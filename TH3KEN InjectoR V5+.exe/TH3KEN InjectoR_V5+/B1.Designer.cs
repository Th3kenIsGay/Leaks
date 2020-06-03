namespace Hosts_Pro_V6
{
	// Token: 0x02000009 RID: 9
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public sealed partial class B1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00002544 File Offset: 0x00000744
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

		// Token: 0x06000032 RID: 50 RVA: 0x000026E4 File Offset: 0x000008E4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Hosts_Pro_V6.B1));
			this.TableLayoutPanel = new global::System.Windows.Forms.TableLayoutPanel();
			this.LogoPictureBox = new global::System.Windows.Forms.PictureBox();
			this.LabelProductName = new global::System.Windows.Forms.Label();
			this.LabelVersion = new global::System.Windows.Forms.Label();
			this.LabelCopyright = new global::System.Windows.Forms.Label();
			this.LabelCompanyName = new global::System.Windows.Forms.Label();
			this.TextBoxDescription = new global::System.Windows.Forms.TextBox();
			this.OKButton = new global::System.Windows.Forms.Button();
			this.TableLayoutPanel.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.LogoPictureBox).BeginInit();
			base.SuspendLayout();
			this.TableLayoutPanel.ColumnCount = 2;
			this.TableLayoutPanel.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 33f));
			this.TableLayoutPanel.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 67f));
			this.TableLayoutPanel.Controls.Add(this.LogoPictureBox, 0, 0);
			this.TableLayoutPanel.Controls.Add(this.LabelProductName, 1, 0);
			this.TableLayoutPanel.Controls.Add(this.LabelVersion, 1, 1);
			this.TableLayoutPanel.Controls.Add(this.LabelCopyright, 1, 2);
			this.TableLayoutPanel.Controls.Add(this.LabelCompanyName, 1, 3);
			this.TableLayoutPanel.Controls.Add(this.TextBoxDescription, 1, 4);
			this.TableLayoutPanel.Controls.Add(this.OKButton, 1, 5);
			this.TableLayoutPanel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.TableLayoutPanel.Location = new global::System.Drawing.Point(9, 9);
			this.TableLayoutPanel.Name = "TableLayoutPanel";
			this.TableLayoutPanel.RowCount = 6;
			this.TableLayoutPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 10f));
			this.TableLayoutPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 10f));
			this.TableLayoutPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 10f));
			this.TableLayoutPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 10f));
			this.TableLayoutPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 10f));
			this.TableLayoutPanel.Size = new global::System.Drawing.Size(390, 229);
			this.TableLayoutPanel.TabIndex = 0;
			this.LogoPictureBox.BackColor = global::System.Drawing.Color.Black;
			this.LogoPictureBox.Cursor = global::System.Windows.Forms.Cursors.No;
			this.LogoPictureBox.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LogoPictureBox.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("LogoPictureBox.Image");
			this.LogoPictureBox.Location = new global::System.Drawing.Point(3, 3);
			this.LogoPictureBox.MaximumSize = new global::System.Drawing.Size(120, 100);
			this.LogoPictureBox.MinimumSize = new global::System.Drawing.Size(120, 100);
			this.LogoPictureBox.Name = "LogoPictureBox";
			this.TableLayoutPanel.SetRowSpan(this.LogoPictureBox, 6);
			this.LogoPictureBox.Size = new global::System.Drawing.Size(120, 100);
			this.LogoPictureBox.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.LogoPictureBox.TabIndex = 0;
			this.LogoPictureBox.TabStop = false;
			this.LabelProductName.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelProductName.Location = new global::System.Drawing.Point(134, 0);
			this.LabelProductName.Margin = new global::System.Windows.Forms.Padding(6, 0, 3, 0);
			this.LabelProductName.MaximumSize = new global::System.Drawing.Size(0, 17);
			this.LabelProductName.Name = "LabelProductName";
			this.LabelProductName.Size = new global::System.Drawing.Size(253, 17);
			this.LabelProductName.TabIndex = 0;
			this.LabelProductName.Text = "Product Name";
			this.LabelProductName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.LabelVersion.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelVersion.Location = new global::System.Drawing.Point(134, 22);
			this.LabelVersion.Margin = new global::System.Windows.Forms.Padding(6, 0, 3, 0);
			this.LabelVersion.MaximumSize = new global::System.Drawing.Size(0, 17);
			this.LabelVersion.Name = "LabelVersion";
			this.LabelVersion.Size = new global::System.Drawing.Size(253, 17);
			this.LabelVersion.TabIndex = 0;
			this.LabelVersion.Text = "Version";
			this.LabelVersion.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.LabelCopyright.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelCopyright.Location = new global::System.Drawing.Point(134, 44);
			this.LabelCopyright.Margin = new global::System.Windows.Forms.Padding(6, 0, 3, 0);
			this.LabelCopyright.MaximumSize = new global::System.Drawing.Size(0, 17);
			this.LabelCopyright.Name = "LabelCopyright";
			this.LabelCopyright.Size = new global::System.Drawing.Size(253, 17);
			this.LabelCopyright.TabIndex = 0;
			this.LabelCopyright.Text = "Copyright";
			this.LabelCopyright.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.LabelCompanyName.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelCompanyName.Location = new global::System.Drawing.Point(134, 66);
			this.LabelCompanyName.Margin = new global::System.Windows.Forms.Padding(6, 0, 3, 0);
			this.LabelCompanyName.MaximumSize = new global::System.Drawing.Size(0, 17);
			this.LabelCompanyName.Name = "LabelCompanyName";
			this.LabelCompanyName.Size = new global::System.Drawing.Size(253, 17);
			this.LabelCompanyName.TabIndex = 0;
			this.LabelCompanyName.Text = "Company Name";
			this.LabelCompanyName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.TextBoxDescription.BackColor = global::System.Drawing.Color.Black;
			this.TextBoxDescription.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.TextBoxDescription.ForeColor = global::System.Drawing.Color.White;
			this.TextBoxDescription.Location = new global::System.Drawing.Point(134, 91);
			this.TextBoxDescription.Margin = new global::System.Windows.Forms.Padding(6, 3, 3, 3);
			this.TextBoxDescription.Multiline = true;
			this.TextBoxDescription.Name = "TextBoxDescription";
			this.TextBoxDescription.ReadOnly = true;
			this.TextBoxDescription.ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.TextBoxDescription.Size = new global::System.Drawing.Size(253, 108);
			this.TextBoxDescription.TabIndex = 0;
			this.TextBoxDescription.TabStop = false;
			this.OKButton.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.OKButton.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.OKButton.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.OKButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.OKButton.ForeColor = global::System.Drawing.Color.Aqua;
			this.OKButton.Location = new global::System.Drawing.Point(312, 205);
			this.OKButton.MaximumSize = new global::System.Drawing.Size(75, 21);
			this.OKButton.MinimumSize = new global::System.Drawing.Size(75, 21);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new global::System.Drawing.Size(75, 21);
			this.OKButton.TabIndex = 0;
			this.OKButton.Text = "&OK";
			this.OKButton.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.CancelButton = this.OKButton;
			base.ClientSize = new global::System.Drawing.Size(408, 247);
			base.Controls.Add(this.TableLayoutPanel);
			this.ForeColor = global::System.Drawing.Color.White;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(414, 276);
			base.MinimizeBox = false;
			this.MinimumSize = new global::System.Drawing.Size(414, 276);
			base.Name = "B1";
			base.Padding = new global::System.Windows.Forms.Padding(9);
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.TableLayoutPanel.ResumeLayout(false);
			this.TableLayoutPanel.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.LogoPictureBox).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000013 RID: 19
		private global::System.ComponentModel.IContainer components;
	}
}
