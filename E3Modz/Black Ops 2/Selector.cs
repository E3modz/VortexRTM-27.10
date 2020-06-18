using E3Modz.Login___Home;
using System;
using System.Windows.Forms;

namespace E3Modz.Black_Ops_2
{
    public partial class Selector : Form
    {
        public Selector()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            BO2 MP = new BO2();
            MP.Show();
            this.Hide();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Zombies ZM = new Zombies();
            ZM.Show();
            this.Hide();
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

        private void Label3_Click(object sender, EventArgs e)
        {
            EBootBuilderBo2 eboot = new EBootBuilderBo2();
            eboot.Show();
            this.Hide();
        }

        private void Selector_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            BO2 B = new BO2();
            B.Show();
            this.Hide();
        }
    }
}
