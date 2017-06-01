using System;
using System.Windows.Forms;

namespace InteractiveMap
{
    public partial class aboutWindow : Form
    {
        public aboutWindow()
        {
            InitializeComponent();
        }

        private void aboutWindow_Load(object sender, EventArgs e)
        {
            label1.Text = "Интерактивная карта\nСтарого Крыма";
            label2.Text = "Автор:\n2017г";
        }
    }
}
