using System;
using System.Windows.Forms;

namespace PS3ManagerAPI
{
    // Token: 0x02000002 RID: 2
    public partial class AttachDialog : Form
    {
        // Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
        public AttachDialog()
        {
            this.InitializeComponent();
        }

        // Token: 0x06000002 RID: 2 RVA: 0x00002060 File Offset: 0x00000260
        public AttachDialog(PS3MAPI MyPS3MAPI) : this()
        {
            this.comboBox1.Items.Clear();
            foreach (uint num in MyPS3MAPI.Process.GetPidProcesses())
            {
                if (num == 0u)
                {
                    break;
                }
                this.comboBox1.Items.Add(MyPS3MAPI.Process.GetName(num));
            }
            this.comboBox1.SelectedIndex = 0;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
