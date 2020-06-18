using E3Modz.Klassen;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E3Modz.Login___Home
{
    public partial class Bo3EbootBuilder : Form
    {
        private void control_flip(bool toggle)
        {
            this.steadyAim.Enabled = toggle;
            this.noRecoil.Enabled = toggle;
            this.redbox.Enabled = toggle;
            this.antiban.Enabled = toggle;
            this.vsat.Enabled = toggle;
            this.wallhack.Enabled = toggle;
            if (this.can_use_sprx)
            {
                this.loadSPRX.Enabled = toggle;
            }
            this.fpsCheckbox.Enabled = toggle;
            this.deadBodiesFlag.Enabled = toggle;
            this.weaponsFlag.Enabled = toggle;
        }
        public Bo3EbootBuilder()
        {
            InitializeComponent();
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public byte[] eboot_buffer;
        public bool can_use_sprx = true;
        private void LoadELFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "ELF File (.elf)|*.elf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.eboot_buffer = File.ReadAllBytes(openFileDialog.FileName);
                byte[] array = new byte[4];
                Array.Copy(this.eboot_buffer, array, array.Length);
                if (Bo3EbootBuilderFunctions.verify_magic(array))
                {
                    this.status.Text = "Successfully loaded " + openFileDialog.SafeFileName;
                    this.control_flip(true);
                    this.buildToolStripMenuItem.Enabled = true;
                }
                else
                {
                    this.status.Text = "Bad file header. Please make sure you're using a proper EBOOT.ELF.";
                    this.control_flip(false);
                    this.buildToolStripMenuItem.Enabled = false;
                }
            }
        }
        public class Mods
        {
            // Token: 0x17000001 RID: 1
            // (get) Token: 0x06000020 RID: 32 RVA: 0x00003D34 File Offset: 0x00001F34
            // (set) Token: 0x06000021 RID: 33 RVA: 0x00003D4B File Offset: 0x00001F4B
            public uint? steady_aim { get; set; }

            // Token: 0x17000002 RID: 2
            // (get) Token: 0x06000022 RID: 34 RVA: 0x00003D54 File Offset: 0x00001F54
            // (set) Token: 0x06000023 RID: 35 RVA: 0x00003D6B File Offset: 0x00001F6B
            public uint? no_recoil { get; set; }

            // Token: 0x17000003 RID: 3
            // (get) Token: 0x06000024 RID: 36 RVA: 0x00003D74 File Offset: 0x00001F74
            // (set) Token: 0x06000025 RID: 37 RVA: 0x00003D8B File Offset: 0x00001F8B
            public uint? vsat { get; set; }

            // Token: 0x17000004 RID: 4
            // (get) Token: 0x06000026 RID: 38 RVA: 0x00003D94 File Offset: 0x00001F94
            // (set) Token: 0x06000027 RID: 39 RVA: 0x00003DAB File Offset: 0x00001FAB
            public uint? wallhack { get; set; }

            // Token: 0x17000005 RID: 5
            // (get) Token: 0x06000028 RID: 40 RVA: 0x00003DB4 File Offset: 0x00001FB4
            // (set) Token: 0x06000029 RID: 41 RVA: 0x00003DCB File Offset: 0x00001FCB
            public uint? fps { get; set; }

            // Token: 0x17000006 RID: 6
            // (get) Token: 0x0600002A RID: 42 RVA: 0x00003DD4 File Offset: 0x00001FD4
            // (set) Token: 0x0600002B RID: 43 RVA: 0x00003DEB File Offset: 0x00001FEB
            public uint? weapons_flag { get; set; }

            // Token: 0x17000007 RID: 7
            // (get) Token: 0x0600002C RID: 44 RVA: 0x00003DF4 File Offset: 0x00001FF4
            // (set) Token: 0x0600002D RID: 45 RVA: 0x00003E0B File Offset: 0x0000200B
            public uint? dead_bodies_flag { get; set; }

            // Token: 0x17000008 RID: 8
            // (get) Token: 0x0600002E RID: 46 RVA: 0x00003E14 File Offset: 0x00002014
            // (set) Token: 0x0600002F RID: 47 RVA: 0x00003E2B File Offset: 0x0000202B
            public string load_sprx { get; set; }

            // Token: 0x17000009 RID: 9
            // (get) Token: 0x06000030 RID: 48 RVA: 0x00003E34 File Offset: 0x00002034
            // (set) Token: 0x06000031 RID: 49 RVA: 0x00003E4B File Offset: 0x0000204B
            public uint? red_box { get; set; }

            // Token: 0x1700000A RID: 10
            // (get) Token: 0x06000032 RID: 50 RVA: 0x00003E54 File Offset: 0x00002054
            // (set) Token: 0x06000033 RID: 51 RVA: 0x00003E6B File Offset: 0x0000206B
            public uint? rl_antiban { get; set; }

            // Token: 0x1700000B RID: 11
            // (get) Token: 0x06000034 RID: 52 RVA: 0x00003E74 File Offset: 0x00002074
            // (set) Token: 0x06000035 RID: 53 RVA: 0x00003E8B File Offset: 0x0000208B
            public uint? ten_prestige { get; set; }

            // Token: 0x1700000C RID: 12
            // (get) Token: 0x06000036 RID: 54 RVA: 0x00003E94 File Offset: 0x00002094
            // (set) Token: 0x06000037 RID: 55 RVA: 0x00003EAB File Offset: 0x000020AB
            public uint? fif_level { get; set; }

            // Token: 0x0400003D RID: 61
            public uint no_blur = 950009856u;
        }

        // Token: 0x02000007 RID: 7
        public enum Build
        {
            // Token: 0x0400004B RID: 75
            npeb_cex,
            // Token: 0x0400004C RID: 76
            npeb_debug,
            // Token: 0x0400004D RID: 77
            npeb_debug_npdrm
        }

        private void Bo3EbootBuilder_Load(object sender, EventArgs e)
        {
            groupBox1.ForeColor = Color.FromArgb(224, 224, 224);
        }
        private void build(Bo3EbootBuilder.Build type)
        {
            Random random = new Random();
            if (random.Next(0, 1000000) % 1000 == 0)
            {
                this.status.Text = "Infiltrating Rebel forces....";
            }
            else
            {
                this.status.Text = "Working...";
            }
            Bo3EbootBuilder.Mods mods = new Bo3EbootBuilder.Mods();
            if (this.wallhack.Checked)
            {
                mods.wallhack = new uint?(952172543u);
            }
            if (this.steadyAim.Checked)
            {
                mods.steady_aim = new uint?(738459648u);
            }
            if (this.noRecoil.Checked)
            {
                mods.no_recoil = new uint?(1610612736u);
            }
            if (this.antiban.Checked)
            {
                mods.rl_antiban = new uint?(1610612736u);
            }
            if (this.redbox.Checked)
            {
                mods.red_box = new uint?(1610612736u);
            }
            if (this.vsat.Checked)
            {
                mods.vsat = new uint?(1610612736u);
            }
            if (this.loadSPRX.Checked && !string.IsNullOrEmpty(this.sprxName.Text))
            {
                mods.load_sprx = this.sprxName.Text;
            }
            if (this.fpsCheckbox.Checked)
            {
                mods.fps = new uint?(1610612736u);
            }
            if (this.weaponsFlag.Checked)
            {
                mods.weapons_flag = new uint?(952172543u);
            }
            if (this.deadBodiesFlag.Checked)
            {
                mods.dead_bodies_flag = new uint?(952172543u);
            }
            string text = Bo3EbootBuilderFunctions.compile(this.eboot_buffer, mods, Bo3EbootBuilder.Build.npeb_debug);
            if (text != null)
            {
                if (!(text == "good"))
                {
                    if (!(text == "nodir"))
                    {
                        if (text == "noeboot")
                        {
                            this.status.Text = "ERROR: Failed to build EBOOT. Please try again.";
                        }
                    }
                    else
                    {
                        this.status.Text = "ERROR: \"tools\" directory is missing. Please redownload and extract all files and folders!";
                    }
                }
                else
                {
                    this.status.Text = "Successfully created EBOOT";
                }
            }
        }

        private void BuildToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(delegate ()
            {
                this.build(Bo3EbootBuilder.Build.npeb_debug);
            });
        }

        private void BuildNPDRMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(delegate ()
            {
                this.build(Bo3EbootBuilder.Build.npeb_debug_npdrm);
            });
        }

        private void CompressEbootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.compressEBOOTS.Checked = !this.compressEBOOTS.Checked;
            E3Modz.Properties.Settings.Default.compress = this.compressEBOOTS.Checked;
            E3Modz.Properties.Settings.Default.Save();
        }

        private void Vsat_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LoadSPRX_CheckedChanged(object sender, EventArgs e)
        {
            this.sprxName.Enabled = this.loadSPRX.Checked;
            this.sprxName.Enabled = this.loadSPRX.Checked;
        }

        private void Button35_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void Button36_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.mediafire.com/file/tusycbccs4u9dlb/VortexRTM.rar/file");
        }
    }
}
