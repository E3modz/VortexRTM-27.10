using E3Modz.Login___Home;
using System;
using System.Windows.Forms;

namespace E3Modz.BO1
{
    public partial class BO1Selector : Form
    {
        public static System.Drawing.Point newpoint = new System.Drawing.Point();
        public static string Username;
        public static string Password;
        public static int x;
        public static int y;
        public BO1Selector()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Dashboard h = new Dashboard();
            h.Show();
            this.Hide();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            E3Modz.Login___Home.BO1 bo = new E3Modz.Login___Home.BO1();
            bo.Show();
            this.Hide();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Bo1Zombies zm = new Bo1Zombies();
            zm.Show();
            this.Hide();
        }

        private void BO1Selector_Load(object sender, EventArgs e)
        {

        }

        private void Panel7_MouseDown(object sender, MouseEventArgs e)
        {
            BO1Selector.x = Control.MousePosition.X - base.Location.X;
            BO1Selector.y = Control.MousePosition.Y - base.Location.Y;
        }

        private void Panel7_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BO1Selector.newpoint = Control.MousePosition;
                BO1Selector.newpoint.X -= BO1Selector.x;
                BO1Selector.newpoint.Y -= BO1Selector.y;
                base.Location = BO1Selector.newpoint;
            }
        }

        private void Panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {
            BO1E3bootBuilder eboot = new BO1E3bootBuilder();
            eboot.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            E3Modz.Login___Home.BO1 bo = new E3Modz.Login___Home.BO1();
            bo.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            E3Modz.Login___Home.BO1 bo = new E3Modz.Login___Home.BO1();
            bo.Show();
            this.Hide();
        }
    }
}
