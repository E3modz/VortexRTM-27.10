using E3Modz.Login___Home;
using PS3Lib;
using PS3Lib.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace E3Modz.MW3
{
    public partial class MW3 : Form
    {
        
        public static System.Drawing.Point newpoint = new System.Drawing.Point();
        public static string Username;
        public static string Password;
        public static int x;
        private bool Forcehostbool = false;
        private bool TMAPI = false;
        uint selected_client = (0);
        public static int y;
        public static uint uint_1;
        private static int VortexRTM = 0;
        public static PS3API PS3 = new PS3API(SelectAPI.ControlConsole);
        public static uint Client0 = 0;
        public static uint Client1 = 1;
        public static uint Client2 = 2;
        public static uint Client3 = 3;
        public static uint Client4 = 4;
        public static uint Client5 = 5;
        public static uint Client6 = 6;
        public static uint Client7 = 7;
        public static uint Client8 = 8;
        public static uint Client9 = 9;
        public static uint Client10 = 10;
        public static uint Client11 = 11;
        public static uint Client12 = 12;
        public static uint Client13 = 13;
        public static uint Client14 = 14;
        public static uint Client15 = 15;
        public static uint Client16 = 16;
        public static uint Client17 = 17;
        public static uint NameAddress = 17880588;
        public string string_0;
        public static PS3ManagerAPI.PS3MAPI PS3M_API = new PS3ManagerAPI.PS3MAPI();
        CCAPI PS43 = new CCAPI();
        public static uint G_ClientOffset = 17867392;
        public static uint G_ClientSize = 14720;
        public static uint G_EntityOffset = 16556672;
        public static uint G_EntitySize = 640;
        public static uint G_GivePlayerWeapon = 1847348;
        public static uint G_HudElems = 15786252;
        public static uint G_InitializeAmmo = 1614492;
        public static uint G_LocalizedStringIndex = 1828556;
        public static uint G_MaterialIndex = 1828676;
        public static uint G_SetModel = 1830748;
        private static bool GameEnd = false;
        public static uint GIndex = 512;
        internal uint a;
        public string string_3 = "N/A";
        public static byte[] GmodOnline = new byte[93]
   {
      (byte) 1,
      (byte) 39,
      (byte) 0,
      (byte) 9,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 134,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 7,
      (byte) 0,
      (byte) 9,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 134,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 106,
      (byte) 0,
      (byte) 15,
      (byte) 0,
      (byte) 17,
      (byte) 0,
      (byte) 8,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 97,
      (byte) 0,
      (byte) 131,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 23,
      (byte) 71,
      (byte) 111,
      (byte) 100,
      (byte) 101,
      (byte) 109,
      (byte) 111,
      (byte) 100,
      (byte) 101,
      (byte) 22,
      (byte) 0,
      (byte) 115,
      (byte) 115,
      (byte) 32,
      (byte) 50,
      (byte) 0,
      (byte) 84,
      (byte) 32,
      (byte) 49,
      (byte) 0,
      (byte) 0,
      (byte) 118,
      (byte) 0,
      (byte) 32,
      (byte) 0,
      (byte) 32,
      (byte) 0,
      (byte) 32,
      (byte) 0,
      (byte) 19,
      (byte) 0,
      (byte) 20,
      (byte) 0,
      (byte) 25,
      (byte) 0,
      (byte) 45,
      (byte) 0,
      (byte) 38,
      (byte) 0,
      (byte) 39,
      (byte) 0,
      (byte) 2,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 4,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 6,
      (byte) 0,
      (byte) 107
   };
        public static uint GodmodeAddress = 16557086;
        public static uint GodmodeOffset = 16557085;
        public static uint HIndex = 513;
        public static uint HudelemSize = 184;
        public MW3()
        {
            InitializeComponent();
            this.a = 40633944u;
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Dashboard h = new Dashboard();
            h.Show();
            this.Hide();
        }

        private void ConnectionTab_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                PS3.ChangeAPI(SelectAPI.ControlConsole);
                label8.Text = "CCAPI";
                label26.Text = "CCAPI";
                PS5.ChangeAPI(SelectAPI.ControlConsole);
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                PS3.ChangeAPI(SelectAPI.TargetManager);
                TMAPI = true;
                label8.Text = "TMAPI";
                label26.Text = "TMAPI";
            }
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                label8.Text = "Hen";
                label26.Text = "Hen";
                button1.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;

            }
            else
            {
                label8.Text = "N/A";
                label26.Text = "N/A";
                button1.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
        public static void cbuf_addtext(int localClientIndex, string command)
        {
            MW3RPC.Call(1946176U, (object)localClientIndex, (object)command);
        }
        private void Label3_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }
        public static void Cbuf_AddText(int localClientIndex, string command)
        {
            MW3RPC.Call(1946176U, (object)localClientIndex, (object)command);
        }
        public static string smethod_9(byte[] byte_43)
        {
            ASCIIEncoding asciiencoding = new ASCIIEncoding();
            return asciiencoding.GetString(byte_43);
        }
        private void method_65()
        {
            byte[] byte_ = new byte[16];
            PS5.GetMemoryR(268501585u, ref byte_);
            string string_ = MW3.smethod_9(byte_).Replace(Convert.ToChar(0).ToString(), string.Empty);
            this.string_0 = this.method_66(string_);
            this.label48.Text = this.string_0;
        }
        private string method_66(string string_3)
        {
            string result;
            if (string_3 == "BLUS30838" | string_3 == "BLES01428" | string_3 == "BLES01431" | string_3 == "BLES01430" | string_3 == "BLES01432" | string_3 == "BLES01433" | string_3 == "BLES01434" | string_3 == "BLES01429" | string_3 == "BLUS30887" | string_3 == "NPEB00964" | string_3 == "NPEB00965" | string_3 == "NPEB00966" | string_3 == "NPEB00967" | string_3 == "NPEB00968" | string_3 == "NPEB00977" | string_3 == "NPEB00978")
            {
                byte[] array = new byte[1];
                PS5.GetMemoryR(2265001u, ref array);
                if (array[0] == 33)
                {
                    result = string_3;
                }
                else
                {
                    result = string_3;
                }

            }
            else
            {
                result = "Unknown";
            }
            return result;
        }


        private void Button10_Click(object sender, EventArgs e)
        {
            if (PS3.ConnectTarget())
            {
                MessageBox.Show("Connected!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label5.Text = "Connected!";
                label5.ForeColor = Color.Yellow;
                label14.Text = PS3.CCAPI.GetTemperatureCELL();
                label15.Text = PS3.CCAPI.GetTemperatureRSX();
                label16.Text = PS3.CCAPI.GetFirmwareVersion();
                label17.Text = PS3.CCAPI.GetFirmwareType();
                if (TMAPI == true)
                {
                    if (PS3.AttachProcess())
                    {
                        //Funcs.MODDEDLISTS();
                        label7.Text = PS3.Extension.ReadString(29080620);
                        label12.Text = label7.Text;
                        label5.Text = "Connected + Attached!";
                        label5.ForeColor = Color.Green;
                        label48.Text = string_3;
                        MW3.cbuf_addtext(0, "cg_scoreboardPingText 1");
                        //Funcs.ChangeMw3Background(E3Modz.Properties.Resources.Skirlex_Fixed);
                    }
                    else
                    {
                        MessageBox.Show("Somthing went wrong");
                    }

                }
                else
                {
                    if (PS3.AttachProcess())
                    {
                        PS5.Connect();

                        Funcs.MODDEDLISTS();
                        label7.Text = PS3.Extension.ReadString(29080620);
                        label12.Text = PS3.Extension.ReadString(29080620);
                        label5.Text = "Connected + Attached!";
                        label5.ForeColor = Color.Green;
                        label48.Text = string_3;
                        this.method_65();
                        MW3.cbuf_addtext(0, "cg_scoreboardPingText 1");
                        Funcs.ChangeMw3Background(E3Modz.Properties.Resources.Skirlex_Fixed);
                        MessageBox.Show("Connected + Attached!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Processe Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        private void Button9_Click(object sender, EventArgs e)
        {
            PS3.DisconnectTarget();
            label5.Text = "Disconnected!";
            label5.ForeColor = Color.Yellow;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            PS3.Power(PS3API.PowerFlags.ShutDown);
            PS43.ShutDown(CCAPI.RebootFlags.ShutDown);
        }



        private void Button65_Click(object sender, EventArgs e)
        {
            PS3M_API.ConnectTarget(this.ipText.Text, Convert.ToInt32(7887));
            try
            {
                this.comboBox1.Items.Clear();
                foreach (uint num in PS3M_API.Process.GetPidProcesses())
                {
                    if (num == 0u)
                    {
                        break;

                    }
                    comboBox1.Items.Add(PS3M_API.Process.GetName(num));
                    label5.Text = "Connected!";

                    label5.ForeColor = Color.Green;
                }
                this.comboBox1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void Button60_Click(object sender, EventArgs e)
        {
            PS3.ChangeAPI(SelectAPI.PS3Manager);
            if (!PS3M_API.AttachProcess(PS3M_API.Process.Processes_Pid[this.comboBox1.SelectedIndex]))
            {
                MessageBox.Show("Impossible to attach :(", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                PS3M_API.DisconnectTarget();
            }
            PS3M_API.PS3.Notify("Successfully Attached");
            label5.Text = "Connected + Attached!";
            label5.ForeColor = Color.Green;
            MessageBox.Show("Attached!", "Succesfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Thread.Sleep(100);
            Funcs.MODDEDLISTS();
            pictureBox1.Visible = true;
            this.method_65();
            PS3.CCAPI.RingBuzzer(CCAPI.BuzzerMode.Double);
            PS3.CCAPI.Notify(CCAPI.NotifyIcon.FINGER, "Attached with RTM Tool, Have Fun! :D");
        }

        private void Button61_Click(object sender, EventArgs e)
        {
            E3Modz.Properties.Settings.Default.DefaultIP = ipText.Text;
            E3Modz.Properties.Settings.Default.Save();
        }

        private void MW3_Load(object sender, EventArgs e)
        {
            ipText.Text = E3Modz.Properties.Settings.Default.DefaultIP;
            this.tabControl1.SelectedTab = ConnectionTab;
        }


        private void Panel6_MouseDown(object sender, MouseEventArgs e)
        {
            MW3.x = Control.MousePosition.X - base.Location.X;
            MW3.y = Control.MousePosition.Y - base.Location.Y;
        }

        private void Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel6_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MW3.newpoint = Control.MousePosition;
                MW3.newpoint.X -= MW3.x;
                MW3.newpoint.Y -= MW3.y;
                base.Location = MW3.newpoint;
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            MW3Protection p = new MW3Protection();
            p.Show();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (button12.Text == "RPC OFF")
            {
                MW3RPC.Enable();
                button12.Text = "RPC ON";
                label22.Text = "Enabled!";
                label22.ForeColor = Color.Green;
                MessageBox.Show("RPC Enabled", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (button12.Text == "RPC ON")
            {
                MessageBox.Show("RPC has been Disabled! For 100% Reflection restart your Game!", "Information");
            }
        }

        private void Button79_Click(object sender, EventArgs e)
        {

            byte[] bytes = Encoding.Default.GetBytes(this.textBox1.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(29080620, bytes);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = NameChangerTab;
        }

        private void Button85_Click(object sender, EventArgs e)
        {
            byte[] buffer1 = new byte[1] { (byte)1 };
            PS3.SetMemory(29080617, buffer1);
            byte[] buffer2 = new byte[1];
            PS3.SetMemory(8989715, buffer2);
            byte[] buffer3 = new byte[1];
            PS3.SetMemory(8989716, buffer3);
            byte[] buffer4 = new byte[1] { (byte)26 };
            PS3.SetMemory(29463676, buffer4);
            label7.Text = PS3.Extension.ReadString(29080620);
        }

        private void Button78_Click(object sender, EventArgs e)
        {
            if (this.button78.Text == "Flash OFF")
            {
                this.FlashNormalName.Start();
                this.button78.Text = "Flash ON";
            }
            else
            {
                if (!(this.button78.Text == "Flash ON"))
                    return;
                this.FlashNormalName.Stop();
                this.button78.Text = "Flash OFF";
            }
        }

        private void FlashNormalName_Tick(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^" + (object)new Random().Next(0, 7) + this.textBox1.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(29080620, bytes);
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.Default.GetBytes(this.textBox2.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(29080620, bytes);
        }

        private void Button84_Click(object sender, EventArgs e)
        {
            Funcs.ChangeNameNonHost(this.textBox3.Text, "");
        }

        private void FlashLive_Tick(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes("^" + (object)new Random().Next(0, 7) + this.textBox2.Text);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(29080620, bytes);
        }

        private void Button82_Click(object sender, EventArgs e)
        {
            if (button82.Text == "Flash?")
            {
                FlashLive.Start();
                button82.Text = "Flash ON";
            }
            else if (button82.Text == "Flash ON")
            {
                FlashLive.Stop();
                button82.Text = "Flash?";
            }
        }

        private void Button83_Click(object sender, EventArgs e)
        {
            if (button83.Text == "Flash OFF")
            {
                FlashIngame.Start();
                button83.Text = "Flash ON";
            }
            else if (button83.Text == "Flash ON")
            {
                FlashIngame.Stop();
                button83.Text = "Flash OFF";
            }
        }

        private void FlashIngame_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int num = random.Next(0, 7);
            Funcs.ChangeNameNonHost(this.textBox3.Text, "^" + num);
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            {
                byte[] bytes1 = Encoding.Default.GetBytes(this.textBox4.Text);
                Array.Resize<byte>(ref bytes1, bytes1.Length + 1);
                PS3.SetMemory(29080620, bytes1);
                byte[] bytes2 = Encoding.Default.GetBytes(this.textBox4.Text);
                Array.Resize<byte>(ref bytes2, bytes2.Length + 1);
                PS3.SetMemory(7541856, bytes2);
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (button13.Text == "CheckBox Name OFF")
            {
                CheckBox.Start();
                button13.Text = "CheckBox Name ON";
            }
            else if (button13.Text == "CheckBox Name ON")
            {
                CheckBox.Stop();
                button13.Text = "CheckBox Name OFF";
            }
        }

        private void CheckBox_Tick(object sender, EventArgs e)
        {
            ++MW3.VortexRTM;
            switch (MW3.VortexRTM - 1)
            {
                case 0:
                    byte[] buffer1 = new byte[31]
                    {
            (byte) 94,
            (byte) 49,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1,
            (byte) 1,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1,
            (byte) 1,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1,
            (byte) 1,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1,
            (byte) 1,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1
                    };
                    PS3.SetMemory(29080620, buffer1);
                    break;
                case 1:
                    byte[] buffer2 = new byte[31]
                    {
            (byte) 94,
            (byte) 50,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1,
            (byte) 1,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1,
            (byte) 1,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1,
            (byte) 1,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1,
            (byte) 1,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1
                    };
                    PS3.SetMemory(29080620, buffer2);
                    break;
                case 2:
                    byte[] buffer3 = new byte[31]
                    {
            (byte) 94,
            (byte) 51,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1,
            (byte) 1,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1,
            (byte) 1,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1,
            (byte) 1,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1,
            (byte) 1,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1
                    };
                    PS3.SetMemory(29080620, buffer3);
                    break;
                case 3:
                    byte[] buffer4 = new byte[31]
                    {
            (byte) 94,
            (byte) 52,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1,
            (byte) 1,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1,
            (byte) 1,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1,
            (byte) 1,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1,
            (byte) 1,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1
                    };
                    PS3.SetMemory(29080620, buffer4);
                    break;
                case 4:
                    byte[] buffer5 = new byte[31]
                    {
            (byte) 94,
            (byte) 53,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1,
            (byte) 1,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1,
            (byte) 1,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1,
            (byte) 1,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1,
            (byte) 1,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1
                    };
                    PS3.SetMemory(29080620, buffer5);
                    break;
                case 5:
                    byte[] buffer6 = new byte[31]
                    {
            (byte) 94,
            (byte) 54,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1,
            (byte) 1,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1,
            (byte) 1,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1,
            (byte) 1,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1,
            (byte) 1,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1
                    };
                    PS3.SetMemory(29080620, buffer6);
                    break;
                case 6:
                    byte[] buffer7 = new byte[31]
                    {
            (byte) 94,
            (byte) 55,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1,
            (byte) 1,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1,
            (byte) 1,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1,
            (byte) 1,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1,
            (byte) 1,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1
                    };
                    PS3.SetMemory(29080620, buffer7);
                    break;
                case 7:
                    byte[] buffer8 = new byte[31]
                    {
            (byte) 94,
            (byte) 56,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1,
            (byte) 1,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1,
            (byte) 1,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1,
            (byte) 1,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1,
            (byte) 1,
            (byte) 94,
            (byte) 1,
            (byte) 128,
            (byte) 128,
            (byte) 1
                    };
                    PS3.SetMemory(29080620, buffer8);
                    break;
            }
            if (MW3.VortexRTM != 9)
                return;
            MW3.VortexRTM = 0;
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            if (button15.Text == "XP Lobby Name OFF")
            {
                XPLOBBY.Start();
                button15.Text = "XP Lobby Name ON";
            }
            else if (button15.Text == "XP Lobby Name ON")
            {
                XPLOBBY.Stop();
                button15.Text = "XP Lobby Name OFF";
            }
        }

        private void XPLOBBY_Tick(object sender, EventArgs e)
        {
            ++MW3.VortexRTM;
            switch (MW3.VortexRTM - 1)
            {
                case 0:
                    byte[] bytes1 = Encoding.Default.GetBytes("^0XP ^2LOBBY ^1XP");
                    Array.Resize<byte>(ref bytes1, bytes1.Length + 1);
                    PS3.SetMemory(29080620, bytes1);
                    break;
                case 1:
                    byte[] bytes2 = Encoding.Default.GetBytes("^1XP ^2LOBBY ^2XP");
                    Array.Resize<byte>(ref bytes2, bytes2.Length + 1);
                    PS3.SetMemory(29080620, bytes2);
                    break;
                case 2:
                    byte[] bytes3 = Encoding.Default.GetBytes("^2XP ^2LOBBY ^3XP");
                    Array.Resize<byte>(ref bytes3, bytes3.Length + 1);
                    PS3.SetMemory(29080620, bytes3);
                    break;
                case 3:
                    byte[] bytes4 = Encoding.Default.GetBytes("^3XP ^2LOBBY ^4XP");
                    Array.Resize<byte>(ref bytes4, bytes4.Length + 1);
                    PS3.SetMemory(29080620, bytes4);
                    break;
                case 4:
                    byte[] bytes5 = Encoding.Default.GetBytes("^4XP ^2LOBBY ^5XP");
                    Array.Resize<byte>(ref bytes5, bytes5.Length + 1);
                    PS3.SetMemory(29080620, bytes5);
                    break;
                case 5:
                    byte[] bytes6 = Encoding.Default.GetBytes("^5XP ^2LOBBY ^6XP");
                    Array.Resize<byte>(ref bytes6, bytes6.Length + 1);
                    PS3.SetMemory(29080620, bytes6);
                    break;
                case 6:
                    byte[] bytes7 = Encoding.Default.GetBytes("^6XP ^2LOBBY ^7XP");
                    Array.Resize<byte>(ref bytes7, bytes7.Length + 1);
                    PS3.SetMemory(29080620, bytes7);
                    break;
                case 7:
                    byte[] bytes8 = Encoding.Default.GetBytes("^7XP ^2LOBBY ^8XP");
                    Array.Resize<byte>(ref bytes8, bytes8.Length + 1);
                    PS3.SetMemory(29080620, bytes8);
                    break;
            }
            if (MW3.VortexRTM != 9)
                return;
            MW3.VortexRTM = 0;
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            if (button16.Text == "Button Name OFF")
            {
                ButtonName.Start();
                button16.Text = "Button Name ON";
            }
            else if (button16.Text == "Button Name ON")
            {
                button16.Text = "Button Name OFF";
                ButtonName.Stop();
            }
        }

        private void ButtonName_Tick(object sender, EventArgs e)
        {
            PS3.SetMemory(29080620U, new byte[8]
     {
        (byte) 1,
        (byte) 2,
        (byte) 3,
        (byte) 4,
        (byte) 5,
        (byte) 6,
        (byte) 7,
        (byte) 8
     });
            Thread.Sleep(20);
            PS3.SetMemory(29080620U, new byte[8]
            {
        (byte) 5,
        (byte) 6,
        (byte) 1,
        (byte) 2,
        (byte) 3,
        (byte) 8,
        (byte) 4,
        (byte) 7
            });
            Thread.Sleep(20);
            byte[] bytes = new byte[8]
            {
        (byte) 4,
        (byte) 7,
        (byte) 6,
        (byte) 5,
        (byte) 8,
        (byte) 2,
        (byte) 3,
        (byte) 1
            };
            PS3.SetMemory(29080620U, bytes);
            Thread.Sleep(20);
            byte[] numArray = new byte[8]
            {
        (byte) 7,
        (byte) 5,
        (byte) 4,
        (byte) 8,
        (byte) 3,
        (byte) 1,
        (byte) 6,
        (byte) 2
            };
            PS3.SetMemory(29080620U, bytes);
            Thread.Sleep(20);
        }
        private void AntiModding()
        {
            byte[] array1 = new byte[17];
            PS3.BlockMemory(AllMemory, array1);
        }

        public static string GetName(int client)
        {
            byte[] array = new byte[32];
            PS3.GetMemory(MW3.NameAddress + (uint)(14720 * client), array);
            string @string = Encoding.ASCII.GetString(array);
            return @string.Replace("\0", "");
        }

        public static string GetTeam(uint Client)
        {
            byte[] Byte = new byte[1];
            PS3.GetMemory((uint)(17880663 + (int)Client * 14720), Byte);
            bool flag1 = ((IEnumerable<byte>)new byte[1] { (byte)1 }).SequenceEqual<byte>((IEnumerable<byte>)Byte);
            bool flag2 = ((IEnumerable<byte>)new byte[1] { (byte)2 }).SequenceEqual<byte>((IEnumerable<byte>)Byte);
            bool flag3 = ((IEnumerable<byte>)new byte[1] { (byte)5 }).SequenceEqual<byte>((IEnumerable<byte>)Byte);
            bool flag4 = ((IEnumerable<byte>)new byte[1] { (byte)6 }).SequenceEqual<byte>((IEnumerable<byte>)Byte);
            bool flag5 = ((IEnumerable<byte>)new byte[1]).SequenceEqual<byte>((IEnumerable<byte>)Byte);
            if (flag1)
                return "Friendly";
            if (flag2)
                return "Enemy";
            if (flag3)
                return "Godmode Team";
            if (flag4)
                return "Spectator";
            return flag5 ? "Free for All" : "Unknown Team";
        }
        public static string GetServerInfoMW3(string rinfo)
        {
            try
            {
                byte[] buffer = new byte[256];
                PS5.GetMemoryR(8610005, ref buffer);
                string str = "";
                if (rinfo == "gamemode")
                    return PS5.ByteArrayToString(buffer).Split(Convert.ToChar(92))[2];
                if (rinfo == "map")
                    return PS5.ByteArrayToString(buffer).Split(Convert.ToChar(92))[6];
                if (rinfo == "hostname")
                    str = PS5.ByteArrayToString(buffer).Split(Convert.ToChar(92))[16];
                return str;
            }
            catch (Exception)
            {
            }
            return "Not in Game";
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            
            this.Host.Text = MW3.GetServerInfoMW3("hostname");
            this.dataGridView1.Enabled = true;
            this.dataGridView1.RowCount = 18;
            for (int client = 0; client < 18; ++client)
            {
                this.dataGridView1.Update();
                this.dataGridView1.Rows[client].Cells[0].Value = (object)client;
                this.dataGridView1.Rows[client].Cells[1].Value = (object)MW3.GetName(client);
                this.dataGridView1.Rows[client].Cells[2].Value = (object)MW3.GetTeam((uint)client);
            }
            byte[] array1 = new byte[17];
            PS3.GetMemory(8610017, array1);
            string string1 = Encoding.ASCII.GetString(array1);
            if (string1.Contains("war"))
                this.Game.Text = "Team Deathmatch";
            else if (string1.Contains("dm"))
                this.Game.Text = "Free for All";
            else if (string1.Contains("sd"))
                this.Game.Text = "Search and Destroy";
            else if (string1.Contains("dom"))
                this.Game.Text = "Domination";
            else if (string1.Contains("conf"))
                this.Game.Text = "Kill Confirmed";
            else if (string1.Contains("tdef"))
                this.Game.Text = "Team Defender";
            else if (string1.Contains("infect"))
                this.Game.Text = "Infected";
            else if (string1.Contains("dem"))
                this.Game.Text = "Demolition";
            else if (string1.Contains("sab"))
                this.Game.Text = "Sabotage";
            else if (string1.Contains("koth"))
                this.Game.Text = "Headquaters Pro";
            else if (string1.Contains("ctf"))
                this.Game.Text = "Capture the flag";
            else if (string1.Contains("grnd"))
                this.Game.Text = "Dropzone";
            else
                this.Game.Text = "Gamemode: Not in Game";
            byte[] buffer2 = new byte[17];
            PS5.GetMemoryR(8610041, ref buffer2);
            string string2 = Encoding.ASCII.GetString(buffer2);
            if (string2.Contains("mp_dome"))
                this.Map.Text = "Dome";
            else if (string2.Contains("mp_seatown"))
                this.Map.Text = "Seatown";
            else if (string2.Contains("mp_plaza2"))
                this.Map.Text = "Arkaden";
            else if (string2.Contains("mp_mogadishu"))
                this.Map.Text = "Bakaara";
            else if (string2.Contains("mp_paris"))
                this.Map.Text = "Resistance";
            else if (string2.Contains("mp_exchange"))
                this.Map.Text = "Downturn";
            else if (string2.Contains("mp_bootleg"))
                this.Map.Text = "Bootleg";
            else if (string2.Contains("mp_carbon"))
                this.Map.Text = "Carbon";
            else if (string2.Contains("mp_hardhat"))
                this.Map.Text = "Hardhat";
            else if (string2.Contains("mp_alpha"))
                this.Map.Text = "Lockdown";
            else if (string2.Contains("mp_village"))
                this.Map.Text = "Village";
            else if (string2.Contains("mp_lambeth"))
                this.Map.Text = "Fallen";
            else if (string2.Contains("mp_radar"))
                this.Map.Text = "Outpost";
            else if (string2.Contains("mp_interchange"))
                this.Map.Text = "Interchange";
            else if (string2.Contains("mp_underground"))
                this.Map.Text = "Underground";
            else if (string2.Contains("mp_bravo"))
                this.Map.Text = "Mission";
            else if (string2.Contains("mp_park"))
                this.Map.Text = "Liberation";
            else if (string2.Contains("mp_italy"))
                this.Map.Text = "Piazza";
            else if (string2.Contains("mp_overwatch"))
                this.Map.Text = "Overwatch";
            else if (string2.Contains("mp_morningwood"))
                this.Map.Text = "Black Box";
            else if (string2.Contains("mp_meteora"))
                this.Map.Text = "Sanctuary";
            else if (string2.Contains("mp_cement"))
                this.Map.Text = "Foundation";
            else if (string2.Contains("mp_qadeem"))
                this.Map.Text = "Oasis";
            else if (string2.Contains("mp_restrepo_ss"))
                this.Map.Text = "Lookout";
            else if (string2.Contains("mp_hillside_ss"))
                this.Map.Text = "Getaway";
            else if (string2.Contains("mp_courtyard_ss"))
                this.Map.Text = "Erosion";
            else if (string2.Contains("mp_aground_ss"))
                this.Map.Text = "Aground";
            else if (string2.Contains("mp_terminal_cls"))
                this.Map.Text = "Terminal";
            else if (string2.Contains("mp_six_ss"))
                this.Map.Text = "Vortex";
            else if (string2.Contains("mp_burn_ss"))
                this.Map.Text = "U-Turn";
            else if (string2.Contains("mp_crosswalk_ss"))
                this.Map.Text = "Intersection";
            else if (string2.Contains("mp_shipbreaker"))
                this.Map.Text = "Decommission";
            else if (string2.Contains("mp_roughneck"))
                this.Map.Text = "Offshore";
            else if (string2.Contains("mp_moab"))
                this.Map.Text = "Gulch";
            else if (string2.Contains("mp_boardwalk"))
                this.Map.Text = "Broadwalk";
            else if (string2.Contains("mp_nola"))
                this.Map.Text = "Parish";
            else
                this.Map.Text = "Unknown Map";
        }

        private void GodemodeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public static void iPrintln(int client, string Text)
        {
            MW3.SV_GameSendServerCommand(client, "c \"" + Text + "\"");
            Thread.Sleep(20);
        }
        public static uint IIndex = 514;
        public static uint Lethal = 1051;
        public static uint LevelTime = 16530864;
        public static uint mFlag = 13820;
        public static uint MoveIndex = 501;
        public static byte[] myhostmax = new byte[1] { (byte)18 };
        public static byte[] myhostmaxDefault = new byte[1] { (byte)18 };
        public static byte[] myhostmin = new byte[1] { (byte)6 };
        public static byte[] myhostminDefault = new byte[1] { (byte)6 };
        private static bool[] PLAYER1 = new bool[10];
        public static uint Player1Index = 504;
        private static bool[] PLAYER2 = new bool[10];
        public static uint Player2Index = 503;
        public static uint PlayerName = 29080620;
        public static uint PrimaryWeapon = 636;
        public static uint RedBoxes = 19;
        public static bool ResetThread = false;
        public static uint SCROLLERIndex = 515;
        public static uint SecondaryWeapon = 628;
        public static uint SelectIndex = 502;
        private static bool[] STATE = new bool[10];
        public static uint SV_GameSendServerCommand2 = 2265000;
        public static uint Tactial = 643;
        public static uint TeamAddress = 17880663;
        public static uint TITELIndex = 505;
        public static bool TrickStatus = false;
        public static uint TypewriterIndex = 516;
        public static uint UFOAddress = 17881215;
        private static int Countername = 0;
        private static int UnbannedDEX3 = 0;
        private static int ArabiMoDz = 0;
        private static int Derank = 0;
        private static int Regenboge = 0;
        public static byte[] savedcoordinates = new byte[12];
        public static uint SV_GameSendServerCommand5 = 2265000;
        private static int Codet = 0;
        private OpenFileDialog ofd = new OpenFileDialog();
        private StringBuilder buffer = new StringBuilder(128);
        private uint AllMemory;

        public static void SV_GameSendServerCommand(int client, string command)
        {
            MW3RPC.Call(MW3.SV_GameSendServerCommand2, (object)client, (object)0, (object)command);
        }
        private void EnableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(17880622 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
    {
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
    });
            PS3.SetMemory((uint)(17867814 + this.dataGridView1.CurrentRow.Index * 14720), new byte[2]
            {
        byte.MaxValue,
        byte.MaxValue
            });
            byte[] bytes = new byte[3]
            {
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
            };
            PS3.SetMemory(MW3.GodmodeOffset + (uint)(this.dataGridView1.CurrentRow.Index * 640), bytes);
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "Godmode ^2ON");
        }

        private void EnableToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(17868434 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
     {
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
     });
            PS3.SetMemory((uint)(17868458 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
            {
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
            });
            PS3.SetMemory((uint)(17868470 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
            {
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
            });
            PS3.SetMemory((uint)(17868446 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
            {
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
            });
            PS3.SetMemory((uint)(17868482 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
            {
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
            });
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "Unlimited Ammo ^2ON");
        }

        private void EnableToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(17868434 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
    {
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
    });
            PS3.SetMemory((uint)(17868458 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
            {
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
            });
            PS3.SetMemory((uint)(17868470 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
            {
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
            });
            PS3.SetMemory((uint)(17868446 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
            {
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
            });
            PS3.SetMemory((uint)(17868482 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
            {
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
            });
            PS3.SetMemory((uint)(17880891 + this.dataGridView1.CurrentRow.Index * 14720), new byte[17]
            {
        (byte) 1,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 1
            });
            PS3.SetMemory((uint)(17867411 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1] { (byte)16 });
            PS3.SetMemory((uint)(17868607 + this.dataGridView1.CurrentRow.Index * 14720), new byte[52]
            {
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 12,
        (byte) 48,
        (byte) 142,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 7,
        byte.MaxValue,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
            });
            PS3.SetMemory((uint)(17868659 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1] { byte.MaxValue });
            PS3.SetMemory((uint)(17880622 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
            {
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
            });
            PS3.SetMemory((uint)(17867814 + this.dataGridView1.CurrentRow.Index * 14720), new byte[2]
            {
        byte.MaxValue,
        byte.MaxValue
            });
            PS3.SetMemory((uint)(17868659 + this.dataGridView1.CurrentRow.Index * 14720), new byte[2]
            {
        (byte) 197,
        byte.MaxValue
            });
            byte[] bytes = new byte[3]
            {
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
            };
            PS3.SetMemory(MW3.GodmodeOffset + (uint)(this.dataGridView1.CurrentRow.Index * 640), bytes);
            byte[] buffer1 = new byte[4]
            {
        (byte) 65,
        (byte) 130,
        (byte) 0,
        (byte) 148
            };
            PS3.SetMemory(204140, buffer1);
            byte[] buffer2 = new byte[4]
            {
        (byte) 192,
        (byte) 36,
        (byte) 0,
        (byte) 0
            };
            PS3.SetMemory(204164, buffer2);
            byte[] buffer3 = new byte[4]
            {
        (byte) 64,
        (byte) 130,
        (byte) 0,
        (byte) 60
            };
            PS3.SetMemory(204172, buffer3);
            byte[] buffer4 = new byte[4]
            {
        (byte) 65,
        (byte) 130,
        (byte) 0,
        (byte) 148
            };
            PS3.SetMemory(203588, buffer4);
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "Cheater Pack ^2Enabled");
        }

        private void EnabledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(17881215 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1] { (byte)1 });
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "NoClip ^2Enabled");
        }

        private void DisabledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(17881215 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]);
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "NoClip ^1Disabled");
        }
        private static string ReturnInfos(int Index)
        {
            return Encoding.ASCII.GetString(PS5.GetMemory(8610005U, 256)).Replace("\\", "|").Split('|')[Index];
        }
        public static string getMapName()
        {
            switch (MW3.ReturnInfos(6))
            {
                case "mp_alpha":
                    return "Lockdown";
                case "mp_bootleg":
                    return "Bootleg";
                case "mp_bravo":
                    return "Mission";
                case "mp_carbon":
                    return "Carbon";
                case "mp_dome":
                    return "Dome";
                case "mp_exchange":
                    return "Downturn";
                case "mp_hardhat":
                    return "Hardhat";
                case "mp_interchange":
                    return "Interchange";
                case "mp_lambeth":
                    return "Fallen";
                case "mp_mogadishu":
                    return "Bakaara";
                case "mp_paris":
                    return "Resistance";
                case "mp_plaza2":
                    return "Arkaden";
                case "mp_radar":
                    return "Outpost";
                case "mp_seatown":
                    return "Seatown";
                case "mp_underground":
                    return "Underground";
                case "mp_village":
                    return "Village";
                case "mp_aground_ss":
                    return "Aground";
                case "mp_cement":
                    return "Foundation";
                case "mp_hillside_ss":
                    return "Getaway";
                case "mp_italy":
                    return "Piazza";
                case "mp_meteora":
                    return "Sanctuary";
                case "mp_morningwood":
                    return "Black Box";
                case "mp_overwatch":
                    return "Overwatch";
                case "mp_park":
                    return "Liberation";
                case "mp_qadeem":
                    return "Oasis";
                case "mp_restrepo_ss":
                    return "Lookout";
                case "mp_terminal_cls":
                    return "Terminal";
                case "mp_courtyard_ss":
                    return "Erosion";
                default:
                    return "Unknown Map";
            }
        }
        private void M4A1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 25
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 25
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 25
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2M4A1 Given");
            }
            else
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 26
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 26
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 26
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2M4A1 Given");
            }
        }

        private void M16A4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 24
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 24
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 24
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2M16A4 Given");
            }
            else
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 25
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 25
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 25
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2M16A4 Given");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = ClientListTab;
        }

        private void ConButton_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = ConnectionTab;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = StatsTab;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = NameChangerTab;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = LobbySettingsTab;
        }

        private void SCARLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 30
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 30
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 30
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2SCAR-L Given");
            }
            else
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 31
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 31
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 31
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2SCAR-L Given");
            }
        }

        private void CM901ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 32
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 32
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 32
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2CM901 Given");
            }
            else
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 33
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 33
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 33
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2CM901 Given");
            }
        }

        private void TYP95ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 28
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 28
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 28
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2TYP-95 Given");
            }
            else
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 29
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 29
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 29
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2TYP-95 Given");
            }
        }

        private void G36CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 31
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 31
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 31
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2G36C Given");
            }
            else
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 32
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 32
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 32
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2G36C Given");
            }
        }

        private void ACR68ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 27
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 27
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 27
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2ACR 6.8 Given");
            }
            else
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 28
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 28
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 28
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2ACR 6.8 Given");
            }
        }

        private void MK14ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 29
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 29
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 29
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2MK14 Given");
            }
            else
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 30
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 30
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 30
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2MK14 Given");
            }
        }

        private void AK47ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 23
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 23
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 23
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2AK-47 Given");
            }
            else
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 24
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 24
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 24
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2AK-47 Given");
            }
        }

        private void FADToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 26
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 26
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 26
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2FAD Given");
            }
            else
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 27
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 27
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 27
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2FAD Given");
            }
        }

        private void MP5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 17
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 17
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 17
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2MP5 Given");
            }
            else
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 18
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 18
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 18
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2MP5 Given");
            }
        }

        private void UMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 21
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 21
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 21
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2UMP45 Given");
            }
            else
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 22
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 22
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 22
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2UMP45 Given");
            }
        }

        private void PP90M1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 20
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 20
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 20
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2PP90M1 Given");
            }
            else
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 21
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 21
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 21
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2PP90M1 Given");
            }
        }

        private void P90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 19
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 19
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 19
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2P90 Given");
            }
            else
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 20
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 20
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 20
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2P90 Given");
            }
        }

        private void PM9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 18
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 18
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 18
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2PM-9 Given");
            }
            else
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 19
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 19
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 19
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2PM-9 Given");
            }
        }

        private void MP7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 22
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 22
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 22
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2MP7 Given");
            }
            else
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 23
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 23
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 23
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2MP7 Given");
            }
        }

        private void L86LSWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 56
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 56
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 56
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2L86 LSW Given");
            }
            else
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 57
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 57
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 57
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2L86 LSW Given");
            }
        }

        private void PKPPECHENEGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 55
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 55
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 55
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2PKP PECHENEG Given");
            }
            else
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 56
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 56
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 56
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2PKP PECHENEG Given");
            }
        }

        private void MK46ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 54
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 54
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 54
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2MK46 Given");
            }
            else
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 55
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 55
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 55
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2MK46 Given");
            }
        }

        private void M60E4JUGGERNAUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 53
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 53
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 53
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2M60E4 Given");
            }
            else
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 54
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 54
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 54
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2M60E4 Given");
            }
        }

        private void BARRETTKAL50ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 4,
          (byte) 59,
          (byte) 42
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 4,
          (byte) 59,
          (byte) 42
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 4,
          (byte) 59,
          (byte) 42
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2BARRETT KAL.50 Given");
            }
            else
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 4,
          (byte) 59,
          (byte) 43
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 4,
          (byte) 59,
          (byte) 43
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 4,
          (byte) 59,
          (byte) 43
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2BARRETT KAL.50 Given");
            }
        }

        private void L118AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 4,
          (byte) 59,
          (byte) 45
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 4,
          (byte) 59,
          (byte) 45
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 4,
          (byte) 59,
          (byte) 45
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2L118A Given");
            }
            else
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 4,
          (byte) 59,
          (byte) 46
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 4,
          (byte) 59,
          (byte) 46
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 4,
          (byte) 59,
          (byte) 46
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2L118A Given");
            }
        }

        private void DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 4,
          (byte) 59,
          (byte) 40
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 4,
          (byte) 59,
          (byte) 40
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 4,
          (byte) 59,
          (byte) 40
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2DRAGUNOW Given");
            }
            else
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 4,
          (byte) 59,
          (byte) 41
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 4,
          (byte) 59,
          (byte) 41
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 4,
          (byte) 59,
          (byte) 41
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2DRAGUNOW Given");
            }
        }

        private void AS50ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 4,
          (byte) 59,
          (byte) 44
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 4,
          (byte) 59,
          (byte) 44
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 4,
          (byte) 59,
          (byte) 44
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2AS50 Given");
            }
            else
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 4,
          (byte) 59,
          (byte) 45
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 4,
          (byte) 59,
          (byte) 45
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 4,
          (byte) 59,
          (byte) 45
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2AS50 Given");
            }
        }

        private void RSASSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 8,
          (byte) 59,
          (byte) 43
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 8,
          (byte) 59,
          (byte) 43
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 8,
          (byte) 59,
          (byte) 43
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2RSASS Given");
            }
            else
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 8,
          (byte) 59,
          (byte) 44
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 8,
          (byte) 59,
          (byte) 44
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 8,
          (byte) 59,
          (byte) 44
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2RSASS Given");
            }
        }

        private void MSRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 4,
          (byte) 59,
          (byte) 41
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 4,
          (byte) 59,
          (byte) 41
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 4,
          (byte) 59,
          (byte) 41
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2MSR Given");
            }
            else
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 4,
          (byte) 59,
          (byte) 42
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 4,
          (byte) 59,
          (byte) 42
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 4,
          (byte) 59,
          (byte) 42
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2MSR Given");
            }
        }

        private void USAS12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 50
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 50
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 50
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2USAS12 Given");
            }
            else
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 51
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 51
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 51
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2USAS12 Given");
            }
        }

        private void KSG12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 46
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 46
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 46
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2KSG 12 Given");
            }
            else
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 47
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 47
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 47
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2KSG 12 Given");
            }
        }

        private void SPAS12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 51
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 51
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 51
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2SPAS-12 Given");
            }
            else
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 52
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 52
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 52
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2SPAS-12 Given");
            }
        }

        private void AA12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 49
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 49
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 49
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2AA-12 Given");
            }
            else
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 50
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 50
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 50
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2AA-12 Given");
            }
        }

        private void STRIKERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 48
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 48
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 48
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2STRIKER Given");
            }
            else
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 49
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 49
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 49
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2STRIKER Given");
            }
        }

        private void MODEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 47
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 47
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 47
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2MODELL 1887 Given");
            }
            else
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 48
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 48
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 11,
          (byte) 48
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2MODELL 1887 Given");
            }
        }

        private void AC130105mmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                byte[] bytes1 = new byte[3];
                bytes1[2] = (byte)105;
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), bytes1);
                byte[] bytes2 = new byte[3];
                bytes2[2] = (byte)105;
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), bytes2);
                byte[] bytes3 = new byte[3];
                bytes3[2] = (byte)105;
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), bytes3);
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2AC130 105mm Given");
            }
            else
            {
                byte[] bytes1 = new byte[3];
                bytes1[2] = (byte)106;
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), bytes1);
                byte[] bytes2 = new byte[3];
                bytes2[2] = (byte)106;
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), bytes2);
                byte[] bytes3 = new byte[3];
                bytes3[2] = (byte)106;
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), bytes3);
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2AC130 105mm Given");
            }
        }

        private void AC13040mmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                byte[] bytes1 = new byte[3];
                bytes1[2] = (byte)104;
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), bytes1);
                byte[] bytes2 = new byte[3];
                bytes2[2] = (byte)104;
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), bytes2);
                byte[] bytes3 = new byte[3];
                bytes3[2] = (byte)104;
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), bytes3);
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2AC130 40mm Given");
            }
            else
            {
                byte[] bytes1 = new byte[3];
                bytes1[2] = (byte)105;
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), bytes1);
                byte[] bytes2 = new byte[3];
                bytes2[2] = (byte)105;
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), bytes2);
                byte[] bytes3 = new byte[3];
                bytes3[2] = (byte)105;
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), bytes3);
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2AC130 40mm Given");
            }
        }

        private void AC13025mmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                byte[] bytes1 = new byte[3];
                bytes1[2] = (byte)103;
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), bytes1);
                byte[] bytes2 = new byte[3];
                bytes2[2] = (byte)103;
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), bytes2);
                byte[] bytes3 = new byte[3];
                bytes3[2] = (byte)103;
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), bytes3);
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2AC130 25mm Given");
            }
            else
            {
                byte[] bytes1 = new byte[3];
                bytes1[2] = (byte)104;
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), bytes1);
                byte[] bytes2 = new byte[3];
                bytes2[2] = (byte)104;
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), bytes2);
                byte[] bytes3 = new byte[3];
                bytes3[2] = (byte)104;
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), bytes3);
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2AC130 25mm Given");
            }
        }

        private void IMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                byte[] bytes1 = new byte[3];
                bytes1[2] = (byte)129;
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), bytes1);
                byte[] bytes2 = new byte[3];
                bytes2[2] = (byte)129;
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), bytes2);
                byte[] bytes3 = new byte[3];
                bytes3[2] = (byte)129;
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), bytes3);
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2IMS Given");
            }
            else
            {
                byte[] bytes1 = new byte[3];
                bytes1[2] = (byte)130;
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), bytes1);
                byte[] bytes2 = new byte[3];
                bytes2[2] = (byte)130;
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), bytes2);
                byte[] bytes3 = new byte[3];
                bytes3[2] = (byte)130;
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), bytes3);
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2IMS Given");
            }
        }

        private void HarrierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                byte[] bytes1 = new byte[3];
                bytes1[2] = (byte)112;
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), bytes1);
                byte[] bytes2 = new byte[3];
                bytes2[2] = (byte)112;
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), bytes2);
                byte[] bytes3 = new byte[3];
                bytes3[2] = (byte)112;
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), bytes3);
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2HARRIER ROCKETS Given");
            }
            else
            {
                byte[] bytes1 = new byte[3];
                bytes1[2] = (byte)113;
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), bytes1);
                byte[] bytes2 = new byte[3];
                bytes2[2] = (byte)113;
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), bytes2);
                byte[] bytes3 = new byte[3];
                bytes3[2] = (byte)113;
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), bytes3);
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2HARRIER ROCKETS Given");
            }
        }

        private void DefaultWeaponToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                byte[] bytes1 = new byte[3];
                bytes1[2] = (byte)1;
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), bytes1);
                byte[] bytes2 = new byte[3];
                bytes2[2] = (byte)1;
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), bytes2);
                byte[] bytes3 = new byte[3];
                bytes3[2] = (byte)1;
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), bytes3);
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2Default Weapon Given");
            }
            else
            {
                byte[] bytes1 = new byte[3];
                bytes1[2] = (byte)1;
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), bytes1);
                byte[] bytes2 = new byte[3];
                bytes2[2] = (byte)1;
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), bytes2);
                byte[] bytes3 = new byte[3];
                bytes3[2] = (byte)1;
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), bytes3);
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2Default Weapon Given");
            }
        }

        private void HarrierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                byte[] bytes1 = new byte[3];
                bytes1[2] = (byte)111;
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), bytes1);
                byte[] bytes2 = new byte[3];
                bytes2[2] = (byte)111;
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), bytes2);
                byte[] bytes3 = new byte[3];
                bytes3[2] = (byte)111;
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), bytes3);
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2HARRIER Given");
            }
            else
            {
                byte[] bytes1 = new byte[3];
                bytes1[2] = (byte)112;
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), bytes1);
                byte[] bytes2 = new byte[3];
                bytes2[2] = (byte)112;
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), bytes2);
                byte[] bytes3 = new byte[3];
                bytes3[2] = (byte)112;
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), bytes3);
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2HARRIER Given");
            }
        }

        private void OspreyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                byte[] bytes1 = new byte[3];
                bytes1[2] = (byte)125;
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), bytes1);
                byte[] bytes2 = new byte[3];
                bytes2[2] = (byte)125;
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), bytes2);
                byte[] bytes3 = new byte[3];
                bytes3[2] = (byte)125;
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), bytes3);
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2OSPREY Given");
            }
            else
            {
                byte[] bytes1 = new byte[3];
                bytes1[2] = (byte)126;
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), bytes1);
                byte[] bytes2 = new byte[3];
                bytes2[2] = (byte)126;
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), bytes2);
                byte[] bytes3 = new byte[3];
                bytes3[2] = (byte)126;
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), bytes3);
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2OSPREY Given");
            }
        }

        private void F2000ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                byte[] bytes1 = new byte[3];
                bytes1[2] = (byte)62;
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), bytes1);
                byte[] bytes2 = new byte[3];
                bytes2[2] = (byte)62;
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), bytes2);
                byte[] bytes3 = new byte[3];
                bytes3[2] = (byte)62;
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), bytes3);
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2F2000 Given");
            }
            else
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 2,
          (byte) 63
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 2,
          (byte) 63
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 2,
          (byte) 63
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2F2000 Given");
            }
        }

        private void ASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                byte[] bytes1 = new byte[3];
                bytes1[2] = (byte)138;
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), bytes1);
                byte[] bytes2 = new byte[3];
                bytes2[2] = (byte)138;
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), bytes2);
                byte[] bytes3 = new byte[3];
                bytes3[2] = (byte)138;
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), bytes3);
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2ASSAULT DRONE ROCKETS Given");
            }
            else
            {
                byte[] bytes1 = new byte[3];
                bytes1[2] = (byte)139;
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), bytes1);
                byte[] bytes2 = new byte[3];
                bytes2[2] = (byte)139;
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), bytes2);
                byte[] bytes3 = new byte[3];
                bytes3[2] = (byte)139;
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), bytes3);
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2ASSAULT DRONE ROCKETS Given");
            }
        }

        private void NoobtubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                byte[] bytes1 = new byte[3];
                bytes1[2] = (byte)33;
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), bytes1);
                byte[] bytes2 = new byte[3];
                bytes2[2] = (byte)33;
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), bytes2);
                byte[] bytes3 = new byte[3];
                bytes3[2] = (byte)33;
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), bytes3);
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2NOOBTUBE Given");
            }
            else
            {
                byte[] bytes1 = new byte[3];
                bytes1[2] = (byte)34;
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), bytes1);
                byte[] bytes2 = new byte[3];
                bytes2[2] = (byte)34;
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), bytes2);
                byte[] bytes3 = new byte[3];
                bytes3[2] = (byte)34;
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), bytes3);
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2NOOBTUBE Given");
            }
        }

        private void PAVELOWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                byte[] bytes1 = new byte[3];
                bytes1[2] = (byte)113;
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), bytes1);
                byte[] bytes2 = new byte[3];
                bytes2[2] = (byte)113;
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), bytes2);
                byte[] bytes3 = new byte[3];
                bytes3[2] = (byte)113;
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), bytes3);
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2PAVELOW Given");
            }
            else
            {
                byte[] bytes1 = new byte[3];
                bytes1[2] = (byte)114;
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), bytes1);
                byte[] bytes2 = new byte[3];
                bytes2[2] = (byte)114;
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), bytes2);
                byte[] bytes3 = new byte[3];
                bytes3[2] = (byte)114;
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), bytes3);
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2PAVELOW Given");
            }
        }

        private void AUGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 8,
          (byte) 52
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 8,
          (byte) 52
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 8,
          (byte) 52
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2AUG Given");
            }
            else
            {
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 8,
          (byte) 53
                });
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 8,
          (byte) 53
                });
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]
                {
          (byte) 0,
          (byte) 8,
          (byte) 53
                });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2AUG Given");
            }
        }

        private void BBARRETTKAL50ScopelessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                byte[] bytes1 = new byte[3];
                bytes1[2] = (byte)42;
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), bytes1);
                byte[] bytes2 = new byte[3];
                bytes2[2] = (byte)42;
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), bytes2);
                byte[] bytes3 = new byte[3];
                bytes3[2] = (byte)42;
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), bytes3);
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2BARRETT KAL.50 SCOPELESS Given");
            }
            else
            {
                byte[] bytes1 = new byte[3];
                bytes1[2] = (byte)43;
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), bytes1);
                byte[] bytes2 = new byte[3];
                bytes2[2] = (byte)43;
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), bytes2);
                byte[] bytes3 = new byte[3];
                bytes3[2] = (byte)43;
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), bytes3);
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2BARRETT KAL.50 SCOPLESS Given");
            }
        }

        private void L118AScopelessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                byte[] bytes1 = new byte[3];
                bytes1[2] = (byte)45;
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), bytes1);
                byte[] bytes2 = new byte[3];
                bytes2[2] = (byte)45;
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), bytes2);
                byte[] bytes3 = new byte[3];
                bytes3[2] = (byte)45;
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), bytes3);
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2L118A SCOPELESS Given");
            }
            else
            {
                byte[] bytes1 = new byte[3];
                bytes1[2] = (byte)46;
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), bytes1);
                byte[] bytes2 = new byte[3];
                bytes2[2] = (byte)46;
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), bytes2);
                byte[] bytes3 = new byte[3];
                bytes3[2] = (byte)46;
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), bytes3);
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^ L118A SCOPLESS Given");
            }
        }

        private void DRAGUNOWSCOPELESSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                byte[] bytes1 = new byte[3];
                bytes1[2] = (byte)40;
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), bytes1);
                byte[] bytes2 = new byte[3];
                bytes2[2] = (byte)40;
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), bytes2);
                byte[] bytes3 = new byte[3];
                bytes3[2] = (byte)40;
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), bytes3);
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2DRAGUNOW SCOPELESS Given");
            }
            else
            {
                byte[] bytes1 = new byte[3];
                bytes1[2] = (byte)41;
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), bytes1);
                byte[] bytes2 = new byte[3];
                bytes2[2] = (byte)41;
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), bytes2);
                byte[] bytes3 = new byte[3];
                bytes3[2] = (byte)41;
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), bytes3);
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2DRAGUNOW SCOPELESS Given");
            }
        }

        private void AS50SCOPELESSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                byte[] bytes1 = new byte[3];
                bytes1[2] = (byte)44;
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), bytes1);
                byte[] bytes2 = new byte[3];
                bytes2[2] = (byte)44;
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), bytes2);
                byte[] bytes3 = new byte[3];
                bytes3[2] = (byte)44;
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), bytes3);
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2AS50 SCOPELESS Given");
            }
            else
            {
                byte[] bytes1 = new byte[3];
                bytes1[2] = (byte)45;
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), bytes1);
                byte[] bytes2 = new byte[3];
                bytes2[2] = (byte)45;
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), bytes2);
                byte[] bytes3 = new byte[3];
                bytes3[2] = (byte)45;
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), bytes3);
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2AS50 SCOPELESS Given");
            }
        }

        private void RSASSSCOPELESSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                byte[] bytes1 = new byte[3];
                bytes1[2] = (byte)43;
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), bytes1);
                byte[] bytes2 = new byte[3];
                bytes2[2] = (byte)43;
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), bytes2);
                byte[] bytes3 = new byte[3];
                bytes3[2] = (byte)43;
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), bytes3);
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2RSASS SCOPELESS Given");
            }
            else
            {
                byte[] bytes1 = new byte[3];
                bytes1[2] = (byte)44;
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), bytes1);
                byte[] bytes2 = new byte[3];
                bytes2[2] = (byte)44;
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), bytes2);
                byte[] bytes3 = new byte[3];
                bytes3[2] = (byte)44;
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), bytes3);
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2RSASS SCOPELESS Given");
            }
        }

        private void MSRSCOPELESSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MW3.getMapName() == "Seatown" | MW3.getMapName() == "Resistance" | MW3.getMapName() == "Underground" | MW3.getMapName() == "Arkaden" | MW3.getMapName() == "Downturn" | MW3.getMapName() == "Bootleg" | MW3.getMapName() == "Lockdown" | MW3.getMapName() == "Village" | MW3.getMapName() == "Erosion" | MW3.getMapName() == "Aground" | MW3.getMapName() == "Mission")
            {
                byte[] bytes1 = new byte[3];
                bytes1[2] = (byte)41;
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), bytes1);
                byte[] bytes2 = new byte[3];
                bytes2[2] = (byte)41;
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), bytes2);
                byte[] bytes3 = new byte[3];
                bytes3[2] = (byte)41;
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), bytes3);
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2MSR SCOPELESS Given");
            }
            else
            {
                byte[] bytes1 = new byte[3];
                bytes1[2] = (byte)42;
                PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), bytes1);
                byte[] bytes2 = new byte[3];
                bytes2[2] = (byte)42;
                PS3.SetMemory((uint)(17868273 + this.dataGridView1.CurrentRow.Index * 14720), bytes2);
                byte[] bytes3 = new byte[3];
                bytes3[2] = (byte)42;
                PS3.SetMemory((uint)(17868453 + this.dataGridView1.CurrentRow.Index * 14720), bytes3);
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
                {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2MSR SCOPELESS Given");
            }
        }

        private void TakeWeponsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(17868029 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]);
            PS3.SetMemory((uint)(17868021 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]);
            PS3.SetMemory((uint)(17868033 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]);
            PS3.SetMemory((uint)(17868025 + this.dataGridView1.CurrentRow.Index * 14720), new byte[3]);
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^1Take Weapons");
        }

        private void GiveAkimboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(17867392 + this.dataGridView1.CurrentRow.Index * 14720 + 713), new byte[1] { (byte)1 });
            PS3.SetMemory((uint)(17867392 + this.dataGridView1.CurrentRow.Index * 14720 + 689), new byte[1] { (byte)1 });
            PS3.SetMemory((uint)(17867392 + this.dataGridView1.CurrentRow.Index * 14720 + 725), new byte[1] { (byte)1 });
            PS3.SetMemory((uint)(17867392 + this.dataGridView1.CurrentRow.Index * 14720 + 701), new byte[1] { (byte)1 });
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2Give Akimbo ");
        }
        private static byte[] ReverseBytes(byte[] inArray)
        {
            Array.Reverse((Array)inArray);
            return inArray;
        }
        public static float[] ReadSingle(uint address, int length)
        {
            byte[] memory = PS5.GetMemory(address, length * 4);
            MW3.ReverseBytes(memory);
            float[] numArray = new float[length];
            for (int index = 0; index < length; ++index)
                numArray[index] = BitConverter.ToSingle(memory, (length - 1 - index) * 4);
            return numArray;
        }
        public static void WriteSingle(uint address, float[] input)
        {
            int length = input.Length;
            byte[] bytes = new byte[length * 4];
            for (int index = 0; index < length; ++index)
                MW3.ReverseBytes(BitConverter.GetBytes(input[index])).CopyTo((Array)bytes, index * 4);
            PS3.SetMemory(address, bytes);
        }
        private static int G_Spawn()
        {
            return MW3RPC.Call(1836428U);
        }
        public static int SpawnTurret(string Type, string ModelName, float[] Angles, float[] Pos)
        {
            int num = MW3.G_Spawn();
            MW3.WriteSingle((uint)(num + 312), new float[3]
            {
        Pos[0],
        Pos[1],
        Pos[2]
            });
            MW3.WriteSingle((uint)(num + 324), new float[3]
            {
        Angles[0],
        Angles[1],
        Angles[2]
            });
            MW3RPC.Call(1830748U, (object)num, (object)ModelName);
            MW3RPC.Call(1896680U, (object)num, (object)Type);
            return num;
        }
        public static uint G_Client(int clientIndex, uint Mod = 0)
        {
            return MW3.G_ClientOffset + Mod + (uint)((ulong)MW3.G_ClientSize * (ulong)clientIndex);
        }
        public static void OnAnglesToForward(int Client, int Distance_in_Meters = 6)
        {
            float[] numArray = MW3.ReadSingle(MW3.G_Client(Client, 0U) + 28U, 3);
            float[] Angles = MW3.ReadSingle(MW3.G_Client(Client, 0U) + 344U, 3);
            float num1 = (float)(Distance_in_Meters * 10);
            float num2 = (float)Math.Sin((double)Angles[0] * Math.PI / 180.0) * num1;
            float num3 = (float)Math.Sqrt((double)num1 * (double)num1 - (double)num2 * (double)num2);
            float num4 = (float)Math.Sin((double)Angles[1] * Math.PI / 180.0) * num3;
            float num5 = (float)Math.Cos((double)Angles[1] * Math.PI / 180.0) * num3;
            float[] Pos = new float[3]
            {
        numArray[0] + num5,
        numArray[1] + num4,
        numArray[2] += 50f - num2
            };
            MW3.SpawnTurret("sentry_minigun_mp", "weapon_minigun", Angles, Pos);
        }
        private void SpawnTurrentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MW3.OnAnglesToForward(this.dataGridView1.CurrentRow.Index, 6);
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2Turrent Spawned");
            Thread.Sleep(3000);
        }

        private void EnableToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(17868607 + this.dataGridView1.CurrentRow.Index * 14720), new byte[52]
     {
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 12,
        (byte) 48,
        (byte) 142,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 7,
        byte.MaxValue,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
     });
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "All Perks ^2ON");
        }

        private void DisableToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(17868607 + this.dataGridView1.CurrentRow.Index * 14720), new byte[155]
      {
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 1,
        (byte) 55,
        (byte) 145,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 7,
        byte.MaxValue,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0
      });
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "All Perks ^1OFF");
        }

        private void EnableToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(17881215 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1] { (byte)1 });
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "NoClip ^2ON");
        }

        private void DisableToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(17881215 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]);
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "NoClip ^1OFF");
        }

        private void DisableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte[] bytes1 = new byte[3];
            bytes1[2] = (byte)100;
            PS3.SetMemory((uint)(16557085 + this.dataGridView1.CurrentRow.Index * 640), bytes1);
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "Godmode ^1OFF");
            PS3.SetMemory((uint)(17867814 + this.dataGridView1.CurrentRow.Index * 14720), new byte[2]
            {
        (byte) 0,
        (byte) 100
            });
            byte[] bytes2 = new byte[3];
            bytes2[2] = (byte)100;
            PS3.SetMemory((uint)(17880622 + this.dataGridView1.CurrentRow.Index * 14720), bytes2);
        }

        private void EnableToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(17868659 + this.dataGridView1.CurrentRow.Index * 14720), new byte[2]
      {
        (byte) 197,
        byte.MaxValue
      });
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "Explosiv Ammo ^2ON");
        }

        private void DisableToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(17868659 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]);
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "Explosiv Ammo ^1OFF");
        }
        public static void PS3Frezze(uint Client)
        {
            PS3.SetMemory((uint)(0x110a500 + (Client * 0x3980)), new byte[] { 0x00, 0xe5, 0xd0 });
            PS3.SetMemory((uint)(0x110a506 + (Client * 0x3980)), new byte[] { 0x00, 0xe5, 0xd0 });
            PS3.SetMemory((uint)(0x110a520 + (Client * 0x3980)), new byte[] { 0xdf, 0xe5, 0xd0, 0xd0 });
            PS3.SetMemory((uint)(0x110a528 + (Client * 0x3980)), new byte[] { 0xdf, 0xe5, 0xd0, 0xd0 });
        }
        private void Ps3FrezzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2PS3 ^1FREZZED^5By ^2Vortex^1RTM");
            Thread.Sleep(1500);
            MW3.PS3Frezze((uint)this.dataGridView1.CurrentRow.Index);
        }
        private void Button21_Click(object sender, EventArgs e)
        {
            if (button21.Text == "GodMode OFF")
            {
                uint cgArray = PS3.Extension.ReadUInt32(0x7BD008);
                uint localClientNumber = PS3.Extension.ReadUInt32(cgArray + 0x150);
                MW3RCE.RCE.WriteUInt32(0xFCA41E + (localClientNumber * 0x280), 0xFF);
                button21.Text = "GodMode ON";
            }
            else if (button21.Text == "GodMode ON")
            {
                button21.Text = "GodMode OFF";
                uint cgArray = PS3.Extension.ReadUInt32(0x7BD008);
                uint localClientNumber = PS3.Extension.ReadUInt32(cgArray + 0x150);
                MW3RCE.RCE.WriteUInt32(0xFCA41E + (localClientNumber * 0x280), 0x00);
            }
        }
        public void WriteUInt32_ROP_1_Exploit(uint Address, uint Value)
        {
            PS3.Extension.WriteUInt32(0x10055014, Value);
            PS3.Extension.WriteUInt32(0x10055010, Address);
            PS3.Extension.WriteUInt32(0x10055000, 2);

            while (PS3.Extension.ReadUInt32(0x10055000) == 2)
                Thread.Sleep(1);
        }
        private void Button22_Click(object sender, EventArgs e)
        {

        }

        private void Button23_Click(object sender, EventArgs e)
        {
            uint cgArray = PS3.Extension.ReadUInt32(0x7BD008);
            uint localClientNumber = PS3.Extension.ReadUInt32(cgArray + 0x150);
            MW3RCE.RCE.WriteUInt32(0x3980 + (localClientNumber * 0x280), 0xFF);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = NonHostTab;
        }

        private void EnableToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(17880891 + this.dataGridView1.CurrentRow.Index * 14720), new byte[17]
     {
        (byte) 1,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 1
     });
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "UAV ^2ON");
        }

        private void DisableToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(17867411 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1] { (byte)16 });
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "Redbox ^2ON");
            byte[] buffer = new byte[0];
            PS3.SetMemory(17867411, buffer);
        }

        private void SpeedX2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(17880620 + this.dataGridView1.CurrentRow.Index * 14720), new byte[22]
      {
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 100,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 63,
        byte.MaxValue
      });
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "Speed x2 ^2ON");
        }

        private void SpeedX4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(17880620 + this.dataGridView1.CurrentRow.Index * 14720), new byte[22]
     {
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 100,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 64,
        (byte) 171
     });
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "Speed x4 ^2ON");
        }

        private void DefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(17880620 + this.dataGridView1.CurrentRow.Index * 14720), new byte[22]
     {
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 100,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 63,
        (byte) 128
     });
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "Speed ^1OFF");
        }

        private void SpiningModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^5360 *_*");
                PS3.SetMemory((uint)(17881215 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 4
        });
                Funcs.SpinMode(this.dataGridView1.CurrentRow.Index);
                PS3.SetMemory((uint)(17881215 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]);
            }
        }

        private void SnakeModeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            {
                PS3.SetMemory((uint)(17867405 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 84
        });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "Snake Mode ^5ON");
            }
        }

        private void BO1JumpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(17868659 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
     {
        byte.MaxValue
     });
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "BO1 Jump ^2ON");
        }

        private void ToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            {
                PS3.SetMemory((uint)(17868030 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]);
                PS3.SetMemory((uint)(17868274 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]);
                PS3.SetMemory((uint)(17868326 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]);
                PS3.SetMemory((uint)(17868454 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]);
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
        {
        (byte) 15,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
        });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^1Camo Reset");
            }
        }

        private void ClassicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                PS3.SetMemory((uint)(17868030 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 1
        });
                PS3.SetMemory((uint)(17868274 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 1
        });
                PS3.SetMemory((uint)(17868326 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 1
        });
                PS3.SetMemory((uint)(17868454 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 1
        });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
        {
        (byte) 15,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
        });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "Camo set to ^2Classic");
            }
        }

        private void ToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            {
                PS3.SetMemory((uint)(17868030 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 2
        });
                PS3.SetMemory((uint)(17868274 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 2
        });
                PS3.SetMemory((uint)(17868326 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 2
        });
                PS3.SetMemory((uint)(17868454 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 2
        });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
        {
        (byte) 15,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
        });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "Camo set to ^2Snow");
            }
        }

        private void ToolStripMenuItem13_Click(object sender, EventArgs e)
        {
            {
                PS3.SetMemory((uint)(17868030 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 3
        });
                PS3.SetMemory((uint)(17868274 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 3
        });
                PS3.SetMemory((uint)(17868326 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 3
        });
                PS3.SetMemory((uint)(17868454 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 3
        });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
        {
        (byte) 15,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
        });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "Camo set to ^2Multicam");
            }
        }

        private void ToolStripMenuItem14_Click(object sender, EventArgs e)
        {
            {
                PS3.SetMemory((uint)(17868030 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 4
        });
                PS3.SetMemory((uint)(17868274 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 4
        });
                PS3.SetMemory((uint)(17868326 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 4
        });
                PS3.SetMemory((uint)(17868454 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 4
        });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
        {
        (byte) 15,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
        });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "Camo set to ^2Digital");
            }
        }

        private void ToolStripMenuItem15_Click(object sender, EventArgs e)
        {
            {
                PS3.SetMemory((uint)(17868030 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 5
        });
                PS3.SetMemory((uint)(17868274 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 5
        });
                PS3.SetMemory((uint)(17868326 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 5
        });
                PS3.SetMemory((uint)(17868454 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 5
        });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
        {
        (byte) 15,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
        });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "Camo set to ^2Hex");
            }
        }

        private void ToolStripMenuItem16_Click(object sender, EventArgs e)
        {
            {
                PS3.SetMemory((uint)(17868030 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 6
        });
                PS3.SetMemory((uint)(17868274 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 6
        });
                PS3.SetMemory((uint)(17868326 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 6
        });
                PS3.SetMemory((uint)(17868454 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 6
        });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
        {
        (byte) 15,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
        });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "Camo set to ^2Choco");
            }
        }

        private void ToolStripMenuItem17_Click(object sender, EventArgs e)
        {
            {
                PS3.SetMemory((uint)(17868030 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 7
        });
                PS3.SetMemory((uint)(17868274 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 7
        });
                PS3.SetMemory((uint)(17868326 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 7
        });
                PS3.SetMemory((uint)(17868454 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 7
        });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
        {
        (byte) 15,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
        });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "Camo set to ^2Snake");
            }
        }

        private void ToolStripMenuItem18_Click(object sender, EventArgs e)
        {
            {
                PS3.SetMemory((uint)(17868030 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 8
        });
                PS3.SetMemory((uint)(17868274 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 8
        });
                PS3.SetMemory((uint)(17868326 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 8
        });
                PS3.SetMemory((uint)(17868454 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 8
        });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
        {
        (byte) 15,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
        });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "Camo set to ^2Blue");
            }
        }

        private void ToolStripMenuItem48_Click(object sender, EventArgs e)
        {
            {
                PS3.SetMemory((uint)(17868030 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 9
        });
                PS3.SetMemory((uint)(17868274 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 9
        });
                PS3.SetMemory((uint)(17868326 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 9
        });
                PS3.SetMemory((uint)(17868454 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 9
        });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
        {
        (byte) 15,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
        });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "Camo set to ^2Red");
            }
        }

        private void AutnumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                PS3.SetMemory((uint)(17868030 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 10
        });
                PS3.SetMemory((uint)(17868274 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 10
        });
                PS3.SetMemory((uint)(17868326 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 10
        });
                PS3.SetMemory((uint)(17868454 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 10
        });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
        {
        (byte) 15,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
        });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "Camo set to ^2Autnum");
            }
        }

        private void ToolStripMenuItem56_Click(object sender, EventArgs e)
        {
            {
                PS3.SetMemory((uint)(17868030 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 13
        });
                PS3.SetMemory((uint)(17868274 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 13
        });
                PS3.SetMemory((uint)(17868326 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 13
        });
                PS3.SetMemory((uint)(17868454 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 13
        });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
        {
        (byte) 15,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
        });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "Camo set to ^2Winter");
            }
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            {
                PS3.SetMemory((uint)(17868030 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 12
        });
                PS3.SetMemory((uint)(17868274 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 12
        });
                PS3.SetMemory((uint)(17868326 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 12
        });
                PS3.SetMemory((uint)(17868454 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 12
        });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
        {
        (byte) 15,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
        });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "Camo set to ^2Marine");
            }
        }

        private void ToolStripMenuItem50_Click(object sender, EventArgs e)
        {

            {
                PS3.SetMemory((uint)(17868030 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 11
        });
                PS3.SetMemory((uint)(17868274 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 11
        });
                PS3.SetMemory((uint)(17868326 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 11
        });
                PS3.SetMemory((uint)(17868454 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]
        {
        (byte) 11
        });
                PS3.SetMemory((uint)(17868456 + this.dataGridView1.CurrentRow.Index * 14720), new byte[4]
        {
        (byte) 15,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
        });
                MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "Camo set to ^2Gold");
            }
        }

        private void EnableToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(17868607 + this.dataGridView1.CurrentRow.Index * 14720), new byte[52]
     {
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 12,
        (byte) 48,
        (byte) 142,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 7,
        byte.MaxValue,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
     });
            byte[] buffer1 = new byte[4]
            {
        (byte) 65,
        (byte) 130,
        (byte) 0,
        (byte) 148
            };
            PS3.SetMemory(204140, buffer1);
            byte[] buffer2 = new byte[4]
            {
        (byte) 192,
        (byte) 36,
        (byte) 0,
        (byte) 0
            };
            PS3.SetMemory(204164, buffer2);
            byte[] buffer3 = new byte[4]
            {
        (byte) 64,
        (byte) 130,
        (byte) 0,
        (byte) 60
            };
            PS3.SetMemory(204172, buffer3);
            byte[] buffer4 = new byte[4]
            {
        (byte) 65,
        (byte) 130,
        (byte) 0,
        (byte) 148
            };
            PS3.SetMemory(203588, buffer4);
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "Rapidfire ^2ON");
        }

        private void DisableToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            byte[] buffer1 = new byte[4]
     {
        (byte) 65,
        (byte) 130,
        (byte) 0,
        (byte) 148
     };
            PS3.SetMemory(204140, buffer1);
            byte[] buffer2 = new byte[4]
            {
        (byte) 192,
        (byte) 36,
        (byte) 0,
        (byte) 8
            };
            PS3.SetMemory(204164, buffer2);
            byte[] buffer3 = new byte[4]
            {
        (byte) 64,
        (byte) 130,
        (byte) 0,
        (byte) 60
            };
            PS3.SetMemory(204172, buffer3);
            byte[] buffer4 = new byte[4];
            PS3.SetMemory(203588, buffer4);
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "Rapidfire ^1OFF");
        }
        public static float[] GetOrigin(uint client)
        {
            return MW3.ReadSingle((uint)(17867420 + 14720 * (int)client), 3);
        }
        public static uint MW3CheckHost()
        {
            string str = PS3.Extension.ReadString(29080620U);
            for (uint index = 0; index < 18U; ++index)
            {
                if (str == PS3.Extension.ReadString((uint)(17880588 + (int)index * 14720)))
                    return index;
            }
            return 18;
        }
        private static void SetOrigin(uint Client, float[] Origin)
        {
            PS5.Extension.WriteFloatArray((uint)(17867420 + (int)Client * 14720), Origin);
        }
        public static void TeleportCToH(uint Client, uint toClient)
        {
            float[] origin = MW3.GetOrigin(toClient);
            MW3.SetOrigin(Client, origin);
        }
        private void HIMToMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MW3.TeleportCToH((uint)this.dataGridView1.CurrentRow.Index, MW3.MW3CheckHost());
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            byte[] numArray = new byte[4];
            numArray[0] = (byte)96;
            byte[] buffer = numArray;
            PS3.SetMemory(417044, buffer);
            byte[] buffer2 = new byte[1] { (byte)2 };
            PS3.SetMemory(389223, buffer2);
        }

        private void Button35_Click(object sender, EventArgs e)
        {
            if (button35.Text == "OFF")
            {
                byte[] numArray = new byte[4];
                numArray[0] = (byte)96;
                byte[] buffer = numArray;
                PS3.SetMemory(417044, buffer);
                button35.Text = "ON";
            }
            else if (button35.Text == "ON")
            {

                byte[] buffer = new byte[4]
                {
          (byte) 65,
          (byte) 130,
          (byte) 0,
          (byte) 12
                };
                PS3.SetMemory(417044, buffer);
                button35.Text = "OFF";
            }
        }

        private void Button150_Click(object sender, EventArgs e)
        {
            if (button150.Text == "OFF")
            {
                byte[] buffer = new byte[1] { (byte)2 };
                PS3.SetMemory(389223, buffer);
                button150.Text = "ON";
            }
            else if (button150.Text == "ON")
            {

                byte[] buffer = new byte[1] { (byte)1 };
                PS3.SetMemory(389223, buffer);
                button150.Text = "OFF";
            }
        }

        private void Button24_Click_1(object sender, EventArgs e)
        {
            if (button24.Text == "OFF")
            {
                byte[] buffer = new byte[1] { (byte)2 };
                PS3.SetMemory(389223, buffer);
                button24.Text = "ON";
            }
            else if (button24.Text == "ON")
            {

                byte[] buffer = new byte[1] { (byte)1 };
                PS3.SetMemory(389223, buffer);
                button24.Text = "OFF";
            }
        }

        private void Button33_Click(object sender, EventArgs e)
        {
            if (button33.Text == "OFF")
            {
                byte[] numArray = new byte[4];
                numArray[0] = (byte)96;
                byte[] buffer = numArray;
                PS3.SetMemory(779984, buffer);
                button33.Text = "ON";
            }
            else if (button33.Text == "ON")
            {

                byte[] buffer = new byte[4]
         {
          (byte) 75,
          (byte) 248,
          (byte) 21,
          (byte) 1
         };
                PS3.SetMemory(779984, buffer);
                button33.Text = "OFF";
            }
        }

        private void Button31_Click(object sender, EventArgs e)
        {
            if (button31.Text == "OFF")
            {
                byte[] buffer = new byte[1] { (byte)1 };
                PS3.SetMemory(26075496, buffer);
                button31.Text = "ON";
            }
            else if (button31.Text == "ON")
            {

                byte[] buffer = new byte[1] { (byte)63 };
                PS3.SetMemory(26075496, buffer);
                button31.Text = "OFF";
            }
        }

        private void Button38_Click(object sender, EventArgs e)
        {
            if (button38.Text == "OFF")
            {
                byte[] buffer1 = new byte[1] { (byte)1 };
                PS3.SetMemory(3769567, buffer1);
                byte[] buffer2 = new byte[2]
                {
                (byte) 5,
                (byte) 112
                };
                PS3.SetMemory(3769586, buffer2);
                button38.Text = "ON";
            }
            else if (button38.Text == "ON")
            {

                byte[] buffer1 = new byte[1];
                PS3.SetMemory(3769567, buffer1);
                byte[] buffer2 = new byte[2]
                {
                (byte) 5,
                (byte) 106
                };
                PS3.SetMemory(3769586, buffer2);
                button38.Text = "OFF";
            }
        }

        private void Button36_Click(object sender, EventArgs e)
        {
            if (button36.Text == "OFF")
            {
                byte[] buffer1 = new byte[1] { (byte)1 };
                PS3.SetMemory(3769567, buffer1);
                byte[] buffer2 = new byte[2]
                {
                (byte) 5,
                (byte) 112
                };
                PS3.SetMemory(3769586, buffer2);
                button36.Text = "ON";
            }
            else if (button36.Text == "ON")
            {

                byte[] buffer1 = new byte[1];
                PS3.SetMemory(3769567, buffer1);
                byte[] buffer2 = new byte[2]
                {
                (byte) 5,
                (byte) 106
                };
                PS3.SetMemory(3769586, buffer2);
                button36.Text = "OFF";
            }
        }

        private void Button40_Click(object sender, EventArgs e)
        {
            if (button40.Text == "OFF")
            {
                PS3.SetMemory(26005116U, new byte[1] { (byte)1 });
                button40.Text = "ON";
            }
            else if (button40.Text == "ON")
            {

                PS3.SetMemory(26005116U, new byte[1]);
                button40.Text = "OFF";
            }
        }

        private void Button42_Click(object sender, EventArgs e)
        {
            if (button40.Text == "OFF")
            {
                byte[] buffer = new byte[8]
        {
          (byte) 92,
          (byte) 0,
          (byte) 76,
          (byte) 1,
          (byte) 0,
          (byte) 80,
          (byte) 32,
          (byte) 0
        };
                PS3.SetMemory(0x25978523, buffer);
                button40.Text = "ON";
            }
            else if (button40.Text == "ON")
            {
                byte[] buffer = new byte[8]
       {
          (byte) 92,
          (byte) 0,
          (byte) 76,
          (byte) 1,
          (byte) 0,
          (byte) 64,
          (byte) 32,
          (byte) 0
       };
                PS3.SetMemory(0x25978523, buffer);

                button40.Text = "OFF";
            }
        }

        private void Button28_Click(object sender, EventArgs e)
        {

        }

        private void Button26_Click(object sender, EventArgs e)
        {

        }

        private void Button44_Click(object sender, EventArgs e)
        {
            if (button44.Text == "OFF")
            {
                PS3.SetMemory(3747339U, new byte[1] { (byte)1 });
                button44.Text = "ON";
            }
            else if (button44.Text == "ON")
            {

                PS3.SetMemory(3747339U, new byte[1]);
                button44.Text = "OFF";
            }
        }
        
        private void Button21_Click_1(object sender, EventArgs e)
        {
            uint cgArray = PS5.Extension.ReadUInt32(0x7BD008);
            uint localClientNumber = PS5.Extension.ReadUInt32(cgArray + 0x150);
            MW3RCE.RCE.WriteUInt32(0xFCA41E + (localClientNumber * 0x280), 0xFF);
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            WebClient fetchInfo = new WebClient();
            string hwidstr = "";
            string debug = fetchInfo.DownloadString("https://dayz.planb-life.com/execute.php?action=hwid&userName=" + textBox1.Text);
            if (debug == "")
            {
                DialogResult result = MessageBox.Show("There is no computer for the license registered you want to enter this computer?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    hwidstr = Login2.GetMachineGuid();
                }
                else if (result == DialogResult.No)
                {
                    hwidstr = "0";
                }
            }

            if (Login2.Execute("accessAccount", "userName=" + textBox1.Text + "&password=" + textBox2.Text + "&hwid=" + hwidstr) == 1)
            {
                E3Modz.Properties.Settings.Default["username"] = textBox1.Text;
                E3Modz.Properties.Settings.Default["password"] = textBox2.Text;
                E3Modz.Properties.Settings.Default.Save();
                Username = textBox1.Text; //To pass it to any other froms (=global)
                Password = textBox2.Text;
                //same for pass
                string premiumState = fetchInfo.DownloadString("https://dayz.planb-life.com/execute.php?action=isPremium&userName=" + Username);
                string HWID = fetchInfo.DownloadString("https://dayz.planb-life.com/execute.php?action=hwid&userName=" + Username);
                if (HWID == Login2.GetMachineGuid())
                {
                    if (premiumState == "1")
                    {



                    }
                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Login Failed License not avaible on this Computer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Button22_Click_1(object sender, EventArgs e)
        {
            Funcs.NonHostEndMatch();
        }

        private void Button69_Click(object sender, EventArgs e)
        {
            Funcs.NonHostEndMatch();
        }

        private void Button71_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(29080620u, new byte[]
                {
                    94,
                    1,
                    224,
                    16,
                    249,
                    0
                });
        }

        private void Button72_Click(object sender, EventArgs e)
        {
            {
                byte[] bytes1 = Encoding.ASCII.GetBytes("");
                Array.Resize<byte>(ref bytes1, bytes1.Length + 1);
                PS3.SetMemory(8989710U, bytes1);
                byte[] numArray1 = new byte[1] { (byte)21 };
                PS3.SetMemory(29463676U, numArray1);
                byte[] numArray2 = new byte[1];
                PS3.SetMemory(8989715U, numArray2);
                byte[] bytes2 = Encoding.Default.GetBytes("^2FreezedByVortexRTM");
                Array.Resize<byte>(ref bytes2, bytes2.Length + 1);
                PS3.SetMemory(29080620U, bytes2);
                Thread.Sleep(400);
                byte[] numArray3 = new byte[29]
        {
        (byte) 94,
        (byte) 1,
        (byte) 224,
        (byte) 16,
        (byte) 249,
        (byte) 0,
        (byte) 121,
        (byte) 32,
        (byte) 70,
        (byte) 114,
        (byte) 101,
        (byte) 101,
        (byte) 122,
        (byte) 101,
        (byte) 32,
        (byte) 98,
        (byte) 121,
        (byte) 32,
        (byte) 84,
        (byte) 114,
        (byte) 97,
        (byte) 105,
        (byte) 108,
        (byte) 101,
        (byte) 114,
        (byte) 77,
        (byte) 111,
        (byte) 68,
        (byte) 122
        };
                PS3.SetMemory(29080620U, numArray3);
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = RCEExploitTab;
        }

        private void Button23_Click_1(object sender, EventArgs e)
        {

            uint cgArray = PS3.Extension.ReadUInt32(0x7BD008);
            uint localClientNumber = PS3.Extension.ReadUInt32(cgArray + 0x150);
            WriteUInt32_ROP_1_Exploit(0x0110D87C + (localClientNumber * 0x3980), 2);
        }

        private void AntiQuitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void method_25(int int_4, string string_3)
        {
            MW3.SV_GameSendServerCommand(int_4, "q " + string_3);
        }
        private void EnableToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            byte[] bytes = new byte[32];
            this.method_25(this.dataGridView1.CurrentRow.Index, "g_scriptmainmenu \"byTehPoisoneOne\"");
            Thread.Sleep(10);
            PS3.SetMemory(5389104U, bytes);
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^1Quitting Disabled!");
        }
        public static float[] GetOrigin2(int client)
        {
            return MW3.ReadSingle((uint)(17867420 + 14720 * client), 3);
        }
        public static void TeleportCToC(uint Client, int toClient)
        {
            float[] origin2 = MW3.GetOrigin2(toClient);
            MW3.SetOrigin(Client, origin2);
        }
        private void METoHIMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MW3.TeleportCToC(MW3.MW3CheckHost(), this.dataGridView1.CurrentRow.Index);
        }
        public static void TeleportAllTo(int Client)
        {
            float[] origin2 = MW3.GetOrigin2(Client);
            for (uint Client1 = 0; Client1 < 18U; ++Client1)
            {
                if ((long)Client != (long)Client1)
                    MW3.SetOrigin(Client1, origin2);
            }
        }
        private void ALLToHIMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MW3.TeleportAllTo(this.dataGridView1.CurrentRow.Index);
        }

        private void SaveHisPositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS5.GetMemoryR((uint)(17867420 + this.dataGridView1.CurrentRow.Index * 14720), ref MW3.savedcoordinates);
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2Your Position is Saved");
        }

        private void ToSavePositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(17867420 + this.dataGridView1.CurrentRow.Index * 14720), MW3.savedcoordinates);
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2Teleport to Saved Position");
        }
        public static void SetOrigin(int Client, float[] Origin)
        {
            MW3.WriteSingle((uint)(17867392 + 14720 * Client + 28), Origin);
        }
        public static void space(int Client)
        {
            float[] Origin = MW3.ReadSingle(MW3.G_Client(Client, 0U) + 28U, 3);
            Origin[2] += 10000f;
            MW3.SetOrigin(Client, Origin);
        }
        private void SkyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MW3.space(this.dataGridView1.CurrentRow.Index);
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2Teleported to Sky");
        }

        private void ToPlatformToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DisableToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            byte[] bytes = new byte[32];
            this.method_25(this.dataGridView1.CurrentRow.Index, "g_scriptmainmenu \"class\"");
            Thread.Sleep(10);

            PS3.SetMemory(5389104U, bytes);
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2Quiting Enabled!");
        }

        private void FriendlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(17880663 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1] { (byte)1 });
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2Team Changed");
        }

        private void EnemyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(17880663 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1] { (byte)2 });
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2Team Changed");
        }

        private void SpectatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(17880663 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1] { (byte)6 });
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2Team Changed");
        }

        private void FreeForAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(17880663 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1] { (byte)4 });
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2Team Changed");
        }

        private void AudienceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(17880663 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1] { (byte)3 });
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2Team Changed");
        }

        private void EnableToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(17867392 + this.dataGridView1.CurrentRow.Index * 14720 + 13103), new byte[1] { (byte)1 });
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^1Look at your Internet ^1BITCH!!!!!");
        }

        private void DisableToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(17867392 + this.dataGridView1.CurrentRow.Index * 14720 + 13103), new byte[1] { (byte)2 });
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2500K Internet Given!");
        }

        private void EnableToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(17881215 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1] { (byte)4 });
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "Frezze ^2ON");
        }

        private void DisableToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(17881215 + this.dataGridView1.CurrentRow.Index * 14720), new byte[1]);
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "Frezze ^1OFF");
        }
        public static uint G_Entity(int clientIndex, uint Mod = 0)
        {
            return MW3.G_EntityOffset + Mod + (uint)((ulong)MW3.G_EntitySize * (ulong)clientIndex);
        }
        public static void Suicide(uint Client)
        {
            PS5.Extension.WriteByte((uint)(16556929 + (int)Client * 640), (byte)1);
            Thread.Sleep(500);
            PS5.Extension.WriteByte((uint)(16556929 + (int)Client * 640), (byte)0);
        }
        public static void PlayerDie(uint Killer, uint Victim)
        {
            if ((int)Killer == (int)Victim)
                MW3.Suicide(Victim);
            else
                MW3RPC.Call(1588760U, (object)MW3.G_Entity((int)Victim, 0U), (object)MW3.G_Entity((int)Killer, 0U), (object)MW3.G_Entity(0, 0U), (object)3490512748U, (object)3490512808U, (object)100, (object)0, (object)1, (object)0, (object)4984, (object)268471712, (object)3490512676U, (object)3490509100U);
        }
        private void ToolStripMenuItem67_Click(object sender, EventArgs e)
        {
            MW3.PlayerDie(MW3.MW3CheckHost(), (uint)this.dataGridView1.CurrentRow.Index);
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^1You have been Killed!");
        }

        private void SuicideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MW3.Suicide((uint)this.dataGridView1.CurrentRow.Index);
            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^7Why You Kill you????? ^2Are you an ^1Noob?");
        }
        public static void KickClient(uint Client)
        {
            RPC.Call(2265120U, (object)Client, (object)"EXE_PLAYERKICKED");
        }
        private void KickToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MW3.KickClient((uint)this.dataGridView1.CurrentRow.Index);
        }
        public static void ultraPS3Frezze(uint Client)
        {
            PS3.SetMemory((uint)(0x110a29c + (0x3980 * Client)), new byte[] { 0xC4, 0x7E, 0xFF, 0xFF, 0xFF });
            PS3.SetMemory((uint)(17867492 + Client * 14720), new byte[]
            {
                68
            });
            for (byte b = 0; b < 87; b += 1)
            {
                PS3.SetMemory((uint)(0x110a29c + (0x3980 * Client)), new byte[] { 0xC4, 0x7E, 0xFF, 0xFF, 0xFF });
                PS3.SetMemory((uint)(17867493 + Client * 14720), new byte[]
                  {
                  b
                  });
                PS3.SetMemory((uint)(0x110a29c + (0x3980 * Client)), new byte[] { 0xC4, 0x7E, 0xFF, 0xFF, 0xFF });
                Thread.Sleep(50);
            }

            PS3.SetMemory((uint)(17867492 + Client * 14720), new byte[]
            {
                68
            });
            PS3.SetMemory((uint)(0x110a29c + (0x3980 * Client)), new byte[] { 0xC4, 0x7E, 0xFF, 0xFF, 0xFF });
            for (byte b = 0; b < 87; b += 1)
            {
                PS3.SetMemory((uint)(17867493 + Client * 14720), new byte[]
                  {
                  b
                  });
                PS3.SetMemory((uint)(0x110a29c + (0x3980 * Client)), new byte[] { 0xC4, 0x7E, 0xFF, 0xFF, 0xFF });
                Thread.Sleep(50);
            }
        }
        private void UltraPS3FreezeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MW3.iPrintln(this.dataGridView1.CurrentRow.Index, "^2PROJECT VORTEX ^2FREEZED YOUR ^5PS3 :/ :/ :/ :/");
            Thread.Sleep(1500);
            MW3.ultraPS3Frezze((uint)this.dataGridView1.CurrentRow.Index);
        }

        private void NoGunToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Button70_Click(object sender, EventArgs e)
        {
            this.tabControl2.SelectedTab = tabPage3;
        }

        private void Button75_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < 18; ++index)
            {
                byte[] buffer = new byte[17];
                PS5.GetMemoryR(29097532, ref buffer);
                string @string = Encoding.ASCII.GetString(buffer);
                this.textBox6.Text = @string;
                if (!this.IpList.Items.Contains((object)@string))
                    this.IpList.Items.Add((object)@string);
            }
        }

        private void Button76_Click(object sender, EventArgs e)
        {
            this.IpList.Items.Clear();
        }

        private void Button73_Click(object sender, EventArgs e)
        {
            this.tabControl2.SelectedTab = tabPage2;
        }
        public static string MW3GetNames(uint clientIndex)
        {
            byte[] Buffer = new byte[16];
            PS5.GetMemoryR(MW3.NameAddress + 14720U * clientIndex, ref Buffer);
            return Encoding.ASCII.GetString(Buffer).Replace("\0", "");
        }
        private void Button77_Click(object sender, EventArgs e)
        {
            for (uint index = 0; index < 18U; ++index)
            {
                if (this.Kicklist.Items.Cast<object>().Select<object, string>((Func<object, string>)(x => x.ToString())).Contains<string>(MW3.MW3GetNames(index)))
                    MW3.KickClient(index);
            }
        }

        private void Button80_Click(object sender, EventArgs e)
        {
            this.Kicklist.Items.Clear();
        }
        public static void SaveTextIntoListBox(ListBox listBox)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text (*.txt)|*.txt";
            SaveFileDialog saveFileDialog2 = saveFileDialog1;
            if (saveFileDialog2.ShowDialog() != DialogResult.OK)
                return;
            using (StreamWriter streamWriter = new StreamWriter(saveFileDialog2.FileName, false))
            {
                foreach (object obj in listBox.Items)
                    streamWriter.Write(obj.ToString() + Environment.NewLine);
            }
            int num = (int)MessageBox.Show("PlayerList Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void Button81_Click(object sender, EventArgs e)
        {
            MW3.SaveTextIntoListBox(this.Kicklist);
        }
        public static void LoadTextIntoListBox(ListBox listBox)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            OpenFileDialog openFileDialog2 = openFileDialog1;
            if (openFileDialog2.ShowDialog() != DialogResult.OK)
                return;
            listBox.Items.Clear();
            using (TextReader textReader = (TextReader)new StreamReader(openFileDialog2.FileName))
            {
                string str1 = string.Empty;
                string str2;
                while ((str2 = textReader.ReadLine()) != null)
                    listBox.Items.Add((object)str2);
            }
            int num = (int)MessageBox.Show("Loaded PlayerList Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void Button87_Click(object sender, EventArgs e)
        {
            MW3.LoadTextIntoListBox(this.Kicklist);
        }

        private void Button86_Click(object sender, EventArgs e)
        {
            if (button86.Text == "Auto KICK OFF")
            {
                this.AutoKick = new System.Windows.Forms.Timer();
                this.AutoKick.Interval = 10000;
                this.AutoKick.Enabled = true;
                this.AutoKick.Start();
            }
        }

        private void AutoKick_Tick(object sender, EventArgs e)
        {
            for (uint index = 0; index < 18U; ++index)
            {
                if (this.Kicklist.Items.Cast<object>().Select<object, string>((Func<object, string>)(x => x.ToString())).Contains<string>(MW3.MW3GetNames(index)))
                    MW3.KickClient(index);
            }
        }

        private void Button89_Click(object sender, EventArgs e)
        {
            if (button89.Text == "AUTO GODMODE CLASS KICKER OFF")
            {
                this.AntiGodMode = new System.Windows.Forms.Timer();
                this.AntiGodMode.Enabled = true;
                this.AntiGodMode.Tick += new EventHandler(this.Timer2_Tick);
                this.AntiGodMode.Start();
                button89.Text = "AUTO GODMODE CLASS KICKER ON";
            }
            else if (button89.Text == "AUTO GODMODE CLASS KICKER ON")
            {
                AntiGodMode.Stop();
                button89.Text = "AUTO GODMODE CLASS KICKER OFF";
            }

        }



        private void Timer2_Tick(object sender, EventArgs e)
        {
            for (uint Client = 0; Client < 17U; ++Client)
            {
                byte[] Buffer1 = new byte[1];
                byte[] Buffer2 = new byte[1];
                byte[] Buffer3 = new byte[1];
                PS5.GetMemoryR((uint)(17868027 + (int)Client * 14720), ref Buffer1);
                PS5.GetMemoryR((uint)(17868035 + (int)Client * 14720), ref Buffer2);
                PS5.GetMemoryR((uint)(17868031 + (int)Client * 14720), ref Buffer3);
                if ((int)Buffer1[0] != 0 && (int)Buffer2[0] == 0 && (int)Buffer3[0] == 0)
                    MW3.PS3Frezze(Client);
            }
        }

        private void Button74_Click(object sender, EventArgs e)
        {
            this.tabControl2.SelectedTab = tabPage1;
        }
        public static byte[] smethod_6(byte[] byte_43)
        {
            Array.Reverse(byte_43);
            return byte_43;
        }
        public class GClass1
        {
            // Token: 0x040004DB RID: 1243
            public static uint uint_0 = 8u;

            // Token: 0x040004DC RID: 1244
            public static uint uint_1 = 4u;

            // Token: 0x040004DD RID: 1245
            public static uint uint_2 = 132u;

            // Token: 0x040004DE RID: 1246
            public static uint uint_3 = 36u;

            // Token: 0x040004DF RID: 1247
            public static uint uint_4 = 20u;

            // Token: 0x040004E0 RID: 1248
            public static uint uint_5 = 48u;

            // Token: 0x040004E1 RID: 1249
            public static uint uint_6 = 44u;

            // Token: 0x040004E2 RID: 1250
            public static uint uint_7 = 68u;

            // Token: 0x040004E3 RID: 1251
            public static uint uint_8 = 72u;

            // Token: 0x040004E4 RID: 1252
            public static uint uint_9 = 76u;

            // Token: 0x040004E5 RID: 1253
            public static uint uint_10 = 140u;

            // Token: 0x040004E6 RID: 1254
            public static uint uint_11 = 168u;

            // Token: 0x040004E7 RID: 1255
            public static uint uint_12 = 44u;

            // Token: 0x040004E8 RID: 1256
            public static uint uint_13 = 148u;

            // Token: 0x040004E9 RID: 1257
            public static uint uint_14 = 152u;

            // Token: 0x040004EA RID: 1258
            public static uint uint_15 = 144u;

            // Token: 0x040004EB RID: 1259
            public static uint uint_16 = 156u;
        }
        public byte[] method_11(uint uint_9)
        {
            byte[] bytes = BitConverter.GetBytes(uint_9);
            Array.Reverse(bytes);
            return bytes;
        }
        public static void smethod_3(uint uint_0, bool bool_0)
        {
            byte[] byte_ = new byte[]
            {

            };
            PS3.SetMemory(uint_0, byte_);
        }
        public static void smethod_4(uint uint_9, uint uint_10 = 0u, uint uint_11 = 0u, uint uint_12 = 0u, uint uint_13 = 0u, uint uint_14 = 0u)
        {
            byte[] bytes = BitConverter.GetBytes(uint_10);
            byte[] bytes2 = BitConverter.GetBytes(uint_11);
            byte[] bytes3 = BitConverter.GetBytes(uint_12);
            byte[] bytes4 = BitConverter.GetBytes(uint_13);
            byte[] bytes5 = BitConverter.GetBytes(uint_14);
            Array.Reverse(bytes);
            Array.Reverse(bytes2);
            Array.Reverse(bytes3);
            Array.Reverse(bytes4);
            Array.Reverse(bytes5);
            PS5.SetMemory(5389072u, bytes);
            PS5.SetMemory(5389076u, bytes2);
            PS5.SetMemory(5389080u, bytes3);
            PS5.SetMemory(5389084u, bytes4);
            PS5.SetMemory(5389088u, bytes5);
            PS5.SetMemory(31134276u, new byte[]
             {
                0,
                0,
                0,
                1
             });
            Thread.Sleep(10);
        }
        public static byte[] smethod_1(float float_1)
        {
            byte[] bytes = BitConverter.GetBytes(float_1);
            Array.Reverse(bytes);
            return bytes;
        }
        public static void smethod_2()
        {
            PS3TMAPI.InitTargetComms();
            PS3TMAPI.Connect(0, null);
        }

        private void Button90_Click(object sender, EventArgs e)
        {

        }

        private void Button91_Click(object sender, EventArgs e)
        {
            if (button91.Text == "OFF")
            {
                AntiQuit.Start();
                MW3.iPrintln(-1, "^1Quitting Disaled!");
                button91.Text = "ON";
                button91.ForeColor = Color.Green;
            }
            else if (button91.Text == "ON")
            {
                button91.Text = "OFF";
                byte[] bytes = new byte[32];
                button91.ForeColor = Color.Red;
                AntiQuit.Stop();
                this.method_25(-1, "g_scriptmainmenu \"class\"");
                PS3.SetMemory(5389104U, bytes);
                MW3.iPrintln(-1, "^2Quitting Enabled!");
            }
        }

        private void AntiQuit_Tick(object sender, EventArgs e)
        {
            byte[] bytes = new byte[32];
            this.method_25(-1, "g_scriptmainmenu \"byTehPoisonOne\"");
            Thread.Sleep(10);
            PS3.SetMemory(5389104U, bytes);
        }

        private void Button93_Click(object sender, EventArgs e)
        {
            if (button93.Text == "OFF")
            {
                AntiQuit.Start();
                MW3.iPrintln(-1, "Wallbreak ^2Enabled");
                byte[] buffer = new byte[2]
      {
        (byte) 1,
        (byte) 44
      };
                PS3.SetMemory(1522530, buffer);
                button93.Text = "ON";
                button93.ForeColor = Color.Green;
            }
            else if (button93.Text == "ON")
            {
                byte[] buffer = new byte[2]
      {
        (byte) 2,
        (byte) 129
      };
                PS3.SetMemory(1522530, buffer);
                button93.Text = "OFF";
                MW3.iPrintln(-1, "Wallbreak ^1Disaled");
                button93.ForeColor = Color.Red;

            }
        }

        private void Button95_Click(object sender, EventArgs e)
        {
            if (button95.Text == "OFF")
            {
                byte[] buffer = new byte[1];
                PS3.SetMemory(1522562, buffer);
                MW3.iPrintln(-1, "^1Why You Kill Yourself?");
                button95.Text = "ON";
                button95.ForeColor = Color.Green;
            }
            else if (button95.Text == "ON")
            {
                button95.Text = "OFF";
                button95.ForeColor = Color.Red;
                byte[] buffer = new byte[1] { (byte)24 };
                PS3.SetMemory(1522562, buffer);
                MW3.iPrintln(-1, "Yes you should Play so, dont kill yourself!");
            }
        }

        private void Button97_Click(object sender, EventArgs e)
        {
            if (button97.Text == "OFF")
            {
                MW3.cbuf_addtext(0, "scr_game_forceuav 1");
                MW3.iPrintln(-1, "^5VORTEX RTM DRONE OVER MAP!");
                button97.Text = "ON";
                button97.ForeColor = Color.Green;
            }
            else if (button97.Text == "ON")
            {
                button97.Text = "OFF";
                button97.ForeColor = Color.Red;
                MW3.cbuf_addtext(0, "scr_game_forceuav 0");
                MW3.iPrintln(-1, "Yes you should Play so, dont kill yourself!");
            }
        }

        private void Button99_Click(object sender, EventArgs e)
        {
            if (button99.Text == "OFF")
            {
                SniperLobby.Start();

                MW3.iPrintln(-1, "^2Sniper^1Lobby^5Started!");
                button99.Text = "ON";
                button99.ForeColor = Color.Green;
            }
            else if (button99.Text == "ON")
            {
                button99.Text = "OFF";
                button99.ForeColor = Color.Red;
                SniperLobby.Stop();
                MW3.iPrintln(-1, "^1Sniper Lobby Stopped!");
            }
        }

        private void SniperLobby_Tick(object sender, EventArgs e)
        {
            {
                uint num = 0;
                while (num < 18U)
                    ++num;
                {
                    byte[] bytes1 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868029 + (int)MW3.Client0 * 14720), bytes1);
                    byte[] bytes2 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868273 + (int)MW3.Client0 * 14720), bytes2);
                    byte[] bytes3 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868453 + (int)MW3.Client0 * 14720), bytes3);
                    byte[] bytes4 = new byte[4]
                    {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                    };
                    PS3.SetMemory((uint)(17868456 + (int)MW3.Client0 * 14720), bytes4);
                    byte[] bytes5 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868029 + (int)MW3.Client0 * 14720), bytes5);
                    byte[] bytes6 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868273 + (int)MW3.Client0 * 14720), bytes6);
                    byte[] bytes7 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868453 + (int)MW3.Client0 * 14720), bytes7);
                    byte[] bytes8 = new byte[4]
                    {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                    };
                    PS3.SetMemory((uint)(17868456 + (int)MW3.Client0 * 14720), bytes8);
                    byte[] bytes9 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868029 + (int)MW3.Client2 * 14720), bytes9);
                    byte[] bytes10 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868273 + (int)MW3.Client2 * 14720), bytes10);
                    byte[] bytes11 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868453 + (int)MW3.Client2 * 14720), bytes11);
                    byte[] bytes12 = new byte[4]
                    {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                    };
                    PS3.SetMemory((uint)(17868456 + (int)MW3.Client2 * 14720), bytes12);
                    byte[] bytes13 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868029 + (int)MW3.Client3 * 14720), bytes13);
                    byte[] bytes14 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868273 + (int)MW3.Client3 * 14720), bytes14);
                    byte[] bytes15 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868453 + (int)MW3.Client3 * 14720), bytes15);
                    byte[] bytes16 = new byte[4]
                    {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                    };
                    PS3.SetMemory((uint)(17868456 + (int)MW3.Client3 * 14720), bytes16);
                    byte[] bytes17 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868029 + (int)MW3.Client4 * 14720), bytes17);
                    byte[] bytes18 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868273 + (int)MW3.Client4 * 14720), bytes18);
                    byte[] bytes19 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868453 + (int)MW3.Client4 * 14720), bytes19);
                    byte[] bytes20 = new byte[4]
                    {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                    };
                    PS3.SetMemory((uint)(17868456 + (int)MW3.Client4 * 14720), bytes20);
                    byte[] bytes21 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868029 + (int)MW3.Client5 * 14720), bytes21);
                    byte[] bytes22 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868273 + (int)MW3.Client5 * 14720), bytes22);
                    byte[] bytes23 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868453 + (int)MW3.Client5 * 14720), bytes23);
                    byte[] bytes24 = new byte[4]
                    {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                    };
                    PS3.SetMemory((uint)(17868456 + (int)MW3.Client5 * 14720), bytes24);
                    byte[] bytes25 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868029 + (int)MW3.Client6 * 14720), bytes25);
                    byte[] bytes26 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868273 + (int)MW3.Client6 * 14720), bytes26);
                    byte[] bytes27 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868453 + (int)MW3.Client6 * 14720), bytes27);
                    byte[] bytes28 = new byte[4]
                    {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                    };
                    PS3.SetMemory((uint)(17868456 + (int)MW3.Client6 * 14720), bytes28);
                    byte[] bytes29 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868029 + (int)MW3.Client7 * 14720), bytes29);
                    byte[] bytes30 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868273 + (int)MW3.Client7 * 14720), bytes30);
                    byte[] bytes31 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868453 + (int)MW3.Client7 * 14720), bytes31);
                    byte[] bytes32 = new byte[4]
                    {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                    };
                    PS3.SetMemory((uint)(17868456 + (int)MW3.Client7 * 14720), bytes32);
                    byte[] bytes33 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868029 + (int)MW3.Client8 * 14720), bytes33);
                    byte[] bytes34 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868273 + (int)MW3.Client8 * 14720), bytes34);
                    byte[] bytes35 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868453 + (int)MW3.Client8 * 14720), bytes35);
                    byte[] bytes36 = new byte[4]
                    {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                    };
                    PS3.SetMemory((uint)(17868456 + (int)MW3.Client8 * 14720), bytes36);
                    byte[] bytes37 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868029 + (int)MW3.Client9 * 14720), bytes37);
                    byte[] bytes38 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868273 + (int)MW3.Client9 * 14720), bytes38);
                    byte[] bytes39 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868453 + (int)MW3.Client9 * 14720), bytes39);
                    byte[] bytes40 = new byte[4]
                    {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                    };
                    PS3.SetMemory((uint)(17868456 + (int)MW3.Client9 * 14720), bytes40);
                    byte[] bytes41 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868029 + (int)MW3.Client10 * 14720), bytes41);
                    byte[] bytes42 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868273 + (int)MW3.Client10 * 14720), bytes42);
                    byte[] bytes43 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868453 + (int)MW3.Client10 * 14720), bytes43);
                    byte[] bytes44 = new byte[4]
                    {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                    };
                    PS3.SetMemory((uint)(17868456 + (int)MW3.Client10 * 14720), bytes44);
                    byte[] bytes45 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868029 + (int)MW3.Client11 * 14720), bytes45);
                    byte[] bytes46 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868273 + (int)MW3.Client11 * 14720), bytes46);
                    byte[] bytes47 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868453 + (int)MW3.Client11 * 14720), bytes47);
                    byte[] bytes48 = new byte[4]
                    {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                    };
                    PS3.SetMemory((uint)(17868456 + (int)MW3.Client11 * 14720), bytes48);
                    byte[] bytes49 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868029 + (int)MW3.Client12 * 14720), bytes49);
                    byte[] bytes50 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868273 + (int)MW3.Client12 * 14720), bytes50);
                    byte[] bytes51 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868453 + (int)MW3.Client12 * 14720), bytes51);
                    byte[] bytes52 = new byte[4]
                    {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                    };
                    PS3.SetMemory((uint)(17868456 + (int)MW3.Client12 * 14720), bytes52);
                    byte[] bytes53 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868029 + (int)MW3.Client13 * 14720), bytes53);
                    byte[] bytes54 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868273 + (int)MW3.Client13 * 14720), bytes54);
                    byte[] bytes55 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868453 + (int)MW3.Client13 * 14720), bytes55);
                    byte[] bytes56 = new byte[4]
                    {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                    };
                    PS3.SetMemory((uint)(17868456 + (int)MW3.Client13 * 14720), bytes56);
                    byte[] bytes57 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868029 + (int)MW3.Client14 * 14720), bytes57);
                    byte[] bytes58 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868273 + (int)MW3.Client14 * 14720), bytes58);
                    byte[] bytes59 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868453 + (int)MW3.Client14 * 14720), bytes59);
                    byte[] bytes60 = new byte[4]
                    {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                    };
                    PS3.SetMemory((uint)(17868456 + (int)MW3.Client14 * 14720), bytes60);
                    byte[] bytes61 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868029 + (int)MW3.Client15 * 14720), bytes61);
                    byte[] bytes62 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868273 + (int)MW3.Client15 * 14720), bytes62);
                    byte[] bytes63 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868453 + (int)MW3.Client15 * 14720), bytes63);
                    byte[] bytes64 = new byte[4]
                    {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                    };
                    PS3.SetMemory((uint)(17868456 + (int)MW3.Client15 * 14720), bytes64);
                    byte[] bytes65 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868029 + (int)MW3.Client16 * 14720), bytes65);
                    byte[] bytes66 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868273 + (int)MW3.Client16 * 14720), bytes66);
                    byte[] bytes67 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868453 + (int)MW3.Client16 * 14720), bytes67);
                    byte[] bytes68 = new byte[4]
                    {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                    };
                    PS3.SetMemory((uint)(17868456 + (int)MW3.Client16 * 14720), bytes68);
                    byte[] bytes69 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868029 + (int)MW3.Client17 * 14720), bytes69);
                    byte[] bytes70 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868273 + (int)MW3.Client17 * 14720), bytes70);
                    byte[] bytes71 = new byte[3]
                    {
          (byte) 4,
          (byte) 59,
          (byte) 41
                    };
                    PS3.SetMemory((uint)(17868453 + (int)MW3.Client17 * 14720), bytes71);
                    byte[] bytes72 = new byte[4]
                    {
          (byte) 15,
          byte.MaxValue,
          byte.MaxValue,
          byte.MaxValue
                    };
                }
            }
        }

        private void AimbotMwenuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Button104_Click(object sender, EventArgs e)
        {
            if (button104.Text == "OFF")
            {

                MW3.iPrintln(-1, "^1Movment Frozen!");
                byte[] buffer = new byte[4]
    {
        (byte) 56,
        (byte) 160,
        (byte) 0,
        (byte) 0
    };
                PS3.SetMemory(1522608, buffer);
                button104.Text = "ON";
                button104.ForeColor = Color.Green;
            }
            else if (button104.Text == "ON")
            {
                button104.Text = "OFF";
                byte[] buffer = new byte[4]
     {
        (byte) 56,
        (byte) 160,
        (byte) 0,
        (byte) 190
     };
                PS3.SetMemory(1522608, buffer);
                button104.ForeColor = Color.Red;
                MW3.iPrintln(-1, "^1Movent ^2Unfrozen!");
            }
        }

        private void Button108_Click(object sender, EventArgs e)
        {
            if (button108.Text == "OFF")
            {

                MW3.iPrintln(-1, "^7RapidFire ^2Enabled!");

                button108.Text = "ON";
                byte[] numArray = new byte[4];
                numArray[0] = (byte)96;
                byte[] buffer1 = numArray;
                PS3.SetMemory(204140, buffer1);
                byte[] buffer2 = new byte[4]
                {
        (byte) 192,
        (byte) 35,
        (byte) 0,
        (byte) 0
                };
                PS3.SetMemory(204164, buffer2);
                byte[] buffer3 = new byte[4]
                {
        (byte) 72,
        (byte) 0,
        (byte) 0,
        (byte) 60
                };
                PS3.SetMemory(204172, buffer3);
                byte[] buffer4 = new byte[4]
                {
        (byte) 61,
        (byte) 76,
        (byte) 204,
        (byte) 205
                };
                PS3.SetMemory(203588, buffer4);
                button108.ForeColor = Color.Green;
            }
            else if (button108.Text == "ON")
            {
                button108.Text = "OFF";
                button108.ForeColor = Color.Red;
                byte[] buffer1 = new byte[4]
     {
        (byte) 65,
        (byte) 130,
        (byte) 0,
        (byte) 148
     };
                PS3.SetMemory(204140, buffer1);
                byte[] buffer2 = new byte[4]
                {
        (byte) 192,
        (byte) 36,
        (byte) 0,
        (byte) 8
                };
                PS3.SetMemory(204164, buffer2);
                byte[] buffer3 = new byte[4]
                {
        (byte) 64,
        (byte) 130,
        (byte) 0,
        (byte) 60
                };
                PS3.SetMemory(204172, buffer3);
                byte[] buffer4 = new byte[4];
                PS3.SetMemory(203588, buffer4);
                MW3.iPrintln(-1, "^1Repid Fire OFF!");
            }
        }

        private void Button106_Click(object sender, EventArgs e)
        {
            if (button106.Text == "OFF")
            {
                MW3.cbuf_addtext(0, "scr_sd_numlives 0");
                MW3.iPrintln(-1, "^7SpawnTrap ^2Enabled! Have Fun! Dont Forget to Quit Noob!");

                button106.Text = "ON";

                button106.ForeColor = Color.Green;
            }
            else if (button106.Text == "ON")
            {
                MW3.cbuf_addtext(0, "scr_sd_numlives 1");
                button106.Text = "OFF";
                button106.ForeColor = Color.Red;

                MW3.iPrintln(-1, "SpawnTrap ^1Disabled!!");
            }
        }
        public static void G_AddEvent(int G_Entity, int Event, int EventParam = 0)
        {
            RPC.Call(1838180U, (object)G_Entity, (object)Event, (object)EventParam);
        }
        public static void EV_PLAY_FX(int Client, int FXID)
        {
            MW3.G_AddEvent(16556672 + Client * 640, 86, FXID);
        }
        public static void Fuck_Money(int client, string FX)
        {
            MW3.EV_PLAY_FX(client, RPC.Call(1829740U, (object)FX));
        }
        private void Button110_Click(object sender, EventArgs e)
        {
            if (button110.Text == "OFF")
            {
                MoneyRain.Start();
                MW3.iPrintln(-1, "Money Money Money! He comes The Money!");

                button110.Text = "ON";

                button110.ForeColor = Color.Green;
            }
            else if (button110.Text == "ON")
            {
                MoneyRain.Stop();
                button110.Text = "OFF";
                button110.ForeColor = Color.Red;

                MW3.iPrintln(-1, "^1Money OFF!");
            }
        }

        private void MoneyRain_Tick(object sender, EventArgs e)
        {
            MW3.Fuck_Money(0, "props/cash_player_drop");
            MW3.Fuck_Money(1, "props/cash_player_drop");
            MW3.Fuck_Money(2, "props/cash_player_drop");
            MW3.Fuck_Money(3, "props/cash_player_drop");
            MW3.Fuck_Money(4, "props/cash_player_drop");
            MW3.Fuck_Money(5, "props/cash_player_drop");
            MW3.Fuck_Money(6, "props/cash_player_drop");
            MW3.Fuck_Money(7, "props/cash_player_drop");
            MW3.Fuck_Money(8, "props/cash_player_drop");
            MW3.Fuck_Money(9, "props/cash_player_drop");
            MW3.Fuck_Money(10, "props/cash_player_drop");
            MW3.Fuck_Money(11, "props/cash_player_drop");
            MW3.Fuck_Money(12, "props/cash_player_drop");
            MW3.Fuck_Money(13, "props/cash_player_drop");
            MW3.Fuck_Money(14, "props/cash_player_drop");
            MW3.Fuck_Money(15, "props/cash_player_drop");
            MW3.Fuck_Money(16, "props/cash_player_drop");
            MW3.Fuck_Money(17, "props/cash_player_drop");
        }

        private void Button112_Click(object sender, EventArgs e)
        {
            if (button112.Text == "OFF")
            {
                MW3.cbuf_addtext(-1, "cg_everyoneHearsEveryone 1");

                button112.Text = "ON";

                button112.ForeColor = Color.Green;
            }
            else if (button112.Text == "ON")
            {

                button112.Text = "OFF";
                button112.ForeColor = Color.Red;
                MW3.cbuf_addtext(-1, "cg_everyoneHearsEveryone 0");
            }
        }

        private void Button114_Click(object sender, EventArgs e)
        {
            if (button114.Text == "OFF")
            {
                Invert.Start();

                button114.Text = "ON";

                button114.ForeColor = Color.Green;
            }
            else if (button112.Text == "ON")
            {
                button114.Text = "OFF";
                button114.ForeColor = Color.Red;
                Invert.Stop();
                PS3.SetMemory((uint)(17867492 + (int)MW3.Client0 * 14720), new byte[1]);
                PS3.SetMemory((uint)(17867496 + (int)MW3.Client0 * 14720), new byte[1]);
                PS3.SetMemory((uint)(17867492 + (int)MW3.Client0 * 14720), new byte[1]);
                PS3.SetMemory((uint)(17867496 + (int)MW3.Client0 * 14720), new byte[1]);
                PS3.SetMemory((uint)(17867492 + (int)MW3.Client2 * 14720), new byte[1]);
                PS3.SetMemory((uint)(17867496 + (int)MW3.Client2 * 14720), new byte[1]);
                PS3.SetMemory((uint)(17867492 + (int)MW3.Client3 * 14720), new byte[1]);
                PS3.SetMemory((uint)(17867496 + (int)MW3.Client3 * 14720), new byte[1]);
                PS3.SetMemory((uint)(17867492 + (int)MW3.Client4 * 14720), new byte[1]);
                PS3.SetMemory((uint)(17867496 + (int)MW3.Client4 * 14720), new byte[1]);
                PS3.SetMemory((uint)(17867492 + (int)MW3.Client5 * 14720), new byte[1]);
                PS3.SetMemory((uint)(17867496 + (int)MW3.Client5 * 14720), new byte[1]);
                PS3.SetMemory((uint)(17867492 + (int)MW3.Client6 * 14720), new byte[1]);
                PS3.SetMemory((uint)(17867496 + (int)MW3.Client6 * 14720), new byte[1]);
                PS3.SetMemory((uint)(17867492 + (int)MW3.Client7 * 14720), new byte[1]);
                PS3.SetMemory((uint)(17867496 + (int)MW3.Client7 * 14720), new byte[1]);
                PS3.SetMemory((uint)(17867492 + (int)MW3.Client8 * 14720), new byte[1]);
                PS3.SetMemory((uint)(17867496 + (int)MW3.Client8 * 14720), new byte[1]);
                PS3.SetMemory((uint)(17867492 + (int)MW3.Client9 * 14720), new byte[1]);
                PS3.SetMemory((uint)(17867496 + (int)MW3.Client9 * 14720), new byte[1]);
                PS3.SetMemory((uint)(17867492 + (int)MW3.Client10 * 14720), new byte[1]);
                PS3.SetMemory((uint)(17867496 + (int)MW3.Client10 * 14720), new byte[1]);
                PS3.SetMemory((uint)(17867492 + (int)MW3.Client11 * 14720), new byte[1]);
                PS3.SetMemory((uint)(17867496 + (int)MW3.Client11 * 14720), new byte[1]);
                PS3.SetMemory((uint)(17867492 + (int)MW3.Client12 * 14720), new byte[1]);
                PS3.SetMemory((uint)(17867496 + (int)MW3.Client12 * 14720), new byte[1]);
                PS3.SetMemory((uint)(17867492 + (int)MW3.Client13 * 14720), new byte[1]);
                PS3.SetMemory((uint)(17867496 + (int)MW3.Client13 * 14720), new byte[1]);
                PS3.SetMemory((uint)(17867492 + (int)MW3.Client14 * 14720), new byte[1]);
                PS3.SetMemory((uint)(17867496 + (int)MW3.Client14 * 14720), new byte[1]);
                PS3.SetMemory((uint)(17867492 + (int)MW3.Client15 * 14720), new byte[1]);
                PS3.SetMemory((uint)(17867496 + (int)MW3.Client15 * 14720), new byte[1]);
                PS3.SetMemory((uint)(17867492 + (int)MW3.Client16 * 14720), new byte[1]);
                PS3.SetMemory((uint)(17867496 + (int)MW3.Client16 * 14720), new byte[1]);
                PS3.SetMemory((uint)(17867492 + (int)MW3.Client17 * 14720), new byte[1]);
                PS3.SetMemory((uint)(17867496 + (int)MW3.Client17 * 14720), new byte[1]);
            }
        }

        private void Invert_Tick(object sender, EventArgs e)
        {
            {
                Funcs.Invert(0, (byte)7);
            }
        }

        private void Button115_Click(object sender, EventArgs e)
        {
            comboBox2.DroppedDown = true;
        }

        private void Button268_Click(object sender, EventArgs e)
        {
            comboBox10.DroppedDown = true;
        }

        private void ComboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox10.Text == "Dome")
                MW3.cbuf_addtext(0, "ui_mapname mp_dome");
            else if (this.comboBox10.Text == "Lockdown")
                MW3.cbuf_addtext(0, "ui_mapname mp_alpha");
            else if (this.comboBox10.Text == "Bootleg")
                MW3.cbuf_addtext(0, "ui_mapname mp_bootleg");
            else if (this.comboBox10.Text == "Mission")
                MW3.cbuf_addtext(0, "ui_mapname mp_bravo");
            else if (this.comboBox10.Text == "Carbon")
                MW3.cbuf_addtext(0, "ui_mapname mp_carbon");
            else if (this.comboBox10.Text == "Downturn")
                MW3.cbuf_addtext(0, "ui_mapname mp_exchange");
            else if (this.comboBox10.Text == "Hardhat")
                MW3.cbuf_addtext(0, "ui_mapname mp_hardhat");
            else if (this.comboBox10.Text == "Interchange")
                MW3.cbuf_addtext(0, "ui_mapname mp_interchange");
            else if (this.comboBox10.Text == "Fallen")
                MW3.cbuf_addtext(0, "ui_mapname mp_lambeth");
            else if (this.comboBox10.Text == "Bakaara")
                MW3.cbuf_addtext(0, "ui_mapname mp_mogadishu");
            else if (this.comboBox10.Text == "Resistance")
                MW3.cbuf_addtext(0, "ui_mapname mp_paris");
            else if (this.comboBox10.Text == "Arkaden")
                MW3.cbuf_addtext(0, "ui_mapname mp_plaza2");
            else if (this.comboBox10.Text == "Outpost")
                MW3.cbuf_addtext(0, "ui_mapname mp_radar");
            else if (this.comboBox10.Text == "Seatown")
                MW3.cbuf_addtext(0, "ui_mapname mp_seatown");
            else if (this.comboBox10.Text == "Underground")
                MW3.cbuf_addtext(0, "ui_mapname mp_underground");
            else if (this.comboBox10.Text == "Village")
                MW3.cbuf_addtext(0, "ui_mapname mp_village");
            else if (this.comboBox10.Text == "Aground")
                MW3.cbuf_addtext(0, "ui_mapname mp_aground_ss");
            else if (this.comboBox10.Text == "Foundation")
                MW3.cbuf_addtext(0, "ui_mapname mp_cement");
            else if (this.comboBox10.Text == "Getaway")
                MW3.cbuf_addtext(0, "ui_mapname mp_hillside_ss");
            else if (this.comboBox10.Text == "Piazza")
                MW3.cbuf_addtext(0, "ui_mapname mp_italy");
            else if (this.comboBox10.Text == "Sanctuary")
                MW3.cbuf_addtext(0, "ui_mapname mp_meteora");
            else if (this.comboBox10.Text == "Black Box")
                MW3.cbuf_addtext(0, "ui_mapname mp_morningwood");
            else if (this.comboBox10.Text == "Overwatch")
                MW3.cbuf_addtext(0, "ui_mapname mp_overwatch");
            else if (this.comboBox10.Text == "Liberation")
                MW3.cbuf_addtext(0, "ui_mapname mp_park");
            else if (this.comboBox10.Text == "Oasis")
                MW3.cbuf_addtext(0, "ui_mapname mp_qadeem");
            else if (this.comboBox10.Text == "Lookout")
                MW3.cbuf_addtext(0, "ui_mapname mp_restrepo_ss");
            else if (this.comboBox10.Text == "Terminal")
            {
                MW3.cbuf_addtext(0, "ui_mapname mp_terminal_cls");
            }
            else
            {
                if (!(this.comboBox10.Text == "Erosion"))
                    return;
                MW3.cbuf_addtext(0, "ui_mapname mp_courtyard_ss");
            }
        }
        public static void fastrestart(int client, string command)
        {
            MW3RPC.Call(2243360U, (object)(uint)client, (object)command);
        }
        public static void fastrestart(int Client)
        {
            MW3.fastrestart(Client, "sv_maprestart");
        }
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox2.Text == "Team Deathmatch")
            {
                MW3.cbuf_addtext(0, "g_gametype war");
                MW3.fastrestart(1);
            }
            else if (this.comboBox2.Text == "Free for All")
            {
                MW3.cbuf_addtext(0, "g_gametype dm");
                MW3.fastrestart(1);
            }
            else if (this.comboBox2.Text == "Search and Destroy")
            {
                MW3.cbuf_addtext(0, "g_gametype sd");
                MW3.fastrestart(1);
            }
            else if (this.comboBox2.Text == "Domination")
            {
                MW3.cbuf_addtext(0, "g_gametype dom");
                MW3.fastrestart(1);
            }
            else if (this.comboBox2.Text == "Kill Confirmed")
            {
                MW3.cbuf_addtext(0, "g_gametype conf");
                MW3.fastrestart(1);
            }
            else if (this.comboBox2.Text == "Team Defender")
            {
                MW3.cbuf_addtext(0, "g_gametype sotf");
                MW3.fastrestart(1);
            }
            else if (this.comboBox2.Text == "Infected")
            {
                MW3.cbuf_addtext(0, "g_gametype infect");
                MW3.fastrestart(1);
            }
            else if (this.comboBox2.Text == "Demolition")
            {
                MW3.cbuf_addtext(0, "g_gametype dem");
                MW3.fastrestart(1);
            }
            else if (this.comboBox2.Text == "Sabotage")
            {
                MW3.cbuf_addtext(0, "g_gametype sab");
                MW3.fastrestart(1);
            }
            else if (this.comboBox2.Text == "Headquaters Pro")
            {
                MW3.cbuf_addtext(0, "g_gametype koth");
                MW3.fastrestart(1);
            }
            else if (this.comboBox2.Text == "Capture the flag")
            {
                MW3.cbuf_addtext(0, "g_gametype ctf");
                MW3.fastrestart(1);
            }
            else if (this.comboBox2.Text == "Dropzone")
            {
                MW3.cbuf_addtext(0, "g_gametype grnd");
                MW3.fastrestart(1);
            }
            else
            {
                if (!(this.comboBox2.Text == "Arena"))
                    return;
                MW3.cbuf_addtext(0, "g_gametype arena");
                MW3.fastrestart(1);
            }
        }
        public static void lockIntDvarToValue(uint pointer, byte[] value)
        {
            uint num1 = 4;
            uint num2 = 11;
            byte[] Buffer1 = new byte[4];
            PS5.GetMemoryR(pointer, ref Buffer1);
            Array.Reverse((Array)Buffer1);
            uint uint32 = BitConverter.ToUInt32(Buffer1, 0);
            byte[] Buffer2 = new byte[2];
            PS5.GetMemoryR(uint32 + num1, ref Buffer2);
            Array.Reverse((Array)Buffer2);
            ushort uint16 = BitConverter.ToUInt16(Buffer2, 0);
            if (((int)uint16 & 2048) != 2048)
            {
                byte[] bytes = BitConverter.GetBytes((ushort)((uint)uint16 | 2048U));
                Array.Reverse((Array)bytes);
                PS3.SetMemory(uint32 + num1, bytes);
            }
            PS3.SetMemory(uint32 + num2, value);
        }
        public static void forceHostOff()
        {
            MW3.lockIntDvarToValue(9104948U, MW3.myhostminDefault);
            MW3.lockIntDvarToValue(9104960U, MW3.myhostmaxDefault);
        }
        public static void forceHostOn()
        {
            MW3.lockIntDvarToValue(9104948U, MW3.myhostmin);
            MW3.lockIntDvarToValue(9104960U, MW3.myhostmax);
        }

        private void Button117_Click(object sender, EventArgs e)
        {
            if (button117.Text == "OFF")
            {
                this.Forcehostbool = true;
                MW3.forceHostOn();
                for (uint index = 0; index < 12U; ++index)
                    PS3.SetMemory((uint)(26013344 + (int)index * 4), MW3.ReverseBytes(BitConverter.GetBytes((int)this.numericUpDown1.Value)));

                button117.Text = "ON";

                button117.ForeColor = Color.Green;
            }
            else if (button117.Text == "ON")
            {
                MW3.forceHostOff();
                button117.Text = "OFF";
                button117.ForeColor = Color.Red;

            }
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void LobbyStart_TextChanged(object sender, EventArgs e)
        {
        }

        private void Button126_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(104320U, MW3.ReverseBytes(BitConverter.GetBytes(Convert.ToSingle(Convert.ToDouble((int)this.numericUpDown10.Value)))));
            MW3.iPrintln(-1, "Jump set to:^2" + numericUpDown10.Value);

        }

        private void Button127_Click(object sender, EventArgs e)
        {
            int num1 = (int)this.numericUpDown11.Value;
            byte num2 = (byte)num1;
            PS3.SetMemory(1522610U, new byte[2]
            {
        (byte) (num1 >> 8),
        num2
            });
            MW3.iPrintln(-1, "Speed set to:^2" + numericUpDown11.Value);
        }

        private void Button128_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[4]
     {
        (byte) 66,
        (byte) 156,
        (byte) 0,
        (byte) 0
     };
            PS3.SetMemory(104320, buffer);
        }

        private void Button129_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[4]
   {
        (byte) 0,
        (byte) 190,
        (byte) 144,
        (byte) 97
   };
            PS3.SetMemory(1522610, buffer);
        }

        private void Button120_Click(object sender, EventArgs e)
        {
            MW3.cbuf_addtext(0, "set scr_" + MW3.GetServerInfoMW3("gamemode") + "_timelimit " + (object)this.numericUpDown2.Value);
        }

        private void Button121_Click(object sender, EventArgs e)
        {
            MW3.cbuf_addtext(0, "set scr_" + MW3.GetServerInfoMW3("gamemode") + "_scorelimit " + (object)this.numericUpDown3.Value);
        }

        private void Button122_Click(object sender, EventArgs e)
        {
            MW3.cbuf_addtext(0, "set scr_" + MW3.GetServerInfoMW3("gamemode") + "_planttime " + (object)this.numericUpDown4.Value);
        }

        private void Button123_Click(object sender, EventArgs e)
        {
            MW3.cbuf_addtext(0, "set scr_" + MW3.GetServerInfoMW3("gamemode") + "_defusetime " + (object)this.numericUpDown5.Value);
        }

        private void Button125_Click(object sender, EventArgs e)
        {
            MW3.cbuf_addtext(0, "set scr_" + MW3.GetServerInfoMW3("gamemode") + "_bombtimer " + (object)this.numericUpDown9.Value);
        }

        private void Button124_Click(object sender, EventArgs e)
        {
            MW3.cbuf_addtext(0, "set scr_" + MW3.GetServerInfoMW3("gamemode") + "_planttime " + (object)this.numericUpDown8.Value);

        }

        private void Button119_Click(object sender, EventArgs e)
        {
            MW3.cbuf_addtext(0, "scr_nukeTimer " + (object)this.numericUpDown7.Value);
        }

        private void Button118_Click(object sender, EventArgs e)
        {
            MW3.cbuf_addtext(0, "g_knockback " + (object)this.numericUpDown6.Value);
        }

        private void Button131_Click(object sender, EventArgs e)
        {
            if (button131.Text == "Derank Name OFF")
            {
                DerankName.Start();
                button131.Text = "Derank Name ON";
            }
            else if (button131.Text == "Derank Name ON")
            {
                button131.Text = "Derank Name OFF";
                DerankName.Stop();
            }
        }

        private void DerankName_Tick(object sender, EventArgs e)
        {
            ++MW3.Derank;
            switch (MW3.Derank - 1)
            {
                case 0:
                    byte[] buffer1 = new byte[9]
                    {
            (byte) 94,
            (byte) 49,
            (byte) 68,
            (byte) 69,
            (byte) 82,
            (byte) 65,
            (byte) 78,
            (byte) 75,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer1);
                    break;
                case 1:
                    byte[] buffer2 = new byte[9]
                    {
            (byte) 94,
            (byte) 50,
            (byte) 68,
            (byte) 69,
            (byte) 82,
            (byte) 65,
            (byte) 78,
            (byte) 75,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer2);
                    break;
                case 2:
                    byte[] buffer3 = new byte[9]
                    {
            (byte) 94,
            (byte) 51,
            (byte) 68,
            (byte) 69,
            (byte) 82,
            (byte) 65,
            (byte) 78,
            (byte) 75,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer3);
                    break;
                case 3:
                    byte[] buffer4 = new byte[9]
                    {
            (byte) 94,
            (byte) 52,
            (byte) 68,
            (byte) 69,
            (byte) 82,
            (byte) 65,
            (byte) 78,
            (byte) 75,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer4);
                    break;
                case 4:
                    byte[] buffer5 = new byte[9]
                    {
            (byte) 94,
            (byte) 53,
            (byte) 68,
            (byte) 69,
            (byte) 82,
            (byte) 65,
            (byte) 78,
            (byte) 75,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer5);
                    break;
                case 5:
                    byte[] buffer6 = new byte[9]
                    {
            (byte) 94,
            (byte) 54,
            (byte) 68,
            (byte) 69,
            (byte) 82,
            (byte) 65,
            (byte) 78,
            (byte) 75,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer6);
                    break;
                case 6:
                    byte[] buffer7 = new byte[9]
                    {
            (byte) 94,
            (byte) 55,
            (byte) 68,
            (byte) 69,
            (byte) 82,
            (byte) 65,
            (byte) 78,
            (byte) 75,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer7);
                    break;
                case 7:
                    byte[] buffer8 = new byte[9]
                    {
            (byte) 94,
            (byte) 56,
            (byte) 68,
            (byte) 69,
            (byte) 82,
            (byte) 65,
            (byte) 78,
            (byte) 75,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer8);
                    break;
                case 8:
                    byte[] buffer9 = new byte[27]
                    {
            (byte) 94,
            (byte) 49,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 53,
            (byte) 48,
            (byte) 37,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer9);
                    break;
                case 9:
                    byte[] buffer10 = new byte[27]
                    {
            (byte) 94,
            (byte) 49,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 53,
            (byte) 48,
            (byte) 37,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer10);
                    break;
                case 10:
                    byte[] buffer11 = new byte[27]
                    {
            (byte) 94,
            (byte) 49,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 53,
            (byte) 48,
            (byte) 37,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer11);
                    break;
                case 11:
                    byte[] buffer12 = new byte[30]
                    {
            (byte) 94,
            (byte) 50,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 49,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 53,
            (byte) 49,
            (byte) 48,
            (byte) 37,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer12);
                    break;
                case 12:
                    byte[] buffer13 = new byte[30]
                    {
            (byte) 94,
            (byte) 50,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 49,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 53,
            (byte) 49,
            (byte) 48,
            (byte) 37,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer13);
                    break;
                case 13:
                    byte[] buffer14 = new byte[30]
                    {
            (byte) 94,
            (byte) 50,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 49,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 53,
            (byte) 50,
            (byte) 48,
            (byte) 37,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer14);
                    break;
                case 14:
                    byte[] buffer15 = new byte[30]
                    {
            (byte) 94,
            (byte) 50,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 49,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 53,
            (byte) 50,
            (byte) 48,
            (byte) 37,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer15);
                    break;
                case 15:
                    byte[] buffer16 = new byte[30]
                    {
            (byte) 94,
            (byte) 50,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 49,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 53,
            (byte) 50,
            (byte) 48,
            (byte) 37,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer16);
                    break;
                case 16:
                    byte[] buffer17 = new byte[30]
                    {
            (byte) 94,
            (byte) 50,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 49,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 53,
            (byte) 51,
            (byte) 48,
            (byte) 37,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer17);
                    break;
                case 17:
                    byte[] buffer18 = new byte[30]
                    {
            (byte) 94,
            (byte) 50,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 49,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 53,
            (byte) 51,
            (byte) 48,
            (byte) 37,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer18);
                    break;
                case 18:
                    byte[] buffer19 = new byte[30]
                    {
            (byte) 94,
            (byte) 50,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 49,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 53,
            (byte) 51,
            (byte) 48,
            (byte) 37,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer19);
                    break;
                case 19:
                    byte[] buffer20 = new byte[30]
                    {
            (byte) 94,
            (byte) 50,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 49,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 53,
            (byte) 52,
            (byte) 48,
            (byte) 37,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer20);
                    break;
                case 20:
                    byte[] buffer21 = new byte[30]
                    {
            (byte) 94,
            (byte) 50,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 49,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 53,
            (byte) 52,
            (byte) 48,
            (byte) 37,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer21);
                    break;
                case 21:
                    byte[] buffer22 = new byte[30]
                    {
            (byte) 94,
            (byte) 50,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 49,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 53,
            (byte) 52,
            (byte) 48,
            (byte) 37,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer22);
                    break;
                case 22:
                    byte[] buffer23 = new byte[30]
                    {
            (byte) 94,
            (byte) 50,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 49,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 53,
            (byte) 53,
            (byte) 48,
            (byte) 37,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer23);
                    break;
                case 23:
                    byte[] buffer24 = new byte[30]
                    {
            (byte) 94,
            (byte) 50,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 49,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 53,
            (byte) 53,
            (byte) 48,
            (byte) 37,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer24);
                    break;
                case 24:
                    byte[] buffer25 = new byte[30]
                    {
            (byte) 94,
            (byte) 50,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 49,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 53,
            (byte) 53,
            (byte) 48,
            (byte) 37,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer25);
                    break;
                case 25:
                    byte[] buffer26 = new byte[30]
                    {
            (byte) 94,
            (byte) 50,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 49,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 53,
            (byte) 54,
            (byte) 48,
            (byte) 37,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer26);
                    break;
                case 26:
                    byte[] buffer27 = new byte[30]
                    {
            (byte) 94,
            (byte) 50,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 49,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 53,
            (byte) 54,
            (byte) 48,
            (byte) 37,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer27);
                    break;
                case 27:
                    byte[] buffer28 = new byte[30]
                    {
            (byte) 94,
            (byte) 50,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 49,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 53,
            (byte) 54,
            (byte) 48,
            (byte) 37,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer28);
                    break;
                case 28:
                    byte[] buffer29 = new byte[30]
                    {
            (byte) 94,
            (byte) 50,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 49,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 53,
            (byte) 55,
            (byte) 48,
            (byte) 37,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer29);
                    break;
                case 29:
                    byte[] buffer30 = new byte[30]
                    {
            (byte) 94,
            (byte) 50,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 49,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 53,
            (byte) 55,
            (byte) 48,
            (byte) 37,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer30);
                    break;
                case 30:
                    byte[] buffer31 = new byte[30]
                    {
            (byte) 94,
            (byte) 50,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 49,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 53,
            (byte) 55,
            (byte) 48,
            (byte) 37,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer31);
                    break;
                case 31:
                    byte[] buffer32 = new byte[30]
                    {
            (byte) 94,
            (byte) 50,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 49,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 53,
            (byte) 56,
            (byte) 48,
            (byte) 37,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer32);
                    break;
                case 32:
                    byte[] buffer33 = new byte[30]
                    {
            (byte) 94,
            (byte) 50,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 49,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 53,
            (byte) 56,
            (byte) 48,
            (byte) 37,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer33);
                    break;
                case 33:
                    byte[] buffer34 = new byte[30]
                    {
            (byte) 94,
            (byte) 50,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 49,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 53,
            (byte) 56,
            (byte) 48,
            (byte) 37,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer34);
                    break;
                case 34:
                    byte[] buffer35 = new byte[30]
                    {
            (byte) 94,
            (byte) 50,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 49,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 53,
            (byte) 57,
            (byte) 48,
            (byte) 37,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer35);
                    break;
                case 35:
                    byte[] buffer36 = new byte[30]
                    {
            (byte) 94,
            (byte) 50,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 49,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 53,
            (byte) 57,
            (byte) 48,
            (byte) 37,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer36);
                    break;
                case 36:
                    byte[] buffer37 = new byte[30]
                    {
            (byte) 94,
            (byte) 50,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 49,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 53,
            (byte) 57,
            (byte) 48,
            (byte) 37,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer37);
                    break;
                case 37:
                    byte[] buffer38 = new byte[31]
                    {
            (byte) 94,
            (byte) 50,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 49,
            (byte) 94,
            (byte) 53,
            (byte) 49,
            (byte) 48,
            (byte) 48,
            (byte) 37,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer38);
                    break;
                case 38:
                    byte[] buffer39 = new byte[31]
                    {
            (byte) 94,
            (byte) 50,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 49,
            (byte) 94,
            (byte) 53,
            (byte) 49,
            (byte) 48,
            (byte) 48,
            (byte) 37,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer39);
                    break;
                case 39:
                    byte[] buffer40 = new byte[31]
                    {
            (byte) 94,
            (byte) 50,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 124,
            (byte) 94,
            (byte) 49,
            (byte) 94,
            (byte) 53,
            (byte) 49,
            (byte) 48,
            (byte) 48,
            (byte) 37,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer40);
                    break;
                case 40:
                    byte[] buffer41 = new byte[18]
                    {
            (byte) 85,
            (byte) 112,
            (byte) 108,
            (byte) 111,
            (byte) 97,
            (byte) 100,
            (byte) 32,
            (byte) 116,
            (byte) 111,
            (byte) 32,
            (byte) 83,
            (byte) 101,
            (byte) 114,
            (byte) 118,
            (byte) 101,
            (byte) 114,
            (byte) 46,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer41);
                    break;
                case 41:
                    byte[] buffer42 = new byte[19]
                    {
            (byte) 85,
            (byte) 112,
            (byte) 108,
            (byte) 111,
            (byte) 97,
            (byte) 100,
            (byte) 32,
            (byte) 116,
            (byte) 111,
            (byte) 32,
            (byte) 83,
            (byte) 101,
            (byte) 114,
            (byte) 118,
            (byte) 101,
            (byte) 114,
            (byte) 46,
            (byte) 46,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer42);
                    break;
                case 42:
                    byte[] buffer43 = new byte[20]
                    {
            (byte) 85,
            (byte) 112,
            (byte) 108,
            (byte) 111,
            (byte) 97,
            (byte) 100,
            (byte) 32,
            (byte) 116,
            (byte) 111,
            (byte) 32,
            (byte) 83,
            (byte) 101,
            (byte) 114,
            (byte) 118,
            (byte) 101,
            (byte) 114,
            (byte) 46,
            (byte) 46,
            (byte) 46,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer43);
                    break;
                case 43:
                    byte[] buffer44 = new byte[21]
                    {
            (byte) 85,
            (byte) 112,
            (byte) 108,
            (byte) 111,
            (byte) 97,
            (byte) 100,
            (byte) 32,
            (byte) 116,
            (byte) 111,
            (byte) 32,
            (byte) 83,
            (byte) 101,
            (byte) 114,
            (byte) 118,
            (byte) 101,
            (byte) 114,
            (byte) 46,
            (byte) 46,
            (byte) 46,
            (byte) 46,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer44);
                    break;
                case 44:
                    byte[] buffer45 = new byte[18]
                    {
            (byte) 85,
            (byte) 112,
            (byte) 108,
            (byte) 111,
            (byte) 97,
            (byte) 100,
            (byte) 32,
            (byte) 116,
            (byte) 111,
            (byte) 32,
            (byte) 83,
            (byte) 101,
            (byte) 114,
            (byte) 118,
            (byte) 101,
            (byte) 114,
            (byte) 46,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer45);
                    break;
                case 45:
                    byte[] buffer46 = new byte[19]
                    {
            (byte) 85,
            (byte) 112,
            (byte) 108,
            (byte) 111,
            (byte) 97,
            (byte) 100,
            (byte) 32,
            (byte) 116,
            (byte) 111,
            (byte) 32,
            (byte) 83,
            (byte) 101,
            (byte) 114,
            (byte) 118,
            (byte) 101,
            (byte) 114,
            (byte) 46,
            (byte) 46,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer46);
                    break;
                case 46:
                    byte[] buffer47 = new byte[20]
                    {
            (byte) 85,
            (byte) 112,
            (byte) 108,
            (byte) 111,
            (byte) 97,
            (byte) 100,
            (byte) 32,
            (byte) 116,
            (byte) 111,
            (byte) 32,
            (byte) 83,
            (byte) 101,
            (byte) 114,
            (byte) 118,
            (byte) 101,
            (byte) 114,
            (byte) 46,
            (byte) 46,
            (byte) 46,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer47);
                    break;
                case 47:
                    byte[] buffer48 = new byte[21]
                    {
            (byte) 85,
            (byte) 112,
            (byte) 108,
            (byte) 111,
            (byte) 97,
            (byte) 100,
            (byte) 32,
            (byte) 116,
            (byte) 111,
            (byte) 32,
            (byte) 83,
            (byte) 101,
            (byte) 114,
            (byte) 118,
            (byte) 101,
            (byte) 114,
            (byte) 46,
            (byte) 46,
            (byte) 46,
            (byte) 46,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer48);
                    break;
                case 48:
                    byte[] buffer49 = new byte[18]
                    {
            (byte) 85,
            (byte) 112,
            (byte) 108,
            (byte) 111,
            (byte) 97,
            (byte) 100,
            (byte) 32,
            (byte) 116,
            (byte) 111,
            (byte) 32,
            (byte) 83,
            (byte) 101,
            (byte) 114,
            (byte) 118,
            (byte) 101,
            (byte) 114,
            (byte) 46,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer49);
                    break;
                case 49:
                    byte[] buffer50 = new byte[19]
                    {
            (byte) 85,
            (byte) 112,
            (byte) 108,
            (byte) 111,
            (byte) 97,
            (byte) 100,
            (byte) 32,
            (byte) 116,
            (byte) 111,
            (byte) 32,
            (byte) 83,
            (byte) 101,
            (byte) 114,
            (byte) 118,
            (byte) 101,
            (byte) 114,
            (byte) 46,
            (byte) 46,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer50);
                    break;
                case 50:
                    byte[] buffer51 = new byte[20]
                    {
            (byte) 85,
            (byte) 112,
            (byte) 108,
            (byte) 111,
            (byte) 97,
            (byte) 100,
            (byte) 32,
            (byte) 116,
            (byte) 111,
            (byte) 32,
            (byte) 83,
            (byte) 101,
            (byte) 114,
            (byte) 118,
            (byte) 101,
            (byte) 114,
            (byte) 46,
            (byte) 46,
            (byte) 46,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer51);
                    break;
                case 51:
                    byte[] buffer52 = new byte[21]
                    {
            (byte) 85,
            (byte) 112,
            (byte) 108,
            (byte) 111,
            (byte) 97,
            (byte) 100,
            (byte) 32,
            (byte) 116,
            (byte) 111,
            (byte) 32,
            (byte) 83,
            (byte) 101,
            (byte) 114,
            (byte) 118,
            (byte) 101,
            (byte) 114,
            (byte) 46,
            (byte) 46,
            (byte) 46,
            (byte) 46,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer52);
                    break;
                case 52:
                    byte[] buffer53 = new byte[20]
                    {
            (byte) 68,
            (byte) 101,
            (byte) 114,
            (byte) 97,
            (byte) 110,
            (byte) 107,
            (byte) 32,
            (byte) 67,
            (byte) 111,
            (byte) 109,
            (byte) 112,
            (byte) 108,
            (byte) 101,
            (byte) 116,
            (byte) 101,
            (byte) 33,
            (byte) 33,
            (byte) 33,
            (byte) 33,
            (byte) 0
                    };
                    PS3.SetMemory(29080620, buffer53);
                    break;
            }
            if (MW3.Derank != 54)
                return;
            MW3.Derank = 0;
        }

        private void FlagName_Tick(object sender, EventArgs e)
        {
            this.FlagName.Interval = 450;
            ++MW3.Countername;
            switch (MW3.Countername - 1)
            {
                case 0:
                    PS3.SetMemory(29080620U, new byte[28]
                    {
            (byte) 94,
            (byte) 1,
            (byte) 125,
            (byte) 61,
            (byte) 51,
            (byte) 99,
            (byte) 97,
            (byte) 114,
            (byte) 100,
            (byte) 116,
            (byte) 105,
            (byte) 116,
            (byte) 108,
            (byte) 101,
            (byte) 95,
            (byte) 102,
            (byte) 108,
            (byte) 97,
            (byte) 103,
            (byte) 95,
            (byte) 103,
            (byte) 101,
            (byte) 114,
            (byte) 109,
            (byte) 97,
            (byte) 110,
            (byte) 121,
            (byte) 0
                    });
                    break;
                case 1:
                    PS3.SetMemory(29080620U, new byte[28]
                    {
            (byte) 94,
            (byte) 1,
            (byte) 125,
            (byte) 61,
            (byte) 51,
            (byte) 99,
            (byte) 97,
            (byte) 114,
            (byte) 100,
            (byte) 116,
            (byte) 105,
            (byte) 116,
            (byte) 108,
            (byte) 101,
            (byte) 95,
            (byte) 102,
            (byte) 108,
            (byte) 97,
            (byte) 103,
            (byte) 95,
            (byte) 103,
            (byte) 101,
            (byte) 114,
            (byte) 109,
            (byte) 97,
            (byte) 110,
            (byte) 121,
            (byte) 0
                    });
                    break;
                case 2:
                    PS3.SetMemory(29080620U, new byte[28]
                    {
            (byte) 94,
            (byte) 1,
            (byte) 125,
            (byte) 61,
            (byte) 51,
            (byte) 99,
            (byte) 97,
            (byte) 114,
            (byte) 100,
            (byte) 116,
            (byte) 105,
            (byte) 116,
            (byte) 108,
            (byte) 101,
            (byte) 95,
            (byte) 102,
            (byte) 108,
            (byte) 97,
            (byte) 103,
            (byte) 95,
            (byte) 103,
            (byte) 101,
            (byte) 114,
            (byte) 109,
            (byte) 97,
            (byte) 110,
            (byte) 121,
            (byte) 0
                    });
                    break;
                case 3:
                    PS3.SetMemory(29080620U, new byte[28]
                    {
            (byte) 94,
            (byte) 1,
            (byte) 125,
            (byte) 61,
            (byte) 51,
            (byte) 99,
            (byte) 97,
            (byte) 114,
            (byte) 100,
            (byte) 116,
            (byte) 105,
            (byte) 116,
            (byte) 108,
            (byte) 101,
            (byte) 95,
            (byte) 102,
            (byte) 108,
            (byte) 97,
            (byte) 103,
            (byte) 95,
            (byte) 103,
            (byte) 101,
            (byte) 114,
            (byte) 109,
            (byte) 97,
            (byte) 110,
            (byte) 121,
            (byte) 0
                    });
                    break;
                case 4:
                    PS3.SetMemory(29080620U, new byte[28]
                    {
            (byte) 94,
            (byte) 1,
            (byte) 125,
            (byte) 61,
            (byte) 51,
            (byte) 99,
            (byte) 97,
            (byte) 114,
            (byte) 100,
            (byte) 116,
            (byte) 105,
            (byte) 116,
            (byte) 108,
            (byte) 101,
            (byte) 95,
            (byte) 102,
            (byte) 108,
            (byte) 97,
            (byte) 103,
            (byte) 95,
            (byte) 103,
            (byte) 101,
            (byte) 114,
            (byte) 109,
            (byte) 97,
            (byte) 110,
            (byte) 121,
            (byte) 0
                    });
                    break;
                case 5:
                    PS3.SetMemory(29080620U, new byte[28]
                    {
            (byte) 94,
            (byte) 1,
            (byte) 125,
            (byte) 61,
            (byte) 51,
            (byte) 99,
            (byte) 97,
            (byte) 114,
            (byte) 100,
            (byte) 116,
            (byte) 105,
            (byte) 116,
            (byte) 108,
            (byte) 101,
            (byte) 95,
            (byte) 102,
            (byte) 108,
            (byte) 97,
            (byte) 103,
            (byte) 95,
            (byte) 103,
            (byte) 101,
            (byte) 114,
            (byte) 109,
            (byte) 97,
            (byte) 110,
            (byte) 121,
            (byte) 0
                    });
                    break;
            }
            if (MW3.Countername == 6)
                MW3.Countername = 0;
            this.FlagName.Start();
        }

        private void Button132_Click(object sender, EventArgs e)
        {
            if (button132.Text == "Flag Name OFF")
            {
                FlagName.Start();
                button132.Text = "Flag Name ON";
            }
            else if (button132.Text == "Flag Name ON")
            {
                button132.Text = "Flag Name OFF";
                FlagName.Stop();
            }
        }

        private void Timer2_Tick_1(object sender, EventArgs e)
        {
            this.MOAB.Interval = 800;
            ++MW3.Countername;
            switch (MW3.Countername - 1)
            {
                case 0:
                    PS3.SetMemory(29080620U, new byte[28]
                    {
            (byte) 94,
            (byte) 49,
            (byte) 94,
            (byte) 1,
            (byte) 109,
            (byte) 109,
            (byte) 20,
            (byte) 100,
            (byte) 112,
            (byte) 97,
            (byte) 100,
            (byte) 95,
            (byte) 107,
            (byte) 105,
            (byte) 108,
            (byte) 108,
            (byte) 115,
            (byte) 116,
            (byte) 114,
            (byte) 101,
            (byte) 97,
            (byte) 107,
            (byte) 95,
            (byte) 110,
            (byte) 117,
            (byte) 107,
            (byte) 101,
            (byte) 0
                    });
                    break;
                case 1:
                    PS3.SetMemory(29080620U, new byte[28]
                    {
            (byte) 94,
            (byte) 50,
            (byte) 94,
            (byte) 1,
            (byte) 109,
            (byte) 109,
            (byte) 20,
            (byte) 100,
            (byte) 112,
            (byte) 97,
            (byte) 100,
            (byte) 95,
            (byte) 107,
            (byte) 105,
            (byte) 108,
            (byte) 108,
            (byte) 115,
            (byte) 116,
            (byte) 114,
            (byte) 101,
            (byte) 97,
            (byte) 107,
            (byte) 95,
            (byte) 110,
            (byte) 117,
            (byte) 107,
            (byte) 101,
            (byte) 0
                    });
                    break;
                case 2:
                    PS3.SetMemory(29080620U, new byte[28]
                    {
            (byte) 94,
            (byte) 51,
            (byte) 94,
            (byte) 1,
            (byte) 109,
            (byte) 109,
            (byte) 20,
            (byte) 100,
            (byte) 112,
            (byte) 97,
            (byte) 100,
            (byte) 95,
            (byte) 107,
            (byte) 105,
            (byte) 108,
            (byte) 108,
            (byte) 115,
            (byte) 116,
            (byte) 114,
            (byte) 101,
            (byte) 97,
            (byte) 107,
            (byte) 95,
            (byte) 110,
            (byte) 117,
            (byte) 107,
            (byte) 101,
            (byte) 0
                    });
                    break;
                case 3:
                    PS3.SetMemory(29080620U, new byte[28]
                    {
            (byte) 94,
            (byte) 52,
            (byte) 94,
            (byte) 1,
            (byte) 109,
            (byte) 109,
            (byte) 20,
            (byte) 100,
            (byte) 112,
            (byte) 97,
            (byte) 100,
            (byte) 95,
            (byte) 107,
            (byte) 105,
            (byte) 108,
            (byte) 108,
            (byte) 115,
            (byte) 116,
            (byte) 114,
            (byte) 101,
            (byte) 97,
            (byte) 107,
            (byte) 95,
            (byte) 110,
            (byte) 117,
            (byte) 107,
            (byte) 101,
            (byte) 0
                    });
                    break;
                case 4:
                    PS3.SetMemory(29080620U, new byte[28]
                    {
            (byte) 94,
            (byte) 53,
            (byte) 94,
            (byte) 1,
            (byte) 109,
            (byte) 109,
            (byte) 20,
            (byte) 100,
            (byte) 112,
            (byte) 97,
            (byte) 100,
            (byte) 95,
            (byte) 107,
            (byte) 105,
            (byte) 108,
            (byte) 108,
            (byte) 115,
            (byte) 116,
            (byte) 114,
            (byte) 101,
            (byte) 97,
            (byte) 107,
            (byte) 95,
            (byte) 110,
            (byte) 117,
            (byte) 107,
            (byte) 101,
            (byte) 0
                    });
                    break;
                case 5:
                    PS3.SetMemory(29080620U, new byte[28]
                    {
            (byte) 94,
            (byte) 54,
            (byte) 94,
            (byte) 1,
            (byte) 109,
            (byte) 109,
            (byte) 20,
            (byte) 100,
            (byte) 112,
            (byte) 97,
            (byte) 100,
            (byte) 95,
            (byte) 107,
            (byte) 105,
            (byte) 108,
            (byte) 108,
            (byte) 115,
            (byte) 116,
            (byte) 114,
            (byte) 101,
            (byte) 97,
            (byte) 107,
            (byte) 95,
            (byte) 110,
            (byte) 117,
            (byte) 107,
            (byte) 101,
            (byte) 0
                    });
                    break;
                case 6:
                    PS3.SetMemory(29080620U, new byte[31]
                    {
            (byte) 94,
            (byte) 1,
            (byte) 125,
            (byte) 125,
            (byte) 25,
            (byte) 105,
            (byte) 119,
            (byte) 53,
            (byte) 95,
            (byte) 99,
            (byte) 97,
            (byte) 114,
            (byte) 100,
            (byte) 116,
            (byte) 105,
            (byte) 116,
            (byte) 108,
            (byte) 101,
            (byte) 95,
            (byte) 101,
            (byte) 120,
            (byte) 112,
            (byte) 108,
            (byte) 111,
            (byte) 115,
            (byte) 105,
            (byte) 111,
            (byte) 110,
            (byte) 95,
            (byte) 97,
            (byte) 0
                    });
                    break;
                case 7:
                    PS3.SetMemory(29080620U, new byte[31]
                    {
            (byte) 94,
            (byte) 1,
            (byte) 125,
            (byte) 125,
            (byte) 25,
            (byte) 105,
            (byte) 119,
            (byte) 53,
            (byte) 95,
            (byte) 99,
            (byte) 97,
            (byte) 114,
            (byte) 100,
            (byte) 116,
            (byte) 105,
            (byte) 116,
            (byte) 108,
            (byte) 101,
            (byte) 95,
            (byte) 101,
            (byte) 120,
            (byte) 112,
            (byte) 108,
            (byte) 111,
            (byte) 115,
            (byte) 105,
            (byte) 111,
            (byte) 110,
            (byte) 95,
            (byte) 97,
            (byte) 0
                    });
                    break;
                case 8:
                    PS3.SetMemory(29080620U, new byte[31]
                    {
            (byte) 94,
            (byte) 1,
            (byte) 125,
            (byte) 125,
            (byte) 25,
            (byte) 105,
            (byte) 119,
            (byte) 53,
            (byte) 95,
            (byte) 99,
            (byte) 97,
            (byte) 114,
            (byte) 100,
            (byte) 116,
            (byte) 105,
            (byte) 116,
            (byte) 108,
            (byte) 101,
            (byte) 95,
            (byte) 101,
            (byte) 120,
            (byte) 112,
            (byte) 108,
            (byte) 111,
            (byte) 115,
            (byte) 105,
            (byte) 111,
            (byte) 110,
            (byte) 95,
            (byte) 97,
            (byte) 0
                    });
                    break;
            }
            if (MW3.Countername == 9)
                MW3.Countername = 0;
            this.MOAB.Start();
        }

        private void Button133_Click(object sender, EventArgs e)
        {
            if (button133.Text == "MOAB Name OFF")
            {
                MOAB.Start();
                button133.Text = "MOAB Name ON";
            }
            else if (button133.Text == "MOAB Name ON")
            {
                MOAB.Stop();
                button133.Text = "MOAB Name OFF";
            }
        }

        private void TimeName_Tick(object sender, EventArgs e)
        {
            this.TimeName.Start();
            this.TimeNow = DateTime.Now.ToString("HH:mm:ss");
            byte[] bytes = Encoding.ASCII.GetBytes("^2Time: ^5" + this.TimeNow);
            Array.Resize<byte>(ref bytes, bytes.Length + 1);
            PS3.SetMemory(29080620, bytes);
            this.TimeName.Start();
        }
        public string TimeNow { get; set; }

        private void Button134_Click(object sender, EventArgs e)
        {
            if (button134.Text == "Time Name OFF")
            {
                TimeName.Start();
                button134.Text = "Time Name ON";
            }
            else if (button134.Text == "Time Name ON")
            {
                TimeName.Stop();
                button134.Text = "Time Name OFF";
            }
        }

        private void Button135_Click(object sender, EventArgs e)
        {
            if (button135.Text == "BigButton OFF")
            {
                BigButton.Start();
                button135.Text = "BigButton ON";
            }
            else if (button135.Text == "BigButton ON")
            {
                BigButton.Stop();
                button135.Text = "BigButton OFF";
            }
        }

        private void BigButton_Tick(object sender, EventArgs e)
        {
            this.BigButton.Start();
            this.BigButton.Interval = 500;
            ++MW3.Countername;
            switch (MW3.Countername - 1)
            {
                case 0:
                    byte[] buffer1 = new byte[18]
        {
            (byte) 1,
            (byte) 2,
            (byte) 3,
            (byte) 4,
            (byte) 5,
            (byte) 6,
            (byte) 16,
            (byte) 15,
            (byte) 17,
            (byte) 18,
            (byte) 19,
            (byte) 14,
            (byte) 20,
            (byte) 21,
            (byte) 22,
            (byte) 23,
            (byte) 0,
            (byte) 0
        };
                    PS3.SetMemory(29080620, buffer1);
                    break;
                case 1:
                    byte[] buffer2 = new byte[18]
        {
            (byte) 23,
            (byte) 1,
            (byte) 2,
            (byte) 3,
            (byte) 4,
            (byte) 5,
            (byte) 6,
            (byte) 16,
            (byte) 15,
            (byte) 17,
            (byte) 18,
            (byte) 19,
            (byte) 14,
            (byte) 20,
            (byte) 21,
            (byte) 22,
            (byte) 0,
            (byte) 0
        };
                    PS3.SetMemory(29080620, buffer2);
                    break;
                case 2:
                    byte[] buffer3 = new byte[18]
        {
            (byte) 22,
            (byte) 23,
            (byte) 1,
            (byte) 2,
            (byte) 3,
            (byte) 4,
            (byte) 5,
            (byte) 6,
            (byte) 16,
            (byte) 15,
            (byte) 17,
            (byte) 18,
            (byte) 19,
            (byte) 14,
            (byte) 20,
            (byte) 21,
            (byte) 0,
            (byte) 0
        };
                    PS3.SetMemory(29080620, buffer3);
                    break;
                case 3:
                    byte[] buffer4 = new byte[18]
        {
            (byte) 21,
            (byte) 22,
            (byte) 23,
            (byte) 1,
            (byte) 2,
            (byte) 3,
            (byte) 4,
            (byte) 5,
            (byte) 6,
            (byte) 16,
            (byte) 15,
            (byte) 17,
            (byte) 18,
            (byte) 19,
            (byte) 14,
            (byte) 20,
            (byte) 0,
            (byte) 0
        };
                    PS3.SetMemory(29080620, buffer4);
                    break;
                case 4:
                    byte[] buffer5 = new byte[18]
        {
            (byte) 20,
            (byte) 21,
            (byte) 22,
            (byte) 23,
            (byte) 1,
            (byte) 2,
            (byte) 3,
            (byte) 4,
            (byte) 5,
            (byte) 6,
            (byte) 16,
            (byte) 15,
            (byte) 17,
            (byte) 18,
            (byte) 19,
            (byte) 14,
            (byte) 0,
            (byte) 0
        };
                    PS3.SetMemory(29080620, buffer5);
                    break;
                case 5:
                    byte[] buffer6 = new byte[18]
        {
            (byte) 14,
            (byte) 20,
            (byte) 21,
            (byte) 22,
            (byte) 23,
            (byte) 1,
            (byte) 2,
            (byte) 3,
            (byte) 4,
            (byte) 5,
            (byte) 6,
            (byte) 16,
            (byte) 15,
            (byte) 17,
            (byte) 18,
            (byte) 19,
            (byte) 0,
            (byte) 0
        };
                    PS3.SetMemory(29080620, buffer6);
                    break;
                case 6:
                    byte[] buffer7 = new byte[18]
        {
            (byte) 19,
            (byte) 14,
            (byte) 20,
            (byte) 21,
            (byte) 22,
            (byte) 23,
            (byte) 1,
            (byte) 2,
            (byte) 3,
            (byte) 4,
            (byte) 5,
            (byte) 6,
            (byte) 16,
            (byte) 15,
            (byte) 17,
            (byte) 18,
            (byte) 0,
            (byte) 0
        };
                    PS3.SetMemory(29080620, buffer7);
                    break;
                case 7:
                    byte[] buffer8 = new byte[18]
        {
            (byte) 18,
            (byte) 19,
            (byte) 14,
            (byte) 20,
            (byte) 21,
            (byte) 22,
            (byte) 23,
            (byte) 1,
            (byte) 2,
            (byte) 3,
            (byte) 4,
            (byte) 5,
            (byte) 6,
            (byte) 16,
            (byte) 15,
            (byte) 17,
            (byte) 0,
            (byte) 0
        };
                    PS3.SetMemory(29080620, buffer8);
                    break;
                case 8:
                    byte[] buffer9 = new byte[18]
        {
            (byte) 17,
            (byte) 18,
            (byte) 19,
            (byte) 14,
            (byte) 20,
            (byte) 21,
            (byte) 22,
            (byte) 23,
            (byte) 1,
            (byte) 2,
            (byte) 3,
            (byte) 4,
            (byte) 5,
            (byte) 6,
            (byte) 16,
            (byte) 15,
            (byte) 0,
            (byte) 0
        };
                    PS3.SetMemory(29080620, buffer9);
                    break;
                case 9:
                    byte[] buffer10 = new byte[18]
        {
            (byte) 15,
            (byte) 17,
            (byte) 18,
            (byte) 19,
            (byte) 14,
            (byte) 20,
            (byte) 21,
            (byte) 22,
            (byte) 23,
            (byte) 1,
            (byte) 2,
            (byte) 3,
            (byte) 4,
            (byte) 5,
            (byte) 6,
            (byte) 16,
            (byte) 0,
            (byte) 0
        };
                    PS3.SetMemory(29080620, buffer10);
                    break;
                case 10:
                    byte[] buffer11 = new byte[18]
        {
            (byte) 16,
            (byte) 15,
            (byte) 17,
            (byte) 18,
            (byte) 19,
            (byte) 14,
            (byte) 20,
            (byte) 21,
            (byte) 22,
            (byte) 23,
            (byte) 1,
            (byte) 2,
            (byte) 3,
            (byte) 4,
            (byte) 5,
            (byte) 6,
            (byte) 0,
            (byte) 0
        };
                    PS3.SetMemory(29080620, buffer11);
                    break;
                case 11:
                    byte[] buffer12 = new byte[18]
        {
            (byte) 6,
            (byte) 16,
            (byte) 15,
            (byte) 17,
            (byte) 18,
            (byte) 19,
            (byte) 14,
            (byte) 20,
            (byte) 21,
            (byte) 22,
            (byte) 23,
            (byte) 1,
            (byte) 2,
            (byte) 3,
            (byte) 4,
            (byte) 5,
            (byte) 0,
            (byte) 0
        };
                    PS3.SetMemory(29080620, buffer12);
                    break;
                case 12:
                    byte[] buffer13 = new byte[18]
        {
            (byte) 5,
            (byte) 6,
            (byte) 16,
            (byte) 15,
            (byte) 17,
            (byte) 18,
            (byte) 19,
            (byte) 14,
            (byte) 20,
            (byte) 21,
            (byte) 22,
            (byte) 23,
            (byte) 1,
            (byte) 2,
            (byte) 3,
            (byte) 4,
            (byte) 0,
            (byte) 0
        };
                    PS3.SetMemory(29080620, buffer13);
                    break;
                case 13:
                    byte[] buffer14 = new byte[18]
        {
            (byte) 4,
            (byte) 5,
            (byte) 6,
            (byte) 16,
            (byte) 15,
            (byte) 17,
            (byte) 18,
            (byte) 19,
            (byte) 14,
            (byte) 20,
            (byte) 21,
            (byte) 22,
            (byte) 23,
            (byte) 1,
            (byte) 2,
            (byte) 3,
            (byte) 0,
            (byte) 0
        };
                    PS3.SetMemory(29080620, buffer14);
                    break;
                case 14:
                    byte[] buffer15 = new byte[18]
        {
            (byte) 3,
            (byte) 4,
            (byte) 5,
            (byte) 6,
            (byte) 16,
            (byte) 15,
            (byte) 17,
            (byte) 18,
            (byte) 19,
            (byte) 14,
            (byte) 20,
            (byte) 21,
            (byte) 22,
            (byte) 23,
            (byte) 1,
            (byte) 2,
            (byte) 0,
            (byte) 0
        };
                    PS3.SetMemory(29080620, buffer15);
                    break;
                case 15:
                    byte[] buffer16 = new byte[18]
        {
            (byte) 2,
            (byte) 3,
            (byte) 4,
            (byte) 5,
            (byte) 6,
            (byte) 16,
            (byte) 15,
            (byte) 17,
            (byte) 18,
            (byte) 19,
            (byte) 14,
            (byte) 20,
            (byte) 21,
            (byte) 22,
            (byte) 23,
            (byte) 1,
            (byte) 0,
            (byte) 0
        };
                    PS3.SetMemory(29080620, buffer16);
                    break;
            }
            if (MW3.Countername == 17)
                MW3.Countername = 0;
            this.BigButton.Start();
        }

        private void Button136_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(29463676, BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown26.Value.ToString())));
        }

        private void Button141_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(29463148U, BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown17.Value.ToString())));
        }

        private void Button140_Click(object sender, EventArgs e)
        {
            byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown9.Value.ToString()));
            PS3.SetMemory(29463724, bytes);
        }

        private void Button139_Click(object sender, EventArgs e)
        {
            byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown13.Value.ToString()));
            PS3.SetMemory(29463732, bytes);
        }

        private void Button138_Click(object sender, EventArgs e)
        {
            byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown14.Value.ToString()));
            PS3.SetMemory(29463744, bytes);
        }

        private void Button137_Click(object sender, EventArgs e)
        {
            byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown15.Value.ToString()));
            PS3.SetMemory(29463740, bytes);
        }

        private void Button142_Click(object sender, EventArgs e)
        {
            byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown16.Value.ToString()));
            PS3.SetMemory(29463728, bytes);
        }

        private void Button149_Click(object sender, EventArgs e)
        {
            byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown24.Value.ToString()));
            PS3.SetMemory(29463776, bytes);
        }

        private void Button144_Click(object sender, EventArgs e)
        {
            byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown23.Value.ToString()));
            PS3.SetMemory(29463780, bytes);
        }

        private void Button145_Click(object sender, EventArgs e)
        {
            byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown22.Value.ToString()));
            PS3.SetMemory(29463784, bytes);
        }

        private void Button146_Click(object sender, EventArgs e)
        {
            byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown21.Value.ToString()));
            PS3.SetMemory(29463784, bytes);
        }

        private void Button147_Click(object sender, EventArgs e)
        {
            byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown20.Value.ToString()));
            PS3.SetMemory(29463800, bytes);
        }

        private void Button148_Click(object sender, EventArgs e)
        {
            byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown19.Value.ToString()));
            PS3.SetMemory(29463804, bytes);
        }

        private void Button143_Click(object sender, EventArgs e)
        {
            byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown18.Value.ToString()));
            PS3.SetMemory(29471451, bytes);
        }

        private void Button158_Click(object sender, EventArgs e)
        {
            byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown32.Value.ToString()));
            PS3.SetMemory(29463684, bytes);
        }

        private void Button153_Click(object sender, EventArgs e)
        {
            byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown31.Value.ToString()));
            PS3.SetMemory(29471606, bytes);
        }

        private void Button154_Click(object sender, EventArgs e)
        {
            byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown31.Value.ToString()));
            PS3.SetMemory(29471611, bytes);
        }

        private void Button155_Click(object sender, EventArgs e)
        {
            byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown29.Value.ToString()));
            PS3.SetMemory(29471617, bytes);
        }

        private void Button156_Click(object sender, EventArgs e)
        {
            byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown28.Value.ToString()));
            PS3.SetMemory(29471624, bytes);
        }

        private void Button157_Click(object sender, EventArgs e)
        {
            byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown27.Value.ToString()));
            PS3.SetMemory(29463758, bytes);
        }

        private void Button302_Click(object sender, EventArgs e)
        {
            comboBox6.DroppedDown = true;
        }

        private void ComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button223_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(29464677 + (Convert.ToInt32(this.comboBox6.Text.Replace("Class", "")) - 2) * 98), MW3.GmodOnline);
        }

        private void Button267_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(29466049 + (Convert.ToInt32(this.comboBox7.Text.Replace("Class", "")) - 1) * 98), MW3.GmodOnline);
        }

        private void Button303_Click(object sender, EventArgs e)
        {
            comboBox7.DroppedDown = true;
        }

        private void Button161_Click(object sender, EventArgs e)
        {
            byte[] bytes1 = Encoding.ASCII.GetBytes(this.textBox5.Text);
            Array.Resize<byte>(ref bytes1, bytes1.Length + 1);
            PS3.SetMemory(29464620, bytes1);

            byte[] bytes2 = Encoding.ASCII.GetBytes(this.textBox5.Text);
            Array.Resize<byte>(ref bytes2, bytes2.Length + 1);
            PS3.SetMemory(29464718, bytes2);

            byte[] bytes3 = Encoding.ASCII.GetBytes(this.textBox5.Text);
            Array.Resize<byte>(ref bytes3, bytes3.Length + 1);
            PS3.SetMemory(29464816, bytes3);

            byte[] bytes4 = Encoding.ASCII.GetBytes(this.textBox5.Text);
            Array.Resize<byte>(ref bytes4, bytes4.Length + 1);
            PS3.SetMemory(29464914, bytes4);

            byte[] bytes5 = Encoding.ASCII.GetBytes(this.textBox5.Text);
            Array.Resize<byte>(ref bytes5, bytes5.Length + 1);
            PS3.SetMemory(29465012, bytes5);

            byte[] bytes6 = Encoding.ASCII.GetBytes(this.textBox5.Text);
            Array.Resize<byte>(ref bytes6, bytes6.Length + 1);
            PS3.SetMemory(29465110, bytes6);

            byte[] bytes7 = Encoding.ASCII.GetBytes(this.textBox5.Text);
            Array.Resize<byte>(ref bytes7, bytes7.Length + 1);
            PS3.SetMemory(29465208, bytes7);

            byte[] bytes8 = Encoding.ASCII.GetBytes(this.textBox5.Text);
            Array.Resize<byte>(ref bytes8, bytes8.Length + 1);
            PS3.SetMemory(29465306, bytes8);

            byte[] bytes9 = Encoding.ASCII.GetBytes(this.textBox5.Text);
            Array.Resize<byte>(ref bytes9, bytes9.Length + 1);
            PS3.SetMemory(29465404, bytes9);

            byte[] bytes10 = Encoding.ASCII.GetBytes(this.textBox5.Text);
            Array.Resize<byte>(ref bytes10, bytes10.Length + 1);
            PS3.SetMemory(29465502, bytes10);

            byte[] bytes11 = Encoding.ASCII.GetBytes(this.textBox5.Text);
            Array.Resize<byte>(ref bytes11, bytes11.Length + 1);
            PS3.SetMemory(29465600, bytes11);

            byte[] bytes12 = Encoding.ASCII.GetBytes(this.textBox5.Text);
            Array.Resize<byte>(ref bytes12, bytes12.Length + 1);
            PS3.SetMemory(29465698, bytes12);

            byte[] bytes13 = Encoding.ASCII.GetBytes(this.textBox5.Text);
            Array.Resize<byte>(ref bytes13, bytes13.Length + 1);
            PS3.SetMemory(29465796, bytes13);

            byte[] bytes14 = Encoding.ASCII.GetBytes(this.textBox5.Text);
            Array.Resize<byte>(ref bytes14, bytes14.Length + 1);
            PS3.SetMemory(29465894, bytes14);

            byte[] bytes15 = Encoding.ASCII.GetBytes(this.textBox5.Text);
            Array.Resize<byte>(ref bytes15, bytes15.Length + 1);
            PS3.SetMemory(29465992, bytes15);
        }

        private void Button162_Click(object sender, EventArgs e)
        {

            if (comboBox3.Text == "Class 1")
            {
                byte[] bytes1 = Encoding.ASCII.GetBytes(this.textBox5.Text);
                Array.Resize<byte>(ref bytes1, bytes1.Length + 1);
                PS3.SetMemory(29464620, bytes1);
            }
            else if (comboBox3.Text == "Class 2")
            {
                byte[] bytes2 = Encoding.ASCII.GetBytes(this.textBox5.Text);
                Array.Resize<byte>(ref bytes2, bytes2.Length + 1);
                PS3.SetMemory(29464718, bytes2);
            }
            else if (comboBox3.Text == "Class 3")
            {
                byte[] bytes3 = Encoding.ASCII.GetBytes(this.textBox5.Text);
                Array.Resize<byte>(ref bytes3, bytes3.Length + 1);
                PS3.SetMemory(29464816, bytes3);
            }
            else if (comboBox3.Text == "Class 4")
            {
                byte[] bytes4 = Encoding.ASCII.GetBytes(this.textBox5.Text);
                Array.Resize<byte>(ref bytes4, bytes4.Length + 1);
                PS3.SetMemory(29464914, bytes4);
            }
            else if (comboBox3.Text == "Class 5")
            {
                byte[] bytes5 = Encoding.ASCII.GetBytes(this.textBox5.Text);
                Array.Resize<byte>(ref bytes5, bytes5.Length + 1);
                PS3.SetMemory(29465012, bytes5);
            }
            else if (comboBox3.Text == "Class 6")
            {
                byte[] bytes6 = Encoding.ASCII.GetBytes(this.textBox5.Text);
                Array.Resize<byte>(ref bytes6, bytes6.Length + 1);
                PS3.SetMemory(29465110, bytes6);
            }
            else if (comboBox3.Text == "Class 7")
            {
                byte[] bytes7 = Encoding.ASCII.GetBytes(this.textBox5.Text);
                Array.Resize<byte>(ref bytes7, bytes7.Length + 1);
                PS3.SetMemory(29465208, bytes7);
            }
            else if (comboBox3.Text == "Class 8")
            {
                byte[] bytes8 = Encoding.ASCII.GetBytes(this.textBox5.Text);
                Array.Resize<byte>(ref bytes8, bytes8.Length + 1);
                PS3.SetMemory(29465306, bytes8);
            }
            else if (comboBox3.Text == "Class 9")
            {
                byte[] bytes9 = Encoding.ASCII.GetBytes(this.textBox5.Text);
                Array.Resize<byte>(ref bytes9, bytes9.Length + 1);
                PS3.SetMemory(29465404, bytes9);
            }
            else if (comboBox3.Text == "Class 10")
            {
                byte[] bytes10 = Encoding.ASCII.GetBytes(this.textBox5.Text);
                Array.Resize<byte>(ref bytes10, bytes10.Length + 1);
                PS3.SetMemory(29465502, bytes10);
            }
            else if (comboBox3.Text == "Class 11")
            {
                byte[] bytes11 = Encoding.ASCII.GetBytes(this.textBox5.Text);
                Array.Resize<byte>(ref bytes11, bytes11.Length + 1);
                PS3.SetMemory(29465600, bytes11);
            }
            else if (comboBox3.Text == "Class 12")
            {
                byte[] bytes12 = Encoding.ASCII.GetBytes(this.textBox5.Text);
                Array.Resize<byte>(ref bytes12, bytes12.Length + 1);
                PS3.SetMemory(29465698, bytes12);
            }
            else if (comboBox3.Text == "Class 13")
            {
                byte[] bytes13 = Encoding.ASCII.GetBytes(this.textBox5.Text);
                Array.Resize<byte>(ref bytes13, bytes13.Length + 1);
                PS3.SetMemory(29465796, bytes13);
            }
            else if (comboBox3.Text == "Class 14")
            {
                byte[] bytes14 = Encoding.ASCII.GetBytes(this.textBox5.Text);
                Array.Resize<byte>(ref bytes14, bytes14.Length + 1);
                PS3.SetMemory(29465894, bytes14);
            }
            else if (comboBox3.Text == "Class 15")
            {
                byte[] bytes15 = Encoding.ASCII.GetBytes(this.textBox5.Text);
                Array.Resize<byte>(ref bytes15, bytes15.Length + 1);
                PS3.SetMemory(29465992, bytes15);
            }
        }

        private void Button164_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(this.MW3CustomClassAUG.Text.Replace("Custom Class", "")) - 1;
            byte[] bytes1 = new byte[1];
            byte[] bytes2 = new byte[1];
            byte[] numArray = new byte[1];
            byte[] bytes3 = new byte[1];
            int num2 = 29464580 + num1 * 98;
            if (this.MW3CamoAUG.Text == "Classic (Woodland)")
                bytes1 = new byte[1] { (byte)1 };
            else if (this.MW3CamoAUG.Text == "Snow (Desert)")
                bytes1 = new byte[1] { (byte)2 };
            else if (this.MW3CamoAUG.Text == "Multicam (Winter)")
                bytes1 = new byte[1] { (byte)3 };
            else if (this.MW3CamoAUG.Text == "Digital Urban (Digital)")
                bytes1 = new byte[1] { (byte)4 };
            else if (this.MW3CamoAUG.Text == "Hex (Urban)")
                bytes1 = new byte[1] { (byte)5 };
            else if (this.MW3CamoAUG.Text == "Snake (Blue Tiger)")
                bytes1 = new byte[1] { (byte)8 };
            else if (this.MW3CamoAUG.Text == "Blue (Autumn)")
                bytes1 = new byte[1] { (byte)10 };
            else if (this.MW3CamoAUG.Text == "Camo")
                bytes1 = new byte[1];
            else if (this.MW3CamoAUG.Text == "Red")
                bytes1 = new byte[1] { (byte)6 };
            if (this.MW3AttachmentAUG.Text == "Silencer")
                bytes2 = new byte[1] { (byte)17 };
            else if (this.MW3AttachmentAUG.Text == "Thermal")
                bytes2 = new byte[1] { (byte)5 };
            else if (this.MW3AttachmentAUG.Text == "Thermal and silencer")
            {
                bytes2 = new byte[1] { (byte)17 };
                byte[] bytes4 = new byte[1] { (byte)5 };
                this.MW3AttachmentAUG.Text = "Attachments";
                bytes3 = new byte[1] { (byte)57 };
                PS3.SetMemory((uint)(num2 + 4), bytes4);
            }
            else if (this.MW3AttachmentAUG.Text == "Red Dot")
                bytes2 = new byte[1] { (byte)1 };
            else if (this.MW3AttachmentAUG.Text == "ACOG")
                bytes2 = new byte[1] { (byte)2 };
            else if (this.MW3AttachmentAUG.Text == "Attachment")
                bytes2 = new byte[1];
            if (this.MW3ProficiencyAUG.Text == "Kick")
                bytes3 = new byte[1] { (byte)133 };
            else if (this.MW3ProficiencyAUG.Text == "Impact")
                bytes3 = new byte[1] { (byte)132 };
            else if (this.MW3ProficiencyAUG.Text == "Attachments")
                bytes3 = new byte[1] { (byte)57 };
            else if (this.MW3ProficiencyAUG.Text == "Focus")
                bytes3 = new byte[1] { (byte)134 };
            else if (this.MW3ProficiencyAUG.Text == "Speed")
                bytes3 = new byte[1] { (byte)35 };
            else if (this.MW3ProficiencyAUG.Text == "Stability")
                bytes3 = new byte[1] { (byte)139 };
            PS3.SetMemory((uint)num2, new byte[1] { (byte)90 });
            PS3.SetMemory((uint)(num2 + 6), bytes1);
            PS3.SetMemory((uint)(num2 + 2), bytes2);
            PS3.SetMemory((uint)(num2 + 8), bytes3);
        }
        public static byte[] method_51(int int_4)
        {
            return new byte[4]
            {
        (byte) int_4,
        (byte) (int_4 >> 8 & (int) byte.MaxValue),
        (byte) (int_4 >> 16 & (int) byte.MaxValue),
        (byte) (int_4 >> 24 & (int) byte.MaxValue)
            };
        }
        public static void UnlockAll()
        {
            PS3.SetMemory(MW3.uint_1 + 11019U, MW3.method_51(2100000000));
            PS3.SetMemory(29463148U, new byte[5]
            {
        (byte) 24,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 0
            });
            PS3.SetMemory(29463676U, new byte[1] { (byte)20 });
            PS3.SetMemory(29466539U, new byte[2]
            {
        (byte) 19,
        (byte) 2
            });
            PS3.SetMemory(29462708U, new byte[400]
            {
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184,
        (byte) 30,
        (byte) 184
            });
            PS3.SetMemory(29466610U, new byte[4096]
            {
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10,
        (byte) 10
            });
            PS3.SetMemory(29470880U, new byte[200]
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
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
            });
            PS3.SetMemory(29463156U, new byte[520]
            {
        byte.MaxValue,
        byte.MaxValue,
        (byte) 0,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 161,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 161,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 161,
        (byte) 0,
        (byte) 174,
        (byte) 10,
        (byte) 161,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 161,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 0,
        (byte) 224,
        (byte) 165,
        (byte) 26,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 17,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30,
        (byte) 30
            });
            PS3.SetMemory(29471468U, new byte[1] { byte.MaxValue });
            PS3.SetMemory(29471459U, new byte[1] { (byte)15 });
            byte[] numArray1 = new byte[1984]
            {
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 90,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 132,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 18,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 101,
        (byte) 0,
        (byte) 92,
        (byte) 0,
        (byte) 48,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 0,
        (byte) 112,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 1,
        (byte) 2,
        (byte) 3,
        (byte) 94,
        (byte) 54,
        (byte) 77,
        (byte) 87,
        (byte) 50,
        (byte) 32,
        (byte) 65,
        (byte) 85,
        (byte) 71,
        (byte) 3,
        (byte) 2,
        (byte) 1,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 118,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 33,
        (byte) 0,
        (byte) 36,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 40,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 132,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 18,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 106,
        (byte) 0,
        (byte) 92,
        (byte) 0,
        (byte) 48,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 0,
        (byte) 110,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 49,
        (byte) 94,
        (byte) 2,
        (byte) 161,
        (byte) 238,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 118,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 33,
        (byte) 0,
        (byte) 36,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 12,
        (byte) 0,
        (byte) 21,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 57,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 18,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 106,
        (byte) 0,
        (byte) 15,
        (byte) 0,
        (byte) 38,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 97,
        (byte) 0,
        (byte) 112,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 52,
        (byte) 77,
        (byte) 75,
        (byte) 49,
        (byte) 52,
        (byte) 13,
        (byte) 32,
        (byte) 94,
        (byte) 49,
        (byte) 77,
        (byte) 75,
        (byte) 49,
        (byte) 52,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 36,
        (byte) 0,
        (byte) 33,
        (byte) 0,
        (byte) 39,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 1,
        (byte) 40,
        (byte) 0,
        (byte) 16,
        (byte) 0,
        (byte) 21,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 57,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 106,
        (byte) 0,
        (byte) 15,
        (byte) 0,
        (byte) 38,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 97,
        (byte) 0,
        (byte) 112,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 18,
        (byte) 18,
        (byte) 94,
        (byte) 49,
        (byte) 78,
        (byte) 79,
        (byte) 32,
        (byte) 94,
        (byte) 48,
        (byte) 71,
        (byte) 85,
        (byte) 78,
        (byte) 17,
        (byte) 17,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 118,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 36,
        (byte) 0,
        (byte) 33,
        (byte) 0,
        (byte) 39,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 18,
        (byte) 0,
        (byte) 20,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 57,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 18,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 102,
        (byte) 0,
        (byte) 49,
        (byte) 0,
        (byte) 38,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 0,
        (byte) 112,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 50,
        (byte) 80,
        (byte) 94,
        (byte) 53,
        (byte) 77,
        (byte) 94,
        (byte) 54,
        (byte) 57,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 118,
        (byte) 0,
        (byte) 1,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 37,
        (byte) 0,
        (byte) 33,
        (byte) 0,
        (byte) 39,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 15,
        (byte) 0,
        (byte) 21,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 57,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 18,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 101,
        (byte) 0,
        (byte) 92,
        (byte) 0,
        (byte) 48,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 0,
        (byte) 112,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 50,
        (byte) 70,
        (byte) 65,
        (byte) 80,
        (byte) 32,
        (byte) 94,
        (byte) 54,
        (byte) 70,
        (byte) 65,
        (byte) 80,
        (byte) 32,
        (byte) 94,
        (byte) 51,
        (byte) 70,
        (byte) 65,
        (byte) 68,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 118,
        (byte) 0,
        (byte) 1,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 33,
        (byte) 0,
        (byte) 36,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 8,
        (byte) 0,
        (byte) 21,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 57,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 18,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 101,
        (byte) 0,
        (byte) 15,
        (byte) 0,
        (byte) 48,
        (byte) 0,
        (byte) 10,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 0,
        (byte) 76,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 49,
        (byte) 84,
        (byte) 89,
        (byte) 80,
        (byte) 69,
        (byte) 32,
        (byte) 94,
        (byte) 57,
        (byte) 57,
        (byte) 53,
        (byte) 17,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 118,
        (byte) 0,
        (byte) 1,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 36,
        (byte) 0,
        (byte) 33,
        (byte) 0,
        (byte) 37,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 1,
        (byte) 19,
        (byte) 0,
        (byte) 20,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 57,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 18,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 101,
        (byte) 0,
        (byte) 92,
        (byte) 0,
        (byte) 48,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 0,
        (byte) 112,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 51,
        (byte) 80,
        (byte) 57,
        (byte) 48,
        (byte) 32,
        (byte) 94,
        (byte) 50,
        (byte) 68,
        (byte) 65,
        (byte) 87,
        (byte) 71,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 118,
        (byte) 0,
        (byte) 1,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 33,
        (byte) 0,
        (byte) 36,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 20,
        (byte) 0,
        (byte) 20,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 57,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 18,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 107,
        (byte) 0,
        (byte) 92,
        (byte) 0,
        (byte) 48,
        (byte) 0,
        (byte) 74,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 0,
        (byte) 112,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 53,
        (byte) 80,
        (byte) 80,
        (byte) 77,
        (byte) 94,
        (byte) 49,
        (byte) 57,
        (byte) 48,
        (byte) 49,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 118,
        (byte) 0,
        (byte) 5,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 10,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 36,
        (byte) 0,
        (byte) 33,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 1,
        (byte) 16,
        (byte) 0,
        (byte) 21,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 57,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 46,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 101,
        (byte) 0,
        (byte) 92,
        (byte) 0,
        (byte) 48,
        (byte) 0,
        (byte) 10,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 0,
        (byte) 112,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 54,
        (byte) 67,
        (byte) 94,
        (byte) 51,
        (byte) 77,
        (byte) 94,
        (byte) 50,
        (byte) 57,
        (byte) 94,
        (byte) 53,
        (byte) 48,
        (byte) 94,
        (byte) 49,
        (byte) 49,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 118,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 10,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 36,
        (byte) 0,
        (byte) 33,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 11,
        (byte) 0,
        (byte) 21,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 57,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 18,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 101,
        (byte) 0,
        (byte) 92,
        (byte) 0,
        (byte) 38,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 97,
        (byte) 0,
        (byte) 110,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 14,
        (byte) 94,
        (byte) 50,
        (byte) 77,
        (byte) 94,
        (byte) 54,
        (byte) 161,
        (byte) 94,
        (byte) 50,
        (byte) 54,
        (byte) 15,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 118,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 36,
        (byte) 0,
        (byte) 33,
        (byte) 0,
        (byte) 39,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 1,
        (byte) 10,
        (byte) 0,
        (byte) 21,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 57,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 10,
        (byte) 0,
        (byte) 17,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 13,
        (byte) 0,
        (byte) 132,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 101,
        (byte) 0,
        (byte) 15,
        (byte) 0,
        (byte) 17,
        (byte) 0,
        (byte) 10,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 97,
        (byte) 0,
        (byte) 76,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 14,
        (byte) 15,
        (byte) 14,
        (byte) 15,
        (byte) 13,
        (byte) 32,
        (byte) 32,
        (byte) 32,
        (byte) 32,
        (byte) 94,
        (byte) 53,
        (byte) 50,
        (byte) 32,
        (byte) 94,
        (byte) 54,
        (byte) 65,
        (byte) 75,
        (byte) 39,
        (byte) 83,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 36,
        (byte) 0,
        (byte) 33,
        (byte) 0,
        (byte) 39,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 1,
        (byte) 22,
        (byte) 0,
        (byte) 20,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 13,
        (byte) 0,
        (byte) 57,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 18,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 108,
        (byte) 0,
        (byte) 92,
        (byte) 0,
        (byte) 38,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 97,
        (byte) 0,
        (byte) 110,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 5,
        (byte) 94,
        (byte) 53,
        (byte) 67,
        (byte) 79,
        (byte) 68,
        (byte) 78,
        (byte) 186,
        (byte) 186,
        (byte) 98,
        (byte) 70,
        (byte) 114,
        (byte) 105,
        (byte) 101,
        (byte) 110,
        (byte) 100,
        (byte) 108,
        (byte) 121,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 118,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 36,
        (byte) 0,
        (byte) 33,
        (byte) 0,
        (byte) 39,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 1,
        (byte) 63,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 13,
        (byte) 0,
        (byte) 138,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 63,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 102,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 17,
        (byte) 0,
        (byte) 10,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 0,
        (byte) 114,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 59,
        (byte) 82,
        (byte) 33,
        (byte) 48,
        (byte) 84,
        (byte) 32,
        (byte) 20,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 125,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 19,
        (byte) 0,
        (byte) 22,
        (byte) 0,
        (byte) 31,
        (byte) 0,
        (byte) 36,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 39,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 1,
        (byte) 7,
        (byte) 0,
        (byte) 21,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 13,
        (byte) 0,
        (byte) 57,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 18,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 108,
        (byte) 0,
        (byte) 92,
        (byte) 0,
        (byte) 38,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 97,
        (byte) 0,
        (byte) 110,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 14,
        (byte) 15,
        (byte) 14,
        (byte) 15,
        (byte) 14,
        (byte) 15,
        (byte) 13,
        (byte) 65,
        (byte) 94,
        (byte) 51,
        (byte) 67,
        (byte) 94,
        (byte) 50,
        (byte) 82,
        (byte) 33,
        (byte) 33,
        (byte) 33,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 118,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 36,
        (byte) 0,
        (byte) 33,
        (byte) 0,
        (byte) 39,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 40,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 132,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 18,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 106,
        (byte) 0,
        (byte) 15,
        (byte) 0,
        (byte) 38,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 97,
        (byte) 0,
        (byte) 131,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 53,
        (byte) 94,
        (byte) 2,
        (byte) 161,
        (byte) 238,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 118,
        (byte) 0,
        (byte) 1,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 19,
        (byte) 0,
        (byte) 23,
        (byte) 0,
        (byte) 25,
        (byte) 0,
        (byte) 35,
        (byte) 0,
        (byte) 33,
        (byte) 0,
        (byte) 39,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 1,
        (byte) 90,
        (byte) 0,
        (byte) 1,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 10,
        (byte) 0,
        (byte) 132,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 18,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 106,
        (byte) 0,
        (byte) 15,
        (byte) 0,
        (byte) 38,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 97,
        (byte) 0,
        (byte) 131,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 51,
        (byte) 67,
        (byte) 79,
        (byte) 68,
        (byte) 78,
        (byte) 186,
        (byte) 186,
        (byte) 98,
        (byte) 70,
        (byte) 114,
        (byte) 105,
        (byte) 101,
        (byte) 110,
        (byte) 100,
        (byte) 108,
        (byte) 121,
        (byte) 174,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 35,
        (byte) 0,
        (byte) 33,
        (byte) 0,
        (byte) 39,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 1,
        (byte) 63,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 138,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 63,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 140,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 102,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 17,
        (byte) 0,
        (byte) 10,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 0,
        (byte) 114,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 1,
        (byte) 2,
        (byte) 3,
        (byte) 17,
        (byte) 19,
        (byte) 6,
        (byte) 94,
        (byte) 48,
        (byte) 72,
        (byte) 170,
        (byte) 169,
        (byte) 107,
        (byte) 161,
        (byte) 110,
        (byte) 103,
        (byte) 13,
        (byte) 15,
        (byte) 14,
        (byte) 15,
        (byte) 64,
        (byte) 0,
        (byte) 118,
        (byte) 0,
        (byte) 1,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 19,
        (byte) 0,
        (byte) 23,
        (byte) 0,
        (byte) 25,
        (byte) 0,
        (byte) 35,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 39,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 22,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 20,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 57,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 1,
        (byte) 0,
        (byte) 18,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 102,
        (byte) 0,
        (byte) 15,
        (byte) 0,
        (byte) 48,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 97,
        (byte) 0,
        (byte) 131,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 54,
        (byte) 171,
        (byte) 72,
        (byte) 166,
        (byte) 116,
        (byte) 109,
        (byte) 97,
        (byte) 114,
        (byte) 107,
        (byte) 101,
        (byte) 114,
        (byte) 122,
        (byte) 33,
        (byte) 33,
        (byte) 171,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 118,
        (byte) 0,
        (byte) 1,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 19,
        (byte) 0,
        (byte) 23,
        (byte) 0,
        (byte) 25,
        (byte) 0,
        (byte) 40,
        (byte) 0,
        (byte) 35,
        (byte) 0,
        (byte) 33,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 40,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 132,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 18,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 106,
        (byte) 0,
        (byte) 15,
        (byte) 0,
        (byte) 48,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 97,
        (byte) 0,
        (byte) 131,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 22,
        (byte) 22,
        (byte) 94,
        (byte) 49,
        (byte) 81,
        (byte) 167,
        (byte) 32,
        (byte) 94,
        (byte) 54,
        (byte) 65,
        (byte) 108,
        (byte) 108,
        (byte) 32,
        (byte) 94,
        (byte) 59,
        (byte) 68,
        (byte) 97,
        (byte) 121,
        (byte) 23,
        (byte) 23,
        (byte) 0,
        (byte) 118,
        (byte) 0,
        (byte) 1,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 19,
        (byte) 0,
        (byte) 23,
        (byte) 0,
        (byte) 25,
        (byte) 0,
        (byte) 40,
        (byte) 0,
        (byte) 33,
        (byte) 0,
        (byte) 35,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 21,
        (byte) 2,
        (byte) 19,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0
            };
            byte[] numArray2 = new byte[1];
            byte[] numArray3 = new byte[1];
            byte[] numArray4 = new byte[1];
            byte[] numArray5 = new byte[1];
            byte[] bytes1 = new byte[1] { (byte)10 };
            byte[] bytes2 = new byte[1] { (byte)17 };
            byte[] bytes3 = new byte[1] { (byte)132 };
            PS3.SetMemory(29464580U, new byte[1] { (byte)90 });
            PS3.SetMemory(29464586U, bytes1);
            PS3.SetMemory(29464582U, bytes2);
            PS3.SetMemory(29464588U, bytes3);
        }
        private void Button163_Click(object sender, EventArgs e)
        {
            comboBox3.DroppedDown = true;
        }

        private void Button160_Click(object sender, EventArgs e)
        {
            MW3.UnlockAll();
        }

        private void Button159_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(29471468U, new byte[1]
      {
        byte.MaxValue
      });
            PS3.SetMemory(29471459U, new byte[1] { (byte)15 });
            PS3.SetMemory(29464576U, new byte[1984]
            {
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 90,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 132,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 18,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 101,
        (byte) 0,
        (byte) 92,
        (byte) 0,
        (byte) 48,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 0,
        (byte) 112,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 1,
        (byte) 2,
        (byte) 3,
        (byte) 94,
        (byte) 54,
        (byte) 77,
        (byte) 87,
        (byte) 50,
        (byte) 32,
        (byte) 65,
        (byte) 85,
        (byte) 71,
        (byte) 3,
        (byte) 2,
        (byte) 1,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 118,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 33,
        (byte) 0,
        (byte) 36,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 40,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 132,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 18,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 106,
        (byte) 0,
        (byte) 92,
        (byte) 0,
        (byte) 48,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 0,
        (byte) 110,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 49,
        (byte) 94,
        (byte) 2,
        (byte) 161,
        (byte) 238,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 118,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 33,
        (byte) 0,
        (byte) 36,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 12,
        (byte) 0,
        (byte) 21,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 57,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 18,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 106,
        (byte) 0,
        (byte) 15,
        (byte) 0,
        (byte) 38,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 97,
        (byte) 0,
        (byte) 112,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 52,
        (byte) 77,
        (byte) 75,
        (byte) 49,
        (byte) 52,
        (byte) 13,
        (byte) 32,
        (byte) 94,
        (byte) 49,
        (byte) 77,
        (byte) 75,
        (byte) 49,
        (byte) 52,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 36,
        (byte) 0,
        (byte) 33,
        (byte) 0,
        (byte) 39,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 1,
        (byte) 40,
        (byte) 0,
        (byte) 16,
        (byte) 0,
        (byte) 21,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 57,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 106,
        (byte) 0,
        (byte) 15,
        (byte) 0,
        (byte) 38,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 97,
        (byte) 0,
        (byte) 112,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 18,
        (byte) 18,
        (byte) 94,
        (byte) 49,
        (byte) 78,
        (byte) 79,
        (byte) 32,
        (byte) 94,
        (byte) 48,
        (byte) 71,
        (byte) 85,
        (byte) 78,
        (byte) 17,
        (byte) 17,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 118,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 36,
        (byte) 0,
        (byte) 33,
        (byte) 0,
        (byte) 39,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 18,
        (byte) 0,
        (byte) 20,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 57,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 18,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 102,
        (byte) 0,
        (byte) 49,
        (byte) 0,
        (byte) 38,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 0,
        (byte) 112,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 50,
        (byte) 80,
        (byte) 94,
        (byte) 53,
        (byte) 77,
        (byte) 94,
        (byte) 54,
        (byte) 57,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 118,
        (byte) 0,
        (byte) 1,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 37,
        (byte) 0,
        (byte) 33,
        (byte) 0,
        (byte) 39,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 15,
        (byte) 0,
        (byte) 21,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 57,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 18,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 101,
        (byte) 0,
        (byte) 92,
        (byte) 0,
        (byte) 48,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 0,
        (byte) 112,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 50,
        (byte) 70,
        (byte) 65,
        (byte) 80,
        (byte) 32,
        (byte) 94,
        (byte) 54,
        (byte) 70,
        (byte) 65,
        (byte) 80,
        (byte) 32,
        (byte) 94,
        (byte) 51,
        (byte) 70,
        (byte) 65,
        (byte) 68,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 118,
        (byte) 0,
        (byte) 1,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 33,
        (byte) 0,
        (byte) 36,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 8,
        (byte) 0,
        (byte) 21,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 57,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 18,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 101,
        (byte) 0,
        (byte) 15,
        (byte) 0,
        (byte) 48,
        (byte) 0,
        (byte) 10,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 0,
        (byte) 76,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 49,
        (byte) 84,
        (byte) 89,
        (byte) 80,
        (byte) 69,
        (byte) 32,
        (byte) 94,
        (byte) 57,
        (byte) 57,
        (byte) 53,
        (byte) 17,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 118,
        (byte) 0,
        (byte) 1,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 36,
        (byte) 0,
        (byte) 33,
        (byte) 0,
        (byte) 37,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 1,
        (byte) 19,
        (byte) 0,
        (byte) 20,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 57,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 18,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 101,
        (byte) 0,
        (byte) 92,
        (byte) 0,
        (byte) 48,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 0,
        (byte) 112,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 51,
        (byte) 80,
        (byte) 57,
        (byte) 48,
        (byte) 32,
        (byte) 94,
        (byte) 50,
        (byte) 68,
        (byte) 65,
        (byte) 87,
        (byte) 71,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 118,
        (byte) 0,
        (byte) 1,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 33,
        (byte) 0,
        (byte) 36,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 20,
        (byte) 0,
        (byte) 20,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 57,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 18,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 107,
        (byte) 0,
        (byte) 92,
        (byte) 0,
        (byte) 48,
        (byte) 0,
        (byte) 74,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 0,
        (byte) 112,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 53,
        (byte) 80,
        (byte) 80,
        (byte) 77,
        (byte) 94,
        (byte) 49,
        (byte) 57,
        (byte) 48,
        (byte) 49,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 118,
        (byte) 0,
        (byte) 5,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 10,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 36,
        (byte) 0,
        (byte) 33,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 1,
        (byte) 16,
        (byte) 0,
        (byte) 21,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 57,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 46,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 101,
        (byte) 0,
        (byte) 92,
        (byte) 0,
        (byte) 48,
        (byte) 0,
        (byte) 10,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 0,
        (byte) 112,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 54,
        (byte) 67,
        (byte) 94,
        (byte) 51,
        (byte) 77,
        (byte) 94,
        (byte) 50,
        (byte) 57,
        (byte) 94,
        (byte) 53,
        (byte) 48,
        (byte) 94,
        (byte) 49,
        (byte) 49,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 118,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 10,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 36,
        (byte) 0,
        (byte) 33,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 11,
        (byte) 0,
        (byte) 21,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 57,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 18,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 101,
        (byte) 0,
        (byte) 92,
        (byte) 0,
        (byte) 38,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 97,
        (byte) 0,
        (byte) 110,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 14,
        (byte) 94,
        (byte) 50,
        (byte) 77,
        (byte) 94,
        (byte) 54,
        (byte) 161,
        (byte) 94,
        (byte) 50,
        (byte) 54,
        (byte) 15,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 118,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 36,
        (byte) 0,
        (byte) 33,
        (byte) 0,
        (byte) 39,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 1,
        (byte) 10,
        (byte) 0,
        (byte) 21,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 57,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 10,
        (byte) 0,
        (byte) 17,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 13,
        (byte) 0,
        (byte) 132,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 101,
        (byte) 0,
        (byte) 15,
        (byte) 0,
        (byte) 17,
        (byte) 0,
        (byte) 10,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 97,
        (byte) 0,
        (byte) 76,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 14,
        (byte) 15,
        (byte) 14,
        (byte) 15,
        (byte) 13,
        (byte) 32,
        (byte) 32,
        (byte) 32,
        (byte) 32,
        (byte) 94,
        (byte) 53,
        (byte) 50,
        (byte) 32,
        (byte) 94,
        (byte) 54,
        (byte) 65,
        (byte) 75,
        (byte) 39,
        (byte) 83,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 36,
        (byte) 0,
        (byte) 33,
        (byte) 0,
        (byte) 39,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 1,
        (byte) 22,
        (byte) 0,
        (byte) 20,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 13,
        (byte) 0,
        (byte) 57,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 18,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 108,
        (byte) 0,
        (byte) 92,
        (byte) 0,
        (byte) 38,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 97,
        (byte) 0,
        (byte) 110,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 5,
        (byte) 94,
        (byte) 53,
        (byte) 67,
        (byte) 79,
        (byte) 68,
        (byte) 78,
        (byte) 186,
        (byte) 186,
        (byte) 98,
        (byte) 70,
        (byte) 114,
        (byte) 105,
        (byte) 101,
        (byte) 110,
        (byte) 100,
        (byte) 108,
        (byte) 121,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 118,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 36,
        (byte) 0,
        (byte) 33,
        (byte) 0,
        (byte) 39,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 1,
        (byte) 63,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 13,
        (byte) 0,
        (byte) 138,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 63,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 102,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 17,
        (byte) 0,
        (byte) 10,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 0,
        (byte) 114,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 59,
        (byte) 82,
        (byte) 33,
        (byte) 48,
        (byte) 84,
        (byte) 32,
        (byte) 20,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 125,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 19,
        (byte) 0,
        (byte) 22,
        (byte) 0,
        (byte) 31,
        (byte) 0,
        (byte) 36,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 39,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 1,
        (byte) 7,
        (byte) 0,
        (byte) 21,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 13,
        (byte) 0,
        (byte) 57,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 18,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 108,
        (byte) 0,
        (byte) 92,
        (byte) 0,
        (byte) 38,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 97,
        (byte) 0,
        (byte) 110,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 14,
        (byte) 15,
        (byte) 14,
        (byte) 15,
        (byte) 14,
        (byte) 15,
        (byte) 13,
        (byte) 65,
        (byte) 94,
        (byte) 51,
        (byte) 67,
        (byte) 94,
        (byte) 50,
        (byte) 82,
        (byte) 33,
        (byte) 33,
        (byte) 33,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 118,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 36,
        (byte) 0,
        (byte) 33,
        (byte) 0,
        (byte) 39,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 40,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 132,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 18,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 106,
        (byte) 0,
        (byte) 15,
        (byte) 0,
        (byte) 38,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 97,
        (byte) 0,
        (byte) 131,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 53,
        (byte) 94,
        (byte) 2,
        (byte) 161,
        (byte) 238,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 118,
        (byte) 0,
        (byte) 1,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 19,
        (byte) 0,
        (byte) 23,
        (byte) 0,
        (byte) 25,
        (byte) 0,
        (byte) 35,
        (byte) 0,
        (byte) 33,
        (byte) 0,
        (byte) 39,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 1,
        (byte) 90,
        (byte) 0,
        (byte) 1,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 10,
        (byte) 0,
        (byte) 132,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 18,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 106,
        (byte) 0,
        (byte) 15,
        (byte) 0,
        (byte) 38,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 97,
        (byte) 0,
        (byte) 131,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 51,
        (byte) 67,
        (byte) 79,
        (byte) 68,
        (byte) 78,
        (byte) 186,
        (byte) 186,
        (byte) 98,
        (byte) 70,
        (byte) 114,
        (byte) 105,
        (byte) 101,
        (byte) 110,
        (byte) 100,
        (byte) 108,
        (byte) 121,
        (byte) 174,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 35,
        (byte) 0,
        (byte) 33,
        (byte) 0,
        (byte) 39,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 1,
        (byte) 63,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 138,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 63,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 140,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 102,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 17,
        (byte) 0,
        (byte) 10,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 0,
        (byte) 114,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 1,
        (byte) 2,
        (byte) 3,
        (byte) 17,
        (byte) 19,
        (byte) 6,
        (byte) 94,
        (byte) 48,
        (byte) 72,
        (byte) 170,
        (byte) 169,
        (byte) 107,
        (byte) 161,
        (byte) 110,
        (byte) 103,
        (byte) 13,
        (byte) 15,
        (byte) 14,
        (byte) 15,
        (byte) 64,
        (byte) 0,
        (byte) 118,
        (byte) 0,
        (byte) 1,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 19,
        (byte) 0,
        (byte) 23,
        (byte) 0,
        (byte) 25,
        (byte) 0,
        (byte) 35,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 39,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 22,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 20,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 57,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 1,
        (byte) 0,
        (byte) 18,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 102,
        (byte) 0,
        (byte) 15,
        (byte) 0,
        (byte) 48,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 97,
        (byte) 0,
        (byte) 131,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 94,
        (byte) 54,
        (byte) 171,
        (byte) 72,
        (byte) 166,
        (byte) 116,
        (byte) 109,
        (byte) 97,
        (byte) 114,
        (byte) 107,
        (byte) 101,
        (byte) 114,
        (byte) 122,
        (byte) 33,
        (byte) 33,
        (byte) 171,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 118,
        (byte) 0,
        (byte) 1,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 19,
        (byte) 0,
        (byte) 23,
        (byte) 0,
        (byte) 25,
        (byte) 0,
        (byte) 40,
        (byte) 0,
        (byte) 35,
        (byte) 0,
        (byte) 33,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 40,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 9,
        (byte) 0,
        (byte) 132,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 18,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 106,
        (byte) 0,
        (byte) 15,
        (byte) 0,
        (byte) 48,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 97,
        (byte) 0,
        (byte) 131,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 22,
        (byte) 22,
        (byte) 94,
        (byte) 49,
        (byte) 81,
        (byte) 167,
        (byte) 32,
        (byte) 94,
        (byte) 54,
        (byte) 65,
        (byte) 108,
        (byte) 108,
        (byte) 32,
        (byte) 94,
        (byte) 59,
        (byte) 68,
        (byte) 97,
        (byte) 121,
        (byte) 23,
        (byte) 23,
        (byte) 0,
        (byte) 118,
        (byte) 0,
        (byte) 1,
        (byte) 0,
        (byte) 3,
        (byte) 0,
        (byte) 8,
        (byte) 0,
        (byte) 19,
        (byte) 0,
        (byte) 23,
        (byte) 0,
        (byte) 25,
        (byte) 0,
        (byte) 40,
        (byte) 0,
        (byte) 33,
        (byte) 0,
        (byte) 35,
        (byte) 0,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 4,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 6,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 21,
        (byte) 2,
        (byte) 19,
        (byte) 2,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0
            });
        }
        public string GetName2(int ClientNum)
        {
            byte[] array = new byte[20];
            PS3.GetMemory((uint)(24667244 + 22536 * ClientNum), array);
            string @string = Encoding.ASCII.GetString(array);
            return @string.Replace("\0", "");
        }
        private void button165_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            for (int i = 0; i < 18; i++)
            {
                string text = PS3.Extension.ReadString(Convert.ToUInt32(9032144 + i * 376));
                if (text == string.Empty)
                {
                    text = "(Empty)";
                }
                string id = Convert.ToString(i);
                this.dataGridView1.Rows[i].Cells[1].Value = (object)Convert.ToString(text);
               
            }
        }

        private void freezePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void enableToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            selected_client = (Convert.ToUInt16(this.dataGridView1.CurrentRow.Index));
            MW3RCE.RCE.WriteChar(0x0110D87F + (0x3980 * selected_client), 255);
        }

        private void ClientListTab_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
