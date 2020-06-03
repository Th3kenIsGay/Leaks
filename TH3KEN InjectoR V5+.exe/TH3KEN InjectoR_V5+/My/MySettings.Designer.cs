using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Hosts_Pro_V6.My
{
	// Token: 0x02000007 RID: 7
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.7.0.0")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal sealed partial class MySettings : ApplicationSettingsBase
	{
		// Token: 0x0600001C RID: 28 RVA: 0x00002430 File Offset: 0x00000630
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		private static void AutoSaveSettings(object sender, EventArgs e)
		{
			bool saveMySettingsOnExit = MyProject.Application.SaveMySettingsOnExit;
			if (saveMySettingsOnExit)
			{
				MySettingsProperty.Settings.Save();
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600001D RID: 29 RVA: 0x0000245C File Offset: 0x0000065C
		public static MySettings Default
		{
			get
			{
				bool flag = !MySettings.addedHandler;
				if (flag)
				{
					object obj = MySettings.addedHandlerLockObject;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					lock (obj)
					{
						bool flag3 = !MySettings.addedHandler;
						if (flag3)
						{
							MyProject.Application.Shutdown += MySettings.AutoSaveSettings;
							MySettings.addedHandler = true;
						}
					}
				}
				return MySettings.defaultInstance;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000024E8 File Offset: 0x000006E8
		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string VV5
		{
			get
			{
				return Conversions.ToString(this["VV5"]);
			}
		}

		// Token: 0x04000008 RID: 8
		private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

		// Token: 0x04000009 RID: 9
		private static bool addedHandler;

		// Token: 0x0400000A RID: 10
		private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());
	}
}
