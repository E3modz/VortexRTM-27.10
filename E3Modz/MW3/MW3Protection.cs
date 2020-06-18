using PS3Lib;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace E3Modz.MW3
{
    public partial class MW3Protection : Form
    {
        PS3API PS3 = new PS3API();
        public MW3Protection()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }

        private void Button42_Click(object sender, EventArgs e)
        {
            if (button42.Text == "OFF")
            {
                button42.ForeColor = Color.Green;
                Funcs.AntiFreeze();
                button42.Text = "ON";
                label5.Text = "80%";

            }
            else if (button42.Text == "ON")
            {
                button42.ForeColor = Color.Red;
                button42.Text = "OFF";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "OFF")
            {
                button1.ForeColor = Color.Green;
                Funcs.AntiFrezze(true);
                button1.Text = "ON";
                label5.Text = "90%";

            }
            else if (button1.Text == "ON")
            {
                button1.ForeColor = Color.Red;
                button1.Text = "OFF";
                Funcs.AntiFrezze(false);
                label5.Text = "0%";
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "OFF")
            {
                button3.ForeColor = Color.Green;
                Funcs.AntiFreezeee();
                button3.Text = "ON";
                label5.Text = "99%";

            }
            else if (button3.Text == "ON")
            {
                button3.ForeColor = Color.Red;
                button3.Text = "OFF";
                label5.Text = "0%";
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (button3.Text == "OFF")
            {
                button5.ForeColor = Color.Green;
                MW3100AntiFreeze.AntiFreezeByE3Modz();
                button3.Text = "ON";
                label5.Text = "100%";

            }
            else if (button3.Text == "ON")
            {
                button5.ForeColor = Color.Red;
                button3.Text = "OFF";
                label5.Text = "0%";
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "OFF")
            {
                button7.ForeColor = Color.Green;
                button7.Text = "ON";



            }
            else if (button7.Text == "ON")
            {
                button7.ForeColor = Color.Red;
                button7.Text = "OFF";
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "OFF")
            {
                byte[] array1 = new byte[32];
                PS3.BlockMemory(0x826731, array1);
                button9.ForeColor = Color.Green;
                button9.Text = "ON";

                MessageBox.Show("if you have this menu your PS3 Will leave every Game!!! Dont enable it when you injected Manace! :D");


            }
            else if (button9.Text == "ON")
            {
                button9.ForeColor = Color.Red;
                button9.Text = "OFF";
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (button11.Text == "OFF")
            {
                button11.ForeColor = Color.Green;
                button11.Text = "ON";
                MessageBox.Show("This option can be shaken when one gets a juggernaut over the streaks");


            }
            else if (button11.Text == "ON")
            {
                button11.ForeColor = Color.Red;
                button11.Text = "OFF";
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (button13.Text == "OFF")
            {
                button13.ForeColor = Color.Green;
                button13.Text = "ON";


            }
            else if (button13.Text == "ON")
            {
                button13.ForeColor = Color.Red;
                button13.Text = "OFF";
            }
        }
    }
}
