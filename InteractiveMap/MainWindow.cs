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
        int animDur = 8;
        bool panelState = false;
        bool panelMoving = false;
        int panelId;
        Timer panelTimer = new Timer();
        int panWidth;
        readonly GMapOverlay layMain = new GMapOverlay();
        List<GMapMarker> Markers;
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
            database = new List<InfoPanelContainer>();
            panel1.Location = new Point(-208, panel1.Location.Y);
            panelTimer.Interval = 1;
            panelTimer.Tick += new EventHandler(panelTimerTick);
            panWidth = panel1.Size.Width;
            dbLoad("final.db");
            GMaps.Instance.ImportFromGMDB("StaryCrym.gmdb");
            MainMap.Manager.Mode = AccessMode.CacheOnly;
        }

        private void mapSetup(double lat, double lng)
        {
            MainMap.Bearing = 0;
            MainMap.CanDragMap = true;
            MainMap.DragButton = MouseButtons.Left;
            MainMap.MarkersEnabled = true;
            MainMap.MaxZoom = 18;
            MainMap.MinZoom = 2;
            MainMap.MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter;
            MainMap.NegativeMode = false;
            MainMap.PolygonsEnabled = true;
            MainMap.RoutesEnabled = true;
            MainMap.Zoom = 15;
            MainMap.Dock = DockStyle.Fill;
            MainMap.Manager.Mode = AccessMode.ServerAndCache;
            MainMap.MapProvider = GMapProviders.OpenStreetMap;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            GMapProvider.WebProxy = System.Net.WebRequest.GetSystemWebProxy();
            GMapProvider.WebProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
            MainMap.Position = new PointLatLng(lat, lng);
        }

        private void panelTimerTick(object sender, EventArgs e)
        {
            int step = panWidth / (animDur / panelTimer.Interval);
            if (panelMoving)
            {
                if (panelState)
                {
                    if (panel1.Location.X > -panWidth)
                    {
                        panel1.Location = new Point(panel1.Location.X - step, panel1.Location.Y);
                    }
                    else{
                        panelMoving = false;
                        panelState = false;
                        panelTimer.Stop();
                    }
                }
                else{
                    if (panel1.Location.X < 0)
                    {
                        panel1.Location = new Point(panel1.Location.X + step, panel1.Location.Y);
                    }
                    else{
                        panelMoving = false;
                        panelState = true;
                        panelTimer.Stop();
                    }
                }
            }
        }

        private void InfoPanelToogle()
        {
            panelMoving = true;
            panelTimer.Start();
        }

        private void InfoPanelToogle(bool openClose)
        {
            if (panelState ^ openClose)
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
            try
            {
                unZipFolder(loadPath, _FOLDER);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
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
            database.Clear();
            layMain.Markers.Clear();

            try
            {
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
                    tmp.ToolTipText = elem.Element("header").Value;
                    layMain.Markers.Add(tmp);

                    counter++;
                }
                COUNTER = counter;
                Application.CurrentCulture = new System.Globalization.CultureInfo("ru-RU");
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка чтения из базы данных!\n" + e.ToString());
            }
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

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Directory.Exists(_FOLDER))
            {
                Directory.Delete(_FOLDER, true);
            }
        }

        private void MainMap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
                panelId = (int)item.Tag;

                foreach (InfoPanelContainer container in database)
                {
                    if (container.id == panelId)
                    {
                        InfoWindow w1 = new InfoWindow(container.image, container.header, container.mainText);
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

        private void about_Click(object sender, EventArgs e)
        {
            aboutWindow inf = new aboutWindow();
            inf.ShowDialog();
        }
    }
}
