using System;
using System.Net;
using System.Windows.Forms;

namespace E3Modz.Login___Home
{
    public partial class ChangeLog : Form
    {
        public ChangeLog()
        {
            InitializeComponent();
        }

        private void Button35_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button36_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }

        private void ChangeLog_Load(object sender, EventArgs e)
        {
            WebClient web = new WebClient();
            System.IO.Stream stream = web.OpenRead("https://powermoddingteam.com/assets/Vortex/News.txt");
            using (System.IO.StreamReader reader = new System.IO.StreamReader(stream))
            {
                String text = reader.ReadToEnd();
              
                richTextBox1.Text = text;
                
            }
        }
    }
}
