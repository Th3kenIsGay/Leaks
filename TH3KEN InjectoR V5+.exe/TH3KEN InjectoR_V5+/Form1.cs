using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hosts_Pro_V6.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Hosts_Pro_V6
{
	// Token: 0x02000017 RID: 23
	[DesignerGenerated]
	public partial class Form1 : Form
	{
		// Token: 0x060000CC RID: 204 RVA: 0x0000694D File Offset: 0x00004B4D
		public Form1()
		{
			base.Load += this.Form1_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00006F73 File Offset: 0x00005173
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00006F7D File Offset: 0x0000517D
		internal virtual ToolStrip ToolStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00006F86 File Offset: 0x00005186
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x00006F90 File Offset: 0x00005190
		internal virtual ToolStripButton ToolStripButton1
		{
			[CompilerGenerated]
			get
			{
				return this._ToolStripButton1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripButton1_Click);
				ToolStripButton toolStripButton = this._ToolStripButton1;
				if (toolStripButton != null)
				{
					toolStripButton.Click -= value2;
				}
				this._ToolStripButton1 = value;
				toolStripButton = this._ToolStripButton1;
				if (toolStripButton != null)
				{
					toolStripButton.Click += value2;
				}
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00006FD3 File Offset: 0x000051D3
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x00006FDD File Offset: 0x000051DD
		internal virtual StatusStrip StatusStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00006FE6 File Offset: 0x000051E6
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00006FF0 File Offset: 0x000051F0
		internal virtual ToolStripStatusLabel ToolStripStatusLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00006FF9 File Offset: 0x000051F9
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x00007004 File Offset: 0x00005204
		internal virtual ListView ListView1
		{
			[CompilerGenerated]
			get
			{
				return this._ListView1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ListView1_SelectedIndexChanged);
				ListView listView = this._ListView1;
				if (listView != null)
				{
					listView.SelectedIndexChanged -= value2;
				}
				this._ListView1 = value;
				listView = this._ListView1;
				if (listView != null)
				{
					listView.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00007047 File Offset: 0x00005247
		// (set) Token: 0x060000DA RID: 218 RVA: 0x00007051 File Offset: 0x00005251
		internal virtual ColumnHeader ColumnHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000DB RID: 219 RVA: 0x0000705A File Offset: 0x0000525A
		// (set) Token: 0x060000DC RID: 220 RVA: 0x00007064 File Offset: 0x00005264
		internal virtual ColumnHeader ColumnHeader2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000DD RID: 221 RVA: 0x0000706D File Offset: 0x0000526D
		// (set) Token: 0x060000DE RID: 222 RVA: 0x00007077 File Offset: 0x00005277
		internal virtual ColumnHeader ColumnHeader3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00007080 File Offset: 0x00005280
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x0000708A File Offset: 0x0000528A
		internal virtual ColumnHeader ColumnHeader4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00007093 File Offset: 0x00005293
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x0000709D File Offset: 0x0000529D
		internal virtual ColumnHeader ColumnHeader5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x000070A6 File Offset: 0x000052A6
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x000070B0 File Offset: 0x000052B0
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

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x000070F3 File Offset: 0x000052F3
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x00007100 File Offset: 0x00005300
		internal virtual ToolStripButton ToolStripButton2
		{
			[CompilerGenerated]
			get
			{
				return this._ToolStripButton2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripButton2_Click);
				ToolStripButton toolStripButton = this._ToolStripButton2;
				if (toolStripButton != null)
				{
					toolStripButton.Click -= value2;
				}
				this._ToolStripButton2 = value;
				toolStripButton = this._ToolStripButton2;
				if (toolStripButton != null)
				{
					toolStripButton.Click += value2;
				}
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000030CF File Offset: 0x000012CF
		private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00007144 File Offset: 0x00005344
		private void Form1_Load(object sender, EventArgs e)
		{
			int num3;
			int num5;
			object obj;
			try
			{
				IL_02:
				int num = 1;
				Process process = new Process();
				IL_0A:
				num = 2;
				int num2 = 0;
				IL_0F:
				num = 3;
				this.ListView1.Items.Clear();
				IL_22:
				num = 4;
				checked
				{
					foreach (Process process in Process.GetProcesses(MyProject.Computer.Name))
					{
						IL_43:
						ProjectData.ClearProjectError();
						num3 = -2;
						IL_4C:
						num = 6;
						this.ListView1.Items.Add(process.ProcessName);
						IL_65:
						num = 7;
						this.ListView1.Items[num2].SubItems.Add(Strings.FormatNumber(Math.Round((double)process.PrivateMemorySize64 / 1024.0), 0, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault));
						IL_AB:
						num = 8;
						this.ListView1.Items[num2].SubItems.Add(Conversions.ToString(process.Responding));
						IL_D5:
						num = 9;
						this.ListView1.Items[num2].SubItems.Add(process.StartTime.ToString().Trim());
						IL_109:
						num = 10;
						this.ListView1.Items[num2].SubItems.Add(Conversions.ToString(process.Id));
						IL_134:
						num = 11;
						num2++;
						IL_13D:
						num = 12;
					}
					IL_157:
					num = 13;
					this.ToolStripStatusLabel1.Text = "İşemler : " + Conversions.ToString(this.ListView1.Items.Count);
					IL_185:
					goto IL_217;
					IL_18A:;
				}
				int num4 = num5 + 1;
				num5 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
				IL_1D0:
				goto IL_20C;
				IL_1D2:
				num5 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num3 > -2) ? num3 : 1);
				IL_1EA:;
			}
			catch when (endfilter(obj is Exception & num3 != 0 & num5 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_1D2;
			}
			IL_20C:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_217:
			if (num5 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00007390 File Offset: 0x00005590
		private void ToolStripButton1_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.ListView1.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					Process.GetProcessById(Conversions.ToInteger(listViewItem.SubItems[4].Text)).Kill();
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
			this.Form1_Load(null, null);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000741C File Offset: 0x0000561C
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Form1_Load(null, null);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000030C5 File Offset: 0x000012C5
		private void ToolStripButton2_Click(object sender, EventArgs e)
		{
			base.Close();
		}
	}
}
