using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using rootip.My;

namespace rootip
{
	// Token: 0x02000008 RID: 8
	[DesignerGenerated]
	public partial class Form1 : Form
	{
		// Token: 0x06000015 RID: 21 RVA: 0x00002106 File Offset: 0x00000306
		public Form1()
		{
			base.Load += this.Form1_Load;
			this.PAT = MySettingsProperty.Settings.pattern;
			this.X = 0;
			this.InitializeComponent();
			Control.CheckForIllegalCrossThreadCalls = false;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000024D0 File Offset: 0x000006D0
		public void Search()
		{
			checked
			{
				try
				{
					int num = System.Convert.ToInt32(this.npages.Value);
					for (int i = 1; i <= num; i++)
					{
						HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.iconarchive.com/search?q=" + this.TextBox1.Text + "&page=" + Conversions.ToString(i));
						httpWebRequest.Proxy = null;
						httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36";
						httpWebRequest.CookieContainer = new CookieContainer();
						HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
						StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
						string input = streamReader.ReadToEnd();
						streamReader.Close();
						try
						{
							foreach (object obj in new Regex(this.PAT).Matches(input))
							{
								Match match = (Match)obj;
								using (WebClient webClient = new WebClient())
								{
									ListViewItem listViewItem = new ListViewItem();
									Image value = (Bitmap)Image.FromStream(new MemoryStream(webClient.DownloadData(match.Groups[1].Value)));
									this.IM.Images.Add(value);
									listViewItem.ImageIndex = this.X;
									this.X++;
									this.LV1.Items.Add(listViewItem);
									this.ic.Text = "simgeler : " + Conversions.ToString(this.LV1.Items.Count);
								}
							}
						}
						finally
						{
							IEnumerator enumerator;
							if (enumerator is IDisposable)
							{
								(enumerator as IDisposable).Dispose();
							}
						}
					}
					this.Panel1.Enabled = true;
					Interaction.MsgBox("Bitti Arama", MsgBoxStyle.Information, null);
					Interaction.MsgBox("Hangi Resmi Seçecekseniz Yan Tıklayıp Kaydet'bilirsiniz :)", MsgBoxStyle.OkOnly, null);
				}
				catch (Exception ex)
				{
					Interaction.MsgBox(ex.Message, MsgBoxStyle.Exclamation, null);
					this.Panel1.Enabled = true;
				}
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002714 File Offset: 0x00000914
		public void savePNG()
		{
			if (!Directory.Exists("png"))
			{
				Directory.CreateDirectory("png");
			}
			Bitmap bitmap = new Bitmap(this.IM.Images[this.LV1.FocusedItem.Index]);
			bitmap.Save("png\\" + DateTime.Now.ToString("hhmmss") + ".png");
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002788 File Offset: 0x00000988
		public void SaveICO()
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
				if (Directory.Exists("ico"))
				{
					goto IL_28;
				}
				IL_1B:
				num2 = 3;
				Directory.CreateDirectory("ico");
				IL_28:
				num2 = 5;
				Bitmap input_stream = new Bitmap(this.IM.Images[this.LV1.FocusedItem.Index]);
				IL_50:
				num2 = 6;
				Form1.Convert(input_stream, new FileStream("ico\\" + DateTime.Now.ToString("hhmmss") + ".ico", FileMode.OpenOrCreate), false);
				IL_82:
				goto IL_F2;
				IL_84:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_AE:
				goto IL_E7;
				IL_B0:
				num4 = num2;
				if (num <= -2)
				{
					goto IL_84;
				}
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_C5:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_B0;
			}
			IL_E7:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_F2:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000028A0 File Offset: 0x00000AA0
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
				IL_0A:
				int num2 = 2;
				this.LV1.Items.Clear();
				IL_1C:
				num2 = 3;
				this.Panel1.Enabled = false;
				IL_2A:
				num2 = 4;
				Thread thread = new Thread(new ThreadStart(this.Search));
				IL_3E:
				num2 = 5;
				this.Button2.Visible = true;
				IL_4C:
				num2 = 6;
				thread.IsBackground = true;
				IL_55:
				num2 = 7;
				thread.Start();
				IL_5D:
				num2 = 8;
				this.Panel1.Enabled = false;
				IL_6B:
				goto IL_E3;
				IL_6D:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_9F:
				goto IL_D8;
				IL_A1:
				num4 = num2;
				if (num <= -2)
				{
					goto IL_6D;
				}
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_B6:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_A1;
			}
			IL_D8:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_E3:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002143 File Offset: 0x00000343
		private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://steamcommunity.com/id/th3ken/");
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002150 File Offset: 0x00000350
		private void SaveToPNGToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.savePNG();
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002158 File Offset: 0x00000358
		private void SaveToIconToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.SaveICO();
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000029A8 File Offset: 0x00000BA8
		public static bool Convert(Bitmap input_stream, Stream output_stream, bool keep_aspect_ratio = false)
		{
			int num;
			bool flag;
			int num6;
			object obj;
			try
			{
				IL_02:
				ProjectData.ClearProjectError();
				num = -2;
				IL_0A:
				int num2 = 2;
				IL_0F:
				num2 = 3;
				if (input_stream == null)
				{
					goto IL_196;
				}
				IL_1B:
				num2 = 4;
				if (!keep_aspect_ratio)
				{
					goto IL_53;
				}
				IL_20:
				num2 = 5;
				int num3 = 48;
				IL_26:
				num2 = 6;
				checked
				{
					int num4 = (int)Math.Round(Math.Round(unchecked((double)input_stream.Height / (double)input_stream.Width * 48.0)));
					goto IL_60;
					IL_53:
					num2 = 8;
					num3 = Form1.InlineAssignHelper<int>(ref num4, 48);
					IL_60:
					num2 = 10;
					Size newSize = new Size(num3, num4);
					IL_6E:
					num2 = 11;
					Bitmap bitmap = new Bitmap(input_stream, newSize);
					IL_7C:
					num2 = 12;
					if (bitmap == null)
					{
						goto IL_18F;
					}
					IL_89:
					num2 = 13;
					MemoryStream memoryStream = new MemoryStream();
					IL_93:
					num2 = 14;
					bitmap.Save(memoryStream, ImageFormat.Png);
					IL_A4:
					num2 = 15;
					BinaryWriter binaryWriter = new BinaryWriter(output_stream);
					IL_AF:
					num2 = 16;
					if (output_stream == null || binaryWriter == null)
					{
						goto IL_18F;
					}
					IL_C2:
					num2 = 17;
					binaryWriter.Write(0);
					IL_CD:
					num2 = 18;
					binaryWriter.Write(0);
					IL_D8:
					num2 = 19;
					binaryWriter.Write(1);
					IL_E3:
					num2 = 20;
					binaryWriter.Write(1);
					IL_EE:
					num2 = 21;
					binaryWriter.Write((byte)num3);
					IL_FB:
					num2 = 22;
					binaryWriter.Write((byte)num4);
					IL_108:
					num2 = 23;
					binaryWriter.Write(0);
					IL_113:
					num2 = 24;
					binaryWriter.Write(0);
					IL_11E:
					num2 = 25;
					binaryWriter.Write(0);
					IL_129:
					num2 = 26;
					binaryWriter.Write(32);
					IL_135:
					num2 = 27;
					binaryWriter.Write((int)memoryStream.Length);
					IL_147:
					num2 = 28;
					binaryWriter.Write(22);
					IL_153:
					num2 = 29;
					binaryWriter.Write(memoryStream.ToArray());
					IL_164:
					num2 = 30;
					binaryWriter.Flush();
					IL_16E:
					num2 = 31;
					binaryWriter.Close();
					IL_178:
					num2 = 32;
					Interaction.MsgBox("Masaüstü'nüze Klasor Oluşturuldu ( İçine Kaydediliyor Resimler !!! )", MsgBoxStyle.OkOnly, null);
					IL_188:
					num2 = 33;
					flag = true;
					goto IL_19B;
					IL_18F:
					num2 = 36;
					flag = false;
					goto IL_19B;
					IL_196:
					num2 = 38;
					flag = false;
					IL_19B:
					goto IL_291;
					IL_1A0:;
				}
				int num5 = num6 + 1;
				num6 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
				IL_24A:
				goto IL_286;
				IL_24C:
				num6 = num2;
				if (num <= -2)
				{
					goto IL_1A0;
				}
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_264:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num6 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_24C;
			}
			IL_286:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_291:
			if (num6 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002C6C File Offset: 0x00000E6C
		private static T InlineAssignHelper<T>(ref T target, T value)
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
				target = value;
				IL_13:
				num2 = 3;
				IL_17:
				goto IL_7B;
				IL_19:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_37:
				goto IL_70;
				IL_39:
				num4 = num2;
				if (num <= -2)
				{
					goto IL_19;
				}
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_4E:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_39;
			}
			IL_70:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_7B:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return value;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002160 File Offset: 0x00000360
		private void method_0(object sender, EventArgs e)
		{
			Process.Start("https://github.com/th3ken-dev/kolay-icon-bulma-v1");
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000216D File Offset: 0x0000036D
		private void LisanceToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("https://github.com/th3ken-dev/kolay-icon-bulma-v1/blob/master/LICENSE");
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000217A File Offset: 0x0000037A
		private void CM1_Opening(object sender, CancelEventArgs e)
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000217A File Offset: 0x0000037A
		private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000217A File Offset: 0x0000037A
		private void SV_FileOk(object sender, CancelEventArgs e)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000217A File Offset: 0x0000037A
		private void Panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002D10 File Offset: 0x00000F10
		private void method_1(object sender, EventArgs e)
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
				Process.Start("https://i.hizliresim.com/MdzNZM.png");
				IL_17:
				num2 = 3;
				Process.Start("https://i.hizliresim.com/QVkDnj.png");
				IL_24:
				num2 = 4;
				Interaction.MsgBox("Sayfa Kaç Adet Sayfa Aratacağını Yazınız !", MsgBoxStyle.OkOnly, null);
				IL_33:
				goto IL_9B;
				IL_35:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_57:
				goto IL_90;
				IL_59:
				num4 = num2;
				if (num <= -2)
				{
					goto IL_35;
				}
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_6E:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_59;
			}
			IL_90:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_9B:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000217A File Offset: 0x0000037A
		private void LV1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000217A File Offset: 0x0000037A
		private void txticon_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000217A File Offset: 0x0000037A
		private void Button2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000217C File Offset: 0x0000037C
		private void Button2_Click_1(object sender, EventArgs e)
		{
			Application.Restart();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000217A File Offset: 0x0000037A
		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002183 File Offset: 0x00000383
		private void Form1_Load(object sender, EventArgs e)
		{
			Interaction.MsgBox("Aramalar'ınızı İngilizce Halinde Yapınız ! Türkçe Yaparsanız Resimler Gelmez ", MsgBoxStyle.OkOnly, null);
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00002192 File Offset: 0x00000392
		// (set) Token: 0x0600002F RID: 47 RVA: 0x00003B70 File Offset: 0x00001D70
		internal virtual Panel Panel1
		{
			[CompilerGenerated]
			get
			{
				return this._Panel1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				PaintEventHandler value2 = new PaintEventHandler(this.Panel1_Paint);
				Panel panel = this._Panel1;
				if (panel != null)
				{
					panel.Paint -= value2;
				}
				this._Panel1 = value;
				panel = this._Panel1;
				if (panel != null)
				{
					panel.Paint += value2;
				}
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000030 RID: 48 RVA: 0x0000219A File Offset: 0x0000039A
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00003BB4 File Offset: 0x00001DB4
		internal virtual ListView LV1
		{
			[CompilerGenerated]
			get
			{
				return this._LV1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.LV1_SelectedIndexChanged);
				ListView lv = this._LV1;
				if (lv != null)
				{
					lv.SelectedIndexChanged -= value2;
				}
				this._LV1 = value;
				lv = this._LV1;
				if (lv != null)
				{
					lv.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000032 RID: 50 RVA: 0x000021A2 File Offset: 0x000003A2
		// (set) Token: 0x06000033 RID: 51 RVA: 0x000021AA File Offset: 0x000003AA
		internal virtual ImageList IM { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000021B3 File Offset: 0x000003B3
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00003BF8 File Offset: 0x00001DF8
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

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000036 RID: 54 RVA: 0x000021BB File Offset: 0x000003BB
		// (set) Token: 0x06000037 RID: 55 RVA: 0x000021C3 File Offset: 0x000003C3
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000038 RID: 56 RVA: 0x000021CC File Offset: 0x000003CC
		// (set) Token: 0x06000039 RID: 57 RVA: 0x000021D4 File Offset: 0x000003D4
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000021DD File Offset: 0x000003DD
		// (set) Token: 0x0600003B RID: 59 RVA: 0x000021E5 File Offset: 0x000003E5
		internal virtual NumericUpDown npages { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000021EE File Offset: 0x000003EE
		// (set) Token: 0x0600003D RID: 61 RVA: 0x000021F6 File Offset: 0x000003F6
		internal virtual Label ic { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600003E RID: 62 RVA: 0x000021FF File Offset: 0x000003FF
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00003C3C File Offset: 0x00001E3C
		internal virtual ContextMenuStrip CM1
		{
			[CompilerGenerated]
			get
			{
				return this._CM1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				CancelEventHandler value2 = new CancelEventHandler(this.CM1_Opening);
				ContextMenuStrip cm = this._CM1;
				if (cm != null)
				{
					cm.Opening -= value2;
				}
				this._CM1 = value;
				cm = this._CM1;
				if (cm != null)
				{
					cm.Opening += value2;
				}
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00002207 File Offset: 0x00000407
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00003C80 File Offset: 0x00001E80
		internal virtual ToolStripMenuItem SaveToPNGToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SaveToPNGToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.SaveToPNGToolStripMenuItem_Click);
				ToolStripMenuItem saveToPNGToolStripMenuItem = this._SaveToPNGToolStripMenuItem;
				if (saveToPNGToolStripMenuItem != null)
				{
					saveToPNGToolStripMenuItem.Click -= value2;
				}
				this._SaveToPNGToolStripMenuItem = value;
				saveToPNGToolStripMenuItem = this._SaveToPNGToolStripMenuItem;
				if (saveToPNGToolStripMenuItem != null)
				{
					saveToPNGToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000042 RID: 66 RVA: 0x0000220F File Offset: 0x0000040F
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00003CC4 File Offset: 0x00001EC4
		internal virtual ToolStripMenuItem SaveToIconToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SaveToIconToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.SaveToIconToolStripMenuItem_Click);
				ToolStripMenuItem saveToIconToolStripMenuItem = this._SaveToIconToolStripMenuItem;
				if (saveToIconToolStripMenuItem != null)
				{
					saveToIconToolStripMenuItem.Click -= value2;
				}
				this._SaveToIconToolStripMenuItem = value;
				saveToIconToolStripMenuItem = this._SaveToIconToolStripMenuItem;
				if (saveToIconToolStripMenuItem != null)
				{
					saveToIconToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00002217 File Offset: 0x00000417
		// (set) Token: 0x06000045 RID: 69 RVA: 0x0000221F File Offset: 0x0000041F
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00002228 File Offset: 0x00000428
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00003D08 File Offset: 0x00001F08
		internal virtual LinkLabel LinkLabel1
		{
			[CompilerGenerated]
			get
			{
				return this._LinkLabel1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler value2 = new LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
				LinkLabel linkLabel = this._LinkLabel1;
				if (linkLabel != null)
				{
					linkLabel.LinkClicked -= value2;
				}
				this._LinkLabel1 = value;
				linkLabel = this._LinkLabel1;
				if (linkLabel != null)
				{
					linkLabel.LinkClicked += value2;
				}
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00002230 File Offset: 0x00000430
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00003D4C File Offset: 0x00001F4C
		internal virtual SaveFileDialog SV
		{
			[CompilerGenerated]
			get
			{
				return this._SV;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				CancelEventHandler value2 = new CancelEventHandler(this.SV_FileOk);
				SaveFileDialog sv = this._SV;
				if (sv != null)
				{
					sv.FileOk -= value2;
				}
				this._SV = value;
				sv = this._SV;
				if (sv != null)
				{
					sv.FileOk += value2;
				}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00002238 File Offset: 0x00000438
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00003D90 File Offset: 0x00001F90
		internal virtual MenuStrip MenuStrip1
		{
			[CompilerGenerated]
			get
			{
				return this._MenuStrip1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				ToolStripItemClickedEventHandler value2 = new ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
				MenuStrip menuStrip = this._MenuStrip1;
				if (menuStrip != null)
				{
					menuStrip.ItemClicked -= value2;
				}
				this._MenuStrip1 = value;
				menuStrip = this._MenuStrip1;
				if (menuStrip != null)
				{
					menuStrip.ItemClicked += value2;
				}
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00002240 File Offset: 0x00000440
		// (set) Token: 0x0600004D RID: 77 RVA: 0x00003DD4 File Offset: 0x00001FD4
		internal virtual ToolStripMenuItem ToolStripMenuItem_0
		{
			[CompilerGenerated]
			get
			{
				return this.toolStripMenuItem_0;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_0);
				ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_0;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				this.toolStripMenuItem_0 = value;
				toolStripMenuItem = this.toolStripMenuItem_0;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00002248 File Offset: 0x00000448
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00003E18 File Offset: 0x00002018
		internal virtual ToolStripMenuItem LisanceToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._LisanceToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.LisanceToolStripMenuItem_Click);
				ToolStripMenuItem lisanceToolStripMenuItem = this._LisanceToolStripMenuItem;
				if (lisanceToolStripMenuItem != null)
				{
					lisanceToolStripMenuItem.Click -= value2;
				}
				this._LisanceToolStripMenuItem = value;
				lisanceToolStripMenuItem = this._LisanceToolStripMenuItem;
				if (lisanceToolStripMenuItem != null)
				{
					lisanceToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00002250 File Offset: 0x00000450
		// (set) Token: 0x06000051 RID: 81 RVA: 0x00003E5C File Offset: 0x0000205C
		internal virtual ToolStripMenuItem ToolStripMenuItem_1
		{
			[CompilerGenerated]
			get
			{
				return this.toolStripMenuItem_1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_1);
				ToolStripMenuItem toolStripMenuItem = this.toolStripMenuItem_1;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				this.toolStripMenuItem_1 = value;
				toolStripMenuItem = this.toolStripMenuItem_1;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00002258 File Offset: 0x00000458
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00003EA0 File Offset: 0x000020A0
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
				EventHandler value2 = new EventHandler(this.TextBox1_TextChanged);
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

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00002260 File Offset: 0x00000460
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00003EE4 File Offset: 0x000020E4
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
				EventHandler value2 = new EventHandler(this.Button2_Click_1);
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

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00002268 File Offset: 0x00000468
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00002270 File Offset: 0x00000470
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x0400000B RID: 11
		private string PAT;

		// Token: 0x0400000C RID: 12
		private int X;

		// Token: 0x0400000D RID: 13
		private string result;

		// Token: 0x0400001E RID: 30
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("YardımToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_0;

		// Token: 0x04000020 RID: 32
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("KullanmaKılavuzuToolStripMenuItem")]
		private ToolStripMenuItem toolStripMenuItem_1;
	}
}
