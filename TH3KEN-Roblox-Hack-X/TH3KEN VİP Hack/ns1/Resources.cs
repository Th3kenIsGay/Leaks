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

namespace ns1
{
	// Token: 0x02000005 RID: 5
	[StandardModule]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	[HideModuleName]
	internal sealed class Resources
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000026E4 File Offset: 0x000008E4
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Resources.resourceMan, null))
				{
					ResourceManager resourceManager = new ResourceManager("Roblox_Giriş_X.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002728 File Offset: 0x00000928
		// (set) Token: 0x0600000D RID: 13 RVA: 0x000020C3 File Offset: 0x000002C3
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

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000E RID: 14 RVA: 0x0000273C File Offset: 0x0000093C
		internal static Bitmap fondo_degradado
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("fondo-degradado", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600000F RID: 15 RVA: 0x0000276C File Offset: 0x0000096C
		internal static Bitmap lg_comet_spinner
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("lg.comet-spinner", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000010 RID: 16 RVA: 0x0000279C File Offset: 0x0000099C
		internal static Bitmap loading
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("loading", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000011 RID: 17 RVA: 0x000027CC File Offset: 0x000009CC
		internal static Bitmap PNG_IMG_BANNER
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("PNG_IMG_BANNER", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000027FC File Offset: 0x000009FC
		internal static Bitmap pxc
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("pxc", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000013 RID: 19 RVA: 0x0000282C File Offset: 0x00000A2C
		internal static Bitmap rgb1
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("rgb1", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000014 RID: 20 RVA: 0x0000285C File Offset: 0x00000A5C
		internal static Bitmap Roblox
		{
			get
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("Roblox", Resources.resourceCulture));
				return (Bitmap)objectValue;
			}
		}

		// Token: 0x04000006 RID: 6
		private static ResourceManager resourceMan;

		// Token: 0x04000007 RID: 7
		private static CultureInfo resourceCulture;
	}
}
