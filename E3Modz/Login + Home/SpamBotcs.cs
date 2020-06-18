using System;
using System.Windows.Forms;

namespace E3Modz.Login___Home
{
    public partial class SpamBotcs : Form
    {
        public SpamBotcs()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(textBox1.Text + "Spammer by Project Vortex");
            SendKeys.Send("{ENTER}");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
