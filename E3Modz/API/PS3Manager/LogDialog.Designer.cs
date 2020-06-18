namespace PS3ManagerAPI
{
	// Token: 0x02000003 RID: 3
	public partial class LogDialog : global::System.Windows.Forms.Form
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002495 File Offset: 0x00000695
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000024B4 File Offset: 0x000006B4
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::PS3ManagerAPI.LogDialog));
			this.tB_Log = new global::System.Windows.Forms.TextBox();
			this.btnRefresh = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.tB_Log.BackColor = global::System.Drawing.Color.White;
			this.tB_Log.Location = new global::System.Drawing.Point(12, 12);
			this.tB_Log.MaxLength = 16;
			this.tB_Log.Multiline = true;
			this.tB_Log.Name = "tB_Log";
			this.tB_Log.ReadOnly = true;
			this.tB_Log.ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.tB_Log.Size = new global::System.Drawing.Size(429, 327);
			this.tB_Log.TabIndex = 10;
			this.btnRefresh.Location = new global::System.Drawing.Point(290, 345);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new global::System.Drawing.Size(71, 21);
			this.btnRefresh.TabIndex = 1;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new global::System.EventHandler(this.LogDialog_Refresh);
			this.button1.Location = new global::System.Drawing.Point(370, 345);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(71, 21);
			this.button1.TabIndex = 2;
			this.button1.Text = "Close";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(453, 378);
			base.ControlBox = false;
			base.Controls.Add(this.button1);
			base.Controls.Add(this.btnRefresh);
			base.Controls.Add(this.tB_Log);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "LogDialog";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "PS3 Manager API Log";
			base.Activated += new global::System.EventHandler(this.LogDialog_Refresh);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000008 RID: 8
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000009 RID: 9
		protected internal global::System.Windows.Forms.TextBox tB_Log;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.Button btnRefresh;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.Button button1;
	}
}
