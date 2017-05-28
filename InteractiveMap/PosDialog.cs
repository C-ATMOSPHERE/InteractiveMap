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
    public partial class PosDialog : Form
    {
        public float lat = 0, lon = 0;

        public PosDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox3.Text != "")
            {
                string str;
                string[] strr;
                str = textBox3.Text;
                str = str.Replace('.', ',');
                strr = str.Split(' ');
                strr[0] = strr[0].Substring(1);
                strr[1] = strr[1].Substring(1);
                float.TryParse(strr[0], out lat);
                float.TryParse(strr[1], out lon);
            }
            DialogResult = DialogResult.OK;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            str = str.Replace('.', ',');
            float.TryParse(str, out lat);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var str = textBox2.Text;
            str = str.Replace('.', ',');
            float.TryParse(str, out lon);
        }
    }
}
