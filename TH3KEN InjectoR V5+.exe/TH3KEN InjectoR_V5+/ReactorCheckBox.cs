using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Hosts_Pro_V6
{
	// Token: 0x02000014 RID: 20
	[DefaultEvent("CheckedChanged")]
	public class ReactorCheckBox : Control
	{
		// Token: 0x060000AC RID: 172 RVA: 0x00005EA8 File Offset: 0x000040A8
		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);
			this.State = MouseState.Over;
			base.Invalidate();
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00005EC1 File Offset: 0x000040C1
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			this.State = MouseState.Down;
			base.Invalidate();
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00005EDA File Offset: 0x000040DA
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			this.State = MouseState.None;
			base.Invalidate();
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00005EF3 File Offset: 0x000040F3
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			this.State = MouseState.Over;
			base.Invalidate();
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000030CF File Offset: 0x000012CF
		protected override void OnPaintBackground(PaintEventArgs pevent)
		{
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000031AB File Offset: 0x000013AB
		protected override void OnTextChanged(EventArgs e)
		{
			base.OnTextChanged(e);
			base.Invalidate();
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00005F0C File Offset: 0x0000410C
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x00005F24 File Offset: 0x00004124
		public bool Checked
		{
			get
			{
				return this._Checked;
			}
			set
			{
				this._Checked = value;
				base.Invalidate();
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00005F38 File Offset: 0x00004138
		protected override void OnClick(EventArgs e)
		{
			this._Checked = !this._Checked;
			ReactorCheckBox.CheckedChangedEventHandler checkedChangedEvent = this.CheckedChangedEvent;
			if (checkedChangedEvent != null)
			{
				checkedChangedEvent(this);
			}
			base.OnClick(e);
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060000B5 RID: 181 RVA: 0x00005F70 File Offset: 0x00004170
		// (remove) Token: 0x060000B6 RID: 182 RVA: 0x00005FA8 File Offset: 0x000041A8
		public event ReactorCheckBox.CheckedChangedEventHandler CheckedChanged;

		// Token: 0x060000B7 RID: 183 RVA: 0x00005FDD File Offset: 0x000041DD
		public ReactorCheckBox()
		{
			this.State = MouseState.None;
			this.BackColor = Color.FromArgb(38, 38, 38);
			this.ForeColor = Color.White;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000600C File Offset: 0x0000420C
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Graphics graphics = e.Graphics;
			base.Height = 16;
			graphics.Clear(this.BackColor);
			Color color = Color.FromArgb(46, 45, 44);
			checked
			{
				LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(1, 1, 14, base.Height - 2), Color.FromArgb(10, 9, 8), Color.FromArgb(31, 29, 26), 90f);
				LinearGradientBrush brush2 = new LinearGradientBrush(new Rectangle(1, 1, 13, (int)Math.Round(unchecked((double)base.Height / 2.0 - 2.0))), Color.FromArgb(80, Color.White), Color.FromArgb(50, Color.White), 90f);
				bool @checked = this._Checked;
				if (@checked)
				{
					color = Color.FromArgb(225, 110, 30);
					brush = new LinearGradientBrush(new Rectangle(1, 1, 14, base.Height - 2), Color.FromArgb(209, 68, 0), Color.FromArgb(210, 75, 0), 90f);
				}
				else
				{
					color = Color.FromArgb(46, 45, 44);
					brush = new LinearGradientBrush(new Rectangle(1, 1, 14, base.Height - 2), Color.FromArgb(24, 24, 24), Color.FromArgb(30, 30, 30), 90f);
				}
				graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), new Point(18, (int)Math.Round(unchecked((double)base.Height / 2.0 + (double)this.Font.Height - 18.0))));
				graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(36, 34, 30))), 2, base.Height - 1, 14, base.Height - 1);
				graphics.FillRectangle(brush, new Rectangle(1, 1, 14, base.Height - 2));
				graphics.DrawRectangle(new Pen(new SolidBrush(color)), new Rectangle(1, 1, 12, base.Height - 4));
				bool checked2 = this._Checked;
				if (checked2)
				{
					graphics.FillRectangle(brush2, new Rectangle(1, 1, 13, (int)Math.Round(unchecked((double)base.Height / 2.0 - 2.0))));
				}
				graphics.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(10, 10, 10))), new Rectangle(0, 0, 14, base.Height - 2));
			}
		}

		// Token: 0x04000038 RID: 56
		private MouseState State;

		// Token: 0x04000039 RID: 57
		private bool _Checked;

		// Token: 0x02000023 RID: 35
		// (Invoke) Token: 0x0600024D RID: 589
		public delegate void CheckedChangedEventHandler(object sender);
	}
}
