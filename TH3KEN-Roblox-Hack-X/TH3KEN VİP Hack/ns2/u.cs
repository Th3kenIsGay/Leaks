using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace ns2
{
	// Token: 0x0200000B RID: 11
	[DesignerGenerated]
	public partial class u : Form
	{
		// Token: 0x06000082 RID: 130 RVA: 0x000023DD File Offset: 0x000005DD
		public u()
		{
			base.Load += this.Form3_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000085 RID: 133 RVA: 0x000023FD File Offset: 0x000005FD
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00005474 File Offset: 0x00003674
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

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00002405 File Offset: 0x00000605
		// (set) Token: 0x06000088 RID: 136 RVA: 0x000054B8 File Offset: 0x000036B8
		internal virtual Timer Timer1
		{
			[CompilerGenerated]
			get
			{
				return this._Timer1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer1_Tick);
				Timer timer = this._Timer1;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer1 = value;
				timer = this._Timer1;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000054FC File Offset: 0x000036FC
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
				IL_0A:
				int num2 = 2;
				MyProject.Forms.GForm0_0.CheckForUpdates();
				IL_1B:
				num2 = 3;
				this.Timer1.Start();
				IL_28:
				num2 = 4;
				MyProject.Forms.Form4.Close();
				IL_39:
				num2 = 5;
				MyProject.Forms.robloxm.Close();
				IL_4A:
				num2 = 6;
				MyProject.Forms.Form4.Close();
				IL_5B:
				num2 = 7;
				MyProject.Forms.rbx.Close();
				IL_6C:
				num2 = 8;
				MyProject.Forms.GForm0_0.CheckForUpdates();
				IL_7D:
				num2 = 9;
				base.Close();
				IL_86:
				goto IL_102;
				IL_88:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_BE:
				goto IL_F7;
				IL_C0:
				num4 = num2;
				if (num <= -2)
				{
					goto IL_88;
				}
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_D5:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_C0;
			}
			IL_F7:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_102:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00005624 File Offset: 0x00003824
		private void Timer1_Tick(object sender, EventArgs e)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_02:
				ProjectData.ClearProjectError();
				num = -2;
				IL_0A:
				int num2 = 2;
				this.ProgressBar1.Increment(15);
				IL_19:
				num2 = 3;
				if (this.ProgressBar1.Value != 100)
				{
					goto IL_59;
				}
				IL_2C:
				num2 = 4;
				this.ProgressBar1.Value = 1;
				IL_3A:
				num2 = 5;
				MyProject.Forms.Form4.Close();
				IL_4B:
				num2 = 6;
				this.ProgressBar1.Visible = false;
				IL_59:
				goto IL_CD;
				IL_5B:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_89:
				goto IL_C2;
				IL_8B:
				num4 = num2;
				if (num <= -2)
				{
					goto IL_5B;
				}
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_A0:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_8B;
			}
			IL_C2:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_CD:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002118 File Offset: 0x00000318
		private void ProgressBar1_Click(object sender, EventArgs e)
		{
		}
	}
}
