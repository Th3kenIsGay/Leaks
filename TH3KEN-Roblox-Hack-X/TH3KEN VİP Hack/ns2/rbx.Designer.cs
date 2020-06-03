namespace ns2
{
	// Token: 0x02000009 RID: 9
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class rbx : global::System.Windows.Forms.Form
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00003D0C File Offset: 0x00001F0C
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

		// Token: 0x0600004A RID: 74 RVA: 0x00003D50 File Offset: 0x00001F50
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns2.rbx));
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.ProgressBar1 = new global::System.Windows.Forms.ProgressBar();
			this.Timer2 = new global::System.Windows.Forms.Timer(this.components);
			this.ProgressBar2 = new global::System.Windows.Forms.ProgressBar();
			this.PictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.Timer3 = new global::System.Windows.Forms.Timer(this.components);
			this.Timer4 = new global::System.Windows.Forms.Timer(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			base.SuspendLayout();
			this.ProgressBar1.Location = new global::System.Drawing.Point(12, 126);
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Size = new global::System.Drawing.Size(493, 44);
			this.ProgressBar1.TabIndex = 0;
			this.ProgressBar2.Location = new global::System.Drawing.Point(12, 110);
			this.ProgressBar2.Maximum = 110;
			this.ProgressBar2.Name = "ProgressBar2";
			this.ProgressBar2.Size = new global::System.Drawing.Size(493, 10);
			this.ProgressBar2.TabIndex = 3;
			this.PictureBox2.Image = global::ns1.Resources.lg_comet_spinner;
			this.PictureBox2.Location = new global::System.Drawing.Point(208, 193);
			this.PictureBox2.Name = "PictureBox2";
			this.PictureBox2.Size = new global::System.Drawing.Size(100, 86);
			this.PictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PictureBox2.TabIndex = 2;
			this.PictureBox2.TabStop = false;
			this.PictureBox1.Image = global::ns1.Resources.PNG_IMG_BANNER;
			this.PictureBox1.Location = new global::System.Drawing.Point(146, 19);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new global::System.Drawing.Size(206, 70);
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex = 1;
			this.PictureBox1.TabStop = false;
			this.Timer3.Interval = 19000;
			this.Timer4.Interval = 1000;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(517, 291);
			base.Controls.Add(this.ProgressBar2);
			base.Controls.Add(this.PictureBox2);
			base.Controls.Add(this.PictureBox1);
			base.Controls.Add(this.ProgressBar1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximumSize = new global::System.Drawing.Size(517, 291);
			this.MinimumSize = new global::System.Drawing.Size(517, 291);
			base.Name = "rbx";
			this.Text = "AntiRoblox";
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400001E RID: 30
		private global::System.ComponentModel.IContainer components;
	}
}
