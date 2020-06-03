using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Hosts_Pro_V6.My;
using Hosts_Pro_V6.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hosts_Pro_V6
{
	// Token: 0x02000019 RID: 25
	[DesignerGenerated]
	public partial class V1 : Form
	{
		// Token: 0x060000EF RID: 239 RVA: 0x000074AA File Offset: 0x000056AA
		public V1()
		{
			base.Load += this.Form1_Load;
			this.ExeName = Path.GetFileNameWithoutExtension(Application.ExecutablePath);
			this.InitializeComponent();
		}

		// Token: 0x060000F0 RID: 240
		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int ReadProcessMemory(int hProcess, int lpBaseAddress, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpBuffer, int nSize, ref int lpNumberOfBytesWritten);

		// Token: 0x060000F1 RID: 241
		[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "LoadLibraryA", ExactSpelling = true, SetLastError = true)]
		public static extern int LoadLibrary([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpLibFileName);

		// Token: 0x060000F2 RID: 242
		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int VirtualAllocEx(int hProcess, int lpAddress, int dwSize, int flAllocationType, int flProtect);

		// Token: 0x060000F3 RID: 243
		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int WriteProcessMemory(int hProcess, int lpBaseAddress, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpBuffer, int nSize, ref int lpNumberOfBytesWritten);

		// Token: 0x060000F4 RID: 244
		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int GetProcAddress(int hModule, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpProcName);

		// Token: 0x060000F5 RID: 245
		[DllImport("Kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetModuleHandleA", ExactSpelling = true, SetLastError = true)]
		private static extern int GetModuleHandle([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpModuleName);

		// Token: 0x060000F6 RID: 246
		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int CreateRemoteThread(int hProcess, int lpThreadAttributes, int dwStackSize, int lpStartAddress, int lpParameter, int dwCreationFlags, ref int lpThreadId);

		// Token: 0x060000F7 RID: 247
		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int OpenProcess(int dwDesiredAccess, int bInheritHandle, int dwProcessId);

		// Token: 0x060000F8 RID: 248
		[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "FindWindowA", ExactSpelling = true, SetLastError = true)]
		private static extern int FindWindow([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClassName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpWindowName);

		// Token: 0x060000F9 RID: 249
		[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "CloseHandleA", ExactSpelling = true, SetLastError = true)]
		private static extern int CloseHandle(int hObject);

		// Token: 0x060000FA RID: 250 RVA: 0x000074E0 File Offset: 0x000056E0
		private void Inject()
		{
			int num;
			int num5;
			object obj;
			try
			{
				ProjectData.ClearProjectError();
				num = 2;
				this.Timer1.Stop();
				Process[] processesByName = Process.GetProcessesByName(this.TextBox1.Text);
				this.TargetProcessHandle = V1.OpenProcess(42, 0, processesByName[0].Id);
				this.pszLibFileRemote = this.OpenFileDialog1.FileName;
				string text = "Kernel32";
				int moduleHandle = V1.GetModuleHandle(ref text);
				string text2 = "LoadLibraryA";
				this.pfnStartAddr = V1.GetProcAddress(moduleHandle, ref text2);
				this.TargetBufferSize = checked(1 + Strings.Len(this.pszLibFileRemote));
				int num2 = V1.VirtualAllocEx(this.TargetProcessHandle, 0, this.TargetBufferSize, 4096, 4);
				int targetProcessHandle = this.TargetProcessHandle;
				int lpBaseAddress = num2;
				int targetBufferSize = this.TargetBufferSize;
				int num3 = 0;
				int num4 = V1.WriteProcessMemory(targetProcessHandle, lpBaseAddress, ref this.pszLibFileRemote, targetBufferSize, ref num3);
				int targetProcessHandle2 = this.TargetProcessHandle;
				int lpThreadAttributes = 0;
				int dwStackSize = 0;
				int lpStartAddress = this.pfnStartAddr;
				int lpParameter = num2;
				int dwCreationFlags = 0;
				num3 = 0;
				V1.CreateRemoteThread(targetProcessHandle2, lpThreadAttributes, dwStackSize, lpStartAddress, lpParameter, dwCreationFlags, ref num3);
				V1.CloseHandle(this.TargetProcessHandle);
				IL_E5:
				base.Show();
				goto IL_132;
				IL_F0:
				num5 = -1;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_104:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_F0;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			IL_132:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00007644 File Offset: 0x00005844
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
				IL_0B:
				int num2 = 2;
				IntPtr mainWindowHandle = Process.GetCurrentProcess().MainWindowHandle;
				bool flag = WindowsApi.FlashWindow(ref mainWindowHandle, true, true, 3);
				IL_24:
				num2 = 3;
				Directory.Delete("C:\\Windows\\Logs", true);
				IL_32:
				num2 = 4;
				Directory.Delete("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\CrashDumps", true);
				IL_4F:
				num2 = 5;
				this.ReactorTheme1.Visible = false;
				IL_5E:
				num2 = 6;
				bool isAvailable = MyProject.Computer.Network.IsAvailable;
				if (!isAvailable)
				{
					IL_89:
					num2 = 9;
					Interaction.MsgBox("Bu Program Açılmadı (Destek için Geliştiricilerle Konuşun !", MsgBoxStyle.OkCancel | MsgBoxStyle.Critical | MsgBoxStyle.Question, "InjectoR V5+");
					IL_9E:
					num2 = 10;
					this.ReactorTheme1.Enabled = false;
					IL_AE:
					num2 = 11;
					base.Close();
					IL_B8:
					goto IL_B9;
				}
				IL_75:
				num2 = 7;
				Interaction.MsgBox("MP3 Kapat Basarak Şarkıyı Kapatabilirsiniz :)", MsgBoxStyle.Information, null);
				IL_85:
				IL_B9:
				num2 = 13;
				this.Timer31.Start();
				IL_C8:
				num2 = 14;
				this.Timer21.Start();
				IL_D7:
				num2 = 15;
				this.Timer27.Start();
				IL_E6:
				num2 = 16;
				this.Timer20.Start();
				IL_F5:
				num2 = 17;
				this.Timer16.Start();
				IL_104:
				num2 = 18;
				this.Timer10.Start();
				IL_113:
				num2 = 19;
				this.Timer2.Start();
				IL_122:
				num2 = 20;
				this.Timer7.Start();
				IL_131:
				num2 = 21;
				this.Label2.Text = "PROCESS :";
				IL_145:
				num2 = 22;
				this.Timer1.Interval = 2;
				IL_155:
				num2 = 23;
				this.ReactorTheme1.Visible = true;
				IL_165:
				goto IL_21F;
				IL_16A:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_1D8:
				goto IL_214;
				IL_1DA:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_1F2:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_1DA;
			}
			IL_214:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_21F:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00007898 File Offset: 0x00005A98
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
				IL_0B:
				int num2 = 2;
				this.Timer1.Start();
				IL_19:
				num2 = 3;
				bool flag = File.Exists(this.OpenFileDialog1.FileName);
				if (!flag)
				{
					goto IL_13E;
				}
				IL_32:
				num2 = 4;
				Process[] processesByName = Process.GetProcessesByName(this.TextBox1.Text);
				IL_46:
				num2 = 5;
				bool flag2 = processesByName.Length == 0;
				if (!flag2)
				{
					IL_9B:
					num2 = 9;
					this.Timer1.Stop();
					IL_AA:
					num2 = 10;
					this.Inject();
					IL_B4:
					num2 = 11;
					this.Label1.ForeColor = Color.Green;
					IL_C8:
					num2 = 12;
					this.PictureBox8.Visible = false;
					IL_D8:
					num2 = 13;
					this.PictureBox7.Visible = false;
					IL_E8:
					num2 = 14;
					this.PictureBox6.Visible = false;
					IL_F8:
					num2 = 15;
					this.Label1.Text = "> Başarılı Inject :) <";
					IL_10C:
					num2 = 16;
					bool @checked = this.CheckBox1.Checked;
					if (!@checked)
					{
						goto IL_13B;
					}
					IL_120:
					num2 = 17;
					this.ReactorTheme1.Visible = false;
					IL_130:
					num2 = 18;
					base.Close();
					IL_13A:
					IL_13B:
					IL_13C:
					goto IL_13D;
				}
				IL_55:
				num2 = 6;
				this.Label1.ForeColor = Color.Gold;
				IL_68:
				num2 = 7;
				this.Label1.Text = ((this.TextBox1.Text + ".exe") ?? "");
				IL_94:
				IL_13D:
				IL_13E:
				IL_13F:
				goto IL_1F1;
				IL_144:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_1AA:
				goto IL_1E6;
				IL_1AC:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_1C4:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_1AC;
			}
			IL_1E6:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_1F1:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00007ABC File Offset: 0x00005CBC
		private void Button2_Click(object sender, EventArgs e)
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
				this.Button1.Select();
				IL_19:
				num2 = 3;
				this.Dlls.Items.Clear();
				IL_2C:
				num2 = 4;
				this.Label5.ForeColor = Color.LawnGreen;
				IL_3F:
				num2 = 5;
				this.Label5.Text = "DLL' Seçmediniz !...";
				IL_52:
				num2 = 6;
				this.RadioButton2.Checked = true;
				IL_61:
				goto IL_D4;
				IL_63:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_8D:
				goto IL_C9;
				IL_8F:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_A7:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_8F;
			}
			IL_C9:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_D4:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00007BB8 File Offset: 0x00005DB8
		private void Button1_Click(object sender, EventArgs e)
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
				IntPtr mainWindowHandle = Process.GetCurrentProcess().MainWindowHandle;
				bool flag = WindowsApi.FlashWindow(ref mainWindowHandle, true, true, 3);
				IL_24:
				num2 = 3;
				this.Button1.Text = "> Seç...";
				IL_37:
				num2 = 4;
				bool isAvailable = MyProject.Computer.Network.IsAvailable;
				if (!isAvailable)
				{
					IL_52:
					num2 = 6;
					this.TextBox1.Enabled = false;
					IL_61:
					num2 = 7;
					Interaction.MsgBox("Bu Program Açılmadı (Destek için Geliştiricilerle Konuşun !", MsgBoxStyle.OkCancel | MsgBoxStyle.Critical | MsgBoxStyle.Question, "InjectoR V5+");
					IL_75:
					num2 = 8;
					Application.Restart();
					IL_7D:
					num2 = 9;
					base.Close();
					IL_87:;
				}
				IL_4E:
				IL_88:
				num2 = 11;
				this.Button3.Refresh();
				IL_97:
				num2 = 12;
				this.Label1.Refresh();
				IL_A6:
				num2 = 13;
				this.ReactorTheme1.Enabled = false;
				IL_B6:
				num2 = 14;
				this.OpenFileDialog1.Filter = "DLL (*.dll) |*.dll";
				IL_CA:
				num2 = 15;
				this.OpenFileDialog1.ShowDialog();
				IL_D9:
				num2 = 16;
				string text = this.OpenFileDialog1.FileName.Substring(this.OpenFileDialog1.FileName.LastIndexOf("\\"));
				IL_103:
				num2 = 17;
				string item = text.Replace("\\", "");
				IL_119:
				num2 = 18;
				this.ReactorTheme1.Enabled = true;
				IL_129:
				num2 = 19;
				this.Dlls.Items.Add(item);
				IL_13F:
				num2 = 20;
				this.Dlls.Enabled = true;
				IL_14F:
				num2 = 21;
				this.Label4.Text = "Status Code =";
				IL_163:
				num2 = 22;
				this.Label7.Text = "Undetected";
				IL_177:
				num2 = 23;
				this.Label1.Visible = true;
				IL_187:
				num2 = 24;
				this.Label7.Visible = true;
				IL_197:
				num2 = 25;
				this.Label4.Visible = true;
				IL_1A7:
				num2 = 26;
				this.Label5.Hide();
				IL_1B6:
				num2 = 27;
				this.TextBox1.ReadOnly = false;
				IL_1C6:
				num2 = 28;
				this.TextBox1.Clear();
				IL_1D5:
				num2 = 29;
				this.Label1.Text = "";
				IL_1E9:
				goto IL_2BB;
				IL_1EE:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_274:
				goto IL_2B0;
				IL_276:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_28E:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_276;
			}
			IL_2B0:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_2BB:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00007EA8 File Offset: 0x000060A8
		private void RadioButton1_CheckedChanged(object sender, EventArgs e)
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
				this.Button3.Refresh();
				IL_19:
				num2 = 3;
				this.Label1.Refresh();
				IL_27:
				num2 = 4;
				this.CheckBox1.Checked = true;
				IL_36:
				num2 = 5;
				this.CheckBox1.Enabled = false;
				IL_45:
				num2 = 6;
				this.CheckBox1.Visible = true;
				IL_54:
				num2 = 7;
				this.Button3.Enabled = false;
				IL_63:
				num2 = 8;
				this.Button3.Visible = false;
				IL_72:
				goto IL_ED;
				IL_74:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_A6:
				goto IL_E2;
				IL_A8:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_C0:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_A8;
			}
			IL_E2:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_ED:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00007FBC File Offset: 0x000061BC
		private void RadioButton2_CheckedChanged(object sender, EventArgs e)
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
				this.Button3.Visible = true;
				IL_1A:
				num2 = 3;
				this.Button3.Refresh();
				IL_28:
				num2 = 4;
				this.Label1.Refresh();
				IL_36:
				num2 = 5;
				this.Timer13.Start();
				IL_44:
				num2 = 6;
				this.Timer1.Stop();
				IL_52:
				num2 = 7;
				this.CheckBox1.Checked = false;
				IL_61:
				num2 = 8;
				this.Button3.Enabled = true;
				IL_70:
				num2 = 9;
				this.CheckBox1.Enabled = true;
				IL_80:
				num2 = 10;
				this.CheckBox1.Visible = true;
				IL_90:
				goto IL_116;
				IL_95:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_CF:
				goto IL_10B;
				IL_D1:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_E9:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_D1;
			}
			IL_10B:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_116:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000030CF File Offset: 0x000012CF
		private void ReactorTheme1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000080F8 File Offset: 0x000062F8
		private void Button4_Click(object sender, EventArgs e)
		{
			int num;
			int num5;
			object obj;
			try
			{
				IL_02:
				ProjectData.ClearProjectError();
				num = -2;
				IL_0B:
				int num2 = 2;
				checked
				{
					int num3 = this.Dlls.SelectedItems.Count - 1;
					for (int i = num3; i >= 0; i += -1)
					{
						IL_25:
						num2 = 3;
						this.Dlls.Items.Remove(RuntimeHelpers.GetObjectValue(this.Dlls.SelectedItems[i]));
						IL_4F:
						num2 = 4;
					}
					IL_5C:
					num2 = 5;
					this.Label5.ForeColor = Color.Pink;
					IL_6F:
					num2 = 6;
					this.Label5.Text = "DLL' Seçmediniz !...";
					IL_82:
					num2 = 7;
					this.Button1.Select();
					IL_90:
					num2 = 8;
					this.Dlls.Select();
					IL_9E:
					goto IL_119;
					IL_A0:;
				}
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_D2:
				goto IL_10E;
				IL_D4:
				num5 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_EC:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_D4;
			}
			IL_10E:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_119:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000030CF File Offset: 0x000012CF
		private void ReactorTheme1_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000030CF File Offset: 0x000012CF
		private void Button5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000030CF File Offset: 0x000012CF
		private void Label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00008238 File Offset: 0x00006438
		private void Timer2_Tick(object sender, EventArgs e)
		{
			this.Label1.ForeColor = Color.Red;
			this.Timer2.Stop();
			this.Timer3.Start();
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00008264 File Offset: 0x00006464
		private void Timer3_Tick(object sender, EventArgs e)
		{
			this.Label1.ForeColor = Color.Blue;
			this.Timer3.Stop();
			this.Timer4.Start();
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00008290 File Offset: 0x00006490
		private void Timer4_Tick(object sender, EventArgs e)
		{
			this.Label1.ForeColor = Color.Yellow;
			this.Timer4.Stop();
			this.Timer5.Start();
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000082BC File Offset: 0x000064BC
		private void Timer5_Tick(object sender, EventArgs e)
		{
			this.Label1.ForeColor = Color.Aqua;
			this.Timer5.Stop();
			this.Timer6.Start();
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000082E8 File Offset: 0x000064E8
		private void Timer6_Tick(object sender, EventArgs e)
		{
			this.Label1.ForeColor = Color.Green;
			this.Timer6.Stop();
			this.Timer2.Start();
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00008314 File Offset: 0x00006514
		private void Timer7_Tick(object sender, EventArgs e)
		{
			this.CheckBox1.ForeColor = Color.Red;
			this.Timer7.Stop();
			this.Timer8.Start();
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00008340 File Offset: 0x00006540
		private void Timer8_Tick(object sender, EventArgs e)
		{
			this.CheckBox1.ForeColor = Color.Blue;
			this.Timer8.Stop();
			this.Timer9.Start();
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000836C File Offset: 0x0000656C
		private void Timer9_Tick(object sender, EventArgs e)
		{
			this.CheckBox1.ForeColor = Color.Pink;
			this.Timer9.Stop();
			this.Timer8.Start();
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00008398 File Offset: 0x00006598
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool isAvailable = MyProject.Computer.Network.IsAvailable;
			if (!isAvailable)
			{
				Interaction.MsgBox("Bu Program Açılmadı (Destek için Geliştiricilerle Konuşun !", MsgBoxStyle.OkCancel | MsgBoxStyle.Critical | MsgBoxStyle.Question, "InjectoR V5+");
				this.ReactorTheme1.Enabled = false;
				ProjectData.EndApp();
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000030CF File Offset: 0x000012CF
		private void Button6_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000083E3 File Offset: 0x000065E3
		private void Timer10_Tick(object sender, EventArgs e)
		{
			this.Dlls.ForeColor = Color.Red;
			this.Timer10.Stop();
			this.Timer11.Start();
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000840F File Offset: 0x0000660F
		private void Timer11_Tick(object sender, EventArgs e)
		{
			this.Dlls.ForeColor = Color.Blue;
			this.Timer11.Stop();
			this.Timer12.Start();
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000843B File Offset: 0x0000663B
		private void Timer12_Tick(object sender, EventArgs e)
		{
			this.Dlls.ForeColor = Color.Pink;
			this.Timer12.Stop();
			this.Timer10.Start();
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000030CF File Offset: 0x000012CF
		private void ReactorProgressBar1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000030CF File Offset: 0x000012CF
		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00008467 File Offset: 0x00006667
		private void Timer13_Tick(object sender, EventArgs e)
		{
			this.Button3.ForeColor = Color.Blue;
			this.Timer13.Stop();
			this.Timer14.Start();
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00008493 File Offset: 0x00006693
		private void Timer14_Tick(object sender, EventArgs e)
		{
			this.Button3.ForeColor = Color.Red;
			this.Timer14.Stop();
			this.Timer15.Start();
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000084BF File Offset: 0x000066BF
		private void Timer15_Tick(object sender, EventArgs e)
		{
			this.Button3.ForeColor = Color.Pink;
			this.Timer15.Stop();
			this.Timer13.Start();
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000084EB File Offset: 0x000066EB
		private void Timer16_Tick(object sender, EventArgs e)
		{
			this.Button1.ForeColor = Color.Red;
			this.Timer16.Stop();
			this.Timer17.Start();
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00008517 File Offset: 0x00006717
		private void Timer17_Tick(object sender, EventArgs e)
		{
			this.Button1.ForeColor = Color.Blue;
			this.Timer17.Stop();
			this.Timer18.Start();
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00008543 File Offset: 0x00006743
		private void Timer18_Tick(object sender, EventArgs e)
		{
			this.Button1.ForeColor = Color.Pink;
			this.Timer18.Stop();
			this.Timer16.Start();
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000856F File Offset: 0x0000676F
		private void Timer19_Tick(object sender, EventArgs e)
		{
			this.Label3.ForeColor = Color.Red;
			this.Timer19.Stop();
			this.Timer20.Start();
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000859B File Offset: 0x0000679B
		private void Timer20_Tick(object sender, EventArgs e)
		{
			this.Label3.ForeColor = Color.White;
			this.Timer20.Stop();
			this.Timer19.Start();
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000085C8 File Offset: 0x000067C8
		private void Dlls_SelectedIndexChanged(object sender, EventArgs e)
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
				this.Timer20.Stop();
				IL_19:
				num2 = 3;
				this.Button3.Refresh();
				IL_27:
				num2 = 4;
				this.Label1.Refresh();
				IL_35:
				goto IL_A0;
				IL_37:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_59:
				goto IL_95;
				IL_5B:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_73:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_5B;
			}
			IL_95:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_A0:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000030CF File Offset: 0x000012CF
		private void ReactorRadioButton1_CheckedChanged(object sender)
		{
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000030CF File Offset: 0x000012CF
		private void ReactorRadioButton1_CheckedChanged_1(object sender)
		{
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000030CF File Offset: 0x000012CF
		private void Label3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000030CF File Offset: 0x000012CF
		private void ReactorButton1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000030CF File Offset: 0x000012CF
		private void Label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00008690 File Offset: 0x00006890
		private void RadioButton1_CheckedChanged_1(object sender, EventArgs e)
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
				this.Button3.Refresh();
				IL_19:
				num2 = 3;
				this.Timer1.Start();
				IL_27:
				num2 = 4;
				this.Label1.Refresh();
				IL_35:
				num2 = 5;
				this.CheckBox1.Checked = true;
				IL_44:
				num2 = 6;
				this.CheckBox1.Enabled = false;
				IL_53:
				num2 = 7;
				this.CheckBox1.Visible = true;
				IL_62:
				num2 = 8;
				this.Button3.Enabled = false;
				IL_71:
				num2 = 9;
				this.Button3.Visible = true;
				IL_81:
				goto IL_100;
				IL_83:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_B9:
				goto IL_F5;
				IL_BB:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_D3:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_BB;
			}
			IL_F5:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_100:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000030CF File Offset: 0x000012CF
		private void ReactorTopButton1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000087B8 File Offset: 0x000069B8
		private void ReactorButton1_Click_1(object sender, EventArgs e)
		{
			MyProject.Forms.B1.Show();
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000087CC File Offset: 0x000069CC
		private void ReactorButton2_Click(object sender, EventArgs e)
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
				this.ReactorTheme1.Enabled = false;
				IL_1A:
				num2 = 3;
				Interaction.MsgBox("Yukarı TextBox Bölümde PROCESS:: Ora'ya Örnk: csgo Yazarsanız Çalışır Injector Başka Oyunlarda Bullamasanız Oyunu Açıp Görevyöneticisi açıp yukardan ayrıntılar basıp orda yazar örnk.exe gibi :) exe'yi yazmanıza gerek yok Ve Oyunu Arkada Açık Olsun Bu İşi Yaparken ", MsgBoxStyle.Question, "Nasıl Çalışır InjectoR V5+ ?");
				IL_2E:
				num2 = 4;
				this.ReactorTheme1.Enabled = true;
				IL_3D:
				num2 = 5;
				this.TextBox1.Select();
				IL_4B:
				goto IL_BA;
				IL_4D:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_73:
				goto IL_AF;
				IL_75:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_8D:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_75;
			}
			IL_AF:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_BA:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000088AC File Offset: 0x00006AAC
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void ReactorButton3_Click(object sender, EventArgs e)
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
				bool isAvailable = MyProject.Computer.Network.IsAvailable;
				if (!isAvailable)
				{
					IL_38:
					num2 = 5;
					Interaction.MsgBox("Bu Program Açılmadı (Destek için Geliştiricilerle Konuşun !", MsgBoxStyle.OkCancel | MsgBoxStyle.Critical | MsgBoxStyle.Question, "InjectoR V5+");
					IL_4C:
					num2 = 6;
					Application.Restart();
					IL_54:
					num2 = 7;
					this.ReactorTheme1.Enabled = false;
					IL_63:
					num2 = 8;
					base.Close();
					IL_6C:
					goto IL_6D;
				}
				IL_20:
				num2 = 3;
				Interaction.MsgBox("Bilgisayarınız İnternete Bağlandı.", MsgBoxStyle.Information, "InjectoR V5+");
				IL_34:
				IL_6D:
				num2 = 10;
				bool isAvailable2 = MyProject.Computer.Network.IsAvailable;
				if (!isAvailable2)
				{
					IL_89:
					num2 = 12;
					Interaction.MsgBox("Bu Program Açılmadı (Destek için Geliştiricilerle Konuşun !", MsgBoxStyle.OkCancel | MsgBoxStyle.Critical | MsgBoxStyle.Question, "InjectoR V5+");
					IL_9E:
					num2 = 13;
					this.Label3.Enabled = false;
					IL_AE:
					num2 = 14;
					this.ReactorTheme1.Enabled = false;
					IL_BE:
					num2 = 15;
					Application.Restart();
					IL_C7:
					num2 = 16;
					base.Close();
					ProjectData.EndApp();
					IL_D7:;
				}
				IL_85:
				IL_D8:
				goto IL_17A;
				IL_DD:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_133:
				goto IL_16F;
				IL_135:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_14D:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_135;
			}
			IL_16F:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_17A:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000030CF File Offset: 0x000012CF
		private void ReactorButton4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000030CF File Offset: 0x000012CF
		private void ReactorButton5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00008A58 File Offset: 0x00006C58
		private void Timer21_Tick(object sender, EventArgs e)
		{
			this.RadioButton2.ForeColor = Color.Red;
			this.Timer21.Stop();
			this.Timer22.Start();
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00008A84 File Offset: 0x00006C84
		private void Timer22_Tick(object sender, EventArgs e)
		{
			this.RadioButton2.ForeColor = Color.Blue;
			this.Timer22.Stop();
			this.Timer23.Start();
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00008AB0 File Offset: 0x00006CB0
		private void Timer23_Tick(object sender, EventArgs e)
		{
			this.RadioButton2.ForeColor = Color.Pink;
			this.Timer23.Stop();
			this.Timer24.Start();
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00008ADC File Offset: 0x00006CDC
		private void Timer24_Tick(object sender, EventArgs e)
		{
			this.RadioButton2.ForeColor = Color.Yellow;
			this.Timer24.Stop();
			this.Timer25.Start();
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00008B08 File Offset: 0x00006D08
		private void Timer25_Tick(object sender, EventArgs e)
		{
			this.RadioButton2.ForeColor = Color.Teal;
			this.Timer25.Stop();
			this.Timer26.Start();
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00008B34 File Offset: 0x00006D34
		private void Timer26_Tick(object sender, EventArgs e)
		{
			this.RadioButton2.ForeColor = Color.Green;
			this.Timer26.Stop();
			this.Timer21.Start();
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000030CF File Offset: 0x000012CF
		private void TabPage2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00008B60 File Offset: 0x00006D60
		private void Timer29_Tick(object sender, EventArgs e)
		{
			this.Label2.ForeColor = Color.Yellow;
			this.Timer29.Stop();
			this.Timer27.Start();
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00008B8C File Offset: 0x00006D8C
		private void Timer27_Tick(object sender, EventArgs e)
		{
			this.Label2.ForeColor = Color.Blue;
			this.Timer27.Stop();
			this.Timer28.Start();
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00008BB8 File Offset: 0x00006DB8
		private void Timer28_Tick(object sender, EventArgs e)
		{
			this.Label2.ForeColor = Color.Red;
			this.Timer28.Stop();
			this.Timer29.Start();
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000030CF File Offset: 0x000012CF
		private void ReactorCheckBox1_CheckedChanged(object sender)
		{
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000030CF File Offset: 0x000012CF
		private void RadioButton3_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000030CF File Offset: 0x000012CF
		private void Label4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000030CF File Offset: 0x000012CF
		private void ReactorButton3_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00008BE4 File Offset: 0x00006DE4
		private void Button5_Click_1(object sender, EventArgs e)
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
				bool isAvailable = MyProject.Computer.Network.IsAvailable;
				if (!isAvailable)
				{
					IL_3E:
					num2 = 5;
					Interaction.MsgBox("Bu Program Açılmadı (Destek için Geliştiricilerle Konuşun !", MsgBoxStyle.OkCancel | MsgBoxStyle.Critical | MsgBoxStyle.Question, "InjectoR V5+");
					IL_52:
					num2 = 6;
					Application.Restart();
					IL_5A:
					num2 = 7;
					base.Close();
					IL_63:
					goto IL_64;
				}
				IL_20:
				num2 = 3;
				IntPtr mainWindowHandle = Process.GetCurrentProcess().MainWindowHandle;
				bool flag = WindowsApi.FlashWindow(ref mainWindowHandle, true, true, 5);
				IL_3A:
				IL_64:
				num2 = 9;
				this.ReactorTheme1.Enabled = false;
				IL_74:
				num2 = 10;
				Process.Start("C:\\Windows\\System32\\cleanmgr.exe");
				IL_82:
				num2 = 11;
				MyProject.Forms.V5.Refresh();
				IL_95:
				num2 = 12;
				MyProject.Forms.V5.Show();
				IL_A8:
				num2 = 13;
				Interaction.MsgBox("Program 1-2 DK Yanıt Vermiyebillir , Lütfen Bekleyiniz !!!", MsgBoxStyle.OkOnly, null);
				IL_B8:
				num2 = 14;
				this.PictureBox8.Visible = false;
				IL_C8:
				num2 = 15;
				this.PictureBox7.Visible = false;
				IL_D8:
				num2 = 16;
				this.PictureBox6.Visible = false;
				IL_E8:
				num2 = 17;
				Directory.Delete("C:\\Users\\" + Environment.UserName + "\\Recent\\", true);
				IL_106:
				num2 = 18;
				Directory.Delete("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Temp", true);
				IL_124:
				num2 = 19;
				Directory.Delete("C:\\Windows\\prefetch\\", true);
				IL_133:
				num2 = 20;
				Directory.Delete("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\CrashDumps", true);
				IL_151:
				num2 = 21;
				Directory.Delete("C:\\Windows\\ServiceProfiles\\LocalService\\AppData\\Local", true);
				IL_160:
				num2 = 22;
				Directory.Delete("C:\\Windows\\Logs", true);
				IL_16F:
				num2 = 23;
				Directory.Delete("C:\\Windows\\System32\\temp\\", true);
				IL_17E:
				num2 = 24;
				Directory.Delete("C:\\Windows\\Temp", true);
				IL_18D:
				num2 = 25;
				Directory.Delete("C:\\Windows\\System32\\TEMP\\", true);
				IL_19C:
				num2 = 26;
				Directory.Delete("C:\\Windows\\Logs", true);
				IL_1AB:
				num2 = 27;
				Directory.Delete("C:\\Windows\\System32\\winevt\\Logs\\", true);
				IL_1BA:
				num2 = 28;
				Directory.Delete("C:\\Windows\\SoftwareDistribution", true);
				IL_1C9:
				num2 = 29;
				Directory.Delete("C:\\Windows\\SoftwareDistribution\\Download\\", true);
				IL_1D8:
				num2 = 30;
				Directory.Delete("C:\\Windows\\INF\\", true);
				IL_1E7:
				num2 = 31;
				Directory.Delete("%TMP%", true);
				IL_1F6:
				num2 = 32;
				this.Label6.Hide();
				IL_205:
				num2 = 33;
				this.Button5.Hide();
				IL_214:
				num2 = 34;
				this.ReactorTheme1.Enabled = true;
				IL_224:
				num2 = 35;
				Interaction.MsgBox("Tüm Gereksiz Temp&Logs Gibi Dosyalar Silindi,VB Program Yeniden Başlatılıyor...", MsgBoxStyle.OkOnly, null);
				IL_234:
				num2 = 36;
				Application.Restart();
				IL_23D:
				goto IL_32B;
				IL_242:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_2E4:
				goto IL_320;
				IL_2E6:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_2FE:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_2E6;
			}
			IL_320:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_32B:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00008F44 File Offset: 0x00007144
		private void Button6_Click_1(object sender, EventArgs e)
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
				MyProject.Forms.V4.Show();
				IL_1D:
				goto IL_80;
				IL_1F:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_39:
				goto IL_75;
				IL_3B:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_53:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_3B;
			}
			IL_75:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_80:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000030CF File Offset: 0x000012CF
		private void PictureBox3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600013B RID: 315 RVA: 0x000030CF File Offset: 0x000012CF
		private void PictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600013C RID: 316 RVA: 0x000030CF File Offset: 0x000012CF
		private void PictureBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000030CF File Offset: 0x000012CF
		private void TabPage3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000030CF File Offset: 0x000012CF
		private void TabPage1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000030CF File Offset: 0x000012CF
		private void PictureBox4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000030CF File Offset: 0x000012CF
		private void PictureBox5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000141 RID: 321 RVA: 0x000030CF File Offset: 0x000012CF
		private void TabPage4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000142 RID: 322 RVA: 0x000030CF File Offset: 0x000012CF
		private void ReactorTabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000143 RID: 323 RVA: 0x000030CF File Offset: 0x000012CF
		private void Label5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000030CF File Offset: 0x000012CF
		private void Label6_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000030CF File Offset: 0x000012CF
		private void TabPage2_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000030CF File Offset: 0x000012CF
		private void TextBox1_TextChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000030CF File Offset: 0x000012CF
		private void ProgressBar1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00008FEC File Offset: 0x000071EC
		private void RadioButton3_CheckedChanged_1(object sender, EventArgs e)
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
				this.RadioButton4.Enabled = false;
				IL_1A:
				num2 = 3;
				this.Timer3.Enabled = false;
				IL_29:
				num2 = 4;
				this.Timer31.Enabled = false;
				IL_38:
				num2 = 5;
				this.Timer30.Enabled = false;
				IL_47:
				num2 = 6;
				this.Timer32.Enabled = false;
				IL_56:
				num2 = 7;
				this.Timer4.Enabled = false;
				IL_65:
				num2 = 8;
				this.Timer5.Enabled = false;
				IL_74:
				num2 = 9;
				this.Timer6.Enabled = false;
				IL_84:
				num2 = 10;
				this.Timer7.Enabled = false;
				IL_94:
				num2 = 11;
				this.Timer8.Enabled = false;
				IL_A4:
				num2 = 12;
				this.Timer9.Enabled = false;
				IL_B4:
				num2 = 13;
				this.Timer10.Enabled = false;
				IL_C4:
				num2 = 14;
				this.Timer11.Enabled = false;
				IL_D4:
				num2 = 15;
				this.Timer12.Enabled = false;
				IL_E4:
				num2 = 16;
				this.Timer13.Enabled = false;
				IL_F4:
				num2 = 17;
				this.Timer14.Enabled = false;
				IL_104:
				num2 = 18;
				this.Timer15.Enabled = false;
				IL_114:
				num2 = 19;
				this.Timer16.Enabled = false;
				IL_124:
				num2 = 20;
				this.Timer17.Enabled = false;
				IL_134:
				num2 = 21;
				this.Timer18.Enabled = false;
				IL_144:
				num2 = 22;
				this.Timer19.Enabled = false;
				IL_154:
				num2 = 23;
				this.Timer20.Enabled = false;
				IL_164:
				num2 = 24;
				this.Timer21.Enabled = false;
				IL_174:
				num2 = 25;
				this.Timer22.Enabled = false;
				IL_184:
				num2 = 26;
				this.Timer23.Enabled = false;
				IL_194:
				num2 = 27;
				this.Timer24.Enabled = false;
				IL_1A4:
				num2 = 28;
				this.Timer25.Enabled = false;
				IL_1B4:
				num2 = 29;
				this.Timer26.Enabled = false;
				IL_1C4:
				num2 = 30;
				this.Timer27.Enabled = false;
				IL_1D4:
				num2 = 31;
				this.Timer28.Enabled = false;
				IL_1E4:
				num2 = 32;
				this.Timer29.Enabled = false;
				IL_1F4:
				num2 = 33;
				this.RadioButton4.Enabled = true;
				IL_204:
				goto IL_2E6;
				IL_209:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_29F:
				goto IL_2DB;
				IL_2A1:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_2B9:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_2A1;
			}
			IL_2DB:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_2E6:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00009304 File Offset: 0x00007504
		private void RadioButton4_CheckedChanged(object sender, EventArgs e)
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
				this.RadioButton3.Enabled = false;
				IL_1A:
				num2 = 3;
				this.Timer2.Enabled = true;
				IL_29:
				num2 = 4;
				this.Timer30.Enabled = true;
				IL_38:
				num2 = 5;
				this.Timer31.Enabled = true;
				IL_47:
				num2 = 6;
				this.Timer3.Enabled = true;
				IL_56:
				num2 = 7;
				this.Timer4.Enabled = true;
				IL_65:
				num2 = 8;
				this.Timer5.Enabled = true;
				IL_74:
				num2 = 9;
				this.Timer6.Enabled = true;
				IL_84:
				num2 = 10;
				this.Timer7.Enabled = true;
				IL_94:
				num2 = 11;
				this.Timer8.Enabled = true;
				IL_A4:
				num2 = 12;
				this.Timer9.Enabled = true;
				IL_B4:
				num2 = 13;
				this.Timer10.Enabled = true;
				IL_C4:
				num2 = 14;
				this.Timer11.Enabled = true;
				IL_D4:
				num2 = 15;
				this.Timer12.Enabled = true;
				IL_E4:
				num2 = 16;
				this.Timer13.Enabled = true;
				IL_F4:
				num2 = 17;
				this.Timer14.Enabled = true;
				IL_104:
				num2 = 18;
				this.Timer15.Enabled = true;
				IL_114:
				num2 = 19;
				this.Timer16.Enabled = true;
				IL_124:
				num2 = 20;
				this.Timer17.Enabled = true;
				IL_134:
				num2 = 21;
				this.Timer18.Enabled = true;
				IL_144:
				num2 = 22;
				this.Timer19.Enabled = true;
				IL_154:
				num2 = 23;
				this.Timer20.Enabled = true;
				IL_164:
				num2 = 24;
				this.Timer21.Enabled = true;
				IL_174:
				num2 = 25;
				this.Timer22.Enabled = true;
				IL_184:
				num2 = 26;
				this.Timer23.Enabled = true;
				IL_194:
				num2 = 27;
				this.Timer24.Enabled = true;
				IL_1A4:
				num2 = 28;
				this.Timer25.Enabled = true;
				IL_1B4:
				num2 = 29;
				this.Timer26.Enabled = true;
				IL_1C4:
				num2 = 30;
				this.Timer27.Enabled = true;
				IL_1D4:
				num2 = 31;
				this.Timer28.Enabled = true;
				IL_1E4:
				num2 = 32;
				this.Timer29.Enabled = true;
				IL_1F4:
				num2 = 33;
				this.RadioButton3.Enabled = true;
				IL_204:
				goto IL_2E6;
				IL_209:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_29F:
				goto IL_2DB;
				IL_2A1:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_2B9:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_2A1;
			}
			IL_2DB:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_2E6:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0000961C File Offset: 0x0000781C
		private void CheckBox2_CheckedChanged(object sender, EventArgs e)
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
				this.ReactorTheme1.Enabled = false;
				IL_1A:
				num2 = 3;
				this.CheckBox3.Enabled = false;
				IL_29:
				num2 = 4;
				this.CheckBox3.Visible = false;
				IL_38:
				num2 = 5;
				Interaction.MsgBox("Steam, Gibi Programlar Kapatılacaktır Ve , Güvenle Inject Edebilirsiniz :)", MsgBoxStyle.OkOnly, "VAC V5+");
				IL_4B:
				num2 = 6;
				Interaction.Shell("TASKKILL /F /IM netsession_win.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_5B:
				num2 = 7;
				Interaction.Shell("TASKKILL /F /IM steam.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_6B:
				num2 = 8;
				Interaction.Shell("TASKKILL /F /IM SteamService.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_7B:
				num2 = 9;
				Interaction.Shell("TASKKILL /F /IM MSASCuiL.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_8C:
				num2 = 10;
				Interaction.Shell("TASKKILL /F /IM UninstallMonitor.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_9D:
				num2 = 11;
				Interaction.Shell("TASKKILL /F /IM SearchUI.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_AE:
				num2 = 12;
				Interaction.Shell("TASKKILL /F /IM MpCmdRun.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_BF:
				num2 = 13;
				Interaction.Shell("TASKKILL /F /IM HijackThis.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_D0:
				num2 = 14;
				Interaction.Shell("TASKKILL /F /IM extremeinjector.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_E1:
				num2 = 15;
				Interaction.Shell("TASKKILL /F /IM ProcessHacker.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_F2:
				num2 = 16;
				Interaction.Shell("TASKKILL /F /IM DLLInjector v2.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_103:
				num2 = 17;
				Interaction.MsgBox("VAC Korumalı Olan Programlar, Kapatıldı ! :)", MsgBoxStyle.OkOnly, null);
				IL_113:
				num2 = 18;
				this.ReactorTheme1.Enabled = true;
				IL_123:
				num2 = 19;
				this.CheckBox2.Visible = false;
				IL_133:
				goto IL_1DD;
				IL_138:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_196:
				goto IL_1D2;
				IL_198:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_1B0:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_198;
			}
			IL_1D2:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_1DD:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000982C File Offset: 0x00007A2C
		private void CheckBox3_CheckedChanged(object sender, EventArgs e)
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
				this.ReactorTheme1.Enabled = false;
				IL_1A:
				num2 = 3;
				this.CheckBox2.Enabled = false;
				IL_29:
				num2 = 4;
				this.CheckBox2.Visible = false;
				IL_38:
				num2 = 5;
				Interaction.MsgBox("Korumalı Programlar Kapatıldı :) İYİ İNJECT'LER", MsgBoxStyle.OkOnly, "SY V5+");
				IL_4B:
				num2 = 6;
				Interaction.Shell("TASKKILL /F /IM MSASCuiL.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_5B:
				num2 = 7;
				Interaction.Shell("TASKKILL /F /IM UninstallMonitor.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_6B:
				num2 = 8;
				Interaction.Shell("TASKKILL /F /IM Taskmgr.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_7B:
				num2 = 9;
				Interaction.Shell("TASKKILL /F /IM avast.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_8C:
				num2 = 10;
				Interaction.Shell("TASKKILL /F /IM avira.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_9D:
				num2 = 11;
				Interaction.Shell("TASKKILL /F /IM Norton Security Deluxe.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_AE:
				num2 = 12;
				Interaction.Shell("TASKKILL /F /IM Avast Pro Antivirus.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_BF:
				num2 = 13;
				Interaction.Shell("TASKKILL /F /IM McAfee AntiVirus.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_D0:
				num2 = 14;
				Interaction.Shell("TASKKILL /F /IM McAfee.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_E1:
				num2 = 15;
				Interaction.Shell("TASKKILL /F /IM 360.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_F2:
				num2 = 16;
				Interaction.Shell("TASKKILL /F /IM Kaspersky Anti-Virus.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_103:
				num2 = 17;
				Interaction.Shell("TASKKILL /F /IM Kaspersky.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_114:
				num2 = 18;
				Interaction.Shell("TASKKILL /F /IM Bitdefender Antivirus Plus.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_125:
				num2 = 19;
				Interaction.Shell("TASKKILL /F /IM AdwCleaner.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_136:
				num2 = 20;
				Interaction.Shell("TASKKILL /F /IM Malwarebytes AdwCleaner 7.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_147:
				num2 = 21;
				Interaction.Shell("TASKKILL /F /IM MpCmdRun.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_158:
				num2 = 22;
				Interaction.Shell("TASKKILL /F /IM Comodo Cloud Antivirus.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_169:
				num2 = 23;
				Interaction.Shell("TASKKILL /F /IM BitDefender Antivirus Free Edition.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_17A:
				num2 = 24;
				Interaction.Shell("TASKKILL /F /IM Panda Free Anti-Virus 2018.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_18B:
				num2 = 25;
				Interaction.Shell("TASKKILL /F /IM Ad-Aware Free Anti-Virus+.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_19C:
				num2 = 26;
				Interaction.Shell("TASKKILL /F /IM MalwareBytes Anti-Malware.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_1AD:
				num2 = 27;
				Interaction.Shell("TASKKILL /F /IM SpyBot Search and Destroy.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_1BE:
				num2 = 28;
				Interaction.Shell("TASKKILL /F /IM Emsisoft Emergency Kit.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_1CF:
				num2 = 29;
				Interaction.Shell("TASKKILL /F /IM HijackThis.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_1E0:
				num2 = 30;
				Interaction.Shell("TASKKILL /F /IM ESET NOD32 Antivirus.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_1F1:
				num2 = 31;
				Interaction.Shell("TASKKILL /F /IM ESETNOD32.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_202:
				num2 = 32;
				Interaction.Shell("TASKKILL /F /IM extremeinjector.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_213:
				num2 = 33;
				Interaction.Shell("TASKKILL /F /IM ProcessHacker.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_224:
				num2 = 34;
				Interaction.Shell("TASKKILL /F /IM DLLInjector v2.exe", AppWinStyle.MinimizedFocus, false, -1);
				IL_235:
				num2 = 35;
				this.ReactorTheme1.Enabled = true;
				IL_245:
				num2 = 36;
				this.CheckBox3.Visible = false;
				IL_255:
				goto IL_343;
				IL_25A:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_2FC:
				goto IL_338;
				IL_2FE:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_316:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_2FE;
			}
			IL_338:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_343:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x000030CF File Offset: 0x000012CF
		private void GecikmeSec_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x0600014D RID: 333 RVA: 0x000030CF File Offset: 0x000012CF
		private void PictureBox1_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000030CF File Offset: 0x000012CF
		private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00009BA4 File Offset: 0x00007DA4
		private void Timer30_Tick(object sender, EventArgs e)
		{
			this.RadioButton1.ForeColor = Color.Red;
			this.Timer30.Stop();
			this.Timer31.Stop();
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00009BD0 File Offset: 0x00007DD0
		private void Timer31_Tick(object sender, EventArgs e)
		{
			this.RadioButton1.ForeColor = Color.Yellow;
			this.Timer31.Stop();
			this.Timer32.Start();
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00009BFC File Offset: 0x00007DFC
		private void Timer32_Tick(object sender, EventArgs e)
		{
			this.RadioButton1.ForeColor = Color.Green;
			this.Timer32.Stop();
			this.Timer31.Start();
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00009C28 File Offset: 0x00007E28
		private void Button3_Click(object sender, EventArgs e)
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
				this.Timer1.Start();
				IL_19:
				num2 = 3;
				bool flag = File.Exists(this.OpenFileDialog1.FileName);
				if (flag)
				{
				}
				IL_31:
				IL_33:
				num2 = 5;
				Process[] processesByName = Process.GetProcessesByName(this.TextBox1.Text);
				IL_46:
				num2 = 6;
				bool flag2 = processesByName.Length == 0;
				if (!flag2)
				{
					IL_F0:
					num2 = 15;
					this.PictureBox8.Visible = false;
					IL_100:
					num2 = 16;
					this.PictureBox7.Visible = true;
					IL_110:
					num2 = 17;
					this.Timer1.Stop();
					IL_11F:
					num2 = 18;
					this.Label1.ForeColor = Color.Green;
					IL_133:
					num2 = 19;
					this.Inject();
					IL_13D:
					num2 = 20;
					this.ProgressBar1.Value = 100;
					IL_14E:
					num2 = 21;
					this.PictureBox8.Visible = false;
					IL_15E:
					num2 = 22;
					this.PictureBox7.Visible = false;
					IL_16E:
					num2 = 23;
					this.PictureBox6.Visible = false;
					IL_17E:
					num2 = 24;
					this.PictureBox7.Visible = true;
					IL_18E:
					num2 = 25;
					this.Label1.Text = "> Başarılı Inject :) <";
					IL_1A2:
					num2 = 26;
					bool @checked = this.CheckBox1.Checked;
					if (!@checked)
					{
						IL_1C4:
						goto IL_1C5;
					}
					IL_1B6:
					num2 = 27;
					base.Close();
					IL_1C0:
					IL_1C5:
					goto IL_1C6;
				}
				IL_57:
				num2 = 7;
				this.ProgressBar1.Value = 5;
				IL_66:
				num2 = 8;
				this.Label1.Text = ((this.TextBox1.Text + ".exe") ?? "");
				IL_92:
				num2 = 9;
				this.TextBox1.Select();
				IL_A1:
				num2 = 10;
				this.Label5.ForeColor = Color.GreenYellow;
				IL_B5:
				num2 = 11;
				this.PictureBox8.Visible = true;
				IL_C5:
				num2 = 12;
				this.PictureBox7.Visible = false;
				IL_D5:
				num2 = 13;
				this.Label5.Text = "DLL' Seçmediniz !...";
				IL_E9:
				IL_1C6:
				goto IL_29C;
				IL_1CB:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_255:
				goto IL_291;
				IL_257:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_26F:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_257;
			}
			IL_291:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_29C:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00009EF8 File Offset: 0x000080F8
		private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
			this.PictureBox8.Visible = false;
			this.PictureBox7.Visible = false;
			this.PictureBox6.Visible = false;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x000030CF File Offset: 0x000012CF
		private void Button7_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00009F22 File Offset: 0x00008122
		private void Button8_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Form1.Show();
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00009F38 File Offset: 0x00008138
		private void CheckBox4_CheckedChanged(object sender, EventArgs e)
		{
			int num;
			int num3;
			object obj;
			try
			{
				IL_02:
				ProjectData.ClearProjectError();
				num = -2;
				IL_0B:
				goto IL_6A;
				IL_0D:
				int num2 = num3 + 1;
				num3 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
				IL_23:
				goto IL_5F;
				IL_25:
				int num4;
				num3 = num4;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_3D:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num3 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_25;
			}
			IL_5F:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_6A:
			if (num3 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000030CF File Offset: 0x000012CF
		private void Timer33_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000030CF File Offset: 0x000012CF
		private void PictureBox8_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600015B RID: 347 RVA: 0x0000C449 File Offset: 0x0000A649
		// (set) Token: 0x0600015C RID: 348 RVA: 0x0000C454 File Offset: 0x0000A654
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

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600015D RID: 349 RVA: 0x0000C497 File Offset: 0x0000A697
		// (set) Token: 0x0600015E RID: 350 RVA: 0x0000C4A4 File Offset: 0x0000A6A4
		internal virtual OpenFileDialog OpenFileDialog1
		{
			[CompilerGenerated]
			get
			{
				return this._OpenFileDialog1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				CancelEventHandler value2 = new CancelEventHandler(this.OpenFileDialog1_FileOk);
				OpenFileDialog openFileDialog = this._OpenFileDialog1;
				if (openFileDialog != null)
				{
					openFileDialog.FileOk -= value2;
				}
				this._OpenFileDialog1 = value;
				openFileDialog = this._OpenFileDialog1;
				if (openFileDialog != null)
				{
					openFileDialog.FileOk += value2;
				}
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600015F RID: 351 RVA: 0x0000C4E7 File Offset: 0x0000A6E7
		// (set) Token: 0x06000160 RID: 352 RVA: 0x0000C4F4 File Offset: 0x0000A6F4
		internal virtual Button Button1
		{
			[CompilerGenerated]
			get
			{
				return this._Button1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click);
				Button button = this._Button1;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button1 = value;
				button = this._Button1;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000161 RID: 353 RVA: 0x0000C537 File Offset: 0x0000A737
		// (set) Token: 0x06000162 RID: 354 RVA: 0x0000C544 File Offset: 0x0000A744
		internal virtual Button Button2
		{
			[CompilerGenerated]
			get
			{
				return this._Button2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button2_Click);
				Button button = this._Button2;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button2 = value;
				button = this._Button2;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000163 RID: 355 RVA: 0x0000C587 File Offset: 0x0000A787
		// (set) Token: 0x06000164 RID: 356 RVA: 0x0000C594 File Offset: 0x0000A794
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

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000165 RID: 357 RVA: 0x0000C5D7 File Offset: 0x0000A7D7
		// (set) Token: 0x06000166 RID: 358 RVA: 0x0000C5E4 File Offset: 0x0000A7E4
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

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000167 RID: 359 RVA: 0x0000C627 File Offset: 0x0000A827
		// (set) Token: 0x06000168 RID: 360 RVA: 0x0000C634 File Offset: 0x0000A834
		internal virtual Button Button4
		{
			[CompilerGenerated]
			get
			{
				return this._Button4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button4_Click);
				Button button = this._Button4;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button4 = value;
				button = this._Button4;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000169 RID: 361 RVA: 0x0000C677 File Offset: 0x0000A877
		// (set) Token: 0x0600016A RID: 362 RVA: 0x0000C684 File Offset: 0x0000A884
		internal virtual ListBox Dlls
		{
			[CompilerGenerated]
			get
			{
				return this._Dlls;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Dlls_SelectedIndexChanged);
				ListBox dlls = this._Dlls;
				if (dlls != null)
				{
					dlls.SelectedIndexChanged -= value2;
				}
				this._Dlls = value;
				dlls = this._Dlls;
				if (dlls != null)
				{
					dlls.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600016B RID: 363 RVA: 0x0000C6C7 File Offset: 0x0000A8C7
		// (set) Token: 0x0600016C RID: 364 RVA: 0x0000C6D4 File Offset: 0x0000A8D4
		internal virtual RadioButton RadioButton2
		{
			[CompilerGenerated]
			get
			{
				return this._RadioButton2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RadioButton2_CheckedChanged);
				RadioButton radioButton = this._RadioButton2;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= value2;
				}
				this._RadioButton2 = value;
				radioButton = this._RadioButton2;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600016D RID: 365 RVA: 0x0000C717 File Offset: 0x0000A917
		// (set) Token: 0x0600016E RID: 366 RVA: 0x0000C724 File Offset: 0x0000A924
		internal virtual ReactorTheme ReactorTheme1
		{
			[CompilerGenerated]
			get
			{
				return this._ReactorTheme1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ReactorTheme1_Click);
				EventHandler value3 = new EventHandler(this.ReactorTheme1_Click_1);
				ReactorTheme reactorTheme = this._ReactorTheme1;
				if (reactorTheme != null)
				{
					reactorTheme.Click -= value2;
					reactorTheme.Click -= value3;
				}
				this._ReactorTheme1 = value;
				reactorTheme = this._ReactorTheme1;
				if (reactorTheme != null)
				{
					reactorTheme.Click += value2;
					reactorTheme.Click += value3;
				}
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600016F RID: 367 RVA: 0x0000C782 File Offset: 0x0000A982
		// (set) Token: 0x06000170 RID: 368 RVA: 0x0000C78C File Offset: 0x0000A98C
		internal virtual Label Label3
		{
			[CompilerGenerated]
			get
			{
				return this._Label3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label3_Click);
				Label label = this._Label3;
				if (label != null)
				{
					label.Click -= value2;
				}
				this._Label3 = value;
				label = this._Label3;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000171 RID: 369 RVA: 0x0000C7CF File Offset: 0x0000A9CF
		// (set) Token: 0x06000172 RID: 370 RVA: 0x0000C7DC File Offset: 0x0000A9DC
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

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000173 RID: 371 RVA: 0x0000C81F File Offset: 0x0000AA1F
		// (set) Token: 0x06000174 RID: 372 RVA: 0x0000C82C File Offset: 0x0000AA2C
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

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000175 RID: 373 RVA: 0x0000C86F File Offset: 0x0000AA6F
		// (set) Token: 0x06000176 RID: 374 RVA: 0x0000C87C File Offset: 0x0000AA7C
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

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000177 RID: 375 RVA: 0x0000C8BF File Offset: 0x0000AABF
		// (set) Token: 0x06000178 RID: 376 RVA: 0x0000C8CC File Offset: 0x0000AACC
		internal virtual Timer Timer5
		{
			[CompilerGenerated]
			get
			{
				return this._Timer5;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer5_Tick);
				Timer timer = this._Timer5;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer5 = value;
				timer = this._Timer5;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000179 RID: 377 RVA: 0x0000C90F File Offset: 0x0000AB0F
		// (set) Token: 0x0600017A RID: 378 RVA: 0x0000C91C File Offset: 0x0000AB1C
		internal virtual Timer Timer6
		{
			[CompilerGenerated]
			get
			{
				return this._Timer6;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer6_Tick);
				Timer timer = this._Timer6;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer6 = value;
				timer = this._Timer6;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600017B RID: 379 RVA: 0x0000C95F File Offset: 0x0000AB5F
		// (set) Token: 0x0600017C RID: 380 RVA: 0x0000C96C File Offset: 0x0000AB6C
		internal virtual Timer Timer7
		{
			[CompilerGenerated]
			get
			{
				return this._Timer7;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer7_Tick);
				Timer timer = this._Timer7;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer7 = value;
				timer = this._Timer7;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600017D RID: 381 RVA: 0x0000C9AF File Offset: 0x0000ABAF
		// (set) Token: 0x0600017E RID: 382 RVA: 0x0000C9BC File Offset: 0x0000ABBC
		internal virtual Timer Timer8
		{
			[CompilerGenerated]
			get
			{
				return this._Timer8;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer8_Tick);
				Timer timer = this._Timer8;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer8 = value;
				timer = this._Timer8;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600017F RID: 383 RVA: 0x0000C9FF File Offset: 0x0000ABFF
		// (set) Token: 0x06000180 RID: 384 RVA: 0x0000CA0C File Offset: 0x0000AC0C
		internal virtual Timer Timer9
		{
			[CompilerGenerated]
			get
			{
				return this._Timer9;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer9_Tick);
				Timer timer = this._Timer9;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer9 = value;
				timer = this._Timer9;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000181 RID: 385 RVA: 0x0000CA4F File Offset: 0x0000AC4F
		// (set) Token: 0x06000182 RID: 386 RVA: 0x0000CA5C File Offset: 0x0000AC5C
		internal virtual Timer Timer10
		{
			[CompilerGenerated]
			get
			{
				return this._Timer10;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer10_Tick);
				Timer timer = this._Timer10;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer10 = value;
				timer = this._Timer10;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000183 RID: 387 RVA: 0x0000CA9F File Offset: 0x0000AC9F
		// (set) Token: 0x06000184 RID: 388 RVA: 0x0000CAAC File Offset: 0x0000ACAC
		internal virtual Timer Timer11
		{
			[CompilerGenerated]
			get
			{
				return this._Timer11;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer11_Tick);
				Timer timer = this._Timer11;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer11 = value;
				timer = this._Timer11;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000185 RID: 389 RVA: 0x0000CAEF File Offset: 0x0000ACEF
		// (set) Token: 0x06000186 RID: 390 RVA: 0x0000CAFC File Offset: 0x0000ACFC
		internal virtual Timer Timer12
		{
			[CompilerGenerated]
			get
			{
				return this._Timer12;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer12_Tick);
				Timer timer = this._Timer12;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer12 = value;
				timer = this._Timer12;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0000CB3F File Offset: 0x0000AD3F
		// (set) Token: 0x06000188 RID: 392 RVA: 0x0000CB4C File Offset: 0x0000AD4C
		internal virtual Timer Timer13
		{
			[CompilerGenerated]
			get
			{
				return this._Timer13;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer13_Tick);
				Timer timer = this._Timer13;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer13 = value;
				timer = this._Timer13;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000189 RID: 393 RVA: 0x0000CB8F File Offset: 0x0000AD8F
		// (set) Token: 0x0600018A RID: 394 RVA: 0x0000CB9C File Offset: 0x0000AD9C
		internal virtual Timer Timer14
		{
			[CompilerGenerated]
			get
			{
				return this._Timer14;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer14_Tick);
				Timer timer = this._Timer14;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer14 = value;
				timer = this._Timer14;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0000CBDF File Offset: 0x0000ADDF
		// (set) Token: 0x0600018C RID: 396 RVA: 0x0000CBEC File Offset: 0x0000ADEC
		internal virtual Timer Timer15
		{
			[CompilerGenerated]
			get
			{
				return this._Timer15;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer15_Tick);
				Timer timer = this._Timer15;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer15 = value;
				timer = this._Timer15;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600018D RID: 397 RVA: 0x0000CC2F File Offset: 0x0000AE2F
		// (set) Token: 0x0600018E RID: 398 RVA: 0x0000CC3C File Offset: 0x0000AE3C
		internal virtual Timer Timer16
		{
			[CompilerGenerated]
			get
			{
				return this._Timer16;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer16_Tick);
				Timer timer = this._Timer16;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer16 = value;
				timer = this._Timer16;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600018F RID: 399 RVA: 0x0000CC7F File Offset: 0x0000AE7F
		// (set) Token: 0x06000190 RID: 400 RVA: 0x0000CC8C File Offset: 0x0000AE8C
		internal virtual Timer Timer17
		{
			[CompilerGenerated]
			get
			{
				return this._Timer17;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer17_Tick);
				Timer timer = this._Timer17;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer17 = value;
				timer = this._Timer17;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000191 RID: 401 RVA: 0x0000CCCF File Offset: 0x0000AECF
		// (set) Token: 0x06000192 RID: 402 RVA: 0x0000CCDC File Offset: 0x0000AEDC
		internal virtual Timer Timer18
		{
			[CompilerGenerated]
			get
			{
				return this._Timer18;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer18_Tick);
				Timer timer = this._Timer18;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer18 = value;
				timer = this._Timer18;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000193 RID: 403 RVA: 0x0000CD1F File Offset: 0x0000AF1F
		// (set) Token: 0x06000194 RID: 404 RVA: 0x0000CD2C File Offset: 0x0000AF2C
		internal virtual Timer Timer19
		{
			[CompilerGenerated]
			get
			{
				return this._Timer19;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer19_Tick);
				Timer timer = this._Timer19;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer19 = value;
				timer = this._Timer19;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000195 RID: 405 RVA: 0x0000CD6F File Offset: 0x0000AF6F
		// (set) Token: 0x06000196 RID: 406 RVA: 0x0000CD7C File Offset: 0x0000AF7C
		internal virtual Timer Timer20
		{
			[CompilerGenerated]
			get
			{
				return this._Timer20;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer20_Tick);
				Timer timer = this._Timer20;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer20 = value;
				timer = this._Timer20;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000197 RID: 407 RVA: 0x0000CDBF File Offset: 0x0000AFBF
		// (set) Token: 0x06000198 RID: 408 RVA: 0x0000CDCC File Offset: 0x0000AFCC
		internal virtual RadioButton RadioButton1
		{
			[CompilerGenerated]
			get
			{
				return this._RadioButton1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RadioButton1_CheckedChanged_1);
				RadioButton radioButton = this._RadioButton1;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= value2;
				}
				this._RadioButton1 = value;
				radioButton = this._RadioButton1;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000199 RID: 409 RVA: 0x0000CE0F File Offset: 0x0000B00F
		// (set) Token: 0x0600019A RID: 410 RVA: 0x0000CE1C File Offset: 0x0000B01C
		internal virtual ReactorTabControl ReactorTabControl1
		{
			[CompilerGenerated]
			get
			{
				return this._ReactorTabControl1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ReactorTabControl1_SelectedIndexChanged);
				ReactorTabControl reactorTabControl = this._ReactorTabControl1;
				if (reactorTabControl != null)
				{
					reactorTabControl.SelectedIndexChanged -= value2;
				}
				this._ReactorTabControl1 = value;
				reactorTabControl = this._ReactorTabControl1;
				if (reactorTabControl != null)
				{
					reactorTabControl.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600019B RID: 411 RVA: 0x0000CE5F File Offset: 0x0000B05F
		// (set) Token: 0x0600019C RID: 412 RVA: 0x0000CE6C File Offset: 0x0000B06C
		internal virtual ReactorButton ReactorButton1
		{
			[CompilerGenerated]
			get
			{
				return this._ReactorButton1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ReactorButton1_Click_1);
				ReactorButton reactorButton = this._ReactorButton1;
				if (reactorButton != null)
				{
					reactorButton.Click -= value2;
				}
				this._ReactorButton1 = value;
				reactorButton = this._ReactorButton1;
				if (reactorButton != null)
				{
					reactorButton.Click += value2;
				}
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600019D RID: 413 RVA: 0x0000CEAF File Offset: 0x0000B0AF
		// (set) Token: 0x0600019E RID: 414 RVA: 0x0000CEBC File Offset: 0x0000B0BC
		internal virtual ReactorButton ReactorButton2
		{
			[CompilerGenerated]
			get
			{
				return this._ReactorButton2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ReactorButton2_Click);
				ReactorButton reactorButton = this._ReactorButton2;
				if (reactorButton != null)
				{
					reactorButton.Click -= value2;
				}
				this._ReactorButton2 = value;
				reactorButton = this._ReactorButton2;
				if (reactorButton != null)
				{
					reactorButton.Click += value2;
				}
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600019F RID: 415 RVA: 0x0000CEFF File Offset: 0x0000B0FF
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x0000CF0C File Offset: 0x0000B10C
		internal virtual TabPage TabPage1
		{
			[CompilerGenerated]
			get
			{
				return this._TabPage1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TabPage1_Click);
				TabPage tabPage = this._TabPage1;
				if (tabPage != null)
				{
					tabPage.Click -= value2;
				}
				this._TabPage1 = value;
				tabPage = this._TabPage1;
				if (tabPage != null)
				{
					tabPage.Click += value2;
				}
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x0000CF4F File Offset: 0x0000B14F
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x0000CF5C File Offset: 0x0000B15C
		internal virtual TabPage TabPage3
		{
			[CompilerGenerated]
			get
			{
				return this._TabPage3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TabPage3_Click);
				TabPage tabPage = this._TabPage3;
				if (tabPage != null)
				{
					tabPage.Click -= value2;
				}
				this._TabPage3 = value;
				tabPage = this._TabPage3;
				if (tabPage != null)
				{
					tabPage.Click += value2;
				}
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x0000CF9F File Offset: 0x0000B19F
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x0000CFAC File Offset: 0x0000B1AC
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

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x0000CFEF File Offset: 0x0000B1EF
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x0000CFFC File Offset: 0x0000B1FC
		internal virtual Timer Timer21
		{
			[CompilerGenerated]
			get
			{
				return this._Timer21;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer21_Tick);
				Timer timer = this._Timer21;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer21 = value;
				timer = this._Timer21;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x0000D03F File Offset: 0x0000B23F
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x0000D04C File Offset: 0x0000B24C
		internal virtual Timer Timer22
		{
			[CompilerGenerated]
			get
			{
				return this._Timer22;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer22_Tick);
				Timer timer = this._Timer22;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer22 = value;
				timer = this._Timer22;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x0000D08F File Offset: 0x0000B28F
		// (set) Token: 0x060001AA RID: 426 RVA: 0x0000D09C File Offset: 0x0000B29C
		internal virtual Timer Timer23
		{
			[CompilerGenerated]
			get
			{
				return this._Timer23;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer23_Tick);
				Timer timer = this._Timer23;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer23 = value;
				timer = this._Timer23;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001AB RID: 427 RVA: 0x0000D0DF File Offset: 0x0000B2DF
		// (set) Token: 0x060001AC RID: 428 RVA: 0x0000D0EC File Offset: 0x0000B2EC
		internal virtual Timer Timer24
		{
			[CompilerGenerated]
			get
			{
				return this._Timer24;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer24_Tick);
				Timer timer = this._Timer24;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer24 = value;
				timer = this._Timer24;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001AD RID: 429 RVA: 0x0000D12F File Offset: 0x0000B32F
		// (set) Token: 0x060001AE RID: 430 RVA: 0x0000D13C File Offset: 0x0000B33C
		internal virtual Timer Timer25
		{
			[CompilerGenerated]
			get
			{
				return this._Timer25;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer25_Tick);
				Timer timer = this._Timer25;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer25 = value;
				timer = this._Timer25;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001AF RID: 431 RVA: 0x0000D17F File Offset: 0x0000B37F
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x0000D18C File Offset: 0x0000B38C
		internal virtual Timer Timer26
		{
			[CompilerGenerated]
			get
			{
				return this._Timer26;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer26_Tick);
				Timer timer = this._Timer26;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer26 = value;
				timer = this._Timer26;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x0000D1CF File Offset: 0x0000B3CF
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x0000D1DC File Offset: 0x0000B3DC
		internal virtual Timer Timer27
		{
			[CompilerGenerated]
			get
			{
				return this._Timer27;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer27_Tick);
				Timer timer = this._Timer27;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer27 = value;
				timer = this._Timer27;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x0000D21F File Offset: 0x0000B41F
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x0000D22C File Offset: 0x0000B42C
		internal virtual Timer Timer28
		{
			[CompilerGenerated]
			get
			{
				return this._Timer28;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer28_Tick);
				Timer timer = this._Timer28;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer28 = value;
				timer = this._Timer28;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x0000D26F File Offset: 0x0000B46F
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x0000D27C File Offset: 0x0000B47C
		internal virtual Timer Timer29
		{
			[CompilerGenerated]
			get
			{
				return this._Timer29;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer29_Tick);
				Timer timer = this._Timer29;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer29 = value;
				timer = this._Timer29;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x0000D2BF File Offset: 0x0000B4BF
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x0000D2CC File Offset: 0x0000B4CC
		internal virtual TabPage TabPage2
		{
			[CompilerGenerated]
			get
			{
				return this._TabPage2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TabPage2_Click_1);
				TabPage tabPage = this._TabPage2;
				if (tabPage != null)
				{
					tabPage.Click -= value2;
				}
				this._TabPage2 = value;
				tabPage = this._TabPage2;
				if (tabPage != null)
				{
					tabPage.Click += value2;
				}
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x0000D30F File Offset: 0x0000B50F
		// (set) Token: 0x060001BA RID: 442 RVA: 0x0000D31C File Offset: 0x0000B51C
		internal virtual PictureBox PictureBox3
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBox3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBox3_Click);
				PictureBox pictureBox = this._PictureBox3;
				if (pictureBox != null)
				{
					pictureBox.Click -= value2;
				}
				this._PictureBox3 = value;
				pictureBox = this._PictureBox3;
				if (pictureBox != null)
				{
					pictureBox.Click += value2;
				}
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001BB RID: 443 RVA: 0x0000D35F File Offset: 0x0000B55F
		// (set) Token: 0x060001BC RID: 444 RVA: 0x0000D36C File Offset: 0x0000B56C
		internal virtual Label Label6
		{
			[CompilerGenerated]
			get
			{
				return this._Label6;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label6_Click);
				Label label = this._Label6;
				if (label != null)
				{
					label.Click -= value2;
				}
				this._Label6 = value;
				label = this._Label6;
				if (label != null)
				{
					label.Click += value2;
				}
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001BD RID: 445 RVA: 0x0000D3AF File Offset: 0x0000B5AF
		// (set) Token: 0x060001BE RID: 446 RVA: 0x0000D3BC File Offset: 0x0000B5BC
		internal virtual Button Button5
		{
			[CompilerGenerated]
			get
			{
				return this._Button5;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button5_Click_1);
				Button button = this._Button5;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button5 = value;
				button = this._Button5;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001BF RID: 447 RVA: 0x0000D3FF File Offset: 0x0000B5FF
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x0000D40C File Offset: 0x0000B60C
		internal virtual TabPage TabPage4
		{
			[CompilerGenerated]
			get
			{
				return this._TabPage4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TabPage4_Click);
				TabPage tabPage = this._TabPage4;
				if (tabPage != null)
				{
					tabPage.Click -= value2;
				}
				this._TabPage4 = value;
				tabPage = this._TabPage4;
				if (tabPage != null)
				{
					tabPage.Click += value2;
				}
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x0000D44F File Offset: 0x0000B64F
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x0000D45C File Offset: 0x0000B65C
		internal virtual Button Button6
		{
			[CompilerGenerated]
			get
			{
				return this._Button6;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button6_Click_1);
				Button button = this._Button6;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button6 = value;
				button = this._Button6;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x0000D49F File Offset: 0x0000B69F
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x0000D4AC File Offset: 0x0000B6AC
		internal virtual RadioButton RadioButton4
		{
			[CompilerGenerated]
			get
			{
				return this._RadioButton4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RadioButton4_CheckedChanged);
				RadioButton radioButton = this._RadioButton4;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= value2;
				}
				this._RadioButton4 = value;
				radioButton = this._RadioButton4;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x0000D4EF File Offset: 0x0000B6EF
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x0000D4FC File Offset: 0x0000B6FC
		internal virtual RadioButton RadioButton3
		{
			[CompilerGenerated]
			get
			{
				return this._RadioButton3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RadioButton3_CheckedChanged_1);
				RadioButton radioButton = this._RadioButton3;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= value2;
				}
				this._RadioButton3 = value;
				radioButton = this._RadioButton3;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x0000D53F File Offset: 0x0000B73F
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x0000D549 File Offset: 0x0000B749
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x0000D552 File Offset: 0x0000B752
		// (set) Token: 0x060001CA RID: 458 RVA: 0x0000D55C File Offset: 0x0000B75C
		internal virtual CheckBox CheckBox2
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBox2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBox2_CheckedChanged);
				CheckBox checkBox = this._CheckBox2;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				this._CheckBox2 = value;
				checkBox = this._CheckBox2;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001CB RID: 459 RVA: 0x0000D59F File Offset: 0x0000B79F
		// (set) Token: 0x060001CC RID: 460 RVA: 0x0000D5AC File Offset: 0x0000B7AC
		internal virtual CheckBox CheckBox3
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBox3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBox3_CheckedChanged);
				CheckBox checkBox = this._CheckBox3;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				this._CheckBox3 = value;
				checkBox = this._CheckBox3;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001CD RID: 461 RVA: 0x0000D5EF File Offset: 0x0000B7EF
		// (set) Token: 0x060001CE RID: 462 RVA: 0x0000D5FC File Offset: 0x0000B7FC
		internal virtual CheckBox CheckBox1
		{
			[CompilerGenerated]
			get
			{
				return this._CheckBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBox1_CheckedChanged);
				CheckBox checkBox = this._CheckBox1;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				this._CheckBox1 = value;
				checkBox = this._CheckBox1;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001CF RID: 463 RVA: 0x0000D63F File Offset: 0x0000B83F
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x0000D649 File Offset: 0x0000B849
		internal virtual PictureBox PictureBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x0000D652 File Offset: 0x0000B852
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x0000D65C File Offset: 0x0000B85C
		internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x0000D665 File Offset: 0x0000B865
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x0000D66F File Offset: 0x0000B86F
		internal virtual PictureBox PictureBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x0000D678 File Offset: 0x0000B878
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x0000D682 File Offset: 0x0000B882
		internal virtual PictureBox PictureBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x0000D68B File Offset: 0x0000B88B
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x0000D698 File Offset: 0x0000B898
		internal virtual Timer Timer30
		{
			[CompilerGenerated]
			get
			{
				return this._Timer30;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer30_Tick);
				Timer timer = this._Timer30;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer30 = value;
				timer = this._Timer30;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x0000D6DB File Offset: 0x0000B8DB
		// (set) Token: 0x060001DA RID: 474 RVA: 0x0000D6E8 File Offset: 0x0000B8E8
		internal virtual Timer Timer31
		{
			[CompilerGenerated]
			get
			{
				return this._Timer31;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer31_Tick);
				Timer timer = this._Timer31;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer31 = value;
				timer = this._Timer31;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0000D72B File Offset: 0x0000B92B
		// (set) Token: 0x060001DC RID: 476 RVA: 0x0000D738 File Offset: 0x0000B938
		internal virtual Timer Timer32
		{
			[CompilerGenerated]
			get
			{
				return this._Timer32;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer32_Tick);
				Timer timer = this._Timer32;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer32 = value;
				timer = this._Timer32;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001DD RID: 477 RVA: 0x0000D77B File Offset: 0x0000B97B
		// (set) Token: 0x060001DE RID: 478 RVA: 0x0000D785 File Offset: 0x0000B985
		internal virtual ToolStripStatusLabel ToolStripStatusLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001DF RID: 479 RVA: 0x0000D78E File Offset: 0x0000B98E
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x0000D798 File Offset: 0x0000B998
		public virtual Button Button3
		{
			[CompilerGenerated]
			get
			{
				return this._Button3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button3_Click);
				Button button = this._Button3;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button3 = value;
				button = this._Button3;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x0000D7DB File Offset: 0x0000B9DB
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x0000D7E5 File Offset: 0x0000B9E5
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x0000D7EE File Offset: 0x0000B9EE
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x0000D7F8 File Offset: 0x0000B9F8
		internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x0000D801 File Offset: 0x0000BA01
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x0000D80C File Offset: 0x0000BA0C
		internal virtual TextBox TextBox1
		{
			[CompilerGenerated]
			get
			{
				return this._TextBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TextBox1_TextChanged_1);
				TextBox textBox = this._TextBox1;
				if (textBox != null)
				{
					textBox.TextChanged -= value2;
				}
				this._TextBox1 = value;
				textBox = this._TextBox1;
				if (textBox != null)
				{
					textBox.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x0000D84F File Offset: 0x0000BA4F
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x0000D859 File Offset: 0x0000BA59
		internal virtual PictureBox PictureBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x0000D862 File Offset: 0x0000BA62
		// (set) Token: 0x060001EA RID: 490 RVA: 0x0000D86C File Offset: 0x0000BA6C
		internal virtual PictureBox PictureBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001EB RID: 491 RVA: 0x0000D875 File Offset: 0x0000BA75
		// (set) Token: 0x060001EC RID: 492 RVA: 0x0000D880 File Offset: 0x0000BA80
		internal virtual PictureBox PictureBox8
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBox8;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBox8_Click);
				PictureBox pictureBox = this._PictureBox8;
				if (pictureBox != null)
				{
					pictureBox.Click -= value2;
				}
				this._PictureBox8 = value;
				pictureBox = this._PictureBox8;
				if (pictureBox != null)
				{
					pictureBox.Click += value2;
				}
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001ED RID: 493 RVA: 0x0000D8C3 File Offset: 0x0000BAC3
		// (set) Token: 0x060001EE RID: 494 RVA: 0x0000D8D0 File Offset: 0x0000BAD0
		public virtual Button Button8
		{
			[CompilerGenerated]
			get
			{
				return this._Button8;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button8_Click);
				Button button = this._Button8;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button8 = value;
				button = this._Button8;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x0400004E RID: 78
		private int TargetProcessHandle;

		// Token: 0x0400004F RID: 79
		private int pfnStartAddr;

		// Token: 0x04000050 RID: 80
		private string pszLibFileRemote;

		// Token: 0x04000051 RID: 81
		private int TargetBufferSize;

		// Token: 0x04000052 RID: 82
		public const int PROCESS_VM_READ = 16;

		// Token: 0x04000053 RID: 83
		public const int TH32CS_SNAPPROCESS = 2;

		// Token: 0x04000054 RID: 84
		public const int MEM_COMMIT = 4096;

		// Token: 0x04000055 RID: 85
		public const int PAGE_READWRITE = 4;

		// Token: 0x04000056 RID: 86
		public const int PROCESS_CREATE_THREAD = 2;

		// Token: 0x04000057 RID: 87
		public const int PROCESS_VM_OPERATION = 8;

		// Token: 0x04000058 RID: 88
		public const int PROCESS_VM_WRITE = 32;

		// Token: 0x04000059 RID: 89
		private string DLLFileName;

		// Token: 0x0400005A RID: 90
		private string ExeName;
	}
}
