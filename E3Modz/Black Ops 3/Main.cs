using E3Modz.Black_Ops_3;
using E3Modz.Login___Home;
using PS3Lib;
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

namespace E3Modz
{
    public partial class Main : Form
    {
        public int CLIENT = 0;
        public static string hencon = E3Modz.Properties.Settings.Default.IP1;
        private string ps3Ip;
        private readonly string errorStatus = "Process failed";
        PS3API E3modz = new PS3API();
        private bool hen = false;
        public static uint NameAddress = 0x5DB0;
        uint G_Client = (0x18C6220);
        bool RPC_Enabled = (false);
        uint Head = (0x338792);
        uint Fair = (0x72FFD54) + (0x18C6220);
        uint unfair = (0x72FFD54) + (0x18C6220) + (0x12C6F20);
        uint non = (0x72FFD54) + (0x18C6220) + (0x12A6F10);
        uint EnableESP = (0x014F5558);
        bool forceHostLoopOn = (false);
        uint G_Client_Size = (0x6200);
        uint selected_client = (0);
        public string string_3 = "N/A";
        public string string_0;
        public static System.Drawing.Point newpoint = new System.Drawing.Point();
        public static string Username;
        public static string Password;
        public static int x;
        public static int y;
        public static PS3API PS3 = new PS3API(SelectAPI.ControlConsole);
        public static PS3ManagerAPI.PS3MAPI PS3M_API = new PS3ManagerAPI.PS3MAPI();
        //AllClients
        bool AllClients = (false);
        bool setUFOonAC = (false);
        bool setGodOnAC = (false);
        bool setInfiAmmoOnAC = (false);
        bool setThirdPersonOnAC = (false);
        int setSpeedAC = (1);
        bool setJetPackOnAC = (false);
        bool[] setUFOon = new bool[12] { false, false, false, false, false, false, false, false, false, false, false, false };
        uint WaWaddy = 0x02BC260D;
        uint MW1addy = 0x10A8FC8D;
        uint MW2addy = 0x007EDCA4;
        uint MW3addy = 0x0122780D;
        uint BO1addy = 0x01C2AA21;
        internal uint a;
        uint BO2addy = 0x01F4A179;
        uint BO3addy = 0x00FC9135;
        #region default values

        uint CoDAddy = 0;
        bool Found = false;
        int saveInt = 0;
        int ByteLength = 500000;
        byte[] dump = { };
        #endregion
        public Main()
        {
            InitializeComponent();
            grabIPsTimer.Start();
            this.a = 0x20dfe78;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void TabPage5_Click(object sender, EventArgs e)
        {

        }
        private void loadSPRX()
        {

        }
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

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

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void ModdedList()
        {
            PS3.Extension.WriteString(0x300DD118, "^5Search Game");
            PS3.Extension.WriteString(0x300AC7EE, "^5Class Editor");
            PS3.Extension.WriteString(0x300B6A1D, "^5Specialist");
            PS3.Extension.WriteString(0x300ACB10, "^5Scorestreaks");
            PS3.Extension.WriteString(0x300ACB10, "^5Scorestreaks");
            PS3.Extension.WriteString(0x300EB012, "^5Multiplayer");
            PS3.Extension.WriteString(0x300EB068, "^5Multiplayer");
            PS3.Extension.WriteString(0x300EB068, "^5Custom Game");
            PS3.Extension.WriteString(0x300DE1CB, "^5Free Mode");
            PS3.Extension.WriteString(0x3010661E, "^2VortexRTM");

        }
        private void Button12_Click(object sender, EventArgs e)
        {

            if (HenCheck.Value == true)
            {
                if (E3Modz.Properties.Settings.Default.bool1 == true)
                {
                    PS3M_API.ConnectTarget(hencon, Convert.ToInt32(7887));
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
                            label19.Text = "Connected!";
                            button13.Enabled = true;

                            label19.ForeColor = Color.Green;
                        }
                        this.comboBox1.SelectedIndex = 0;
                        bunifuGauge1.Value = 50;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("No Console found!\nPlease add it on hen console manager!\n If you Click Yes you come to the Console Manager\nEROOR:0x7761A", "Some Title", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        HenCidChanger henman = new HenCidChanger();
                        henman.Show();

                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }
            }
            else
            {
                label20.Text = "Connecting..";
                if (E3modz.ConnectTarget())
                {
                    label20.Refresh();
                    label20.Text = "Connected";
                    button13.Enabled = true;
                    label19.Text = "Connected!";
                    label19.ForeColor = Color.Green;
                    MessageBox.Show("Connected!", "Succesfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Thread.Sleep(100);
                    label20.Text = "Awaiting attach..";
                    E3modz.CCAPI.RingBuzzer(CCAPI.BuzzerMode.Single);
                    E3modz.CCAPI.Notify(CCAPI.NotifyIcon.FINGER, "Connected with E3modz Tool :D");
                    label14.Text = E3modz.CCAPI.GetTemperatureCELL();
                    label15.Text = E3modz.CCAPI.GetTemperatureRSX();
                    label16.Text = E3modz.CCAPI.GetFirmwareVersion();
                    label17.Text = E3modz.CCAPI.GetFirmwareType();
                    button13.Enabled = true;
                    bunifuGauge1.Value = 50;

                }
                else
                {
                    MessageBox.Show("Operation Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    label20.Text = errorStatus;
                }
            }
        }


        //NewCodeAFTER BuyedVersion
        internal bool isAttached()
        {
            if(label20.Text == "Attached")
            {
                return true;
            }
            return false;
        }
        private string method_66(string string_3)
        {
            string result;
            if (string_3 == "BLUS31527" | string_3 == "BLES02166" | string_3 == "BLES02168" | string_3 == "BCJS35003" | string_3 == "NPEB02266" | string_3 == "NPEB02268" | string_3 == "NPJA00135" | string_3 == "NPUB31665")
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
        public static string smethod_9(byte[] byte_43)
        {
            ASCIIEncoding asciiencoding = new ASCIIEncoding();
            return asciiencoding.GetString(byte_43);
        }
        private void method_65()
        {
            byte[] byte_ = new byte[16];
            PS5.GetMemoryR(268501585u, ref byte_);
            string string_ = Main.smethod_9(byte_).Replace(Convert.ToChar(0).ToString(), string.Empty);
            this.string_0 = this.method_66(string_);
            this.label108.Text = this.string_0;
        }
        private void Button13_Click(object sender, EventArgs e)
        {
            if (HenCheck.Value == true)
            {
                PS3.ChangeAPI(SelectAPI.PS3Manager);
                if (!PS3M_API.AttachProcess(PS3M_API.Process.Processes_Pid[this.comboBox1.SelectedIndex]))
                {
                    MessageBox.Show("Impossible to attach :(", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    PS3M_API.DisconnectTarget();
                }
                hen = true;
                PS3M_API.PS3.Notify("Successfully Attached");
                PS6.Attach();
                label20.Refresh();
                RPC.Init();
                this.method_65();
                label14.Text = E3modz.CCAPI.GetTemperatureCELL();
                label15.Text = E3modz.CCAPI.GetTemperatureRSX();
                label16.Text = E3modz.CCAPI.GetFirmwareVersion();
                PS3.Extension.WriteString(0x10040010,"^1Vortex^2RTM");
                PS3.Extension.WriteFloat(0x10040004, 200F); //xpos
                PS3.Extension.WriteFloat(0x10040008, 200F); //ypos
                PS3.Extension.WriteFloat(0x1004000C, 0.75F); //size
                label112.Text = "Offset found!";
                label112.ForeColor = Color.Green;
                label17.Text = E3modz.CCAPI.GetFirmwareType();
                Patches();
                label20.Text = "Attached";
                RPC_Enabled = true;
                label12.Text = PS3.Extension.ReadString(0x01F2CE45);
                label13.Text = "Enabled";
                label19.Text = "Connected + Attached!";
                label19.ForeColor = Color.Green;
                label116.Text = "Enabled!";
                label116.ForeColor = Color.Green;
                MessageBox.Show("Attached!", "Succesfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Thread.Sleep(100);
                label20.Text = "Ready to Mod!";
                E3modz.CCAPI.RingBuzzer(CCAPI.BuzzerMode.Double);
                E3modz.CCAPI.Notify(CCAPI.NotifyIcon.FINGER, "Attached with VortexRTM Tool, Have Fun! :D");
                label106.Text = "Loaded!";
                bunifuGauge1.Value = 100;
                label106.ForeColor = Color.Green;

            }

            else
            {
                label20.Text = "Attaching..";
                if (E3modz.AttachProcess())
                {
                    PS5.Connect();
                    PS6.Attach();
                    label20.Refresh();
                    RPC.Init();
                    Patches();
                    PS3.Extension.WriteString(0xA5EF5D, "^2VortexRTM");
                    label20.Text = "Attached";
                    this.method_65();
                    RPC_Enabled = true;
                    label12.Text = PS3.Extension.ReadString(0x01F2CE45);
                    PS3.SetMemory(0xCC5A8, new byte[] { 0x2c, 0x14, 0x00, 0x01 });
                    ModdedList();
                    PS3.Extension.WriteString(0x00A544E8, "\n\n\n\n\n\n\n\n\n\n^5Vortex^2RTM");
                    label112.Text = "Offset found!";
                    label112.ForeColor = Color.Green;
                    label19.Text = "Connected + Attached!";
                    label19.ForeColor = Color.Green;
                    label13.Text = "Enabled";
                    label116.Text = "Enabled!";
                    label116.ForeColor = Color.Green;
                    MessageBox.Show("Attached!", "Succesfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Thread.Sleep(100);
                    label20.Text = "Ready to Mod!";
                    E3modz.CCAPI.RingBuzzer(CCAPI.BuzzerMode.Double);
                    E3modz.CCAPI.Notify(CCAPI.NotifyIcon.FINGER, "Attached with E3Modz Tool, Have Fun! :D");
                    label106.Text = "Loaded!";
                    bunifuGauge1.Value = 100;
                    label106.ForeColor = Color.Green;
                }
                else
                {
                    MessageBox.Show("Attaching failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


        private void Button1_Click(object sender, EventArgs e)
        {
            this.TabControl1.SelectedTab = Connection;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.TabControl1.SelectedTab = tabPage2;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.TabControl1.SelectedTab = Rce;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.TabControl1.SelectedTab = NameChange;
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anti VortexRTM is now Enabled!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button20_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.E3modz.SetMemory(810557548u, new byte[]
            {
                94
            });
        }

        private void Button21_Click(object sender, EventArgs e)
        {

        }

        private void AntiServerCrash_Tick(object sender, EventArgs e)
        {
            this.E3modz.SetMemory(9482500u, new byte[]
            {
                1
            });
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            if (button14.Text == "Anti Ban : OFF")
            {

                E3modz.SetMemory(0x7C4148, new byte[] { 0x60, 0, 0, 0 });
                E3modz.SetMemory(0x7C4050, new byte[] { 0x60, 0, 0, 0 });
                E3modz.SetMemory(0x55705C, new byte[] { 0x60, 0, 0, 0 });
                E3modz.SetMemory(0x5570FC, new byte[] { 0x60, 0, 0, 0 });
                E3modz.SetMemory(0x4AC9C0, new byte[] { 0x60, 0, 0, 0 });
                E3modz.SetMemory(0x4AAD20, new byte[] { 0x60, 0, 0, 0 });
                button14.Text = "Anti Ban : ON";
                label111.Text = "Enabled!";
                label111.ForeColor = Color.Green;


                MessageBox.Show("Anti-Ban: Enabled.", "E3Modz V1", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }

            else if (button14.Text == "Anti Ban : ON")
            {
                button14.Text = "Anti Ban : OFF";
            }
        }

        private void Button16_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            byte[] bytes = (Encoding.ASCII.GetBytes(textBox1.Text));
            E3modz.SetMemory(0x1f3cff4, bytes);
            byte[] buffer = (Encoding.ASCII.GetBytes(textBox1.Text));
            E3modz.SetMemory(0x20dfe78, buffer);
        }

        private void TabPage4_Click(object sender, EventArgs e)
        {

        }

        private void Button15_Click(object sender, EventArgs e)
        {

            RPC.Init();
            MessageBox.Show("Succesfully Enabled!", "Sucess!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Button10_Click(object sender, EventArgs e)
        {
            this.TabControl1.SelectedTab = ClientList;
        }
        public string GetName(int ClientNum)
        {
            byte[] array = new byte[20];
            PS3.GetMemory((uint)(G_Client + G_Client_Size * ClientNum + 0x5DB0), array);
            string @string = Encoding.ASCII.GetString(array);
            return @string.Replace("\0", "");
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            label33.Text = PS3.Extension.ReadString(PS3.Extension.ReadUInt32(0x00F57BF8) + 0x64);
            this.dataGridView1.Enabled = true;
            this.dataGridView1.RowCount = 12;
            for (int i = 0; i < 12; i++)
            {
                this.dataGridView1.Update();
                this.dataGridView1.Rows[i].Cells[0].Value = i;
                this.dataGridView1.Rows[i].Cells[1].Value = this.GetName(i);
            }
        }
        private void EnableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(0x17FF620 + 0x21C + dataGridView1.CurrentRow.Index * 0x350), new byte[2] { 0xFF, 0xFF });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Godmode ^2Enabled");
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            byte[] bytes = (Encoding.ASCII.GetBytes(textBox4.Text + "\0"));
            PS3.SetMemory(0x1f3cff4, bytes);
            byte[] buffer = (Encoding.ASCII.GetBytes(textBox4.Text + "\0"));
            PS3.SetMemory(0x20dfe78, buffer);
        }


        private void Button23_Click(object sender, EventArgs e)
        {
            if (button23.Text == "Flash OFF")
            {
                FlashName.Start();
                button23.Text = "Flash ON";
            }
            else if (button23.Text == "Flash ON")
            {

                button23.Text = "Flash OFF";
                FlashName.Stop();
            }
        }
        //Test 
        public void ChangeName(string InputText)
        {
            byte[] bytes = (Encoding.ASCII.GetBytes(InputText + "\0"));
            PS3.SetMemory(0x1f3cff4, bytes);
            byte[] buffer = (Encoding.ASCII.GetBytes(InputText + "\0"));
            PS3.SetMemory(0x20dfe78, buffer);
        }
        private void FlashName_Tick(object sender, EventArgs e)
        {
            int flashColor = (new Random().Next(0, 7));
            ChangeName("^" + flashColor + textBox4.Text);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.TabControl1.SelectedTab = NonHost;
        }

        private void Button27_Click(object sender, EventArgs e)
        {

        }

        private void Button30_Click(object sender, EventArgs e)
        {

        }

        private void Button32_Click(object sender, EventArgs e)
        {
        }

        private void Button31_Click(object sender, EventArgs e)
        {

        }

        private void Button33_Click(object sender, EventArgs e)
        {

        }

        private void Button34_Click(object sender, EventArgs e)
        {
            if (button34.Text == "Force Host OFF")
            {
                button34.Text = "Force Host ON";
                PS3.Extension.WriteBytes(0xCC5A8, new byte[] { 0x2C, 0x14, 0x00, 0x01 });
            }
            else if (button34.Text == "Force Host ON")
            {
                PS3.Extension.WriteBytes(0xCC5A8, new byte[] { 0x2C, 0x14, 0x00, 0x00 });
                button34.Text = "Force Host OFF";
            }
        }

        private void Button34_Click_1(object sender, EventArgs e)
        {

            RPC.CBuf_Addtext("cmd mr " + PS3.Extension.ReadInt32(0x1198860) + " 3 endround");
        }

        private void Button35_Click(object sender, EventArgs e)
        {
            RPC.CBuf_Addtext("cmd mr " + PS3.Extension.ReadInt32(0x1198860) + " 3 endround");
        }

        private void Button36_Click(object sender, EventArgs e)
        {

        }

        private void Button37_Click(object sender, EventArgs e)
        {

        }

        private void Button39_Click(object sender, EventArgs e)
        {

        }

        private void Button40_Click(object sender, EventArgs e)
        {

        }

        private void Button38_Click(object sender, EventArgs e)
        {

        }

        private void DisableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(0x17FF620 + 0x21C + dataGridView1.CurrentRow.Index * 0x350), new byte[2] { 0x00, 0x64 });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Godmode ^1Disabled");
        }

        private void EnableToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 0x12; i++)
            {

                PS3.SetMemory((G_Client + 0x548 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 15, 0xff, 0xff, 0xff });
                PS3.SetMemory((G_Client + 0x389 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 15, 0xff, 0xff, 0xff });
                PS3.SetMemory((G_Client + 0x584 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 15, 0xff, 0xff, 0xff });
                PS3.SetMemory((G_Client + 0x54c + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 15, 0xff, 0xff, 0xff });
                PS3.SetMemory((G_Client + 0x588 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 15, 0xff, 0xff, 0xff });
            }
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Unlimited Ammo: ^2Enabled");
        }

        private void Ammo_Tick(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(0x18C67A7 + this.dataGridView1.CurrentRow.Index * 0x350), new byte[4]
           {
              byte.MaxValue,
              byte.MaxValue,
              byte.MaxValue,
              byte.MaxValue
           });
            PS3.SetMemory((uint)(0x18C67B3 + this.dataGridView1.CurrentRow.Index * 0x350), new byte[4]
         {
              byte.MaxValue,
              byte.MaxValue,
              byte.MaxValue,
              byte.MaxValue
         });
            PS3.SetMemory((uint)(0x18C67AB + this.dataGridView1.CurrentRow.Index * 0x350), new byte[4]
        {
              byte.MaxValue,
              byte.MaxValue,
              byte.MaxValue,
              byte.MaxValue
        });
        }

        private void DisableToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RPC.iPrintlnBold(this.dataGridView1.CurrentRow.Index * 0x350, "^7Unlimited Ammo: ^1Disabled");

            PS3.SetMemory((0x18C4862 + (uint)dataGridView1.CurrentRow.Index * 0x61E0), new byte[] { 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory((0x18C4826 + (uint)dataGridView1.CurrentRow.Index * 0x61E0), new byte[] { 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory((0x18BC8C2 + (uint)dataGridView1.CurrentRow.Index * 0x61E0), new byte[] { 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory((0x18C486A + (uint)dataGridView1.CurrentRow.Index * 0x61E0), new byte[] { 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory((0x18C4864 + (uint)dataGridView1.CurrentRow.Index * 0x61E0), new byte[] { 0x00, 0x00, 0xff, 0x00 });

        }

        private void EnableToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            //Created by: ѕι∂яα∂ι from iHax.fr
            PS3.SetMemory((uint)(G_Client + 0x5D03 + dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x01 });
            PS3.SetMemory((uint)(G_Client + 0x5DFE + dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x00, 0xff });
            Thread.Sleep(0x1388);
            PS3.SetMemory((uint)(G_Client + 0x5D03 + dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x02 });
            RPC.iPrintlnBold(this.dataGridView1.CurrentRow.Index, "^7UFO MODE: ^2Enabled!");
        }


        private void Button9_Click(object sender, EventArgs e)
        {
            this.TabControl1.SelectedTab = IpGrabber;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            this.TabControl1.SelectedTab = Lobby;
        }

        private void Button37_Click_1(object sender, EventArgs e)
        {
            RPC.CBuf_Addtext("fast_restart ");
        }

        private void Button42_Click(object sender, EventArgs e)
        {
            int NumOfClients = (0);
            if (NumOfClients < 12)
            {
                Thread.Sleep(1000);
                RPC.Call(0x005EBEB0);
            }
            else
            {
                MessageBox.Show("Game is Full!", "Error");
            }
        }

        private void GravitySpikesToolStripMenuItem_Click(object sender, EventArgs e)
        {


            PS3.SetMemory((G_Client + 0x546 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 0xff });
            PS3.SetMemory((G_Client + 0x542 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 0xff });
            PS3.SetMemory((G_Client + 0x53e + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 0xff });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Unlimited Killstreaks ^2Enabled");
        }

        private void Button43_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 17; i++)
            {
                uint index = 0x18CC0BC + (uint)i * 0x6200;
                if (PS3.Extension.ReadString(index) == "ATVI")
                    RPC.CBuf_Addtext("clientKick " + (int)i);
            }
        }

        private void ClonePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RPC.Call(0x308B98 + (uint)this.dataGridView1.CurrentRow.Index);
            RPC.iPrintlnBold(this.dataGridView1.CurrentRow.Index, "^7You Have been Cloned by ^3E3ModzRTM TOOL :D");
        }

        private void GodModeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void KillPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void KillHimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selected_client = (Convert.ToUInt16(this.dataGridView1.CurrentRow.Index));
            Thread.Sleep(1000);
            PS3.SetMemory(0x00303748, new byte[] { 0x38, 0x60, 0x00, 0x14, 0x1C, 0x63, 0x03, 0x50, });
            PS3.SetMemory(0x0030374B, new byte[] { Convert.ToByte(selected_client) });
            RPC.Call(0x0030372C, 1);
            RPC.iPrintlnBold(this.dataGridView1.CurrentRow.Index, "^1Bitch you have been killed!");
        }

        private void KickPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RPC.CBuf_Addtext("clientkick " + (uint)this.dataGridView1.CurrentRow.Index);
        }

        private void Panel6_MouseDown(object sender, MouseEventArgs e)
        {
            Main.x = Control.MousePosition.X - base.Location.X;
            Main.y = Control.MousePosition.Y - base.Location.Y;
        }

        private void Panel6_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Main.newpoint = Control.MousePosition;
                Main.newpoint.X -= Main.x;
                Main.newpoint.Y -= Main.y;
                base.Location = Main.newpoint;
            }
        }
        void WriteInt(int client, uint addr, uint value)
        {
            var temp1 = addr - 0x36C85AC4;
            var temp2 = Convert.ToDecimal(temp1);
            RPC.Call(0x005EC544, client, 1, "i " + temp2 / 4 + " " + Convert.ToDecimal(value));
        }
        void redModdedName(int client)
        {
            WriteInt(client, 0x37EF8FD8 + (0 * 4), 0x5E3145);
            WriteInt(client, 0x37EF8FD8 + (1 * 4), 0x33);
            RPC.iPrintln(client, "Clantag ^2Given^7!");
        }
        void GreenModdedName(int client)
        {
            WriteInt(client, 0x37EF8FD8 + (0 * 4), 0x5E3245);
            WriteInt(client, 0x37EF8FD8 + (1 * 4), 0x33);
            RPC.iPrintln(client, "Clantag ^2Given^7!");
        }
        void YellowBlueModdedName(int client)
        {
            WriteInt(client, 0x37EF8FD8 + (0 * 4), 0x5E3345);
            WriteInt(client, 0x37EF8FD8 + (1 * 4), 0x33);
            RPC.iPrintln(client, "Clantag ^2Given^7!");
        }
        void CyanBlueModdedName(int client)
        {
            WriteInt(client, 0x37EF8FD8 + (0 * 4), 0x5e3545);
            WriteInt(client, 0x37EF8FD8 + (1 * 4), 0x33);
            RPC.iPrintln(client, "Clantag ^2Given^7!");
        }
        void PINKModdedName(int client)
        {
            WriteInt(client, 0x37EF8FD8 + (0 * 4), 0x5E3645);
            WriteInt(client, 0x37EF8FD8 + (1 * 4), 0x33);
            RPC.iPrintln(client, "Clantag ^2Given^7!");
        }
        void DarkBlueModdedName(int client)
        {
            WriteInt(client, 0x37EF8FD8 + (0 * 4), 0x5E3445);
            WriteInt(client, 0x37EF8FD8 + (1 * 4), 0x33);
            RPC.iPrintln(client, "Clantag ^2Given^7!");
        }
        void BlackModdedName(int client)
        {
            WriteInt(client, 0x37EF8FD8 + (0 * 4), 0x5E3045);
            WriteInt(client, 0x37EF8FD8 + (1 * 4), 0x33);
            RPC.iPrintln(client, "Clantag ^2Given^7!");
        }
        void GiveToken(int client)
        {
            WriteInt(client, 0x37EF80F4, 0x000000FF);
            RPC.iPrintln(client, "255 Unlock Tokens ^2Given^7!");
            RPC.iPrintln(client, "^1Youtube.com/E3Modz ^7- ^2Subscribe :)");
        }
        void Classes(int client)
        {
            WriteInt(client, 0x37EEC9F4 + (0 * 4), 0x00001100);
            WriteInt(client, 0x37EEC9F4 + (1 * 4), 0x11001100);
            WriteInt(client, 0x37EEC9F4 + (2 * 4), 0x11001100);
            RPC.iPrintln(client, "10 Classes ^2Given^7!");
            RPC.iPrintln(client, "^1Youtube.com/E3Modz ^7- ^2Subscribe :)");

        }
        void Rank55(int client)
        {
            WriteInt(client, 0x37EF8E5C, 0x00360000);
            WriteInt(client, 0x37EF8E60, 0x00980030);
            WriteInt(client, 0x37EF8E64, 0x3C160000);
            RPC.iPrintln(client, "Rank 55 ^2Given^7!");
        }
        void PS3Freeze(int client)
        {
            RPC.iPrintln(client, "PS3 Frozen ^1By VortexRTM ^6Bitch");
            Thread.Sleep(200);
            WriteInt(client, 0x1f3cff4 + (0 * 4), 0x5e3245);
            WriteInt(client, 0x1f3cff4 + (1 * 4), 0x33);
            RPC.iPrintln(client, "PS3 Frozen ^1By VortexRTM ^6Bitch");
        }
        void RecoverClient(int client)
        {
            WriteInt(client, 0x37EF8FD8 + (0 * 4), 0x5e3245);
            WriteInt(client, 0x37EF8FD8 + (1 * 4), 0x33);
            RPC.iPrintln(client, "Clantag ^2Given^7!");

            WriteInt(client, 0x37EF8E5C, 0x00360000);
            WriteInt(client, 0x37EF8E60, 0x00980030);
            WriteInt(client, 0x37EF8E64, 0x3C160000);
            RPC.iPrintln(client, "Rank 55 ^2Given^7!");

            WriteInt(client, 0x37EF8E44, 0x000B0000);
            RPC.iPrintln(client, "Master Prestige ^2Given^7!");

            WriteInt(client, 0x37EEC9F4 + (0 * 4), 0x00001100);
            WriteInt(client, 0x37EEC9F4 + (1 * 4), 0x11001100);
            WriteInt(client, 0x37EEC9F4 + (2 * 4), 0x11001100);
            RPC.iPrintln(client, "10 Classes ^2Given^7!");

            WriteInt(client, 0x37F107B0 + (0 * 4), 0x005E3159);
            WriteInt(client, 0x37F107B0 + (1 * 4), 0x6F757475);
            WriteInt(client, 0x37F107B0 + (2 * 4), 0x62653A00);
            WriteInt(client, 0x37F107B0 + (3 * 4), 0x00000000);
            WriteInt(client, 0x37F107B0 + (4 * 4), 0x5E324533);
            //WriteInt(client, 0x37F107B0 + (5 * 4), 0x7373756D);
            WriteInt(client, 0x37F107B0 + (6 * 4), 0x4D6f647A);
            //WriteInt(client, 0x37F107B0 + (7 * 4), 0x67617465);
            WriteInt(client, 0x37F107B0 + (8 * 4), 0x5E3553);
            WriteInt(client, 0x37F107B0 + (9 * 4), 0x53756273);
            WriteInt(client, 0x37F107B0 + (10 * 4), 0x63726962);
            WriteInt(client, 0x37F107B0 + (11 * 4), 0x65);
            WriteInt(client, 0x37F107B0 + (12 * 4), 0x005E354D);
            WriteInt(client, 0x37F107B0 + (13 * 4), 0x6F646465);
            WriteInt(client, 0x37F107B0 + (14 * 4), 0x64466F72);
            WriteInt(client, 0x37F107B0 + (15 * 4), 0x00000000);
            WriteInt(client, 0x37F107B0 + (16 * 4), 0x005E3649);
            WriteInt(client, 0x37F107B0 + (17 * 4), 0x6E737461);
            WriteInt(client, 0x37F107B0 + (18 * 4), 0x3A000000);
            WriteInt(client, 0x37F107B0 + (19 * 4), 0x00000000);
            WriteInt(client, 0x37F107B0 + (20 * 4), 0x005E364D);
            WriteInt(client, 0x37F107B0 + (21 * 4), 0x6F646465);
            WriteInt(client, 0x37F107B0 + (22 * 4), 0x644C6F62);
            WriteInt(client, 0x37F107B0 + (23 * 4), 0x62696573);
            WriteInt(client, 0x37F107B0 + (24 * 4), 0x005E3646);
            WriteInt(client, 0x37F107B0 + (25 * 4), 0x6F72596F);
            WriteInt(client, 0x37F107B0 + (26 * 4), 0x75000000);
            WriteInt(client, 0x37F107B0 + (27 * 4), 0x00000000);
            WriteInt(client, 0x37F107B0 + (28 * 4), 0x005E3246);
            WriteInt(client, 0x37F107B0 + (29 * 4), 0x6F6C6C6F);
            WriteInt(client, 0x37F107B0 + (30 * 4), 0x77204D65);
            WriteInt(client, 0x37F107B0 + (31 * 4), 0x21007421);
            WriteInt(client, 0x37F107B0 + (32 * 4), 0x005E324A);
            WriteInt(client, 0x37F107B0 + (33 * 4), 0x6F696E20);
            WriteInt(client, 0x37F107B0 + (34 * 4), 0x44697363);
            WriteInt(client, 0x37F107B0 + (35 * 4), 0x6F726421);
            WriteInt(client, 0x37F107B0 + (36 * 4), 0x20436F64);
            WriteInt(client, 0x37F107B0 + (37 * 4), 0x5e316575);
            WriteInt(client, 0x37F107B0 + (38 * 4), 0x516a4b70);
            WriteInt(client, 0x37F107B0 + (39 * 4), 0x6b77);
            WriteInt(client, 0x37F107B0 + (40 * 4), 0x20202020);
            WriteInt(client, 0x37F107B0 + (41 * 4), 0x20200000);
            RPC.iPrintln(client, "Modded Classnames ^2Given^7! by VortexRTM");

            WriteInt(client, 0x37EF80F4, 0x000000FF);
            RPC.iPrintln(client, "255 Unlock Tokens ^2Given^7!");

            RPC.iPrintln(client, "^1Youtube.com/E3Modz ^7- ^2Subscribe :)");
        }
        private void Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.TabControl1.SelectedTab = Stats;
            if (isAttached())
            {
                LoadStats();
                GrabClasses();
                ValueToString();
            }
            MessageBox.Show("You are not attached to BO3 STATS dosent load!");
        }

        private void Button11_Click(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            TabControl1.SelectedTab = IpSpoofer;
        }
        private int Call2(uint Address, params object[] MemoryParams)
        {
            int num = MemoryParams.Length;
            uint num2 = 0u;
            uint num3 = 0u;
            while ((ulong)num3 < (ulong)((long)num))
            {
                bool flag = MemoryParams[(int)num3] is int;
                if (flag)
                {
                    byte[] bytes = BitConverter.GetBytes((int)MemoryParams[(int)num3]);
                    Array.Reverse(bytes);
                    PS3.SetMemory(268763136u + (num3 + num2) * 4u, bytes);
                }
                else
                {
                    bool flag2 = MemoryParams[(int)num3] is uint;
                    if (flag2)
                    {
                        byte[] bytes2 = BitConverter.GetBytes((uint)MemoryParams[(int)num3]);
                        Array.Reverse(bytes2);
                        PS3.SetMemory(268763136u + (num3 + num2) * 4u, bytes2);
                    }
                    else
                    {
                        bool flag3 = MemoryParams[(int)num3] is string;
                        if (flag3)
                        {
                            byte[] bytes3 = Encoding.UTF8.GetBytes(Convert.ToString(MemoryParams[(int)num3]) + "\0");
                            PS3.SetMemory(268763220u + num3 * 1024u, bytes3);
                            uint value = 268763220u + num3 * 1024u;
                            byte[] bytes4 = BitConverter.GetBytes(value);
                            Array.Reverse(bytes4);
                            PS3.SetMemory(268763136u + (num3 + num2) * 4u, bytes4);
                        }
                        else
                        {
                            bool flag4 = MemoryParams[(int)num3] is float;
                            if (flag4)
                            {
                                num2 += 1u;
                                byte[] bytes5 = BitConverter.GetBytes((float)MemoryParams[(int)num3]);
                                Array.Reverse(bytes5);
                                PS3.SetMemory(268763172u + (num2 - 1u) * 4u, bytes5);
                            }
                        }
                    }
                }
                num3 += 1u;
            }
            byte[] bytes6 = BitConverter.GetBytes(Address);
            Array.Reverse(bytes6);
            PS3.SetMemory(268763212u, bytes6);
            Thread.Sleep(20);
            byte[] array = PS3.Extension.ReadBytes(268763216u, 4);
            Array.Reverse(array);
            return BitConverter.ToInt32(array, 0);
        }
        private void Stats_Click(object sender, EventArgs e)
        {

        }
        private void HenCMD(string Command)
        {
            this.Call2(5970556u, new object[]
            {
                0,
                Command + "\0"
            });
        }
        private void Button11_Click_1(object sender, EventArgs e)
        {
            if (hen == true)
            {
                this.HenCMD("StatSetByName PLEVEL " + Prestige.Text);
            }
            else
            {
                //Prestige offset 0x37EF8E45
                byte[] bytes = (BitConverter.GetBytes(Convert.ToInt32(Prestige.Text)));
                PS3.SetMemory(0x37EF8E45, bytes);
            }
        }

        private void Button45_Click(object sender, EventArgs e)
        {
            if (hen == true)
            {
                this.HenCMD("StatSetByName SCORE " + pointstxt.Text);
            }
            else
            {
                //Points offset 0x37EF8E87
                byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(pointstxt.Text));
                PS3.SetMemory(0x37EF8E87, bytes);
            }

        }

        private void Button47_Click(object sender, EventArgs e)
        {
            if (hen == true)
            {
                this.HenCMD("StatSetByName KILLS " + killstxt.Text);
            }
            else
            {
                //Kills offset 0x37EF86D1
                byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(killstxt.Text));
                PS3.SetMemory(0x37EF86D1, bytes);
            }
        }

        private void Button46_Click(object sender, EventArgs e)
        {
            if (hen == true)
            {
                this.HenCMD("StatSetByName DEATHS " + deathstxt.Text);
            }
            else
            {
                //Deaths offset 0x37EF828D
                byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(deathstxt.Text));
                PS3.SetMemory(0x37EF828D, bytes);
            }

        }

        private void Button49_Click(object sender, EventArgs e)
        {
            if (hen == true)
            {
                this.HenCMD("StatSetByName WINS " + winstxt.Text);
            }
            else
            {
                //Wins offset 0x37EF8FB3
                byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(winstxt.Text));
                PS3.SetMemory(0x37EF8FB3, bytes);
            }
        }

        private void Button48_Click(object sender, EventArgs e)
        {
            if (hen == true)
            {
                this.HenCMD("StatSetByName LOSSES " + loosestxt.Text);
            }
            else
            {
                //Losses offsets 0x37EF8FB0
                byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(loosestxt.Text));
                PS3.SetMemory(0x37EF8FB0, bytes);
            }

        }
        //GrabClass Method
        public void GrabClasses()
        {
            H.Text = PS3.Extension.ReadString(0x37F107B1);
            HH.Text = PS3.Extension.ReadString(0x37F107C1);
            HHH.Text = PS3.Extension.ReadString(0x37F107D1);
            HHHH.Text = PS3.Extension.ReadString(0x37F107E1);
            HHHHH.Text = PS3.Extension.ReadString(0x37F107F1);
            HHHHHH.Text = PS3.Extension.ReadString(0x37F10801);
            HHHHHHH.Text = PS3.Extension.ReadString(0x37F10811);
            HHHHHHHH.Text = PS3.Extension.ReadString(0x37F10821);
            HHHHHHHHH.Text = PS3.Extension.ReadString(0x37F10831);
            HHHHHHHHHH.Text = PS3.Extension.ReadString(0x37F10841);
        }
        //Class name method
        public void ClassName(int MyClassNum, string ClassName)
        {
            uint MyOffset = (0);

            //Set offset
            if (MyClassNum == 1) { MyOffset = (0x37F107B1); }
            if (MyClassNum == 2) { MyOffset = (0x37F107C1); }
            if (MyClassNum == 3) { MyOffset = (0x37F107D1); }
            if (MyClassNum == 4) { MyOffset = (0x37F107E1); }
            if (MyClassNum == 5) { MyOffset = (0x37F107F1); }
            if (MyClassNum == 6) { MyOffset = (0x37F10801); }
            if (MyClassNum == 7) { MyOffset = (0x37F10811); }
            if (MyClassNum == 8) { MyOffset = (0x37F10821); }
            if (MyClassNum == 9) { MyOffset = (0x37F10831); }
            if (MyClassNum == 10) { MyOffset = (0x37F10841); }

            //If the method was used correctly
            if (MyClassNum > 0 && MyClassNum < 11)
            {
                byte[] bytes = (Encoding.ASCII.GetBytes(ClassName + "\0"));
                PS3.SetMemory(MyOffset, bytes);
            }

            else
            {
                MessageBox.Show("There are only 10 classes, so you can not change class: \"" + MyClassNum + "\"", "Error");
            }
        }

        private void Button50_Click(object sender, EventArgs e)
        {
            string current = (string)clasnum.SelectedItem;
            if (clasnum.Text == "Class 1")
            {

                ClassName(1, klassnametxt.Text);
                GrabClasses();
            }
            else if (clasnum.Text == "Class 2")
            {
                ClassName(2, klassnametxt.Text);
                GrabClasses();
            }
            else if (clasnum.Text == "Class 3")
            {
                ClassName(3, klassnametxt.Text);
                GrabClasses();
            }
            else if (clasnum.Text == "Class 4")
            {
                ClassName(4, klassnametxt.Text);
                GrabClasses();
            }
            else if (clasnum.Text == "Class 5")
            {
                ClassName(5, klassnametxt.Text);
                GrabClasses();
            }
            else if (clasnum.Text == "Class 6")
            {
                ClassName(6, klassnametxt.Text);
                GrabClasses();
            }
            else if (clasnum.Text == "Class 7")
            {
                ClassName(7, klassnametxt.Text);
                GrabClasses();
            }
            else if (clasnum.Text == "Class 8")
            {
                ClassName(8, klassnametxt.Text);
                GrabClasses();
            }
            else if (clasnum.Text == "Class 9")
            {
                ClassName(9, klassnametxt.Text);
                GrabClasses();
            }
            else if (clasnum.Text == "Class 10")
            {
                ClassName(10, klassnametxt.Text);
                GrabClasses();
            }
        }
        private void Button51_Click(object sender, EventArgs e)
        {
            ClassName(1, klassnametxt.Text);
            ClassName(2, klassnametxt.Text);
            ClassName(3, klassnametxt.Text);
            ClassName(4, klassnametxt.Text);
            ClassName(5, klassnametxt.Text);
            ClassName(6, klassnametxt.Text);
            ClassName(7, klassnametxt.Text);
            ClassName(8, klassnametxt.Text);
            ClassName(9, klassnametxt.Text);
            ClassName(10, klassnametxt.Text);
            GrabClasses();
        }

        private void Clasnum_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Button124_Click(object sender, EventArgs e)
        {

            clasnum.DroppedDown = true;

        }
        private void Button52_Click(object sender, EventArgs e)
        {
            if (hen == true)
            {
                this.HenCMD("StatSetByName PLEVEL 55");
                this.HenCMD("StatSetByName LEVELXP 	1,457,200");
            }
            else
            {
                //Level offset 0x37EF8E65
                byte[] buffer = (new byte[] { 0, 1, 0, 0 });
                PS3.SetMemory(0x37EF8E65, buffer);
            }
        }

        private void Button53_Click(object sender, EventArgs e)
        {
            if (hen == true)
            {
                this.HenCMD("StatSetByName RANK 0");
                this.HenCMD("StatSetByName LEVELXP 0");
            }
            else
            {
                byte[] buffer = (new byte[] { 255, 255, 255, 255 });
                PS3.SetMemory(0x37EF8E65, buffer);
            }
        }

        private void Button58_Click(object sender, EventArgs e)
        {
            //Prestige offset 0x37EF8E45
            byte[] bytes = (BitConverter.GetBytes(Convert.ToInt32(Prestige.Text)));
            PS3.SetMemory(0x37EF8E45, bytes);
            //Points offset 0x37EF8E87
            byte[] bytes1 = BitConverter.GetBytes(Convert.ToInt32(pointstxt.Text));
            PS3.SetMemory(0x37EF8E87, bytes1);
            //Kills offset 0x37EF86D1
            byte[] bytes2 = BitConverter.GetBytes(Convert.ToInt32(killstxt.Text));
            PS3.SetMemory(0x37EF86D1, bytes2);
            //Deaths offset 0x37EF828D
            byte[] bytes3 = BitConverter.GetBytes(Convert.ToInt32(deathstxt.Text));
            PS3.SetMemory(0x37EF828D, bytes3);
            //Wins offset 0x37EF8FB3
            byte[] bytes4 = BitConverter.GetBytes(Convert.ToInt32(winstxt.Text));
            PS3.SetMemory(0x37EF8FB3, bytes4);
            //Losses offsets 0x37EF8FB0
            byte[] bytes5 = BitConverter.GetBytes(Convert.ToInt32(loosestxt.Text));
            PS3.SetMemory(0x37EF8FB0, bytes5);
        }
        private void resetstats()
        {
            MessageBox.Show("Please be patient this will take up to 2 minutes.", "Please Wait...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            byte[] buffer = new byte[] { 0x00 };
            PS3.SetMemory(0x37eec9f8, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37eec1c7 + 0x3ca1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3cc6, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3cea, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3cf0, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3cf5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3cfb, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3d01, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3d07, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3e91, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3eb6, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3eda, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3edf, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3ee6, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3eeb, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3ef1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3ef8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3f0d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3f32, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3f56, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3f5b, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3f62, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3f67, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3f6d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3f74, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3d99, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3dbe, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3de2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3de7, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3ded, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3df3, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3df9, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3dff, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3d1d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3d41, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3d66, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3d6c, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3d72, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3d78, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3d7e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3d84, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3e15, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3e39, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3e5d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3e63, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3e69, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3e6f, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3e75, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3e7b, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4179, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x419e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x41c2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x41c7, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x41cd, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x41d3, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x41d9, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x41df, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4369, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x438e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x43b1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x43b7, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x43bd, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x43c3, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x43c9, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x43cf, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4271, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x42ba, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x42c0, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x42c6, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x42cc, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x42d2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x42d8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4295, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x41f5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x421a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4243, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x423d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4249, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x424f, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4255, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x425b, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x42ed, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4312, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4335, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x433b, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4341, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4347, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x434d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4353, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4461, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4486, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x44a9, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x44af, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x44b5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x44bb, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x44c1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x44c7, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x43e5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x440a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x442d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4433, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4439, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x443f, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4445, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x444b, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x50f9, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5147, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5142, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x514e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5153, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5159, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x515f, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5165, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5175, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5199, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x51c3, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x51ca, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x51cf, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x51d5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x51db, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x51bd, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5001, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5026, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x504a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5050, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5056, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x505c, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5062, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5068, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x507d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x50c6, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x50cc, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x50d2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x50d8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x50de, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x50e4, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x50ea, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4749, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x476d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4792, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4798, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x479e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x47a4, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x47aa, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x47b0, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4651, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4675, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4699, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x46a0, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x46a6, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x46ac, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x46b2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x46b8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x47c5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x47e9, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x480d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4814, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x481a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4820, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4826, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x482c, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x46cd, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x46f1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4715, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x471c, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4722, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4728, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x472e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4734, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4ba5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4bed, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4bf4, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4bfa, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c00, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c06, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c0c, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c12, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4b29, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4b71, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4b77, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4b7e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4b83, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4b8a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4b8f, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4b96, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c9d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4ce5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4cec, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4cf2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4cf8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4cfe, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4d04, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4d0a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c21, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c69, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c70, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c75, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c7c, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c82, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c88, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c8e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3845, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3869, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x388d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3894, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3899, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x389f, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x38a6, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x38ab, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x38c1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x38e6, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3909, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3910, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3916, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x391c, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3921, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3928, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x393d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3961, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3986, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x398b, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3992, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3998, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x399e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x39a4, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x53e2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x542a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5430, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5436, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x543c, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5442, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5448, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x544e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x545e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x54a5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x54ab, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x54b1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x54b7, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x54be, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x54c3, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x54ca, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x67bd, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x67c3, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x6806, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x680c, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x6811, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x6817, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x681d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x6824, buffer);
            PS3.SetMemory(0x37ef299b, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef0357, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef03d3, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef7ff5, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef04cb, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef0547, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef05c3, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef063f, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37eefe7f, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37eefefb, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37eeff77, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37eefff3, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef006f, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef00eb, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef082f, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef08ab, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef0927, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef09a3, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef0d07, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef0d83, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef91df, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef0dff, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef11df, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef125b, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef12d7, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef1353, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37eefa23, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37eefa9f, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37eefb1b, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef15bf, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef163b, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37eec1c7 + 0xc539, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc53e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc544, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc54a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc550, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc556, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc55c, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc562, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc568, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc56e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc58c, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc5e1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc74f, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc76e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc791, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc797, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc7c6, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc80e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc815, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc856, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc862, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc868, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc8aa, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc8e1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc8e6, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc8fe, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc90a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc916, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc91d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc958, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc965, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc96a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc971, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc977, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc97d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc995, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc9a6, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc9c5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xca18, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xca1f, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xca2a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xca31, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xca36, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xca6d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xca8a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xca91, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xca96, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xca9d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcaa3, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcaa8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcaa9, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcaaf, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcab5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcacd, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcaf1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcb08, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcb15, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcb38, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcb3e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcb45, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcb5d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcb62, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcb7b, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcb98, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcb9e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcba5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcbaa, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcbb1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcbc2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcbd5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcbda, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcbe1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcbed, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcbf8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcc95, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xccc3, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcd01, buffer);
            byte[] buffer2 = new byte[] { 11 };
            PS3.SetMemory(0x37eec1c7 + 0xcd20, buffer2);
            PS3.SetMemory(0x37eec1c7 + 0xcd5a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcdae, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcdcd, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcdd8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcdf1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xce93, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcfe9, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xd0cd, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xd13f, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc011, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc03a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc041, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc047, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc04d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc053, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc088, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc0d1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc0e2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc0e8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc0ee, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc101, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc107, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc10d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc113, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc118, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc137, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc13d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc143, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc14e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc155, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc167, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc178, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc17e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc185, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc18a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc1c1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc1c7, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc1cd, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc1d2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc1d8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc1e5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc20e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc227, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc232, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc251, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc257, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2a5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2aa, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2b1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2b7, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2bd, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2c8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2ce, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2d5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2db, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2e1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2e7, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2ed, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2f2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2f8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2fe, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc305, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc30b, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc317, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc31d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc322, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc328, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc34d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc352, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc358, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc35e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc365, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc371, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc382, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc38e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc3a7, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc3b2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc3b8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc3bf, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc3c5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc3ca, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc3d1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc3d7, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc3dd, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc3e3, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc3e8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc3fa, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc401, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc407, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc40d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc412, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc418, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc41e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc425, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc42a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc431, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc436, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc44e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc455, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc461, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc467, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc472, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc478, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc47e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc49d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc4a2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc4a8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc4b5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc4cd, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc4e5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc4ea, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc50f, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc515, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc51a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc521, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc527, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc52d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc532, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc538, buffer);

            byte[] Level = (new byte[] { 255, 255, 255, 255 });
            PS3.SetMemory(0x37EF8E65, Level);

            byte[] XPBytes = BitConverter.GetBytes(0);
            PS3.SetMemory(0x37EF8E63, XPBytes);

            byte[] points = BitConverter.GetBytes(0);
            PS3.SetMemory(0x37EF8E87, points);

            byte[] kills = BitConverter.GetBytes(0);
            PS3.SetMemory(0x37EF86D1, kills);

            byte[] deaths = BitConverter.GetBytes(0);
            PS3.SetMemory(0x37EF828D, deaths);

            byte[] wins = BitConverter.GetBytes(0);
            PS3.SetMemory(0x37EF8FB3, wins);

            byte[] losses = BitConverter.GetBytes(0);
            PS3.SetMemory(0x37EF8FB0, losses);

            byte[] Tokens = new byte[] { 0 };
            PS3.SetMemory(0x37EF80F7, Tokens);

            MessageBox.Show("Stats Resettet!", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Button57_Click(object sender, EventArgs e)
        {
            resetstats();
        }


        private void Button54_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please be patient this will take up to 2 minutes.", "Please Wait...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            byte[] buffer = new byte[] { 0xff };
            PS3.SetMemory(0x37eec9f8, new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff });
            PS3.SetMemory(0x37eec1c7 + 0x3ca1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3cc6, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3cea, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3cf0, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3cf5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3cfb, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3d01, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3d07, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3e91, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3eb6, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3eda, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3edf, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3ee6, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3eeb, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3ef1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3ef8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3f0d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3f32, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3f56, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3f5b, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3f62, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3f67, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3f6d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3f74, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3d99, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3dbe, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3de2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3de7, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3ded, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3df3, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3df9, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3dff, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3d1d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3d41, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3d66, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3d6c, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3d72, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3d78, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3d7e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3d84, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3e15, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3e39, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3e5d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3e63, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3e69, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3e6f, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3e75, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3e7b, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4179, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x419e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x41c2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x41c7, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x41cd, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x41d3, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x41d9, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x41df, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4369, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x438e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x43b1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x43b7, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x43bd, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x43c3, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x43c9, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x43cf, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4271, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x42ba, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x42c0, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x42c6, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x42cc, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x42d2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x42d8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4295, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x41f5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x421a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4243, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x423d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4249, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x424f, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4255, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x425b, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x42ed, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4312, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4335, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x433b, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4341, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4347, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x434d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4353, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4461, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4486, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x44a9, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x44af, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x44b5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x44bb, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x44c1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x44c7, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x43e5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x440a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x442d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4433, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4439, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x443f, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4445, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x444b, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x50f9, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5147, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5142, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x514e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5153, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5159, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x515f, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5165, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5175, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5199, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x51c3, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x51ca, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x51cf, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x51d5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x51db, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x51bd, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5001, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5026, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x504a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5050, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5056, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x505c, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5062, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5068, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x507d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x50c6, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x50cc, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x50d2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x50d8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x50de, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x50e4, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x50ea, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4749, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x476d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4792, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4798, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x479e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x47a4, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x47aa, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x47b0, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4651, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4675, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4699, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x46a0, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x46a6, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x46ac, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x46b2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x46b8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x47c5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x47e9, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x480d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4814, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x481a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4820, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4826, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x482c, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x46cd, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x46f1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4715, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x471c, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4722, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4728, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x472e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4734, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4ba5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4bed, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4bf4, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4bfa, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c00, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c06, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c0c, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c12, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4b29, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4b71, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4b77, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4b7e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4b83, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4b8a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4b8f, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4b96, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c9d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4ce5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4cec, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4cf2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4cf8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4cfe, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4d04, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4d0a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c21, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c69, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c70, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c75, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c7c, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c82, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c88, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c8e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3845, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3869, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x388d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3894, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3899, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x389f, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x38a6, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x38ab, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x38c1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x38e6, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3909, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3910, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3916, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x391c, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3921, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3928, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x393d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3961, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3986, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x398b, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3992, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3998, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x399e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x39a4, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x53e2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x542a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5430, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5436, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x543c, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5442, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5448, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x544e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x545e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x54a5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x54ab, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x54b1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x54b7, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x54be, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x54c3, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x54ca, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x67bd, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x67c3, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x6806, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x680c, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x6811, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x6817, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x681d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x6824, buffer);
            PS3.SetMemory(0x37ef299b, new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff });
            PS3.SetMemory(0x37ef0357, new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff });
            PS3.SetMemory(0x37ef03d3, new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff });
            PS3.SetMemory(0x37ef7ff5, new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff });
            PS3.SetMemory(0x37ef04cb, new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff });
            PS3.SetMemory(0x37ef0547, new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff });
            PS3.SetMemory(0x37ef05c3, new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff });
            PS3.SetMemory(0x37ef063f, new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff });
            PS3.SetMemory(0x37eefe7f, new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff });
            PS3.SetMemory(0x37eefefb, new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff });
            PS3.SetMemory(0x37eeff77, new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff });
            PS3.SetMemory(0x37eefff3, new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff });
            PS3.SetMemory(0x37ef006f, new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff });
            PS3.SetMemory(0x37ef00eb, new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff });
            PS3.SetMemory(0x37ef082f, new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff });
            PS3.SetMemory(0x37ef08ab, new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff });
            PS3.SetMemory(0x37ef0927, new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff });
            PS3.SetMemory(0x37ef09a3, new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff });
            PS3.SetMemory(0x37ef0d07, new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff });
            PS3.SetMemory(0x37ef0d83, new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff });
            PS3.SetMemory(0x37ef91df, new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff });
            PS3.SetMemory(0x37ef0dff, new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff });
            PS3.SetMemory(0x37ef11df, new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff });
            PS3.SetMemory(0x37ef125b, new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff });
            PS3.SetMemory(0x37ef12d7, new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff });
            PS3.SetMemory(0x37ef1353, new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff });
            PS3.SetMemory(0x37eefa23, new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff });
            PS3.SetMemory(0x37eefa9f, new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff });
            PS3.SetMemory(0x37eefb1b, new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff });
            PS3.SetMemory(0x37ef15bf, new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff });
            PS3.SetMemory(0x37ef163b, new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff });
            PS3.SetMemory(0x37eec1c7 + 0xc539, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc53e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc544, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc54a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc550, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc556, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc55c, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc562, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc568, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc56e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc58c, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc5e1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc74f, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc76e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc791, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc797, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc7c6, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc80e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc815, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc856, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc862, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc868, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc8aa, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc8e1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc8e6, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc8fe, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc90a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc916, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc91d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc958, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc965, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc96a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc971, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc977, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc97d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc995, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc9a6, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc9c5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xca18, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xca1f, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xca2a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xca31, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xca36, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xca6d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xca8a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xca91, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xca96, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xca9d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcaa3, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcaa8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcaa9, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcaaf, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcab5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcacd, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcaf1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcb08, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcb15, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcb38, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcb3e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcb45, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcb5d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcb62, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcb7b, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcb98, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcb9e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcba5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcbaa, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcbb1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcbc2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcbd5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcbda, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcbe1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcbed, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcbf8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcc95, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xccc3, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcd01, buffer);
            byte[] buffer2 = new byte[] { 11 };
            PS3.SetMemory(0x37eec1c7 + 0xcd20, buffer2);
            PS3.SetMemory(0x37eec1c7 + 0xcd5a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcdae, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcdcd, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcdd8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcdf1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xce93, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcfe9, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xd0cd, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xd13f, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc011, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc03a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc041, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc047, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc04d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc053, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc088, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc0d1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc0e2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc0e8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc0ee, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc101, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc107, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc10d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc113, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc118, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc137, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc13d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc143, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc14e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc155, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc167, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc178, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc17e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc185, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc18a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc1c1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc1c7, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc1cd, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc1d2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc1d8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc1e5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc20e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc227, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc232, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc251, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc257, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2a5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2aa, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2b1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2b7, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2bd, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2c8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2ce, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2d5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2db, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2e1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2e7, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2ed, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2f2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2f8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2fe, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc305, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc30b, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc317, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc31d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc322, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc328, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc34d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc352, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc358, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc35e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc365, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc371, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc382, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc38e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc3a7, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc3b2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc3b8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc3bf, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc3c5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc3ca, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc3d1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc3d7, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc3dd, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc3e3, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc3e8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc3fa, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc401, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc407, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc40d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc412, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc418, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc41e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc425, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc42a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc431, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc436, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc44e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc455, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc461, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc467, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc472, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc478, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc47e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc49d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc4a2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc4a8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc4b5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc4cd, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc4e5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc4ea, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc50f, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc515, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc51a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc521, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc527, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc52d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc532, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc538, buffer);
            PS3.SetMemory(0x37EF8E65, new byte[] { 0, 1, 0, 0 });
            MessageBox.Show("Level 55 / Unlock All / Weapon Unlocks", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void resetStats2()
        {
            byte[] buffer = new byte[] { 0x00 };
            PS3.SetMemory(0x37eec9f8, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37eec1c7 + 0x3ca1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3cc6, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3cea, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3cf0, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3cf5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3cfb, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3d01, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3d07, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3e91, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3eb6, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3eda, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3edf, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3ee6, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3eeb, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3ef1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3ef8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3f0d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3f32, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3f56, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3f5b, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3f62, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3f67, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3f6d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3f74, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3d99, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3dbe, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3de2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3de7, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3ded, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3df3, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3df9, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3dff, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3d1d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3d41, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3d66, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3d6c, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3d72, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3d78, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3d7e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3d84, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3e15, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3e39, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3e5d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3e63, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3e69, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3e6f, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3e75, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3e7b, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4179, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x419e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x41c2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x41c7, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x41cd, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x41d3, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x41d9, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x41df, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4369, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x438e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x43b1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x43b7, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x43bd, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x43c3, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x43c9, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x43cf, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4271, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x42ba, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x42c0, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x42c6, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x42cc, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x42d2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x42d8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4295, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x41f5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x421a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4243, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x423d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4249, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x424f, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4255, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x425b, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x42ed, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4312, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4335, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x433b, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4341, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4347, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x434d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4353, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4461, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4486, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x44a9, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x44af, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x44b5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x44bb, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x44c1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x44c7, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x43e5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x440a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x442d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4433, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4439, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x443f, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4445, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x444b, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x50f9, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5147, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5142, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x514e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5153, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5159, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x515f, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5165, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5175, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5199, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x51c3, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x51ca, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x51cf, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x51d5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x51db, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x51bd, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5001, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5026, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x504a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5050, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5056, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x505c, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5062, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5068, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x507d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x50c6, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x50cc, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x50d2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x50d8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x50de, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x50e4, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x50ea, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4749, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x476d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4792, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4798, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x479e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x47a4, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x47aa, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x47b0, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4651, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4675, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4699, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x46a0, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x46a6, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x46ac, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x46b2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x46b8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x47c5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x47e9, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x480d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4814, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x481a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4820, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4826, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x482c, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x46cd, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x46f1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4715, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x471c, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4722, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4728, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x472e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4734, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4ba5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4bed, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4bf4, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4bfa, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c00, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c06, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c0c, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c12, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4b29, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4b71, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4b77, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4b7e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4b83, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4b8a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4b8f, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4b96, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c9d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4ce5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4cec, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4cf2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4cf8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4cfe, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4d04, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4d0a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c21, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c69, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c70, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c75, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c7c, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c82, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c88, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x4c8e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3845, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3869, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x388d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3894, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3899, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x389f, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x38a6, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x38ab, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x38c1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x38e6, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3909, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3910, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3916, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x391c, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3921, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3928, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x393d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3961, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3986, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x398b, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3992, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x3998, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x399e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x39a4, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x53e2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x542a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5430, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5436, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x543c, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5442, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x5448, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x544e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x545e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x54a5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x54ab, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x54b1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x54b7, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x54be, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x54c3, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x54ca, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x67bd, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x67c3, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x6806, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x680c, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x6811, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x6817, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x681d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0x6824, buffer);
            PS3.SetMemory(0x37ef299b, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef0357, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef03d3, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef7ff5, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef04cb, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef0547, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef05c3, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef063f, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37eefe7f, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37eefefb, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37eeff77, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37eefff3, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef006f, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef00eb, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef082f, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef08ab, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef0927, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef09a3, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef0d07, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef0d83, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef91df, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef0dff, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef11df, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef125b, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef12d7, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef1353, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37eefa23, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37eefa9f, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37eefb1b, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef15bf, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37ef163b, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory(0x37eec1c7 + 0xc539, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc53e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc544, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc54a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc550, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc556, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc55c, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc562, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc568, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc56e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc58c, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc5e1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc74f, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc76e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc791, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc797, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc7c6, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc80e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc815, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc856, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc862, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc868, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc8aa, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc8e1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc8e6, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc8fe, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc90a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc916, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc91d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc958, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc965, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc96a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc971, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc977, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc97d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc995, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc9a6, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc9c5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xca18, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xca1f, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xca2a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xca31, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xca36, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xca6d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xca8a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xca91, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xca96, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xca9d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcaa3, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcaa8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcaa9, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcaaf, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcab5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcacd, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcaf1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcb08, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcb15, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcb38, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcb3e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcb45, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcb5d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcb62, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcb7b, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcb98, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcb9e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcba5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcbaa, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcbb1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcbc2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcbd5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcbda, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcbe1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcbed, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcbf8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcc95, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xccc3, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcd01, buffer);
            byte[] buffer2 = new byte[] { 11 };
            PS3.SetMemory(0x37eec1c7 + 0xcd20, buffer2);
            PS3.SetMemory(0x37eec1c7 + 0xcd5a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcdae, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcdcd, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcdd8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcdf1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xce93, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xcfe9, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xd0cd, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xd13f, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc011, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc03a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc041, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc047, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc04d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc053, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc088, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc0d1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc0e2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc0e8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc0ee, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc101, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc107, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc10d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc113, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc118, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc137, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc13d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc143, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc14e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc155, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc167, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc178, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc17e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc185, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc18a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc1c1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc1c7, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc1cd, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc1d2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc1d8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc1e5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc20e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc227, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc232, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc251, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc257, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2a5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2aa, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2b1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2b7, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2bd, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2c8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2ce, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2d5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2db, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2e1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2e7, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2ed, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2f2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2f8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc2fe, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc305, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc30b, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc317, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc31d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc322, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc328, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc34d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc352, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc358, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc35e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc365, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc371, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc382, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc38e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc3a7, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc3b2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc3b8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc3bf, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc3c5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc3ca, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc3d1, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc3d7, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc3dd, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc3e3, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc3e8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc3fa, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc401, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc407, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc40d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc412, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc418, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc41e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc425, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc42a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc431, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc436, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc44e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc455, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc461, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc467, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc472, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc478, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc47e, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc49d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc4a2, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc4a8, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc4b5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc4cd, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc4e5, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc4ea, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc50f, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc515, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc51a, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc521, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc527, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc52d, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc532, buffer);
            PS3.SetMemory(0x37eec1c7 + 0xc538, buffer);

            byte[] Level = (new byte[] { 255, 255, 255, 255 });
            PS3.SetMemory(0x37EF8E65, Level);

            byte[] XPBytes = BitConverter.GetBytes(0);
            PS3.SetMemory(0x37EF8E63, XPBytes);

            byte[] points = BitConverter.GetBytes(0);
            PS3.SetMemory(0x37EF8E87, points);

            byte[] kills = BitConverter.GetBytes(0);
            PS3.SetMemory(0x37EF86D1, kills);

            byte[] deaths = BitConverter.GetBytes(0);
            PS3.SetMemory(0x37EF828D, deaths);

            byte[] wins = BitConverter.GetBytes(0);
            PS3.SetMemory(0x37EF8FB3, wins);

            byte[] losses = BitConverter.GetBytes(0);
            PS3.SetMemory(0x37EF8FB0, losses);

            byte[] Tokens = new byte[] { 0 };
            PS3.SetMemory(0x37EF80F7, Tokens);
        }
        private void LoadStats()
        {
            try
            {
                this.numericUpDown1.Value = PS6.Func.GetByte(Main.Offsets.Prestige);
                this.numericUpDown2.Value = PS6.Func.GetUInt32(Main.Offsets.Score, true);
                this.numericUpDown3.Value = PS6.Func.GetUInt32(Main.Offsets.Kills, true);
                this.numericUpDown4.Value = PS6.Func.GetUInt32(Main.Offsets.Deaths, true);
                this.numericUpDown5.Value = PS6.Func.GetUInt32(Main.Offsets.Wins, true);
                this.numericUpDown6.Value = PS6.Func.GetUInt32(Main.Offsets.Losses, true);

            }
            catch
            {
                if (MessageBox.Show("Your Stats is So High\nYou want to reset Stats??", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    resetstats();
                }
                else
                {

                }
            }
        }
        private void Button55_Click(object sender, EventArgs e)
        {
            this.Prestige.Text = "10";
            this.pointstxt.Text = "62543722";
            this.killstxt.Text = "21340";
            this.deathstxt.Text = "5634";
            this.winstxt.Text = "9300";
            this.loosestxt.Text = "5064";
        }
        public static class Offsets
        {
            public static uint Deaths = 0x37EF828D;
            public static uint Kills = 0x37EF86D1;
            public static uint Losses = 0x37EF8FB0;
            public static uint Prestige = 0x37EF8E45;
            public static uint Score = 0x37EF8E87;
            public static uint Tokens = 31786u;
            public static uint Wins = 0x37EF8FB3;
        }
        private void ValueToString()
        {
            this.Prestige.Text = numericUpDown1.Value.ToString();
            this.pointstxt.Text = numericUpDown2.Value.ToString();
            this.killstxt.Text = numericUpDown3.Value.ToString();
            this.deathstxt.Text = numericUpDown4.Value.ToString();
            this.winstxt.Text = numericUpDown5.Value.ToString();
            this.loosestxt.Text = numericUpDown6.Value.ToString();
        }
        private void Button56_Click(object sender, EventArgs e)
        {
            LoadStats();
            ValueToString();
        }

        private void Button268_Click(object sender, EventArgs e)
        {
            classnamepre.DroppedDown = true;
        }

        private void Classnamepre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (classnamepre.Text == "Vortex RTM Tool")
            {
                ClassName(1, "^1Vortex^2RTM");
                ClassName(2, "^5ModdedClasses");
                ClassName(3, "^2UsingVortex");
                ClassName(4, "^2Using");
                ClassName(5, "Vortex^2RTM");
                ClassName(6, "^1Developed by");
                ClassName(7, "^1E3^2MoDz");
                ClassName(8, "V^2ort^3ex^5RTM");
                ClassName(9, "^1En^4gine");
                ClassName(10, "^2Injected");
                GrabClasses();
            }
            else if (classnamepre.Text == "Modded 1")
            {
                ClassName(1, "^1@@@@@@@");
                ClassName(2, "^5@Hacked@@");
                ClassName(3, "^2Using ^1VortexRTM");
                ClassName(4, "^2#####@");
                ClassName(5, "^1§§§§§§§");
                ClassName(6, "^2&&&&&&&");
                ClassName(7, "^(/()Z&§");
                ClassName(8, "V^2ort^3ex^5RTM");
                ClassName(9, "^1§§§§§§§");
                ClassName(10, "^3§§erwrrw+**");
                GrabClasses();
            }
            else
            {
                MessageBox.Show("Comming SooN!");
            }
        }

        private void Killstxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Deathstxt_TextChanged(object sender, EventArgs e)
        {
            double num1, num2, sum;
            num1 = double.Parse(killstxt.Text);
            num2 = double.Parse(deathstxt.Text);
            sum = num1 / num2;
            label45.Text = Convert.ToString(sum);
            if (System.Text.RegularExpressions.Regex.IsMatch(deathstxt.Text, "[^0-9]"))
            {
                deathstxt.Text = deathstxt.Text.Remove(deathstxt.Text.Length - 1);
            }
        }

        private void Loosestxt_TextChanged(object sender, EventArgs e)
        {
            double num1, num2, sum;
            num1 = double.Parse(winstxt.Text);
            num2 = double.Parse(loosestxt.Text);
            sum = num1 / num2;
            label44.Text = Convert.ToString(sum);
            if (System.Text.RegularExpressions.Regex.IsMatch(loosestxt.Text, "[^0-9]"))
            {
                loosestxt.Text = loosestxt.Text.Remove(loosestxt.Text.Length - 1);
            }
        }

        private void Winstxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button59_Click(object sender, EventArgs e)
        {

            decimal d = Convert.ToDecimal(19346708);
            Class10.smethod_3(-1, string.Concat(new object[]
            {
                    "i ",
                    d / 4m,
                    " ",
                    Convert.ToDecimal(8085041)
            }));
            decimal d2 = Convert.ToDecimal(19346712);
            Class10.smethod_3(-1, string.Concat(new object[]
            {
                    "i ",
                    d2 / 4m,
                    " ",
                    Convert.ToDecimal(2097152000)
            }));
            decimal d3 = Convert.ToDecimal(19346332);
            Class10.smethod_3(-1, string.Concat(new object[]
            {
                    "i ",
                    d3 / 4m,
                    " ",
                    Convert.ToDecimal(0)
            }));
            decimal d4 = Convert.ToDecimal(19346336);
            Class10.smethod_3(-1, string.Concat(new object[]
            {
                    "i ",
                    d4 / 4m,
                    " ",
                    Convert.ToDecimal(0)
            }));
            decimal d5 = Convert.ToDecimal(19346304);
            Class10.smethod_3(-1, string.Concat(new object[]
            {
                    "i ",
                    d5 / 4m,
                    " ",
                    Convert.ToDecimal(0)
            }));
            Class10.smethod_7(-1, "^5You have been: ^1Deranked!");
            return;
        }

        private void AGiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.RPC_Enabled)
            {
                MessageBox.Show("You must enable RPC in order to use this command!", "Black Ops 3: Remote Procedure Call");
                return;
            }

            if (this.RPC_Enabled)
            {
                selected_client = (Convert.ToUInt16(dataGridView1.CurrentRow.Index));
                decimal d6 = Convert.ToDecimal(19346708);
                Class10.smethod_3((int)this.selected_client, string.Concat(new object[]
                {
                "i ",
                d6 / 4m,
                " ",
                Convert.ToDecimal(8085041)
                }));
                decimal d7 = Convert.ToDecimal(19346712);
                Class10.smethod_3((int)this.selected_client, string.Concat(new object[]
                {
                "i ",
                d7 / 4m,
                " ",
                Convert.ToDecimal(2097152000)
                }));
                decimal d8 = Convert.ToDecimal(19346332);
                Class10.smethod_3((int)this.selected_client, string.Concat(new object[]
                {
                "i ",
                d8 / 4m,
                " ",
                Convert.ToDecimal(0)
                }));
                decimal d9 = Convert.ToDecimal(19346336);
                Class10.smethod_3((int)this.selected_client, string.Concat(new object[]
                {
                "i ",
                d9 / 4m,
                " ",
                Convert.ToDecimal(0)
                }));
                decimal d10 = Convert.ToDecimal(19346304);
                Class10.smethod_3((int)this.selected_client, string.Concat(new object[]
                {
                "i ",
                d10 / 4m,
                " ",
                Convert.ToDecimal(0)
                }));
                RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "^1You have been Deranked!");
                RPC.iPrintlnBold(this.dataGridView1.CurrentRow.Index, "^1You have been Deranked!");
            }
        }
        private void DerankToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void UnlimitedAmmoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void GiveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            selected_client = (Convert.ToUInt16(dataGridView1.CurrentRow.Index * 0x350));
            string[] array = new string[]
            {
                "# MP_PRESTIGE10",
                "# MP_ALLCAREER",
                "# MP_ALLGAMEMODE",
                "# MP_ALLBOOTCAMP",
                "# MP_ALLSPECIALISTS",
                "# MP_PRESTIGE1",
                "# MP_COMMANDER",
                "# MP_10MULTIKILL",
                "# MP_10MEDALS",
                "# MP_LEVEL10"
            };
            if (this.RPC_Enabled)
            {
                Class10.smethod_7(-1, "^6Unlocking Multiplayer achivements.");
                foreach (string object_ in array)
                {
                    Class10.smethod_3(-1, object_);
                    Thread.Sleep(25);
                    Class10.smethod_3(-1, object_);
                }
                return;
            }
            Class10.smethod_7((int)this.selected_client, "^6Unlocking Multiplayer achivements.");
            foreach (string object_2 in array)
            {
                Class10.smethod_3((int)this.selected_client, object_2);
                Thread.Sleep(25);
                Class10.smethod_3((int)this.selected_client, object_2);
            }
        }

        private void RankHimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.RPC_Enabled)
            {
                MessageBox.Show("You must enable RPC in order to use this command!", "Black Ops 3: Remote Procedure Call");
                return;
            }
            selected_client = (Convert.ToUInt16(dataGridView1.CurrentRow.Index));
            if (this.RPC_Enabled)
            {
                decimal d = Convert.ToDecimal(19346708);
                Class10.smethod_3((int)this.selected_client, string.Concat(new object[]
                {
                    "i ",
                    d / 4m,
                    " ",
                    Convert.ToDecimal(6177374)
                }));
                decimal d2 = Convert.ToDecimal(19346712);
                Class10.smethod_3((int)this.selected_client, string.Concat(new object[]
                {
                    "i ",
                    d2 / 4m,
                    " ",
                    Convert.ToDecimal(0)
                }));
                decimal d3 = Convert.ToDecimal(19346332);
                Class10.smethod_3((int)this.selected_client, string.Concat(new object[]
                {
                    "i ",
                    d3 / 4m,
                    " ",
                    Convert.ToDecimal(960051513)
                }));
                decimal d4 = Convert.ToDecimal(19346336);
                Class10.smethod_3((int)this.selected_client, string.Concat(new object[]
                {
                    "i ",
                    d4 / 4m,
                    " ",
                    Convert.ToDecimal(960051513)
                }));
                decimal d5 = Convert.ToDecimal(19346304);
                Class10.smethod_3((int)this.selected_client, string.Concat(new object[]
                {
                    "i ",
                    d5 / 4m,
                    " ",
                    Convert.ToDecimal(720896)
                }));
                RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "^2You have been given ^5Prestige Master + ^2Level 55");
                RPC.iPrintlnBold(this.dataGridView1.CurrentRow.Index, "^2You have been given ^5Prestige Master + ^2Level 55");
                return;
            }
            decimal d6 = Convert.ToDecimal(19346708);
            Class10.smethod_3((int)this.selected_client, string.Concat(new object[]
            {
                "i ",
                d6 / 4m,
                " ",
                Convert.ToDecimal(6177374)
            }));
            decimal d7 = Convert.ToDecimal(19346712);
            Class10.smethod_3((int)this.selected_client, string.Concat(new object[]
            {
                "i ",
                d7 / 4m,
                " ",
                Convert.ToDecimal(0)
            }));
            decimal d8 = Convert.ToDecimal(19346332);
            Class10.smethod_3((int)this.selected_client, string.Concat(new object[]
            {
                "i ",
                d8 / 4m,
                " ",
                Convert.ToDecimal(960051513)
            }));
            decimal d9 = Convert.ToDecimal(19346336);
            Class10.smethod_3((int)this.selected_client, string.Concat(new object[]
            {
                "i ",
                d9 / 4m,
                " ",
                Convert.ToDecimal(960051513)
            }));
            decimal d10 = Convert.ToDecimal(19346304);
            Class10.smethod_3((int)this.selected_client, string.Concat(new object[]
            {
                "i ",
                d10 / 4m,
                " ",
                Convert.ToDecimal(720896)
            }));
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "^2You have been given ^5Prestige Master + ^2Level 55");
            RPC.iPrintlnBold(this.dataGridView1.CurrentRow.Index, "^2You have been given ^5Prestige Master + ^2Level 55");
        }

        private void FreezeHimToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button60_Click(object sender, EventArgs e)
        {
        }

        private void Button61_Click(object sender, EventArgs e)
        {

        }

        private void Button65_Click(object sender, EventArgs e)
        {

        }

        private void Button61_Click_1(object sender, EventArgs e)
        {

        }
        private void Nop(uint Addr)
        {
            byte[] array = new byte[4];
            array[0] = 96;
            PS3.SetMemory(Addr, array);
        }
        private void Patches()
        {

            this.Nop(8143176u);
            this.Nop(8142928u);
            this.Nop(8144728u);
            this.Nop(8144480u);
            this.Nop(5599324u);
            this.Nop(5599484u);
            this.Nop(4901312u);
            this.Nop(4893984u);
            this.Nop(6363316u);
            uint addy = 6491724u;
            byte[] array = new byte[4];
            array[0] = 56;
            array[1] = 96;
            PS3.SetMemory(addy, array);
            this.Nop(6491684u);
            label115.Text = "Enabled!";
            label115.ForeColor = Color.Green;

        }


        private void Button60_Click_1(object sender, EventArgs e)
        {
            PS3.ChangeAPI(SelectAPI.PS3Manager);
            if (!PS3M_API.AttachProcess(PS3M_API.Process.Processes_Pid[this.comboBox1.SelectedIndex]))
            {
                MessageBox.Show("Impossible to attach :(", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                PS3M_API.DisconnectTarget();
            }
            hen = true;
            PS3M_API.PS3.Notify("Successfully Attached");
            PS6.Attach();
            label20.Refresh();
            RPC.Init();

            label14.Text = E3modz.CCAPI.GetTemperatureCELL();
            label15.Text = E3modz.CCAPI.GetTemperatureRSX();
            label16.Text = E3modz.CCAPI.GetFirmwareVersion();
            PS3.SetMemory(0xCC5A8, new byte[] { 0x2c, 0x14, 0x00, 0x01 });
            PS3.Extension.WriteString(0x00A544E8, "\n\n\n\n\n\n\n\n\n\n^5Vortex^2RTM");
            label17.Text = E3modz.CCAPI.GetFirmwareType();
            Patches();
            label20.Text = "Attached";
            RPC_Enabled = true;
            label12.Text = PS3.Extension.ReadString(0x01F2CE45);
            label13.Text = "Enabled";
            label19.Text = "Connected + Attached!";
            label19.ForeColor = Color.Green;
            MessageBox.Show("Attached!", "Succesfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Thread.Sleep(100);
            label20.Text = "Attached Sucessfully!";
            E3modz.CCAPI.RingBuzzer(CCAPI.BuzzerMode.Double);
            E3modz.CCAPI.Notify(CCAPI.NotifyIcon.FINGER, "Attached with E3Modz Tool, Have Fun! :D");
        }

        private void Button62_Click(object sender, EventArgs e)
        {


        }

        private void SpecialistMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void forceHostBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        private void Button59_Click_1(object sender, EventArgs e)
        {

        }

        private void ForceHostBackgroundWorker_DoWork_1(object sender, DoWorkEventArgs e)
        {
            RPC.CBuf_Addtext("set lobbyTimerStartInterval 10;");
            RPC.CBuf_Addtext("set LobbySearchSkip 1;");
            RPC.CBuf_Addtext("set lobbyTimerStatusVotingInterval 10;");
            RPC.CBuf_Addtext("set party_minPlayers 1;");

            while (forceHostLoopOn)
            {
                //Thread.Sleep(5000);
                RPC.CBuf_Addtext("set lobbyTimerStartInterval 10;");
                RPC.CBuf_Addtext("set LobbySearchSkip 1;");
                RPC.CBuf_Addtext("set lobbyTimerStatusVotingInterval 10;");
                RPC.CBuf_Addtext("set party_minPlayers 1;");
            }

            RPC.CBuf_Addtext("reset lobbyTimerStartInterval;");
            RPC.CBuf_Addtext("reset LobbySearchSkip;");
            RPC.CBuf_Addtext("reset lobbyTimerStatusVotingInterval;");
            RPC.CBuf_Addtext("reset party_minPlayers;");
        }
        public void ChangeClantag(string InputText)
        {
            byte[] bytes = (Encoding.ASCII.GetBytes(InputText + "\0"));
            PS3.SetMemory(0x37EF8FD9, bytes);
        }
        private void Button29_Click(object sender, EventArgs e)
        {

            ChangeClantag(textBox3.Text);
        }

        private void GiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3Freeze(dataGridView1.CurrentCell.RowIndex);
        }

        private void Button63_Click(object sender, EventArgs e)
        {
            if (!ipGrabberBackgroundWorker.IsBusy)
                ipGrabberBackgroundWorker.RunWorkerAsync();
            canGrab = true;
        }



        private void Button64_Click(object sender, EventArgs e)
        {

        }

        private void DerankToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        //////////////////////////////////
        ///Ip Grabber by: Mayhem Modding///
        ////////////////////////////////////
        ///
        bool canGrab = false;
        bool loadInfo = false;
        List<string> addName = new List<string>();
        List<string> addPublicIp = new List<string>();
        List<string> addPort = new List<string>();
        List<string> addLocalIp = new List<string>();
        uint startOfs = 0x020bb927;

        private static string convertIp(byte[] ip)
        {
            return string.Format("{0}.{1}.{2}.{3}", ip[0], ip[1], ip[2], ip[3]);
        }

        private static string convertPort(byte[] ip)
        {
            return string.Format("{0}{1}{2}", ip[0], ip[1], ip[2]);
        }

        public static List<int> IndexOfSequence(byte[] buffer, byte[] pattern, int startIndex)
        {
            List<int> positions = new List<int>();
            int i = Array.IndexOf<byte>(buffer, pattern[0], startIndex);
            while (i >= 0 && i <= buffer.Length - pattern.Length)
            {
                byte[] segment = new byte[pattern.Length];
                Buffer.BlockCopy(buffer, i, segment, 0, pattern.Length);
                if (segment.SequenceEqual<byte>(pattern))
                    positions.Add(i);
                i = Array.IndexOf<byte>(buffer, pattern[0], i + pattern.Length);
            }
            return positions;
        }
        private void grabInfo()
        {
            if (canGrab)
            {
                canGrab = false;
                int[] nameResults = IndexOfSequence(PS3.Extension.ReadBytes(startOfs, 20000), new byte[] { 0x00, 0x24 }, 0).ToArray();
                addName.Clear();
                addPublicIp.Clear();
                addPort.Clear();
                addLocalIp.Clear();
                for (int i = 0; i < nameResults.Length; i++)
                {
                    addName.Add(PS3.Extension.ReadString(startOfs + 2 + (uint)nameResults[i]));
                    addPublicIp.Add(convertIp(PS3.Extension.ReadBytes(startOfs + (uint)nameResults[i] - 0x1E, 4)));
                    addPort.Add(convertPort(PS3.Extension.ReadBytes(startOfs + (uint)nameResults[i] - 0x1A, 3)));
                    addLocalIp.Add(convertIp(PS3.Extension.ReadBytes(startOfs + (uint)nameResults[i] - 0x3C, 4)));
                }
                loadInfo = true;
            }
        }
        private void IpGrabberBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            PS3.ConnectTarget(0);
            while (0 == 0)
            {
                grabInfo();
            }
        }

        private void GrabIPsTimer_Tick(object sender, EventArgs e)
        {
            if (loadInfo)
            {
                loadInfo = false;
                if (addName.Count == addPublicIp.Count && addName.Count == addPort.Count && addName.Count == addLocalIp.Count)
                    try
                    {
                        ipGrabberDataGridView.Rows.Clear();
                        for (int i = 0; i < addName.Count; i++)
                            ipGrabberDataGridView.Rows.Add(addName[i], addPublicIp[i], addPort[i], addLocalIp[i]);
                    }

                    catch
                    {

                    }
            }
        }

        private void Button408_Click(object sender, EventArgs e)
        {
            connectbox.DroppedDown = true;
        }

        private void Connectbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connectbox.Text == "E3Modz")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("E3Modz");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Enstone")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("^3Enstone");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Sony")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("^2Gay^1Sony");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Treyarch")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("^2T^1rey^5arch");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Black Ops 2")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("^2Black ^1Ops^5 2");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Unlockall Free")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("^2Unlockall ^1FREE");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Unlockall not Free!")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Unlockall not Free!");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Kid shut up")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("^2Kid ^1shut up");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "French ")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("^3French ");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "America ")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("^1Am^2erica");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Brasil ")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("^3Brasil ");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "German ")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("^3German ");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Austria")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("^1Aus^7tr^1ia");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "PS3")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("^2PS3");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "HDMI Kabel ")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("^2HDMI Kabel ");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "RGB ")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("^1R^6G^3B ");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Modded PS3 ")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("^2Modded PS3 ");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "DEX ")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("^1DEX ");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "CEX")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("^2CEX");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "HAN ")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("H^3AN ");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Han = Gay ")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Han = Gay ");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Target Manager ")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Target Manager ");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Control Console ")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Control Console ");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "PS4")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("^3PS4");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "LUUUL ")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("LUUUL ");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Fuck You ")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Fuck ^2You ");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "E3Modz ")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("^1E3^2Modz ");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Trooool ")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Tro^2oool ");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Marcelscorpion")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Marcelscorpion");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Visca_Barca")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Visca_Barca");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Visca96Barca")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Visca96Barca");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "MontanaBlack88 ")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("MontanaBlack88 ");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Faze_Rain ")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Faze_Rain ");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Faze_Pamaj")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Faze_Pamaj");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Faze_Clan ")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Faze_Clan ");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Faze ")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Faze ");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "PewDiePie")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("PewDiePie");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Ninja ")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Ninja ");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Dex_CFW")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Dex_CFW");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Kiwi_Modz ")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Kiwi_Modz ");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "BassHaxor")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("BassHaxor");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Exill")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Exill");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Smoky_Mods")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Smoky_Mods");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "E3Modz ")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("E3Modz ");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Nuketown ")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Nuketown ");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Standoff")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Standoff");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Express")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Express");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Carrier")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Carrier");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Raid ")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Raid ");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Aftermath")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Aftermath");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Cargo")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Cargo");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Drone")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Drone");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Hijacked")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Hijacked");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Meltdown")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Meltdown");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Plaza")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Plaza");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Slums")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Slums");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Turbine")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Turbine");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Yemen ")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Yemen ");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Iphone")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Iphone");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Samsung ")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Samsung ");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Redbull ")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Redbull ");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "AkiiiNator")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("AkiiiNator");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Saskia ")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Saskia");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "GermanGirl ")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("GermanGirl ");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Webman ")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Webman ");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "Exploit ")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("Exploit ");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "VortexRTM ")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("VortexRTM ");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
            else if (connectbox.Text == "DontTryHard")
            {
                byte[] bytes = Encoding.ASCII.GetBytes("DontTryHard");
                Array.Resize<byte>(ref bytes, bytes.Length + 1);
                PS3.SetMemory(0x1f3cff4, bytes);
                PS3.SetMemory(0x20dfe78, bytes);
                byte[] byE3Modz = new byte[] { 0x60, 0x00, 0x00, 0x00 }; PS3.SetMemory(0x52DFC0, byE3Modz);
            }
        }

        private void Button89_Click(object sender, EventArgs e)
        {
            comboBox3.DroppedDown = true;
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "PS3")
            {
                ChangeClantag("PS3");
            }
            else if (comboBox3.Text == "PS4")
            {
                ChangeClantag("PS4");
            }
            else if (comboBox3.Text == "MoDz")
            {
                ChangeClantag("MoDz");
            }
            else if (comboBox3.Text == "<3")
            {
                ChangeClantag("<3");
            }
            else if (comboBox3.Text == "RTM")
            {
                ChangeClantag("^5RTM");
            }
            else if (comboBox3.Text == "Ua")
            {
                ChangeClantag("^2Ua");
            }
            else if (comboBox3.Text == "BO2")
            {
                ChangeClantag("BO2");
            }
            else if (comboBox3.Text == "BOII")
            {
                ChangeClantag("BOII");
            }
            else if (comboBox3.Text == "BO3")
            {
                ChangeClantag("BO3");
            }
            else if (comboBox3.Text == "iMP")
            {
                ChangeClantag("iMP");
            }
            else if (comboBox3.Text == "Faze")
            {
                ChangeClantag("Faze");
            }
            else if (comboBox3.Text == "CheckBox")
            {
                ChangeClantag("^Hac");
            }
            else if (comboBox3.Text == "Modded")
            {
                int flashColor = (new Random().Next(0, 7));
                ChangeClantag("{^" + flashColor + "}");
            }
        }

        private void Button102_Click(object sender, EventArgs e)
        {
            PS3.Extension.WriteString(0x1f3cff4, this.textBox1.Text + "\u0010\u0001\u0001" + this.textBox1.Text + "\u0006holo_9\0");
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            byte[] bytes = (Encoding.ASCII.GetBytes(label12.Text + "\0"));
            PS3.SetMemory(0x1f3cff4, bytes);
            byte[] buffer = (Encoding.ASCII.GetBytes(label12.Text + "\0"));
            PS3.SetMemory(0x20dfe78, buffer);
        }
        public void ChangePlayercard(string InputText)
        {
            byte[] bytes = (Encoding.ASCII.GetBytes(InputText + "\0"));
            PS3.SetMemory(0x1F2CE45, bytes);
        }
        private void Button67_Click(object sender, EventArgs e)
        {
            ChangePlayercard(textBox3.Text);
        }

        private void ClientList_Click(object sender, EventArgs e)
        {


        }
        bool isInGame = true;
        private void AntiOn()
        {
            dump = PS3.Extension.ReadBytes(CoDAddy, ByteLength);
            Thread.Sleep(200);
            for (int i = 0; i < dump.Length; i++)
            {
                try
                {
                    if (dump[i + 1] == 0x6E && dump[i + 2] == 0x64 && dump[i + 3] == 0x72 && dump[i + 4] == 0x6F && dump[i + 5] == 0x75 && dump[i + 6] == 0x6E && dump[i + 7] == 0x64)
                    {
                        Thread.Sleep(200);
                        PS3.SetMemory(CoDAddy + (uint)i, new byte[] { 0x00 });
                        saveInt = i;
                        isInGame = false;
                        Found = true;
                        break;
                    }
                }
                catch
                {
                    MessageBox.Show("Could not find address", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Button20_Click_1(object sender, EventArgs e)
        {
            CoDAddy = BO3addy;
            AntiOn();
        }

        private void Button21_Click_1(object sender, EventArgs e)
        {
            CoDAddy = BO3addy;
            AntiOn();
        }

        private void Button20_Click_2(object sender, EventArgs e)
        {

        }

        private void Button68_Click(object sender, EventArgs e)
        {

        }

        private void EnableToolStripMenuItem3_Click(object sender, EventArgs e)
        {

            PS3.SetMemory((uint)(0x018C6220 + 0x20C + dataGridView1.CurrentRow.Index * 0x350), new byte[] { 5 });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Godmode ^2Enabled");
        }

        private void Button40_Click_1(object sender, EventArgs e)
        {
            RPC.CBuf_Addtext("gts timelimit 0");
        }

        private void RankV2ULTIMATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecoverClient(dataGridView1.CurrentCell.RowIndex);
        }
        uint[] TypewriterElem = new uint[12];
        uint gameTime()
        {
            return PS3.Extension.ReadUInt32(0x1781E80 + 0x98C);
        }

        uint HudElem_Alloc(int client, int team)
        {
            uint g_hudelem = 0x01770708;
            for (uint i = 0; i < 1023; i++)
            {
                if (PS3.Extension.ReadByte(g_hudelem + (i * 0x88) + 0x70) == 0)
                {
                    PS3.Extension.WriteByte(g_hudelem + (i * 0x88) + 0x70, 1);
                    PS3.Extension.WriteInt32(g_hudelem + (i * 0x88) + 0x7C, client);
                    PS3.Extension.WriteInt32(g_hudelem + (i * 0x88) + 0x80, team);

                    return (g_hudelem + (i * 0x88));
                }
            }
            return 0;
        }

        void SetPoint(uint elem, byte align, byte relative, float x, float y)
        {
            PS3.Extension.WriteByte(elem + 0x72, align);
            PS3.Extension.WriteByte(elem + 0x73, relative);
            Main.WriteFloatArray(elem, new float[2] { x, y });
        }

        void SetColor(uint elem, byte[] color)
        {
            if (color.Length <= 4)
            {
                PS3.SetMemory(elem + 0x18, color);
            }
        }

        void SetCOD7DecodeFX(uint elem, ushort fxLetterTime, ushort fxDecayStartTime, ushort fxDecayDuration, float time)
        {
            PS3.Extension.WriteUInt32(elem + 0x48, gameTime());
            PS3.Extension.WriteUInt32(elem + 0x4C, 0x800);
            PS3.Extension.WriteUInt16(elem + 0x66, fxLetterTime);
            PS3.Extension.WriteUInt16(elem + 0x68, fxDecayStartTime);
            PS3.Extension.WriteUInt16(elem + 0x6a, fxDecayDuration);
        }


        void SetText(uint elem, string text)
        {
            ushort texts = (ushort)RPC.Call(0x0038E4EC, new object[] { text, 1 });
            PS3.Extension.WriteUInt16(elem + 0x64, texts);
        }
        void SetType(uint elem, byte type)
        {
            PS3.Extension.WriteByte(elem + 0x70, type);
        }

        void SetTextSize(uint elem, float size)
        {
            PS3.Extension.WriteFloat(elem + 0xC, size);
        }
        void TypewriterTest2(string text)
        {
            for (uint i = 0; i < 12; i++)
            {
                if (TypewriterElem[i] != 0)
                {
                    PS3.SetMemory(TypewriterElem[i], new byte[0x84]);
                }
            }
            for (uint i = 0; i < 12; i++)
            {
                TypewriterElem[i] = HudElem_Alloc((int)i, 0);
                SetColor(TypewriterElem[i], new byte[] { 0xFF, 0xFF, 0xFF, 0xFF });
                SetText(TypewriterElem[i], text);
                SetPoint(TypewriterElem[i], 0, 0, /*(float)xPosText.Value*/-30, /*(float)yPosText.Value*/160);
                SetType(TypewriterElem[i], 1);
                SetTextSize(TypewriterElem[i], 3.0F);
            }
        }
        void TypewriterTest(string text)
        {
            for (uint i = 0; i < 12; i++)
            {
                if (TypewriterElem[i] != 0)
                {
                    PS3.SetMemory(TypewriterElem[i], new byte[0x84]);
                }
            }
            for (uint i = 0; i < 12; i++)
            {
                TypewriterElem[i] = HudElem_Alloc((int)i, 0);
                SetColor(TypewriterElem[i], new byte[] { 0xFF, 0xFF, 0xFF, 0xFF });
                SetText(TypewriterElem[i], text);
                SetPoint(TypewriterElem[i], 0, 0, /*(float)xPosText.Value*/-30, /*(float)yPosText.Value*/160);
                SetType(TypewriterElem[i], 1);
                SetTextSize(TypewriterElem[i], 3.0F);    //Time
                SetCOD7DecodeFX(TypewriterElem[i], 100, 2000, 500, 0.5F);
            }
        }
        private void Button20_Click_3(object sender, EventArgs e)
        {
            TypewriterTest2(textBox6.Text);
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_MouseEnter(object sender, EventArgs e)
        {

        }

        private void TextBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                for (uint i = 0; i < 12; i++)
                {
                    SetText(doHeartText[i], textBox6.Text);
                }
            }
        }
        public static float[] ReadFloatArray(uint addr, int length)
        {
            float[] numArray = new float[length];
            for (int index = 0; index < length; ++index)
            {
                byte[] memory = PS5.GetMemory(addr + (uint)(index * 4), 4);
                Array.Reverse((Array)memory);
                numArray[index] = BitConverter.ToSingle(memory, 0);
            }
            return numArray;
        }
        public static void WriteFloatArray(uint Offset, float[] Array)
        {
            byte[] bytes = new byte[Array.Length * 4];
            for (int index = 0; index < Array.Length; ++index)
                PS3API.ReverseBytes(BitConverter.GetBytes(Array[index])).CopyTo((Array)bytes, index * 4);
            PS3.SetMemory(Offset, bytes);
        }

        private void Button68_Click_1(object sender, EventArgs e)
        {
            TypewriterTest(textBox6.Text);
        }

        private void Button69_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Center screen")
            {
                RPC.iPrintlnBold(-1, textBox7.Text);
            }
            else if (comboBox2.Text == "Kill feed")
            {
                RPC.iPrintln(-1, textBox7.Text);
            }
        }

        private void Button70_Click(object sender, EventArgs e)
        {
            RPC.CBuf_Addtext("gts scorelimit 0");
        }
        void ChangeFontScaleOverTime(uint elem, float time, float scale)
        {
            PS3.Extension.WriteUInt32(elem + 0x14, gameTime());
            PS3.Extension.WriteFloat(elem + 0x10, PS3.Extension.ReadFloat(elem + 0xC));
            PS3.Extension.WriteFloat(elem + 0xC, scale);
            PS3.Extension.WriteUInt16(elem + 0x52, (ushort)(time * 1000 + 0.5));
        }
        private void Button41_Click(object sender, EventArgs e)
        {
            if (button41.Text == "Anti Quit OFF")
            {
                RPC.iPrintln(-1, "Anti-Quit: ^2Enabled");
                PS3.Extension.WriteUInt32(0x01781E80 + 0x5564, 0x00000800);
                button41.Text = "Anti Quit ON";
            }
            else if (button41.Text == "Anti Quit ON")
            {
                RPC.iPrintln(-1, "Anti-Quit: ^1Disabled");
                button41.Text = "Anti Quit OFF";
                PS3.Extension.WriteUInt32(0x01781E80 + 0x5564, 0x00000410);
            }
        }

        uint[] doHeartText = new uint[12];
        bool switchme;

        private void DoHeart_Tick(object sender, EventArgs e)
        {
            switchme = !switchme;
            for (uint i = 0; i < 12; i++)
            {
                if (doHeartText[i] == 0)
                {

                    doHeartText[i] = HudElem_Alloc((int)i, 0);
                    SetText(doHeartText[i], textBox6.Text);
                    SetPoint(doHeartText[i], 0, 0, 0, 0);
                    SetType(doHeartText[i], 1);
                    SetColor(doHeartText[i], new byte[] { 0xFF, 0xFF, 0xFF, 0xFF });
                }
                ChangeFontScaleOverTime(doHeartText[i], 1.5F, switchme ? 1.0F : 3.0F);
            }
        }

        private void Button71_Click(object sender, EventArgs e)
        {
            if (button71.Text == "Do Heart OFF")
            {

                DoHeart.Start();
                button71.Text = "Do Heart ON";

            }
            else if (button71.Text == "Do Heart ON")
            {
                DoHeart.Stop();
                button71.Text = "Do Heart OFF";

            }
        }

        private void GiveModdedNameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RedNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redModdedName(dataGridView1.CurrentCell.RowIndex);
        }

        private void GreenNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GreenModdedName(dataGridView1.CurrentCell.RowIndex);
        }

        private void DarkBlueNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DarkBlueModdedName(dataGridView1.CurrentCell.RowIndex);
        }

        private void YellowNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YellowBlueModdedName(dataGridView1.CurrentCell.RowIndex);
        }

        private void CyanNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CyanBlueModdedName(dataGridView1.CurrentCell.RowIndex);
        }

        private void BlackNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BlackModdedName(dataGridView1.CurrentCell.RowIndex);
        }

        private void PinkNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PINKModdedName(dataGridView1.CurrentCell.RowIndex);
        }

        private void Give255WeaponTokenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GiveToken(dataGridView1.CurrentCell.RowIndex);
        }

        private void Give10ClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classes(dataGridView1.CurrentCell.RowIndex);
        }

        private void GivePrestige1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            Rank55(dataGridView1.CurrentCell.RowIndex);
        }

        private void GroupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void Button117_Click(object sender, EventArgs e)
        {
            string BO3DERANKbyE3Modz = "callvote map \"mp_stronghold;statsetbyname RANKXP 1;statsetbyname PLEVEL 0;statsetbyname RANK 1;\"";
            RPC.Call(0x001DF4F0, 0, BO3DERANKbyE3Modz.Replace(';', '\x0D'));
            Thread.Sleep(1000);
            RPC.CBuf_Addtext("disconnect\n");
        }

        private void Button118_Click(object sender, EventArgs e)
        {
            string BO3DERANKbyE3Modz = "callvote map \"mp_stronghold;statsetbyname RANKXP 99999;statsetbyname PLEVEL 11;statsetbyname RANK 54;\"";
            RPC.Call(0x001DF4F0, 0, BO3DERANKbyE3Modz.Replace(';', '\x0D'));
            Thread.Sleep(1000);
            RPC.CBuf_Addtext("disconnect\n");
        }

        private void Button119_Click(object sender, EventArgs e)
        {

        }

        private void Button120_Click(object sender, EventArgs e)
        {
            string BO3DERANKbyE3Modz = "callvote map \"mp_stronghold;statsetbyname RANKXP 9999999999999999;statsetbyname PLEVEL 9999999999999999;statsetbyname RANK 9999999999999999;\"";
            RPC.Call(0x001DF4F0, 0, BO3DERANKbyE3Modz.Replace(';', '\x0D'));
            Thread.Sleep(1000);
            RPC.CBuf_Addtext("disconnect\n");
        }
        float[] AnglesToForward(float[] Origin, float[] Angles, uint diff)
        {
            float num = ((float)Math.Sin((Angles[0] * Math.PI) / 180)) * diff;
            float num1 = (float)Math.Sqrt(((diff * diff) - (num * num)));
            float num2 = ((float)Math.Sin((Angles[1] * Math.PI) / 180)) * num1;
            float num3 = ((float)Math.Cos((Angles[1] * Math.PI) / 180)) * num1;
            return new float[] { Origin[0] + num3, Origin[1] + num2, Origin[2] - num };
        }
        private void v2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        int bNoclip;
        private void timer2_Tick(object sender, EventArgs e)
        {
            bNoclip = dataGridView1.CurrentCell.RowIndex;
            for (int i = 0; i < 12; i++)
            {

                if (PS3.Extension.ReadUInt32((uint)(0x018CBF4C + (0x6200 * i))) == 0x00020000)
                {
                    PS3.SetMemory((uint)(0x018CC224 + (0x6200 * i)), new byte[] { 0x00, 0x00, 0x00, 0x10 });
                    float[] Origin = PS5.Extension.ReadFloatArray((uint)(0x017FF638 + (0x350 * i)), 3);
                    float[] Angle = PS5.Extension.ReadFloatArray((uint)(0x017FF658 + (0x350 * i)), 3);
                    PS5.Extension.WriteFloatArray((uint)(0x018C6250 + (0x6200 * i)), AnglesToForward(Origin, Angle, 20));
                }
                else
                {
                    PS3.SetMemory((uint)(0x018CC224 + (0x6200 * i)), new byte[] { 0x00, 0x00, 0x00, 0x00 });
                }
            }
        }

        private void button78_Click(object sender, EventArgs e)
        {
            RPC.CBuf_Addtext("gts timelimit " + textBox10.Text);
        }

        private void button74_Click(object sender, EventArgs e)
        {
            RPC.CBuf_Addtext("gts scorelimit " + textBox11.Text);
        }

        private void button75_Click(object sender, EventArgs e)
        {
            RPC.CBuf_Addtext("gts defuseTime " + textBox12.Text);
        }

        private void button76_Click(object sender, EventArgs e)
        {
            RPC.CBuf_Addtext("gts silentPlant " + textBox13.Text);

        }

        private void button83_Click(object sender, EventArgs e)
        {
            RPC.CBuf_Addtext("playerRespawnDelay " + textBox19.Text);
        }

        private void button82_Click(object sender, EventArgs e)
        {
            RPC.CBuf_Addtext("spawnsuicidepenalty " + textBox18.Text);
        }

        private void button81_Click(object sender, EventArgs e)
        {
            RPC.CBuf_Addtext("roundScoreLimit " + textBox17.Text);
        }

        private void button80_Click(object sender, EventArgs e)
        {
            RPC.CBuf_Addtext("playerRespawnDelay " + textBox16.Text);
        }

        private void button79_Click(object sender, EventArgs e)
        {
            RPC.CBuf_Addtext("playerMaxHealth " + textBox15.Text);
        }

        private void button84_Click(object sender, EventArgs e)
        {
            RPC.CBuf_Addtext("g_speed " + textBox20.Text);
            RPC.iPrintlnBold(-1, "Speed set to: ^2" + textBox20.Text);
        }

        private void button85_Click(object sender, EventArgs e)
        {

            PS3.Extension.WriteString(0x300AC7EE, textBox21.Text);

        }

        private void button86_Click(object sender, EventArgs e)
        {

            PS3.Extension.WriteString(0x300B6A1D, textBox22.Text);

        }

        private void button87_Click(object sender, EventArgs e)
        {

            PS3.Extension.WriteString(0x300ACB10, textBox23.Text);

        }

        private void button91_Click(object sender, EventArgs e)
        {
            PS3.Extension.WriteString(0x300DD118, textBox26.Text);

        }

        private void button90_Click(object sender, EventArgs e)
        {

            PS3.Extension.WriteString(0x300EB068, textBox25.Text);

        }

        private void button88_Click(object sender, EventArgs e)
        {

            PS3.Extension.WriteString(0x300DE1CB, textBox24.Text);
        }

        private void button94_Click(object sender, EventArgs e)
        {

            PS3.Extension.WriteString(0x3010661E, textBox29.Text);
        }

        private void button93_Click(object sender, EventArgs e)
        {

            PS3.Extension.WriteString(0x300EB012, textBox28.Text);

        }

        private void button92_Click(object sender, EventArgs e)
        {

            PS3.Extension.WriteString(0x300EB068, textBox27.Text);

        }

        private void enableToolStripMenuItem3_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox10.Text == "mp_apartments")
            {
                string MapChange = "callvote map \"mp_stronghold;\"";
                RPC.Call(0x001DF4F0, 0, MapChange.Replace(';', '\x0D'));
                Thread.Sleep(1000);

            }
        }

        private void button95_Click(object sender, EventArgs e)
        {
            RPC.CBuf_Addtext("disconnect\n");
        }

        private void button72_Click(object sender, EventArgs e)
        {
            string DRNKDBO2 = "callvote map \"quit\n;statsetbyname RANKXP 0;statsetbyname PLEVEL 0;statsetbyname RANK 0;\"";
            RPC.Call(0x001DF4F0, 0, DRNKDBO2.Replace(';', '\x0D'));
            Thread.Sleep(1000);
            RPC.CBuf_Addtext("disconnect\n");
        }

        private void button121_Click(object sender, EventArgs e)
        {
            MessageBox.Show("With this Method you can Derank and Rank the Host! ex: You play a 1vs1 with a Player and he is Host you can Derank him!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button97_Click(object sender, EventArgs e)
        {
            if (button97.Text == "Super Jump OFF")
            {
                button97.Text = "Super Jump ON";
                PS3.Extension.WriteUInt16(0x01781E80 + 0x5598, 700);
                RPC.iPrintlnBold(-1, "Super Jump: ^2Enabled");
            }
            else if (button97.Text == "Super Jump ON")
            {
                PS3.Extension.WriteUInt16(0x01781E80 + 0x5598, 60);
                RPC.iPrintlnBold(-1, "Super Jump: ^1Disabled");
            }
        }

        private void button98_Click(object sender, EventArgs e)
        {

        }

        private void heyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "^5Hey");
        }

        private void dontKillMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "^1Dont Kill me!");
        }

        private void iDerankedYouBitchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "^1I Deranked you Bitch!");
        }

        private void iHaveGiveYouPrestigeMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "^2I gived you Presitge Master!");
        }

        private void projectVortexIsTheBestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "^2Project Vortex is the best RTM TOOL!");
        }

        private void e3MoDzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "^1Developed by E3Modz");
        }

        private void button100_Click(object sender, EventArgs e)
        {

        }

        float[] GetOrigin(uint client)
        {
            return Main.ReadFloatArray(0x018C6220 + (client * 0x6200) + 0x30, 3);
        }

        void SetOrigin(uint client, float[] origin)
        {
            Main.WriteFloatArray(0x018C6220 + (client * 0x6200) + 0x30, origin);
        }

        int Scr_LocalPlayer()
        {
            return PS3.Extension.ReadInt32(PS3.Extension.ReadUInt32(0x00F57BF4));
        }
        private void toMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetOrigin((uint)dataGridView1.CurrentCell.RowIndex, GetOrigin((uint)Scr_LocalPlayer()));
            RPC.iPrintln(dataGridView1.CurrentCell.RowIndex, string.Format("{0} Summoned You", PS3.Extension.ReadString(PS3.Extension.ReadUInt32(0x00F57BF8) + 0x64)));
        }

        private void toHimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetOrigin((uint)dataGridView1.CurrentCell.RowIndex, GetOrigin((uint)Scr_LocalPlayer()));
            RPC.iPrintln(dataGridView1.CurrentCell.RowIndex, string.Format("{0} Summoned You", PS3.Extension.ReadString(PS3.Extension.ReadUInt32(0x00F57BF8) + 0x64)));
        }

        private void giveScorestreaksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Scorestreaks ^2Enabled");
        }

        private void button99_Click(object sender, EventArgs e)
        {
            RPC.CBuf_Addtext("g_speed " + "230");
            RPC.iPrintlnBold(-1, "Speed ^1OFF");
        }

        private void button100_Click_1(object sender, EventArgs e)
        {
            if (button100.Text == "Disable WallRun OFF")
            {
                Dvar_SetBool(0x02D1181C, 0);
                button100.Text = "Disable WallRun ON";
                RPC.iPrintlnBold(-1, "WallRun now  ^1Disabled");
            }
            else if (button100.Text == "Disable WallRun ON")
            {
                Dvar_SetBool(0x02D1181C, 1);
                button100.Text = "Disable WallRun OFF";
                RPC.iPrintlnBold(-1, "WallRun now  ^2Enabled");
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void Lobby_Click(object sender, EventArgs e)
        {

        }
        public static void PS3Frezze(uint Client)
        {
            PS3.SetMemory((uint)(0x110a500 + (Client * 0x350)), new byte[] { 0x00, 0xe5, 0xd0 });
            PS3.SetMemory((uint)(0x110a506 + (Client * 0x350)), new byte[] { 0x00, 0xe5, 0xd0 });
            PS3.SetMemory((uint)(0x110a520 + (Client * 0x350)), new byte[] { 0xdf, 0xe5, 0xd0, 0xd0 });
            PS3.SetMemory((uint)(0x110a528 + (Client * 0x350)), new byte[] { 0xdf, 0xe5, 0xd0, 0xd0 });
        }
        private void giveToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void enabledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(G_Client + 0x5 + dataGridView1.CurrentRow.Index * 0x350), new byte[2] { 0xFF, 0xFF });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Movment: ^1Frozzen");
        }

        private void IpGrabber_Click(object sender, EventArgs e)
        {

        }

        private void button96_Click(object sender, EventArgs e)
        {
            comboBox10.DroppedDown = true;
        }

        private void button162_Click(object sender, EventArgs e)
        {
            string BO3DERANKbyE3Modz = "callvote map \"mp_biodome;statsetbyname RANKXP 1,457,200;statsetbyname PLEVEL " + prestigetxt + ";statsetbyname RANK 55;\"";
            RPC.Call(0x001DF4F0, 0, BO3DERANKbyE3Modz.Replace(';', '\x0D'));
            Thread.Sleep(1000);
            RPC.CBuf_Addtext("disconnect\n");
        }

        private void button103_Click(object sender, EventArgs e)
        {

        }

        private void kN44ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x383 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 0x01 });
            RPC.iPrintln(dataGridView1.CurrentRow.Index, "Default Weapon ^2Given");
        }

        private void button104_Click(object sender, EventArgs e)
        {
            RPC.CBuf_Addtext("cmd loadside 5 5 5 5;");
            Thread.Sleep(1200);
            RPC.CBuf_Addtext("disconnect\n");
        }
        void Dvar_SetBool(uint dvarPtr, byte value)
        {
            PS3.Extension.WriteByte(PS3.Extension.ReadUInt32(dvarPtr) + 0x8, value);
        }
        private void button101_Click(object sender, EventArgs e)
        {
            if (button101.Text == "Unlimited Boost OFF")
            {
                Dvar_SetBool(0x02D11814, 0);
                button101.Text = "Unlimited Boost ON";
                RPC.iPrintlnBold(-1, "Unlimited Boost ^2Enabled");
            }
            else if (button101.Text == "Unlimited Boost ON")
            {
                Dvar_SetBool(0x02D11814, 1);
                button101.Text = "Unlimited Boost OFF";
                RPC.iPrintlnBold(-1, "Unlimited Boost ^1Disabled");
            }
        }
        uint GetEntity(int i)
        {
            return (0x017FF620 + (0x350 * (uint)i));
        }
        void G_SetOrigin(uint ent, float[] origin)
        {
            Main.WriteFloatArray(ent + 0x18, origin);
            Main.WriteFloatArray(ent + 0x198, origin);
            Main.WriteFloatArray(ent + 0x1A4, origin);
        }
        private void button105_Click(object sender, EventArgs e)
        {
            if (button105.Text == "Disable Death Barrier OFF")
            {
                for (uint i = 0; i < 2047; i++)
                {
                    ushort trigger_hurt = PS3.Extension.ReadUInt16(0x1978D68 + 0x248);
                    if (PS3.Extension.ReadUInt16(0x017FF620 + (0x350 * i) + 0x1EE) == trigger_hurt)
                    {
                        G_SetOrigin(GetEntity((int)i), new float[] { 0, 0, -99999999 });

                    }
                    button105.Text = "Disable Death Barrier ON";


                }
                RPC.iPrintlnBold(-1, "^2Death Barrier: Disabled Jump out of the Map!");
                button105.Text = "Disable Death Barrier ON";
            }
            else if (button105.Text == "Disable Death Barrier ON")
            {

                button105.Text = "Disable Death Barrier OFF";
            }
        }

        private void button106_Click(object sender, EventArgs e)
        {
            RPC.CBuf_Addtext("");
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (hencon.Length == 0)
            {
                MessageBox.Show("Please Add first a Console on Hen Console Manager!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                label7.Text = "HEN";
            }
        }
        private void saveCommandsDEV()
        {

            bool flag3 = this.saveFileDialog1.ShowDialog() == DialogResult.OK;
            if (flag3)
            {

                string filename = saveFileDialog1.FileName;
                //This line of code creates a text file for the data export.
                System.IO.StreamWriter file = new System.IO.StreamWriter(Path.GetFullPath(saveFileDialog1.FileName));

                try
                {
                    string sLine = "";

                    //This for loop loops through each row in the table
                    for (int r = 0; r <= DEV.Rows.Count - 1; r++)
                    {
                        //This for loop loops through each column, and the row number
                        //is passed from the for loop above.
                        for (int c = 0; c <= DEV.Columns.Count - 1; c++)
                        {
                            sLine = sLine + DEV.Rows[r].Cells[c].Value;
                            if (c != DEV.Columns.Count - 1)
                            {
                                //A comma is added as a text delimiter in order
                                //to separate each field in the text file.
                                //You can choose another character as a delimiter.
                                sLine = sLine + "|";
                            }
                        }

                        file.WriteLine(sLine);

                        sLine = "";
                    }

                    file.Close();

                }
                catch (System.Exception err)
                {
                    System.Windows.Forms.MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    file.Close();
                }
            }
        }
        private void button60_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show(hencon);
        }

        private void button60_Click_3(object sender, EventArgs e)
        {



            TabControl1.SelectedTab = tabPage1;

        }
        private void ConnectToConsole()
        {
            if (PS3M_API.ConnectTarget(this.ps3Ip, 7887))
            {
                uint[] pidProcesses = PS3M_API.Process.GetPidProcesses();
                uint num = 0u;
                while ((ulong)num < (ulong)((long)pidProcesses.Length))
                {
                    if (PS3M_API.Process.GetName(pidProcesses[(int)num]).ToLower().Contains("default") || PS3M_API.Process.GetName(pidProcesses[(int)num]).ToLower().Contains("eboot"))
                    {
                        PS3M_API.Process.Process_Pid = pidProcesses[(int)num];
                        if (PS3M_API.AttachProcess(PS3M_API.Process.Process_Pid))
                        {
                            Thread.Sleep(500);
                            FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create("ftp://" + this.ps3Ip + "/dev_hdd0/tmp/RetroClient.sprx");
                            ftpWebRequest.Method = "STOR";
                            ftpWebRequest.Credentials = new NetworkCredential("", this.ps3Ip);
                            byte[] array = new WebClient().DownloadData("https://dayz.planb-life.com/ModMenus/RetroClient.sprx");
                            ftpWebRequest.ContentLength = (long)array.Length;
                            using (Stream requestStream = ftpWebRequest.GetRequestStream())
                            {
                                requestStream.Write(array, 0, array.Length);
                            }
                            using (FtpWebResponse ftpWebResponse = (FtpWebResponse)ftpWebRequest.GetResponse())
                            {
                                Console.WriteLine("Upload File Complete, status " + ftpWebResponse.StatusDescription);
                                MessageBox.Show("Connected And Attached!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                        }
                    }
                    num += 1u;
                }
            }
        }
        private void button61_Click_2(object sender, EventArgs e)
        {

        }

        private void button62_Click_1(object sender, EventArgs e)
        {

        }

        private void IpSpoofer_Click(object sender, EventArgs e)
        {

        }

        private void button65_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox11_Enter(object sender, EventArgs e)
        {

        }
        private void button61_Click_3(object sender, EventArgs e)
        {

            RPC.SV_SendServerCommand(CLIENT, textBox30.Text);
        }

        private void button62_Click_2(object sender, EventArgs e)
        {

            RPC.SV_GameSendServerCommand(CLIENT, textBox31.Text);
        }

        private void button107_Click(object sender, EventArgs e)
        {
            RPC.CBuf_Addtext(textBox32.Text);
        }
        private void saveCommands()
        {
            TextWriter writer = new StreamWriter(@"C:\Desktop\DEV.txt");
            for (int i = 0; i < DEV.Rows.Count - 1; i++)
            {
                for (int j = 0; j < DEV.Columns.Count; j++)
                {
                    writer.Write("\t" + DEV.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                }
                writer.WriteLine("");
                writer.WriteLine("---------------------------------------------------");
            }
            writer.Close();
            MessageBox.Show("Hat geklappt!");
        }


        private void button110_Click(object sender, EventArgs e)
        {
            //listView1.Items.Add("\n" + textBox30.Text);
            if (textBox30.Text == "")
            {
                MessageBox.Show("No Command to save!");
                this.textBox30.Focus();
            }
            else
            {

                string Column5 = "SV_SendServerCommand";
                string Column6 = textBox30.Text;

                string[] row = { Column5, Column6 };
                DEV.Rows.Add(row);




                textBox30.Focus();

                textBox30.Clear();
            }
        }

        private void removeFromListToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                int selectedIndex = DEV.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {
                    DEV.Rows.RemoveAt(selectedIndex);
                    DEV.Refresh(); // if needed
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Unable to remove selected row at this time");
            }
        }

        private void button108_Click(object sender, EventArgs e)
        {
            saveCommandsDEV();
        }

        private void DEV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button109_Click(object sender, EventArgs e)
        {
            DEV.Rows.Clear();
            DEV.Refresh();
        }

        private void button113_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            bool flag3 = this.openFileDialog1.ShowDialog() == DialogResult.OK;
            if (flag3)
            {
                string filename = openFileDialog1.FileName;
                using (var streamReader = new StreamReader(filename))
                {
                    while (!streamReader.EndOfStream)
                    {
                        var line = streamReader.ReadLine();
                        var values = line.Split('|');
                        var rowIndex = DEV.Rows.Add();
                        for (int i = 0; i < values.Length; i++)
                        {
                            DEV.Rows[rowIndex].Cells[i].Value = values[i];
                        }
                    }
                }
            }
        }

        private void Nopping(uint Addr)
        {
            byte[] array = new byte[4];
            array[0] = 96;
            PS3.SetMemory(Addr, array);
        }
        private void button115_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textBox33.Text);
            PS3.SetMemory((G_Client + 0x383 + (uint)0 * 0x6200), bytes);

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }
        private void aimbot()
        {
            void FairAimbot()
            {
                byte[] buffer = new byte[0xFF];
                PS3.BlockMemory(0x90DAFF, buffer);
                byte[] array = new byte[0x64];
                PS3.SetMemory(G_Client + G_Client_Size, array);

            }
        }
        private void button114_Click(object sender, EventArgs e)
        {
            uint Offset = 0x1D0000DF;
            uint Offset2 = 0x1D0000DF;
            uint Offset3 = 0x1833200;
            this.Nopping(Offset);
            this.Nopping(Offset2);
            this.Nopping(Offset3);
        }

        private void button116_Click(object sender, EventArgs e)
        {
            uint Offset = 0x4E88A0U;
            uint Offset2 = 0x904E88;
            uint Offset3 = 0x8A78D0;
            this.Nopping(Offset);
            this.Nopping(Offset2);
            this.Nopping(Offset3);
        }

        private void button122_Click(object sender, EventArgs e)
        {
            uint Offset = 0x3C23D7;
            uint Offset2 = 0x3C23050;
            uint Offset3 = 0x44;
            this.Nopping(Offset);
            this.Nopping(Offset2);
            this.Nopping(Offset3);
        }

        private void button123_Click(object sender, EventArgs e)
        {
            uint Offset = 0xA076C;
            uint Offset2 = 0x20004;
            uint Offset3 = 0x5080AF;
            this.Nopping(Offset);
            this.Nopping(Offset2);
            this.Nopping(Offset3);
        }

        private void button125_Click(object sender, EventArgs e)
        {
            byte[] array = new byte[4];
            array[0] = 62;
            PS3.SetMemory(0x90AFF, array);
            MessageBox.Show("All Zombies was killed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button126_Click(object sender, EventArgs e)
        {
            byte[] array = new byte[0xFF];
            array[0] = 62;
            PS3.SetMemory(0x90AFF, array);
            MessageBox.Show("More Zombies Spawned!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button127_Click(object sender, EventArgs e)
        {

        }

        private void button129_Click(object sender, EventArgs e)
        {

        }

        private void button65_Click_2(object sender, EventArgs e)
        {

        }

        private void button103_Click_1(object sender, EventArgs e)
        {
            if (button103.Text == "OFF")
            {
                button132.PerformClick();
                button134.PerformClick();
                button138.PerformClick();
                button144.PerformClick();
                button103.Text = "ON";
                button103.ForeColor = Color.Green;
            }
            else if (button103.Text == "ON")
            {
                button132.PerformClick();
                button134.PerformClick();
                button138.PerformClick();
                button144.PerformClick();
                button103.Text = "OFF";
                button103.ForeColor = Color.Red;
            }
        }

        private void button132_Click(object sender, EventArgs e)
        {
            if (button132.Text == "OFF")
            {
                button132.Text = "ON";
                button132.ForeColor = Color.Green;
                PS3.Extension.WriteBytes(0x58DF48, new byte[] { 0x60, 0x00, 0x00, 0x00 });
                PS3.Extension.WriteBytes(0x58DF10, new byte[] { 0x60, 0x00, 0x00, 0x00 });
            }
            else if (button132.Text == "ON")
            {
                button132.ForeColor = Color.Red;
                PS3.Extension.WriteBytes(0x58DF48, new byte[] { 0x41, 0x82, 0x01, 0xD4 });
                PS3.Extension.WriteBytes(0x58DF10, new byte[] { 0x41, 0x82, 0x02, 0x0C });
                button132.Text = "OFF";
            }
        }

        private void button134_Click(object sender, EventArgs e)
        {
            if (button134.Text == "OFF")
            {
                button134.Text = "ON";
                button134.ForeColor = Color.Green;
                PS3.Extension.WriteBytes(0xC8998, new byte[] { 0x60, 0x00, 0x00, 0x00 });
            }
            else if (button134.Text == "ON")
            {
                button134.ForeColor = Color.Red;
                PS3.Extension.WriteBytes(0xC8998, new byte[] { 0x41, 0x82, 0x00, 0xAC });
                button134.Text = "OFF";
            }
        }

        private void button136_Click(object sender, EventArgs e)
        {
            if (button136.Text == "OFF")
            {
                button136.Text = "ON";
                button136.ForeColor = Color.Green;
                PS3.Extension.WriteBytes(0xC8998, new byte[] { 0x60, 0x00, 0x00, 0x00 });

            }
            else if (button136.Text == "ON")
            {
                button136.ForeColor = Color.Red;
                PS3.Extension.WriteBytes(0xC8998, new byte[] { 0x41, 0x82, 0x00, 0xAC });
                button136.Text = "OFF";
            }
        }

        private void button138_Click(object sender, EventArgs e)
        {
            if (button138.Text == "OFF")
            {
                button138.Text = "ON";
                button138.ForeColor = Color.Green;
                PS3.Extension.WriteBytes(0x1908E8, new byte[] { 0x60, 0x00, 0x00, 0x00 });
            }
            else if (button138.Text == "ON")
            {
                PS3.Extension.WriteBytes(0x1908E8, new byte[] { 0x48, 0x5F, 0x75, 0x31 });
                button138.Text = "OFF";
                button138.ForeColor = Color.Red;
            }
        }

        private void button140_Click(object sender, EventArgs e)
        {

            if (button140.Text == "OFF")
            {
                button140.Text = "ON";
                button140.ForeColor = Color.Green;
                PS3.Extension.WriteBytes(0x76A174, new byte[] { 0x2C, 0x04, 0x00, 0x00 });
            }
            else if (button140.Text == "ON")
            {
                PS3.Extension.WriteBytes(0x76A174, new byte[] { 0x2C, 0x04, 0x00, 0x02 });
                button140.Text = "OFF";
                button140.ForeColor = Color.Red;
            }
        }

        private void button142_Click(object sender, EventArgs e)
        {
            if (button142.Text == "OFF")
            {
                button142.Text = "ON";
                button142.ForeColor = Color.Green;
                PS3.Extension.WriteBytes(0xCC5A8, new byte[] { 0x2C, 0x14, 0x00, 0x01 });
            }
            else if (button142.Text == "ON")
            {
                PS3.Extension.WriteBytes(0xCC5A8, new byte[] { 0x2C, 0x14, 0x00, 0x00 });
                button142.ForeColor = Color.Red;
                button142.Text = "OFF";
            }
        }

        private void button144_Click(object sender, EventArgs e)
        {
            if (button144.Text == "OFF")
            {
                button144.Text = "ON";
                button144.ForeColor = Color.Green;
                PS3.Extension.WriteBytes(0x76A174, new byte[] { 0x2C, 0x14, 0x00, 0x01 });
            }
            else if (button144.Text == "ON")
            {
                PS3.Extension.WriteBytes(0x76A174, new byte[] { 0x2C, 0x04, 0x00, 0x02 });
                button144.ForeColor = Color.Red;
                button144.Text = "OFF";
            }
        }

        private void button111_Click(object sender, EventArgs e)
        {
            if (textBox31.Text == "")
            {
                MessageBox.Show("No Command to save!");
                this.textBox31.Focus();
            }
            else
            {

                string Column5 = "SV_GameSendServerCommand";
                string Column6 = textBox31.Text;

                string[] row = { Column5, Column6 };
                DEV.Rows.Add(row);




                textBox31.Focus();

                textBox31.Clear();
            }
        }

        private void button112_Click(object sender, EventArgs e)
        {
            if (textBox32.Text == "")
            {
                MessageBox.Show("No Command to save!");
                this.textBox32.Focus();
            }
            else
            {

                string Column5 = "CBuf_Addtext";
                string Column6 = textBox32.Text;

                string[] row = { Column5, Column6 };
                DEV.Rows.Add(row);




                textBox32.Focus();

                textBox32.Clear();
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DEV.Rows.Clear();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DEV.Refresh();
        }

        private void label100_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In Rebug Toolbox : \n-System Mode : REBUG\n-XMB Operation Mode : DEBUG\n-Debug Menu Type : DEX\n-Cobra Mode : Enable\n\nIn Debug Settings\n-Release Check Mode : Development Mode\n-Boot Mode : System Software Mode\n-Network Settings for Debug : Single Settings", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label101_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can not set Unlockall with hen! you need Debug settings to do that!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button302_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button223_Click(object sender, EventArgs e)
        {


        }

        private void button39_Click_1(object sender, EventArgs e)
        {
            PS3.Extension.WriteString(0x20dfe78, "^Hdd\u0012overlay_low_health\0");
        }

        private void button114_Click_1(object sender, EventArgs e)
        {
            PS3.Extension.WriteBytes(0x371572A4, new byte[] { 0x00, 0x00, 0x00, 0x00 });
            PS3.Extension.WriteBytes(0x371572A4, new byte[] { 0x00, 0x00, 0x00, 0x00 });
            PS3.Extension.WriteBytes(0x37267640, new byte[] { 0x00, 0x00, 0x00, 0x00 });
            PS3.Extension.WriteBytes(0x372CE8E0, new byte[] { 0x00, 0x00, 0x00, 0x00 });
            PS3.Extension.WriteBytes(0x37393190, new byte[] { 0x00, 0x00, 0x00, 0x00 });
            PS3.Extension.WriteBytes(0x373D8574, new byte[] { 0x00, 0x00, 0x00, 0x00 });
            PS3.Extension.WriteBytes(0x374B421C, new byte[] { 0x00, 0x00, 0x00, 0x00 });
            PS3.Extension.WriteBytes(0x375279F8, new byte[] { 0x00, 0x00, 0x00, 0x00 });
            PS3.Extension.WriteBytes(0x3756F4E0, new byte[] { 0x00, 0x00, 0x00, 0x00 });

        }

        private void button116_Click_1(object sender, EventArgs e)
        {
            comboBox8.DroppedDown = true;
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox8.Text == "Low Health")
            {
                PS3.Extension.WriteString(0x1f3cff4, "^Hdd\u0012overlay_low_health\0");
                PS3.Extension.WriteString(0x20dfe78, "^Hdd\u0012overlay_low_health\0");
            }
            else if (comboBox8.Text == "LongCheckBox")
            {
                PS3.Extension.WriteString(0x1f3cff4, "^Hc2youtube_logo" + "^1E3Modz");
            }
            else if (comboBox8.Text == "KD")
            {
                PS3.Extension.WriteString(0x1f3cff4, "^Hdd\u001amenu_mp_lobby_aar_icons_kd\0");
                PS3.Extension.WriteString(0x20dfe78, "^Hdd\u001amenu_mp_lobby_aar_icons_kd\0");
            }
            else if (comboBox8.Text == "Scoreboard")
            {
                PS3.Extension.WriteString(0x1f3cff4, "^Hdd\t7_shotgun_tc12_barrel_01_world\0");

            }
        }

        private void CCAPICheck_OnValueChange(object sender, EventArgs e)
        {
            if (CCAPICheck.Value == true)
            {
                TMAPICheck.Value = false;
                HenCheck.Value = false;
                E3modz.ChangeAPI(SelectAPI.ControlConsole);
                label7.Text = "CCAPI";
            }
            else
            {
                label7.Text = "?";
            }
        }

        private void TMAPICheck_OnValueChange(object sender, EventArgs e)
        {
            if (TMAPICheck.Value == true)
            {
                CCAPICheck.Value = false;
                HenCheck.Value = false;
                E3modz.ChangeAPI(SelectAPI.TargetManager);
                label7.Text = "TMAPI";
            }
            else
            {
                label7.Text = "?";
            }
        }

        private void HenCheck_OnValueChange(object sender, EventArgs e)
        {
            if (HenCheck.Value == true)
            {
                CCAPICheck.Value = false;
                TMAPICheck.Value = false;
                if (hencon.Length == 0)
                {
                    MessageBox.Show("Please Add first a Console on Hen Console Manager!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    label7.Text = "HEN";
                }
            }
            else
            {

            }
        }

        private void button122_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Allow you to switch the connection API", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Show your console infos \nworking on: CCAPI and Hen!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel63_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button123_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Show your Game Information and the tool settings", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button127_Click_1(object sender, EventArgs e)
        {
            if (button127.Text == "OFF")
            {
                button127.Text = "ON";
                button127.ForeColor = Color.Green;
            }
            else if (button127.Text == "ON")
            {
                button127.Text = "OFF";
                button127.ForeColor = Color.Red;
            }
        }

        private void button126_Click_1(object sender, EventArgs e)
        {
            if (button126.Text == "OFF")
            {
                button126.Text = "ON";
                button126.ForeColor = Color.Green;
            }
            else if (button126.Text == "ON")
            {
                button126.Text = "OFF";
                button126.ForeColor = Color.Red;
            }
        }

        private void button129_Click_1(object sender, EventArgs e)
        {
            if (button129.Text == "OFF")
            {
                button129.Text = "ON";
                button129.ForeColor = Color.Green;
            }
            else if (button129.Text == "ON")
            {
                button129.Text = "OFF";
                button129.ForeColor = Color.Red;
            }
        }

        private void button145_Click(object sender, EventArgs e)
        {
            if (button145.Text == "OFF")
            {
                button145.Text = "ON";
                button145.ForeColor = Color.Green;
            }
            else if (button145.Text == "ON")
            {
                button145.Text = "OFF";
                button145.ForeColor = Color.Red;
            }
        }

        private void button147_Click(object sender, EventArgs e)
        {
            if (button147.Text == "OFF")
            {
                button147.Text = "ON";
                button147.ForeColor = Color.Green;
            }
            else if (button147.Text == "ON")
            {
                button147.Text = "OFF";
                button147.ForeColor = Color.Red;
            }
        }

        private void button149_Click(object sender, EventArgs e)
        {
            if (button149.Text == "OFF")
            {
                button149.Text = "ON";
                button149.ForeColor = Color.Green;
            }
            else if (button149.Text == "ON")
            {
                button149.Text = "OFF";
                button149.ForeColor = Color.Red;
            }
        }

        private void button155_Click(object sender, EventArgs e)
        {
            if (button155.Text == "OFF")
            {
                button155.Text = "ON";
                button155.ForeColor = Color.Green;
            }
            else if (button155.Text == "ON")
            {
                button155.Text = "OFF";
                button155.ForeColor = Color.Red;
            }
        }

        private void button153_Click(object sender, EventArgs e)
        {
            if (button153.Text == "OFF")
            {
                button153.Text = "ON";
                button153.ForeColor = Color.Green;
            }
            else if (button153.Text == "ON")
            {
                button153.Text = "OFF";
                button153.ForeColor = Color.Red;
            }
        }

        private void button151_Click(object sender, EventArgs e)
        {
            if (button151.Text == "OFF")
            {
                button151.Text = "ON";
                button151.ForeColor = Color.Green;
            }
            else if (button151.Text == "ON")
            {
                button151.Text = "OFF";
                button151.ForeColor = Color.Red;
            }
        }

        private void button157_Click(object sender, EventArgs e)
        {
            RPC.CBuf_Addtext("cmd mr " + PS3.Extension.ReadInt32(0x1198860) + " 3 endround");
        }

        private void button158_Click(object sender, EventArgs e)
        {
            RPC.CBuf_Addtext("cmd mr " + PS3.Extension.ReadInt32(0x1198860) + " 3 endround");
        }

        private void button159_Click(object sender, EventArgs e)
        {
            RPC.CBuf_Addtext("disconnect\n");
        }

        private void button35_Click_1(object sender, EventArgs e)
        {
            if (RPC_Enabled)
            {
                if (button35.Text == "OFF")
                {
                    button35.ForeColor = Color.Green;
                    forceHostLoopOn = (true);
                    button35.Text = "ON";

                    if (!forceHostBackgroundWorker.IsBusy)
                    {
                        forceHostBackgroundWorker.RunWorkerAsync();
                    }
                }

                else
                {
                    forceHostLoopOn = (false);
                    button35.Text = "OFF";
                    button35.ForeColor = Color.Red;
                }
            }
        }

        private void button59_Click_2(object sender, EventArgs e)
        {
            try
            {
                if (comboBox9.Text == "Right top Corner")
                {
                    PS3.SetMemory(0xCC5A8, new byte[] { 0x2c, 0x14, 0x00, 0x01 });
                    PS3.Extension.WriteString(0x00A544E8, bunifuTextbox1.text);
                }
                else if (comboBox9.Text == "Right bottom Corner")
                {
                    PS3.SetMemory(0xCC5A8, new byte[] { 0x2c, 0x14, 0x00, 0x01 });
                    PS3.Extension.WriteString(0x00A544E8, "\n\n\n\n\n\n\n\n\n\n" + bunifuTextbox1.text);
                }
                else
                {
                    MessageBox.Show("Please select the position befor you can Spawn the FPS Text!\nError: Nothing Selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button95_Click_1(object sender, EventArgs e)
        {
            comboBox9.DroppedDown = true;
        }

        private void explosivToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x383 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 0x7a });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Bullets Changed to: ^2 Explosiv");
        }

        private void rPGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x383 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 0x7a });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Bullets Changed to: ^2RPG-Rocktes");
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x383 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 0x8f });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Bullets Changed to: ^2Model");

        }

        private void defaultToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x383 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 14 });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Bullets^1Taken");
        }

        private void enableToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x5eff + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 0x07 });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Uav ^2Given");
        }

        private void enableToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x383 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 0x6d });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Rapidfire ^2Enabled");
        }

        private void enableToolStripMenuItem3_Click_2(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x5d27 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 0x00 });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "^1Bro it looks like you Internet suck....");
        }

        private void disableToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x5d27 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 0x02 });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "^2Internet Restored");
        }

        private void disableToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x5eff + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 0x03 });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "UAV ^1Taken");
        }

        private void enableToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x5df8 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 0x40 });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Speed 2x ^2Enabled");
        }

        private void kudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x383 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 0x02 });
        }

        private void disableToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x383 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 14 });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Rapidfire ^1Taken");
        }

        private void disableToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x5df8 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 0x3f });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Speed 2x ^1Taken");
        }

        private void defaultToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x647 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[4]);
            PS3.SetMemory((G_Client + 0x65b + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[1]);
            PS3.SetMemory((G_Client + 0x647 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[2]);
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Vision set to: ^2Default");
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[4];
            buffer[2] = 0xf8;
            buffer[3] = 0xfb;
            PS3.SetMemory((G_Client + 0x647 + (uint)dataGridView1.CurrentRow.Index * 0x6200), buffer);
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Vision set to: ^2Blue");
        }

        private void eMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[4];
            buffer[2] = 0xf8;
            buffer[3] = 0xfb;
            PS3.SetMemory((G_Client + 0x647 + (uint)dataGridView1.CurrentRow.Index * 0x6200), buffer);
            byte[] buffer2 = new byte[] { 0xff };
            PS3.SetMemory((G_Client + 0x647 + (uint)dataGridView1.CurrentRow.Index * 0x6200), buffer2);
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Vision set to: ^2EMP");
        }

        private void thermalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte[] buffer2 = new byte[] { 0xff };
            PS3.SetMemory((G_Client + 0x647 + (uint)dataGridView1.CurrentRow.Index * 0x6200), buffer2);
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Vision set to: ^2Thermal");
        }

        private void enableToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Third Person: ^2Enabled");
            PS3.SetMemory((G_Client + 0x12d + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 0x01 });
        }

        private void disableToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x12d + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 0x00 });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Third Person: ^1Disabled");
        }

        private void enableToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x658 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 0xf5 });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Hud ^1Removed");
        }

        private void disableToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x658 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 0x00 });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Hud ^2Restored");
        }

        private void enableToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x65a + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 0x01 });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Invisible: ^2Enabled");
        }

        private void disableToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Invisible: ^1Taken");
            PS3.SetMemory((G_Client + 0x65a + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 0x00 });
        }

        private void disabledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(G_Client + 0x5 + dataGridView1.CurrentRow.Index * 0x350), new byte[2] { 0x00, 0x00 });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Movment: ^1UnFrozzen");
        }

        private void vMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x383 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 0x04 });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "VMP ^2Given");
        }

        private void kN44ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x383 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 14 });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "KN-44 ^2Given");
        }

        private void hVK30ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x383 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 0x12 });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "HVK-30 ^2Given");
        }

        private void iCR1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x383 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 20 });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "HVK-30 ^2Given");
        }

        private void kRMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x383 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 0x1c });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "KRM ^2Given");
        }

        private void aRGUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x383 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 0x1f });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "KRM ^2Given");
        }

        private void bRMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x383 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 0x20 });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "BRM ^2Given");
        }

        private void dingoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x383 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 0x22 });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "DINGO ^2Given");
        }

        private void drakonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x383 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 40 });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "DRAKON ^2Given");
        }

        private void locusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x383 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 0x2a });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "LOCUS ^2Given");
        }

        private void noCamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x389 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 0x00 });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Camo ^1Removed");
        }

        private void jungleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x389 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 1 });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Camo changed to: ^2Jungle");
        }

        private void flectarnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x389 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 3 });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Camo changed to: ^2flectarn");
        }

        private void danteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x389 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 6 });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Camo changed to: ^2Dante");
        }

        private void policiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x389 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 9 });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Camo changed to: ^2Burnt");
        }

        private void darkMetterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x389 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 0x11 });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Camo changed to: ^2Dark Metter");
        }

        private void button135_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click_1(object sender, EventArgs e)
        {
        }

        private void enableToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x12F + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 0x04 });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "T-Bag ^2Enabled");
        }

        private void enableToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x186 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 0x01 });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Snake Mode ^2Enabled");
        }

        private void disableToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x186 + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 0x02 });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Snake Mode ^2Enabled");
        }

        private void giveToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x73B + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 0x01 });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Specialist ^2Given");
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((G_Client + 0x73B + (uint)dataGridView1.CurrentRow.Index * 0x6200), new byte[] { 0x00 });
            RPC.iPrintln(this.dataGridView1.CurrentRow.Index, "Specialist ^1Removed");
        }

        private void button33_Click_1(object sender, EventArgs e)
        {
            PS3.Extension.WriteString(0x10040000, "Hello");
        }

        private void button163_Click(object sender, EventArgs e)
        {
            string hello = PS3.Extension.ReadString(0x10040000);
            MessageBox.Show(hello);
        }

        private void button165_Click(object sender, EventArgs e)
        {
            if (button165.Text == "OFF")
            {
                button165.Text = "ON";
                button165.ForeColor = Color.Green;
                PS3.SetMemory(0x10040000, new byte[] { 0x01 });
            }
            else if (button165.Text == "ON")
            {
                PS3.SetMemory(0x10040000, new byte[] { 0x00 });
                button165.Text = "OFF";
                button165.ForeColor = Color.Red;
            }
        }

        private void button167_Click(object sender, EventArgs e)
        {
            if (button167.Text == "OFF")
            {
                button167.Text = "ON";
                button167.ForeColor = Color.Green;
                PS3.SetMemory(0x10040001, new byte[] { 0x01 });
            }
            else if (button167.Text == "ON")
            {
                PS3.SetMemory(0x10040001, new byte[] { 0x00 });
                button167.Text = "OFF";
                button167.ForeColor = Color.Red;
            }
        }
    }
}
    









