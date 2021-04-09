using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

// Token: 0x0200000C RID: 12
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal class Form0 : WindowsFormsApplicationBase
{
	// Token: 0x06000040 RID: 64 RVA: 0x00005AFC File Offset: 0x00003CFC
	[DebuggerNonUserCode]
	private static void smethod_0(object object_0)
	{
		List<WeakReference> obj = Form0.list_0;
		checked
		{
			lock (obj)
			{
				if (Form0.list_0.Count == Form0.list_0.Capacity)
				{
					int num = 0;
					int num2 = 0;
					int num3 = Form0.list_0.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = Form0.list_0[num4];
						if (weakReference.IsAlive)
						{
							if (num4 != num)
							{
								Form0.list_0[num] = Form0.list_0[num4];
							}
							num++;
						}
						num4++;
					}
					Form0.list_0.RemoveRange(num, Form0.list_0.Count - num);
					Form0.list_0.Capacity = Form0.list_0.Count;
				}
				Form0.list_0.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_0)));
			}
		}
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00005BEC File Offset: 0x00003DEC
	[DebuggerHidden]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[STAThread]
	[MethodImpl(MethodImplOptions.NoOptimization)]
	internal static void Main(string[] args)
	{
		try
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
		}
		finally
		{
		}
		Class6.Form0_0.Run(args);
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00005C24 File Offset: 0x00003E24
	[DebuggerStepThrough]
	public Form0() : base(AuthenticationMode.Windows)
	{
		Form0.smethod_0(this);
		this.IsSingleInstance = false;
		this.EnableVisualStyles = true;
		this.SaveMySettingsOnExit = true;
		this.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00005C5C File Offset: 0x00003E5C
	[DebuggerStepThrough]
	protected virtual void OnCreateMainForm()
	{
		this.MainForm = Class6.Class7_0.Form1_0;
	}

	// Token: 0x0400002C RID: 44
	private static List<WeakReference> list_0 = new List<WeakReference>();
}
