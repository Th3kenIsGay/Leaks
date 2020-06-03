using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hosts_Pro_V6.My;
using Microsoft.VisualBasic.CompilerServices;

namespace Hosts_Pro_V6
{
	// Token: 0x02000009 RID: 9
	[DesignerGenerated]
	public sealed partial class B1 : Form
	{
		// Token: 0x06000020 RID: 32 RVA: 0x00002523 File Offset: 0x00000723
		public B1()
		{
			base.Load += this.AboutBox1_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00002594 File Offset: 0x00000794
		// (set) Token: 0x06000023 RID: 35 RVA: 0x000025A0 File Offset: 0x000007A0
		internal TableLayoutPanel TableLayoutPanel
		{
			[CompilerGenerated]
			get
			{
				return this._TableLayoutPanel;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				PaintEventHandler value2 = new PaintEventHandler(this.TableLayoutPanel_Paint);
				TableLayoutPanel tableLayoutPanel = this._TableLayoutPanel;
				if (tableLayoutPanel != null)
				{
					tableLayoutPanel.Paint -= value2;
				}
				this._TableLayoutPanel = value;
				tableLayoutPanel = this._TableLayoutPanel;
				if (tableLayoutPanel != null)
				{
					tableLayoutPanel.Paint += value2;
				}
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000024 RID: 36 RVA: 0x000025E3 File Offset: 0x000007E3
		// (set) Token: 0x06000025 RID: 37 RVA: 0x000025F0 File Offset: 0x000007F0
		internal PictureBox LogoPictureBox
		{
			[CompilerGenerated]
			get
			{
				return this._LogoPictureBox;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.LogoPictureBox_Click);
				PictureBox logoPictureBox = this._LogoPictureBox;
				if (logoPictureBox != null)
				{
					logoPictureBox.Click -= value2;
				}
				this._LogoPictureBox = value;
				logoPictureBox = this._LogoPictureBox;
				if (logoPictureBox != null)
				{
					logoPictureBox.Click += value2;
				}
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002633 File Offset: 0x00000833
		// (set) Token: 0x06000027 RID: 39 RVA: 0x0000263D File Offset: 0x0000083D
		internal Label LabelProductName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002646 File Offset: 0x00000846
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00002650 File Offset: 0x00000850
		internal Label LabelVersion { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00002659 File Offset: 0x00000859
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00002663 File Offset: 0x00000863
		internal Label LabelCompanyName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600002C RID: 44 RVA: 0x0000266C File Offset: 0x0000086C
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00002676 File Offset: 0x00000876
		internal TextBox TextBoxDescription { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600002E RID: 46 RVA: 0x0000267F File Offset: 0x0000087F
		// (set) Token: 0x0600002F RID: 47 RVA: 0x0000268C File Offset: 0x0000088C
		internal Button OKButton
		{
			[CompilerGenerated]
			get
			{
				return this._OKButton;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.OKButton_Click);
				Button okbutton = this._OKButton;
				if (okbutton != null)
				{
					okbutton.Click -= value2;
				}
				this._OKButton = value;
				okbutton = this._OKButton;
				if (okbutton != null)
				{
					okbutton.Click += value2;
				}
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000030 RID: 48 RVA: 0x000026CF File Offset: 0x000008CF
		// (set) Token: 0x06000031 RID: 49 RVA: 0x000026D9 File Offset: 0x000008D9
		internal Label LabelCopyright { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x06000033 RID: 51 RVA: 0x00002FC4 File Offset: 0x000011C4
		private void AboutBox1_Load(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(MyProject.Application.Info.Title, "", true) != 0;
			string arg;
			if (flag)
			{
				arg = MyProject.Application.Info.Title;
			}
			else
			{
				arg = Path.GetFileNameWithoutExtension(MyProject.Application.Info.AssemblyName);
			}
			this.Text = string.Format("About {0}", arg);
			this.LabelProductName.Text = MyProject.Application.Info.ProductName;
			this.LabelVersion.Text = string.Format("Version {0}", MyProject.Application.Info.Version.ToString());
			this.LabelCopyright.Text = MyProject.Application.Info.Copyright;
			this.LabelCompanyName.Text = MyProject.Application.Info.CompanyName;
			this.TextBoxDescription.Text = MyProject.Application.Info.Description;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000030C5 File Offset: 0x000012C5
		private void OKButton_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000030CF File Offset: 0x000012CF
		private void LogoPictureBox_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000030CF File Offset: 0x000012CF
		private void TableLayoutPanel_Paint(object sender, PaintEventArgs e)
		{
		}
	}
}
