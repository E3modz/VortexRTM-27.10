using E3Modz.Black_Ops_3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E3Modz.ConsoleManager
{
    public partial class AddNewConsole : Form
    {
        public AddNewConsole()
        {
            InitializeComponent();
        }
        private void checkifexist()
        {
            Properties.Settings.Default.IP1 = textBox2.Text;
            Properties.Settings.Default.bool1 = true;
            Properties.Settings.Default.Save();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                checkifexist();
                MessageBox.Show("Console sucessfully added!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                HenCidChanger h = new HenCidChanger();
                h.Show();

            }
            catch
            {
                MessageBox.Show("An unkown error!\n Please restart the RTM Tool and Try again!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void AddNewConsole_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            AddNewConsole h = new AddNewConsole();
            h.Show();
            this.Hide();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }
    }
}
