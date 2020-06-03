namespace Hosts_Pro_V6
{
	// Token: 0x02000017 RID: 23
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x060000CD RID: 205 RVA: 0x00006970 File Offset: 0x00004B70
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000069C0 File Offset: 0x00004BC0
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Hosts_Pro_V6.Form1));
			this.ToolStrip1 = new global::System.Windows.Forms.ToolStrip();
			this.ToolStripButton1 = new global::System.Windows.Forms.ToolStripButton();
			this.ToolStripButton2 = new global::System.Windows.Forms.ToolStripButton();
			this.StatusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.ToolStripStatusLabel1 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.ListView1 = new global::System.Windows.Forms.ListView();
			this.ColumnHeader1 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader2 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader3 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader4 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader5 = new global::System.Windows.Forms.ColumnHeader();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.ToolStrip1.SuspendLayout();
			this.StatusStrip1.SuspendLayout();
			base.SuspendLayout();
			this.ToolStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripButton1,
				this.ToolStripButton2
			});
			this.ToolStrip1.Location = new global::System.Drawing.Point(0, 0);
			this.ToolStrip1.Name = "ToolStrip1";
			this.ToolStrip1.Size = new global::System.Drawing.Size(536, 25);
			this.ToolStrip1.TabIndex = 1;
			this.ToolStrip1.Text = "ToolStrip1";
			this.ToolStripButton1.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.ToolStripButton1.ForeColor = global::System.Drawing.Color.Red;
			this.ToolStripButton1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolStripButton1.Image");
			this.ToolStripButton1.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.ToolStripButton1.Name = "ToolStripButton1";
			this.ToolStripButton1.Size = new global::System.Drawing.Size(95, 22);
			this.ToolStripButton1.Text = "Sonlandır İşlemi";
			this.ToolStripButton2.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.ToolStripButton2.ForeColor = global::System.Drawing.Color.Blue;
			this.ToolStripButton2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolStripButton2.Image");
			this.ToolStripButton2.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.ToolStripButton2.Name = "ToolStripButton2";
			this.ToolStripButton2.Size = new global::System.Drawing.Size(42, 22);
			this.ToolStripButton2.Text = "Yenile";
			this.StatusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripStatusLabel1
			});
			this.StatusStrip1.Location = new global::System.Drawing.Point(0, 266);
			this.StatusStrip1.Name = "StatusStrip1";
			this.StatusStrip1.Size = new global::System.Drawing.Size(536, 22);
			this.StatusStrip1.TabIndex = 2;
			this.StatusStrip1.Text = "StatusStrip1";
			this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
			this.ToolStripStatusLabel1.Size = new global::System.Drawing.Size(63, 17);
			this.ToolStripStatusLabel1.Text = "İşemler :  0";
			this.ListView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.ColumnHeader1,
				this.ColumnHeader2,
				this.ColumnHeader3,
				this.ColumnHeader4,
				this.ColumnHeader5
			});
			this.ListView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.ListView1.GridLines = true;
			this.ListView1.Location = new global::System.Drawing.Point(0, 25);
			this.ListView1.MultiSelect = false;
			this.ListView1.Name = "ListView1";
			this.ListView1.Size = new global::System.Drawing.Size(536, 241);
			this.ListView1.TabIndex = 3;
			this.ListView1.UseCompatibleStateImageBehavior = false;
			this.ListView1.View = global::System.Windows.Forms.View.Details;
			this.ColumnHeader1.Text = "İsim";
			this.ColumnHeader1.Width = 239;
			this.ColumnHeader2.Text = "Memory";
			this.ColumnHeader2.Width = 54;
			this.ColumnHeader3.Text = "Çalışan";
			this.ColumnHeader3.Width = 83;
			this.ColumnHeader4.Text = "Başlatıldı";
			this.ColumnHeader4.Width = 93;
			this.ColumnHeader5.Text = "ID";
			this.Timer1.Interval = 15000;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(536, 288);
			base.Controls.Add(this.ListView1);
			base.Controls.Add(this.StatusStrip1);
			base.Controls.Add(this.ToolStrip1);
			this.ForeColor = global::System.Drawing.Color.Lime;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximumSize = new global::System.Drawing.Size(546, 321);
			this.MinimumSize = new global::System.Drawing.Size(546, 321);
			base.Name = "Form1";
			this.Text = "V5+ Görev Yöneticisi";
			this.ToolStrip1.ResumeLayout(false);
			this.ToolStrip1.PerformLayout();
			this.StatusStrip1.ResumeLayout(false);
			this.StatusStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000040 RID: 64
		private global::System.ComponentModel.IContainer components;
	}
}
