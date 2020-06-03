using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace rootip.My
{
	// Token: 0x02000002 RID: 2
	[GeneratedCode("MyTemplate", "11.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal class MyApplication : WindowsFormsApplicationBase
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000022E4 File Offset: 0x000004E4
		[STAThread]
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[MethodImpl(MethodImplOptions.NoOptimization)]
		internal static void Main(string[] args)
		{
			try
			{
				Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
			}
			finally
			{
			}
			MyProject.Application.Run(args);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		[DebuggerStepThrough]
		public MyApplication() : base(AuthenticationMode.Windows)
		{
			base.IsSingleInstance = true;
			base.EnableVisualStyles = true;
			base.SaveMySettingsOnExit = true;
			base.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002075 File Offset: 0x00000275
		[DebuggerStepThrough]
		protected override void OnCreateMainForm()
		{
			base.MainForm = MyProject.Forms.Form1;
		}
	}
}
