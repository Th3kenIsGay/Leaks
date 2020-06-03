using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Steam_Game_Spammer_0._1.My;
using Steam_Game_Spammer_0._1.My.Resources;

namespace Steam_Game_Spammer_0._1
{
	// Token: 0x0200000A RID: 10
	[DesignerGenerated]
	public partial class Form1 : Form
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00002110 File Offset: 0x00000310
		[DebuggerNonUserCode]
		public Form1()
		{
			base.Load += this.Form1_Load;
			Form1.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002BE4 File Offset: 0x00000DE4
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Form1.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					if (Form1.__ENCList.Count == Form1.__ENCList.Capacity)
					{
						int num = 0;
						int num2 = 0;
						int num3 = Form1.__ENCList.Count - 1;
						int num4 = num2;
						for (;;)
						{
							int num5 = num4;
							int num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							WeakReference weakReference = Form1.__ENCList[num4];
							if (weakReference.IsAlive)
							{
								if (num4 != num)
								{
									Form1.__ENCList[num] = Form1.__ENCList[num4];
								}
								num++;
							}
							num4++;
						}
						Form1.__ENCList.RemoveRange(num, Form1.__ENCList.Count - num);
						Form1.__ENCList.Capacity = Form1.__ENCList.Count;
					}
					Form1.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00003568 File Offset: 0x00001768
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00002137 File Offset: 0x00000337
		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00003580 File Offset: 0x00001780
		// (set) Token: 0x06000038 RID: 56 RVA: 0x00003598 File Offset: 0x00001798
		internal virtual PictureBox PictureBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.PictureBox1_Click);
				MouseEventHandler value3 = new MouseEventHandler(this.PictureBox1_Click);
				EventHandler value4 = new EventHandler(this.PictureBox1_Click_1);
				if (this._PictureBox1 != null)
				{
					this._PictureBox1.MouseClick -= value2;
					this._PictureBox1.MouseClick -= value3;
					this._PictureBox1.Click -= value4;
				}
				this._PictureBox1 = value;
				if (this._PictureBox1 != null)
				{
					this._PictureBox1.MouseClick += value2;
					this._PictureBox1.MouseClick += value3;
					this._PictureBox1.Click += value4;
				}
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000039 RID: 57 RVA: 0x0000363C File Offset: 0x0000183C
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00002140 File Offset: 0x00000340
		internal virtual SaveFileDialog SaveFileDialog1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SaveFileDialog1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SaveFileDialog1 = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00003654 File Offset: 0x00001854
		// (set) Token: 0x0600003C RID: 60 RVA: 0x0000366C File Offset: 0x0000186C
		internal virtual PictureBox PictureBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBox3_Click);
				if (this._PictureBox3 != null)
				{
					this._PictureBox3.Click -= value2;
				}
				this._PictureBox3 = value;
				if (this._PictureBox3 != null)
				{
					this._PictureBox3.Click += value2;
				}
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003D RID: 61 RVA: 0x000036C4 File Offset: 0x000018C4
		// (set) Token: 0x0600003E RID: 62 RVA: 0x000036DC File Offset: 0x000018DC
		internal virtual PictureBox PictureBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBox2_Click_1);
				if (this._PictureBox2 != null)
				{
					this._PictureBox2.Click -= value2;
				}
				this._PictureBox2 = value;
				if (this._PictureBox2 != null)
				{
					this._PictureBox2.Click += value2;
				}
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00003734 File Offset: 0x00001934
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00002149 File Offset: 0x00000349
		internal virtual TextBox TextBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox1 = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000041 RID: 65 RVA: 0x0000374C File Offset: 0x0000194C
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00003764 File Offset: 0x00001964
		internal virtual Button Button2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button2_Click);
				if (this._Button2 != null)
				{
					this._Button2.Click -= value2;
				}
				this._Button2 = value;
				if (this._Button2 != null)
				{
					this._Button2.Click += value2;
				}
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000043 RID: 67 RVA: 0x000037BC File Offset: 0x000019BC
		// (set) Token: 0x06000044 RID: 68 RVA: 0x000037D4 File Offset: 0x000019D4
		internal virtual CheckBox CheckBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CheckBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBox1_CheckedChanged);
				if (this._CheckBox1 != null)
				{
					this._CheckBox1.CheckedChanged -= value2;
				}
				this._CheckBox1 = value;
				if (this._CheckBox1 != null)
				{
					this._CheckBox1.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000045 RID: 69 RVA: 0x0000382C File Offset: 0x00001A2C
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00003844 File Offset: 0x00001A44
		internal virtual NotifyIcon NotifyIcon1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NotifyIcon1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
				if (this._NotifyIcon1 != null)
				{
					this._NotifyIcon1.MouseDoubleClick -= value2;
				}
				this._NotifyIcon1 = value;
				if (this._NotifyIcon1 != null)
				{
					this._NotifyIcon1.MouseDoubleClick += value2;
				}
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000047 RID: 71 RVA: 0x0000389C File Offset: 0x00001A9C
		// (set) Token: 0x06000048 RID: 72 RVA: 0x000038B4 File Offset: 0x00001AB4
		internal virtual Button Button1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click_3);
				if (this._Button1 != null)
				{
					this._Button1.Click -= value2;
				}
				this._Button1 = value;
				if (this._Button1 != null)
				{
					this._Button1.Click += value2;
				}
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000049 RID: 73 RVA: 0x0000390C File Offset: 0x00001B0C
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00002152 File Offset: 0x00000352
		internal virtual MenuStrip MenuStrip1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MenuStrip1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MenuStrip1 = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00003924 File Offset: 0x00001B24
		// (set) Token: 0x0600004C RID: 76 RVA: 0x0000393C File Offset: 0x00001B3C
		internal virtual ToolStripMenuItem HelpToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._HelpToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.HelpToolStripMenuItem_Click);
				if (this._HelpToolStripMenuItem != null)
				{
					this._HelpToolStripMenuItem.Click -= value2;
				}
				this._HelpToolStripMenuItem = value;
				if (this._HelpToolStripMenuItem != null)
				{
					this._HelpToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00003994 File Offset: 0x00001B94
		// (set) Token: 0x0600004E RID: 78 RVA: 0x000039AC File Offset: 0x00001BAC
		internal virtual ToolStripMenuItem TutorialAddNonSteamGameToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TutorialAddNonSteamGameToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TutorialAddNonSteamGameToolStripMenuItem_Click);
				if (this._TutorialAddNonSteamGameToolStripMenuItem != null)
				{
					this._TutorialAddNonSteamGameToolStripMenuItem.Click -= value2;
				}
				this._TutorialAddNonSteamGameToolStripMenuItem = value;
				if (this._TutorialAddNonSteamGameToolStripMenuItem != null)
				{
					this._TutorialAddNonSteamGameToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00003A04 File Offset: 0x00001C04
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00003A1C File Offset: 0x00001C1C
		internal virtual ToolStripMenuItem TutorialUseMagnetSpammerToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TutorialUseMagnetSpammerToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TutorialUseMagnetSpammerToolStripMenuItem_Click);
				if (this._TutorialUseMagnetSpammerToolStripMenuItem != null)
				{
					this._TutorialUseMagnetSpammerToolStripMenuItem.Click -= value2;
				}
				this._TutorialUseMagnetSpammerToolStripMenuItem = value;
				if (this._TutorialUseMagnetSpammerToolStripMenuItem != null)
				{
					this._TutorialUseMagnetSpammerToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00003A74 File Offset: 0x00001C74
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00003A8C File Offset: 0x00001C8C
		internal virtual ToolStripMenuItem SourceCodeToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SourceCodeToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.SourceCodeToolStripMenuItem_Click);
				if (this._SourceCodeToolStripMenuItem != null)
				{
					this._SourceCodeToolStripMenuItem.Click -= value2;
				}
				this._SourceCodeToolStripMenuItem = value;
				if (this._SourceCodeToolStripMenuItem != null)
				{
					this._SourceCodeToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003AE4 File Offset: 0x00001CE4
		public void savefromresources(string filepath, object File)
		{
			byte[] data = (byte[])File;
			MyProject.Computer.FileSystem.WriteAllBytes(filepath, data, true);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003B0C File Offset: 0x00001D0C
		public void Delay(double dblSecs)
		{
			DateAndTime.Now.AddSeconds(1.1574074074074073E-05);
			DateTime t = DateAndTime.Now.AddSeconds(1.1574074074074073E-05).AddSeconds(dblSecs);
			while (DateTime.Compare(DateAndTime.Now, t) <= 0)
			{
				Application.DoEvents();
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000215B File Offset: 0x0000035B
		private void Button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003B6C File Offset: 0x00001D6C
		private void PictureBox1_Click(object sender, EventArgs e)
		{
			this.PictureBox1.Image = Resources.Steam_button_sample2;
			this.SaveFileDialog1.ShowDialog();
			if (Operators.CompareString(this.SaveFileDialog1.FileName, "", false) == 0)
			{
				this.PictureBox1.Image = Resources.Steam_button_sample;
			}
			else
			{
				this.savefromresources(this.SaveFileDialog1.FileName + ".exe", Resources.SteamSpammerEjection);
				this.PictureBox1.Image = Resources.Steam_button_sample;
				Interaction.MsgBox("Extract done!", MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000215B File Offset: 0x0000035B
		private void PictureBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000215B File Offset: 0x0000035B
		private void PictureBox1_Click(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000215B File Offset: 0x0000035B
		private void PictureBox1_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000215B File Offset: 0x0000035B
		private void Form1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00003C00 File Offset: 0x00001E00
		private void PictureBox3_Click(object sender, EventArgs e)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_01:
				ProjectData.ClearProjectError();
				num = -2;
				IL_09:
				int num2 = 2;
				Process.Start("E:\\Steam\\Steam.exe");
				IL_16:
				num2 = 3;
				Process.Start("C:\\" + Environment.UserName + "\\Steam\\Steam.exe");
				IL_32:
				num2 = 4;
				Process.Start("E:\\" + Environment.UserName + "\\Steam\\Steam.exe");
				IL_4E:
				num2 = 5;
				Process.Start("D:\\" + Environment.UserName + "\\Steam\\Steam.exe");
				IL_6A:
				num2 = 6;
				Process.Start("F:\\" + Environment.UserName + "\\Steam\\Steam.exe");
				IL_86:
				num2 = 7;
				Interaction.MsgBox("Steam'ı Açılıyor ( Açılmasa Kendiniz Açınız !!!", MsgBoxStyle.OkOnly, null);
				IL_95:
				num2 = 8;
				this.PictureBox3.Image = Resources.Open_Steam__2_;
				IL_A7:
				num2 = 9;
				this.Delay(1.0);
				IL_B9:
				num2 = 10;
				this.PictureBox3.Image = Resources.Open_Steam;
				IL_CC:
				goto IL_14C;
				IL_CE:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_108:
				goto IL_141;
				IL_10A:
				num4 = num2;
				if (num <= -2)
				{
					goto IL_CE;
				}
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_11F:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_10A;
			}
			IL_141:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_14C:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000215D File Offset: 0x0000035D
		private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.savefromresources("Tutorial.mp4", Resources.Tutorial);
			MyProject.Forms.Tutorial.Show();
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00003D80 File Offset: 0x00001F80
		private void PictureBox2_Click_1(object sender, EventArgs e)
		{
			this.PictureBox1.Image = Resources.Steam_button_sample2;
			this.SaveFileDialog1.ShowDialog();
			if (Operators.CompareString(this.SaveFileDialog1.FileName, "", false) == 0)
			{
				this.PictureBox1.Image = Resources.Steam_button_sample;
			}
			else
			{
				this.savefromresources(this.SaveFileDialog1.FileName + ".exe", Resources.SteamGameAdvanced);
				this.PictureBox1.Image = Resources.Steam_button_sample;
				Interaction.MsgBox("Extract done!", MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000215B File Offset: 0x0000035B
		private void Button1_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00003E14 File Offset: 0x00002014
		private void Button2_Click(object sender, EventArgs e)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_01:
				ProjectData.ClearProjectError();
				num = -2;
				IL_09:
				int num2 = 2;
				if (Operators.CompareString(this.TextBox1.Text, "", false) != 0)
				{
					goto IL_3A;
				}
				IL_26:
				num2 = 3;
				Interaction.MsgBox("Lütfen 'STEAM APP ID'nizi ekleyin, buharsız uygulamanızın özelliklerinde bulabilirsiniz (Genellikle Masaüstünüzde)", MsgBoxStyle.OkOnly, null);
				IL_35:
				goto IL_F6;
				IL_3A:
				num2 = 5;
				IL_3C:
				num2 = 6;
				Interaction.MsgBox("Uyarı! Bu, seçilen programın üst üste 5 kez spam olmasını sağlayacaktır! Devam edeceğine emin misin ?", MsgBoxStyle.OkOnly, null);
				for (;;)
				{
					IL_5F:
					num2 = 8;
					Process.Start(this.TextBox1.Text);
					IL_4D:
					num2 = 9;
					this.Delay(5.0);
				}
				IL_74:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_B2:
				goto IL_EB;
				IL_B4:
				num4 = num2;
				if (num <= -2)
				{
					goto IL_74;
				}
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_C9:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_B4;
			}
			IL_EB:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_F6:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00003F30 File Offset: 0x00002130
		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (this.CheckBox1.Checked)
			{
				Interaction.MsgBox("'Steam Uygulama Kimliği' ni aşağıdaki metin kutusuna yerleştirin, böylece oyunu arkadaşınıza spam olarak ekleyebilirsiniz.", MsgBoxStyle.OkOnly, null);
				this.TextBox1.Visible = true;
				this.Button2.Visible = true;
			}
			else
			{
				this.TextBox1.Visible = false;
				this.Button2.Visible = false;
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000217E File Offset: 0x0000037E
		private void Button1_Click_2(object sender, EventArgs e)
		{
			this.Hide();
			this.NotifyIcon1.Visible = true;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002192 File Offset: 0x00000392
		private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.Show();
			this.NotifyIcon1.Visible = false;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000217E File Offset: 0x0000037E
		private void Button1_Click_3(object sender, EventArgs e)
		{
			this.Hide();
			this.NotifyIcon1.Visible = true;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000021A6 File Offset: 0x000003A6
		private void TutorialAddNonSteamGameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.savefromresources("Tutorial.mp4", Resources.Tutorial);
			MyProject.Forms.Tutorial.AxWindowsMediaPlayer1.URL = "Tutorial.mp4";
			MyProject.Forms.Tutorial.Show();
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000215B File Offset: 0x0000035B
		private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000021E0 File Offset: 0x000003E0
		private void TutorialUseMagnetSpammerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.savefromresources("Tutorialgame.mp4", Resources.Tutorialgame);
			MyProject.Forms.Tutorial.AxWindowsMediaPlayer1.URL = "Tutorialgame.mp4";
			MyProject.Forms.Tutorial.Show();
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000221A File Offset: 0x0000041A
		private void ReportBugToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Interaction.MsgBox("Contact Devloper on Steam: id> th3ken.", MsgBoxStyle.OkOnly, null);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000215B File Offset: 0x0000035B
		private void ContactDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002229 File Offset: 0x00000429
		private void SourceCodeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("https://github.com/th3ken-dev/Steam-Game-Spammer-V1/blob/master/LICENSE");
		}

		// Token: 0x0400000E RID: 14
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000010 RID: 16
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000011 RID: 17
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x04000012 RID: 18
		[AccessedThroughProperty("SaveFileDialog1")]
		private SaveFileDialog _SaveFileDialog1;

		// Token: 0x04000013 RID: 19
		[AccessedThroughProperty("PictureBox3")]
		private PictureBox _PictureBox3;

		// Token: 0x04000014 RID: 20
		[AccessedThroughProperty("PictureBox2")]
		private PictureBox _PictureBox2;

		// Token: 0x04000015 RID: 21
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x04000016 RID: 22
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x04000017 RID: 23
		[AccessedThroughProperty("CheckBox1")]
		private CheckBox _CheckBox1;

		// Token: 0x04000018 RID: 24
		[AccessedThroughProperty("NotifyIcon1")]
		private NotifyIcon _NotifyIcon1;

		// Token: 0x04000019 RID: 25
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x0400001A RID: 26
		[AccessedThroughProperty("MenuStrip1")]
		private MenuStrip _MenuStrip1;

		// Token: 0x0400001B RID: 27
		[AccessedThroughProperty("HelpToolStripMenuItem")]
		private ToolStripMenuItem _HelpToolStripMenuItem;

		// Token: 0x0400001C RID: 28
		[AccessedThroughProperty("TutorialAddNonSteamGameToolStripMenuItem")]
		private ToolStripMenuItem _TutorialAddNonSteamGameToolStripMenuItem;

		// Token: 0x0400001D RID: 29
		[AccessedThroughProperty("TutorialUseMagnetSpammerToolStripMenuItem")]
		private ToolStripMenuItem _TutorialUseMagnetSpammerToolStripMenuItem;

		// Token: 0x0400001E RID: 30
		[AccessedThroughProperty("SourceCodeToolStripMenuItem")]
		private ToolStripMenuItem _SourceCodeToolStripMenuItem;
	}
}
