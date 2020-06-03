using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Hosts_Pro_V6
{
	// Token: 0x0200000F RID: 15
	public class ReactorMultiLineTextBox : Control
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00004569 File Offset: 0x00002769
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00004574 File Offset: 0x00002774
		private virtual TextBox txtbox
		{
			[CompilerGenerated]
			get
			{
				return this._txtbox;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = delegate(object a0, EventArgs a1)
				{
					this.TextChngTxtBox();
				};
				TextBox txtbox = this._txtbox;
				if (txtbox != null)
				{
					txtbox.TextChanged -= value2;
				}
				this._txtbox = value;
				txtbox = this._txtbox;
				if (txtbox != null)
				{
					txtbox.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000066 RID: 102 RVA: 0x000045B8 File Offset: 0x000027B8
		// (set) Token: 0x06000067 RID: 103 RVA: 0x000045D0 File Offset: 0x000027D0
		public int MaxCharacters
		{
			get
			{
				return this._maxchars;
			}
			set
			{
				this._maxchars = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000068 RID: 104 RVA: 0x000045E4 File Offset: 0x000027E4
		// (set) Token: 0x06000069 RID: 105 RVA: 0x000045FC File Offset: 0x000027FC
		public HorizontalAlignment TextAlign
		{
			get
			{
				return this._align;
			}
			set
			{
				this._align = value;
				base.Invalidate();
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000030CF File Offset: 0x000012CF
		protected override void OnPaintBackground(PaintEventArgs pevent)
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000031AB File Offset: 0x000013AB
		protected override void OnTextChanged(EventArgs e)
		{
			base.OnTextChanged(e);
			base.Invalidate();
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000460D File Offset: 0x0000280D
		protected override void OnBackColorChanged(EventArgs e)
		{
			base.OnBackColorChanged(e);
			this.txtbox.BackColor = this.BackColor;
			base.Invalidate();
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00004631 File Offset: 0x00002831
		protected override void OnForeColorChanged(EventArgs e)
		{
			base.OnForeColorChanged(e);
			this.txtbox.ForeColor = this.ForeColor;
			base.Invalidate();
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00004655 File Offset: 0x00002855
		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			this.txtbox.Size = checked(new Size(base.Width - 10, base.Height - 11));
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00004683 File Offset: 0x00002883
		protected override void OnFontChanged(EventArgs e)
		{
			base.OnFontChanged(e);
			this.txtbox.Font = this.Font;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000046A0 File Offset: 0x000028A0
		protected override void OnGotFocus(EventArgs e)
		{
			base.OnGotFocus(e);
			this.txtbox.Focus();
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000046B7 File Offset: 0x000028B7
		public void TextChngTxtBox()
		{
			this.Text = this.txtbox.Text;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000046CC File Offset: 0x000028CC
		public void TextChng()
		{
			this.txtbox.Text = this.Text;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000046E4 File Offset: 0x000028E4
		public void NewTextBox()
		{
			TextBox txtbox = this.txtbox;
			txtbox.Multiline = true;
			txtbox.BackColor = this.BackColor;
			txtbox.ForeColor = this.ForeColor;
			txtbox.Text = string.Empty;
			txtbox.TextAlign = HorizontalAlignment.Center;
			txtbox.BorderStyle = BorderStyle.None;
			txtbox.Location = new Point(2, 4);
			txtbox.Font = new Font("Verdana", 7.25f);
			txtbox.Size = checked(new Size(base.Width - 10, base.Height - 10));
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00004780 File Offset: 0x00002980
		public ReactorMultiLineTextBox()
		{
			base.TextChanged += delegate(object a0, EventArgs a1)
			{
				this.TextChng();
			};
			this.txtbox = new TextBox();
			this._maxchars = 32767;
			this.NewTextBox();
			base.Controls.Add(this.txtbox);
			this.Text = "";
			this.BackColor = Color.FromArgb(37, 37, 37);
			this.ForeColor = Color.White;
			base.Size = new Size(135, 35);
			this.DoubleBuffered = true;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00004820 File Offset: 0x00002A20
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			base.OnPaint(e);
			this.txtbox.TextAlign = this.TextAlign;
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

		// Token: 0x04000029 RID: 41
		private int _maxchars;

		// Token: 0x0400002A RID: 42
		private HorizontalAlignment _align;
	}
}
