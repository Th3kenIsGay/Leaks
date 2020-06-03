using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;

namespace Hosts_Pro_V6
{
	// Token: 0x0200000E RID: 14
	public class ReactorProgressBar : Control
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00004174 File Offset: 0x00002374
		// (set) Token: 0x0600005C RID: 92 RVA: 0x0000418C File Offset: 0x0000238C
		public int Maximum
		{
			get
			{
				return this._Maximum;
			}
			set
			{
				bool flag = value < this._Value;
				if (flag)
				{
					this._Value = value;
				}
				this._Maximum = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600005D RID: 93 RVA: 0x000041C0 File Offset: 0x000023C0
		// (set) Token: 0x0600005E RID: 94 RVA: 0x000041EC File Offset: 0x000023EC
		public int Value
		{
			get
			{
				int value = this._Value;
				int result;
				if (value != 0)
				{
					result = this._Value;
				}
				else
				{
					result = 1;
				}
				return result;
			}
			set
			{
				int num = value;
				bool flag = num > this._Maximum;
				if (flag)
				{
					value = this._Maximum;
				}
				this._Value = value;
				base.Invalidate();
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000030CF File Offset: 0x000012CF
		protected override void OnPaintBackground(PaintEventArgs pevent)
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00004224 File Offset: 0x00002424
		protected override void CreateHandle()
		{
			base.CreateHandle();
			new Thread(new ThreadStart(this.Animate))
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000425C File Offset: 0x0000245C
		public void Animate()
		{
			for (;;)
			{
				bool flag = this.OFS <= base.Width;
				if (flag)
				{
					ref int ptr = ref this.OFS;
					this.OFS = checked(ptr + 1);
				}
				else
				{
					this.OFS = 0;
				}
				base.Invalidate();
				Thread.Sleep(this.Speed);
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000042B1 File Offset: 0x000024B1
		public ReactorProgressBar()
		{
			this.OFS = 0;
			this.Speed = 50;
			this._Maximum = 100;
			this._Value = 0;
			this.DoubleBuffered = true;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000042E4 File Offset: 0x000024E4
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			base.OnPaint(e);
			checked
			{
				int num = (int)Math.Round(unchecked((double)this._Value / (double)this._Maximum * (double)base.Width));
				graphics.Clear(Color.FromArgb(38, 38, 38));
				LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(1, 1, num - 1, base.Height - 2), Color.FromArgb(10, 9, 8), Color.FromArgb(31, 29, 26), 90f);
				graphics.FillRectangle(brush, new Rectangle(1, 1, num - 1, base.Height - 2));
				HatchBrush brush2 = new HatchBrush(HatchStyle.WideUpwardDiagonal, Color.FromArgb(175, 219, 78, 0), Color.FromArgb(175, 229, 98, 0));
				graphics.RenderingOrigin = new Point(this.OFS, 0);
				graphics.FillRectangle(brush2, new Rectangle(1, 1, num - 2, base.Height - 2));
				LinearGradientBrush brush3 = new LinearGradientBrush(new Rectangle(1, 1, num - 2, (int)Math.Round(unchecked((double)base.Height / 2.0 - 1.0))), Color.FromArgb(80, Color.White), Color.FromArgb(50, Color.White), 90f);
				graphics.FillRectangle(brush3, new Rectangle(1, 1, num - 2, (int)Math.Round(unchecked((double)base.Height / 2.0 - 1.0))));
				graphics.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(10, 10, 10))), new Rectangle(0, 0, base.Width - 1, base.Height - 1));
				graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black)), new Rectangle(1, 1, base.Width - 3, base.Height - 3));
				graphics.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(70, 70, 70))), new Rectangle(0, 0, base.Width - 1, base.Height - 1));
				graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(45, 45, 45))), 0, 0, base.Width, 0);
				graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(45, 45, 45))), 0, 0, 0, base.Height);
				graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(45, 45, 45))), base.Width - 1, 0, base.Width - 1, base.Height);
			}
		}

		// Token: 0x04000024 RID: 36
		private int OFS;

		// Token: 0x04000025 RID: 37
		private int Speed;

		// Token: 0x04000026 RID: 38
		private int _Maximum;

		// Token: 0x04000027 RID: 39
		private int _Value;
	}
}
