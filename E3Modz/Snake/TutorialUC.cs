using System;
using System.Windows.Forms;

namespace Snake
{
    public partial class TutorialUC : UserControl
    {
        public mainForm homeForm { get; set; }

        public TutorialUC()
        {
            InitializeComponent();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            homeForm.Show();
            homeForm.SnekGame();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            homeForm.Show();
            homeForm.Home();
        }
    }
}
