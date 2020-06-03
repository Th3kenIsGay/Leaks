using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Hosts_Pro_V6
{
	// Token: 0x0200000C RID: 12
	public class ReactorButton : Control
	{
		// Token: 0x06000043 RID: 67 RVA: 0x00003642 File Offset: 0x00001842
		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);
			this.State = MouseState.Over;
			base.Invalidate();
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000365B File Offset: 0x0000185B
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			this.State = MouseState.Down;
			base.Invalidate();
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003674 File Offset: 0x00001874
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			this.State = MouseState.None;
			base.Invalidate();
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000368D File Offset: 0x0000188D
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			this.State = MouseState.Over;
			base.Invalidate();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000030CF File Offset: 0x000012CF
		protected override void OnPaintBackground(PaintEventArgs pevent)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000031AB File Offset: 0x000013AB
		protected override void OnTextChanged(EventArgs e)
		{
			base.OnTextChanged(e);
			base.Invalidate();
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000036A8 File Offset: 0x000018A8
		public ReactorButton()
		{
			this.State = MouseState.None;
			this.BackColor = Color.FromArgb(38, 38, 38);
			this.Font = new Font("Verdana", 6.75f);
			this.DoubleBuffered = true;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000036F4 File Offset: 0x000018F4
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			base.OnPaint(e);
			graphics.Clear(Color.FromArgb(36, 34, 30));
			checked
			{
				switch (this.State)
				{
				case MouseState.None:
				{
					graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(36, 34, 30))), 2, base.Height - 1, base.Width - 4, base.Height - 1);
					LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(1, 1, base.Width - 1, base.Height - 2), Color.FromArgb(10, 9, 8), Color.FromArgb(31, 29, 26), 90f);
					graphics.FillRectangle(brush, new Rectangle(1, 1, base.Width - 1, base.Height - 2));
					graphics.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(46, 45, 44))), new Rectangle(1, 1, base.Width - 3, base.Height - 4));
					break;
				}
				case MouseState.Over:
				{
					graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(46, 44, 38))), 2, base.Height - 1, base.Width - 4, base.Height - 1);
					LinearGradientBrush brush2 = new LinearGradientBrush(new Rectangle(1, 1, base.Width - 1, base.Height - 2), Color.FromArgb(219, 78, 0), Color.FromArgb(230, 95, 0), 90f);
					graphics.FillRectangle(brush2, new Rectangle(1, 1, base.Width - 1, base.Height - 2));
					graphics.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(245, 120, 10))), new Rectangle(1, 1, base.Width - 3, base.Height - 4));
					break;
				}
				case MouseState.Down:
				{
					graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(36, 34, 30))), 2, base.Height - 1, base.Width - 4, base.Height - 1);
					LinearGradientBrush brush3 = new LinearGradientBrush(new Rectangle(1, 1, base.Width - 1, base.Height - 2), Color.FromArgb(209, 68, 0), Color.FromArgb(210, 75, 0), 270f);
					graphics.FillRectangle(brush3, new Rectangle(1, 1, base.Width - 1, base.Height - 2));
					graphics.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(225, 110, 30))), new Rectangle(1, 1, base.Width - 3, base.Height - 4));
					break;
				}
				}
				LinearGradientBrush brush4 = new LinearGradientBrush(new Rectangle(1, 1, base.Width - 2, (int)Math.Round(unchecked((double)base.Height / 2.0 - 2.0))), Color.FromArgb(80, Color.White), Color.FromArgb(50, Color.White), 90f);
				graphics.FillRectangle(brush4, new Rectangle(1, 1, base.Width - 2, (int)Math.Round(unchecked((double)base.Height / 2.0 - 2.0))));
				graphics.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(21, 20, 18))), new Rectangle(0, 0, base.Width - 1, base.Height - 2));
				graphics.DrawString(this.Text, this.Font, Brushes.Black, new Rectangle(0, -2, base.Width - 1, base.Height - 1), new StringFormat
				{
					LineAlignment = StringAlignment.Center,
					Alignment = StringAlignment.Center
				});
				graphics.DrawString(this.Text, this.Font, Brushes.White, new Rectangle(0, -1, base.Width - 1, base.Height - 1), new StringFormat
				{
					LineAlignment = StringAlignment.Center,
					Alignment = StringAlignment.Center
				});
			}
		}

		// Token: 0x0400001E RID: 30
		private MouseState State;
	}
}
