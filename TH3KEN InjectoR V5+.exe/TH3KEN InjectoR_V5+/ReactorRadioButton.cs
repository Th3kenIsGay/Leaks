using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Hosts_Pro_V6
{
	// Token: 0x02000015 RID: 21
	[DefaultEvent("CheckedChanged")]
	public class ReactorRadioButton : Control
	{
		// Token: 0x060000B9 RID: 185 RVA: 0x0000628D File Offset: 0x0000448D
		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);
			this.State = MouseState.Over;
			base.Invalidate();
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000062A6 File Offset: 0x000044A6
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			this.State = MouseState.Down;
			base.Invalidate();
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000062BF File Offset: 0x000044BF
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			this.State = MouseState.None;
			base.Invalidate();
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000062D8 File Offset: 0x000044D8
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			this.State = MouseState.Over;
			base.Invalidate();
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000030CF File Offset: 0x000012CF
		protected override void OnPaintBackground(PaintEventArgs pevent)
		{
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000031AB File Offset: 0x000013AB
		protected override void OnTextChanged(EventArgs e)
		{
			base.OnTextChanged(e);
			base.Invalidate();
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000BF RID: 191 RVA: 0x000062F4 File Offset: 0x000044F4
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x0000630C File Offset: 0x0000450C
		public bool Checked
		{
			get
			{
				return this._Checked;
			}
			set
			{
				this._Checked = value;
				this.InvalidateControls();
				ReactorRadioButton.CheckedChangedEventHandler checkedChangedEvent = this.CheckedChangedEvent;
				if (checkedChangedEvent != null)
				{
					checkedChangedEvent(this);
				}
				base.Invalidate();
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00006344 File Offset: 0x00004544
		protected override void OnClick(EventArgs e)
		{
			bool flag = !this._Checked;
			if (flag)
			{
				this.Checked = true;
			}
			base.OnClick(e);
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060000C2 RID: 194 RVA: 0x00006370 File Offset: 0x00004570
		// (remove) Token: 0x060000C3 RID: 195 RVA: 0x000063A8 File Offset: 0x000045A8
		public event ReactorRadioButton.CheckedChangedEventHandler CheckedChanged;

		// Token: 0x060000C4 RID: 196 RVA: 0x000063DD File Offset: 0x000045DD
		protected override void OnCreateControl()
		{
			base.OnCreateControl();
			this.InvalidateControls();
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000063F0 File Offset: 0x000045F0
		private void InvalidateControls()
		{
			bool flag = !base.IsHandleCreated || !this._Checked;
			if (!flag)
			{
				try
				{
					foreach (object obj in base.Parent.Controls)
					{
						Control control = (Control)obj;
						bool flag2 = control != this && control is ReactorRadioButton;
						if (flag2)
						{
							((ReactorRadioButton)control).Checked = false;
						}
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
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00006490 File Offset: 0x00004690
		public ReactorRadioButton()
		{
			this.State = MouseState.None;
			this.BackColor = Color.FromArgb(38, 38, 38);
			this.ForeColor = Color.White;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000064C0 File Offset: 0x000046C0
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Graphics graphics = e.Graphics;
			base.Height = 16;
			graphics.Clear(this.BackColor);
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			this.R1 = new Rectangle(2, 0, 13, 13);
			bool @checked = this._Checked;
			if (@checked)
			{
				this.G1 = new LinearGradientBrush(this.R1, Color.FromArgb(220, 209, 68, 0), Color.FromArgb(220, 210, 75, 0), 90f);
			}
			else
			{
				this.G1 = new LinearGradientBrush(this.R1, Color.FromArgb(24, 24, 24), Color.FromArgb(30, 30, 30), 90f);
			}
			graphics.FillEllipse(this.G1, this.R1);
			bool flag = this.State == MouseState.Over;
			if (flag)
			{
				this.R1 = new Rectangle(2, 0, 13, 13);
				graphics.FillEllipse(new SolidBrush(Color.FromArgb(5, Color.White)), this.R1);
			}
			bool checked2 = this._Checked;
			if (checked2)
			{
				this.R1 = new Rectangle(4, 1, 9, 6);
				this.G1 = new LinearGradientBrush(this.R1, Color.FromArgb(80, 255, 255, 255), Color.FromArgb(30, 255, 255, 255), 90f);
				graphics.FillEllipse(this.G1, this.R1);
				graphics.DrawEllipse(new Pen(new SolidBrush(Color.FromArgb(225, 110, 30))), 3, 1, 11, 11);
			}
			graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), 18f, 1f);
			graphics.DrawEllipse(Pens.Black, 2, 0, 13, 13);
			graphics.DrawEllipse(new Pen(Color.FromArgb(15, Color.White)), 1, -1, 15, 15);
		}

		// Token: 0x0400003B RID: 59
		private Rectangle R1;

		// Token: 0x0400003C RID: 60
		private LinearGradientBrush G1;

		// Token: 0x0400003D RID: 61
		private MouseState State;

		// Token: 0x0400003E RID: 62
		private bool _Checked;

		// Token: 0x02000024 RID: 36
		// (Invoke) Token: 0x06000251 RID: 593
		public delegate void CheckedChangedEventHandler(object sender);
	}
}
