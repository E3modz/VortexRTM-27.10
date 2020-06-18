using E3Modz.Black_Ops_2;
using System;
using System.Windows.Forms;

namespace E3Modz.Login___Home
{
    public partial class BO3_Selector : Form
    {
        public static System.Drawing.Point newpoint = new System.Drawing.Point();
        public static string Username;
        public static string Password;
        public static int x;
        public static int y;
        public BO3_Selector()
        {
            InitializeComponent();
        }

        private void Button35_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            Bo3EbootBuilder eboot = new Bo3EbootBuilder();
            eboot.Show();
            this.Hide();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Main bo3 = new Main();
            bo3.Show();
            this.Hide();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            BO3Zombies zm = new BO3Zombies();
            zm.Show();
            this.Hide();
        }

        private void FlowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            BO3_Selector.x = Control.MousePosition.X - base.Location.X;
            BO3_Selector.y = Control.MousePosition.Y - base.Location.Y;
        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FlowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BO3_Selector.newpoint = Control.MousePosition;
                BO3_Selector.newpoint.X -= BO3_Selector.x;
                BO3_Selector.newpoint.Y -= BO3_Selector.y;
                base.Location = BO3_Selector.newpoint;
            }
        }

        private void BO3_Selector_Load(object sender, EventArgs e)
        {

        }
    }
}
