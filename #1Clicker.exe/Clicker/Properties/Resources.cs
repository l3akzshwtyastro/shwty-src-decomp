using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Clicker.Properties
{
	// Token: 0x02000007 RID: 7
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x0600005A RID: 90 RVA: 0x00008C68 File Offset: 0x00006E68
		internal Resources()
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00008C74 File Offset: 0x00006E74
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("Clicker.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00008CBC File Offset: 0x00006EBC
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00008CD3 File Offset: 0x00006ED3
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

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00008CDC File Offset: 0x00006EDC
		internal static Bitmap Cat
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Cat", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00008D0C File Offset: 0x00006F0C
		internal static Bitmap icons8_discord_new_32
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("icons8-discord-new-32", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00008D3C File Offset: 0x00006F3C
		internal static Bitmap icons8_twitter_22
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("icons8-twitter-22", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00008D6C File Offset: 0x00006F6C
		internal static Bitmap icons8_youtube_22
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("icons8-youtube-22", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x04000060 RID: 96
		private static ResourceManager resourceMan;

		// Token: 0x04000061 RID: 97
		private static CultureInfo resourceCulture;
	}
}
