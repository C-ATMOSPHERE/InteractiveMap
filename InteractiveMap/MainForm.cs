using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using System.Xml.Linq;

namespace InteractiveMap
{
    public partial class MainForm : Form
    {
        bool imageSizeNotif = true;//один раз выводим ведомление о размерах изображения
        bool addPointFlag = false;
        int animDur = 250;//продолжительность 
        /// <summary>
        /// true = hide, false = show
        /// </summary>
        bool panelState = false;//true = show, false = hide;
        bool panelMoving = false;//движется ли панель
        int panelId;
        Timer panelTimer = new Timer();
        int panWidth;
        // layers
        readonly GMapOverlay layMain = new GMapOverlay();
        // marker
        List<GMapMarker> Markers;
        PointLatLng mainMapPos;
        Color tmpColor;
        List<InfoPanelContainer> database;
        int COUNTER = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mapSetup(45.02731, 35.08689);

            MainMap.Overlays.Add(layMain);
            Markers = new List<GMapMarker>();
            addMarkers();

            database = new List<InfoPanelContainer>();
            /*currentMarker = new GMarkerGoogle(MainMap.Position, GMarkerGoogleType.arrow);
            currentMarker.IsHitTestVisible = false;
            top.Markers.Add(currentMarker);*/
            panel1.Location = new Point(-208, panel1.Location.Y);
            panelTimer.Interval = 10;
            panelTimer.Tick += new EventHandler(panelTimerTick);
            //label2.Text = panel1.Location.X.ToString();
            panWidth = panel1.Size.Width;
            tmpColor = btnAddPoint.BackColor;
            ////////////////////////////////////////////////////////////////////////////
            comboBox1.DataSource = Enum.GetValues(typeof(GMarkerGoogleType));
            comboBox1.SelectedIndex = 1;
        }

        private void mapSetup(double lat, double lng)
        {
            //Настройки для компонента GMap.

            MainMap.Bearing = 0; //Азимут или наклон карты
            MainMap.CanDragMap = true; //разрешаем перемещение 
            MainMap.DragButton = MouseButtons.Left; //устанавливаем кнопку перемещения карты (ПКМ по умолчанию)
            //gMapControl1.GrayScaleMode = true;
            MainMap.MarkersEnabled = true; //включение пользовательских маркеров
            //Указываем значение макс/мин приближения
            MainMap.MaxZoom = 18;
            MainMap.MinZoom = 2;
            //Устанавливаем центр приближения/удаления
            MainMap.MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter;
            MainMap.NegativeMode = false; //режим негатива (инвертированые цвета, ночной режим)
            MainMap.PolygonsEnabled = true; //Разрешаем полигоны (??)
            MainMap.RoutesEnabled = true; //Разрешаем маршруты
            //gMapControl1.ShowTileGridLines = true; //тайловая 
            MainMap.Zoom = 15; //начальное приближение
            zoom_bar.Value = (int)MainMap.Zoom * 100;
            MainMap.Dock = DockStyle.Fill;//размер окна карты относительно формы

            //Выбираем поставщика карт
            MainMap.MapProvider =
                GMapProviders.GoogleMap;
            //Режим работы (сервер, кеш, смешаный)
            GMaps.Instance.Mode = AccessMode.ServerOnly;

            //Настройка прокси
            GMapProvider.WebProxy = System.Net.WebRequest.GetSystemWebProxy();
            GMapProvider.WebProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
            //Устанавливаем начальную точку
            MainMap.Position = new PointLatLng(lat, lng);

            //устанавливаем зум
            zoom_bar.Minimum = MainMap.MinZoom * 100;
            zoom_bar.Maximum = MainMap.MaxZoom * 100;
            zoom_bar.TickFrequency = 50;

            //Настройка поставщика карт
            String[] mapProvList = { "Google Maps", "Google Maps спутник", "Google Maps гибридный", "Яндекс Карты", "Яндекс Карты спутник", "Яндекс Карты гибридный", "OpenStreer Map" };
            //GMapProviders.
            foreach (string str in mapProvList)
            {
                cb_mapProvider.Items.Add(str);
            }
            cb_mapProvider.SelectedIndex = 0;
        }

        private void panelTimerTick(object sender, EventArgs e)
        {
            /////////////////////////////////////////////////////////////
            //1000 ms
            int step = panWidth / (animDur / panelTimer.Interval);

            //panelState -> true = hide, false = show;
            if (panelMoving)
            {
                if (panelState) //скрывавем
                {
                    if (panel1.Location.X > -panWidth)
                    {
                        panel1.Location = new Point(panel1.Location.X - step, panel1.Location.Y);
                    }
                    else
                    {
                        panelMoving = false;
                        panelState = false;
                        panelTimer.Stop();
                    }
                }
                else //показывавем
                {
                    if (panel1.Location.X < 0)
                    {
                        panel1.Location = new Point(panel1.Location.X + step, panel1.Location.Y);
                    }
                    else
                    {
                        panelMoving = false;
                        panelState = true;
                        panelTimer.Stop();
                        //panel1.Location = new Point(0, panel1.Location.Y);
                    }
                }
            }
            label2.Text = panel1.Location.X.ToString();
        }

        private void addMarkers()
        {
            //Markers.Add(new GMarkerGoogle(MainMap.), GMarkerGoogleType.arrow);
            /*
            Markers.Add(new GMarkerGoogle(new PointLatLng(45.03, 35.09), GMarkerGoogleType.black_small));
            Markers.Add(new GMarkerGoogle(new PointLatLng(45.03, 35.10), GMarkerGoogleType.blue));
            Markers.Add(new GMarkerGoogle(new PointLatLng(45.02, 35.09), GMarkerGoogleType.blue_dot));
            Markers.Add(new GMarkerGoogle(new PointLatLng(45.02, 35.10), GMarkerGoogleType.blue_pushpin));

            foreach(GMapMarker item in Markers)
            {
                layMain.Markers.Add(item);
            }*/
            /*GMapOverlay markers = new GMapOverlay("markers");
            GMapMarker marker =
                new GMarkerGoogle(
                    new PointLatLng(45.02731, 35.08689),
                    GMarkerGoogleType.blue_pushpin);
            marker.ToolTipText = "hello\nout there";
            marker.ToolTip.Fill = Brushes.Black;
            marker.ToolTip.Foreground = Brushes.White;
            marker.ToolTip.Stroke = Pens.Black;
            marker.ToolTip.TextPadding = new Size(20, 20);
            marker.Tag = "m_1445";
            markers.Markers.Add(marker);
            MainMap.Overlays.Add(markers);
            mark_2 = new GMarkerGoogle(new PointLatLng(45.03, 35.09), GMarkerGoogleType.arrow);
            markers.Markers.Add(mark_2);*/
        }

        private void btn_zoom_add_Click(object sender, EventArgs e)
        {
            MainMap.Zoom = ((int)MainMap.Zoom) + 1;
        }

        private void btn_zoom_sub_Click(object sender, EventArgs e)
        {
            MainMap.Zoom = ((int)(MainMap.Zoom + 0.99)) - 1;
        }

        private void zoom_bar_ValueChanged(object sender, EventArgs e)
        {
            MainMap.Zoom = zoom_bar.Value / 100.0;
        }

        private void MainMap_OnMapZoomChanged()
        {
            zoom_bar.Value = (int)(MainMap.Zoom * 100.0);
        }

        private void cb_mapProvider_DropDownClosed(object sender, EventArgs e)
        {
            switch (cb_mapProvider.SelectedItem.ToString())
            {
                case "Google Maps": MainMap.MapProvider = GMapProviders.GoogleMap; break;
                case "Google Maps спутник": MainMap.MapProvider = GMapProviders.GoogleSatelliteMap; break;
                case "Google Maps гибридный": MainMap.MapProvider = GMapProviders.GoogleHybridMap; break;
                case "Яндекс Карты": MainMap.MapProvider = GMapProviders.YandexMap; break;
                case "Яндекс Карты спутник": MainMap.MapProvider = GMapProviders.YandexSatelliteMap; break;
                case "Яндекс Карты гибридный": MainMap.MapProvider = GMapProviders.YandexHybridMap; break;
                case "OpenStreer Map": MainMap.MapProvider = GMapProviders.OpenStreetMap; break;
                default: MainMap.MapProvider = GMapProviders.GoogleMap; break;
            }
        }

        private void MainMap_OnPositionChanged(PointLatLng point)
        {
            mainMapPos = point;
            textBox1.Text = "Lat: " + mainMapPos.Lat.ToString();
            textBox2.Text = "Lng: " + mainMapPos.Lng.ToString();
        }

        private void MainMap_MouseClick(object sender, MouseEventArgs e)
        {
            /*if (e.Button == MouseButtons.Left && addPointFlag)
            {
                if (!panelState) InfoPanelToogle();
                layMain.Markers.Add(new GMarkerGoogle(mainMapPos, (GMarkerGoogleType)comboBox1.SelectedIndex));
            }*/
        }

        private void MainMap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!panelState || ((int)item.Tag != panelId))
                {
                    panelId = (int)item.Tag;

                    foreach (InfoPanelContainer container in database)
                    {
                        if (container.id == panelId)
                        {
                            panelHeader.Text = container.header;
                            panelText.Text = container.mainText;
                            pictureBox1.Image = container.image;
                            break;
                        }
                    }

                    InfoPanelToogle(true);
                }
                else
                {
                    InfoPanelToogle(false);
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (MessageBox.Show("Удалить метку?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dbItemDelete((int)item.Tag);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InfoPanelToogle();
        }

        private void InfoPanelToogle()
        {
            panelMoving = true;
            panelTimer.Start();
        }
        /// <summary>
        /// Открывает либо закрыает инфо панель
        /// </summary>
        /// <param name="openClose">true - открывает false - закрывает</param>
        private void InfoPanelToogle(bool openClose)
        {
            if (panelState ^ openClose)
            //if (panelState == openClose)
            {
                panelMoving = true;
                panelTimer.Start();
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string errorText = "Ошибка!\n";
            bool erFlag = false;
            if (newHeaderText.Text == String.Empty)
            {
                erFlag = true;
                errorText += "Нужно ввести заголовок!\n";
            }
            if (newDescription.Text == String.Empty)
            {
                erFlag = true;
                errorText += "Нужно ввести описание!\n";
            }
            if (prewievImage.Image == null)
            {
                erFlag = true;
                errorText += "Нужно выбрать изображение!\n";
            }
            if (comboBox1.SelectedIndex == 0)
            {
                erFlag = true;
                errorText += "Нужно выбрать тип маркера!";
            }
            if (!erFlag)
            {
                InfoPanelContainer tmpItem;
                tmpItem = new InfoPanelContainer(COUNTER, comboBox1.SelectedIndex, newHeaderText.Text,
                    newDescription.Text, prewievImage.Image);
                database.Add(tmpItem);

                GMapMarker tmpMark = new GMarkerGoogle(mainMapPos, (GMarkerGoogleType)comboBox1.SelectedIndex);
                tmpMark.ToolTipText = newHeaderText.Text;
                tmpMark.Tag = COUNTER;
                layMain.Markers.Add(tmpMark);

                COUNTER++;

                panelHeader.Text = newHeaderText.Text;
                panelText.Text = newDescription.Text;
                pictureBox1.Image = prewievImage.Image;

                InfoPanelToogle(true);
            }
            else
            {
                MessageBox.Show(errorText);
            }
        }

        private void loadImage_Click(object sender, EventArgs e)
        {
            if (imageSizeNotif)
            {
                imageSizeNotif = false;
                MessageBox.Show("Размер изображения должен быть 200x200!");
            }
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Изображения|*.jpg;*.png;*.jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                prewievImage.Image = Image.FromFile(ofd.FileName);
                if (prewievImage.Image.Height != 200 && prewievImage.Image.Width != 200)
                {
                    MessageBox.Show("Изображение не 200x200!\nИзображение будет выведено с искажениями!");
                }
            }
        }

        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            /*addPointFlag = true;
            btnAddPoint.BackColor = Color.Red;
            MainMap.CanDragMap = false;*/
            GMapMarker tmpMark = new GMarkerGoogle(mainMapPos, (GMarkerGoogleType)comboBox1.SelectedIndex);
            tmpMark.ToolTipText = newHeaderText.Text;
            tmpMark.Tag = layMain.Markers.Count;
            layMain.Markers.Add(tmpMark);
        }

        private void dbItemDelete(int id)
        {
            for (int i = 0; i < layMain.Markers.Count; i++)
            {
                if ((int)layMain.Markers[i].Tag == id)
                {
                    layMain.Markers.RemoveAt(i);
                    break;
                }
            }
            for (int i = 0; i < database.Count; i++)
            {
                if (database[i].id == id)
                {
                    database.RemoveAt(i);
                    break;
                }
            }
        }

        private void dbSave()
        {

        }

        GMarkerGoogle getMarker(int id)
        {
            foreach (GMarkerGoogle mark in layMain.Markers)
            {
                if ((int)mark.Tag == id)
                {
                    return mark;
                }
            }
            return null;
        }

        private void xmlSave(string savePath)
        {
            XDocument xDoc = new XDocument();

            XElement root = new XElement("Places");
            XElement place = new XElement("place");

            foreach (InfoPanelContainer cont in database)
            {
                double lat, lon;
                place = new XElement("place");
                place.Add(new XAttribute("id", cont.id));
                place.Add(new XElement("header", cont.header));
                place.Add(new XElement("description", cont.mainText));
                place.Add(new XElement("image", "1.png"));
                place.Add(new XElement("markerType", cont.markerType));
                try
                {
                    lat = getMarker(cont.id).Position.Lat;
                    lon = getMarker(cont.id).Position.Lng;
                }
                catch
                {
                    MessageBox.Show("Ошибка при доступе к координатам маркера!");
                    return;
                }

                place.Add(new XElement("lat", lat));
                place.Add(new XElement("lon", lon));

                root.Add(place);
            }

            xDoc.Add(root);
            xDoc.Save(savePath);
        }

        private void xmlLoad()
        {
            XDocument xDoc = XDocument.Load("database.xml");
            String str = "";

            foreach (XElement elem in xDoc.Element("Places").Elements("place"))
            {
                XAttribute attr = elem.Attribute("id");
                XElement elem1 = elem.Element("header");
                XElement elem2 = elem.Element("description");

                str += attr.Value + "; ";
                str += elem1.Value + "; ";
                str += elem2.Value + ";\n";
            }
            MessageBox.Show(str);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                InfoPanelToogle(false);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //markers
        }

        private void test1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string outStr = "";
            foreach (GMapMarker item in layMain.Markers)
            {
                outStr += item.Position.ToString() + " ! ";
                try
                {
                    outStr += item.Tag.ToString() + " ! ";
                }
                catch (Exception error)
                {
                    outStr += error.ToString() + " ! ";
                }
                outStr += item.ToolTipText + "\n";
                item.ToolTipText += "_";
            }
            MessageBox.Show(outStr);
        }

        private void infoShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoPanelToogle(true);
        }

        private void infoHideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoPanelToogle(false);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //label2.Text = panelState.ToString();
        }

        private void сохранитьБазуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dbSave();
            xmlSave("db.xml");
        }


    }
}
