using System;
using System.Windows.Forms;

namespace Snake
{
    public partial class HomeUC : UserControl
    {
        public mainForm homeForm { get; set; }

        public HomeUC()
        {
            InitializeComponent();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            homeForm.Show();
            homeForm.SnekGame();
        }

        private void btn_Tutorial_Click(object sender, EventArgs e)
        {
            homeForm.Show();
            homeForm.Tutorial();
        }
    }
}
