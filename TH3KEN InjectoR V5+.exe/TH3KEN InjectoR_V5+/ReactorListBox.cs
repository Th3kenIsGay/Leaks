using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Hosts_Pro_V6
{
	// Token: 0x02000011 RID: 17
	public class ReactorListBox : Control
	{
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00004E0A File Offset: 0x0000300A
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00004E14 File Offset: 0x00003014
		public virtual ListBox lstbox
		{
			[CompilerGenerated]
			get
			{
				return this._lstbox;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DrawItemEventHandler value2 = new DrawItemEventHandler(this.DrawItem);
				ListBox lstbox = this._lstbox;
				if (lstbox != null)
				{
					lstbox.DrawItem -= value2;
				}
				this._lstbox = value;
				lstbox = this._lstbox;
				if (lstbox != null)
				{
					lstbox.DrawItem += value2;
				}
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000030CF File Offset: 0x000012CF
		protected override void OnPaintBackground(PaintEventArgs pevent)
		{
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00004E57 File Offset: 0x00003057
		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			this.lstbox.Size = checked(new Size(base.Width - 6, base.Height - 6));
			base.Invalidate();
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00004E8A File Offset: 0x0000308A
		protected override void OnBackColorChanged(EventArgs e)
		{
			base.OnBackColorChanged(e);
			this.lstbox.BackColor = this.BackColor;
			base.Invalidate();
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00004EAE File Offset: 0x000030AE
		protected override void OnForeColorChanged(EventArgs e)
		{
			base.OnForeColorChanged(e);
			this.lstbox.ForeColor = this.ForeColor;
			base.Invalidate();
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00004ED2 File Offset: 0x000030D2
		protected override void OnFontChanged(EventArgs e)
		{
			base.OnFontChanged(e);
			this.lstbox.Font = this.Font;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00004EEF File Offset: 0x000030EF
		protected override void OnGotFocus(EventArgs e)
		{
			base.OnGotFocus(e);
			this.lstbox.Focus();
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00004F08 File Offset: 0x00003108
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00004F20 File Offset: 0x00003120
		public string[] Items
		{
			get
			{
				return this.__Items;
			}
			set
			{
				this.__Items = value;
				this.lstbox.Items.Clear();
				base.Invalidate();
				this.lstbox.Items.AddRange(value);
				base.Invalidate();
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00004F5C File Offset: 0x0000315C
		public string SelectedItem
		{
			get
			{
				return Conversions.ToString(this.lstbox.SelectedItem);
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00004F80 File Offset: 0x00003180
		public void DrawItem(object sender, DrawItemEventArgs e)
		{
			try
			{
				e.DrawBackground();
				e.Graphics.DrawString(this.lstbox.Items[e.Index].ToString(), e.Font, new SolidBrush(this.lstbox.ForeColor), e.Bounds, StringFormat.GenericDefault);
				e.DrawFocusRectangle();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000500C File Offset: 0x0000320C
		public void AddRange(object[] Items)
		{
			this.lstbox.Items.Remove("");
			this.lstbox.Items.AddRange(Items);
			base.Invalidate();
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000503E File Offset: 0x0000323E
		public void AddItem(object Item)
		{
			this.lstbox.Items.Add(RuntimeHelpers.GetObjectValue(Item));
			base.Invalidate();
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00005060 File Offset: 0x00003260
		public void NewListBox()
		{
			this.lstbox.Size = new Size(126, 96);
			this.lstbox.BorderStyle = BorderStyle.None;
			this.lstbox.DrawMode = DrawMode.OwnerDrawVariable;
			this.lstbox.Location = new Point(4, 4);
			this.lstbox.ForeColor = Color.FromArgb(216, 216, 216);
			this.lstbox.BackColor = Color.FromArgb(38, 38, 38);
			this.lstbox.Items.Clear();
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000050F8 File Offset: 0x000032F8
		public ReactorListBox()
		{
			this.lstbox = new ListBox();
			this.__Items = new string[]
			{
				""
			};
			this.NewListBox();
			base.Controls.Add(this.lstbox);
			base.Size = new Size(131, 101);
			this.BackColor = Color.FromArgb(38, 38, 38);
			this.DoubleBuffered = true;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00005174 File Offset: 0x00003374
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			base.OnPaint(e);
			graphics.Clear(this.BackColor);
			checked
			{
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(37, 37, 37)), new Rectangle(1, 1, base.Width - 2, base.Height - 2));
				graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black)), new Rectangle(1, 1, base.Width - 3, base.Height - 3));
				graphics.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(70, 70, 70))), new Rectangle(0, 0, base.Width - 1, base.Height - 1));
				graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(45, 45, 45))), 0, 0, base.Width, 0);
				graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(45, 45, 45))), 0, 0, 0, base.Height);
				graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(45, 45, 45))), base.Width - 1, 0, base.Width - 1, base.Height);
				graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(31, 31, 31))), 2, 2, base.Width - 3, 2);
			}
		}

		// Token: 0x04000030 RID: 48
		private string[] __Items;
	}
}
