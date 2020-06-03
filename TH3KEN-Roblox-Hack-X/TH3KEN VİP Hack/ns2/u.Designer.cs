namespace ns2
{
	// Token: 0x0200000B RID: 11
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class u : global::System.Windows.Forms.Form
	{
		// Token: 0x06000083 RID: 131 RVA: 0x00005310 File Offset: 0x00003510
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00005354 File Offset: 0x00003554
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns2.u));
			this.ProgressBar1 = new global::System.Windows.Forms.ProgressBar();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			base.SuspendLayout();
			this.ProgressBar1.Location = new global::System.Drawing.Point(0, 0);
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Size = new global::System.Drawing.Size(10, 10);
			this.ProgressBar1.TabIndex = 0;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(10, 10);
			base.Controls.Add(this.ProgressBar1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximumSize = new global::System.Drawing.Size(10, 10);
			this.MinimumSize = new global::System.Drawing.Size(10, 10);
			base.Name = "u";
			base.ResumeLayout(false);
		}

		// Token: 0x04000034 RID: 52
		private global::System.ComponentModel.IContainer components;
	}
}
