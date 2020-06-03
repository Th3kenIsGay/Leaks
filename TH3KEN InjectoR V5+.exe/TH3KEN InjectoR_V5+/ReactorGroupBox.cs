using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Hosts_Pro_V6
{
	// Token: 0x02000016 RID: 22
	public class ReactorGroupBox : ContainerControl
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x000030CF File Offset: 0x000012CF
		protected override void OnPaintBackground(PaintEventArgs pevent)
		{
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000031AB File Offset: 0x000013AB
		protected override void OnTextChanged(EventArgs e)
		{
			base.OnTextChanged(e);
			base.Invalidate();
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000066C2 File Offset: 0x000048C2
		public ReactorGroupBox()
		{
			this.BackColor = Color.FromArgb(33, 33, 33);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000066E0 File Offset: 0x000048E0
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Graphics graphics = e.Graphics;
			graphics.Clear(this.BackColor);
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, base.Width, 24), Color.FromArgb(10, 10, 10), Color.FromArgb(50, 50, 50), 90f);
			graphics.FillRectangle(brush, new Rectangle(0, 0, base.Width, 24));
			LinearGradientBrush brush2 = new LinearGradientBrush(new Rectangle(0, 0, base.Width, 12), Color.FromArgb(60, Color.White), Color.FromArgb(20, Color.White), 90f);
			graphics.FillRectangle(brush2, new Rectangle(0, 0, base.Width, 12));
			graphics.DrawLine(Pens.Black, 0, 24, base.Width, 24);
			checked
			{
				graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black)), new Rectangle(1, 1, base.Width - 3, base.Height - 3));
				graphics.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(70, 70, 70))), new Rectangle(0, 0, base.Width - 1, base.Height - 1));
				graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(45, 45, 45))), 0, 0, base.Width, 0);
				graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(45, 45, 45))), 0, 0, 0, base.Height);
				graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(45, 45, 45))), base.Width - 1, 0, base.Width - 1, base.Height);
				graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(31, 31, 31))), 2, 2, base.Width - 3, 2);
			}
			graphics.DrawString(this.Text, this.Font, Brushes.Black, (float)((double)base.Width / 2.0 - (double)(checked(3 * this.Text.Length)) + 1.0), 6f);
			graphics.DrawString(this.Text, this.Font, Brushes.White, (float)((double)base.Width / 2.0 - (double)(checked(3 * this.Text.Length)) + 1.0), 7f);
		}
	}
}
