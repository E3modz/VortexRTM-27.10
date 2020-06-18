using E3Modz.Login___Home;
using Microsoft.VisualBasic;
using PS3Lib;
using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace E3Modz.Black_Ops_2
{
    public partial class BO3Zombies : Form
    {
        private bool henPS3 = false;
        private readonly string errorStatus = "Process failed";
        PS3API E3modz = new PS3API();
        public static uint NameAddress = 0x5DB0;
        static uint Prestige = 0x37DDE5D8;
        uint G_Client = (0x18C42E8);
        bool RPC_Enabled = (false);
        bool forceHostLoopOn = (false);
        uint G_Client_Size = (0x61E0);
        uint selected_client = (0);
        public static System.Drawing.Point newpoint = new System.Drawing.Point();
        public static string Username;
        public static string Password;
        public static int x;
        public static int y;
        public static PS3API PS3 = new PS3API(SelectAPI.ControlConsole);
        public static PS3ManagerAPI.PS3MAPI PS3M_API = new PS3ManagerAPI.PS3MAPI();
        public BO3Zombies()
        {
            InitializeComponent();
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

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                PS3.ChangeAPI(SelectAPI.ControlConsole);
            }
        }

        private void Con_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                PS3.ChangeAPI(SelectAPI.ControlConsole);
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            label20.Text = "Connecting..";

            if (HenRadio.Checked == true)
            {
                PS3M_API.ConnectTarget(Main.hencon, Convert.ToInt32(7887));
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            if (E3modz.ConnectTarget())
            {
                label20.Refresh();
                label20.Text = "Connected";
                label3.Text = "Connected!";
                label3.ForeColor = Color.Green;
                MessageBox.Show("Connected!", "Succesfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Thread.Sleep(100);
                label20.Text = "Awaiting attach..";
                E3modz.CCAPI.RingBuzzer(CCAPI.BuzzerMode.Single);
                E3modz.CCAPI.Notify(CCAPI.NotifyIcon.FINGER, "VortexRTM Connected!");

            }
            else
            {
                MessageBox.Show("Operation Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label20.Text = errorStatus;
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            label20.Text = "Attaching..";
            if (HenRadio.Checked == true)
            {
                PS3.ChangeAPI(SelectAPI.PS3Manager);
                if (!PS3M_API.AttachProcess(PS3M_API.Process.Processes_Pid[this.comboBox1.SelectedIndex]))
                {
                    MessageBox.Show("Impossible to attach :(", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    PS3M_API.DisconnectTarget();
                }
                label20.Refresh();
                label20.Text = "Attached";
                RPC_Enabled = true;
                byte[] buffer = new byte[] { 1 };
                PS3.SetMemory(0xc7b1b, buffer);
                PS3.Extension.WriteString(0xa46248, "\n\n\n\n\n\n\n\n\n\n\n\n^2Vortex^1RTM");
                label3.Text = "Connected + Attached!";
                label3.ForeColor = Color.Green;
                MessageBox.Show("Attached!", "Succesfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Thread.Sleep(100);
                label20.Text = "Attached Sucessfully!";
                E3modz.CCAPI.RingBuzzer(CCAPI.BuzzerMode.Double);
                E3modz.CCAPI.Notify(CCAPI.NotifyIcon.FINGER, "VortexRTM Engine Injected! Have Fun!");
            }
            if (E3modz.AttachProcess())
            {
                label20.Refresh();
                label20.Text = "Attached";
                RPC_Enabled = true;
                byte[] buffer = new byte[] { 1 };
                PS3.SetMemory(0xc7b1b, buffer);
                PS3.Extension.WriteString(0xa46248, "\n\n\n\n\n\n\n\n\n\n\n\n^2Vortex^1RTM");
                label3.Text = "Connected + Attached!";
                label3.ForeColor = Color.Green;
                MessageBox.Show("Attached!", "Succesfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Thread.Sleep(100);
                label20.Text = "Attached Sucessfully!";
                E3modz.CCAPI.RingBuzzer(CCAPI.BuzzerMode.Double);
                E3modz.CCAPI.Notify(CCAPI.NotifyIcon.FINGER, "VortexRTM Engine Injected! Have Fun!");
            }
            else
            {
                MessageBox.Show("Attaching failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button61_Click(object sender, EventArgs e)
        {
            
        }

        private void Button65_Click(object sender, EventArgs e)
        {
          
        }

        private void Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BO3Zombies_Load(object sender, EventArgs e)
        {
            
            this.co.SelectedTab = con;
            this.Connection.BackColor = Color.FromArgb(192, 64, 0);
            this.Acoountbtn.BackColor = Color.FromArgb(35, 35, 35);
            this.clientsbtm.BackColor = Color.FromArgb(35, 35, 35);
            this.LobbyBtn.BackColor = Color.FromArgb(35, 35, 35);
            this.moreBtn.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void Button60_Click(object sender, EventArgs e)
        {
            PS3.ChangeAPI(SelectAPI.PS3Manager);
            if (!PS3M_API.AttachProcess(PS3M_API.Process.Processes_Pid[this.comboBox1.SelectedIndex]))
            {
                MessageBox.Show("Impossible to attach :(", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                PS3M_API.DisconnectTarget();
            }
            henPS3 = true;
            PS3M_API.PS3.Notify("Successfully Attached");
            label20.Refresh();
            label20.Text = "Attached";
            RPC_Enabled = true;
            label3.Text = "Connected + Attached!";
            label3.ForeColor = Color.Green;
            byte[] buffer = new byte[] { 1 };
            PS3.SetMemory(0xc7b1b, buffer);
            PS3.Extension.WriteString(0xa46248, "\n\n\n\n\n\n\n\n\n\n\n\n^2Vortex^1RTM");
            MessageBox.Show("Attached!", "Succesfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Thread.Sleep(100);
            label20.Text = "Attached Sucessfully!";
            E3modz.CCAPI.RingBuzzer(CCAPI.BuzzerMode.Double);
            E3modz.CCAPI.Notify(CCAPI.NotifyIcon.FINGER, "Vortex HEN Engine Injected, have Fun!");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
          

            button6.Enabled = false;
            button7.Enabled = false;
            button10.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            PS3.DisconnectTarget();
            label3.Text = "Diconnected!";
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            PS3.CCAPI.ShutDown(CCAPI.RebootFlags.ShutDown);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.co.SelectedTab = con;
            this.Connection.BackColor = Color.FromArgb(192, 64, 0);
            this.Acoountbtn.BackColor = Color.FromArgb(35, 35, 35);
            this.clientsbtm.BackColor = Color.FromArgb(35, 35, 35);
            this.LobbyBtn.BackColor = Color.FromArgb(35, 35, 35);
            this.moreBtn.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.co.SelectedTab = clientlist;
            this.clientsbtm.BackColor = Color.FromArgb(192, 64, 0);
            this.Acoountbtn.BackColor = Color.FromArgb(35, 35, 35);
            this.Connection.BackColor = Color.FromArgb(35, 35, 35);
            this.LobbyBtn.BackColor = Color.FromArgb(35, 35, 35);
            this.moreBtn.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void Acoountbtn_Click(object sender, EventArgs e)
        {
            this.co.SelectedTab = account;
            this.Acoountbtn.BackColor = Color.FromArgb(192, 64, 0);
            this.Connection.BackColor = Color.FromArgb(35, 35, 35);
            this.clientsbtm.BackColor = Color.FromArgb(35, 35, 35);
            this.LobbyBtn.BackColor = Color.FromArgb(35, 35, 35);
            this.moreBtn.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void LobbyBtn_Click(object sender, EventArgs e)
        {
            this.co.SelectedTab = loby;
            this.LobbyBtn.BackColor = Color.FromArgb(192, 64, 0);
            this.Acoountbtn.BackColor = Color.FromArgb(35, 35, 35);
            this.clientsbtm.BackColor = Color.FromArgb(35, 35, 35);
            this.Connection.BackColor = Color.FromArgb(35, 35, 35);
            this.moreBtn.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void MoreBtn_Click(object sender, EventArgs e)
        {
            this.co.SelectedTab = more;
            this.moreBtn.BackColor = Color.FromArgb(192, 64, 0);
            this.Acoountbtn.BackColor = Color.FromArgb(35, 35, 35);
            this.clientsbtm.BackColor = Color.FromArgb(35, 35, 35);
            this.LobbyBtn.BackColor = Color.FromArgb(35, 35, 35);
            this.Connection.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void Panel6_MouseDown(object sender, MouseEventArgs e)
        {
            BO3Zombies.x = Control.MousePosition.X - base.Location.X;
            BO3Zombies.y = Control.MousePosition.Y - base.Location.Y;
        }

        private void Panel6_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BO3Zombies.newpoint = Control.MousePosition;
                BO3Zombies.newpoint.X -= BO3Zombies.x;
                BO3Zombies.newpoint.Y -= BO3Zombies.y;
                base.Location = BO3Zombies.newpoint;
            }
        }

        private void Panel6_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BO3Zombies.newpoint = Control.MousePosition;
                BO3Zombies.newpoint.X -= BO3Zombies.x;
                BO3Zombies.newpoint.Y -= BO3Zombies.y;
                base.Location = BO3Zombies.newpoint;
            }
        }

        private void Panel6_MouseDown_1(object sender, MouseEventArgs e)
        {
            BO3Zombies.x = Control.MousePosition.X - base.Location.X;
            BO3Zombies.y = Control.MousePosition.Y - base.Location.Y;
        }
        public string GetName(int ClientNum)
        {
            byte[] array = new byte[20];
            PS3.GetMemory((uint)(G_Client + G_Client_Size * ClientNum + 0x5DB0), array);
            return Encoding.ASCII.GetString(array).Replace("\0", "");
        }
        private static void SV_GameSendServerCommand(int Client, string Command)
        {
            ZombieRPC.Call(0x5E0E44, Client, 1, Command);
        }
        public static void iPrintln(int Client, string Text)
        {
            SV_GameSendServerCommand(Client, "O \"" + Text + "\"");
        }
        private void Button1_Click_1(object sender, EventArgs e)
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

        private void EnableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(0x18C430b + dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x05 });
        }

        private void Clientlist_Click(object sender, EventArgs e)
        {

        }

        private void GiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(0x18C430b + dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x05 });
        }

        private void RemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((uint)(0x18C430b + dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x04 });
        }

        private void GiveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C4862 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x7f, 0xff, 0xff, 0xff });
            PS3.SetMemory((0x18C4826 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x7f, 0xff, 0xff, 0xff });
            PS3.SetMemory((0x18BC8C2 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x7f, 0xff, 0xff, 0xff });
            PS3.SetMemory((0x18C486A + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x7f, 0xff, 0xff, 0xff });
            PS3.SetMemory((0x18C4864 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x7f, 0xff, 0xff, 0xff });
        }

        private void RemoveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C4862 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory((0x18C4826 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory((0x18BC8C2 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory((0x18C486A + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x00, 0x00, 0x00, 0x00 });
            PS3.SetMemory((0x18C4864 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x00, 0x00, 0xff, 0x00 });
        }

        private void MaxPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18CA19D + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x7f, 0xff, 0xff, 0xff });
        }

        private void GiveToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18CA0E0 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x3f, 0xff });
        }

        private void RemoveToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18CA0E0 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x3f, 0x80 });
        }

        private void GiveToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18CA00F + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x01 });
        }

        private void RemoveToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18CA00F + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x02 });
        }

        private void GiveToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C4415 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x01 });
        }

        private void RemoveToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C4415 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x00 });
        }

        private void RemoveToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18CA1E7 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x00 });
        }

        private void DisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18CA1E7 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x03 });
        }

        private void GiveToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18CA0CD + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0xff, 0x00, 0x64, 0x00 });
        }

        private void RemoveToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18CA0CD + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x00, 0x00, 0x64, 0x00 });
        }

        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F9 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x01 });
        }

        private void DefaultWeaponsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F3 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x01 });
        }

        private void VsperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F3 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x02 });
        }

        private void VMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F3 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x04 });
        }

        private void KudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F3 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x06 });
        }

        private void PharoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F3 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x09 });
        }

        private void PortersX2RayGunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F3 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x0B });
        }

        private void RazorbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F3 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x0D });
        }

        private void HyèneKudaAmélioréeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F3 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x0F });
        }

        private void ICR1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F3 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x1A });
        }

        private void KN44ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F3 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x1C });
        }

        private void M8A7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F3 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x1E });
        }

        private void SheivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F3 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x20 });
        }

        private void HVK30ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F3 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x22 });
        }

        private void ManOWarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F3 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x24 });
        }

        private void XR2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F3 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x26 });
        }

        private void VengeurConsacréKN44AmélioréeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F3 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x28 });
        }

        private void KRM262ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F3 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x33 });
        }

        private void MarAstaguaArbgwaothToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F3 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x80 });
        }

        private void NarUllaquaArbgwaothToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F3 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x81 });
        }

        private void LorZarozzorArbgwaothToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F3 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x82 });
        }

        private void WeaponInterdimensionalGunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F3 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x83 });
        }

        private void KreeaholoLuKreemasaleetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F3 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x89 });
        }

        private void KreeahoahmNalAhmahmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F3 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x76 });
        }

        private void KreeahoahmNalAhmhogarocToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F3 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x79 });
        }

        private void KreegakaleetLuGosataahmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F3 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x95 });
        }

        private void PortersX2RayGunToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F3 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x96 });
        }

        private void DeathMachineToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F3 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x95 });
        }

        private void RayGunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F3 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x75 });
        }

        private void WunderwaffeDG2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F3 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x78 });
        }

        private void WunderwaffeDG3JZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F3 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x77 });
        }

        private void ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F9 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x02 });
        }

        private void ToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F9 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x03 });
        }

        private void ToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F9 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x04 });
        }

        private void ToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F9 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x05 });
        }

        private void ToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F9 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x06 });
        }

        private void ToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F9 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x07 });
        }

        private void ToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F9 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x08 });
        }

        private void ToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F9 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x09 });
        }

        private void ToolStripMenuItem13_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F9 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x0A });
        }

        private void DarkMetterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F9 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x11 });
        }

        private void GirlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C45F9 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x0C });
        }

        private void FireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(0x25e5660, new byte[1]);
            PS3.SetMemory((0x18C45F9 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x02 });
        }

        private void DefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(0x25e5660, new byte[1]);
            PS3.SetMemory((0x18C45F9 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x00 });
        }

        private void WaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x25e5660 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 1 });
        }

        private void SendModdedInGameStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18CA1B2 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0xff, 0xff, 0xff, 0xff });
            PS3.SetMemory((0x18CA1BE + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0xff, 0xff, 0xff, 0xff });
            PS3.SetMemory((0x18CA19E + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0xff, 0xff, 0xff, 0xff });
        }
        public string method_30(int int_1)
        {
            byte[] buffer = new byte[0x10];
            PS3.GetMemory(0x1AEE380 + 0x3334 + ((uint)(int_1 * 0x3900)), buffer);
            return Encoding.ASCII.GetString(buffer).Replace("\0", "");
        }
        private void ChangeNameInGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = Interaction.InputBox("Set a new name here :", "Change Name By VortexRTM", method_30(dataGridView1.CurrentRow.Index), -1, -1);
            byte[] bytes = Encoding.ASCII.GetBytes(str + "\0");
            PS3.SetMemory(0x18CA0fc + ((uint)dataGridView1.CurrentRow.Index * 0x350), bytes);
            PS3.SetMemory((0x18CA19b + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x00 });
            Thread.Sleep(1000);
            PS3.SetMemory((0x18CA19b + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x01 });
        }

        private void GiveToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C42Fc + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x02 });
        }

        private void RemoveToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C42Fc + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x00 });
        }

        private void GiveToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C42F8 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x00 });
        }

        private void RemoveToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            PS3.SetMemory((0x18C42F8 + (uint)dataGridView1.CurrentRow.Index * 0x350), new byte[] { 0x0A });
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "No Recoil OFF")
            {
                byte[] buffer = new byte[4];
                buffer[0] = 0x60;
                PS3.SetMemory(0x18b3a0, buffer);
                button2.Text = "No Recoil ON";
            }
            else if (button2.Text == "No Recoil ON")
            {
                button2.Text = "No Recoil OFF";
                PS3.SetMemory(0x18b3a0, new byte[] { 0x48, 0x5e, 0xe4, 0xc9 });
            }
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            if (button3.Text == "Small Crosshair OFF")
            {
                PS3.SetMemory(0x75bbc7, new byte[1]);
                button3.Text = "Small Crosshair ON";
            }
            else if (button3.Text == "Small Crosshair ON")
            {
                button3.Text = "Small Crosshair OFF";
                byte[] buffer = new byte[] { 2 };
                PS3.SetMemory(0x75bbc7, buffer);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "ProMode OFF")
            {
                byte[] buffer = new byte[] { 0x40, 0xff };
                PS3.SetMemory(0x25ef020, buffer);
                button4.Text = "ProMode ON";
            }
            else if (button4.Text == "ProMode ON")
            {
                button4.Text = "ProMode OFF";
                byte[] buffer = new byte[] { 0x00, 0x00 };
                PS3.SetMemory(0x25ef020, buffer);
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(0x174A2AF, BitConverter.GetBytes((int)numericUpDown1.Value));
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (button11.Text == "ALL Unlimited Ammo OFF")
            {
                PS3.SetMemory(0x18BC8C2, new byte[] { 0x7f, 0xff, 0xff, 0xff });
                PS3.SetMemory(0x18BC8C2 + 0x61E0, new byte[] { 0xff, 0xff, 0xff, 0xff });
                PS3.SetMemory(0x18BC8C2 + 0x61E0 + 0x61E0, new byte[] { 0xff, 0xff, 0xff, 0xff });
                PS3.SetMemory(0x18BC8C2 + 0x61E0 + 0x61E0 + 0x61E0, new byte[] { 0xff, 0xff, 0xff, 0xff });
                //
                PS3.SetMemory(0x18C4862, new byte[] { 0x7f, 0xff, 0xff, 0xff });
                PS3.SetMemory(0x18C4862 + 0x61E0, new byte[] { 0xff, 0xff, 0xff, 0xff });
                PS3.SetMemory(0x18C4862 + 0x61E0 + 0x61E0, new byte[] { 0xff, 0xff, 0xff, 0xff });
                PS3.SetMemory(0x18C4862 + 0x61E0 + 0x61E0 + 0x61E0, new byte[] { 0xff, 0xff, 0xff, 0xff });
                //
                PS3.SetMemory(0x18C4826, new byte[] { 0x7f, 0xff, 0xff, 0xff });
                PS3.SetMemory(0x18C4826 + 0x61E0, new byte[] { 0xff, 0xff, 0xff, 0xff });
                PS3.SetMemory(0x18C4826 + 0x61E0 + 0x61E0, new byte[] { 0xff, 0xff, 0xff, 0xff });
                PS3.SetMemory(0x18C4826 + 0x61E0 + 0x61E0 + 0x61E0, new byte[] { 0xff, 0xff, 0xff, 0xff });
                //
                PS3.SetMemory(0x18C486A, new byte[] { 0x7f, 0xff, 0xff, 0xff });
                PS3.SetMemory(0x18C486A + 0x61E0, new byte[] { 0xff, 0xff, 0xff, 0xff });
                PS3.SetMemory(0x18C486A + 0x61E0 + 0x61E0, new byte[] { 0xff, 0xff, 0xff, 0xff });
                PS3.SetMemory(0x18C486A + 0x61E0 + 0x61E0 + 0x61E0, new byte[] { 0xff, 0xff, 0xff, 0xff });
                //
                PS3.SetMemory(0x18C4864, new byte[] { 0x7f, 0xff, 0xff, 0xff });
                PS3.SetMemory(0x18C4864 + 0x61E0, new byte[] { 0xff, 0xff, 0xff, 0xff });
                PS3.SetMemory(0x18C4864 + 0x61E0 + 0x61E0, new byte[] { 0xff, 0xff, 0xff, 0xff });
                PS3.SetMemory(0x18C4864 + 0x61E0 + 0x61E0 + 0x61E0, new byte[] { 0xff, 0xff, 0xff, 0xff });
                button11.Text = "ALL Unlimited Ammo ON";
            }
            else if (button11.Text == "ALL Unlimited Ammo ON")
            {
                button11.Text = "ALL Unlimited Ammo OFF";
                PS3.SetMemory(0x18BC8C2, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                PS3.SetMemory(0x18BC8C2 + 0x61E0, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                PS3.SetMemory(0x18BC8C2 + 0x61E0 + 0x61E0, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                PS3.SetMemory(0x18BC8C2 + 0x61E0 + 0x61E0 + 0x61E0, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                //
                PS3.SetMemory(0x18C4862, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                PS3.SetMemory(0x18C4862 + 0x61E0, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                PS3.SetMemory(0x18C4862 + 0x61E0 + 0x61E0, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                PS3.SetMemory(0x18C4862 + 0x61E0 + 0x61E0 + 0x61E0, new byte[] { 0xff, 0xff, 0xff, 0xff });
                //
                PS3.SetMemory(0x18C4826, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                PS3.SetMemory(0x18C4826 + 0x61E0, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                PS3.SetMemory(0x18C4826 + 0x61E0 + 0x61E0, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                PS3.SetMemory(0x18C4826 + 0x61E0 + 0x61E0 + 0x61E0, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                //
                PS3.SetMemory(0x18C486A, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                PS3.SetMemory(0x18C486A + 0x61E0, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                PS3.SetMemory(0x18C486A + 0x61E0 + 0x61E0, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                PS3.SetMemory(0x18C486A + 0x61E0 + 0x61E0 + 0x61E0, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                //
                PS3.SetMemory(0x18C4864, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                PS3.SetMemory(0x18C4864 + 0x61E0, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                PS3.SetMemory(0x18C4864 + 0x61E0 + 0x61E0, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                PS3.SetMemory(0x18C4864 + 0x61E0 + 0x61E0 + 0x61E0, new byte[] { 0x00, 0x00, 0x00, 0x00 });
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (button12.Text == "ALL GodMode OFF")
            {
                PS3.SetMemory(0x18C430b, new byte[] { 0x01, 0x01, 0x01, 0x01 });
                PS3.SetMemory(0x18C430b + 0x61E0, new byte[] { 0x01, 0x01, 0x01, 0x01 });
                PS3.SetMemory(0x18C430b + 0x61E0 + 0x61E0, new byte[] { 0x01, 0x01, 0x01, 0x01 });
                PS3.SetMemory(0x18C430b + 0x61E0 + 0x61E0 + 0x61E0, new byte[] { 0x01, 0x01, 0x01, 0x01 });
                button12.Text = "ALL GodMode ON";
            }
            else if (button12.Text == "ALL GodMode ON")
            {
                PS3.SetMemory(0x18C430b, new byte[] { 0x00, 0x10, 0x10, 0x00 });
                PS3.SetMemory(0x18C430b + 0x61E0, new byte[] { 0x00, 0x10, 0x10, 0x00 });
                PS3.SetMemory(0x18C430b + 0x61E0 + 0x61E0, new byte[] { 0x00, 0x10, 0x10, 0x00 });
                PS3.SetMemory(0x18C430b + 0x61E0 + 0x61E0 + 0x61E0, new byte[] { 0x00, 0x10, 0x10, 0x00 });
                button12.Text = "ALL GodMode OFF";

            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (button13.Text == "ALL Max Points OFF")
            {
                PS3.SetMemory(0x18CA19D, new byte[] { 0x7f, 0xff, 0xff, 0xff });
                PS3.SetMemory(0x18CA19D + 0x61E0, new byte[] { 0x7f, 0xff, 0xff, 0xff });
                PS3.SetMemory(0x18CA19D + 0x61E0 + 0x61E0, new byte[] { 0x7f, 0xff, 0xff, 0xff });
                PS3.SetMemory(0x18CA19D + 0x61E0 + 0x61E0 + 0x61E0, new byte[] { 0x7f, 0xff, 0xff, 0xff });
                button13.Text = "ALL Max Points ON";
            }
            else if (button13.Text == "ALL Max Points ON")
            {
                PS3.SetMemory(0x18CA19D, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                PS3.SetMemory(0x18CA19D + 0x61E0, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                PS3.SetMemory(0x18CA19D + 0x61E0 + 0x61E0, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                PS3.SetMemory(0x18CA19D + 0x61E0 + 0x61E0 + 0x61E0, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                button13.Text = "ALL Max Points OFF";

            }
        }
        public struct StatsZM
        {
            public static UInt32
            Level = Prestige - 0x5E,
            Kill = Prestige + 0xAE,
            Liquid = Prestige + 0x9C,
            round_leaderboard = Prestige + 0x22E,
            Round_Survived = Prestige - 0x30,
            Unlock_Start = Prestige + 0x240,
            Lenght = 0x26C,
            HeadShots = Prestige - 0x4E,
            Average_Points = Prestige - 0x5A,
            Tag_Clan = Prestige + 0x430,
            GobbleName = 0x37DF0DD7,
            GobbleNameInterval = 0x16,
            Time_Played = Prestige - 0x24,
            tirseffectué = 0x37DDE6BC,
            tirsreussi = 0x37DDE6C2,
            porteouverte = 0x37DDE6B0,
            elimexplosif = 0x37DDE6AA,
            reanim = 0x37DDE698,
            distanceparcourue = 0x37DDE6B6,
            atoutbus = 0x37DDE69E;
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
        private void HenCMD(string Command)
        {
            this.Call2(0x5A657C, new object[]
            {
                0,
                Command + "\0"
            });
        }
        private void Button18_Click(object sender, EventArgs e)
        {
            if (henPS3 == true)
            {
                this.HenCMD("StatSetByName PLEVEL 35");
                this.HenCMD("StatSetByName LEVELXP 	1,457,200");
            }
            else
            {
                byte[] buffer = new byte[] { 0x21, 0x00, 0x00, 0x00 };
                PS3.GetMemory(StatsZM.Level, buffer);
            }
           
        }
        public struct WeaponsUnlockZM
        {
            public static UInt32
            L_Car_9 = 0x37DD5E3D,
            L_Car_9_Camo = L_Car_9 + 0x12,
            L_Car_9_Kill = L_Car_9 + 0xD,
            RK5 = 0x37DD5DBB,
            RK5_Camo = RK5 + 0x12,
            RK5_Kill = RK5 + 0xD,
            XM_53 = 0x37DD5DBB,
            XM_53_Camo = XM_53 + 0x12,
            XM_53_Kill = XM_53 + 0xD,
            Bowie = 0x37DD8F7F,
            Bowie_Camo = Bowie + 0x12,
            Bowie_Kill = Bowie + 0xD,
            DrakonKill = 0x37DD7189,
            DrakonKill_Camo = DrakonKill + 0x12,
            DrakonKill_Kill = DrakonKill + 0xD,
            VMP = 0x37DD63D3,
            VMP_Camo = VMP + 0x12,
            VMP_Kill = VMP + 0xD,
            Kuda = 0x37DD61CB,
            Kuda_Camo = Kuda + 0x12,
            Kuda_Kill = Kuda + 0xD,
            Vesper = 0x37DD62CF,
            Vesper_Camo = Vesper + 0x12,
            Vesper_Kill = Vesper + 0xD,
            Phara = 0x37DD624D,
            Phara_Camo = Phara + 0x12,
            Phara_Kill = Phara + 0xD,
            KN44 = 0x37DD66DF,
            KN44_Camo = KN44 + 0x12,
            KN44_Kill = KN44 + 0xD,
            ICR1 = 0x37DD6761,
            ICR1_Camo = ICR1 + 0x12,
            ICR1_Kill = ICR1 + 0xD,
            M8A1 = 0x37DD6969,
            M8A1_Camo = M8A1 + 0x12,
            M8A1_Kill = M8A1 + 0xD,
            Sheiva = 0x37DD69EB,
            Sheiva_Camo = Sheiva + 0x12,
            Sheiva_Kill = Sheiva + 0xD,
            HVK30 = 0x37DD67E3,
            HVK30_Camo = HVK30 + 0x12,
            HVK30_Kill = HVK30 + 0xD,
            BRM = 0x37DD6CF7,
            BRM_Camo = BRM + 0x12,
            BRM_Kill = BRM + 0xD,
            Dingo = 0x37DD6BF3,
            Dingo_Camo = Dingo + 0x12,
            Dingo_Kill = Dingo + 0xD,
            Dredge = 0x37DD6C75,
            Dredge_Camo = Dredge + 0x12,
            Dredge_kill = Dredge + 0xD,
            Gorgon = 0x37DD6D79,
            Gorgon_Camo = Gorgon + 0x12,
            Gorgon_Kill = Gorgon + 0xD,
            KRM62 = 0x37DD771F,
            KRM62_CamO = KRM62 + 0x12,
            KRM62_Kill = KRM62 + 0xD,
            Argus = 0x37DD769D,
            Argus_Camo = Argus + 0x12,
            Argus_Kill = Argus + 0xD,
            Brecci = 0x37DD77A1,
            Brecci_Camo = Brecci + 0x12,
            Brecci_Kill = Brecci + 0xD,
            HayMaker = 0x37DD761B,
            HayMaker_Camo = HayMaker + 0x12,
            HayMaker_Kill = HayMaker + 0xD,
            Locus = 0x37DD7107,
            Locus_Camo = Locus + 0x12,
            Locus_Kill = Locus + 0xD,
            SVG100 = 0x37DD720B,
            SVG100_Camo = SVG100 + 0x12,
            SVG100_Kill = SVG100 + 0xD,
            Weevil_Camo = 0x37DD6467,
            Weevil_Level = 0x37DD6455,
            XM53_Camo = 0x37DD7A3D,
            Man_of_war_Camo = 0x37DD6877,
            Man_of_ware_Level = 0x37DD6865;

        }
        public struct WeaponsZM
        {
            public static UInt32
            HeadshotsInterval = 0x1E,
            RK5Kills = Prestige - 0x8810,
            RK5Headshots = Prestige - 0x8810 + HeadshotsInterval,
            DrakonKill = Prestige - 0x7442,
            DrakonHeadshots = Prestige - 0x7442 + HeadshotsInterval,
            VMP = Prestige - 0x81F8,
            VMPHeadshots = VMP + HeadshotsInterval,
            Weevil = VMP + 0x82,
            WeevilHeadshots = Weevil + HeadshotsInterval,
            LCar9 = Prestige - 0x878E,
            LCar9Headshots = LCar9 + HeadshotsInterval,
            BowieKnife = Prestige - 0x564C,
            BowieKnifeHeadshots = BowieKnife + HeadshotsInterval,
            XM53 = Prestige - 0x6BA0,
            XM53Headshots = XM53 + HeadshotsInterval,
            Kuda = Prestige - 0x8400,
            KudaHeadshots = Kuda + HeadshotsInterval,
            Vesper = Prestige - 0x82FC,
            VesperHeadShots = Vesper + HeadshotsInterval,
            Phara = Prestige - 0x837E,
            PhroHeadshots = Phara + HeadshotsInterval,
            KN44 = Prestige - 0x7EEC,
            KN44Headshots = KN44 + HeadshotsInterval,
            ICR1 = Prestige - 0x7E6A,
            ICR1Headshots = ICR1 + HeadshotsInterval,
            M8A1 = Prestige - 0x7C62,
            M8A1Headshots = M8A1 + HeadshotsInterval,
            Sheiva = Prestige - 0x7BE0,
            SheivaHeadshots = Sheiva + HeadshotsInterval,
            HVK30 = Prestige - 0x7DE8,
            HVK30Headshots = HVK30 + HeadshotsInterval,
            ManOfWar = HVK30 + 0x82,
            ManOfWarHeadshots = ManOfWar + HeadshotsInterval,
            BRM = Prestige - 0x78D4,
            BRMHeadshots = BRM + HeadshotsInterval,
            Dingo = Prestige - 0x79D8,
            DingoHeadshots = Dingo + HeadshotsInterval,
            Dredge = Prestige - 0x7956,
            DredgeHeadshots = Dredge + HeadshotsInterval,
            Gorgon = Prestige - 0x7852,
            GorgonHeadshots = Gorgon + HeadshotsInterval,
            KRM262 = Prestige - 0x6EAC,
            KRM262Headshots = KRM262 + HeadshotsInterval,
            Argus = Prestige - 0x6F2E,
            ArgusHeadshots = Argus + HeadshotsInterval,
            Brecci = Prestige - 0x6E2A,
            BrecciHeadshots = Brecci + HeadshotsInterval,
            HayMaker = Prestige - 0x6FB0,
            HayMakerHeadshots = HayMaker + HeadshotsInterval,
            Locus = Prestige - 0x74C4,
            LocusHeadshots = Locus + HeadshotsInterval,
            SVG100 = Prestige - 0x73C0,
            SVG100Headshots = SVG100 + HeadshotsInterval;
        }
        private void Button17_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(0x37DDE818, Enumerable.Repeat((byte)0xff, 0x26C).ToArray());
            byte[] fuck = new byte[] { 0xff, 0xff, };
            PS3.SetMemory(0x37DDD102, fuck);
            PS3.SetMemory(0x37DDCEFA, fuck);
            PS3.SetMemory(0x37DDCF7C, fuck);
            PS3.SetMemory(0x37DDCD74, fuck);
            PS3.SetMemory(0x37DDCB6C, fuck);
            PS3.SetMemory(0x37DDCC70, fuck);
            PS3.SetMemory(0x37DDCBEE, fuck);
            PS3.SetMemory(0x37DDCAEA, fuck);
            PS3.SetMemory(0x37DDCA68, fuck);
            PS3.SetMemory(0x37DDCDF6, fuck);
            PS3.SetMemory(0x37DDD206, fuck);
            PS3.SetMemory(0x37DDD288, fuck);
            PS3.SetMemory(0x37DDD38C, fuck);
            PS3.SetMemory(0x37DDCCF2, fuck);
            PS3.SetMemory(0x37DDCE78, fuck);
            PS3.SetMemory(0x37DDCFFE, fuck);
            PS3.SetMemory(0x37DDD080, fuck);
            PS3.SetMemory(0x37DDD184, fuck);
            PS3.SetMemory(WeaponsUnlockZM.Weevil_Camo, fuck);
            PS3.SetMemory(WeaponsUnlockZM.Weevil_Level, fuck);
            PS3.SetMemory(WeaponsUnlockZM.Man_of_war_Camo, fuck);
            PS3.SetMemory(WeaponsUnlockZM.Man_of_ware_Level, fuck);
            PS3.SetMemory(WeaponsUnlockZM.XM53_Camo, fuck);
            PS3.SetMemory(WeaponsUnlockZM.Argus, fuck);
            PS3.SetMemory(WeaponsUnlockZM.Argus_Camo, fuck);
            PS3.SetMemory(WeaponsUnlockZM.Bowie, fuck);
            PS3.SetMemory(WeaponsUnlockZM.Bowie_Camo, fuck);
            PS3.SetMemory(WeaponsUnlockZM.Brecci, fuck);
            PS3.SetMemory(WeaponsUnlockZM.Brecci_Camo, fuck);
            PS3.SetMemory(WeaponsUnlockZM.BRM, fuck);
            PS3.SetMemory(WeaponsUnlockZM.BRM_Camo, fuck);
            PS3.SetMemory(WeaponsUnlockZM.Dingo, fuck);
            PS3.SetMemory(WeaponsUnlockZM.Dingo_Camo, fuck);
            PS3.SetMemory(WeaponsUnlockZM.DrakonKill, fuck);
            PS3.SetMemory(WeaponsUnlockZM.DrakonKill_Camo, fuck);
            PS3.SetMemory(WeaponsUnlockZM.Dredge, fuck);
            PS3.SetMemory(WeaponsUnlockZM.Dredge_Camo, fuck);
            PS3.SetMemory(WeaponsUnlockZM.Gorgon, fuck);
            PS3.SetMemory(WeaponsUnlockZM.Gorgon_Camo, fuck);
            PS3.SetMemory(WeaponsUnlockZM.HayMaker, fuck);
            PS3.SetMemory(WeaponsUnlockZM.HayMaker_Camo, fuck);
            PS3.SetMemory(WeaponsUnlockZM.HVK30, fuck);
            PS3.SetMemory(WeaponsUnlockZM.HVK30_Camo, fuck);
            PS3.SetMemory(WeaponsUnlockZM.ICR1, fuck);
            PS3.SetMemory(WeaponsUnlockZM.ICR1_Camo, fuck);
            PS3.SetMemory(WeaponsUnlockZM.KN44, fuck);
            PS3.SetMemory(WeaponsUnlockZM.KN44_Camo, fuck);
            PS3.SetMemory(WeaponsUnlockZM.KRM62, fuck);
            PS3.SetMemory(WeaponsUnlockZM.KRM62_CamO, fuck);
            PS3.SetMemory(WeaponsUnlockZM.Kuda, fuck);
            PS3.SetMemory(WeaponsUnlockZM.Kuda_Camo, fuck);
            PS3.SetMemory(WeaponsUnlockZM.L_Car_9, fuck);
            PS3.SetMemory(WeaponsUnlockZM.L_Car_9_Camo, fuck);
            PS3.SetMemory(WeaponsUnlockZM.Locus, fuck);
            PS3.SetMemory(WeaponsUnlockZM.Locus_Camo, fuck);
            PS3.SetMemory(WeaponsUnlockZM.M8A1, fuck);
            PS3.SetMemory(WeaponsUnlockZM.M8A1_Camo, fuck);
            PS3.SetMemory(WeaponsUnlockZM.Phara, fuck);
            PS3.SetMemory(WeaponsUnlockZM.Phara_Camo, fuck);
            PS3.SetMemory(WeaponsUnlockZM.RK5, fuck);
            PS3.SetMemory(WeaponsUnlockZM.RK5_Camo, fuck);
            PS3.SetMemory(WeaponsUnlockZM.Sheiva, fuck);
            PS3.SetMemory(WeaponsUnlockZM.Sheiva_Camo, fuck);
            PS3.SetMemory(WeaponsUnlockZM.SVG100, fuck);
            PS3.SetMemory(WeaponsUnlockZM.SVG100_Camo, fuck);
            PS3.SetMemory(WeaponsUnlockZM.Vesper, fuck);
            PS3.SetMemory(WeaponsUnlockZM.Vesper_Camo, fuck);
            PS3.SetMemory(WeaponsUnlockZM.VMP, fuck);
            PS3.SetMemory(WeaponsUnlockZM.VMP_Camo, fuck);
            PS3.SetMemory(WeaponsUnlockZM.XM_53, fuck);
            PS3.SetMemory(WeaponsUnlockZM.XM_53_Camo, fuck);
            PS3.SetMemory(WeaponsUnlockZM.XM_53_Kill, fuck);
            PS3.SetMemory(WeaponsUnlockZM.Weevil_Camo, fuck);
            PS3.SetMemory(WeaponsUnlockZM.Weevil_Level, fuck);
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(Prestige, BitConverter.GetBytes((int)firefoxNumericUpDown1.Value));
            PS3.SetMemory(StatsZM.Kill, BitConverter.GetBytes((int)firefoxNumericUpDown3.Value));
            PS3.SetMemory(StatsZM.Liquid, BitConverter.GetBytes((int)firefoxNumericUpDown4.Value));
            PS3.SetMemory(StatsZM.Round_Survived, BitConverter.GetBytes((int)firefoxNumericUpDown5.Value));
            PS3.SetMemory(StatsZM.HeadShots, BitConverter.GetBytes((int)firefoxNumericUpDown7.Value));
            PS3.SetMemory(StatsZM.Average_Points, BitConverter.GetBytes((int)firefoxNumericUpDown6.Value));
            PS3.SetMemory(StatsZM.round_leaderboard, BitConverter.GetBytes((int)firefoxNumericUpDown8.Value));
            PS3.SetMemory(StatsZM.tirsreussi, BitConverter.GetBytes((int)logInNumeric27.Value));
            PS3.SetMemory(StatsZM.porteouverte, BitConverter.GetBytes((int)logInNumeric28.Value));
            PS3.SetMemory(StatsZM.reanim, BitConverter.GetBytes((int)logInNumeric29.Value));
            PS3.SetMemory(StatsZM.distanceparcourue, BitConverter.GetBytes((int)logInNumeric30.Value));
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[4];
            PS3.GetMemory(Prestige, buffer);
            firefoxNumericUpDown1.Value = BitConverter.ToInt32(buffer, 0);



            byte[] buffer8 = new byte[4];
            PS3.GetMemory(StatsZM.Kill, buffer8);
            firefoxNumericUpDown3.Value = BitConverter.ToInt32(buffer8, 0);

            byte[] buffer9 = new byte[4];
            PS3.GetMemory(StatsZM.Liquid, buffer9);
            firefoxNumericUpDown4.Value = BitConverter.ToInt32(buffer9, 0);

            byte[] buffer7 = new byte[4];
            PS3.GetMemory(StatsZM.Round_Survived, buffer7);
            firefoxNumericUpDown5.Value = BitConverter.ToInt32(buffer7, 0);

            byte[] buffer12 = new byte[4];
            PS3.GetMemory(StatsZM.HeadShots, buffer12);
            firefoxNumericUpDown6.Value = BitConverter.ToInt32(buffer12, 0);

            byte[] buffer10 = new byte[4];
            PS3.GetMemory(StatsZM.Average_Points, buffer10);
            firefoxNumericUpDown7.Value = BitConverter.ToInt32(buffer10, 0);

            byte[] buffer19 = new byte[4];
            PS3.GetMemory(StatsZM.tirsreussi, buffer19);
            logInNumeric27.Value = BitConverter.ToInt32(buffer19, 0);

            byte[] buffer13 = new byte[4];
            PS3.GetMemory(StatsZM.porteouverte, buffer13);
            logInNumeric28.Value = BitConverter.ToInt32(buffer13, 0);

            byte[] buffer14 = new byte[4];
            PS3.GetMemory(StatsZM.reanim, buffer14);
            logInNumeric29.Value = BitConverter.ToInt32(buffer14, 0);

            byte[] buffer15 = new byte[4];
            PS3.GetMemory(StatsZM.distanceparcourue, buffer15);
            logInNumeric30.Value = BitConverter.ToInt32(buffer15, 0);
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            Random randNum = new Random();
            firefoxNumericUpDown1.Value = randNum.Next(0, 11);
            firefoxNumericUpDown3.Value = randNum.Next(1, 100000);
            firefoxNumericUpDown4.Value = randNum.Next(1, 100000);
            firefoxNumericUpDown5.Value = randNum.Next(1, 100000);
            firefoxNumericUpDown6.Value = randNum.Next(1, 100000);
            firefoxNumericUpDown7.Value = randNum.Next(1, 100000);
            firefoxNumericUpDown10.Value = randNum.Next(0, 55);
            firefoxNumericUpDown9.Value = randNum.Next(0, 24);
            firefoxNumericUpDown11.Value = randNum.Next(0, 60);
            logInNumeric27.Value = randNum.Next(1, 100000);
            logInNumeric28.Value = randNum.Next(1, 100000);
            logInNumeric29.Value = randNum.Next(1, 100000);
            logInNumeric30.Value = randNum.Next(1, 100000);
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = PS3.Extension.ReadString(StatsZM.GobbleName);
            textBox2.Text = PS3.Extension.ReadString(StatsZM.GobbleName + StatsZM.GobbleNameInterval);
            textBox3.Text = PS3.Extension.ReadString(StatsZM.GobbleName + StatsZM.GobbleNameInterval + StatsZM.GobbleNameInterval);
            textBox4.Text = PS3.Extension.ReadString(StatsZM.GobbleName + StatsZM.GobbleNameInterval + StatsZM.GobbleNameInterval + StatsZM.GobbleNameInterval);
            textBox5.Text = PS3.Extension.ReadString(StatsZM.GobbleName + StatsZM.GobbleNameInterval + StatsZM.GobbleNameInterval + StatsZM.GobbleNameInterval + StatsZM.GobbleNameInterval);
            textBox10.Text = PS3.Extension.ReadString(StatsZM.GobbleName + StatsZM.GobbleNameInterval + StatsZM.GobbleNameInterval + StatsZM.GobbleNameInterval + StatsZM.GobbleNameInterval + StatsZM.GobbleNameInterval);
            textBox9.Text = PS3.Extension.ReadString(StatsZM.GobbleName + StatsZM.GobbleNameInterval + StatsZM.GobbleNameInterval + StatsZM.GobbleNameInterval + StatsZM.GobbleNameInterval + StatsZM.GobbleNameInterval + StatsZM.GobbleNameInterval);
            textBox8.Text = PS3.Extension.ReadString(StatsZM.GobbleName + StatsZM.GobbleNameInterval + StatsZM.GobbleNameInterval + StatsZM.GobbleNameInterval + StatsZM.GobbleNameInterval + StatsZM.GobbleNameInterval + StatsZM.GobbleNameInterval + StatsZM.GobbleNameInterval);
            textBox7.Text = PS3.Extension.ReadString(StatsZM.GobbleName + StatsZM.GobbleNameInterval + StatsZM.GobbleNameInterval + StatsZM.GobbleNameInterval + StatsZM.GobbleNameInterval + StatsZM.GobbleNameInterval + StatsZM.GobbleNameInterval + StatsZM.GobbleNameInterval + StatsZM.GobbleNameInterval);
            textBox6.Text = PS3.Extension.ReadString(StatsZM.GobbleName + StatsZM.GobbleNameInterval + StatsZM.GobbleNameInterval + StatsZM.GobbleNameInterval + StatsZM.GobbleNameInterval + StatsZM.GobbleNameInterval + StatsZM.GobbleNameInterval + StatsZM.GobbleNameInterval + StatsZM.GobbleNameInterval + StatsZM.GobbleNameInterval);
        }

        private void Button268_Click(object sender, EventArgs e)
        {
            classnamepre.DroppedDown = true;
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            if (classnamepre.Text == "RK5")
            {
                PS3.SetMemory(WeaponsZM.RK5Kills, BitConverter.GetBytes((int)killweapzm.Value));
                PS3.SetMemory(WeaponsZM.RK5Headshots, BitConverter.GetBytes((int)headshotsweapzm.Value));
            }
            else if (classnamepre.Text == "DRAKON")
            {
                PS3.SetMemory(WeaponsZM.DrakonKill, BitConverter.GetBytes((int)killweapzm.Value));
                PS3.SetMemory(WeaponsZM.DrakonHeadshots, BitConverter.GetBytes((int)headshotsweapzm.Value));
            }
            else if (classnamepre.Text == "VMP")
            {
                PS3.SetMemory(WeaponsZM.VMP, BitConverter.GetBytes((int)killweapzm.Value));
                PS3.SetMemory(WeaponsZM.VMPHeadshots, BitConverter.GetBytes((int)headshotsweapzm.Value));
            }
            else if (classnamepre.Text == "LCAR9")
            {
                PS3.SetMemory(WeaponsZM.LCar9, BitConverter.GetBytes((int)killweapzm.Value));
                PS3.SetMemory(WeaponsZM.LCar9Headshots, BitConverter.GetBytes((int)headshotsweapzm.Value));
            }
            else if (classnamepre.Text == "BOWIEKNIFE")
            {
                PS3.SetMemory(WeaponsZM.BowieKnife, BitConverter.GetBytes((int)killweapzm.Value));
                PS3.SetMemory(WeaponsZM.BowieKnifeHeadshots, BitConverter.GetBytes((int)headshotsweapzm.Value));
            }
            else if (classnamepre.Text == "XM53")
            {
                PS3.SetMemory(WeaponsZM.XM53, BitConverter.GetBytes((int)killweapzm.Value));
                PS3.SetMemory(WeaponsZM.XM53Headshots, BitConverter.GetBytes((int)headshotsweapzm.Value));
            }
            else if (classnamepre.Text == "KUDA")
            {
                PS3.SetMemory(WeaponsZM.Kuda, BitConverter.GetBytes((int)killweapzm.Value));
                PS3.SetMemory(WeaponsZM.KudaHeadshots, BitConverter.GetBytes((int)headshotsweapzm.Value));
            }
            else if (classnamepre.Text == "VESPER")
            {
                PS3.SetMemory(WeaponsZM.Vesper, BitConverter.GetBytes((int)killweapzm.Value));
                PS3.SetMemory(WeaponsZM.VesperHeadShots, BitConverter.GetBytes((int)headshotsweapzm.Value));
            }
            else if (classnamepre.Text == "PHARO")
            {
                PS3.SetMemory(WeaponsZM.Phara, BitConverter.GetBytes((int)killweapzm.Value));
                PS3.SetMemory(WeaponsZM.PhroHeadshots, BitConverter.GetBytes((int)headshotsweapzm.Value));
            }
            else if (classnamepre.Text == "KN44")
            {
                PS3.SetMemory(WeaponsZM.KN44, BitConverter.GetBytes((int)killweapzm.Value));
                PS3.SetMemory(WeaponsZM.KN44Headshots, BitConverter.GetBytes((int)headshotsweapzm.Value));
            }
            else if (classnamepre.Text == "ICR1")
            {
                PS3.SetMemory(WeaponsZM.ICR1, BitConverter.GetBytes((int)killweapzm.Value));
                PS3.SetMemory(WeaponsZM.ICR1Headshots, BitConverter.GetBytes((int)headshotsweapzm.Value));
            }
            else if (classnamepre.Text == "M8A1")
            {
                PS3.SetMemory(WeaponsZM.BowieKnife, BitConverter.GetBytes((int)killweapzm.Value));
                PS3.SetMemory(WeaponsZM.BowieKnifeHeadshots, BitConverter.GetBytes((int)headshotsweapzm.Value));
            }
            else if (classnamepre.Text == "SHEIVA")
            {
                PS3.SetMemory(WeaponsZM.Sheiva, BitConverter.GetBytes((int)killweapzm.Value));
                PS3.SetMemory(WeaponsZM.SheivaHeadshots, BitConverter.GetBytes((int)headshotsweapzm.Value));
            }
            else if (classnamepre.Text == "HVK30")
            {
                PS3.SetMemory(WeaponsZM.HVK30, BitConverter.GetBytes((int)killweapzm.Value));
                PS3.SetMemory(WeaponsZM.HVK30Headshots, BitConverter.GetBytes((int)headshotsweapzm.Value));
            }
            else if (classnamepre.Text == "BRM")
            {
                PS3.SetMemory(WeaponsZM.BRM, BitConverter.GetBytes((int)killweapzm.Value));
                PS3.SetMemory(WeaponsZM.BRMHeadshots, BitConverter.GetBytes((int)headshotsweapzm.Value));
            }
            else if (classnamepre.Text == "DINGO")
            {
                PS3.SetMemory(WeaponsZM.Dingo, BitConverter.GetBytes((int)killweapzm.Value));
                PS3.SetMemory(WeaponsZM.DingoHeadshots, BitConverter.GetBytes((int)headshotsweapzm.Value));
            }
            else if (classnamepre.Text == "GORGON")
            {
                PS3.SetMemory(WeaponsZM.Gorgon, BitConverter.GetBytes((int)killweapzm.Value));
                PS3.SetMemory(WeaponsZM.GorgonHeadshots, BitConverter.GetBytes((int)headshotsweapzm.Value));
            }
            else if (classnamepre.Text == "KRM262")
            {
                PS3.SetMemory(WeaponsZM.KRM262, BitConverter.GetBytes((int)killweapzm.Value));
                PS3.SetMemory(WeaponsZM.KRM262Headshots, BitConverter.GetBytes((int)headshotsweapzm.Value));
            }
            else if (classnamepre.Text == "ARGUS")
            {
                PS3.SetMemory(WeaponsZM.Argus, BitConverter.GetBytes((int)killweapzm.Value));
                PS3.SetMemory(WeaponsZM.ArgusHeadshots, BitConverter.GetBytes((int)headshotsweapzm.Value));
            }
            else if (classnamepre.Text == "BRECCI")
            {
                PS3.SetMemory(WeaponsZM.Brecci, BitConverter.GetBytes((int)killweapzm.Value));
                PS3.SetMemory(WeaponsZM.BrecciHeadshots, BitConverter.GetBytes((int)headshotsweapzm.Value));
            }
            else if (classnamepre.Text == "HAYMAKER12")
            {
                PS3.SetMemory(WeaponsZM.HayMaker, BitConverter.GetBytes((int)killweapzm.Value));
                PS3.SetMemory(WeaponsZM.HayMakerHeadshots, BitConverter.GetBytes((int)headshotsweapzm.Value));
            }
            else if (classnamepre.Text == "LOCUS")
            {
                PS3.SetMemory(WeaponsZM.Locus, BitConverter.GetBytes((int)killweapzm.Value));
                PS3.SetMemory(WeaponsZM.LocusHeadshots, BitConverter.GetBytes((int)headshotsweapzm.Value));
            }
            else if (classnamepre.Text == "SVG100")
            {
                PS3.SetMemory(WeaponsZM.SVG100, BitConverter.GetBytes((int)killweapzm.Value));
                PS3.SetMemory(WeaponsZM.SVG100Headshots, BitConverter.GetBytes((int)headshotsweapzm.Value));
            }
            else if (classnamepre.Text == "WEEVIL")
            {
                PS3.SetMemory(WeaponsZM.Weevil, BitConverter.GetBytes((int)killweapzm.Value));
                PS3.SetMemory(WeaponsZM.WeevilHeadshots, BitConverter.GetBytes((int)headshotsweapzm.Value));
            }
            else if (classnamepre.Text == "MANOWAR")
            {
                PS3.SetMemory(WeaponsZM.ManOfWar, BitConverter.GetBytes((int)killweapzm.Value));
                PS3.SetMemory(WeaponsZM.ManOfWarHeadshots, BitConverter.GetBytes((int)headshotsweapzm.Value));
            }
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In Rebug Toolbox : \n-System Mode : REBUG\n-XMB Operation Mode : DEBUG\n-Debug Menu Type : DEX\n-Cobra Mode : Enable\n\nIn Debug Settings\n-Release Check Mode : Development Mode\n-Boot Mode : System Software Mode\n-Network Settings for Debug : Single Settings", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public struct GobbleGumStats
        {
            public static UInt32
            Alchemical_Antithesis = Prestige - 0x22D8,
            Always_done_swiftly = Prestige - 0x2256,
            anywhere_but_here = Prestige - 0x2256 + 0x82,
            armamental_accomplishment = anywhere_but_here + 0x82,
            arms_grace = Prestige - 0x2256 + 0x82 + 0x82 + 0x82,
            arsenal_accelerator = Prestige - 0x2256 + 0x82 + 0x82 + 0x82 + 0x82,
            coagulant = Prestige - 0x2256 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82,
            danger_closest = Prestige - 0x2256 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82,
            firing_on_all_cylinders = Prestige - 0x2256 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82,
            impatient = Prestige - 0x2256 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82,
            in_plain_sight = Prestige - 0x2256 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82,
            lucky_crit = Prestige - 0x2256 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82,
            now_you_see_me = Prestige - 0x2256 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82,
            stock_option = Prestige - 0x2256 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82,
            sword_flay = Prestige - 0x2256 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82,
            aftertaste = Prestige - 0x2256 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82,
            burned_out = Prestige - 0x2256 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82,
            cache_back = Prestige - 0x2256 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82,
            dead_of_nuclear_winter = Prestige - 0x2256 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82,
            ephemeral_enhancement = Prestige - 0x2256 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82,
            im_feeling_lucky = Prestige - 0x2256 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82,
            immolation_liquidation = Prestige - 0x2256 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82,
            kill_joy = Prestige - 0x2256 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82,
            killing_time = Prestige - 0x2256 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82,
            licenced_contractor = Prestige - 0x2256 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82,
            on_the_house = Prestige - 0x2256 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82,
            perkaholic = Prestige - 0x2256 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82,
            phoenix_up = Prestige - 0x2256 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82,
            pop_shocks = Prestige - 0x2256 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82,
            respin_cycle = Prestige - 0x2256 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82,
            unquenchable = Prestige - 0x2256 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82,
            wall_power = Prestige - 0x2256 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82,
            whos_keeping_score = Prestige - 0x2256 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82,
            crawl_space = Prestige - 0x2256 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82,
            fatal_contraption = Prestige - 0x2256 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82,
            head_drama = Prestige - 0x2256 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82,
            undead_man_walking = Prestige - 0x2256 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82 + 0x82;
        }
        private void Button23_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(GobbleGumStats.aftertaste, BitConverter.GetBytes((int)usegobblezm.Value));
            PS3.SetMemory(GobbleGumStats.Alchemical_Antithesis, BitConverter.GetBytes((int)usegobblezm.Value));
            PS3.SetMemory(GobbleGumStats.Always_done_swiftly, BitConverter.GetBytes((int)usegobblezm.Value));
            PS3.SetMemory(GobbleGumStats.anywhere_but_here, BitConverter.GetBytes((int)usegobblezm.Value));
            PS3.SetMemory(GobbleGumStats.armamental_accomplishment, BitConverter.GetBytes((int)usegobblezm.Value));
            PS3.SetMemory(GobbleGumStats.arms_grace, BitConverter.GetBytes((int)usegobblezm.Value));
            PS3.SetMemory(GobbleGumStats.arsenal_accelerator, BitConverter.GetBytes((int)usegobblezm.Value));
            PS3.SetMemory(GobbleGumStats.burned_out, BitConverter.GetBytes((int)usegobblezm.Value));
            PS3.SetMemory(GobbleGumStats.cache_back, BitConverter.GetBytes((int)usegobblezm.Value));
            PS3.SetMemory(GobbleGumStats.coagulant, BitConverter.GetBytes((int)usegobblezm.Value));
            PS3.SetMemory(GobbleGumStats.crawl_space, BitConverter.GetBytes((int)usegobblezm.Value));
            PS3.SetMemory(GobbleGumStats.danger_closest, BitConverter.GetBytes((int)usegobblezm.Value));
            PS3.SetMemory(GobbleGumStats.dead_of_nuclear_winter, BitConverter.GetBytes((int)usegobblezm.Value));
            PS3.SetMemory(GobbleGumStats.ephemeral_enhancement, BitConverter.GetBytes((int)usegobblezm.Value));
            PS3.SetMemory(GobbleGumStats.fatal_contraption, BitConverter.GetBytes((int)usegobblezm.Value));
            PS3.SetMemory(GobbleGumStats.firing_on_all_cylinders, BitConverter.GetBytes((int)usegobblezm.Value));
            PS3.SetMemory(GobbleGumStats.head_drama, BitConverter.GetBytes((int)usegobblezm.Value));
            PS3.SetMemory(GobbleGumStats.im_feeling_lucky, BitConverter.GetBytes((int)usegobblezm.Value));
            PS3.SetMemory(GobbleGumStats.immolation_liquidation, BitConverter.GetBytes((int)usegobblezm.Value));
            PS3.SetMemory(GobbleGumStats.impatient, BitConverter.GetBytes((int)usegobblezm.Value));
            PS3.SetMemory(GobbleGumStats.in_plain_sight, BitConverter.GetBytes((int)usegobblezm.Value));
            PS3.SetMemory(GobbleGumStats.kill_joy, BitConverter.GetBytes((int)usegobblezm.Value));
            PS3.SetMemory(GobbleGumStats.killing_time, BitConverter.GetBytes((int)usegobblezm.Value));
            PS3.SetMemory(GobbleGumStats.licenced_contractor, BitConverter.GetBytes((int)usegobblezm.Value));
            PS3.SetMemory(GobbleGumStats.lucky_crit, BitConverter.GetBytes((int)usegobblezm.Value));
            PS3.SetMemory(GobbleGumStats.now_you_see_me, BitConverter.GetBytes((int)usegobblezm.Value));
            PS3.SetMemory(GobbleGumStats.on_the_house, BitConverter.GetBytes((int)usegobblezm.Value));
            PS3.SetMemory(GobbleGumStats.perkaholic, BitConverter.GetBytes((int)usegobblezm.Value));
            PS3.SetMemory(GobbleGumStats.phoenix_up, BitConverter.GetBytes((int)usegobblezm.Value));
            PS3.SetMemory(GobbleGumStats.pop_shocks, BitConverter.GetBytes((int)usegobblezm.Value));
            PS3.SetMemory(GobbleGumStats.respin_cycle, BitConverter.GetBytes((int)usegobblezm.Value));
            PS3.SetMemory(GobbleGumStats.stock_option, BitConverter.GetBytes((int)usegobblezm.Value));
            PS3.SetMemory(GobbleGumStats.sword_flay, BitConverter.GetBytes((int)usegobblezm.Value));
            PS3.SetMemory(GobbleGumStats.undead_man_walking, BitConverter.GetBytes((int)usegobblezm.Value));
            PS3.SetMemory(GobbleGumStats.unquenchable, BitConverter.GetBytes((int)usegobblezm.Value));
            PS3.SetMemory(GobbleGumStats.wall_power, BitConverter.GetBytes((int)usegobblezm.Value));
            PS3.SetMemory(GobbleGumStats.whos_keeping_score, BitConverter.GetBytes((int)usegobblezm.Value));
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            if (gobblegumzm.SelectedIndex == 0)
            {
                PS3.SetMemory(GobbleGumStats.aftertaste, BitConverter.GetBytes((int)usegobblezm.Value));
            }
            if (gobblegumzm.SelectedIndex == 1)
            {
                PS3.SetMemory(GobbleGumStats.Alchemical_Antithesis, BitConverter.GetBytes((int)usegobblezm.Value));
            }
            if (gobblegumzm.SelectedIndex == 2)
            {
                PS3.SetMemory(GobbleGumStats.Always_done_swiftly, BitConverter.GetBytes((int)usegobblezm.Value));
            }
            if (gobblegumzm.SelectedIndex == 3)
            {
                PS3.SetMemory(GobbleGumStats.anywhere_but_here, BitConverter.GetBytes((int)usegobblezm.Value));
            }
            if (gobblegumzm.SelectedIndex == 4)
            {
                PS3.SetMemory(GobbleGumStats.armamental_accomplishment, BitConverter.GetBytes((int)usegobblezm.Value));
            }
            if (gobblegumzm.SelectedIndex == 5)
            {
                PS3.SetMemory(GobbleGumStats.arms_grace, BitConverter.GetBytes((int)usegobblezm.Value));
            }
            if (gobblegumzm.SelectedIndex == 6)
            {
                PS3.SetMemory(GobbleGumStats.arsenal_accelerator, BitConverter.GetBytes((int)usegobblezm.Value));
            }
            if (gobblegumzm.SelectedIndex == 7)
            {
                PS3.SetMemory(GobbleGumStats.burned_out, BitConverter.GetBytes((int)usegobblezm.Value));
            }
            if (gobblegumzm.SelectedIndex == 8)
            {
                PS3.SetMemory(GobbleGumStats.cache_back, BitConverter.GetBytes((int)usegobblezm.Value));
            }
            if (gobblegumzm.SelectedIndex == 9)
            {
                PS3.SetMemory(GobbleGumStats.coagulant, BitConverter.GetBytes((int)usegobblezm.Value));
            }
            if (gobblegumzm.SelectedIndex == 10)
            {
                PS3.SetMemory(GobbleGumStats.crawl_space, BitConverter.GetBytes((int)usegobblezm.Value));
            }
            if (gobblegumzm.SelectedIndex == 11)
            {
                PS3.SetMemory(GobbleGumStats.danger_closest, BitConverter.GetBytes((int)usegobblezm.Value));
            }
            if (gobblegumzm.SelectedIndex == 12)
            {
                PS3.SetMemory(GobbleGumStats.dead_of_nuclear_winter, BitConverter.GetBytes((int)usegobblezm.Value));
            }
            if (gobblegumzm.SelectedIndex == 13)
            {
                PS3.SetMemory(GobbleGumStats.ephemeral_enhancement, BitConverter.GetBytes((int)usegobblezm.Value));
            }
            if (gobblegumzm.SelectedIndex == 14)
            {
                PS3.SetMemory(GobbleGumStats.fatal_contraption, BitConverter.GetBytes((int)usegobblezm.Value));
            }
            if (gobblegumzm.SelectedIndex == 15)
            {
                PS3.SetMemory(GobbleGumStats.firing_on_all_cylinders, BitConverter.GetBytes((int)usegobblezm.Value));
            }
            if (gobblegumzm.SelectedIndex == 16)
            {
                PS3.SetMemory(GobbleGumStats.head_drama, BitConverter.GetBytes((int)usegobblezm.Value));
            }
            if (gobblegumzm.SelectedIndex == 17)
            {
                PS3.SetMemory(GobbleGumStats.im_feeling_lucky, BitConverter.GetBytes((int)usegobblezm.Value));
            }
            if (gobblegumzm.SelectedIndex == 18)
            {
                PS3.SetMemory(GobbleGumStats.immolation_liquidation, BitConverter.GetBytes((int)usegobblezm.Value));
            }
            if (gobblegumzm.SelectedIndex == 19)
            {
                PS3.SetMemory(GobbleGumStats.impatient, BitConverter.GetBytes((int)usegobblezm.Value));
            }
            if (gobblegumzm.SelectedIndex == 20)
            {
                PS3.SetMemory(GobbleGumStats.in_plain_sight, BitConverter.GetBytes((int)usegobblezm.Value));
            }
            if (gobblegumzm.SelectedIndex == 21)
            {
                PS3.SetMemory(GobbleGumStats.kill_joy, BitConverter.GetBytes((int)usegobblezm.Value));
            }
            if (gobblegumzm.SelectedIndex == 22)
            {
                PS3.SetMemory(GobbleGumStats.killing_time, BitConverter.GetBytes((int)usegobblezm.Value));
            }
            if (gobblegumzm.SelectedIndex == 23)
            {
                PS3.SetMemory(GobbleGumStats.licenced_contractor, BitConverter.GetBytes((int)usegobblezm.Value));
            }
            if (gobblegumzm.SelectedIndex == 24)
            {
                PS3.SetMemory(GobbleGumStats.lucky_crit, BitConverter.GetBytes((int)usegobblezm.Value));
            }
            if (gobblegumzm.SelectedIndex == 25)
            {
                PS3.SetMemory(GobbleGumStats.now_you_see_me, BitConverter.GetBytes((int)usegobblezm.Value));
            }
            if (gobblegumzm.SelectedIndex == 26)
            {
                PS3.SetMemory(GobbleGumStats.on_the_house, BitConverter.GetBytes((int)usegobblezm.Value));
            }
            if (gobblegumzm.SelectedIndex == 27)
            {
                PS3.SetMemory(GobbleGumStats.perkaholic, BitConverter.GetBytes((int)usegobblezm.Value));
            }
            if (gobblegumzm.SelectedIndex == 28)
            {
                PS3.SetMemory(GobbleGumStats.phoenix_up, BitConverter.GetBytes((int)usegobblezm.Value));
            }
            if (gobblegumzm.SelectedIndex == 299)
            {
                PS3.SetMemory(GobbleGumStats.pop_shocks, BitConverter.GetBytes((int)usegobblezm.Value));
            }
            if (gobblegumzm.SelectedIndex == 30)
            {
                PS3.SetMemory(GobbleGumStats.respin_cycle, BitConverter.GetBytes((int)usegobblezm.Value));
            }
            if (gobblegumzm.SelectedIndex == 31)
            {
                PS3.SetMemory(GobbleGumStats.stock_option, BitConverter.GetBytes((int)usegobblezm.Value));
            }
            if (gobblegumzm.SelectedIndex == 32)
            {
                PS3.SetMemory(GobbleGumStats.sword_flay, BitConverter.GetBytes((int)usegobblezm.Value));
            }
            if (gobblegumzm.SelectedIndex == 33)
            {
                PS3.SetMemory(GobbleGumStats.undead_man_walking, BitConverter.GetBytes((int)usegobblezm.Value));
            }
            if (gobblegumzm.SelectedIndex == 34)
            {
                PS3.SetMemory(GobbleGumStats.unquenchable, BitConverter.GetBytes((int)usegobblezm.Value));
            }
            if (gobblegumzm.SelectedIndex == 35)
            {
                PS3.SetMemory(GobbleGumStats.wall_power, BitConverter.GetBytes((int)usegobblezm.Value));
            }
            if (gobblegumzm.SelectedIndex == 36)
            {
                PS3.SetMemory(GobbleGumStats.whos_keeping_score, BitConverter.GetBytes((int)usegobblezm.Value));
            }
        }
        private void button26_Click(object sender, EventArgs e)
        {
            this.HenCMD("StatSetByName PLEVEL 35");
            this.HenCMD("StatSetByName LEVELXP 	1,457,200");
        }

        private void firefoxNumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            this.HenCMD("StatSetByName PLEVEL 35");
            this.HenCMD("StatSetByName LEVELXP 	1,457,200");
        }
    }
}

