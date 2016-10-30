using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Xml.Linq;
using System.IO.Compression;

namespace InteractiveMap
{
    public partial class DrawingTest : Form
    {
        int animDur = 250;//продолжительность 
        bool panelState = true;//true = show, false = hide;
        bool panelMoving = false;//движется ли панель
        Timer panelTimer = new Timer();
        int panWidth;

        public DrawingTest()
        {
            InitializeComponent();
            //Anim1();
        }

        private void DrawingTest_Load(object sender, EventArgs e)
        {
            panelTimer.Interval = 10;
            panelTimer.Tick += new EventHandler(panelTimerTick);
            label2.Text = panel1.Location.X.ToString();
            panWidth = panel1.Size.Width;
            //MessageBox.Show(this.Size.Width.ToString());
            //maxWidth = DrawingTest.ActiveForm.Size.Width;
            //panWidth = 0;
        }

        private void xmlCreate()
        {
            XDocument xDoc = new XDocument();

            XElement root = new XElement("Places");

            XElement place = new XElement("place",
                new XAttribute("id", 111),
                new XElement("header", "Заголовок"),
                new XElement("description", "Описание"),
                new XElement("image", "1.png"),
                new XElement("markerType", 3),
                new XElement("lat", 1.04756d),
                new XElement("lon", 1.11876d)
                );

            root.Add(place);
            xDoc.Add(root);
            xDoc.Save("db.xml");
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

        private void panelTimerTick(object sender, EventArgs e)
        {
            //1000 ms
            int step = panWidth / (animDur / panelTimer.Interval);

            //panelState -> true = show, false = hide;
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
                    label2.Text = panel1.Location.X.ToString();
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
                    }
                    label2.Text = panel1.Location.X.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //xmlLoad();
            pictureBox2.Image = Image.FromFile("1.img");
        }

        private void Anim1()
        {
            Opacity = 0;
            Timer timer = new Timer();
            timer.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.05d) == 1) timer.Stop();
            });
            timer.Interval = 100;
            timer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //скрыть
            if (panelState)
            {
                //panelState = true;
                panelMoving = true;
                panelTimer.Start();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //показать
            if (!panelState)
            {
                //panelState = false;
                panelMoving = true;
                panelTimer.Start();
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            textBox2.Text = trackBar1.Value.ToString();
            animDur = trackBar1.Value;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            xmlCreate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            zipFolder("tfold", "arch.zip");
        }

        void zipFolder(string folder, string destination)
        {
            ZipFile.CreateFromDirectory(folder, destination);
        }

        void unZipFolder(string archSource, string destination)
        {
            ZipFile.ExtractToDirectory(archSource, destination);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            unZipFolder("arch.zip", "destFold");
            try
            {
                pictureBox2.Image = Image.FromFile("destFold/1.img");
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
    }

}
