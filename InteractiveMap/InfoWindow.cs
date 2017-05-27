using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteractiveMap
{
    public partial class InfoWindow : Form
    {
        public InfoWindow()
        {
            InitializeComponent();
        }

        public InfoWindow(Image img, string header, string text)
        {
            InitializeComponent();
            InfoImage.Image = img;
            ActiveForm.Text = header;
            InfoCaption.Text = header;
            InfoText.Text = text;
        }

        private void InfoWindow_Load(object sender, EventArgs e)
        {

        }

        byte infImgCount = 0;
        private void InfoImage_Click(object sender, EventArgs e)
        {
            infImgCount++;
            if (infImgCount > 4) infImgCount = 0;
            InfoImage.SizeMode =  (PictureBoxSizeMode)infImgCount;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
