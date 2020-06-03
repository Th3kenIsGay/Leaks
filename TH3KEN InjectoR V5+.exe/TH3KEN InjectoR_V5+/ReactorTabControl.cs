using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Hosts_Pro_V6
{
	// Token: 0x02000013 RID: 19
	public class ReactorTabControl : TabControl
	{
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00005780 File Offset: 0x00003980
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x00005798 File Offset: 0x00003998
		public Color TabBorderColor
		{
			get
			{
				return this._TabBrColor;
			}
			set
			{
				this._TabBrColor = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x000057AC File Offset: 0x000039AC
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x000057C4 File Offset: 0x000039C4
		public Color TabTextColor
		{
			get
			{
				return this._ControlBColor;
			}
			set
			{
				this._ControlBColor = value;
				base.Invalidate();
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000030CF File Offset: 0x000012CF
		protected override void OnPaintBackground(PaintEventArgs pevent)
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000057D5 File Offset: 0x000039D5
		public ReactorTabControl()
		{
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
			this.TabBorderColor = Color.White;
			this.TabTextColor = Color.White;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00005804 File Offset: 0x00003A04
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			base.OnPaint(e);
			checked
			{
				Rectangle rect = new Rectangle(0, 0, base.Width - 1, 25);
				Rectangle rect2 = new Rectangle(0, 0, base.Width - 1, 25);
				Rectangle rect3 = new Rectangle(2, 0, base.Width - 1, 13);
				SolidBrush solidBrush = new SolidBrush(Color.Empty);
				SolidBrush solidBrush2 = new SolidBrush(Color.DimGray);
				LinearGradientBrush brush = new LinearGradientBrush(rect3, Color.FromArgb(50, Color.White), Color.FromArgb(25, Color.White), 90f);
				graphics.Clear(Color.FromArgb(32, 32, 32));
				this.DrawGradientBrush2 = new LinearGradientBrush(rect2, Color.FromArgb(10, 10, 10), Color.FromArgb(50, 50, 50), 90f);
				graphics.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(28, 28, 28))), new Rectangle(1, 1, base.Width - 3, base.Height - 3));
				graphics.FillRectangle(this.DrawGradientBrush2, rect);
				graphics.FillRectangle(brush, rect3);
				int num = base.TabCount - 1;
				for (int i = 0; i <= num; i++)
				{
					Rectangle tabRect = base.GetTabRect(i);
					bool flag = (i & 1) != 0;
					if (flag)
					{
						solidBrush2.Color = Color.Transparent;
					}
					else
					{
						solidBrush2.Color = Color.Transparent;
					}
					graphics.FillRectangle(solidBrush2, tabRect);
					bool flag2 = i == base.SelectedIndex;
					Pen pen;
					if (flag2)
					{
						pen = new Pen(Color.Transparent, 1f);
						LinearGradientBrush brush2 = new LinearGradientBrush(new Rectangle(tabRect.Location.X + 3, tabRect.Location.Y + 3, tabRect.Width - 8, tabRect.Height - 6), Color.FromArgb(175, 219, 78, 0), Color.FromArgb(175, 229, 98, 0), 90f);
						LinearGradientBrush brush3 = new LinearGradientBrush(new Rectangle(tabRect.Location.X + 3, tabRect.Location.Y + 3, tabRect.Width - 8, (int)Math.Round(unchecked((double)tabRect.Height / 2.0 - 5.0))), Color.FromArgb(80, Color.White), Color.FromArgb(20, Color.White), 90f);
						graphics.FillRectangle(brush2, new Rectangle(tabRect.Location.X + 3, tabRect.Location.Y + 3, tabRect.Width - 8, tabRect.Height - 6));
						graphics.FillRectangle(brush3, new Rectangle(tabRect.Location.X + 3, tabRect.Location.Y + 3, tabRect.Width - 8, (int)Math.Round(unchecked((double)tabRect.Height / 2.0 - 4.0))));
						graphics.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(10, 10, 10))), new Rectangle(tabRect.Location.X + 3, tabRect.Location.Y + 3, tabRect.Width - 8, tabRect.Height - 6));
						graphics.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(100, 230, 90, 0))), new Rectangle(tabRect.Location.X + 4, tabRect.Location.Y + 4, tabRect.Width - 10, tabRect.Height - 8));
						Rectangle rectangle = new Rectangle(1, 1, base.Width - 1, 3);
					}
					else
					{
						pen = new Pen(Color.Transparent, 1f);
					}
					graphics.DrawRectangle(pen, new Rectangle(tabRect.Location.X + 3, tabRect.Location.Y + 1, tabRect.Width - 8, tabRect.Height - 4));
					pen.Dispose();
					StringFormat stringFormat = new StringFormat();
					stringFormat.LineAlignment = StringAlignment.Center;
					stringFormat.Alignment = StringAlignment.Center;
					bool flag3 = base.SelectedIndex == i;
					if (flag3)
					{
						solidBrush.Color = this.TabTextColor;
					}
					else
					{
						solidBrush.Color = Color.DimGray;
					}
					graphics.DrawString(base.TabPages[i].Text, this.Font, solidBrush, base.GetTabRect(i), stringFormat);
					try
					{
						base.TabPages[i].BackColor = Color.FromArgb(32, 32, 32);
					}
					catch (Exception ex)
					{
					}
				}
				try
				{
					try
					{
						foreach (object obj in base.TabPages)
						{
							TabPage tabPage = (TabPage)obj;
							tabPage.BorderStyle = BorderStyle.None;
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
				catch (Exception ex2)
				{
				}
				graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(10, 10, 10))), 2, 24, base.Width - 2, 24);
				graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black)), new Rectangle(1, 1, base.Width - 3, base.Height - 3));
				graphics.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(70, 70, 70))), new Rectangle(0, 0, base.Width - 1, base.Height - 1));
				graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(45, 45, 45))), 0, 0, base.Width, 0);
				graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(45, 45, 45))), 0, 0, 0, base.Height);
				graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(45, 45, 45))), base.Width - 1, 0, base.Width - 1, base.Height);
				graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(31, 31, 31))), 2, 2, base.Width - 3, 2);
			}
		}

		// Token: 0x04000034 RID: 52
		private LinearGradientBrush DrawGradientBrush;

		// Token: 0x04000035 RID: 53
		private LinearGradientBrush DrawGradientBrush2;

		// Token: 0x04000036 RID: 54
		private Color _TabBrColor;

		// Token: 0x04000037 RID: 55
		private Color _ControlBColor;
	}
}
