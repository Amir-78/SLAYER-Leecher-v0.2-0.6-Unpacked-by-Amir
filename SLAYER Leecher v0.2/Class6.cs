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

// Token: 0x0200000E RID: 14
[StandardModule]
[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
internal sealed class Class6
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000046 RID: 70 RVA: 0x00005CD0 File Offset: 0x00003ED0
	[HelpKeyword("My.Computer")]
	internal static Class5 Class5_0
	{
		[DebuggerHidden]
		get
		{
			return Class6.class9_0.Prop_0;
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000047 RID: 71 RVA: 0x00005CEC File Offset: 0x00003EEC
	[HelpKeyword("My.Application")]
	internal static Form0 Form0_0
	{
		[DebuggerHidden]
		get
		{
			return Class6.class9_1.Prop_0;
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000048 RID: 72 RVA: 0x00005D08 File Offset: 0x00003F08
	[HelpKeyword("My.User")]
	internal static User User_0
	{
		[DebuggerHidden]
		get
		{
			return Class6.class9_2.Prop_0;
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000049 RID: 73 RVA: 0x00005D24 File Offset: 0x00003F24
	[HelpKeyword("My.Forms")]
	internal static Class6.Class7 Class7_0
	{
		[DebuggerHidden]
		get
		{
			return Class6.class9_3.Prop_0;
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x0600004A RID: 74 RVA: 0x00005D40 File Offset: 0x00003F40
	[HelpKeyword("My.WebServices")]
	internal static Class6.Class8 Class8_0
	{
		[DebuggerHidden]
		get
		{
			return Class6.class9_4.Prop_0;
		}
	}

	// Token: 0x0400002D RID: 45
	private static readonly Class6.Class9<Class5> class9_0 = new Class6.Class9<Class5>();

	// Token: 0x0400002E RID: 46
	private static readonly Class6.Class9<Form0> class9_1 = new Class6.Class9<Form0>();

	// Token: 0x0400002F RID: 47
	private static readonly Class6.Class9<User> class9_2 = new Class6.Class9<User>();

	// Token: 0x04000030 RID: 48
	private static Class6.Class9<Class6.Class7> class9_3 = new Class6.Class9<Class6.Class7>();

	// Token: 0x04000031 RID: 49
	private static readonly Class6.Class9<Class6.Class8> class9_4 = new Class6.Class9<Class6.Class8>();

	// Token: 0x0200000F RID: 15
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Class7
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00005D5C File Offset: 0x00003F5C
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00005DD4 File Offset: 0x00003FD4
		public Custom Custom_0
		{
			[DebuggerNonUserCode]
			get
			{
				this.custom_0 = Class6.Class7.smethod_0<Custom>(this.custom_0);
				return this.custom_0;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != this.custom_0)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.method_0<Custom>(ref this.custom_0);
				}
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00005D84 File Offset: 0x00003F84
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00005E10 File Offset: 0x00004010
		public Form1 Form1_0
		{
			[DebuggerNonUserCode]
			get
			{
				this.form1_0 = Class6.Class7.smethod_0<Form1>(this.form1_0);
				return this.form1_0;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != this.form1_0)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.method_0<Form1>(ref this.form1_0);
				}
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00005DAC File Offset: 0x00003FAC
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00005E4C File Offset: 0x0000404C
		public Search_Engine Search_Engine_0
		{
			[DebuggerNonUserCode]
			get
			{
				this.search_Engine_0 = Class6.Class7.smethod_0<Search_Engine>(this.search_Engine_0);
				return this.search_Engine_0;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != this.search_Engine_0)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.method_0<Search_Engine>(ref this.search_Engine_0);
				}
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00005E88 File Offset: 0x00004088
		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : Form, new()
		{
			T result;
			if (gparam_0 != null && !gparam_0.IsDisposed)
			{
				result = gparam_0;
			}
			else
			{
				if (Class6.Class7.hashtable_0 != null)
				{
					if (Class6.Class7.hashtable_0.ContainsKey(typeof(T)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					Class6.Class7.hashtable_0 = new Hashtable();
				}
				Class6.Class7.hashtable_0.Add(typeof(T), null);
				try
				{
					result = Activator.CreateInstance<T>();
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
					Class6.Class7.hashtable_0.Remove(typeof(T));
				}
			}
			return result;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00005F98 File Offset: 0x00004198
		[DebuggerHidden]
		private void method_0<T>(ref T gparam_0) where T : Form
		{
			gparam_0.Dispose();
			gparam_0 = default(T);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00004D90 File Offset: 0x00002F90
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class7()
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00005FC0 File Offset: 0x000041C0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool Equals(object obj)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(obj));
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00005FDC File Offset: 0x000041DC
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00005FF4 File Offset: 0x000041F4
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_1()
		{
			return typeof(Class6.Class7);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00006010 File Offset: 0x00004210
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string ToString()
		{
			return base.ToString();
		}

		// Token: 0x04000032 RID: 50
		public Custom custom_0;

		// Token: 0x04000033 RID: 51
		public Form1 form1_0;

		// Token: 0x04000034 RID: 52
		public Search_Engine search_Engine_0;

		// Token: 0x04000035 RID: 53
		[ThreadStatic]
		private static Hashtable hashtable_0;
	}

	// Token: 0x02000010 RID: 16
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class8
	{
		// Token: 0x06000058 RID: 88 RVA: 0x00005FC0 File Offset: 0x000041C0
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public bool Equals(object obj)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(obj));
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00005FDC File Offset: 0x000041DC
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00006028 File Offset: 0x00004228
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_0()
		{
			return typeof(Class6.Class8);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00006010 File Offset: 0x00004210
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public string ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00006044 File Offset: 0x00004244
		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : new()
		{
			T result;
			if (gparam_0 != null)
			{
				result = gparam_0;
			}
			else
			{
				result = Activator.CreateInstance<T>();
			}
			return result;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00006068 File Offset: 0x00004268
		[DebuggerHidden]
		private void method_1<T>(ref T gparam_0)
		{
			gparam_0 = default(T);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00004D90 File Offset: 0x00002F90
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class8()
		{
		}
	}

	// Token: 0x02000011 RID: 17
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Class9<T> where T : new()
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00006084 File Offset: 0x00004284
		internal T Prop_0
		{
			[DebuggerHidden]
			get
			{
				if (Class6.Class9<T>.gparam_0 == null)
				{
					Class6.Class9<T>.gparam_0 = Activator.CreateInstance<T>();
				}
				return Class6.Class9<T>.gparam_0;
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00004D90 File Offset: 0x00002F90
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class9()
		{
		}

		// Token: 0x04000036 RID: 54
		[CompilerGenerated]
		[ThreadStatic]
		private static T gparam_0;
	}
}
