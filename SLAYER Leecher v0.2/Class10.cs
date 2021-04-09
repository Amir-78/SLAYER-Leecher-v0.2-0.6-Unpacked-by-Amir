using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000013 RID: 19
[StandardModule]
internal sealed class Class10
{
	// Token: 0x0600007B RID: 123
	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SendMessage(IntPtr intptr_0, int int_1, int int_2, [MarshalAs(UnmanagedType.LPWStr)] string string_0);

	// Token: 0x0600007C RID: 124 RVA: 0x00006BF8 File Offset: 0x00004DF8
	public static void smethod_0(ref List<TextBox> list_0, List<string> list_1)
	{
		int num = 0;
		checked
		{
			int num2 = list_0.Count - 1;
			int num3 = num;
			for (;;)
			{
				int num4 = num3;
				int num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				Class10.SendMessage(list_0[num3].Handle, 5377, 1, list_1[num3]);
				num3++;
			}
		}
	}

	// Token: 0x04000040 RID: 64
	private const int int_0 = 5377;
}
