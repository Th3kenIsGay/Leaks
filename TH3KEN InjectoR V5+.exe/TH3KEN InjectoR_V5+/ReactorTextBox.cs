using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Hosts_Pro_V6
{
	// Token: 0x02000010 RID: 16
	public class ReactorTextBox : Control
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00004991 File Offset: 0x00002B91
		// (set) Token: 0x06000079 RID: 121 RVA: 0x0000499C File Offset: 0x00002B9C
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

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600007A RID: 122 RVA: 0x000049E0 File Offset: 0x00002BE0
		// (set) Token: 0x0600007B RID: 123 RVA: 0x000049F8 File Offset: 0x00002BF8
		public bool UsePasswordMask
		{
			get
			{
				return this._passmask;
			}
			set
			{
				this._passmask = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00004A0C File Offset: 0x00002C0C
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00004A24 File Offset: 0x00002C24
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

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00004A38 File Offset: 0x00002C38
		// (set) Token: 0x0600007F RID: 127 RVA: 0x00004A50 File Offset: 0x00002C50
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

		// Token: 0x06000080 RID: 128 RVA: 0x000030CF File Offset: 0x000012CF
		protected override void OnPaintBackground(PaintEventArgs pevent)
		{
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000031AB File Offset: 0x000013AB
		protected override void OnTextChanged(EventArgs e)
		{
			base.OnTextChanged(e);
			base.Invalidate();
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00004A61 File Offset: 0x00002C61
		protected override void OnBackColorChanged(EventArgs e)
		{
			base.OnBackColorChanged(e);
			this.txtbox.BackColor = this.BackColor;
			base.Invalidate();
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00004A85 File Offset: 0x00002C85
		protected override void OnForeColorChanged(EventArgs e)
		{
			base.OnForeColorChanged(e);
			this.txtbox.ForeColor = this.ForeColor;
			base.Invalidate();
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00004AA9 File Offset: 0x00002CA9
		protected override void OnFontChanged(EventArgs e)
		{
			base.OnFontChanged(e);
			this.txtbox.Font = this.Font;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00004AC6 File Offset: 0x00002CC6
		protected override void OnGotFocus(EventArgs e)
		{
			base.OnGotFocus(e);
			this.txtbox.Focus();
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00004ADD File Offset: 0x00002CDD
		public void TextChngTxtBox()
		{
			this.Text = this.txtbox.Text;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00004AF2 File Offset: 0x00002CF2
		public void TextChng()
		{
			this.txtbox.Text = this.Text;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00004B08 File Offset: 0x00002D08
		public void NewTextBox()
		{
			TextBox txtbox = this.txtbox;
			txtbox.Multiline = false;
			txtbox.BackColor = this.BackColor;
			txtbox.ForeColor = this.ForeColor;
			txtbox.Text = string.Empty;
			txtbox.TextAlign = HorizontalAlignment.Center;
			txtbox.BorderStyle = BorderStyle.None;
			txtbox.Location = new Point(5, 5);
			txtbox.Font = new Font("Verdana", 7.25f);
			txtbox.Size = checked(new Size(base.Width - 10, base.Height - 11));
			txtbox.UseSystemPasswordChar = this.UsePasswordMask;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00004BB0 File Offset: 0x00002DB0
		public ReactorTextBox()
		{
			base.TextChanged += delegate(object a0, EventArgs a1)
			{
				this.TextChng();
			};
			this.txtbox = new TextBox();
			this._passmask = false;
			this._maxchars = 32767;
			this.NewTextBox();
			base.Controls.Add(this.txtbox);
			this.Text = "";
			this.BackColor = Color.FromArgb(37, 37, 37);
			this.ForeColor = Color.White;
			base.Size = new Size(135, 35);
			this.DoubleBuffered = true;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00004C54 File Offset: 0x00002E54
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			base.OnPaint(e);
			checked
			{
				base.Height = this.txtbox.Height + 11;
				TextBox txtbox = this.txtbox;
				txtbox.Width = base.Width - 10;
				txtbox.TextAlign = this.TextAlign;
				txtbox.UseSystemPasswordChar = this.UsePasswordMask;
				graphics.Clear(this.BackColor);
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(37, 37, 37)), new Rectangle(1, 1, base.Width - 2, base.Height - 2));
				graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black)), new Rectangle(1, 1, base.Width - 3, base.Height - 3));
				graphics.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(70, 70, 70))), new Rectangle(0, 0, base.Width - 1, base.Height - 1));
				graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(45, 45, 45))), 0, 0, base.Width, 0);
				graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(45, 45, 45))), 0, 0, 0, base.Height);
				graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(45, 45, 45))), base.Width - 1, 0, base.Width - 1, base.Height);
				graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(31, 31, 31))), 2, 2, base.Width - 3, 2);
			}
		}

		// Token: 0x0400002C RID: 44
		private bool _passmask;

		// Token: 0x0400002D RID: 45
		private int _maxchars;

		// Token: 0x0400002E RID: 46
		private HorizontalAlignment _align;
	}
}
