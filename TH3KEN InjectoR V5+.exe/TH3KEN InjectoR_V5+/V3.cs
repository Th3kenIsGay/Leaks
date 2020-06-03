using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hosts_Pro_V6.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hosts_Pro_V6
{
	// Token: 0x0200001A RID: 26
	[DesignerGenerated]
	public partial class V3 : Form
	{
		// Token: 0x060001EF RID: 495 RVA: 0x0000D913 File Offset: 0x0000BB13
		public V3()
		{
			base.Load += this.Form3_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x0000E28D File Offset: 0x0000C48D
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x0000E298 File Offset: 0x0000C498
		internal virtual ProgressBar ProgressBar1
		{
			[CompilerGenerated]
			get
			{
				return this._ProgressBar1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ProgressBar1_Click);
				ProgressBar progressBar = this._ProgressBar1;
				if (progressBar != null)
				{
					progressBar.Click -= value2;
				}
				this._ProgressBar1 = value;
				progressBar = this._ProgressBar1;
				if (progressBar != null)
				{
					progressBar.Click += value2;
				}
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x0000E2DB File Offset: 0x0000C4DB
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x0000E2E8 File Offset: 0x0000C4E8
		internal virtual Label Label1
		{
			[CompilerGenerated]
			get
			{
				return this._Label1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label1_Click);
				Label label = this._Label1;
				if (label != null)
				{
					label.Click -= value2;
				}
				this._Label1 = value;
				label = this._Label1;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x0000E32B File Offset: 0x0000C52B
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x0000E338 File Offset: 0x0000C538
		internal virtual Label Label2
		{
			[CompilerGenerated]
			get
			{
				return this._Label2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label2_Click);
				Label label = this._Label2;
				if (label != null)
				{
					label.Click -= value2;
				}
				this._Label2 = value;
				label = this._Label2;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x0000E37B File Offset: 0x0000C57B
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x0000E388 File Offset: 0x0000C588
		internal virtual ProgressBar ProgressBar2
		{
			[CompilerGenerated]
			get
			{
				return this._ProgressBar2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ProgressBar2_Click);
				ProgressBar progressBar = this._ProgressBar2;
				if (progressBar != null)
				{
					progressBar.Click -= value2;
				}
				this._ProgressBar2 = value;
				progressBar = this._ProgressBar2;
				if (progressBar != null)
				{
					progressBar.Click += value2;
				}
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001FA RID: 506 RVA: 0x0000E3CB File Offset: 0x0000C5CB
		// (set) Token: 0x060001FB RID: 507 RVA: 0x0000E3D5 File Offset: 0x0000C5D5
		internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001FC RID: 508 RVA: 0x0000E3DE File Offset: 0x0000C5DE
		// (set) Token: 0x060001FD RID: 509 RVA: 0x0000E3E8 File Offset: 0x0000C5E8
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001FE RID: 510 RVA: 0x0000E3F1 File Offset: 0x0000C5F1
		// (set) Token: 0x060001FF RID: 511 RVA: 0x0000E3FB File Offset: 0x0000C5FB
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000200 RID: 512 RVA: 0x0000E404 File Offset: 0x0000C604
		// (set) Token: 0x06000201 RID: 513 RVA: 0x0000E40E File Offset: 0x0000C60E
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000202 RID: 514 RVA: 0x0000E417 File Offset: 0x0000C617
		// (set) Token: 0x06000203 RID: 515 RVA: 0x0000E421 File Offset: 0x0000C621
		internal virtual PictureBox PictureBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000204 RID: 516 RVA: 0x0000E42A File Offset: 0x0000C62A
		// (set) Token: 0x06000205 RID: 517 RVA: 0x0000E434 File Offset: 0x0000C634
		internal virtual ProgressBar ProgressBar3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x06000206 RID: 518 RVA: 0x000030CF File Offset: 0x000012CF
		private void ProgressBar1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000E440 File Offset: 0x0000C640
		private void Form3_Load(object sender, EventArgs e)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_02:
				ProjectData.ClearProjectError();
				num = -2;
				IL_0B:
				int num2 = 2;
				this.Label5.Text = Environment.MachineName;
				IL_1E:
				num2 = 3;
				this.Label3.Text = string.Concat(new string[]
				{
					(Guid.NewGuid().ToString() + Guid.NewGuid().ToString()).Replace("-", "").Substring(0, 4).ToUpper(),
					"-",
					(Guid.NewGuid().ToString() + Guid.NewGuid().ToString()).Replace("-", "").Substring(0, 4).ToUpper(),
					"-",
					(Guid.NewGuid().ToString() + Guid.NewGuid().ToString()).Replace("-", "").Substring(0, 4).ToUpper(),
					"-",
					(Guid.NewGuid().ToString() + Guid.NewGuid().ToString()).Replace("-", "").Substring(0, 4).ToUpper()
				});
				IL_173:
				num2 = 4;
				Interaction.Shell("TASKKILL /F /IM extremeinjector.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_183:
				num2 = 5;
				Interaction.Shell("TASKKILL /F /IM ProcessHacker.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_193:
				num2 = 6;
				Interaction.Shell("TASKKILL /F /IM hack.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_1A3:
				num2 = 7;
				Interaction.Shell("TASKKILL /F /IM ınjector.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_1B3:
				num2 = 8;
				Interaction.Shell("TASKKILL /F /IM dll ınject.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_1C3:
				num2 = 9;
				Interaction.Shell("TASKKILL /F /IM DLLInjector v2.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_1D4:
				num2 = 10;
				Interaction.Shell("TASKKILL /F /IM kill.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_1E5:
				num2 = 11;
				Interaction.Shell("TASKKILL /F /IM killer.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_1F6:
				num2 = 12;
				this.ProgressBar1.Visible = true;
				IL_206:
				num2 = 13;
				this.ProgressBar3.Value = -1;
				IL_216:
				num2 = 14;
				this.ProgressBar3.Value = 100;
				IL_227:
				num2 = 15;
				this.ProgressBar1.Value = 100;
				IL_238:
				num2 = 16;
				this.ProgressBar2.Visible = true;
				IL_248:
				num2 = 17;
				this.ProgressBar2.Value = 100;
				IL_259:
				goto IL_2FB;
				IL_25E:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_2B4:
				goto IL_2F0;
				IL_2B6:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_2CE:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_2B6;
			}
			IL_2F0:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_2FB:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000208 RID: 520 RVA: 0x000030CF File Offset: 0x000012CF
		private void Label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000209 RID: 521 RVA: 0x000030CF File Offset: 0x000012CF
		private void Label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600020A RID: 522 RVA: 0x000030CF File Offset: 0x000012CF
		private void ProgressBar2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600020B RID: 523 RVA: 0x000030CF File Offset: 0x000012CF
		private void PictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600020C RID: 524 RVA: 0x000030CF File Offset: 0x000012CF
		private void PictureBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600020D RID: 525 RVA: 0x000030CF File Offset: 0x000012CF
		private void PictureBox9_Click(object sender, EventArgs e)
		{
		}
	}
}
