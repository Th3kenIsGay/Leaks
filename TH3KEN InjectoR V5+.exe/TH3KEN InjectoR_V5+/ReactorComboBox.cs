using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Hosts_Pro_V6
{
	// Token: 0x02000012 RID: 18
	public class ReactorComboBox : ComboBox
	{
		// Token: 0x0600009E RID: 158 RVA: 0x000030CF File Offset: 0x000012CF
		protected override void OnPaintBackground(PaintEventArgs pevent)
		{
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600009F RID: 159 RVA: 0x000052D0 File Offset: 0x000034D0
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x000052E8 File Offset: 0x000034E8
		public int StartIndex
		{
			get
			{
				return this._StartIndex;
			}
			set
			{
				this._StartIndex = value;
				try
				{
					base.SelectedIndex = value;
				}
				catch (Exception ex)
				{
				}
				base.Invalidate();
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00005330 File Offset: 0x00003530
		public void ReplaceItem(object sender, DrawItemEventArgs e)
		{
			e.DrawBackground();
			try
			{
				bool flag = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
				if (flag)
				{
					e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(229, 88, 0)), e.Bounds);
				}
				using (SolidBrush solidBrush = new SolidBrush(e.ForeColor))
				{
					e.Graphics.DrawString(base.GetItemText(RuntimeHelpers.GetObjectValue(base.Items[e.Index])), e.Font, solidBrush, e.Bounds);
				}
			}
			catch (Exception ex)
			{
			}
			e.DrawFocusRectangle();
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00005404 File Offset: 0x00003604
		protected void DrawTriangle(Color Clr, Point FirstPoint, Point SecondPoint, Point ThirdPoint, Graphics G)
		{
			List<Point> list = new List<Point>();
			list.Add(FirstPoint);
			list.Add(SecondPoint);
			list.Add(ThirdPoint);
			G.FillPolygon(new SolidBrush(Clr), list.ToArray());
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00005448 File Offset: 0x00003648
		public ReactorComboBox()
		{
			base.DrawItem += this.ReplaceItem;
			this._StartIndex = 0;
			this.LightBlack = Color.FromArgb(37, 37, 37);
			this.LighterBlack = Color.FromArgb(60, 60, 60);
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
			base.DrawMode = DrawMode.OwnerDrawFixed;
			this.BackColor = Color.FromArgb(45, 45, 45);
			this.ForeColor = Color.White;
			base.DropDownStyle = ComboBoxStyle.DropDownList;
			this.DoubleBuffered = true;
			base.Invalidate();
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000054E4 File Offset: 0x000036E4
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Graphics graphics = e.Graphics;
			LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, base.Width, 10), Color.FromArgb(62, Color.White), Color.FromArgb(30, Color.White), 90f);
			SolidBrush solidBrush = new SolidBrush(Color.FromArgb(37, 37, 37));
			checked
			{
				try
				{
					Graphics graphics2 = graphics;
					graphics2.SmoothingMode = SmoothingMode.HighQuality;
					graphics2.Clear(Color.FromArgb(37, 37, 37));
					graphics2.FillRectangle(brush, new Rectangle(base.Width - 20, 0, base.Width, 9));
					graphics2.DrawLine(Pens.Black, base.Width - 20, 0, base.Width - 20, base.Height);
					try
					{
						graphics2.DrawString(this.Text, this.Font, Brushes.White, new Rectangle(3, 0, base.Width - 20, base.Height), new StringFormat
						{
							LineAlignment = StringAlignment.Center,
							Alignment = StringAlignment.Near
						});
					}
					catch (Exception ex)
					{
					}
					graphics2.DrawLine(new Pen(new SolidBrush(Color.FromArgb(37, 37, 37))), 0, 0, 0, 0);
					graphics2.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(0, 0, 0))), new Rectangle(1, 1, base.Width - 3, base.Height - 3));
					graphics2.DrawLine(new Pen(new SolidBrush(Color.FromArgb(45, 45, 45))), 0, 0, base.Width, 0);
					graphics2.DrawLine(new Pen(new SolidBrush(Color.FromArgb(45, 45, 45))), 0, 0, 0, base.Height);
					graphics2.DrawLine(new Pen(new SolidBrush(Color.FromArgb(45, 45, 45))), base.Width - 1, 0, base.Width - 1, base.Height);
					graphics2.DrawLine(new Pen(new SolidBrush(Color.FromArgb(70, 70, 70))), 0, base.Height - 1, base.Width, base.Height - 1);
					this.DrawTriangle(Color.White, new Point(base.Width - 14, 8), new Point(base.Width - 7, 8), new Point(base.Width - 11, 11), graphics);
					graphics2 = null;
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x04000031 RID: 49
		private int _StartIndex;

		// Token: 0x04000032 RID: 50
		private Color LightBlack;

		// Token: 0x04000033 RID: 51
		private Color LighterBlack;
	}
}
