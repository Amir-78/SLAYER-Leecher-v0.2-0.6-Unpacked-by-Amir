using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000017 RID: 23
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[CompilerGenerated]
[DebuggerNonUserCode]
[HideModuleName]
[StandardModule]
internal sealed class Class11
{
	// Token: 0x17000093 RID: 147
	// (get) Token: 0x060001D6 RID: 470 RVA: 0x000131B4 File Offset: 0x000113B4
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (object.ReferenceEquals(Class11.resourceManager_0, null))
			{
				ResourceManager resourceManager = new ResourceManager("SLAYER_Combo_Searcher_v_0._4.Resources", typeof(Class11).Assembly);
				Class11.resourceManager_0 = resourceManager;
			}
			return Class11.resourceManager_0;
		}
	}

	// Token: 0x17000094 RID: 148
	// (get) Token: 0x060001D7 RID: 471 RVA: 0x000131F8 File Offset: 0x000113F8
	// (set) Token: 0x060001D8 RID: 472 RVA: 0x0001320C File Offset: 0x0001140C
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		get
		{
			return Class11.cultureInfo_0;
		}
		set
		{
			Class11.cultureInfo_0 = value;
		}
	}

	// Token: 0x17000095 RID: 149
	// (get) Token: 0x060001D9 RID: 473 RVA: 0x00013220 File Offset: 0x00011420
	internal static Icon Icon_0
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Class11.ResourceManager_0.GetObject("_1492186413_12", Class11.cultureInfo_0));
			return (Icon)objectValue;
		}
	}

	// Token: 0x17000096 RID: 150
	// (get) Token: 0x060001DA RID: 474 RVA: 0x00013250 File Offset: 0x00011450
	internal static UnmanagedMemoryStream UnmanagedMemoryStream_0
	{
		get
		{
			return Class11.ResourceManager_0.GetStream("credit", Class11.cultureInfo_0);
		}
	}

	// Token: 0x17000097 RID: 151
	// (get) Token: 0x060001DB RID: 475 RVA: 0x00013274 File Offset: 0x00011474
	internal static Bitmap Bitmap_0
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Class11.ResourceManager_0.GetObject("loading_gif", Class11.cultureInfo_0));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x17000098 RID: 152
	// (get) Token: 0x060001DC RID: 476 RVA: 0x000132A4 File Offset: 0x000114A4
	internal static Bitmap Bitmap_1
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Class11.ResourceManager_0.GetObject("NewVersion", Class11.cultureInfo_0));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x17000099 RID: 153
	// (get) Token: 0x060001DD RID: 477 RVA: 0x000132D4 File Offset: 0x000114D4
	internal static Icon Icon_1
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Class11.ResourceManager_0.GetObject("S1", Class11.cultureInfo_0));
			return (Icon)objectValue;
		}
	}

	// Token: 0x1700009A RID: 154
	// (get) Token: 0x060001DE RID: 478 RVA: 0x00013304 File Offset: 0x00011504
	internal static Bitmap Bitmap_2
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Class11.ResourceManager_0.GetObject("s2", Class11.cultureInfo_0));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x1700009B RID: 155
	// (get) Token: 0x060001DF RID: 479 RVA: 0x00013334 File Offset: 0x00011534
	internal static Bitmap Bitmap_3
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Class11.ResourceManager_0.GetObject("s3", Class11.cultureInfo_0));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x1700009C RID: 156
	// (get) Token: 0x060001E0 RID: 480 RVA: 0x00013364 File Offset: 0x00011564
	internal static Bitmap Bitmap_4
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Class11.ResourceManager_0.GetObject("shopping_cart_accept_icon", Class11.cultureInfo_0));
			return (Bitmap)objectValue;
		}
	}

	// Token: 0x040000EA RID: 234
	private static ResourceManager resourceManager_0;

	// Token: 0x040000EB RID: 235
	private static CultureInfo cultureInfo_0;
}
