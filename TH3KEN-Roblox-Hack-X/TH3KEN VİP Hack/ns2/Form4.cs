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
	// Token: 0x0200000C RID: 12
	[DesignerGenerated]
	public partial class Form4 : Form
	{
		// Token: 0x0600008C RID: 140 RVA: 0x0000240D File Offset: 0x0000060D
		public Form4()
		{
			base.Load += this.Form4_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600008F RID: 143 RVA: 0x0000242D File Offset: 0x0000062D
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00002435 File Offset: 0x00000635
		internal virtual BunifuTileButton BunifuTileButton1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000091 RID: 145 RVA: 0x0000243E File Offset: 0x0000063E
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00006228 File Offset: 0x00004428
		internal virtual BunifuMetroTextbox BunifuMetroTextbox1
		{
			[CompilerGenerated]
			get
			{
				return this._BunifuMetroTextbox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BunifuMetroTextbox1_OnValueChanged);
				BunifuMetroTextbox bunifuMetroTextbox = this._BunifuMetroTextbox1;
				if (bunifuMetroTextbox != null)
				{
					bunifuMetroTextbox.OnValueChanged -= value2;
				}
				this._BunifuMetroTextbox1 = value;
				bunifuMetroTextbox = this._BunifuMetroTextbox1;
				if (bunifuMetroTextbox != null)
				{
					bunifuMetroTextbox.OnValueChanged += value2;
				}
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00002446 File Offset: 0x00000646
		// (set) Token: 0x06000094 RID: 148 RVA: 0x0000244E File Offset: 0x0000064E
		internal virtual BunifuCustomLabel BunifuCustomLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00002457 File Offset: 0x00000657
		// (set) Token: 0x06000096 RID: 150 RVA: 0x0000626C File Offset: 0x0000446C
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

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000097 RID: 151 RVA: 0x0000245F File Offset: 0x0000065F
		// (set) Token: 0x06000098 RID: 152 RVA: 0x00002467 File Offset: 0x00000667
		internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00002470 File Offset: 0x00000670
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00002478 File Offset: 0x00000678
		internal virtual PictureBox PictureBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00002481 File Offset: 0x00000681
		// (set) Token: 0x0600009C RID: 156 RVA: 0x000062B0 File Offset: 0x000044B0
		internal virtual BunifuFlatButton BunifuFlatButton2
		{
			[CompilerGenerated]
			get
			{
				return this._BunifuFlatButton2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BunifuFlatButton2_Click);
				BunifuFlatButton bunifuFlatButton = this._BunifuFlatButton2;
				if (bunifuFlatButton != null)
				{
					bunifuFlatButton.Click -= value2;
				}
				this._BunifuFlatButton2 = value;
				bunifuFlatButton = this._BunifuFlatButton2;
				if (bunifuFlatButton != null)
				{
					bunifuFlatButton.Click += value2;
				}
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00002489 File Offset: 0x00000689
		// (set) Token: 0x0600009E RID: 158 RVA: 0x00002491 File Offset: 0x00000691
		internal virtual BunifuCustomLabel BunifuCustomLabel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600009F RID: 159 RVA: 0x0000249A File Offset: 0x0000069A
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x000024A2 File Offset: 0x000006A2
		internal virtual PictureBox PictureBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x060000A1 RID: 161 RVA: 0x000062F4 File Offset: 0x000044F4
		private void Form4_Load(object sender, EventArgs e)
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
				MyProject.Forms.u.Close();
				IL_1B:
				num2 = 3;
				MyProject.Forms.GForm0_0.Hide();
				IL_2C:
				num2 = 4;
				MyProject.Forms.GForm0_0.Timer1.Stop();
				IL_42:
				num2 = 5;
				MyProject.Forms.GForm0_0.Timer2.Stop();
				IL_58:
				num2 = 6;
				MyProject.Forms.GForm0_0.Timer3.Stop();
				IL_6E:
				num2 = 7;
				MyProject.Forms.rbx.Timer1.Stop();
				IL_84:
				num2 = 8;
				MyProject.Forms.rbx.Timer2.Stop();
				IL_9A:
				num2 = 9;
				MyProject.Forms.rbx.Timer3.Stop();
				IL_B1:
				num2 = 10;
				MyProject.Forms.u.Timer1.Stop();
				IL_C8:
				goto IL_148;
				IL_CA:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_104:
				goto IL_13D;
				IL_106:
				num4 = num2;
				if (num <= -2)
				{
					goto IL_CA;
				}
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_11B:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_106;
			}
			IL_13D:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_148:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00006470 File Offset: 0x00004670
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
				if (Operators.CompareString(this.BunifuMetroTextbox1.Text, "CD792B482D6998FEC62D75D86F194", false) != 0)
				{
					goto IL_4C;
				}
				IL_27:
				num2 = 3;
				this.BunifuMetroTextbox1.ForeColor = Color.Green;
				IL_39:
				num2 = 4;
				MyProject.Forms.robloxm.Show();
				goto IL_72;
				IL_4C:
				num2 = 6;
				Interaction.MsgBox("HATALI CDKEY.", MsgBoxStyle.Exclamation, "HATA!");
				IL_60:
				num2 = 7;
				this.BunifuMetroTextbox1.ForeColor = Color.Red;
				IL_72:
				goto IL_EA;
				IL_74:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_A6:
				goto IL_DF;
				IL_A8:
				num4 = num2;
				if (num <= -2)
				{
					goto IL_74;
				}
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_BD:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_A8;
			}
			IL_DF:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_EA:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00006580 File Offset: 0x00004780
		private void BunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
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
				this.BunifuMetroTextbox1.ForeColor = Color.Yellow;
				IL_1C:
				goto IL_7C;
				IL_1E:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_38:
				goto IL_71;
				IL_3A:
				num4 = num2;
				if (num <= -2)
				{
					goto IL_1E;
				}
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_4F:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_3A;
			}
			IL_71:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_7C:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00006624 File Offset: 0x00004824
		private void BunifuFlatButton2_Click(object sender, EventArgs e)
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
				Interaction.MsgBox("0x53503842 / server?:local", MsgBoxStyle.OkOnly, null);
				IL_19:
				num2 = 3;
				MyProject.Forms.robloxm.Show();
				IL_2A:
				goto IL_8E;
				IL_2C:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_4A:
				goto IL_83;
				IL_4C:
				num4 = num2;
				if (num <= -2)
				{
					goto IL_2C;
				}
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
				IL_61:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_4C;
			}
			IL_83:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_8E:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002118 File Offset: 0x00000318
		private void PictureBox4_Click(object sender, EventArgs e)
		{
		}
	}
}
