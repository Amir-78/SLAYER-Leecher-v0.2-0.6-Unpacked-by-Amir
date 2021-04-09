using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace SLAYER_Combo_Searcher_v_0._4.My
{
	// Token: 0x02000018 RID: 24
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
	[CompilerGenerated]
	internal sealed partial class MySettings : ApplicationSettingsBase
	{
		// Token: 0x060001E3 RID: 483 RVA: 0x000133D8 File Offset: 0x000115D8
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[DebuggerNonUserCode]
		private static void smethod_0(object sender, EventArgs e)
		{
			if (Class6.Form0_0.SaveMySettingsOnExit)
			{
				Class12.MySettings_0.Save();
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x000133FC File Offset: 0x000115FC
		public static MySettings Default
		{
			get
			{
				if (!MySettings.bool_0)
				{
					object obj = MySettings.object_0;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					lock (obj)
					{
						if (!MySettings.bool_0)
						{
							Class6.Form0_0.Shutdown += MySettings.smethod_0;
							MySettings.bool_0 = true;
						}
					}
				}
				return MySettings.mySettings_0;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x00013474 File Offset: 0x00011674
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x00013494 File Offset: 0x00011694
		[DefaultSettingValue("@yandex.ru pastebin.com\r\n@yandex.ru:12345\r\n@gmail.com:qwerty\r\n@gmail.ru:password\r\n@hotmail.com pastebin.com\r\nemail:password\r\nusername:password\r\n@yandex.ru \r\n@yahoo.co.uk \r\n@yahoo.fr \r\n@freenet.de \r\n@gmail.com \r\n@yahoo.com \r\n@outlook.fr \r\n@hotmail.com \r\n@wanaado.f")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string Config
		{
			get
			{
				return Conversions.ToString(this["Config"]);
			}
			set
			{
				this["Config"] = value;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x000134B0 File Offset: 0x000116B0
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x000134D0 File Offset: 0x000116D0
		[DefaultSettingValue("True")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public bool GOOGLE
		{
			get
			{
				return Conversions.ToBoolean(this["GOOGLE"]);
			}
			set
			{
				this["GOOGLE"] = value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x000134F0 File Offset: 0x000116F0
		// (set) Token: 0x060001EA RID: 490 RVA: 0x00013510 File Offset: 0x00011710
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("True")]
		public bool YANDEX
		{
			get
			{
				return Conversions.ToBoolean(this["YANDEX"]);
			}
			set
			{
				this["YANDEX"] = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001EB RID: 491 RVA: 0x00013530 File Offset: 0x00011730
		// (set) Token: 0x060001EC RID: 492 RVA: 0x00013550 File Offset: 0x00011750
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool Pastebin
		{
			get
			{
				return Conversions.ToBoolean(this["Pastebin"]);
			}
			set
			{
				this["Pastebin"] = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001ED RID: 493 RVA: 0x00013570 File Offset: 0x00011770
		// (set) Token: 0x060001EE RID: 494 RVA: 0x00013590 File Offset: 0x00011790
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool Bing
		{
			get
			{
				return Conversions.ToBoolean(this["Bing"]);
			}
			set
			{
				this["Bing"] = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001EF RID: 495 RVA: 0x000135B0 File Offset: 0x000117B0
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x000135D0 File Offset: 0x000117D0
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		public bool Proxy
		{
			get
			{
				return Conversions.ToBoolean(this["Proxy"]);
			}
			set
			{
				this["Proxy"] = value;
			}
		}

		// Token: 0x040000EC RID: 236
		private static MySettings mySettings_0 = (MySettings)SettingsBase.Synchronized(new MySettings());

		// Token: 0x040000ED RID: 237
		private static bool bool_0;

		// Token: 0x040000EE RID: 238
		private static object object_0 = RuntimeHelpers.GetObjectValue(new object());
	}
}
