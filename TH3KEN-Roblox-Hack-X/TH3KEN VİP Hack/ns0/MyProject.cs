using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using ns2;

namespace ns0
{
	// Token: 0x02000004 RID: 4
	[StandardModule]
	[HideModuleName]
	[GeneratedCode("MyTemplate", "11.0.0.0")]
	internal sealed class MyProject
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002658 File Offset: 0x00000858
		[HelpKeyword("My.Computer")]
		internal static MyComputer Computer
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_ComputerObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002674 File Offset: 0x00000874
		[HelpKeyword("My.Application")]
		internal static MyApplication Application
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_AppObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002690 File Offset: 0x00000890
		[HelpKeyword("My.User")]
		internal static User User
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_UserObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000026AC File Offset: 0x000008AC
		[HelpKeyword("My.Forms")]
		internal static MyProject.MyForms Forms
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyFormsObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000026C8 File Offset: 0x000008C8
		[HelpKeyword("My.WebServices")]
		internal static MyProject.MyWebServices WebServices
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyWebServicesObjectProvider.GetInstance;
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();

		// Token: 0x04000002 RID: 2
		private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();

		// Token: 0x04000003 RID: 3
		private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();

		// Token: 0x04000004 RID: 4
		private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();

		// Token: 0x04000005 RID: 5
		private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

		// Token: 0x0200000D RID: 13
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
		internal sealed class MyForms
		{
			// Token: 0x060000A6 RID: 166 RVA: 0x000066D8 File Offset: 0x000048D8
			[DebuggerHidden]
			private static T Create__Instance__<T>(T Instance) where T : Form, new()
			{
				if (Instance == null || Instance.IsDisposed)
				{
					if (MyProject.MyForms.m_FormBeingCreated != null)
					{
						if (MyProject.MyForms.m_FormBeingCreated.ContainsKey(typeof(T)))
						{
							throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
						}
					}
					else
					{
						MyProject.MyForms.m_FormBeingCreated = new Hashtable();
					}
					MyProject.MyForms.m_FormBeingCreated.Add(typeof(T), null);
					try
					{
						return Activator.CreateInstance<T>();
					}
					catch (TargetInvocationException ex) when (ex.InnerException != null)
					{
						string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[]
						{
							ex.InnerException.Message
						});
						throw new InvalidOperationException(resourceString, ex.InnerException);
					}
					finally
					{
						MyProject.MyForms.m_FormBeingCreated.Remove(typeof(T));
					}
				}
				return Instance;
			}

			// Token: 0x060000A7 RID: 167 RVA: 0x000024AB File Offset: 0x000006AB
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance) where T : Form
			{
				instance.Dispose();
				instance = default(T);
			}

			// Token: 0x060000A8 RID: 168 RVA: 0x000024C0 File Offset: 0x000006C0
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyForms()
			{
			}

			// Token: 0x060000A9 RID: 169 RVA: 0x000067E8 File Offset: 0x000049E8
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x060000AA RID: 170 RVA: 0x00006804 File Offset: 0x00004A04
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x060000AB RID: 171 RVA: 0x0000681C File Offset: 0x00004A1C
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyProject.MyForms);
			}

			// Token: 0x060000AC RID: 172 RVA: 0x00006838 File Offset: 0x00004A38
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x060000AD RID: 173 RVA: 0x000024C8 File Offset: 0x000006C8
			// (set) Token: 0x060000B2 RID: 178 RVA: 0x00002545 File Offset: 0x00000745
			public Form4 Form4
			{
				[DebuggerHidden]
				get
				{
					this.m_Form4 = MyProject.MyForms.Create__Instance__<Form4>(this.m_Form4);
					return this.m_Form4;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Form4)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Form4>(ref this.m_Form4);
					}
				}
			}

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x060000AE RID: 174 RVA: 0x000024E1 File Offset: 0x000006E1
			// (set) Token: 0x060000B3 RID: 179 RVA: 0x0000256F File Offset: 0x0000076F
			public GForm0 GForm0_0
			{
				[DebuggerHidden]
				get
				{
					this.gform0_0 = MyProject.MyForms.Create__Instance__<GForm0>(this.gform0_0);
					return this.gform0_0;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.gform0_0)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<GForm0>(ref this.gform0_0);
					}
				}
			}

			// Token: 0x17000041 RID: 65
			// (get) Token: 0x060000AF RID: 175 RVA: 0x000024FA File Offset: 0x000006FA
			// (set) Token: 0x060000B4 RID: 180 RVA: 0x00002599 File Offset: 0x00000799
			public rbx rbx
			{
				[DebuggerHidden]
				get
				{
					this.m_rbx = MyProject.MyForms.Create__Instance__<rbx>(this.m_rbx);
					return this.m_rbx;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_rbx)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<rbx>(ref this.m_rbx);
					}
				}
			}

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x060000B0 RID: 176 RVA: 0x00002513 File Offset: 0x00000713
			// (set) Token: 0x060000B5 RID: 181 RVA: 0x000025C3 File Offset: 0x000007C3
			public robloxm robloxm
			{
				[DebuggerHidden]
				get
				{
					this.m_robloxm = MyProject.MyForms.Create__Instance__<robloxm>(this.m_robloxm);
					return this.m_robloxm;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_robloxm)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<robloxm>(ref this.m_robloxm);
					}
				}
			}

			// Token: 0x17000043 RID: 67
			// (get) Token: 0x060000B1 RID: 177 RVA: 0x0000252C File Offset: 0x0000072C
			// (set) Token: 0x060000B6 RID: 182 RVA: 0x000025ED File Offset: 0x000007ED
			public u u
			{
				[DebuggerHidden]
				get
				{
					this.m_u = MyProject.MyForms.Create__Instance__<u>(this.m_u);
					return this.m_u;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_u)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<u>(ref this.m_u);
					}
				}
			}

			// Token: 0x04000041 RID: 65
			[ThreadStatic]
			private static Hashtable m_FormBeingCreated;

			// Token: 0x04000042 RID: 66
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Form4 m_Form4;

			// Token: 0x04000043 RID: 67
			[EditorBrowsable(EditorBrowsableState.Never)]
			public GForm0 gform0_0;

			// Token: 0x04000044 RID: 68
			[EditorBrowsable(EditorBrowsableState.Never)]
			public rbx m_rbx;

			// Token: 0x04000045 RID: 69
			[EditorBrowsable(EditorBrowsableState.Never)]
			public robloxm m_robloxm;

			// Token: 0x04000046 RID: 70
			[EditorBrowsable(EditorBrowsableState.Never)]
			public u m_u;
		}

		// Token: 0x0200000E RID: 14
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		internal sealed class MyWebServices
		{
			// Token: 0x060000B7 RID: 183 RVA: 0x000067E8 File Offset: 0x000049E8
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x060000B8 RID: 184 RVA: 0x00006804 File Offset: 0x00004A04
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x060000B9 RID: 185 RVA: 0x00006850 File Offset: 0x00004A50
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			internal new Type GetType()
			{
				return typeof(MyProject.MyWebServices);
			}

			// Token: 0x060000BA RID: 186 RVA: 0x00006838 File Offset: 0x00004A38
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x060000BB RID: 187 RVA: 0x0000686C File Offset: 0x00004A6C
			[DebuggerHidden]
			private static T Create__Instance__<T>(T instance) where T : new()
			{
				T result;
				if (instance == null)
				{
					result = Activator.CreateInstance<T>();
				}
				else
				{
					result = instance;
				}
				return result;
			}

			// Token: 0x060000BC RID: 188 RVA: 0x00002617 File Offset: 0x00000817
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance)
			{
				instance = default(T);
			}

			// Token: 0x060000BD RID: 189 RVA: 0x000024C0 File Offset: 0x000006C0
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyWebServices()
			{
			}
		}

		// Token: 0x0200000F RID: 15
		[EditorBrowsable(EditorBrowsableState.Never)]
		[ComVisible(false)]
		internal sealed class ThreadSafeObjectProvider<T> where T : new()
		{
			// Token: 0x17000044 RID: 68
			// (get) Token: 0x060000BE RID: 190 RVA: 0x00006890 File Offset: 0x00004A90
			internal T GetInstance
			{
				[DebuggerHidden]
				get
				{
					if (MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
					{
						MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = Activator.CreateInstance<T>();
					}
					return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
				}
			}

			// Token: 0x060000BF RID: 191 RVA: 0x000024C0 File Offset: 0x000006C0
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ThreadSafeObjectProvider()
			{
			}

			// Token: 0x04000047 RID: 71
			[CompilerGenerated]
			[ThreadStatic]
			private static T m_ThreadStaticValue;
		}
	}
}
