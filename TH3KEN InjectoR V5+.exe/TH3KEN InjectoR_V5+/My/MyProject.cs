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

namespace Hosts_Pro_V6.My
{
	// Token: 0x02000004 RID: 4
	[StandardModule]
	[HideModuleName]
	[GeneratedCode("MyTemplate", "11.0.0.0")]
	internal sealed class MyProject
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002120 File Offset: 0x00000320
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
		// (get) Token: 0x06000008 RID: 8 RVA: 0x0000213C File Offset: 0x0000033C
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
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002158 File Offset: 0x00000358
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
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002174 File Offset: 0x00000374
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
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002190 File Offset: 0x00000390
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

		// Token: 0x0200001E RID: 30
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
		internal sealed class MyForms
		{
			// Token: 0x0600022C RID: 556 RVA: 0x0000F5EC File Offset: 0x0000D7EC
			[DebuggerHidden]
			private static T Create__Instance__<T>(T Instance) where T : Form, new()
			{
				bool flag = Instance == null || Instance.IsDisposed;
				if (flag)
				{
					bool flag2 = MyProject.MyForms.m_FormBeingCreated != null;
					if (flag2)
					{
						bool flag3 = MyProject.MyForms.m_FormBeingCreated.ContainsKey(typeof(T));
						if (flag3)
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

			// Token: 0x0600022D RID: 557 RVA: 0x0000F714 File Offset: 0x0000D914
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance) where T : Form
			{
				instance.Dispose();
				instance = default(T);
			}

			// Token: 0x0600022E RID: 558 RVA: 0x0000F72B File Offset: 0x0000D92B
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyForms()
			{
			}

			// Token: 0x0600022F RID: 559 RVA: 0x0000F738 File Offset: 0x0000D938
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x06000230 RID: 560 RVA: 0x0000F758 File Offset: 0x0000D958
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x06000231 RID: 561 RVA: 0x0000F770 File Offset: 0x0000D970
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyProject.MyForms);
			}

			// Token: 0x06000232 RID: 562 RVA: 0x0000F78C File Offset: 0x0000D98C
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x17000098 RID: 152
			// (get) Token: 0x06000233 RID: 563 RVA: 0x0000F7A4 File Offset: 0x0000D9A4
			// (set) Token: 0x0600023A RID: 570 RVA: 0x0000F861 File Offset: 0x0000DA61
			public B1 B1
			{
				[DebuggerHidden]
				get
				{
					this.m_B1 = MyProject.MyForms.Create__Instance__<B1>(this.m_B1);
					return this.m_B1;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_B1)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<B1>(ref this.m_B1);
					}
				}
			}

			// Token: 0x17000099 RID: 153
			// (get) Token: 0x06000234 RID: 564 RVA: 0x0000F7BF File Offset: 0x0000D9BF
			// (set) Token: 0x0600023B RID: 571 RVA: 0x0000F88D File Offset: 0x0000DA8D
			public Form1 Form1
			{
				[DebuggerHidden]
				get
				{
					this.m_Form1 = MyProject.MyForms.Create__Instance__<Form1>(this.m_Form1);
					return this.m_Form1;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Form1)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Form1>(ref this.m_Form1);
					}
				}
			}

			// Token: 0x1700009A RID: 154
			// (get) Token: 0x06000235 RID: 565 RVA: 0x0000F7DA File Offset: 0x0000D9DA
			// (set) Token: 0x0600023C RID: 572 RVA: 0x0000F8B9 File Offset: 0x0000DAB9
			public Form2 Form2
			{
				[DebuggerHidden]
				get
				{
					this.m_Form2 = MyProject.MyForms.Create__Instance__<Form2>(this.m_Form2);
					return this.m_Form2;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Form2)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Form2>(ref this.m_Form2);
					}
				}
			}

			// Token: 0x1700009B RID: 155
			// (get) Token: 0x06000236 RID: 566 RVA: 0x0000F7F5 File Offset: 0x0000D9F5
			// (set) Token: 0x0600023D RID: 573 RVA: 0x0000F8E5 File Offset: 0x0000DAE5
			public V1 V1
			{
				[DebuggerHidden]
				get
				{
					this.m_V1 = MyProject.MyForms.Create__Instance__<V1>(this.m_V1);
					return this.m_V1;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_V1)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<V1>(ref this.m_V1);
					}
				}
			}

			// Token: 0x1700009C RID: 156
			// (get) Token: 0x06000237 RID: 567 RVA: 0x0000F810 File Offset: 0x0000DA10
			// (set) Token: 0x0600023E RID: 574 RVA: 0x0000F911 File Offset: 0x0000DB11
			public V3 V3
			{
				[DebuggerHidden]
				get
				{
					this.m_V3 = MyProject.MyForms.Create__Instance__<V3>(this.m_V3);
					return this.m_V3;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_V3)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<V3>(ref this.m_V3);
					}
				}
			}

			// Token: 0x1700009D RID: 157
			// (get) Token: 0x06000238 RID: 568 RVA: 0x0000F82B File Offset: 0x0000DA2B
			// (set) Token: 0x0600023F RID: 575 RVA: 0x0000F93D File Offset: 0x0000DB3D
			public V4 V4
			{
				[DebuggerHidden]
				get
				{
					this.m_V4 = MyProject.MyForms.Create__Instance__<V4>(this.m_V4);
					return this.m_V4;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_V4)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<V4>(ref this.m_V4);
					}
				}
			}

			// Token: 0x1700009E RID: 158
			// (get) Token: 0x06000239 RID: 569 RVA: 0x0000F846 File Offset: 0x0000DA46
			// (set) Token: 0x06000240 RID: 576 RVA: 0x0000F969 File Offset: 0x0000DB69
			public V5 V5
			{
				[DebuggerHidden]
				get
				{
					this.m_V5 = MyProject.MyForms.Create__Instance__<V5>(this.m_V5);
					return this.m_V5;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_V5)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<V5>(ref this.m_V5);
					}
				}
			}

			// Token: 0x040000B9 RID: 185
			[ThreadStatic]
			private static Hashtable m_FormBeingCreated;

			// Token: 0x040000BA RID: 186
			[EditorBrowsable(EditorBrowsableState.Never)]
			public B1 m_B1;

			// Token: 0x040000BB RID: 187
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Form1 m_Form1;

			// Token: 0x040000BC RID: 188
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Form2 m_Form2;

			// Token: 0x040000BD RID: 189
			[EditorBrowsable(EditorBrowsableState.Never)]
			public V1 m_V1;

			// Token: 0x040000BE RID: 190
			[EditorBrowsable(EditorBrowsableState.Never)]
			public V3 m_V3;

			// Token: 0x040000BF RID: 191
			[EditorBrowsable(EditorBrowsableState.Never)]
			public V4 m_V4;

			// Token: 0x040000C0 RID: 192
			[EditorBrowsable(EditorBrowsableState.Never)]
			public V5 m_V5;
		}

		// Token: 0x0200001F RID: 31
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		internal sealed class MyWebServices
		{
			// Token: 0x06000241 RID: 577 RVA: 0x0000F998 File Offset: 0x0000DB98
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x06000242 RID: 578 RVA: 0x0000F9B8 File Offset: 0x0000DBB8
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x06000243 RID: 579 RVA: 0x0000F9D0 File Offset: 0x0000DBD0
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			internal new Type GetType()
			{
				return typeof(MyProject.MyWebServices);
			}

			// Token: 0x06000244 RID: 580 RVA: 0x0000F9EC File Offset: 0x0000DBEC
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x06000245 RID: 581 RVA: 0x0000FA04 File Offset: 0x0000DC04
			[DebuggerHidden]
			private static T Create__Instance__<T>(T instance) where T : new()
			{
				bool flag = instance == null;
				T result;
				if (flag)
				{
					result = Activator.CreateInstance<T>();
				}
				else
				{
					result = instance;
				}
				return result;
			}

			// Token: 0x06000246 RID: 582 RVA: 0x0000FA2D File Offset: 0x0000DC2D
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance)
			{
				instance = default(T);
			}

			// Token: 0x06000247 RID: 583 RVA: 0x0000F72B File Offset: 0x0000D92B
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyWebServices()
			{
			}
		}

		// Token: 0x02000020 RID: 32
		[EditorBrowsable(EditorBrowsableState.Never)]
		[ComVisible(false)]
		internal sealed class ThreadSafeObjectProvider<T> where T : new()
		{
			// Token: 0x1700009F RID: 159
			// (get) Token: 0x06000248 RID: 584 RVA: 0x0000FA38 File Offset: 0x0000DC38
			internal T GetInstance
			{
				[DebuggerHidden]
				get
				{
					bool flag = MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null;
					if (flag)
					{
						MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = Activator.CreateInstance<T>();
					}
					return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
				}
			}

			// Token: 0x06000249 RID: 585 RVA: 0x0000F72B File Offset: 0x0000D92B
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ThreadSafeObjectProvider()
			{
			}

			// Token: 0x040000C1 RID: 193
			[CompilerGenerated]
			[ThreadStatic]
			private static T m_ThreadStaticValue;
		}
	}
}
