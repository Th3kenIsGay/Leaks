using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Steam_Game_Spammer_0._1.My.Resources
{
	// Token: 0x0200000B RID: 11
	[CompilerGenerated]
	[StandardModule]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[HideModuleName]
	[DebuggerNonUserCode]
	internal sealed class Resources
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00003F8C File Offset: 0x0000218C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Resources.resourceMan, null))
				{
					ResourceManager resourceManager = new ResourceManager("Steam_Game_Spammer_0._1.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00003FD0 File Offset: 0x000021D0
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00002236 File Offset: 0x00000436
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00003FE4 File Offset: 0x000021E4
		internal static Bitmap Advanced
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("Advanced", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00004014 File Offset: 0x00002214
		internal static Bitmap maxresdefault
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("maxresdefault", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00004044 File Offset: 0x00002244
		internal static Bitmap Open_Steam
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("Open_Steam", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00004074 File Offset: 0x00002274
		internal static Bitmap Open_Steam__2_
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("Open_Steam__2_", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000071 RID: 113 RVA: 0x000040A4 File Offset: 0x000022A4
		internal static Bitmap Steam_button_sample
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("Steam_button_sample", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000040D4 File Offset: 0x000022D4
		internal static Bitmap Steam_button_sample2
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("Steam_button_sample2", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00004104 File Offset: 0x00002304
		internal static byte[] SteamGameAdvanced
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("SteamGameAdvanced", Resources.resourceCulture));
				return (byte[])objectValue;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00004134 File Offset: 0x00002334
		internal static byte[] SteamSpammerEjection
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("SteamSpammerEjection", Resources.resourceCulture));
				return (byte[])objectValue;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00004164 File Offset: 0x00002364
		internal static byte[] Tutorial
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("Tutorial", Resources.resourceCulture));
				return (byte[])objectValue;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00004194 File Offset: 0x00002394
		internal static byte[] Tutorialgame
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("Tutorialgame", Resources.resourceCulture));
				return (byte[])objectValue;
			}
		}

		// Token: 0x0400001F RID: 31
		private static ResourceManager resourceMan;

		// Token: 0x04000020 RID: 32
		private static CultureInfo resourceCulture;
	}
}
