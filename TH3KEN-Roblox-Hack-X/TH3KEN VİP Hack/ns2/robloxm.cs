using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;
using ns1;

namespace ns2
{
	// Token: 0x0200000A RID: 10
	[DesignerGenerated]
	public partial class robloxm : Form
	{
		// Token: 0x06000061 RID: 97 RVA: 0x000022A7 File Offset: 0x000004A7
		public robloxm()
		{
			base.Load += this.robloxm_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000064 RID: 100 RVA: 0x000022C7 File Offset: 0x000004C7
		// (set) Token: 0x06000065 RID: 101 RVA: 0x000022CF File Offset: 0x000004CF
		internal virtual ProgressBar ProgressBar1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000066 RID: 102 RVA: 0x000022D8 File Offset: 0x000004D8
		// (set) Token: 0x06000067 RID: 103 RVA: 0x000022E0 File Offset: 0x000004E0
		internal virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000068 RID: 104 RVA: 0x000022E9 File Offset: 0x000004E9
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00005044 File Offset: 0x00003244
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

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600006A RID: 106 RVA: 0x000022F1 File Offset: 0x000004F1
		// (set) Token: 0x0600006B RID: 107 RVA: 0x000022F9 File Offset: 0x000004F9
		internal virtual SaveFileDialog SaveFileDialog1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00002302 File Offset: 0x00000502
		// (set) Token: 0x0600006D RID: 109 RVA: 0x0000230A File Offset: 0x0000050A
		internal virtual TextBox TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00002313 File Offset: 0x00000513
		// (set) Token: 0x0600006F RID: 111 RVA: 0x0000231B File Offset: 0x0000051B
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00002324 File Offset: 0x00000524
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00005088 File Offset: 0x00003288
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

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000072 RID: 114 RVA: 0x0000232C File Offset: 0x0000052C
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00002334 File Offset: 0x00000534
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000074 RID: 116 RVA: 0x0000233D File Offset: 0x0000053D
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00002345 File Offset: 0x00000545
		internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0000234E File Offset: 0x0000054E
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00002356 File Offset: 0x00000556
		internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000078 RID: 120 RVA: 0x0000235F File Offset: 0x0000055F
		// (set) Token: 0x06000079 RID: 121 RVA: 0x000050CC File Offset: 0x000032CC
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

		// Token: 0x0600007A RID: 122 RVA: 0x00002367 File Offset: 0x00000567
		private void robloxm_Load(object sender, EventArgs e)
		{
			MyProject.Forms.Form4.Hide();
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002378 File Offset: 0x00000578
		private void Button2_Click(object sender, EventArgs e)
		{
			this.SaveFileDialog1.Filter = "  th3ken vip| *.exe";
			this.SaveFileDialog1.ShowDialog();
			this.TextBox2.Text = this.SaveFileDialog1.FileName;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002118 File Offset: 0x00000318
		private void Button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000023AC File Offset: 0x000005AC
		private void download_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			this.ProgressBar1.Value = e.ProgressPercentage;
			this.Label6.Text = Conversions.ToString(e.BytesReceived);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00005110 File Offset: 0x00003310
		[MethodImpl(MethodImplOptions.NoOptimization)]
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Label7.Text = Conversions.ToString(this.ProgressBar1.Value) + "%";
			if (this.ProgressBar1.Value == this.ProgressBar1.Maximum)
			{
				this.Timer1.Enabled = false;
				Interaction.MsgBox("ENG: Selected File Successfully Downloaded;) TR: Seçtiginiz Yere Başarıyla Dosya İndirildi ;)", MsgBoxStyle.Information, "Dosya İndirildi");
				this.ProgressBar1.Value = 100;
				ProjectData.EndApp();
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600007F RID: 127 RVA: 0x000023D5 File Offset: 0x000005D5
		// (set) Token: 0x06000080 RID: 128 RVA: 0x0000518C File Offset: 0x0000338C
		private virtual WebClient HTTPCLIENT
		{
			[CompilerGenerated]
			get
			{
				return this._HTTPCLIENT;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DownloadProgressChangedEventHandler value2 = new DownloadProgressChangedEventHandler(this.download_DownloadProgressChanged);
				WebClient httpclient = this._HTTPCLIENT;
				if (httpclient != null)
				{
					httpclient.DownloadProgressChanged -= value2;
				}
				this._HTTPCLIENT = value;
				httpclient = this._HTTPCLIENT;
				if (httpclient != null)
				{
					httpclient.DownloadProgressChanged += value2;
				}
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000051D0 File Offset: 0x000033D0
		private void BunifuFlatButton1_Click(object sender, EventArgs e)
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
				if (!MyProject.Computer.Network.IsAvailable)
				{
					goto IL_62;
				}
				IL_1D:
				num2 = 3;
				this.TextBox2.ReadOnly = true;
				IL_2B:
				num2 = 4;
				this.HTTPCLIENT = new WebClient();
				IL_38:
				num2 = 5;
				this.HTTPCLIENT.DownloadFileAsync(new Uri(this.TextBox1.Text), this.TextBox2.Text);
				goto IL_93;
				IL_62:
				num2 = 7;
				Interaction.MsgBox("0x80070035 Hata Kodu.", MsgBoxStyle.OkOnly, null);
				IL_71:
				num2 = 8;
				base.Hide();
				IL_79:
				num2 = 9;
				MyProject.Forms.GForm0_0.Show();
				IL_8B:
				num2 = 10;
				Application.Restart();
				IL_93:
				goto IL_11A;
				IL_98:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_D6:
				goto IL_10F;
				IL_D8:
				num4 = num2;
				if (num <= -2)
				{
					goto IL_98;
				}
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_ED:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_D8;
			}
			IL_10F:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_11A:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}
	}
}
