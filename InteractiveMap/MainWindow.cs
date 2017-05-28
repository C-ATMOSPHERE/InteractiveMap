using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Xml.Linq;

namespace InteractiveMap
{
    public partial class MainWindow : Form
    {
        bool imageSizeNotif = true;//один раз выводим ведомление о размерах изображения
        int animDur = 100;//продолжительность 
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
        List<InfoPanelContainer> database;
        int COUNTER = 0;
        string _FOLDER = "tmpFolder";
        string _FILENAME = "db.xml";

        public MainWindow()
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
            MainMap.Dock = DockStyle.Fill;//размер окна карты относительно формы
            MainMap.Manager.Mode = AccessMode.ServerAndCache;

            //Выбираем поставщика карт
            MainMap.MapProvider = GMapProviders.OpenStreetMap;
            //Режим работы (сервер, кеш, смешаный)
            GMaps.Instance.Mode = AccessMode.ServerAndCache;

            //Настройка прокси
            GMapProvider.WebProxy = System.Net.WebRequest.GetSystemWebProxy();
            GMapProvider.WebProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
            //Устанавливаем начальную точку
            MainMap.Position = new PointLatLng(lat, lng);
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

        private void MainMap_MouseClick(object sender, MouseEventArgs e)
        {
            /*if (e.Button == MouseButtons.Left && addPointFlag)
            {
                if (!panelState) InfoPanelToogle();
                layMain.Markers.Add(new GMarkerGoogle(mainMapPos, (GMarkerGoogleType)comboBox1.SelectedIndex));
            }*/
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

        private void dbLoad(string loadPath)
        {
            if (Directory.Exists(_FOLDER))
            {
                Directory.Delete(_FOLDER, true);
            }
            //распаковываем
            try
            {
                unZipFolder(loadPath, _FOLDER);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            //Считываем данные
            XDocument xDoc = new XDocument();
            try
            {
                xDoc = XDocument.Load(_FOLDER + "/" + _FILENAME);
            }
            catch
            {
                MessageBox.Show("Не удалось загрузить файл!");
            }

            int counter = 0;
            database.Clear();////////////////////////////сохранить базу до успешной загурзки!
            layMain.Markers.Clear();/////////////////////сохранить базу до успешной загурзки!

            try
            {
                //Устаналиваем локаль (влияет на десятичный разделитель: точка - американский, запятая - русский)
                Application.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                foreach (XElement elem in xDoc.Element("Places").Elements("place"))
                {
                    database.Add(new InfoPanelContainer(
                        int.Parse(elem.Attribute("id").Value),
                        int.Parse(elem.Element("markerType").Value),
                        elem.Element("header").Value,
                        elem.Element("description").Value,
                        loadImage(_FOLDER + "/" + elem.Element("image").Value)
                        ));
                    GMarkerGoogle tmp = new GMarkerGoogle(
                        new PointLatLng(
                            double.Parse(elem.Element("lat").Value),
                            double.Parse(elem.Element("lon").Value)),
                        (GMarkerGoogleType)int.Parse(elem.Element("markerType").Value)
                        );
                    tmp.Tag = int.Parse(elem.Attribute("id").Value);
                    layMain.Markers.Add(tmp);

                    counter++;
                }
                COUNTER = counter;
                Application.CurrentCulture = new System.Globalization.CultureInfo("ru-RU");
                MessageBox.Show("Загрузка успешно завершена.\nЗагржено файлов: " + counter.ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка чтения из базы данных!\n" + e.ToString());
            }
            //Удаляем временные файлы
            try
            {
                Directory.Delete(_FOLDER, true);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        Image loadImage(string path)
        {
            FileStream imgStream = File.OpenRead(path);
            Image img = Image.FromStream(imgStream);
            imgStream.Close();
            return img;
        }

        void zipFolder(string folder, string destination)
        {
            ZipFile.CreateFromDirectory(folder, destination);
        }

        void unZipFolder(string archSource, string destination)
        {
            ZipFile.ExtractToDirectory(archSource, destination);
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

        private void загрузитьБазуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "База данных|*.db|Все файлы|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                dbLoad(ofd.FileName);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Directory.Exists(_FOLDER))
            {
                Directory.Delete(_FOLDER, true);
            }
        }

        private void сохранитьКэшToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainMap.ShowExportDialog();
        }

        private void загрузитьКэшToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainMap.ShowImportDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
                panelId = (int)item.Tag;

                foreach (InfoPanelContainer container in database)
                {
                    if (container.id == panelId)
                    {
                        InfoWindow w1 = new InfoWindow(container.image, container.header, container.mainText);
                    //w1.Show();
                    w1.ShowDialog();
                        break;
                    }
                }
        }

        private void MainMap_OnMarkerEnter(GMapMarker item)
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

        private void MainMap_OnMarkerLeave(GMapMarker item)
        {
            InfoPanelToogle(false);
        }
    }
}
