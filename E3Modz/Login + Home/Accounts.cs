using System;
using System.Net;
using System.Windows.Forms;

namespace E3Modz.Login___Home
{
    public partial class Accounts : Form
    {
        public Accounts()
        {
            InitializeComponent();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (Spotify.Checked == true)
            {
                WebClient web = new WebClient();
                System.IO.Stream stream = web.OpenRead("https://dayz.planb-life.com/SpotifyAccs.txt");
                using (System.IO.StreamReader reader = new System.IO.StreamReader(stream))
                {
                    String text = reader.ReadToEnd();
                    richTextBox1.Text = text;
                }
            }
            else
            {
                richTextBox1.Text = "";
            }

        }

        private void Button35_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();

        }

        private void Button36_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Netflix_CheckedChanged(object sender, EventArgs e)
        {
            if (Netflix.Checked == true)
            {
                WebClient web = new WebClient();
                System.IO.Stream stream = web.OpenRead("https://dayz.planb-life.com/NetflixAccs.txt");
                using (System.IO.StreamReader reader = new System.IO.StreamReader(stream))
                {
                    String text = reader.ReadToEnd();
                    richTextBox1.Text = text;
                }
            }
            else
            {
                richTextBox1.Text = "";
            }

        }

        private void Amazon_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}