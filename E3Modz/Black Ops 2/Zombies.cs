using E3Modz.Login___Home;
using PS3Lib;
using System;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
namespace E3Modz.Black_Ops_2
{
    public partial class Zombies : Form
    {
        uint G_Client = (0x18C42E8);
        uint G_Client_Size = (0x61E0);
        uint selected_client = (0);
        public static PS3API PS3 = new PS3API(SelectAPI.ControlConsole);
        public static PS3ManagerAPI.PS3MAPI PS3M_API = new PS3ManagerAPI.PS3MAPI();
        public Zombies()
        {
            InitializeComponent();
        }

        private void Zombies_Load(object sender, EventArgs e)
        {
            groupBox9.Visible = false;
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                PS3.ChangeAPI(SelectAPI.ControlConsole);
                groupBox9.Visible = true;
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                PS3.ChangeAPI(SelectAPI.TargetManager);
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (PS3.ConnectTarget())
            {
                MessageBox.Show("Succesfully Connected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label22.Text = PS3.CCAPI.GetTemperatureCELL();
                label23.Text = PS3.CCAPI.GetTemperatureRSX();
                label24.Text = PS3.CCAPI.GetFirmwareVersion();
                label25.Text = PS3.CCAPI.GetFirmwareType();
                label27.Text = "Connected! Awaiting Attach Process";
                label27.ForeColor = Color.Yellow;
            }
            else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void E3PrivateNotify(string textHeader, string text, string Shader)
        {
            Zombies.PS3.SetMemory(29490803u, new byte[]
            {
                40
            });
            Zombies.PS3.Extension.WriteString(29490277u, textHeader);
            Zombies.PS3.Extension.WriteString(29490789u, Shader);
            Zombies.PS3.Extension.WriteString(29490533u, text);
            Zombies.PS3.SetMemory(29491046u, new byte[]
            {
                0,
                0,
                0,
                0,
                51,
                51,
                51,
                51,
                51,
                51,
                51,
                51,
                51,
                51,
                51,
                0,
                0,
                0,
                0,
                0,
                0,
                1,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0,
                0
            });
            Zombies.PS3.SetMemory(13959205u, new byte[]
            {
                32
            });
            Thread.Sleep(2500);
            PS3API ps = Zombies.PS3;
            uint offset = 29491046u;
            byte[] array = new byte[32];
            array[21] = 1;
            ps.SetMemory(offset, array);
            Zombies.PS3.Extension.WriteString(29490533u, "");
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            if (PS3.AttachProcess())
            {
                label27.Text = "Ready to Mod!";
                label27.ForeColor = Color.Green;
                this.PSNName.Text = PS3.Extension.ReadString(40633944);
                PS3.Extension.WriteString(0x8E3290, "^5Project ^2Vortex ^1Zombies");
                byte[] buffer1 = new byte[4];
                buffer1[0] = 0x60;
                PS3.SetMemory(0x37FEC, buffer1);
                E3PrivateNotify("^2ProjectVortex\0", "^1Zombies<3\0", "lui_loader_no_offset");
                E3PrivateNotify("^5Welcome User:\0", PSNName.Text + "\0", "lui_loader_no_offset");
                MessageBox.Show("Attached!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            ZombieRPC.Init();
            MessageBox.Show("RPC Enabled!", "Have Fun!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            PS3.DisconnectTarget();
            MessageBox.Show("Sucessfully");
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            PS3.TMAPI.PowerOff(true);
            PS3.CCAPI.ShutDown(CCAPI.RebootFlags.ShutDown);
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(this.textBox1.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(40633944u, bytes);
            PS3.SetMemory(40633983u, bytes);
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (button12.Text == "Flash?")
            {
                FlashName.Start();
                button12.Text = "Flash ON";
            }
            else if (button12.Text == "Flash ON")
            {
                FlashName.Stop();
                button12.Text = "Flash?";
            }
        }

        private void FlashName_Tick(object sender, EventArgs e)
        {
            base.Name = this.textBox1.Text;
            int num = new Random().Next(0, 9);
            PS3.SetMemory(40633944u, Encoding.ASCII.GetBytes("^" + num.ToString() + base.Name + "\0"));
            PS3.SetMemory(40633983u, Encoding.ASCII.GetBytes("^" + num.ToString() + base.Name + "\0"));
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            ZombieRPC.CBuf_Addtext(";cmd userinfo \"\\clanAbbrev\\" + this.textBox2.Text + "\\name\\" + this.textBox2.Text);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            if (button16.Text == "Anti Ban OFF")
            {
                PS3.SetMemory(0x50CA9F, new byte[] { 0x99 });
                PS3.SetMemory(0x4BAA20, new byte[] { 0x48, 0x00, });
                PS3.SetMemory(0x50DD2C, new byte[] { 0x48, 0x00, });
                PS3.SetMemory(0x50CACC, new byte[] { 0x48, 0x80, });
                PS3.SetMemory(0x50E184, new byte[] { 0x60, 0x00, 0x00, 0x00 });
                PS3.SetMemory(0x54A4E4, new byte[] { 0x60, 0x00, 0x00, 0x00 });
                PS3.SetMemory(0x54A858, new byte[] { 0x60, 0x00, 0x00, 0x00 });
                PS3.SetMemory(0x5327F8, new byte[] { 0x60, 0x00, 0x00, 0x00 });
                PS3.SetMemory(0x532804, new byte[] { 0x60, 0x00, 0x00, 0x00 });
                PS3.SetMemory(0x52FE74, new byte[] { 0x41, 0x80 });
                PS3.Extension.WriteUInt32(0x3DBD54, 0x480000D8);
                PS3.SetMemory(0x003DC634, new byte[] { 0x60, 0x00, 0x00, 0x00 }); //DisableRSAProtection
                PS3.SetMemory(0x003DC634, new byte[] { 0x48, 0x00, 0x00, 0xD8 });
                button16.Text = "Anti Ban ON";
            }
            else if (button16.Text == "Anti Ban ON")
            {
                PS3.SetMemory(0x50CA9F, new byte[] { 0x99 });
                PS3.SetMemory(0x4BAA20, new byte[] { 0x48, 0x00, });
                PS3.SetMemory(0x50DD2C, new byte[] { 0x48, 0x00, });
                PS3.SetMemory(0x50CACC, new byte[] { 0x48, 0x80, });
                PS3.SetMemory(0x50E184, new byte[] { 0x60, 0x00, 0x00, 0x00 });
                PS3.SetMemory(0x54A4E4, new byte[] { 0x60, 0x00, 0x00, 0x00 });
                PS3.SetMemory(0x54A858, new byte[] { 0x60, 0x00, 0x00, 0x00 });
                PS3.SetMemory(0x5327F8, new byte[] { 0x60, 0x00, 0x00, 0x00 });
                PS3.SetMemory(0x532804, new byte[] { 0x60, 0x00, 0x00, 0x00 });
                PS3.SetMemory(0x52FE74, new byte[] { 0x41, 0x82 });
                PS3.SetMemory(0x003DC634, new byte[] { 0x88, 0x63, 0x00, 0x18 }); //DisableRSAProtection
                PS3.SetMemory(0x003DC634, new byte[] { 0x60, 0x7C, 0x00, 0x00 });
                button16.Text = "Anti Ban OFF";
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

        private void Button14_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void EnableToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EnableToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[]
            {
                5
            };
            PS3.SetMemory((uint)(24645443 + this.dataGridView1.CurrentRow.Index * 22536), buffer);
            ZombieRPC.Call(0x0349F6C, this.dataGridView1.CurrentRow.Index, 0, "O " + "GodMode^2Enabled");
        }
        public string GetName(int ClientNum)
        {

            byte[] array = new byte[20];
            PS3.GetMemory((uint)(G_Client + G_Client_Size * ClientNum + 0x350), array);
            string @string = Encoding.ASCII.GetString(array);
            return @string.Replace("\0", "");
        }
        private void Button17_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Enabled = true;
            this.dataGridView1.RowCount = 4;
            for (int i = 0; i < 4; i++)
            {
                this.dataGridView1.Update();
                this.dataGridView1.Rows[i].Cells[0].Value = i;
                this.dataGridView1.Rows[i].Cells[1].Value = this.GetName(i);
            }
        }

        private void EnabledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[]
            {
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue,

            };
            PS3.SetMemory((uint)(24646493 + this.dataGridView1.CurrentRow.Index * 22536), buffer);

            PS3.SetMemory((uint)(24646497 + this.dataGridView1.CurrentRow.Index * 22536), buffer);

            PS3.SetMemory((uint)(24646485 + this.dataGridView1.CurrentRow.Index * 22536), buffer);

            PS3.SetMemory((uint)(24646425 + this.dataGridView1.CurrentRow.Index * 22536), buffer);

            PS3.SetMemory((uint)(24646489 + this.dataGridView1.CurrentRow.Index * 22536), buffer);

            PS3.SetMemory((uint)(24646501 + this.dataGridView1.CurrentRow.Index * 22536), buffer);
            ZombieRPC.Call(0x0349F6C, this.dataGridView1.CurrentRow.Index, 0, "O " + "UnlimitedAmmo^2Enabled");
        }
        //round 0x160B093
        private void Button18_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(0x160B093, BitConverter.GetBytes((int)numericUpDown1.Value));
        }

        private void MaxPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[]
        {
                15,
                66,
                64
        };
            PS3.SetMemory((uint)(24667393 + this.dataGridView1.CurrentRow.Index * 22536), buffer);
            ZombieRPC.Call(0x0349F6C, this.dataGridView1.CurrentRow.Index, 0, "O " + "MaxPoints:^2Enabled");
        }

        private void EnabledToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[1];
            PS3.SetMemory((uint)(24666979 + this.dataGridView1.CurrentRow.Index * 22536), buffer);
            ZombieRPC.Call(0x0349F6C, this.dataGridView1.CurrentRow.Index, 0, "O " + "InternetSetTO:^1-9999Ping");
        }

        private void DisabledToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[]
            {
                2
            };
            PS3.SetMemory((uint)(24666979 + this.dataGridView1.CurrentRow.Index * 22536), buffer);
            ZombieRPC.Call(0x0349F6C, this.dataGridView1.CurrentRow.Index, 0, "O " + "InternetSetTO:^2-129msPing");
        }

        private void KillHimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[]
            {
                70
            };
            PS3.SetMemory((uint)(24645464 + this.dataGridView1.CurrentRow.Index * 22536), buffer);
            ZombieRPC.Call(0x0349F6C, this.dataGridView1.CurrentRow.Index, 0, "O " + "^1YouHaveBeenKilled");

        }

        private void KickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZombieRPC.Call(0x0349F6C, this.dataGridView1.CurrentRow.Index, 0, "O " + "^1YouWillBeKickedIn5Seconds!ByeBye!");
            Thread.Sleep(3000);
            byte[] buffer = new byte[]
        {
                byte.MaxValue
        };
            PS3.SetMemory((uint)(24645775 + this.dataGridView1.CurrentRow.Index * 22536), buffer);

        }

        private void DefaultWeaponToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[]
            {
                1
            };
            PS3.SetMemory((uint)(24646087 + this.dataGridView1.CurrentRow.Index * 22536), buffer);
            ZombieRPC.Call(0x0349F6C, this.dataGridView1.CurrentRow.Index, 0, "O " + "DeafultWeapon^2Given");
        }

        private void PointersMarkIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[]
            {
                78
            };
            PS3.SetMemory((uint)(24646087 + this.dataGridView1.CurrentRow.Index * 22536), buffer);
            ZombieRPC.Call(0x0349F6C, this.dataGridView1.CurrentRow.Index, 0, "O " + "PointersMarkI^2Given");
        }

        private void PointersMarkIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[]
            {
                77
            };
            PS3.SetMemory((uint)(24646087 + this.dataGridView1.CurrentRow.Index * 22536), buffer);
        }

        private void EnableToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[]
         {
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue,

         };
            PS3.SetMemory((uint)(24646493 + this.dataGridView1.CurrentRow.Index * 22536), buffer);

            PS3.SetMemory((uint)(24646497 + this.dataGridView1.CurrentRow.Index * 22536), buffer);

            PS3.SetMemory((uint)(24646485 + this.dataGridView1.CurrentRow.Index * 22536), buffer);

            PS3.SetMemory((uint)(24646425 + this.dataGridView1.CurrentRow.Index * 22536), buffer);

            PS3.SetMemory((uint)(24646489 + this.dataGridView1.CurrentRow.Index * 22536), buffer);

            PS3.SetMemory((uint)(24646501 + this.dataGridView1.CurrentRow.Index * 22536), buffer);
            ZombieRPC.Call(0x0349F6C, this.dataGridView1.CurrentRow.Index, 0, "O " + "UnlimitedAmmo^2Enabled");
        }
        private void freezePlayer(int P)
        {
            ZombieRPC.Call(0x0349F6C, this.dataGridView1.CurrentRow.Index, 0, "O " + "YourPS3WillBeFreezeIn5Seconds^2ByeBye!");
            ZombieRPC.Call(0x0349F6C, this.dataGridView1.CurrentRow.Index, 0, "< " + "YourPS3WillBeFreezeIn5Seconds^2ByeBye!");
            Thread.Sleep(2500);
            ZombieRPC.SV_GameSendServerCommand(P, "^ 6 70 90");
        }
        private void GiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            freezePlayer(this.dataGridView1.CurrentRow.Index);
        }

        private void EnableToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[]
           {
                5
           };
            PS3.SetMemory((uint)(0x5d5c68 + this.dataGridView1.CurrentRow.Index * 22536), buffer);
            ZombieRPC.Call(0x0349F6C, this.dataGridView1.CurrentRow.Index, 0, "O " + "GodMode^2Enabled");
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            if (button19.Text == "Blue Eys OFF")
            {

                pictureBox6.Refresh();
                button19.Text = "Blue Eys ON";
                byte[] buffer = new byte[]
            {
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue,
                byte.MaxValue
            };
                PS3.SetMemory(40880783u, buffer);
            }

            else if (button19.Text == "Blue Eys ON")
            {

                pictureBox6.Refresh();
                button19.Text = "Blue Eys OFF";
                byte[] buffer = new byte[17];
                PS3.SetMemory(40880783u, buffer);
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[]
            {
                0,
                0,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255
            };
            PS3.SetMemory(40880774u, buffer);
            byte[] buffer2 = new byte[]
            {
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255
            };
            PS3.SetMemory(40880782u, buffer2);
        }


        private void PictureBox3_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[]
             {
                0,
                2,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255
             };
            PS3.SetMemory(40880774u, buffer);
            byte[] buffer2 = new byte[]
            {
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255
            };
            PS3.SetMemory(40880782u, buffer2);
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[]
              {
                0,
                9,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255
              };
            PS3.SetMemory(40880774u, buffer);
            byte[] buffer2 = new byte[]
            {
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255
            };
            PS3.SetMemory(40880782u, buffer2);
        }


        private void PictureBox5_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[]
             {
                0,
                21,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255
             };
            PS3.SetMemory(40880774u, buffer);
            byte[] buffer2 = new byte[]
            {
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255
            };
            PS3.SetMemory(40880782u, buffer2);
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[]
              {
                0,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255
              };
            PS3.SetMemory(40880774u, buffer);
            byte[] buffer2 = new byte[]
            {
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255,
                255
            };
            PS3.SetMemory(40880782u, buffer2);
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                Kills.Checked = true;
                Headshot.Checked = true;
                Downs.Checked = true;
                Deaths.Checked = true;
                Perks.Checked = true;
                Miles.Checked = true;
                Gibs.Checked = true;
                Bullets.Checked = true;
                Doors.Checked = true;
                Grenades.Checked = true;
                Hits.Checked = true;
                recives.Checked = true;

            }
            else
            {
                Kills.Checked = false;
                Headshot.Checked = false;
                Downs.Checked = false;
                Deaths.Checked = false;
                Perks.Checked = false;
                Miles.Checked = false;
                Gibs.Checked = false;
                Bullets.Checked = false;
                Doors.Checked = false;
                Grenades.Checked = false;
                Hits.Checked = false;
                recives.Checked = false;
            }
        }
        private void saveStats()
        {
            if (checkBox2.Checked == true)
            {
                if (Kills.Checked == true)
                {
                    byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown124.Value.ToString()));
                    PS3.SetMemory(40880396u, bytes);
                }
                if (Headshot.Checked == true)
                {
                    byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown123.Value.ToString()));
                    PS3.SetMemory(40880260u, bytes);
                }
                if (Downs.Checked == true)
                {
                    byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown122.Value.ToString()));
                    PS3.SetMemory(40880400u, bytes);
                }
                if (Deaths.Checked == true)
                {
                    byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown121.Value.ToString()));
                    PS3.SetMemory(40880456u, bytes);
                }
                if (Perks.Checked == true)
                {
                    byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown118.Value.ToString()));
                    PS3.SetMemory(40880408u, bytes);
                }
                if (Miles.Checked == true)
                {
                    byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown125.Value.ToString()));
                    PS3.SetMemory(40880444u, bytes);
                }
                if (Gibs.Checked == true)
                {
                    byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown115.Value.ToString()));
                    PS3.SetMemory(40880412u, bytes);
                }
                if (Bullets.Checked == true)
                {
                    byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown114.Value.ToString()));
                    PS3.SetMemory(40880448u, bytes);
                }
                if (Doors.Checked == true)
                {
                    byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown117.Value.ToString()));
                    PS3.SetMemory(40880440u, bytes);
                }
                if (Grenades.Checked == true)
                {
                    byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown119.Value.ToString()));
                    PS3.SetMemory(40880436u, bytes);
                }
                if (Hits.Checked == true)
                {
                    byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown120.Value.ToString()));
                    PS3.SetMemory(40880452u, bytes);
                }
                if (recives.Checked == true)
                {
                    byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown120.Value.ToString()));
                    PS3.SetMemory(40880404u, bytes);
                }

            }
        }
        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            saveStats();
        }

        private void Button39_Click(object sender, EventArgs e)
        {

        }

        private void Button37_Click(object sender, EventArgs e)
        {

        }

        private void Button34_Click(object sender, EventArgs e)
        {

        }

        private void Button31_Click(object sender, EventArgs e)
        {
            if (button31.Text == "FORCE HOST OFF")
            {
                byte[] buffer = new byte[1];
                PS3.SetMemory(30238040u, buffer);
                button31.Text = "FORCEHOST ON";
            }
            else if (button31.Text == "FORCE HOST ON")
            {
                button31.Text = "FORCEHOST OFF";
                byte[] buffer = new byte[]
            {
                1
            };
                PS3.SetMemory(30237912u, buffer);
            }
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[]
                 {
                    0x40
                 };
            PS3.SetMemory(0x26FCA00, buffer);
        }

        private void EnableToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(G_Client + 0x23 + dataGridView1.CurrentRow.Index * 0x350), new byte[2] { 0xFF, 0xFF });
            RPC.iPrintlnBold(this.dataGridView1.CurrentRow.Index, "Godmode ^2Enabled");
        }
    }
}
