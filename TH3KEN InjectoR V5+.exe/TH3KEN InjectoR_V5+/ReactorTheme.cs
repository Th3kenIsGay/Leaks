using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Hosts_Pro_V6
{
	// Token: 0x0200000B RID: 11
	public class ReactorTheme : ContainerControl
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000037 RID: 55 RVA: 0x000030D2 File Offset: 0x000012D2
		// (set) Token: 0x06000038 RID: 56 RVA: 0x000030DC File Offset: 0x000012DC
		private virtual ReactorTopButton CloseBtn { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000030E5 File Offset: 0x000012E5
		// (set) Token: 0x0600003A RID: 58 RVA: 0x000030EF File Offset: 0x000012EF
		private virtual ReactorTopButton MinimBtn { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x0600003B RID: 59 RVA: 0x000030CF File Offset: 0x000012CF
		protected override void OnPaintBackground(PaintEventArgs e)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000030F8 File Offset: 0x000012F8
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			bool flag = e.Button == MouseButtons.Left & new Rectangle(0, 0, base.Width, this.MoveHeight).Contains(e.Location);
			if (flag)
			{
				this.Cap = true;
				this.MouseP = e.Location;
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003156 File Offset: 0x00001356
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			this.Cap = false;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003168 File Offset: 0x00001368
		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);
			bool cap = this.Cap;
			if (cap)
			{
				base.Parent.Location = Control.MousePosition - (Size)this.MouseP;
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000031AB File Offset: 0x000013AB
		protected override void OnTextChanged(EventArgs e)
		{
			base.OnTextChanged(e);
			base.Invalidate();
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000031C0 File Offset: 0x000013C0
		public ReactorTheme()
		{
			this.CloseBtn = new ReactorTopButton
			{
				Location = new Point(412, 7),
				ButtonType = ReactorTopButton.topButtonType.Close,
				CloseButtonFunction = ReactorTopButton.closeFunc.CloseForm
			};
			this.MinimBtn = new ReactorTopButton
			{
				Location = new Point(393, 7),
				ButtonType = ReactorTopButton.topButtonType.Minimize
			};
			this.MouseP = new Point(0, 0);
			this.Cap = false;
			this.Dock = DockStyle.Fill;
			this.MoveHeight = 45;
			this.Font = new Font("Verdana", 6.75f);
			this.DoubleBuffered = true;
			base.Controls.Add(this.CloseBtn);
			base.Controls.Add(this.MinimBtn);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003290 File Offset: 0x00001490
		protected override void OnPaint(PaintEventArgs e)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_02:
				ProjectData.ClearProjectError();
				num = -2;
				IL_0B:
				int num2 = 2;
				Graphics graphics = e.Graphics;
				IL_14:
				num2 = 3;
				base.OnPaint(e);
				IL_1E:
				num2 = 4;
				bool flag = base.ParentForm.FormBorderStyle > FormBorderStyle.None;
				if (!flag)
				{
					goto IL_44;
				}
				IL_34:
				num2 = 5;
				base.ParentForm.FormBorderStyle = FormBorderStyle.None;
				IL_43:
				IL_44:
				IL_45:
				num2 = 7;
				checked
				{
					this.CloseBtn.Location = new Point(base.Width - 23, 7);
					IL_62:
					num2 = 8;
					this.MinimBtn.Location = new Point(base.Width - 42, 7);
					IL_7F:
					num2 = 9;
					LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(5, 31, base.Width - 11, 20), Color.FromArgb(23, 23, 22), Color.FromArgb(38, 38, 38), 90f);
					IL_B7:
					num2 = 10;
					LinearGradientBrush linearGradientBrush = new LinearGradientBrush(new Rectangle(0, 15, base.Width, 15), Color.Black, Color.FromArgb(26, 25, 21), 90f);
					IL_E6:
					num2 = 11;
					graphics.Clear(Color.FromArgb(26, 25, 21));
					IL_FB:
					num2 = 12;
					graphics.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(42, 41, 37))), 4, 30, base.Width - 9, base.Height - 36);
					IL_12F:
					num2 = 13;
					graphics.FillRectangle(new SolidBrush(Color.FromArgb(38, 38, 38)), new Rectangle(5, 31, base.Width - 11, base.Height - 38));
					IL_163:
					num2 = 14;
					graphics.FillRectangle(brush, new Rectangle(5, 31, base.Width - 11, 20));
					IL_182:
					num2 = 15;
					graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(24, 24, 24))), 5, 32, base.Width - 7, 32);
					IL_1AE:
					num2 = 16;
					graphics.DrawRectangle(Pens.Black, new Rectangle(5, 31, base.Width - 11, base.Height - 38));
					IL_1D7:
					num2 = 17;
					graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(151, 150, 146))), 1, 1, base.Width - 2, 1);
					IL_20A:
					num2 = 18;
					graphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, base.Width - 1, base.Height - 1));
					IL_230:
					num2 = 19;
					graphics.DrawString(this.Text, this.Font, Brushes.Black, new Rectangle(0, 10, base.Width - 1, 10), new StringFormat
					{
						LineAlignment = StringAlignment.Center,
						Alignment = StringAlignment.Center
					});
					IL_277:
					num2 = 20;
					graphics.DrawString(this.Text, this.Font, Brushes.White, new Rectangle(0, 11, base.Width - 1, 11), new StringFormat
					{
						LineAlignment = StringAlignment.Center,
						Alignment = StringAlignment.Center
					});
					IL_2BE:
					goto IL_36C;
					IL_2C3:;
				}
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_325:
				goto IL_361;
				IL_327:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_33F:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_327;
			}
			IL_361:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_36C:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003630 File Offset: 0x00001830
		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400001B RID: 27
		private Point MouseP;

		// Token: 0x0400001C RID: 28
		private bool Cap;

		// Token: 0x0400001D RID: 29
		private int MoveHeight;
	}
}
