namespace rootip
{
	// Token: 0x02000008 RID: 8
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600002C RID: 44 RVA: 0x00002DD0 File Offset: 0x00000FD0
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

		// Token: 0x0600002D RID: 45 RVA: 0x00002E14 File Offset: 0x00001014
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::rootip.Form1));
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.TextBox1 = new global::System.Windows.Forms.TextBox();
			this.ic = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.npages = new global::System.Windows.Forms.NumericUpDown();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.LV1 = new global::System.Windows.Forms.ListView();
			this.CM1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.SaveToPNGToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SaveToIconToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.IM = new global::System.Windows.Forms.ImageList(this.components);
			this.Label3 = new global::System.Windows.Forms.Label();
			this.LinkLabel1 = new global::System.Windows.Forms.LinkLabel();
			this.SV = new global::System.Windows.Forms.SaveFileDialog();
			this.MenuStrip1 = new global::System.Windows.Forms.MenuStrip();
			this.ToolStripMenuItem_0 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem_1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.LisanceToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.npages).BeginInit();
			this.CM1.SuspendLayout();
			this.MenuStrip1.SuspendLayout();
			base.SuspendLayout();
			this.Panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.TextBox1);
			this.Panel1.Controls.Add(this.ic);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.npages);
			this.Panel1.Controls.Add(this.Button1);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(597, 46);
			this.Panel1.TabIndex = 0;
			this.Label4.AutoSize = true;
			this.Label4.BackColor = global::System.Drawing.Color.Black;
			this.Label4.Cursor = global::System.Windows.Forms.Cursors.PanWest;
			this.Label4.Font = new global::System.Drawing.Font("Calibri", 10f, global::System.Drawing.FontStyle.Bold);
			this.Label4.ForeColor = global::System.Drawing.Color.Transparent;
			this.Label4.Location = new global::System.Drawing.Point(578, 333);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(15, 17);
			this.Label4.TabIndex = 7;
			this.Label4.Text = "<";
			this.TextBox1.BackColor = global::System.Drawing.Color.White;
			this.TextBox1.Font = new global::System.Drawing.Font("Montserrat", 9.749999f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.TextBox1.ForeColor = global::System.Drawing.Color.Black;
			this.TextBox1.Location = new global::System.Drawing.Point(101, 9);
			this.TextBox1.MaxLength = 55;
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new global::System.Drawing.Size(185, 23);
			this.TextBox1.TabIndex = 6;
			this.TextBox1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.ic.AutoSize = true;
			this.ic.Font = new global::System.Drawing.Font("Calibri", 10f, global::System.Drawing.FontStyle.Bold);
			this.ic.ForeColor = global::System.Drawing.Color.Red;
			this.ic.Location = new global::System.Drawing.Point(489, 14);
			this.ic.Name = "ic";
			this.ic.Size = new global::System.Drawing.Size(22, 17);
			this.ic.TabIndex = 5;
			this.ic.Text = "~~";
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Calibri", 10f, global::System.Drawing.FontStyle.Bold);
			this.Label2.ForeColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.Label2.Location = new global::System.Drawing.Point(385, 13);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(50, 17);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "Sayfa >";
			this.npages.BackColor = global::System.Drawing.Color.Black;
			this.npages.ForeColor = global::System.Drawing.Color.Lime;
			this.npages.Hexadecimal = true;
			this.npages.Location = new global::System.Drawing.Point(436, 11);
			global::System.Windows.Forms.NumericUpDown npages = this.npages;
			int[] array = new int[4];
			array[0] = 1;
			npages.Minimum = new decimal(array);
			this.npages.Name = "npages";
			this.npages.Size = new global::System.Drawing.Size(42, 22);
			this.npages.TabIndex = 3;
			this.npages.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown npages2 = this.npages;
			int[] array2 = new int[4];
			array2[0] = 2;
			npages2.Value = new decimal(array2);
			this.Button1.BackColor = global::System.Drawing.Color.Black;
			this.Button1.Cursor = global::System.Windows.Forms.Cursors.Cross;
			this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button1.Font = new global::System.Drawing.Font("Zekton Rg", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.Button1.ForeColor = global::System.Drawing.Color.Yellow;
			this.Button1.Location = new global::System.Drawing.Point(295, 5);
			this.Button1.MaximumSize = new global::System.Drawing.Size(84, 31);
			this.Button1.MinimumSize = new global::System.Drawing.Size(84, 31);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(84, 31);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "> Ara <";
			this.Button1.UseVisualStyleBackColor = false;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Zekton Rg", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.Label1.ForeColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.Label1.Location = new global::System.Drawing.Point(3, 15);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(95, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Arama Filtre >";
			this.LV1.BackColor = global::System.Drawing.SystemColors.Control;
			this.LV1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.LV1.ContextMenuStrip = this.CM1;
			this.LV1.LargeImageList = this.IM;
			this.LV1.Location = new global::System.Drawing.Point(0, 75);
			this.LV1.MaximumSize = new global::System.Drawing.Size(597, 255);
			this.LV1.MinimumSize = new global::System.Drawing.Size(597, 255);
			this.LV1.Name = "LV1";
			this.LV1.Size = new global::System.Drawing.Size(597, 255);
			this.LV1.SmallImageList = this.IM;
			this.LV1.TabIndex = 1;
			this.LV1.UseCompatibleStateImageBehavior = false;
			this.CM1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.SaveToPNGToolStripMenuItem,
				this.SaveToIconToolStripMenuItem
			});
			this.CM1.Name = "CM1";
			this.CM1.Size = new global::System.Drawing.Size(169, 48);
			this.SaveToPNGToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("SaveToPNGToolStripMenuItem.Image");
			this.SaveToPNGToolStripMenuItem.Name = "SaveToPNGToolStripMenuItem";
			this.SaveToPNGToolStripMenuItem.Size = new global::System.Drawing.Size(168, 22);
			this.SaveToPNGToolStripMenuItem.Text = "Şöyle Kaydet PNG";
			this.SaveToIconToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("SaveToIconToolStripMenuItem.Image");
			this.SaveToIconToolStripMenuItem.Name = "SaveToIconToolStripMenuItem";
			this.SaveToIconToolStripMenuItem.Size = new global::System.Drawing.Size(168, 22);
			this.SaveToIconToolStripMenuItem.Text = "Şöyle Kaydet Icon";
			this.IM.ColorDepth = global::System.Windows.Forms.ColorDepth.Depth32Bit;
			this.IM.ImageSize = new global::System.Drawing.Size(48, 48);
			this.IM.TransparentColor = global::System.Drawing.Color.Transparent;
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Calibri", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.Label3.ForeColor = global::System.Drawing.Color.FromArgb(192, 192, 0);
			this.Label3.Location = new global::System.Drawing.Point(5, 332);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(66, 15);
			this.Label3.TabIndex = 3;
			this.Label3.Text = "Coded BY :";
			this.LinkLabel1.AutoSize = true;
			this.LinkLabel1.Font = new global::System.Drawing.Font("Calibri", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.LinkLabel1.LinkColor = global::System.Drawing.Color.Red;
			this.LinkLabel1.Location = new global::System.Drawing.Point(69, 333);
			this.LinkLabel1.Name = "LinkLabel1";
			this.LinkLabel1.Size = new global::System.Drawing.Size(50, 15);
			this.LinkLabel1.TabIndex = 4;
			this.LinkLabel1.TabStop = true;
			this.LinkLabel1.Text = "TH3KEN";
			this.MenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripMenuItem_0,
				this.ToolStripMenuItem_1,
				this.LisanceToolStripMenuItem
			});
			this.MenuStrip1.Location = new global::System.Drawing.Point(0, 46);
			this.MenuStrip1.MaximumSize = new global::System.Drawing.Size(597, 24);
			this.MenuStrip1.MinimumSize = new global::System.Drawing.Size(597, 24);
			this.MenuStrip1.Name = "MenuStrip1";
			this.MenuStrip1.Size = new global::System.Drawing.Size(597, 24);
			this.MenuStrip1.TabIndex = 5;
			this.MenuStrip1.Text = "MenuStrip1";
			this.ToolStripMenuItem_0.Name = "YardımToolStripMenuItem";
			this.ToolStripMenuItem_0.Size = new global::System.Drawing.Size(56, 20);
			this.ToolStripMenuItem_0.Text = "Yardım";
			this.ToolStripMenuItem_1.Name = "KullanmaKılavuzuToolStripMenuItem";
			this.ToolStripMenuItem_1.Size = new global::System.Drawing.Size(116, 20);
			this.ToolStripMenuItem_1.Text = "Kullanma Kılavuzu";
			this.LisanceToolStripMenuItem.Name = "LisanceToolStripMenuItem";
			this.LisanceToolStripMenuItem.Size = new global::System.Drawing.Size(58, 20);
			this.LisanceToolStripMenuItem.Text = "Lisance";
			this.Button2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.Button2.Location = new global::System.Drawing.Point(522, 331);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(75, 20);
			this.Button2.TabIndex = 7;
			this.Button2.Text = "Durdur";
			this.Button2.UseVisualStyleBackColor = true;
			this.Button2.Visible = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 14f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(597, 352);
			base.Controls.Add(this.Label4);
			base.Controls.Add(this.Button2);
			base.Controls.Add(this.MenuStrip1);
			base.Controls.Add(this.LinkLabel1);
			base.Controls.Add(this.Label3);
			base.Controls.Add(this.Panel1);
			base.Controls.Add(this.LV1);
			this.Font = new global::System.Drawing.Font("Calibri", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ForeColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form1";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "İcon Bul Kolay Yol | TH3KEN - X";
			base.TransparencyKey = global::System.Drawing.Color.FromArgb(255, 128, 0);
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.npages).EndInit();
			this.CM1.ResumeLayout(false);
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400000E RID: 14
		private global::System.ComponentModel.IContainer components;
	}
}
