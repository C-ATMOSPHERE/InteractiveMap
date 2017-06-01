using System;
using System.Drawing;
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
            Text = header;
            ActiveForm.Text = header;
            InfoCaption.Text = header;
            InfoText.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
