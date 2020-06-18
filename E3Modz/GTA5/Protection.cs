using E3Modz.Login___Home;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace E3Modz.GTA5
{
    public partial class Protection : Form
    {
        public Protection()
        {
            InitializeComponent();
        }
        private byte[] ModderProtON = new byte[]
        {
            78,
            128,
            0,
            32
        };
        private byte[] ModderProtOFF = new byte[]
        {
            124,
            8,
            2,
            166
        };
        private void Button6_Click(object sender, EventArgs e)
        {

        }

        private void Button42_Click(object sender, EventArgs e)
        {
            if (button42.Text == "OFF")
            {
                button42.Text = "ON";
                button42.ForeColor = Color.Green;
                GTA5Main.PS3.SetMemory(19706264u, this.ModderProtON);
                GTA5Main.PS3.SetMemory(19707228u, this.ModderProtON);
                GTA5Main.PS3.SetMemory(19708208u, this.ModderProtON);
                GTA5Main.PS3.SetMemory(19707660u, this.ModderProtON);
            }
            else if (button42.Text == "ON")
            {
                GTA5Main.PS3.SetMemory(19706264u, this.ModderProtOFF);
                GTA5Main.PS3.SetMemory(19707228u, this.ModderProtOFF);
                GTA5Main.PS3.SetMemory(19708208u, this.ModderProtOFF);
                GTA5Main.PS3.SetMemory(19707660u, this.ModderProtOFF);
                button42.Text = "OFF";
                button42.ForeColor = Color.Red;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "OFF")
            {
                button1.Text = "ON";
                button1.ForeColor = Color.Green;
                GTA5Main.PS3.SetMemory(19682872u, this.ModderProtON);
            }
            else if (button1.Text == "ON")
            {
                GTA5Main.PS3.SetMemory(19682872u, this.ModderProtOFF);
                button1.Text = "OFF";
                button1.ForeColor = Color.Red;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "OFF")
            {
                button3.Text = "ON";
                button3.ForeColor = Color.Green;
                GTA5Main.PS3.SetMemory(19676276u, this.ModderProtON);
                GTA5Main.PS3.SetMemory(19675852u, this.ModderProtON);
            }
            else if (button3.Text == "ON")
            {
                GTA5Main.PS3.SetMemory(19676276u, this.ModderProtOFF);
                GTA5Main.PS3.SetMemory(19675852u, this.ModderProtOFF);
                button3.Text = "OFF";
                button3.ForeColor = Color.Red;
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "OFF")
            {
                button7.Text = "ON";
                button7.ForeColor = Color.Green;
                GTA5Main.PS3.SetMemory(19679812u, this.ModderProtON);
            }
            else if (button7.Text == "ON")
            {
                GTA5Main.PS3.SetMemory(19679812u, this.ModderProtOFF);
                button7.Text = "OFF";
                button7.ForeColor = Color.Red;
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "OFF")
            {
                button9.Text = "ON";
                button9.ForeColor = Color.Green;
                GTA5Main.PS3.SetMemory(19746968u, this.ModderProtON);
            }
            else if (button9.Text == "ON")
            {
                GTA5Main.PS3.SetMemory(19746968u, this.ModderProtOFF);
                button9.Text = "OFF";
                button9.ForeColor = Color.Red;
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {

            if (button11.Text == "OFF")
            {
                button11.Text = "ON";
                button11.ForeColor = Color.Green;
                GTA5Main.PS3.SetMemory(19677500u, this.ModderProtON);
            }
            else if (button11.Text == "ON")
            {
                GTA5Main.PS3.SetMemory(19677500u, this.ModderProtOFF);
                button11.Text = "OFF";
                button11.ForeColor = Color.Red;
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (button13.Text == "OFF")
            {
                button13.Text = "ON";
                button13.ForeColor = Color.Green;
                Main.PS3.SetMemory(19687920u, this.ModderProtON);
            }
            else if (button13.Text == "ON")
            {
                Main.PS3.SetMemory(19687920u, this.ModderProtOFF);
                button13.Text = "OFF";
                button13.ForeColor = Color.Red;
            }
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            if (button17.Text == "OFF")
            {
                button17.Text = "ON";
                button17.ForeColor = Color.Green;
                Main.PS3.SetMemory(19649388u, this.ModderProtON);
            }
            else if (button17.Text == "ON")
            {
                Main.PS3.SetMemory(19649388u, this.ModderProtOFF);
                button17.Text = "OFF";
                button17.ForeColor = Color.Red;
            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            if (button15.Text == "OFF")
            {
                button15.Text = "ON";
                button15.ForeColor = Color.Green;
                Main.PS3.SetMemory(19734056u, this.ModderProtON);
            }
            else if (button15.Text == "ON")
            {
                Main.PS3.SetMemory(19734056u, this.ModderProtOFF);
                button15.Text = "OFF";
                button15.ForeColor = Color.Red;
            }
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            if (button21.Text == "OFF")
            {
                button21.Text = "ON";
                button21.ForeColor = Color.Green;
                Main.PS3.SetMemory(19725800u, this.ModderProtON);
                Main.PS3.SetMemory(19726920u, this.ModderProtON);
            }
            else if (button21.Text == "ON")
            {
                Main.PS3.SetMemory(19725800u, this.ModderProtOFF);
                Main.PS3.SetMemory(19726920u, this.ModderProtOFF);
                button21.Text = "OFF";
                button21.ForeColor = Color.Red;
            }
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            if (button19.Text == "OFF")
            {
                button19.Text = "ON";
                button19.ForeColor = Color.Green;
                Main.PS3.SetMemory(19705448u, this.ModderProtON);
            }
            else if (button19.Text == "ON")
            {
                Main.PS3.SetMemory(19705448u, this.ModderProtOFF);
                button19.Text = "OFF";
                button19.ForeColor = Color.Red;
            }
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            if (button23.Text == "OFF")
            {
                button23.Text = "ON";
                button23.ForeColor = Color.Green;
                Main.PS3.SetMemory(19755852u, this.ModderProtON);
            }
            else if (button23.Text == "ON")
            {
                Main.PS3.SetMemory(19755852u, this.ModderProtOFF);
                button23.Text = "OFF";
                button23.ForeColor = Color.Red;
            }
        }

        private void Button35_Click(object sender, EventArgs e)
        {
            Dashboard h = new Dashboard();
            h.Show();
            this.Hide();
        }

        private void Button36_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "OFF")
            {
                button5.Text = "ON";
                button5.ForeColor = Color.Green;
                GTA5Main.PS3.SetMemory(19755852u, this.ModderProtON);
            }
            else if (button5.Text == "ON")
            {
                GTA5Main.PS3.SetMemory(19755852u, this.ModderProtOFF);
                button5.Text = "OFF";
                button5.ForeColor = Color.Red;
            }
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            if (button25.Text == "OFF")
            {
                button25.Text = "ON";
                button25.ForeColor = Color.Green;
                Main.PS3.SetMemory(19755852u, this.ModderProtON);
            }
            else if (button5.Text == "ON")
            {
                GTA5Main.PS3.SetMemory(19755852u, this.ModderProtOFF);
                button25.Text = "OFF";
                button25.ForeColor = Color.Red;
            }
        }
    }
}
