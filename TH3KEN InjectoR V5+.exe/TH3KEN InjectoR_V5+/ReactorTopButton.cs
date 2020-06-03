using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Hosts_Pro_V6
{
	// Token: 0x0200000D RID: 13
	public class ReactorTopButton : Control
	{
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00003AF4 File Offset: 0x00001CF4
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00003B0C File Offset: 0x00001D0C
		public ReactorTopButton.topButtonType ButtonType
		{
			get
			{
				return this._tbType;
			}
			set
			{
				this._tbType = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00003B20 File Offset: 0x00001D20
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00003B38 File Offset: 0x00001D38
		public bool UseStandardFunction
		{
			get
			{
				return this._defaultFunc;
			}
			set
			{
				this._defaultFunc = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00003B44 File Offset: 0x00001D44
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00003B5C File Offset: 0x00001D5C
		public ReactorTopButton.closeFunc CloseButtonFunction
		{
			get
			{
				return this._closeFunc;
			}
			set
			{
				this._closeFunc = value;
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003B66 File Offset: 0x00001D66
		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);
			this.State = MouseState.Over;
			base.Invalidate();
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003B7F File Offset: 0x00001D7F
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			this.State = MouseState.Down;
			base.Invalidate();
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003B98 File Offset: 0x00001D98
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			this.State = MouseState.None;
			base.Invalidate();
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003BB1 File Offset: 0x00001DB1
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			this.State = MouseState.Over;
			base.Invalidate();
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000030CF File Offset: 0x000012CF
		protected override void OnPaintBackground(PaintEventArgs pevent)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000031AB File Offset: 0x000013AB
		protected override void OnTextChanged(EventArgs e)
		{
			base.OnTextChanged(e);
			base.Invalidate();
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003BCC File Offset: 0x00001DCC
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public void buttonFunction()
		{
			bool defaultFunc = this._defaultFunc;
			if (defaultFunc)
			{
				switch (this.ButtonType)
				{
				case ReactorTopButton.topButtonType.Minimize:
					base.Parent.FindForm().WindowState = FormWindowState.Minimized;
					break;
				case ReactorTopButton.topButtonType.Maximize:
					base.Parent.FindForm().WindowState = FormWindowState.Maximized;
					break;
				case ReactorTopButton.topButtonType.Close:
				{
					ReactorTopButton.closeFunc closeButtonFunction = this.CloseButtonFunction;
					if (closeButtonFunction != ReactorTopButton.closeFunc.CloseForm)
					{
						if (closeButtonFunction == ReactorTopButton.closeFunc.CloseApp)
						{
							Application.Exit();
							ProjectData.EndApp();
						}
					}
					else
					{
						base.Parent.FindForm().Close();
					}
					break;
				}
				}
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003C74 File Offset: 0x00001E74
		public ReactorTopButton()
		{
			base.Click += delegate(object a0, EventArgs a1)
			{
				this.buttonFunction();
			};
			this.State = MouseState.None;
			this._tbType = ReactorTopButton.topButtonType.Blank;
			this._defaultFunc = true;
			this._closeFunc = ReactorTopButton.closeFunc.CloseForm;
			this.BackColor = Color.FromArgb(38, 38, 38);
			this.Font = new Font("Verdana", 6.75f);
			base.Size = new Size(17, 17);
			this.DoubleBuffered = true;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003CF8 File Offset: 0x00001EF8
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			base.OnPaint(e);
			base.Size = new Size(17, 17);
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
					this.buttonColor = Color.FromArgb(163, 163, 162);
					break;
				}
				case MouseState.Over:
				{
					graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(46, 44, 38))), 2, base.Height - 1, base.Width - 4, base.Height - 1);
					LinearGradientBrush brush2 = new LinearGradientBrush(new Rectangle(1, 1, base.Width - 1, base.Height - 2), Color.FromArgb(219, 78, 0), Color.FromArgb(230, 95, 0), 90f);
					graphics.FillRectangle(brush2, new Rectangle(1, 1, base.Width - 1, base.Height - 2));
					graphics.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(245, 120, 10))), new Rectangle(1, 1, base.Width - 3, base.Height - 4));
					this.buttonColor = Color.FromArgb(255, 255, 255);
					break;
				}
				case MouseState.Down:
				{
					graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(36, 34, 30))), 2, base.Height - 1, base.Width - 4, base.Height - 1);
					LinearGradientBrush brush3 = new LinearGradientBrush(new Rectangle(1, 1, base.Width - 1, base.Height - 2), Color.FromArgb(10, 9, 8), Color.FromArgb(31, 29, 26), 270f);
					graphics.FillRectangle(brush3, new Rectangle(1, 1, base.Width - 1, base.Height - 2));
					graphics.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(46, 45, 44))), new Rectangle(1, 1, base.Width - 3, base.Height - 4));
					break;
				}
				}
				switch (this.ButtonType)
				{
				case ReactorTopButton.topButtonType.Minimize:
					graphics.FillRectangle(new SolidBrush(this.buttonColor), new Rectangle(4, 10, 9, 2));
					break;
				case ReactorTopButton.topButtonType.Maximize:
					graphics.DrawRectangle(new Pen(new SolidBrush(this.buttonColor)), new Rectangle(4, 4, 8, 7));
					graphics.DrawLine(new Pen(new SolidBrush(this.buttonColor)), 4, 5, base.Width - 6, 5);
					break;
				case ReactorTopButton.topButtonType.Close:
					graphics.DrawLine(new Pen(new SolidBrush(this.buttonColor), 2f), 4, 4, 12, 11);
					graphics.DrawLine(new Pen(new SolidBrush(this.buttonColor), 2f), 12, 4, 4, 11);
					graphics.DrawLine(new Pen(new SolidBrush(this.buttonColor)), 4, 4, 5, 5);
					graphics.DrawLine(new Pen(new SolidBrush(this.buttonColor)), 4, 11, 5, 10);
					break;
				}
				LinearGradientBrush brush4 = new LinearGradientBrush(new Rectangle(1, 1, base.Width - 2, 7), Color.FromArgb(80, Color.White), Color.FromArgb(50, Color.White), 90f);
				graphics.FillRectangle(brush4, new Rectangle(1, 1, base.Width - 2, 7));
				graphics.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(21, 20, 18))), new Rectangle(0, 0, base.Width - 1, base.Height - 2));
			}
		}

		// Token: 0x0400001F RID: 31
		private Color buttonColor;

		// Token: 0x04000020 RID: 32
		private MouseState State;

		// Token: 0x04000021 RID: 33
		private ReactorTopButton.topButtonType _tbType;

		// Token: 0x04000022 RID: 34
		private bool _defaultFunc;

		// Token: 0x04000023 RID: 35
		private ReactorTopButton.closeFunc _closeFunc;

		// Token: 0x02000021 RID: 33
		public enum topButtonType : byte
		{
			// Token: 0x040000C3 RID: 195
			Blank,
			// Token: 0x040000C4 RID: 196
			Minimize,
			// Token: 0x040000C5 RID: 197
			Maximize,
			// Token: 0x040000C6 RID: 198
			Close
		}

		// Token: 0x02000022 RID: 34
		public enum closeFunc : byte
		{
			// Token: 0x040000C8 RID: 200
			CloseForm,
			// Token: 0x040000C9 RID: 201
			CloseApp
		}
	}
}
