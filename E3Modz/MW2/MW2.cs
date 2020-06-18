using E3Modz.Login___Home;
using Furious_V2_NEW;
using PS3Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace E3Modz.Black_Ops_2
{
    public partial class MW2 : Form
    {
        public static System.Drawing.Point newpoint = new System.Drawing.Point();
        public static string Username;
        public static string Password;
        public static int x;
        private bool[] aimbotVerified;
        private static bool AdvCheck1ON = true;
        private bool runAimbot;
        private static bool CheckGame = true;
        private static bool AdvCheck1OFF = true;
        private bool isInGame = true;
        public static int y;
        private string aimbotMethod;
        public static PS3API PS3 = new PS3API(SelectAPI.ControlConsole);
        public static PS3ManagerAPI.PS3MAPI PS3M_API = new PS3ManagerAPI.PS3MAPI();
        CCAPI PS43 = new CCAPI();
        private const int WS_MINIMIZEBOX = 131072;
        private const int CS_DBLCLKS = 8;
        private bool setOnce = true;

        // Token: 0x0400001E RID: 30
        private ColorDialog themeBox = new ColorDialog();

        // Token: 0x0400001F RID: 31
        public static Color selectedTheme = Color.FromArgb(255, 10, 10);

        // Token: 0x04000020 RID: 32
        public static Color selectedTabColor = Color.FromArgb(30, 30, 30);

        // Token: 0x04000021 RID: 33
        private int[] toolRGB;

        // Token: 0x04000022 RID: 34
        private int aFtog;
        private bool useAuto;

        // Token: 0x04000026 RID: 38
        private string[] cardT;

        // Token: 0x04000027 RID: 39
        private string[] cardI;

        // Token: 0x04000028 RID: 40
        private uint nameOfs;

        // Token: 0x04000029 RID: 41
        private byte[] nameVal;

        // Token: 0x0400002A RID: 42
        private string[] nameButtons;

        // Token: 0x0400002B RID: 43
        private string verticalN;

        // Token: 0x0400002C RID: 44
        private int slideInt;

        // Token: 0x0400002D RID: 45
        private uint prgOfs;

        // Token: 0x0400002E RID: 46
        private uint lvlOfs;

        // Token: 0x0400002F RID: 47
        private int lvlNum;

        // Token: 0x04000030 RID: 48
        private int prgNum;

        // Token: 0x04000031 RID: 49
        private int[] levels;

        // Token: 0x04000032 RID: 50
        private string[] onlineOrOffline;

        // Token: 0x04000033 RID: 51
        private string[] changeMap;

        // Token: 0x04000034 RID: 52
        private string[] changeGametype;

        // Token: 0x04000035 RID: 53
        private ColorDialog visionRGB;

        // Token: 0x04000036 RID: 54
        private int[] visionInt;

        // Token: 0x04000037 RID: 55
        private Random visionR;

        // Token: 0x04000038 RID: 56
        private ColorDialog scoreRGB;

        // Token: 0x04000039 RID: 57
        private int[] scoreInt;

        // Token: 0x0400003A RID: 58
        private Random scoreR;

        // Token: 0x0400003B RID: 59
        private ColorDialog nameRGB;

        // Token: 0x0400003C RID: 60
        private int[] nameInt;

        // Token: 0x0400003D RID: 61
        private Random nameR;

        // Token: 0x0400003E RID: 62
        private ColorDialog nameTRGB;

        // Token: 0x0400003F RID: 63
        private int[] nameTInt;

        // Token: 0x04000040 RID: 64
        private Random nameTR;

        // Token: 0x04000041 RID: 65
        private ColorDialog kfRGB;

        // Token: 0x04000042 RID: 66
        private int[] kfInt;

        // Token: 0x04000043 RID: 67
        private Random kfR;

        // Token: 0x04000044 RID: 68
        private ColorDialog laRGB;

        // Token: 0x04000045 RID: 69
        private int[] laInt;

        // Token: 0x04000046 RID: 70
        private Random laR;

        // Token: 0x04000047 RID: 71
        private bool autoF;

        // Token: 0x04000048 RID: 72
        private bool invis;

        // Token: 0x04000049 RID: 73
        private bool health;

        // Token: 0x0400004A RID: 74
        private int invisTog;

        // Token: 0x0400004B RID: 75
        private string[] healthC;

        // Token: 0x0400004C RID: 76
        private ColorDialog twRGBc;

        // Token: 0x0400004D RID: 77
        private ColorDialog twRGBg;

        // Token: 0x0400004E RID: 78
        private bool advUFO;

        // Token: 0x0400004F RID: 79
        private int[] L2jetTog;

        // Token: 0x04000050 RID: 80
        private int inGameTog;

        // Token: 0x04000051 RID: 81
        private int hostNum;

        // Token: 0x04000052 RID: 82
        private int advUFOtog;

        // Token: 0x04000053 RID: 83
        private bool jetPack;

        // Token: 0x04000054 RID: 84
        private bool noAA;

        // Token: 0x04000055 RID: 85
        private bool L2jet;

        // Token: 0x04000056 RID: 86
        private bool noCFG;

        // Token: 0x04000057 RID: 87
        private bool noRB;

        // Token: 0x04000058 RID: 88
        private bool noLeave;

        // Token: 0x04000059 RID: 89
        private byte[] zeroArray;

        // Token: 0x0400005A RID: 90
        private string[] statNames;

        // Token: 0x0400005B RID: 91
        private string[] stats;

        // Token: 0x0400005C RID: 92
        private string notifyCmd;

        // Token: 0x0400005D RID: 93
        private bool listUpdate;

        // Token: 0x0400005E RID: 94
        private byte[] saveGunByte;

        // Token: 0x0400005F RID: 95
        private int curGridIndex;

        // Token: 0x04000060 RID: 96
        private bool useBuild;

        // Token: 0x04000061 RID: 97
        private bool setModel;

        // Token: 0x04000062 RID: 98
        private uint entOfs;

        // Token: 0x04000063 RID: 99
        private int entIndex;

        // Token: 0x04000064 RID: 100
        private float[] entPos;

        // Token: 0x04000065 RID: 101
        private float[] entAngle;

        // Token: 0x04000066 RID: 102
        private int _horizSpin;

        // Token: 0x04000067 RID: 103
        private int _vertSpin;

        // Token: 0x04000068 RID: 104
        private List<uint> entList;

        // Token: 0x04000069 RID: 105
        private List<int> indexList;

        // Token: 0x0400006A RID: 106
        private List<float[]> posList;

        // Token: 0x0400006B RID: 107
        private List<float[]> angleList;

        // Token: 0x0400006C RID: 108
        private int L2Int;

        // Token: 0x0400006D RID: 109
        private int R2Int;

        // Token: 0x0400006E RID: 110
        private int entRadius;
        public MW2()
        {
            InitializeComponent();
        }

        private void Panel8_MouseDown(object sender, MouseEventArgs e)
        {
            MW2.x = Control.MousePosition.X - base.Location.X;
            MW2.y = Control.MousePosition.Y - base.Location.Y;
        }

        private void Panel8_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MW2.newpoint = Control.MousePosition;
                MW2.newpoint.X -= MW2.x;
                MW2.newpoint.Y -= MW2.y;
                base.Location = MW2.newpoint;
            }
        }

        private void Panel8_Paint(object sender, PaintEventArgs e)
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

        private void Button9_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = Connection;
            this.ConButton.BackColor = Color.DarkGoldenrod;
            this.AccButton.BackColor = Color.FromArgb(35, 35, 35);
            this.nonHostButton.BackColor = Color.FromArgb(35, 35, 35);
            this.ClientListButton.BackColor = Color.FromArgb(35, 35, 35);
            this.LobbySettings.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void MW2_Load(object sender, EventArgs e)
        {
            ipText.Text = E3Modz.Properties.Settings.Default.DefaultIP;
            this.tabControl1.SelectedTab = Connection;
            this.ConButton.BackColor = Color.DarkGoldenrod;
            this.AccButton.BackColor = Color.FromArgb(35, 35, 35);
            this.nonHostButton.BackColor = Color.FromArgb(35, 35, 35);
            this.ClientListButton.BackColor = Color.FromArgb(35, 35, 35);
            this.LobbySettings.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void AccButton_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = Account;
            this.AccButton.BackColor = Color.DarkGoldenrod;
            this.ConButton.BackColor = Color.FromArgb(35, 35, 35);
            this.nonHostButton.BackColor = Color.FromArgb(35, 35, 35);
            this.ClientListButton.BackColor = Color.FromArgb(35, 35, 35);
            this.LobbySettingsButton.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void NonHostButton_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = NonHost;
            this.nonHostButton.BackColor = Color.DarkGoldenrod;
            this.ConButton.BackColor = Color.FromArgb(35, 35, 35);
            this.Account.BackColor = Color.FromArgb(35, 35, 35);
            this.ClientListButton.BackColor = Color.FromArgb(35, 35, 35);
            this.LobbySettings.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void ClientListButton_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = ClientList;
            this.ClientListButton.BackColor = Color.DarkGoldenrod;
            this.ConButton.BackColor = Color.FromArgb(35, 35, 35);
            this.nonHostButton.BackColor = Color.FromArgb(35, 35, 35);
            this.NonHost.BackColor = Color.FromArgb(35, 35, 35);
            this.LobbySettings.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void LobbySettingsButton_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = LobbySettings;
            this.LobbySettings.BackColor = Color.DarkGoldenrod;
            this.ConButton.BackColor = Color.FromArgb(35, 35, 35);
            this.nonHostButton.BackColor = Color.FromArgb(35, 35, 35);
            this.NonHost.BackColor = Color.FromArgb(35, 35, 35);
            this.ClientListButton.BackColor = Color.FromArgb(35, 35, 35);
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                PS3.ChangeAPI(SelectAPI.ControlConsole);
                label8.Text = "CCAPI";
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                PS3.ChangeAPI(SelectAPI.TargetManager);
                label8.Text = "TMAPI";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (PS3.ConnectTarget())
            {
                label5.Text = "Connected!";
                label5.ForeColor = Color.Green;
                MessageBox.Show("Connected!");
                pictureBox1.Visible = true;

                if (PS3.AttachProcess())
                {
                    label5.Text = "Connected and Attached!";
                    MW2RPC.EnableMW2RPC();
                    bool flag2 = !this.aimbotProcess.IsBusy;
                    if (flag2)
                    {
                        this.aimbotProcess.RunWorkerAsync();
                    }
                }
                else
                {
                    MessageBox.Show("Attach Process Failed! Check you Console IP!/NContact the Support!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Conection Failed! Check you Console IP!/nor Contact the Support!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
            MW2RPC.EnableMW2RPC();
            pictureBox1.Visible = true;
            PS3.CCAPI.RingBuzzer(CCAPI.BuzzerMode.Double);
            PS3.CCAPI.Notify(CCAPI.NotifyIcon.FINGER, "Attached with E3Modz Tool, Have Fun! :D");
        }

        private void Button61_Click(object sender, EventArgs e)
        {
            E3Modz.Properties.Settings.Default.DefaultIP = ipText.Text;
            E3Modz.Properties.Settings.Default.Save();
        }

        private void ClientList_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            PS3.DisconnectTarget();
            label5.Text = "Disconnected!";
            label5.ForeColor = Color.Yellow;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                groupBox11.Visible = true;
                label8.Text = "Hen";
                button1.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;

            }
            else
            {
                groupBox11.Visible = false;
                label8.Text = "N/A";
                button1.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            PS3.Power(PS3API.PowerFlags.ShutDown);
            PS43.ShutDown(CCAPI.RebootFlags.ShutDown);
        }

        private void Connection_Click(object sender, EventArgs e)
        {

        }

        private void Panel9_Paint(object sender, PaintEventArgs e)
        {

        }
        string GetMW2LobbyNames(uint Client)
        {
            string XUUIDB = PS3.Extension.ReadString(0x00a1359a + ((uint)Client * 216));
            return XUUIDB;
        }
        private void Button160_Click(object sender, EventArgs e)
        {
          
        }

        void Write_ROP_Exploit(uint Address, uint Value, uint RCENUM)
        {
            PS3.Extension.WriteUInt32(0x10055008, Value);
            PS3.Extension.WriteUInt32(0x10055004, Address);
            PS3.Extension.WriteUInt32(0x10055000, RCENUM);
        }
        private void GodModeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Write_ROP_Exploit(0x014E5429 + (0x3700 * (uint)this.dataGridView1.CurrentRow.Index), 0xFFFFFFFF, 1);
            Thread.Sleep(1000);
        }
        public static int Call(uint address, params object[] parameters)
        {
            int num = parameters.Length;
            int i = 0;
            uint num2 = 0u;
            uint num3 = 0u;
            while (i < num)
            {
                if (parameters[i] is int)
                {
                    MW2.PS3.Extension.WriteInt32(268566528u + num2 * 4u, (int)parameters[i]);
                    num2 += 1u;
                }
                else if (parameters[i] is uint)
                {
                    MW2.PS3.Extension.WriteUInt32(268566528u + num2 * 4u, (uint)parameters[i]);
                    num2 += 1u;
                }
                else if (parameters[i] is short)
                {
                    MW2.PS3.Extension.WriteInt16(268566528u + num2 * 4u, (short)parameters[i]);
                    num2 += 1u;
                }
                else if (parameters[i] is ushort)
                {
                    MW2.PS3.Extension.WriteUInt16(268566528u + num2 * 4u, (ushort)parameters[i]);
                    num2 += 1u;
                }
                else if (parameters[i] is byte)
                {
                    MW2.PS3.Extension.WriteByte(268566528u + num2 * 4u, (byte)parameters[i]);
                    num2 += 1u;
                }
                else if (parameters[i] is string)
                {
                    uint num4 = 268574720u + num3 * 1024u;
                    MW2.PS3.Extension.WriteString(num4, Convert.ToString(parameters[i]));
                    MW2.PS3.Extension.WriteUInt32(268566528u + num2 * 4u, num4);
                    num2 += 1u;
                    num3 += 1u;
                }
                i++;
            }
            MW2.PS3.Extension.WriteUInt32(268566600u, address);
            Thread.Sleep(20);
            return MW2.PS3.Extension.ReadInt32(268566604u);
        }
        public static void SV_GameSendServerCommand(int clientIndex, string Cmd)
        {
            MW2.Call(2203808u, new object[]
            {
                clientIndex,
                0,
                Cmd
            });
        }
        public static void iPrintln(int clientIndex, string Txt)
        {
            MW2.SV_GameSendServerCommand(clientIndex, "f \"" + Txt + "\"");
        }
        private void EnableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte[] array = new byte[]
{
                255,
                255,
                255,
                255
};
            PS3.SetMemory((uint)(20027392 + this.dataGridView1.CurrentRow.Index * 640 + 388), array);
            MW2.iPrintln(this.dataGridView1.CurrentRow.Index, "GodMode ^2ON");
        }
        private void autoFireBot()
        {
            bool flag = PS3.Extension.ReadByte(9095663u) > 0;
            if (flag)
            {
                bool flag2 = this.aFtog == 0 || this.aFtog == 1;
                if (flag2)
                {
                    PS3.Extension.WriteBytes(9809888u, new byte[]
                     {
                        1
                     });
                    bool flag3 = this.useAuto;
                    if (flag3)
                    {
                        PS3.Extension.WriteBytes(9810048u, new byte[]
                        {
                            1
                        });
                    }
                    this.aFtog = 2;
                }
                PS3.Extension.WriteBytes(9095668u, new byte[1]);
                bool flag4 = !this.useAuto;
                if (flag4)
                {
                    PS3.Extension.WriteBytes(9810049u, new byte[]
                    {
                        1
                    });
                }
            }
            else
            {
                bool flag5 = this.aFtog == 0 || this.aFtog == 2;
                if (flag5)
                {
                    PS3.Extension.WriteBytes(9809888u, new byte[1]);
                    bool flag6 = this.useAuto;
                    if (flag6)
                    {
                        PS3.Extension.WriteBytes(9810048u, new byte[1]);
                    }
                    this.aFtog = 1;
                }
            }
        }
        private void fairMode()
        {
            for (int i = 0; i < 5; i++)
            {
                PS3.Extension.WriteByte(9111155u, 1);
            }
            PS3.Extension.WriteBytes(9095663u, new byte[]
            {
                byte.MaxValue,
                0,
                0,
                7,
                byte.MaxValue,
                0
            });
        }

        private void nonHostAimbot()
        {
            bool flag = this.runAimbot;
            if (flag)
            {
                bool flag2 = this.aimbotMethod == "bot";
                if (flag2)
                {
                    this.autoFireBot();
                }
                bool flag3 = MW2RPC.NonHostButtonPressed(MW2RPC.NonHostButtons.L1);
                if (flag3)
                {
                    bool flag4 = this.aimbotMethod == "normal";
                    if (flag4)
                    {
                        PS3.Extension.WriteBytes(9095668u, new byte[1]);
                    }
                    else
                    {
                        bool flag5 = this.aimbotMethod == "fair";
                        if (flag5)
                        {
                            this.fairMode();
                        }
                    }
                }
                else
                {
                    bool flag6 = this.aimbotMethod == "fair";
                    if (flag6)
                    {
                        PS3.Extension.WriteByte(9111155u, 1);
                    }
                }
            }
        }
        private void FairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.aimbotVerified[this.dataGridView1.CurrentRow.Index] = true;
        }
        private void PS3api()
        {
            bool flag = PS3.GetCurrentAPIName() == "Target Manager";
            if (flag)
            {
                PS3.ConnectTarget(0);
            }
            else
            {
                bool flag2 = PS3.GetCurrentAPIName() == "Control Console";
                if (flag2)
                {
                    PS3.ConnectTarget();
                }
            }
        }

        private void AimbotProcess_DoWork(object sender, DoWorkEventArgs e)
        {
            this.PS3api();
            for (; ; )
            {
                this.nonHostAimbot();
            }
        }

        private void Button45_Click(object sender, EventArgs e)
        {

            dataGridView1.Enabled = true; dataGridView1.RowCount = 18;
            for (int i = 0; i < 18; i++)
            {

                dataGridView1.Update();
                dataGridView1.Rows[i].Cells[0].Value = i;
                dataGridView1.Rows[i].Cells[1].Value = GetMW2LobbyNames((uint)i);
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (button11.Text == "OFF")
            {
                this.AAenable.Start();
                this.Adv1.Start();
                if (this.checkBox12.Checked)
                {
                    this.Adv2.Start();
                }
                button11.Text = "ON";
                button11.ForeColor = Color.Green;

            }
            else if (button11.Text == "ON")
            {
                button11.Text = "OFF";
                button11.ForeColor = Color.Red;
                this.AAenable.Stop();
                this.Adv1.Stop();
                this.Adv2.Stop();
            }

        }
        private bool InGame()
        {
            return PS3.Extension.ReadBool(30505612u);
        }
        public static void Cbuf_AddText(string text)
        {
            byte[] array = new byte[256];
            byte[] buffer = array;
            byte[] buffer2 = new byte[]
            {
                56,
                96,
                0,
                0,
                60,
                128,
                2,
                0,
                48,
                132,
                80,
                0,
                75,
                248,
                99,
                253
            };
            byte[] buffer3 = new byte[]
            {
                129,
                34,
                69,
                16,
                129,
                105,
                0,
                0,
                136,
                11,
                0,
                12,
                47,
                128,
                0,
                0
            };
            byte[] buffer4 = new byte[0];
            buffer4 = Encoding.UTF8.GetBytes(text);
            PS3.SetMemory(33574912u, buffer4);
            PS3.SetMemory(2439864u, buffer2);
            PS3.SetMemory(2439864u, buffer3);
            PS3.SetMemory(33574912u, buffer);
        }

        private void AAenable_Tick(object sender, EventArgs e)
        {
            if (this.InGame())
            {
                if (MW2.CheckGame)
                {
                    MW2.CheckGame = false;
                    MW2.Cbuf_AddText(" aim_autoaim_lerp 100");
                    MW2.Cbuf_AddText(" aim_autoaim_region_height 480");
                    MW2.Cbuf_AddText(" aim_autoaim_region_width 640");
                    MW2.Cbuf_AddText(" aim_aimAssistRangeScale 2");
                    MW2.Cbuf_AddText(" aim_autoAimRangeScale 2");
                    MW2.Cbuf_AddText(" aim_slowdown_debug 1");
                    MW2.Cbuf_AddText(" aim_slowdown_region_height 0");
                    MW2.Cbuf_AddText(" aim_slowdown_region_width 0");
                    MW2.Cbuf_AddText(" aim_lockon_enabled 1");
                    MW2.Cbuf_AddText(" aim_lockon_strength 1");
                    MW2.Cbuf_AddText(" aim_lockon_deflection 0");
                    MW2.Cbuf_AddText(" aim_autoaim_enabled 0");
                    MW2.Cbuf_AddText(" aim_slowdown_yaw_scale_ads 0");
                    MW2.Cbuf_AddText(" aim_slowdown_pitch_scale_ads 0");
                    MW2.Cbuf_AddText(" aim_slowdown_enabled 1");
                }
            }
            else
            {
                MW2.CheckGame = true;
            }
            this.AAenable.Stop();
            this.AAenable.Start();
        }
        public class NonHostButtons
        {
            // Token: 0x04000613 RID: 1555
            public static uint L1 = 65u;

            // Token: 0x04000614 RID: 1556
            public static uint R1 = 77u;

            // Token: 0x04000615 RID: 1557
            public static uint Square = 41u;

            // Token: 0x04000616 RID: 1558
            public static uint R3 = 209u;

            // Token: 0x04000617 RID: 1559
            public static uint DpadUp = 245u;

            // Token: 0x04000618 RID: 1560
            public static uint DpadDown = 261u;

            // Token: 0x04000619 RID: 1561
            public static uint Cross = 16u;

            // Token: 0x0400061A RID: 1562
            public static uint Triangle = 52u;

            // Token: 0x0400061B RID: 1563
            public static uint Circle = 28u;

            // Token: 0x0400061C RID: 1564
            public static uint L2 = 220u;

            // Token: 0x0400061D RID: 1565
            public static uint R2 = 232u;

            // Token: 0x0400061E RID: 1566
            public static uint L3 = 196u;

            // Token: 0x0400061F RID: 1567
            public static uint Left = 268u;

            // Token: 0x04000620 RID: 1568
            public static uint Right = 280u;

            // Token: 0x04000621 RID: 1569
            public static uint Select = 184u;

            // Token: 0x04000622 RID: 1570
            public static uint Start = 172u;
        }

        public bool NonHostButtonPressed(uint Button)
        {
            return PS3.Extension.ReadByte(9814154u + Button) == 1;
        }
        private void Adv_Tick(object sender, EventArgs e)
        {
            this.Adv1.Interval = 1;
            if (this.NonHostButtonPressed(MW2.NonHostButtons.L1))
            {
                MW2.AdvCheck1OFF = true;
                if (MW2.AdvCheck1ON)
                {
                    MW2.AdvCheck1ON = false;
                    MW2.Cbuf_AddText(";aim_aimAssistRangeScale 2;aim_autoAimRangeScale 2");
                }
                else
                {
                    MW2.Cbuf_AddText("aim_autoaim_enabled 1");
                    MW2.Cbuf_AddText("aim_autoaim_enabled 0");
                }
            }
            else
            {
                MW2.AdvCheck1ON = true;
                if (MW2.AdvCheck1OFF)
                {
                    MW2.AdvCheck1OFF = false;
                    MW2.Cbuf_AddText(";aim_autoaim_enabled 0;aim_aimAssistRangeScale 0;aim_autoAimRangeScale 0");
                }
            }
            this.Adv1.Stop();
            this.Adv1.Start();
        }

        private void CheckBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Adv2_Tick(object sender, EventArgs e)
        {

        }

        private void enableToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Write_ROP_Exploit(0x014E5429 + (0x3700 * (uint)this.dataGridView1.CurrentRow.Index), 0xFFFFFFFF, 1);
            Thread.Sleep(1000);
        }

        private void enableToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Write_ROP_Exploit(0x14E256C + (0x3700 * (uint)this.dataGridView1.CurrentRow.Index), 0x7FFFFFFF, 1);
            Thread.Sleep(1000);
        }

        private void noClipToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void enableToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Write_ROP_Exploit(0x014E5620 + (0x3700 * (uint)this.dataGridView1.CurrentRow.Index), 0x03, 1);
            Thread.Sleep(1000);
        }
    }
}

