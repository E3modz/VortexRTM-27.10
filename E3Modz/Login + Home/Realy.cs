using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E3Modz.Login___Home
{
    public partial class Realy : Form
    {
        public static string failed = "";
        public Realy()
        {
            InitializeComponent();
        }
        private string randomNum1()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            return randomNumber.ToString();
        }
        private string randomNum2()
        {
            Random random = new Random();
            int randomNumber = random.Next(30, 100);
            return randomNumber.ToString();
        }
        private void Realy_Load(object sender, EventArgs e)
        {
            label3.Text = randomNum1();
            label5.Text = randomNum2();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == label3.Text + label5.Text)
                {
                    MessageBox.Show("Verifed");
                    Dashboard.hasVerifed = true;
                    new Dashboard().Show();
                    this.Hide();
                }
                else
                {
                    if (failed == "0")
                    {
                        MessageBox.Show("Wrong!\nYou have 2 more tries");
                        label3.Text = randomNum1();
                        label5.Text = randomNum2();
                        failed = "1";
                    }
                    else if (failed == "1")
                    {
                        MessageBox.Show("Wrong!\nYou have 1 more tries");
                        label3.Text = randomNum1();
                        label5.Text = randomNum2();
                        failed = "2";
                    }
                    else if (failed == "2")
                    {
                        MessageBox.Show("Wrong!\nYou have 0 more tries");
                        this.Close();
                        failed = "3";
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(label3.Text + label5.Text);
            if (textBox1.Text == label3.Text + label5.Text)
            {
                MessageBox.Show("Verifed");
                Dashboard.hasVerifed = true;
                new Dashboard().Show();
                this.Hide();
            }
            else
            {
                if (failed == "0")
                {
                    MessageBox.Show("Wrong!\nYou have 2 more tries");
                    label3.Text = randomNum1();
                    label5.Text = randomNum2();
                    failed = "1";
                }
                else if (failed == "1")
                {
                    MessageBox.Show("Wrong!\nYou have 1 more tries");
                    label3.Text = randomNum1();
                    label5.Text = randomNum2();
                    failed = "2";
                }
                else if (failed == "2")
                {
                    MessageBox.Show("Wrong!\nYou have 0 more tries");
                    this.Close();
                    failed = "3";
                }
            }
        }
    }
}

    