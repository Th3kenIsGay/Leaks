using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Steam_Game_Spammer_0._1.My
{
	// Token: 0x0200000C RID: 12
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
	[CompilerGenerated]
	internal sealed partial class MySettings : ApplicationSettingsBase
	{
		// Token: 0x06000079 RID: 121 RVA: 0x000041C4 File Offset: 0x000023C4
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		private static void AutoSaveSettings(object sender, EventArgs e)
		{
			if (MyProject.Application.SaveMySettingsOnExit)
			{
				MySettingsProperty.Settings.Save();
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600007A RID: 122 RVA: 0x000041E8 File Offset: 0x000023E8
		public static MySettings Default
		{
			get
			{
				if (!MySettings.addedHandler)
				{
					object obj = MySettings.addedHandlerLockObject;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					lock (obj)
					{
						if (!MySettings.addedHandler)
						{
							MyProject.Application.Shutdown += MySettings.AutoSaveSettings;
							MySettings.addedHandler = true;
						}
					}
				}
				return MySettings.defaultInstance;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00004260 File Offset: 0x00002460
		// (set) Token: 0x0600007C RID: 124 RVA: 0x0000226B File Offset: 0x0000046B
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("")]
		public string SettingV1
		{
			get
			{
				return Conversions.ToString(this["SettingV1"]);
			}
			set
			{
				this["SettingV1"] = value;
			}
		}

		// Token: 0x04000021 RID: 33
		private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

		// Token: 0x04000022 RID: 34
		private static bool addedHandler;

		// Token: 0x04000023 RID: 35
		private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());
	}
}
