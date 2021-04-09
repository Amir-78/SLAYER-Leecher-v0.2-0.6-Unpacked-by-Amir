using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SkinSoft.VisualStyler;
using SkinSoft.VisualStyler.Licensing;
using xNet;

// Token: 0x02000014 RID: 20
[DesignerGenerated]
public partial class Form1 : Form
{
	// Token: 0x0600007E RID: 126 RVA: 0x00006C58 File Offset: 0x00004E58
	[DebuggerNonUserCode]
	private static void smethod_0(object object_2)
	{
		List<WeakReference> obj = Form1.list_0;
		checked
		{
			lock (obj)
			{
				if (Form1.list_0.Count == Form1.list_0.Capacity)
				{
					int num = 0;
					int num2 = 0;
					int num3 = Form1.list_0.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = Form1.list_0[num4];
						if (weakReference.IsAlive)
						{
							if (num4 != num)
							{
								Form1.list_0[num] = Form1.list_0[num4];
							}
							num++;
						}
						num4++;
					}
					Form1.list_0.RemoveRange(num, Form1.list_0.Count - num);
					Form1.list_0.Capacity = Form1.list_0.Count;
				}
				Form1.list_0.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_2)));
			}
		}
	}

	// Token: 0x0600007F RID: 127 RVA: 0x00006D48 File Offset: 0x00004F48
	[DebuggerNonUserCode]
	protected virtual void Dispose(bool disposing)
	{
		try
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x06000081 RID: 129 RVA: 0x0000B504 File Offset: 0x00009704
	// (set) Token: 0x06000082 RID: 130 RVA: 0x0000B51C File Offset: 0x0000971C
	internal virtual GControl0 CustomTabcontrol1
	{
		[DebuggerNonUserCode]
		get
		{
			return this._CustomTabcontrol1;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.method_64);
			if (this._CustomTabcontrol1 != null)
			{
				this._CustomTabcontrol1.SelectedIndexChanged -= value2;
			}
			this._CustomTabcontrol1 = value;
			if (this._CustomTabcontrol1 != null)
			{
				this._CustomTabcontrol1.SelectedIndexChanged += value2;
			}
		}
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x06000083 RID: 131 RVA: 0x0000B574 File Offset: 0x00009774
	// (set) Token: 0x06000084 RID: 132 RVA: 0x0000B58C File Offset: 0x0000978C
	internal virtual TabPage TabPage1
	{
		[DebuggerNonUserCode]
		get
		{
			return this._TabPage1;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._TabPage1 = value;
		}
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x06000085 RID: 133 RVA: 0x0000B5A0 File Offset: 0x000097A0
	// (set) Token: 0x06000086 RID: 134 RVA: 0x0000B5B8 File Offset: 0x000097B8
	internal virtual TabPage TabPage2
	{
		[DebuggerNonUserCode]
		get
		{
			return this._TabPage2;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._TabPage2 = value;
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x06000087 RID: 135 RVA: 0x0000B5CC File Offset: 0x000097CC
	// (set) Token: 0x06000088 RID: 136 RVA: 0x0000B5E4 File Offset: 0x000097E4
	internal virtual TabPage TabPage3
	{
		[DebuggerNonUserCode]
		get
		{
			return this._TabPage3;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._TabPage3 = value;
		}
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x06000089 RID: 137 RVA: 0x0000B5F8 File Offset: 0x000097F8
	// (set) Token: 0x0600008A RID: 138 RVA: 0x0000B610 File Offset: 0x00009810
	internal virtual ImageList ImageList_0
	{
		[DebuggerNonUserCode]
		get
		{
			return this.imageList_0;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this.imageList_0 = value;
		}
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x0600008B RID: 139 RVA: 0x0000B624 File Offset: 0x00009824
	// (set) Token: 0x0600008C RID: 140 RVA: 0x0000B63C File Offset: 0x0000983C
	internal virtual RichTextBox RichTextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return this._RichTextBox1;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._RichTextBox1 = value;
		}
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x0600008D RID: 141 RVA: 0x0000B650 File Offset: 0x00009850
	// (set) Token: 0x0600008E RID: 142 RVA: 0x0000B668 File Offset: 0x00009868
	internal virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Label3;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Label3 = value;
		}
	}

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x0600008F RID: 143 RVA: 0x0000B67C File Offset: 0x0000987C
	// (set) Token: 0x06000090 RID: 144 RVA: 0x0000B694 File Offset: 0x00009894
	internal virtual RichTextBox RichTextBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return this._RichTextBox2;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._RichTextBox2 = value;
		}
	}

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x06000091 RID: 145 RVA: 0x0000B6A8 File Offset: 0x000098A8
	// (set) Token: 0x06000092 RID: 146 RVA: 0x0000B6C0 File Offset: 0x000098C0
	internal virtual RichTextBox RichTextBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return this._RichTextBox3;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._RichTextBox3 = value;
		}
	}

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x06000093 RID: 147 RVA: 0x0000B6D4 File Offset: 0x000098D4
	// (set) Token: 0x06000094 RID: 148 RVA: 0x0000B6EC File Offset: 0x000098EC
	internal virtual RichTextBox RichTextBox4
	{
		[DebuggerNonUserCode]
		get
		{
			return this._RichTextBox4;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._RichTextBox4 = value;
		}
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x06000095 RID: 149 RVA: 0x0000B700 File Offset: 0x00009900
	// (set) Token: 0x06000096 RID: 150 RVA: 0x0000B718 File Offset: 0x00009918
	internal virtual TextBox TextBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return this._TextBox3;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.method_21);
			if (this._TextBox3 != null)
			{
				this._TextBox3.TextChanged -= value2;
			}
			this._TextBox3 = value;
			if (this._TextBox3 != null)
			{
				this._TextBox3.TextChanged += value2;
			}
		}
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x06000097 RID: 151 RVA: 0x0000B770 File Offset: 0x00009970
	// (set) Token: 0x06000098 RID: 152 RVA: 0x0000B788 File Offset: 0x00009988
	internal virtual TextBox TextBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return this._TextBox2;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.method_20);
			if (this._TextBox2 != null)
			{
				this._TextBox2.TextChanged -= value2;
			}
			this._TextBox2 = value;
			if (this._TextBox2 != null)
			{
				this._TextBox2.TextChanged += value2;
			}
		}
	}

	// Token: 0x1700001D RID: 29
	// (get) Token: 0x06000099 RID: 153 RVA: 0x0000B7E0 File Offset: 0x000099E0
	// (set) Token: 0x0600009A RID: 154 RVA: 0x0000B7F8 File Offset: 0x000099F8
	internal virtual RichTextBox RichTextBox6
	{
		[DebuggerNonUserCode]
		get
		{
			return this._RichTextBox6;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._RichTextBox6 = value;
		}
	}

	// Token: 0x1700001E RID: 30
	// (get) Token: 0x0600009B RID: 155 RVA: 0x0000B80C File Offset: 0x00009A0C
	// (set) Token: 0x0600009C RID: 156 RVA: 0x0000B824 File Offset: 0x00009A24
	internal virtual RichTextBox RichTextBox5
	{
		[DebuggerNonUserCode]
		get
		{
			return this._RichTextBox5;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._RichTextBox5 = value;
		}
	}

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x0600009D RID: 157 RVA: 0x0000B838 File Offset: 0x00009A38
	// (set) Token: 0x0600009E RID: 158 RVA: 0x0000B850 File Offset: 0x00009A50
	internal virtual TextBox TextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return this._TextBox1;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._TextBox1 = value;
		}
	}

	// Token: 0x17000020 RID: 32
	// (get) Token: 0x0600009F RID: 159 RVA: 0x0000B864 File Offset: 0x00009A64
	// (set) Token: 0x060000A0 RID: 160 RVA: 0x0000B87C File Offset: 0x00009A7C
	internal virtual Button Button6
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Button6;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.method_15);
			if (this._Button6 != null)
			{
				this._Button6.Click -= value2;
			}
			this._Button6 = value;
			if (this._Button6 != null)
			{
				this._Button6.Click += value2;
			}
		}
	}

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x060000A1 RID: 161 RVA: 0x0000B8D4 File Offset: 0x00009AD4
	// (set) Token: 0x060000A2 RID: 162 RVA: 0x0000B8EC File Offset: 0x00009AEC
	internal virtual Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Button1;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.method_11);
			if (this._Button1 != null)
			{
				this._Button1.Click -= value2;
			}
			this._Button1 = value;
			if (this._Button1 != null)
			{
				this._Button1.Click += value2;
			}
		}
	}

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x060000A3 RID: 163 RVA: 0x0000B944 File Offset: 0x00009B44
	// (set) Token: 0x060000A4 RID: 164 RVA: 0x0000B95C File Offset: 0x00009B5C
	internal virtual GroupBox GroupBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return this._GroupBox1;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._GroupBox1 = value;
		}
	}

	// Token: 0x17000023 RID: 35
	// (get) Token: 0x060000A5 RID: 165 RVA: 0x0000B970 File Offset: 0x00009B70
	// (set) Token: 0x060000A6 RID: 166 RVA: 0x0000B988 File Offset: 0x00009B88
	internal virtual Label l9
	{
		[DebuggerNonUserCode]
		get
		{
			return this._l9;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._l9 = value;
		}
	}

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x060000A7 RID: 167 RVA: 0x0000B99C File Offset: 0x00009B9C
	// (set) Token: 0x060000A8 RID: 168 RVA: 0x0000B9B4 File Offset: 0x00009BB4
	internal virtual Label l6
	{
		[DebuggerNonUserCode]
		get
		{
			return this._l6;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._l6 = value;
		}
	}

	// Token: 0x17000025 RID: 37
	// (get) Token: 0x060000A9 RID: 169 RVA: 0x0000B9C8 File Offset: 0x00009BC8
	// (set) Token: 0x060000AA RID: 170 RVA: 0x0000B9E0 File Offset: 0x00009BE0
	internal virtual Label l7
	{
		[DebuggerNonUserCode]
		get
		{
			return this._l7;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._l7 = value;
		}
	}

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x060000AB RID: 171 RVA: 0x0000B9F4 File Offset: 0x00009BF4
	// (set) Token: 0x060000AC RID: 172 RVA: 0x0000BA0C File Offset: 0x00009C0C
	internal virtual Label l5
	{
		[DebuggerNonUserCode]
		get
		{
			return this._l5;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._l5 = value;
		}
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x060000AD RID: 173 RVA: 0x0000BA20 File Offset: 0x00009C20
	// (set) Token: 0x060000AE RID: 174 RVA: 0x0000BA38 File Offset: 0x00009C38
	internal virtual Label l4
	{
		[DebuggerNonUserCode]
		get
		{
			return this._l4;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._l4 = value;
		}
	}

	// Token: 0x17000028 RID: 40
	// (get) Token: 0x060000AF RID: 175 RVA: 0x0000BA4C File Offset: 0x00009C4C
	// (set) Token: 0x060000B0 RID: 176 RVA: 0x0000BA64 File Offset: 0x00009C64
	internal virtual Label l8
	{
		[DebuggerNonUserCode]
		get
		{
			return this._l8;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._l8 = value;
		}
	}

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x060000B1 RID: 177 RVA: 0x0000BA78 File Offset: 0x00009C78
	// (set) Token: 0x060000B2 RID: 178 RVA: 0x0000BA90 File Offset: 0x00009C90
	internal virtual TextBox TextBox4
	{
		[DebuggerNonUserCode]
		get
		{
			return this._TextBox4;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.method_22);
			if (this._TextBox4 != null)
			{
				this._TextBox4.TextChanged -= value2;
			}
			this._TextBox4 = value;
			if (this._TextBox4 != null)
			{
				this._TextBox4.TextChanged += value2;
			}
		}
	}

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x060000B3 RID: 179 RVA: 0x0000BAE8 File Offset: 0x00009CE8
	// (set) Token: 0x060000B4 RID: 180 RVA: 0x0000BB00 File Offset: 0x00009D00
	internal virtual Button Button3
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Button3;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.method_13);
			if (this._Button3 != null)
			{
				this._Button3.Click -= value2;
			}
			this._Button3 = value;
			if (this._Button3 != null)
			{
				this._Button3.Click += value2;
			}
		}
	}

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x060000B5 RID: 181 RVA: 0x0000BB58 File Offset: 0x00009D58
	// (set) Token: 0x060000B6 RID: 182 RVA: 0x0000BB70 File Offset: 0x00009D70
	internal virtual Button Button2
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Button2;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.method_12);
			if (this._Button2 != null)
			{
				this._Button2.Click -= value2;
			}
			this._Button2 = value;
			if (this._Button2 != null)
			{
				this._Button2.Click += value2;
			}
		}
	}

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x060000B7 RID: 183 RVA: 0x0000BBC8 File Offset: 0x00009DC8
	// (set) Token: 0x060000B8 RID: 184 RVA: 0x0000BBE0 File Offset: 0x00009DE0
	internal virtual GroupBox GroupBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return this._GroupBox2;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._GroupBox2 = value;
		}
	}

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x060000B9 RID: 185 RVA: 0x0000BBF4 File Offset: 0x00009DF4
	// (set) Token: 0x060000BA RID: 186 RVA: 0x0000BC0C File Offset: 0x00009E0C
	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Label1;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Label1 = value;
		}
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x060000BB RID: 187 RVA: 0x0000BC20 File Offset: 0x00009E20
	// (set) Token: 0x060000BC RID: 188 RVA: 0x0000BC38 File Offset: 0x00009E38
	internal virtual GroupBox GroupBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return this._GroupBox3;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._GroupBox3 = value;
		}
	}

	// Token: 0x1700002F RID: 47
	// (get) Token: 0x060000BD RID: 189 RVA: 0x0000BC4C File Offset: 0x00009E4C
	// (set) Token: 0x060000BE RID: 190 RVA: 0x0000BC64 File Offset: 0x00009E64
	internal virtual Button Button7
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Button7;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.method_16);
			if (this._Button7 != null)
			{
				this._Button7.Click -= value2;
			}
			this._Button7 = value;
			if (this._Button7 != null)
			{
				this._Button7.Click += value2;
			}
		}
	}

	// Token: 0x17000030 RID: 48
	// (get) Token: 0x060000BF RID: 191 RVA: 0x0000BCBC File Offset: 0x00009EBC
	// (set) Token: 0x060000C0 RID: 192 RVA: 0x0000BCD4 File Offset: 0x00009ED4
	internal virtual BackgroundWorker BackgroundWorker_0
	{
		[DebuggerNonUserCode]
		get
		{
			return this.backgroundWorker_0;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			DoWorkEventHandler value2 = new DoWorkEventHandler(this.method_2);
			if (this.backgroundWorker_0 != null)
			{
				this.backgroundWorker_0.DoWork -= value2;
			}
			this.backgroundWorker_0 = value;
			if (this.backgroundWorker_0 != null)
			{
				this.backgroundWorker_0.DoWork += value2;
			}
		}
	}

	// Token: 0x17000031 RID: 49
	// (get) Token: 0x060000C1 RID: 193 RVA: 0x0000BD2C File Offset: 0x00009F2C
	// (set) Token: 0x060000C2 RID: 194 RVA: 0x0000BD44 File Offset: 0x00009F44
	internal virtual BackgroundWorker BackgroundWorker_1
	{
		[DebuggerNonUserCode]
		get
		{
			return this.backgroundWorker_1;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			DoWorkEventHandler value2 = new DoWorkEventHandler(this.method_3);
			if (this.backgroundWorker_1 != null)
			{
				this.backgroundWorker_1.DoWork -= value2;
			}
			this.backgroundWorker_1 = value;
			if (this.backgroundWorker_1 != null)
			{
				this.backgroundWorker_1.DoWork += value2;
			}
		}
	}

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x060000C3 RID: 195 RVA: 0x0000BD9C File Offset: 0x00009F9C
	// (set) Token: 0x060000C4 RID: 196 RVA: 0x0000BDB4 File Offset: 0x00009FB4
	internal virtual BackgroundWorker BackgroundWorker_2
	{
		[DebuggerNonUserCode]
		get
		{
			return this.backgroundWorker_2;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			DoWorkEventHandler value2 = new DoWorkEventHandler(this.method_4);
			if (this.backgroundWorker_2 != null)
			{
				this.backgroundWorker_2.DoWork -= value2;
			}
			this.backgroundWorker_2 = value;
			if (this.backgroundWorker_2 != null)
			{
				this.backgroundWorker_2.DoWork += value2;
			}
		}
	}

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x060000C5 RID: 197 RVA: 0x0000BE0C File Offset: 0x0000A00C
	// (set) Token: 0x060000C6 RID: 198 RVA: 0x0000BE24 File Offset: 0x0000A024
	internal virtual BackgroundWorker BackgroundWorker_3
	{
		[DebuggerNonUserCode]
		get
		{
			return this.backgroundWorker_3;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			DoWorkEventHandler value2 = new DoWorkEventHandler(this.method_5);
			if (this.backgroundWorker_3 != null)
			{
				this.backgroundWorker_3.DoWork -= value2;
			}
			this.backgroundWorker_3 = value;
			if (this.backgroundWorker_3 != null)
			{
				this.backgroundWorker_3.DoWork += value2;
			}
		}
	}

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x060000C7 RID: 199 RVA: 0x0000BE7C File Offset: 0x0000A07C
	// (set) Token: 0x060000C8 RID: 200 RVA: 0x0000BE94 File Offset: 0x0000A094
	internal virtual BackgroundWorker BackgroundWorker_4
	{
		[DebuggerNonUserCode]
		get
		{
			return this.backgroundWorker_4;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			DoWorkEventHandler value2 = new DoWorkEventHandler(this.method_6);
			if (this.backgroundWorker_4 != null)
			{
				this.backgroundWorker_4.DoWork -= value2;
			}
			this.backgroundWorker_4 = value;
			if (this.backgroundWorker_4 != null)
			{
				this.backgroundWorker_4.DoWork += value2;
			}
		}
	}

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x060000C9 RID: 201 RVA: 0x0000BEEC File Offset: 0x0000A0EC
	// (set) Token: 0x060000CA RID: 202 RVA: 0x0000BF04 File Offset: 0x0000A104
	internal virtual BackgroundWorker BackgroundWorker_5
	{
		[DebuggerNonUserCode]
		get
		{
			return this.backgroundWorker_5;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			DoWorkEventHandler value2 = new DoWorkEventHandler(this.method_7);
			if (this.backgroundWorker_5 != null)
			{
				this.backgroundWorker_5.DoWork -= value2;
			}
			this.backgroundWorker_5 = value;
			if (this.backgroundWorker_5 != null)
			{
				this.backgroundWorker_5.DoWork += value2;
			}
		}
	}

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x060000CB RID: 203 RVA: 0x0000BF5C File Offset: 0x0000A15C
	// (set) Token: 0x060000CC RID: 204 RVA: 0x0000BF74 File Offset: 0x0000A174
	internal virtual BackgroundWorker BackgroundWorker_6
	{
		[DebuggerNonUserCode]
		get
		{
			return this.backgroundWorker_6;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			DoWorkEventHandler value2 = new DoWorkEventHandler(this.method_9);
			RunWorkerCompletedEventHandler value3 = new RunWorkerCompletedEventHandler(this.method_10);
			if (this.backgroundWorker_6 != null)
			{
				this.backgroundWorker_6.DoWork -= value2;
				this.backgroundWorker_6.RunWorkerCompleted -= value3;
			}
			this.backgroundWorker_6 = value;
			if (this.backgroundWorker_6 != null)
			{
				this.backgroundWorker_6.DoWork += value2;
				this.backgroundWorker_6.RunWorkerCompleted += value3;
			}
		}
	}

	// Token: 0x17000037 RID: 55
	// (get) Token: 0x060000CD RID: 205 RVA: 0x0000BFF0 File Offset: 0x0000A1F0
	// (set) Token: 0x060000CE RID: 206 RVA: 0x0000C008 File Offset: 0x0000A208
	internal virtual ContextMenuStrip CMP
	{
		[DebuggerNonUserCode]
		get
		{
			return this._CMP;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._CMP = value;
		}
	}

	// Token: 0x17000038 RID: 56
	// (get) Token: 0x060000CF RID: 207 RVA: 0x0000C01C File Offset: 0x0000A21C
	// (set) Token: 0x060000D0 RID: 208 RVA: 0x0000C034 File Offset: 0x0000A234
	internal virtual ToolStripMenuItem ConfigParDefaultToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return this._ConfigParDefaultToolStripMenuItem;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.method_17);
			if (this._ConfigParDefaultToolStripMenuItem != null)
			{
				this._ConfigParDefaultToolStripMenuItem.Click -= value2;
			}
			this._ConfigParDefaultToolStripMenuItem = value;
			if (this._ConfigParDefaultToolStripMenuItem != null)
			{
				this._ConfigParDefaultToolStripMenuItem.Click += value2;
			}
		}
	}

	// Token: 0x17000039 RID: 57
	// (get) Token: 0x060000D1 RID: 209 RVA: 0x0000C08C File Offset: 0x0000A28C
	// (set) Token: 0x060000D2 RID: 210 RVA: 0x0000C0A4 File Offset: 0x0000A2A4
	internal virtual ToolStripMenuItem PastKeywordConfigToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return this._PastKeywordConfigToolStripMenuItem;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.method_18);
			if (this._PastKeywordConfigToolStripMenuItem != null)
			{
				this._PastKeywordConfigToolStripMenuItem.Click -= value2;
			}
			this._PastKeywordConfigToolStripMenuItem = value;
			if (this._PastKeywordConfigToolStripMenuItem != null)
			{
				this._PastKeywordConfigToolStripMenuItem.Click += value2;
			}
		}
	}

	// Token: 0x1700003A RID: 58
	// (get) Token: 0x060000D3 RID: 211 RVA: 0x0000C0FC File Offset: 0x0000A2FC
	// (set) Token: 0x060000D4 RID: 212 RVA: 0x0000C114 File Offset: 0x0000A314
	internal virtual ToolStripMenuItem ClearKeywordToolStripMenuItem
	{
		[DebuggerNonUserCode]
		get
		{
			return this._ClearKeywordToolStripMenuItem;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.method_19);
			if (this._ClearKeywordToolStripMenuItem != null)
			{
				this._ClearKeywordToolStripMenuItem.Click -= value2;
			}
			this._ClearKeywordToolStripMenuItem = value;
			if (this._ClearKeywordToolStripMenuItem != null)
			{
				this._ClearKeywordToolStripMenuItem.Click += value2;
			}
		}
	}

	// Token: 0x1700003B RID: 59
	// (get) Token: 0x060000D5 RID: 213 RVA: 0x0000C16C File Offset: 0x0000A36C
	// (set) Token: 0x060000D6 RID: 214 RVA: 0x0000C184 File Offset: 0x0000A384
	internal virtual Label l2
	{
		[DebuggerNonUserCode]
		get
		{
			return this._l2;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._l2 = value;
		}
	}

	// Token: 0x1700003C RID: 60
	// (get) Token: 0x060000D7 RID: 215 RVA: 0x0000C198 File Offset: 0x0000A398
	// (set) Token: 0x060000D8 RID: 216 RVA: 0x0000C1B0 File Offset: 0x0000A3B0
	internal virtual GroupBox GroupBox4
	{
		[DebuggerNonUserCode]
		get
		{
			return this._GroupBox4;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._GroupBox4 = value;
		}
	}

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x060000D9 RID: 217 RVA: 0x0000C1C4 File Offset: 0x0000A3C4
	// (set) Token: 0x060000DA RID: 218 RVA: 0x0000C1DC File Offset: 0x0000A3DC
	internal virtual Label Label13
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Label13;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Label13 = value;
		}
	}

	// Token: 0x1700003E RID: 62
	// (get) Token: 0x060000DB RID: 219 RVA: 0x0000C1F0 File Offset: 0x0000A3F0
	// (set) Token: 0x060000DC RID: 220 RVA: 0x0000C208 File Offset: 0x0000A408
	internal virtual Label Label10
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Label10;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Label10 = value;
		}
	}

	// Token: 0x1700003F RID: 63
	// (get) Token: 0x060000DD RID: 221 RVA: 0x0000C21C File Offset: 0x0000A41C
	// (set) Token: 0x060000DE RID: 222 RVA: 0x0000C234 File Offset: 0x0000A434
	internal virtual Label lbl3
	{
		[DebuggerNonUserCode]
		get
		{
			return this._lbl3;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._lbl3 = value;
		}
	}

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x060000DF RID: 223 RVA: 0x0000C248 File Offset: 0x0000A448
	// (set) Token: 0x060000E0 RID: 224 RVA: 0x0000C260 File Offset: 0x0000A460
	internal virtual Label Label11
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Label11;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Label11 = value;
		}
	}

	// Token: 0x17000041 RID: 65
	// (get) Token: 0x060000E1 RID: 225 RVA: 0x0000C274 File Offset: 0x0000A474
	// (set) Token: 0x060000E2 RID: 226 RVA: 0x0000C28C File Offset: 0x0000A48C
	internal virtual Label lbl9
	{
		[DebuggerNonUserCode]
		get
		{
			return this._lbl9;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._lbl9 = value;
		}
	}

	// Token: 0x17000042 RID: 66
	// (get) Token: 0x060000E3 RID: 227 RVA: 0x0000C2A0 File Offset: 0x0000A4A0
	// (set) Token: 0x060000E4 RID: 228 RVA: 0x0000C2B8 File Offset: 0x0000A4B8
	internal virtual Label Label12
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Label12;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Label12 = value;
		}
	}

	// Token: 0x17000043 RID: 67
	// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000C2CC File Offset: 0x0000A4CC
	// (set) Token: 0x060000E6 RID: 230 RVA: 0x0000C2E4 File Offset: 0x0000A4E4
	internal virtual GroupBox GroupBox5
	{
		[DebuggerNonUserCode]
		get
		{
			return this._GroupBox5;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._GroupBox5 = value;
		}
	}

	// Token: 0x17000044 RID: 68
	// (get) Token: 0x060000E7 RID: 231 RVA: 0x0000C2F8 File Offset: 0x0000A4F8
	// (set) Token: 0x060000E8 RID: 232 RVA: 0x0000C310 File Offset: 0x0000A510
	internal virtual Button Button8
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Button8;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.method_25);
			if (this._Button8 != null)
			{
				this._Button8.Click -= value2;
			}
			this._Button8 = value;
			if (this._Button8 != null)
			{
				this._Button8.Click += value2;
			}
		}
	}

	// Token: 0x17000045 RID: 69
	// (get) Token: 0x060000E9 RID: 233 RVA: 0x0000C368 File Offset: 0x0000A568
	// (set) Token: 0x060000EA RID: 234 RVA: 0x0000C380 File Offset: 0x0000A580
	internal virtual Button Button5
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Button5;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.method_24);
			if (this._Button5 != null)
			{
				this._Button5.Click -= value2;
			}
			this._Button5 = value;
			if (this._Button5 != null)
			{
				this._Button5.Click += value2;
			}
		}
	}

	// Token: 0x17000046 RID: 70
	// (get) Token: 0x060000EB RID: 235 RVA: 0x0000C3D8 File Offset: 0x0000A5D8
	// (set) Token: 0x060000EC RID: 236 RVA: 0x0000C3F0 File Offset: 0x0000A5F0
	internal virtual Button BTN1
	{
		[DebuggerNonUserCode]
		get
		{
			return this._BTN1;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.method_23);
			if (this._BTN1 != null)
			{
				this._BTN1.Click -= value2;
			}
			this._BTN1 = value;
			if (this._BTN1 != null)
			{
				this._BTN1.Click += value2;
			}
		}
	}

	// Token: 0x17000047 RID: 71
	// (get) Token: 0x060000ED RID: 237 RVA: 0x0000C448 File Offset: 0x0000A648
	// (set) Token: 0x060000EE RID: 238 RVA: 0x0000C460 File Offset: 0x0000A660
	internal virtual Button BTNLoad
	{
		[DebuggerNonUserCode]
		get
		{
			return this._BTNLoad;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.method_27);
			DragEventHandler value3 = new DragEventHandler(this.method_56);
			DragEventHandler value4 = new DragEventHandler(this.method_55);
			if (this._BTNLoad != null)
			{
				this._BTNLoad.Click -= value2;
				this._BTNLoad.DragEnter -= value3;
				this._BTNLoad.DragDrop -= value4;
			}
			this._BTNLoad = value;
			if (this._BTNLoad != null)
			{
				this._BTNLoad.Click += value2;
				this._BTNLoad.DragEnter += value3;
				this._BTNLoad.DragDrop += value4;
			}
		}
	}

	// Token: 0x17000048 RID: 72
	// (get) Token: 0x060000EF RID: 239 RVA: 0x0000C504 File Offset: 0x0000A704
	// (set) Token: 0x060000F0 RID: 240 RVA: 0x0000C51C File Offset: 0x0000A71C
	internal virtual Label l12
	{
		[DebuggerNonUserCode]
		get
		{
			return this._l12;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._l12 = value;
		}
	}

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x060000F1 RID: 241 RVA: 0x0000C530 File Offset: 0x0000A730
	// (set) Token: 0x060000F2 RID: 242 RVA: 0x0000C548 File Offset: 0x0000A748
	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Label2;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Label2 = value;
		}
	}

	// Token: 0x1700004A RID: 74
	// (get) Token: 0x060000F3 RID: 243 RVA: 0x0000C55C File Offset: 0x0000A75C
	// (set) Token: 0x060000F4 RID: 244 RVA: 0x0000C574 File Offset: 0x0000A774
	internal virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Label4;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Label4 = value;
		}
	}

	// Token: 0x1700004B RID: 75
	// (get) Token: 0x060000F5 RID: 245 RVA: 0x0000C588 File Offset: 0x0000A788
	// (set) Token: 0x060000F6 RID: 246 RVA: 0x0000C5A0 File Offset: 0x0000A7A0
	internal virtual TextBox TextBox5
	{
		[DebuggerNonUserCode]
		get
		{
			return this._TextBox5;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._TextBox5 = value;
		}
	}

	// Token: 0x1700004C RID: 76
	// (get) Token: 0x060000F7 RID: 247 RVA: 0x0000C5B4 File Offset: 0x0000A7B4
	// (set) Token: 0x060000F8 RID: 248 RVA: 0x0000C5CC File Offset: 0x0000A7CC
	internal virtual Label Label6
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Label6;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Label6 = value;
		}
	}

	// Token: 0x1700004D RID: 77
	// (get) Token: 0x060000F9 RID: 249 RVA: 0x0000C5E0 File Offset: 0x0000A7E0
	// (set) Token: 0x060000FA RID: 250 RVA: 0x0000C5F8 File Offset: 0x0000A7F8
	internal virtual Label Label5
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Label5;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Label5 = value;
		}
	}

	// Token: 0x1700004E RID: 78
	// (get) Token: 0x060000FB RID: 251 RVA: 0x0000C60C File Offset: 0x0000A80C
	// (set) Token: 0x060000FC RID: 252 RVA: 0x0000C624 File Offset: 0x0000A824
	internal virtual LinkLabel LinkLabel3
	{
		[DebuggerNonUserCode]
		get
		{
			return this._LinkLabel3;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			LinkLabelLinkClickedEventHandler value2 = new LinkLabelLinkClickedEventHandler(this.method_29);
			if (this._LinkLabel3 != null)
			{
				this._LinkLabel3.LinkClicked -= value2;
			}
			this._LinkLabel3 = value;
			if (this._LinkLabel3 != null)
			{
				this._LinkLabel3.LinkClicked += value2;
			}
		}
	}

	// Token: 0x1700004F RID: 79
	// (get) Token: 0x060000FD RID: 253 RVA: 0x0000C67C File Offset: 0x0000A87C
	// (set) Token: 0x060000FE RID: 254 RVA: 0x0000C694 File Offset: 0x0000A894
	internal virtual LinkLabel LinkLabel2
	{
		[DebuggerNonUserCode]
		get
		{
			return this._LinkLabel2;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			LinkLabelLinkClickedEventHandler value2 = new LinkLabelLinkClickedEventHandler(this.method_30);
			if (this._LinkLabel2 != null)
			{
				this._LinkLabel2.LinkClicked -= value2;
			}
			this._LinkLabel2 = value;
			if (this._LinkLabel2 != null)
			{
				this._LinkLabel2.LinkClicked += value2;
			}
		}
	}

	// Token: 0x17000050 RID: 80
	// (get) Token: 0x060000FF RID: 255 RVA: 0x0000C6EC File Offset: 0x0000A8EC
	// (set) Token: 0x06000100 RID: 256 RVA: 0x0000C704 File Offset: 0x0000A904
	internal virtual LinkLabel LinkLabel1
	{
		[DebuggerNonUserCode]
		get
		{
			return this._LinkLabel1;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			LinkLabelLinkClickedEventHandler value2 = new LinkLabelLinkClickedEventHandler(this.method_31);
			if (this._LinkLabel1 != null)
			{
				this._LinkLabel1.LinkClicked -= value2;
			}
			this._LinkLabel1 = value;
			if (this._LinkLabel1 != null)
			{
				this._LinkLabel1.LinkClicked += value2;
			}
		}
	}

	// Token: 0x17000051 RID: 81
	// (get) Token: 0x06000101 RID: 257 RVA: 0x0000C75C File Offset: 0x0000A95C
	// (set) Token: 0x06000102 RID: 258 RVA: 0x0000C774 File Offset: 0x0000A974
	internal virtual Label Label17
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Label17;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Label17 = value;
		}
	}

	// Token: 0x17000052 RID: 82
	// (get) Token: 0x06000103 RID: 259 RVA: 0x0000C788 File Offset: 0x0000A988
	// (set) Token: 0x06000104 RID: 260 RVA: 0x0000C7A0 File Offset: 0x0000A9A0
	internal virtual Label Label18
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Label18;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Label18 = value;
		}
	}

	// Token: 0x17000053 RID: 83
	// (get) Token: 0x06000105 RID: 261 RVA: 0x0000C7B4 File Offset: 0x0000A9B4
	// (set) Token: 0x06000106 RID: 262 RVA: 0x0000C7CC File Offset: 0x0000A9CC
	internal virtual Label Label19
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Label19;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Label19 = value;
		}
	}

	// Token: 0x17000054 RID: 84
	// (get) Token: 0x06000107 RID: 263 RVA: 0x0000C7E0 File Offset: 0x0000A9E0
	// (set) Token: 0x06000108 RID: 264 RVA: 0x0000C7F8 File Offset: 0x0000A9F8
	internal virtual Label Label16
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Label16;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Label16 = value;
		}
	}

	// Token: 0x17000055 RID: 85
	// (get) Token: 0x06000109 RID: 265 RVA: 0x0000C80C File Offset: 0x0000AA0C
	// (set) Token: 0x0600010A RID: 266 RVA: 0x0000C824 File Offset: 0x0000AA24
	internal virtual Label Label15
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Label15;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Label15 = value;
		}
	}

	// Token: 0x17000056 RID: 86
	// (get) Token: 0x0600010B RID: 267 RVA: 0x0000C838 File Offset: 0x0000AA38
	// (set) Token: 0x0600010C RID: 268 RVA: 0x0000C850 File Offset: 0x0000AA50
	internal virtual Label Label14
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Label14;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Label14 = value;
		}
	}

	// Token: 0x17000057 RID: 87
	// (get) Token: 0x0600010D RID: 269 RVA: 0x0000C864 File Offset: 0x0000AA64
	// (set) Token: 0x0600010E RID: 270 RVA: 0x0000C87C File Offset: 0x0000AA7C
	internal virtual Label Label9
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Label9;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Label9 = value;
		}
	}

	// Token: 0x17000058 RID: 88
	// (get) Token: 0x0600010F RID: 271 RVA: 0x0000C890 File Offset: 0x0000AA90
	// (set) Token: 0x06000110 RID: 272 RVA: 0x0000C8A8 File Offset: 0x0000AAA8
	internal virtual Label Label8
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Label8;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Label8 = value;
		}
	}

	// Token: 0x17000059 RID: 89
	// (get) Token: 0x06000111 RID: 273 RVA: 0x0000C8BC File Offset: 0x0000AABC
	// (set) Token: 0x06000112 RID: 274 RVA: 0x0000C8D4 File Offset: 0x0000AAD4
	internal virtual Label Label7
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Label7;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Label7 = value;
		}
	}

	// Token: 0x1700005A RID: 90
	// (get) Token: 0x06000113 RID: 275 RVA: 0x0000C8E8 File Offset: 0x0000AAE8
	// (set) Token: 0x06000114 RID: 276 RVA: 0x0000C900 File Offset: 0x0000AB00
	internal virtual Button Button10
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Button10;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.method_34);
			if (this._Button10 != null)
			{
				this._Button10.Click -= value2;
			}
			this._Button10 = value;
			if (this._Button10 != null)
			{
				this._Button10.Click += value2;
			}
		}
	}

	// Token: 0x1700005B RID: 91
	// (get) Token: 0x06000115 RID: 277 RVA: 0x0000C958 File Offset: 0x0000AB58
	// (set) Token: 0x06000116 RID: 278 RVA: 0x0000C970 File Offset: 0x0000AB70
	internal virtual Button Button9
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Button9;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.method_32);
			if (this._Button9 != null)
			{
				this._Button9.Click -= value2;
			}
			this._Button9 = value;
			if (this._Button9 != null)
			{
				this._Button9.Click += value2;
			}
		}
	}

	// Token: 0x1700005C RID: 92
	// (get) Token: 0x06000117 RID: 279 RVA: 0x0000C9C8 File Offset: 0x0000ABC8
	// (set) Token: 0x06000118 RID: 280 RVA: 0x0000C9E0 File Offset: 0x0000ABE0
	internal virtual ComboBox CMResultat
	{
		[DebuggerNonUserCode]
		get
		{
			return this._CMResultat;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.method_35);
			if (this._CMResultat != null)
			{
				this._CMResultat.SelectedIndexChanged -= value2;
			}
			this._CMResultat = value;
			if (this._CMResultat != null)
			{
				this._CMResultat.SelectedIndexChanged += value2;
			}
		}
	}

	// Token: 0x1700005D RID: 93
	// (get) Token: 0x06000119 RID: 281 RVA: 0x0000CA38 File Offset: 0x0000AC38
	// (set) Token: 0x0600011A RID: 282 RVA: 0x0000CA50 File Offset: 0x0000AC50
	internal virtual Label Label23
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Label23;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Label23 = value;
		}
	}

	// Token: 0x1700005E RID: 94
	// (get) Token: 0x0600011B RID: 283 RVA: 0x0000CA64 File Offset: 0x0000AC64
	// (set) Token: 0x0600011C RID: 284 RVA: 0x0000CA7C File Offset: 0x0000AC7C
	internal virtual Label lblc
	{
		[DebuggerNonUserCode]
		get
		{
			return this._lblc;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._lblc = value;
		}
	}

	// Token: 0x1700005F RID: 95
	// (get) Token: 0x0600011D RID: 285 RVA: 0x0000CA90 File Offset: 0x0000AC90
	// (set) Token: 0x0600011E RID: 286 RVA: 0x0000CAA8 File Offset: 0x0000ACA8
	internal virtual RichTextBox RichLeech
	{
		[DebuggerNonUserCode]
		get
		{
			return this._RichLeech;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._RichLeech = value;
		}
	}

	// Token: 0x17000060 RID: 96
	// (get) Token: 0x0600011F RID: 287 RVA: 0x0000CABC File Offset: 0x0000ACBC
	// (set) Token: 0x06000120 RID: 288 RVA: 0x0000CAD4 File Offset: 0x0000ACD4
	internal virtual Panel Panel1
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Panel1;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Panel1 = value;
		}
	}

	// Token: 0x17000061 RID: 97
	// (get) Token: 0x06000121 RID: 289 RVA: 0x0000CAE8 File Offset: 0x0000ACE8
	// (set) Token: 0x06000122 RID: 290 RVA: 0x0000CB00 File Offset: 0x0000AD00
	internal virtual Label lblyes
	{
		[DebuggerNonUserCode]
		get
		{
			return this._lblyes;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._lblyes = value;
		}
	}

	// Token: 0x17000062 RID: 98
	// (get) Token: 0x06000123 RID: 291 RVA: 0x0000CB14 File Offset: 0x0000AD14
	// (set) Token: 0x06000124 RID: 292 RVA: 0x0000CB2C File Offset: 0x0000AD2C
	internal virtual Label lnews
	{
		[DebuggerNonUserCode]
		get
		{
			return this._lnews;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._lnews = value;
		}
	}

	// Token: 0x17000063 RID: 99
	// (get) Token: 0x06000125 RID: 293 RVA: 0x0000CB40 File Offset: 0x0000AD40
	// (set) Token: 0x06000126 RID: 294 RVA: 0x0000CB58 File Offset: 0x0000AD58
	internal virtual PictureBox imgversion
	{
		[DebuggerNonUserCode]
		get
		{
			return this._imgversion;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._imgversion = value;
		}
	}

	// Token: 0x17000064 RID: 100
	// (get) Token: 0x06000127 RID: 295 RVA: 0x0000CB6C File Offset: 0x0000AD6C
	// (set) Token: 0x06000128 RID: 296 RVA: 0x0000CB84 File Offset: 0x0000AD84
	internal virtual Button Button11
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Button11;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.method_38);
			if (this._Button11 != null)
			{
				this._Button11.Click -= value2;
			}
			this._Button11 = value;
			if (this._Button11 != null)
			{
				this._Button11.Click += value2;
			}
		}
	}

	// Token: 0x17000065 RID: 101
	// (get) Token: 0x06000129 RID: 297 RVA: 0x0000CBDC File Offset: 0x0000ADDC
	// (set) Token: 0x0600012A RID: 298 RVA: 0x0000CBF4 File Offset: 0x0000ADF4
	internal virtual BackgroundWorker BackgroundWorker_7
	{
		[DebuggerNonUserCode]
		get
		{
			return this.backgroundWorker_7;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			DoWorkEventHandler value2 = new DoWorkEventHandler(this.method_39);
			if (this.backgroundWorker_7 != null)
			{
				this.backgroundWorker_7.DoWork -= value2;
			}
			this.backgroundWorker_7 = value;
			if (this.backgroundWorker_7 != null)
			{
				this.backgroundWorker_7.DoWork += value2;
			}
		}
	}

	// Token: 0x17000066 RID: 102
	// (get) Token: 0x0600012B RID: 299 RVA: 0x0000CC4C File Offset: 0x0000AE4C
	// (set) Token: 0x0600012C RID: 300 RVA: 0x0000CC64 File Offset: 0x0000AE64
	internal virtual RichTextBox RchYandex
	{
		[DebuggerNonUserCode]
		get
		{
			return this._RchYandex;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._RchYandex = value;
		}
	}

	// Token: 0x17000067 RID: 103
	// (get) Token: 0x0600012D RID: 301 RVA: 0x0000CC78 File Offset: 0x0000AE78
	// (set) Token: 0x0600012E RID: 302 RVA: 0x0000CC90 File Offset: 0x0000AE90
	internal virtual RichTextBox RCHp
	{
		[DebuggerNonUserCode]
		get
		{
			return this._RCHp;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._RCHp = value;
		}
	}

	// Token: 0x17000068 RID: 104
	// (get) Token: 0x0600012F RID: 303 RVA: 0x0000CCA4 File Offset: 0x0000AEA4
	// (set) Token: 0x06000130 RID: 304 RVA: 0x0000CCBC File Offset: 0x0000AEBC
	internal virtual BackgroundWorker BackgroundWorker_8
	{
		[DebuggerNonUserCode]
		get
		{
			return this.backgroundWorker_8;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			DoWorkEventHandler value2 = new DoWorkEventHandler(this.method_40);
			if (this.backgroundWorker_8 != null)
			{
				this.backgroundWorker_8.DoWork -= value2;
			}
			this.backgroundWorker_8 = value;
			if (this.backgroundWorker_8 != null)
			{
				this.backgroundWorker_8.DoWork += value2;
			}
		}
	}

	// Token: 0x17000069 RID: 105
	// (get) Token: 0x06000131 RID: 305 RVA: 0x0000CD14 File Offset: 0x0000AF14
	// (set) Token: 0x06000132 RID: 306 RVA: 0x0000CD2C File Offset: 0x0000AF2C
	internal virtual BackgroundWorker BackgroundWorker_9
	{
		[DebuggerNonUserCode]
		get
		{
			return this.backgroundWorker_9;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this.backgroundWorker_9 = value;
		}
	}

	// Token: 0x1700006A RID: 106
	// (get) Token: 0x06000133 RID: 307 RVA: 0x0000CD40 File Offset: 0x0000AF40
	// (set) Token: 0x06000134 RID: 308 RVA: 0x0000CD58 File Offset: 0x0000AF58
	internal virtual ComboBox CMType
	{
		[DebuggerNonUserCode]
		get
		{
			return this._CMType;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.method_47);
			if (this._CMType != null)
			{
				this._CMType.SelectedIndexChanged -= value2;
			}
			this._CMType = value;
			if (this._CMType != null)
			{
				this._CMType.SelectedIndexChanged += value2;
			}
		}
	}

	// Token: 0x1700006B RID: 107
	// (get) Token: 0x06000135 RID: 309 RVA: 0x0000CDB0 File Offset: 0x0000AFB0
	// (set) Token: 0x06000136 RID: 310 RVA: 0x0000CDC8 File Offset: 0x0000AFC8
	internal virtual PictureBox PictureBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return this._PictureBox2;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.method_50);
			EventHandler value3 = new EventHandler(this.method_49);
			EventHandler value4 = new EventHandler(this.method_48);
			if (this._PictureBox2 != null)
			{
				this._PictureBox2.MouseLeave -= value2;
				this._PictureBox2.MouseEnter -= value3;
				this._PictureBox2.Click -= value4;
			}
			this._PictureBox2 = value;
			if (this._PictureBox2 != null)
			{
				this._PictureBox2.MouseLeave += value2;
				this._PictureBox2.MouseEnter += value3;
				this._PictureBox2.Click += value4;
			}
		}
	}

	// Token: 0x1700006C RID: 108
	// (get) Token: 0x06000137 RID: 311 RVA: 0x0000CE6C File Offset: 0x0000B06C
	// (set) Token: 0x06000138 RID: 312 RVA: 0x0000CE84 File Offset: 0x0000B084
	internal virtual Label Label20
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Label20;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Label20 = value;
		}
	}

	// Token: 0x1700006D RID: 109
	// (get) Token: 0x06000139 RID: 313 RVA: 0x0000CE98 File Offset: 0x0000B098
	// (set) Token: 0x0600013A RID: 314 RVA: 0x0000CEB0 File Offset: 0x0000B0B0
	internal virtual Label Label21
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Label21;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Label21 = value;
		}
	}

	// Token: 0x1700006E RID: 110
	// (get) Token: 0x0600013B RID: 315 RVA: 0x0000CEC4 File Offset: 0x0000B0C4
	// (set) Token: 0x0600013C RID: 316 RVA: 0x0000CEDC File Offset: 0x0000B0DC
	internal virtual Label err
	{
		[DebuggerNonUserCode]
		get
		{
			return this._err;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._err = value;
		}
	}

	// Token: 0x1700006F RID: 111
	// (get) Token: 0x0600013D RID: 317 RVA: 0x0000CEF0 File Offset: 0x0000B0F0
	// (set) Token: 0x0600013E RID: 318 RVA: 0x0000CF08 File Offset: 0x0000B108
	internal virtual Label CERR
	{
		[DebuggerNonUserCode]
		get
		{
			return this._CERR;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._CERR = value;
		}
	}

	// Token: 0x17000070 RID: 112
	// (get) Token: 0x0600013F RID: 319 RVA: 0x0000CF1C File Offset: 0x0000B11C
	// (set) Token: 0x06000140 RID: 320 RVA: 0x0000CF34 File Offset: 0x0000B134
	internal virtual Label Label24
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Label24;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Label24 = value;
		}
	}

	// Token: 0x17000071 RID: 113
	// (get) Token: 0x06000141 RID: 321 RVA: 0x0000CF48 File Offset: 0x0000B148
	// (set) Token: 0x06000142 RID: 322 RVA: 0x0000CF60 File Offset: 0x0000B160
	internal virtual ToolTip ToolTip_0
	{
		[DebuggerNonUserCode]
		get
		{
			return this.toolTip_0;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this.toolTip_0 = value;
		}
	}

	// Token: 0x17000072 RID: 114
	// (get) Token: 0x06000143 RID: 323 RVA: 0x0000CF74 File Offset: 0x0000B174
	// (set) Token: 0x06000144 RID: 324 RVA: 0x0000CF8C File Offset: 0x0000B18C
	internal virtual Label Label22
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Label22;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Label22 = value;
		}
	}

	// Token: 0x17000073 RID: 115
	// (get) Token: 0x06000145 RID: 325 RVA: 0x0000CFA0 File Offset: 0x0000B1A0
	// (set) Token: 0x06000146 RID: 326 RVA: 0x0000CFB8 File Offset: 0x0000B1B8
	internal virtual LinkLabel LinkLabel4
	{
		[DebuggerNonUserCode]
		get
		{
			return this._LinkLabel4;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			LinkLabelLinkClickedEventHandler value2 = new LinkLabelLinkClickedEventHandler(this.method_52);
			if (this._LinkLabel4 != null)
			{
				this._LinkLabel4.LinkClicked -= value2;
			}
			this._LinkLabel4 = value;
			if (this._LinkLabel4 != null)
			{
				this._LinkLabel4.LinkClicked += value2;
			}
		}
	}

	// Token: 0x17000074 RID: 116
	// (get) Token: 0x06000147 RID: 327 RVA: 0x0000D010 File Offset: 0x0000B210
	// (set) Token: 0x06000148 RID: 328 RVA: 0x0000D028 File Offset: 0x0000B228
	internal virtual NumericUpDown numericUpDown1
	{
		[DebuggerNonUserCode]
		get
		{
			return this._numericUpDown1;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._numericUpDown1 = value;
		}
	}

	// Token: 0x17000075 RID: 117
	// (get) Token: 0x06000149 RID: 329 RVA: 0x0000D03C File Offset: 0x0000B23C
	// (set) Token: 0x0600014A RID: 330 RVA: 0x0000D054 File Offset: 0x0000B254
	internal virtual GroupBox GroupBox7
	{
		[DebuggerNonUserCode]
		get
		{
			return this._GroupBox7;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._GroupBox7 = value;
		}
	}

	// Token: 0x17000076 RID: 118
	// (get) Token: 0x0600014B RID: 331 RVA: 0x0000D068 File Offset: 0x0000B268
	// (set) Token: 0x0600014C RID: 332 RVA: 0x0000D080 File Offset: 0x0000B280
	internal virtual Label Label25
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Label25;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Label25 = value;
		}
	}

	// Token: 0x17000077 RID: 119
	// (get) Token: 0x0600014D RID: 333 RVA: 0x0000D094 File Offset: 0x0000B294
	// (set) Token: 0x0600014E RID: 334 RVA: 0x0000D0AC File Offset: 0x0000B2AC
	internal virtual Label Label26
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Label26;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Label26 = value;
		}
	}

	// Token: 0x17000078 RID: 120
	// (get) Token: 0x0600014F RID: 335 RVA: 0x0000D0C0 File Offset: 0x0000B2C0
	// (set) Token: 0x06000150 RID: 336 RVA: 0x0000D0D8 File Offset: 0x0000B2D8
	internal virtual System.Windows.Forms.Timer Timer_0
	{
		[DebuggerNonUserCode]
		get
		{
			return this.timer_0;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.method_53);
			if (this.timer_0 != null)
			{
				this.timer_0.Tick -= value2;
			}
			this.timer_0 = value;
			if (this.timer_0 != null)
			{
				this.timer_0.Tick += value2;
			}
		}
	}

	// Token: 0x17000079 RID: 121
	// (get) Token: 0x06000151 RID: 337 RVA: 0x0000D130 File Offset: 0x0000B330
	// (set) Token: 0x06000152 RID: 338 RVA: 0x0000D148 File Offset: 0x0000B348
	internal virtual RichTextBox TXT2
	{
		[DebuggerNonUserCode]
		get
		{
			return this._TXT2;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.method_54);
			if (this._TXT2 != null)
			{
				this._TXT2.TextChanged -= value2;
			}
			this._TXT2 = value;
			if (this._TXT2 != null)
			{
				this._TXT2.TextChanged += value2;
			}
		}
	}

	// Token: 0x1700007A RID: 122
	// (get) Token: 0x06000153 RID: 339 RVA: 0x0000D1A0 File Offset: 0x0000B3A0
	// (set) Token: 0x06000154 RID: 340 RVA: 0x0000D1B8 File Offset: 0x0000B3B8
	internal virtual Panel Panel2
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Panel2;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Panel2 = value;
		}
	}

	// Token: 0x1700007B RID: 123
	// (get) Token: 0x06000155 RID: 341 RVA: 0x0000D1CC File Offset: 0x0000B3CC
	// (set) Token: 0x06000156 RID: 342 RVA: 0x0000D1E4 File Offset: 0x0000B3E4
	internal virtual Button Button4
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Button4;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.method_57);
			if (this._Button4 != null)
			{
				this._Button4.Click -= value2;
			}
			this._Button4 = value;
			if (this._Button4 != null)
			{
				this._Button4.Click += value2;
			}
		}
	}

	// Token: 0x1700007C RID: 124
	// (get) Token: 0x06000157 RID: 343 RVA: 0x0000D23C File Offset: 0x0000B43C
	// (set) Token: 0x06000158 RID: 344 RVA: 0x0000D254 File Offset: 0x0000B454
	internal virtual Button bproxy
	{
		[DebuggerNonUserCode]
		get
		{
			return this._bproxy;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			DragEventHandler value2 = new DragEventHandler(this.method_60);
			DragEventHandler value3 = new DragEventHandler(this.method_59);
			EventHandler value4 = new EventHandler(this.method_58);
			if (this._bproxy != null)
			{
				this._bproxy.DragEnter -= value2;
				this._bproxy.DragDrop -= value3;
				this._bproxy.Click -= value4;
			}
			this._bproxy = value;
			if (this._bproxy != null)
			{
				this._bproxy.DragEnter += value2;
				this._bproxy.DragDrop += value3;
				this._bproxy.Click += value4;
			}
		}
	}

	// Token: 0x1700007D RID: 125
	// (get) Token: 0x06000159 RID: 345 RVA: 0x0000D2F8 File Offset: 0x0000B4F8
	// (set) Token: 0x0600015A RID: 346 RVA: 0x0000D310 File Offset: 0x0000B510
	internal virtual Label Label27
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Label27;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Label27 = value;
		}
	}

	// Token: 0x1700007E RID: 126
	// (get) Token: 0x0600015B RID: 347 RVA: 0x0000D324 File Offset: 0x0000B524
	// (set) Token: 0x0600015C RID: 348 RVA: 0x0000D33C File Offset: 0x0000B53C
	internal virtual ComboBox text_proxyType
	{
		[DebuggerNonUserCode]
		get
		{
			return this._text_proxyType;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.method_61);
			if (this._text_proxyType != null)
			{
				this._text_proxyType.SelectedIndexChanged -= value2;
			}
			this._text_proxyType = value;
			if (this._text_proxyType != null)
			{
				this._text_proxyType.SelectedIndexChanged += value2;
			}
		}
	}

	// Token: 0x1700007F RID: 127
	// (get) Token: 0x0600015D RID: 349 RVA: 0x0000D394 File Offset: 0x0000B594
	// (set) Token: 0x0600015E RID: 350 RVA: 0x0000D3AC File Offset: 0x0000B5AC
	internal virtual Panel Panel3
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Panel3;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Panel3 = value;
		}
	}

	// Token: 0x17000080 RID: 128
	// (get) Token: 0x0600015F RID: 351 RVA: 0x0000D3C0 File Offset: 0x0000B5C0
	// (set) Token: 0x06000160 RID: 352 RVA: 0x0000D3D8 File Offset: 0x0000B5D8
	internal virtual PictureBox PictureBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return this._PictureBox1;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.method_63);
			EventHandler value3 = new EventHandler(this.method_62);
			if (this._PictureBox1 != null)
			{
				this._PictureBox1.MouseLeave -= value2;
				this._PictureBox1.MouseEnter -= value3;
			}
			this._PictureBox1 = value;
			if (this._PictureBox1 != null)
			{
				this._PictureBox1.MouseLeave += value2;
				this._PictureBox1.MouseEnter += value3;
			}
		}
	}

	// Token: 0x17000081 RID: 129
	// (get) Token: 0x06000161 RID: 353 RVA: 0x0000D454 File Offset: 0x0000B654
	// (set) Token: 0x06000162 RID: 354 RVA: 0x0000D46C File Offset: 0x0000B66C
	internal virtual PictureBox PictureBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return this._PictureBox3;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._PictureBox3 = value;
		}
	}

	// Token: 0x17000082 RID: 130
	// (get) Token: 0x06000163 RID: 355 RVA: 0x0000D480 File Offset: 0x0000B680
	// (set) Token: 0x06000164 RID: 356 RVA: 0x0000D498 File Offset: 0x0000B698
	internal virtual LinkLabel LinkLabel5
	{
		[DebuggerNonUserCode]
		get
		{
			return this._LinkLabel5;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			LinkLabelLinkClickedEventHandler value2 = new LinkLabelLinkClickedEventHandler(this.method_65);
			if (this._LinkLabel5 != null)
			{
				this._LinkLabel5.LinkClicked -= value2;
			}
			this._LinkLabel5 = value;
			if (this._LinkLabel5 != null)
			{
				this._LinkLabel5.LinkClicked += value2;
			}
		}
	}

	// Token: 0x17000083 RID: 131
	// (get) Token: 0x06000165 RID: 357 RVA: 0x0000D4F0 File Offset: 0x0000B6F0
	// (set) Token: 0x06000166 RID: 358 RVA: 0x0000D508 File Offset: 0x0000B708
	internal virtual Label Label28
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Label28;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Label28 = value;
		}
	}

	// Token: 0x17000084 RID: 132
	// (get) Token: 0x06000167 RID: 359 RVA: 0x0000D51C File Offset: 0x0000B71C
	// (set) Token: 0x06000168 RID: 360 RVA: 0x0000D534 File Offset: 0x0000B734
	internal virtual ToolTip ToolTip_1
	{
		[DebuggerNonUserCode]
		get
		{
			return this.toolTip_1;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this.toolTip_1 = value;
		}
	}

	// Token: 0x17000085 RID: 133
	// (get) Token: 0x06000169 RID: 361 RVA: 0x0000D548 File Offset: 0x0000B748
	// (set) Token: 0x0600016A RID: 362 RVA: 0x0000D560 File Offset: 0x0000B760
	internal virtual Label Label30
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Label30;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Label30 = value;
		}
	}

	// Token: 0x17000086 RID: 134
	// (get) Token: 0x0600016B RID: 363 RVA: 0x0000D574 File Offset: 0x0000B774
	// (set) Token: 0x0600016C RID: 364 RVA: 0x0000D58C File Offset: 0x0000B78C
	internal virtual Label Label29
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Label29;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Label29 = value;
		}
	}

	// Token: 0x17000087 RID: 135
	// (get) Token: 0x0600016D RID: 365 RVA: 0x0000D5A0 File Offset: 0x0000B7A0
	// (set) Token: 0x0600016E RID: 366 RVA: 0x0000D5B8 File Offset: 0x0000B7B8
	internal virtual PictureBox PictureBox4
	{
		[DebuggerNonUserCode]
		get
		{
			return this._PictureBox4;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._PictureBox4 = value;
		}
	}

	// Token: 0x17000088 RID: 136
	// (get) Token: 0x0600016F RID: 367 RVA: 0x0000D5CC File Offset: 0x0000B7CC
	// (set) Token: 0x06000170 RID: 368 RVA: 0x0000D5E4 File Offset: 0x0000B7E4
	internal virtual VisualStyler VisualStyler_0
	{
		[DebuggerNonUserCode]
		get
		{
			return this.visualStyler_0;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this.visualStyler_0 = value;
		}
	}

	// Token: 0x06000171 RID: 369 RVA: 0x0000D5F8 File Offset: 0x0000B7F8
	public Form1()
	{
		base.Shown += this.Form1_Shown;
		Form1.smethod_0(this);
		this.string_0 = new string[]
		{
			"Mozilla/4.0 (compatible; Intel Mac OS X 10.6; rv:2.0b8) Gecko/20100101 Firefox/4.0b8)",
			"Mozilla/5.0 (Macintosh; I; Intel Mac OS X 11_7_9; de-LI; rv:1.9b4) Gecko/2012010317 Firefox/10.0a4",
			"Mozilla/5.0 (Macintosh; Intel Mac OS X 10.6; rv:2.0b11pre) Gecko/20110126 Firefox/4.0b11pre",
			"Mozilla/5.0 (Macintosh; Intel Mac OS X 10.6; rv:2.0b8) Gecko/20100101 Firefox/4.0b8",
			"Mozilla/5.0 (Macintosh; Intel Mac OS X 10.6; rv:25.0) Gecko/20100101 Firefox/25.0",
			"Mozilla/5.0 (Macintosh; Intel Mac OS X 10.6; rv:9.0) Gecko/20100101 Firefox/9.0",
			"Mozilla/5.0 (Macintosh; Intel Mac OS X 10.6; rv:9.0a2) Gecko/20111101 Firefox/9.0a2",
			"Mozilla/5.0 (Macintosh; Intel Mac OS X 10.8; rv:21.0) Gecko/20100101 Firefox/21.0",
			"Mozilla/5.0 (Macintosh; Intel Mac OS X 10.8; rv:24.0) Gecko/20100101 Firefox/24.0",
			"Mozilla/5.0 (Macintosh; Intel Mac OS X 10_10; rv:33.0) Gecko/20100101 Firefox/33.0",
			"Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10.5; en-US; rv:1.9.2.4) Gecko/20100527 Firefox/3.6.4",
			"Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10.6; en-US; rv:1.9.2) Gecko/20091218 Firefox 3.6b5",
			"Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10.6;en-US; rv:1.9.2.9) Gecko/20100824 Firefox/3.6.9",
			"Mozilla/5.0 (Macintosh; U; Intel Mac OS X; de-AT; rv:1.9.1.8) Gecko/20100625 Firefox/3.6.6",
			"Mozilla/5.0 (Macintosh; U; PPC Mac OS X 10.5; en-US; rv:1.9.2.4) Gecko/20100611 Firefox/3.6.4 GTB7.0",
			"Mozilla/5.0 (Microsoft Windows NT 6.2.9200.0); rv:22.0) Gecko/20130405 Firefox/22.0",
			"Mozilla/5.0 (Windows NT 5.0; WOW64; rv:5.0) Gecko/20100101 Firefox/5.0",
			"Mozilla/5.0 (Windows NT 5.0; WOW64; rv:6.0) Gecko/20100101 Firefox/6.0",
			"Mozilla/5.0 (Windows NT 5.0; rv:21.0) Gecko/20100101 Firefox/21.0",
			"Mozilla/5.0 (Windows NT 5.0; rv:5.0) Gecko/20100101 Firefox/5.0",
			"Mozilla/5.0 (Windows NT 5.1; U; rv:5.0) Gecko/20100101 Firefox/5.0",
			"Mozilla/5.0 (Windows NT 5.1; rv:11.0) Gecko Firefox/11.0",
			"Mozilla/5.0 (Windows NT 5.1; rv:12.0) Gecko/20120403211507 Firefox/12.0",
			"Mozilla/5.0 (Windows NT 5.1; rv:14.0) Gecko/20120405 Firefox/14.0a1",
			"Mozilla/5.0 (Windows NT 5.1; rv:15.0) Gecko/20100101 Firefox/13.0.1",
			"Mozilla/5.0 (Windows NT 5.1; rv:2.0.1) Gecko/20100101 Firefox/5.0",
			"Mozilla/5.0 (Windows NT 5.1; rv:2.0b13pre) Gecko/20110223 Firefox/4.0b13pre",
			"Mozilla/5.0 (Windows NT 5.1; rv:2.0b8pre) Gecko/20101127 Firefox/4.0b8pre",
			"Mozilla/5.0 (Windows NT 5.1; rv:2.0b9pre) Gecko/20110105 Firefox/4.0b9pre",
			"Mozilla/5.0 (Windows NT 5.1; rv:21.0) Gecko/20100101 Firefox/21.0",
			"Mozilla/5.0 (Windows NT 5.1; rv:21.0) Gecko/20130331 Firefox/21.0",
			"Mozilla/5.0 (Windows NT 5.1; rv:21.0) Gecko/20130401 Firefox/21.0",
			"Mozilla/5.0 (Windows NT 5.1; rv:31.0) Gecko/20100101 Firefox/31.0",
			"Mozilla/5.0 (Windows NT 5.1; rv:6.0) Gecko/20100101 Firefox/6.0 FirePHP/0.6",
			"Mozilla/5.0 (Windows NT 5.1; rv:8.0; en_us) Gecko/20100101 Firefox/8.0",
			"Mozilla/5.0 (Windows NT 5.2; WOW64; rv:5.0) Gecko/20100101 Firefox/5.0",
			"Mozilla/5.0 (Windows NT 5.2; rv:2.0b13pre) Gecko/20110304 Firefox/4.0b13pre",
			"Mozilla/5.0 (Windows NT 6.0; WOW64; rv:24.0) Gecko/20100101 Firefox/24.0",
			"Mozilla/5.0 (Windows NT 6.0; rv:14.0) Gecko/20100101 Firefox/14.0.1",
			"Mozilla/5.0 (Windows NT 6.1.1; rv:5.0) Gecko/20100101 Firefox/5.0",
			"Mozilla/5.0 (Windows NT 6.1; U; ru; rv:5.0.1.6) Gecko/20110501 Firefox/5.0.1 Firefox/5.0.1",
			"Mozilla/5.0 (Windows NT 6.1; U;WOW64; de;rv:11.0) Gecko Firefox/11.0",
			"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:11.0) Gecko Firefox/11.0",
			"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:15.0) Gecko/20120427 Firefox/15.0a1",
			"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:18.0) Gecko/20100101 Firefox/18.0",
			"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0b11pre) Gecko/20110128 Firefox/4.0b11pre",
			"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0b6pre) Gecko/20100903 Firefox/4.0b6pre",
			"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0b7) Gecko/20100101 Firefox/4.0b7",
			"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0b7) Gecko/20101111 Firefox/4.0b7",
			"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0b8pre) Gecko/20101114 Firefox/4.0b8pre",
			"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:21.0) Gecko/20100101 Firefox/21.0",
			"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:21.0) Gecko/20130330 Firefox/21.0",
			"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:21.0) Gecko/20130331 Firefox/21.0",
			"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:21.0) Gecko/20130401 Firefox/21.0",
			"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20130406 Firefox/23.0",
			"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:29.0) Gecko/20120101 Firefox/29.0",
			"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:31.0) Gecko/20130401 Firefox/31.0",
			"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:40.0) Gecko/20100101 Firefox/40.1",
			"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:6.0a2) Gecko/20110612 Firefox/6.0a2",
			"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:6.0a2) Gecko/20110613 Firefox/6.0a2",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:14.0) Gecko/20120405 Firefox/14.0a1",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:16.0.1) Gecko/20121011 Firefox/21.0.1",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b10pre) Gecko/20110118 Firefox/4.0b10pre",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b11pre) Gecko/20110128 Firefox/4.0b11pre",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b11pre) Gecko/20110129 Firefox/4.0b11pre",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b11pre) Gecko/20110131 Firefox/4.0b11pre",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b8pre) Gecko/20101114 Firefox/4.0b8pre",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b8pre) Gecko/20101128 Firefox/4.0b8pre",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b8pre) Gecko/20101213 Firefox/4.0b8pre",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b9pre) Gecko/20101228 Firefox/4.0b9pre",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.2a1pre) Gecko/20110208 Firefox/4.2a1pre",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.2a1pre) Gecko/20110323 Firefox/4.2a1pre",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.2a1pre) Gecko/20110324 Firefox/4.2a1pre",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:22.0) Gecko/20130328 Firefox/22.0",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:23.0) Gecko/20131011 Firefox/23.0",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:25.0) Gecko/20100101 Firefox/25.0",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:25.0) Gecko/20100101 Firefox/29.0",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:5.0) Gecko/20100101 Firefox/5.0",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:5.0) Gecko/20110619 Firefox/5.0",
			"Mozilla/5.0 (Windows NT 6.1; de;rv:12.0) Gecko/20120403211507 Firefox/12.0",
			"Mozilla/5.0 (Windows NT 6.1; rv:1.9) Gecko/20100101 Firefox/4.0",
			"Mozilla/5.0 (Windows NT 6.1; rv:12.0) Gecko/ 20120405 Firefox/14.0.1",
			"Mozilla/5.0 (Windows NT 6.1; rv:12.0) Gecko/20120403211507 Firefox/12.0",
			"Mozilla/5.0 (Windows NT 6.1; rv:12.0) Gecko/20120403211507 Firefox/14.0.1",
			"Mozilla/5.0 (Windows NT 6.1; rv:14.0) Gecko/20100101 Firefox/18.0.1",
			"Mozilla/5.0 (Windows NT 6.1; rv:14.0) Gecko/20120405 Firefox/14.0a1",
			"Mozilla/5.0 (Windows NT 6.1; rv:15.0) Gecko/20120716 Firefox/15.0a2",
			"Mozilla/5.0 (Windows NT 6.1; rv:2.0) Gecko/20110319 Firefox/4.0",
			"Mozilla/5.0 (Windows NT 6.1; rv:2.0b10) Gecko/20110126 Firefox/4.0b10",
			"Mozilla/5.0 (Windows NT 6.1; rv:2.0b10pre) Gecko/20110113 Firefox/4.0b10pre",
			"Mozilla/5.0 (Windows NT 6.1; rv:2.0b11pre) Gecko/20110126 Firefox/4.0b11pre",
			"Mozilla/5.0 (Windows NT 6.1; rv:2.0b6pre) Gecko/20100903 Firefox/4.0b6pre Firefox/4.0b6pre",
			"Mozilla/5.0 (Windows NT 6.1; rv:2.0b7pre) Gecko/20100921 Firefox/4.0b7pre",
			"Mozilla/5.0 (Windows NT 6.1; rv:21.0) Gecko/20100101 Firefox/21.0",
			"Mozilla/5.0 (Windows NT 6.1; rv:21.0) Gecko/20130328 Firefox/21.0",
			"Mozilla/5.0 (Windows NT 6.1; rv:21.0) Gecko/20130401 Firefox/21.0",
			"Mozilla/5.0 (Windows NT 6.1; rv:22.0) Gecko/20130405 Firefox/22.0",
			"Mozilla/5.0 (Windows NT 6.1; rv:27.3) Gecko/20130101 Firefox/27.3",
			"Mozilla/5.0 (Windows NT 6.1; rv:6.0) Gecko/20100101 Firefox/19.0",
			"Mozilla/5.0 (Windows NT 6.1; rv:6.0) Gecko/20100101 Firefox/5.0",
			"Mozilla/5.0 (Windows NT 6.1; rv:6.0) Gecko/20100101 Firefox/7.0",
			"Mozilla/5.0 (Windows NT 6.1; rv:6.0) Gecko/20110814 Firefox/6.0",
			"Mozilla/5.0 (Windows NT 6.2; WOW64; rv:15.0) Gecko/20120910144328 Firefox/15.0.2",
			"Mozilla/5.0 (Windows NT 6.2; WOW64; rv:16.0.1) Gecko/20121011 Firefox/16.0.1",
			"Mozilla/5.0 (Windows NT 6.2; WOW64; rv:21.0) Gecko/20130514 Firefox/21.0",
			"Mozilla/5.0 (Windows NT 6.2; WOW64; rv:5.0) Gecko/20100101 Firefox/5.0",
			"Mozilla/5.0 (Windows NT 6.2; Win64; x64; rv:16.0.1) Gecko/20121011 Firefox/16.0.1",
			"Mozilla/5.0 (Windows NT 6.2; Win64; x64; rv:16.0.1) Gecko/20121011 Firefox/21.0.1",
			"Mozilla/5.0 (Windows NT 6.2; Win64; x64; rv:21.0.0) Gecko/20121011 Firefox/21.0.0",
			"Mozilla/5.0 (Windows NT 6.2; Win64; x64; rv:27.0) Gecko/20121011 Firefox/27.0",
			"Mozilla/5.0 (Windows NT 6.2; Win64; x64;) Gecko/20100101 Firefox/20.0",
			"Mozilla/5.0 (Windows NT 6.2; rv:21.0) Gecko/20130326 Firefox/21.0",
			"Mozilla/5.0 (Windows NT 6.2; rv:22.0) Gecko/20130405 Firefox/22.0",
			"Mozilla/5.0 (Windows NT 6.2; rv:22.0) Gecko/20130405 Firefox/23.0",
			"Mozilla/5.0 (Windows NT 6.2; rv:9.0.1) Gecko/20100101 Firefox/9.0.1",
			"Mozilla/5.0 (Windows NT 6.3; rv:36.0) Gecko/20100101 Firefox/36.0",
			"Mozilla/5.0 (Windows x86; rv:19.0) Gecko/20100101 Firefox/19.0",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; cs; rv:1.9.2.4) Gecko/20100611 Firefox/3.6.4",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.1.16) Gecko/20120427 Firefox/15.0a1",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.2.28) Gecko/20120306 Firefox/5.0.1",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.2.3) Gecko/20100401 Mozilla/5.0 (X11; U; Linux i686; it-IT; rv:1.9.0.2) Gecko/2008092313 Ubuntu/9.25 (jaunty) Firefox/3.8",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.2b4) Gecko/20091124 Firefox/3.6b4",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:2.0.1) Gecko/20110606 Firefox/4.0.1",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; fr; rv:1.9.2b4) Gecko/20091124 Firefox/3.6b4 (.NET CLR 3.5.30729)",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; fr; rv:1.9.2b5) Gecko/20091204 Firefox/3.6b5",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; it; rv:1.9.2.6) Gecko/20100625 Firefox/3.6.6 ( .NET CLR 3.5.30729; .NET4.0E)",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; ja; rv:1.9.2a1pre) Gecko/20090402 Firefox/3.6a1pre (.NET CLR 3.5.30729)",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; ko; rv:1.9.2.4) Gecko/20100523 Firefox/3.6.4",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; nb-NO; rv:1.9.2.4) Gecko/20100611 Firefox/3.6.4 (.NET CLR 3.5.30729)",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; pt-PT; rv:1.9.2.7) Gecko/20100713 Firefox/3.6.7 (.NET CLR 3.5.30729)",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; ru; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.7 (.NET CLR 3.5.30729)",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; rv:15.0) Gecko/20121011 Firefox/15.0.1",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; tr; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8 ( .NET CLR 3.5.30729; .NET4.0E)",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; zh-CN; rv:1.9.2.4) Gecko/20100503 Firefox/3.6.4 ( .NET CLR 3.5.30729)",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; zh-CN; rv:1.9.2.4) Gecko/20100513 Firefox/3.6.4 (.NET CLR 3.5.30729)",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; zh-CN; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; zh-TW; rv:1.9.2.4) Gecko/20100611 Firefox/3.6.4 GTB7.0 ( .NET CLR 3.5.30729)",
			"Mozilla/5.0 (Windows; U; Windows NT 5.2; en-CA; rv:1.9.2.4) Gecko/20100523 Firefox/3.6.4",
			"Mozilla/5.0 (Windows; U; Windows NT 5.2; en-GB; rv:1.9.2.9) Gecko/20100824 Firefox/3.6.9",
			"Mozilla/5.0 (Windows; U; Windows NT 5.2; zh-TW; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8",
			"Mozilla/5.0 (Windows; U; Windows NT 6.0; en-GB; rv:1.9.2.9) Gecko/20100824 Firefox/3.6.9 ( .NET CLR 3.5.30729; .NET CLR 4.0.20506)",
			"Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.2.4) Gecko/20100513 Firefox/3.6.4 (.NET CLR 3.5.30729)",
			"Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.2.4) Gecko/20100523 Firefox/3.6.4 ( .NET CLR 3.5.30729)",
			"Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.2.4) Gecko/20100527 Firefox/3.6.4",
			"Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.2.4) Gecko/20100527 Firefox/3.6.4 (.NET CLR 3.5.30729)",
			"Mozilla/5.0 (Windows; U; Windows NT 6.0; fr; rv:1.9.2.4) Gecko/20100523 Firefox/3.6.4 ( .NET CLR 3.5.30729)",
			"Mozilla/5.0 (Windows; U; Windows NT 6.0; ja; rv:1.9.2.4) Gecko/20100513 Firefox/3.6.4 ( .NET CLR 3.5.30729)",
			"Mozilla/5.0 (Windows; U; Windows NT 6.0; nl; rv:1.9.2.6) Gecko/20100625 Firefox/3.6.6",
			"Mozilla/5.0 (Windows; U; Windows NT 6.0; zh-CN; rv:1.9.2.4) Gecko/20100513 Firefox/3.6.4",
			"Mozilla/5.0 (Windows; U; Windows NT 6.0; zh-CN; rv:1.9.2.6) Gecko/20100625 Firefox/3.6.6 GTB7.1",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; WOW64; en-US; rv:2.0.4) Gecko/20120718 AskTbAVR-IDW/3.12.5.17700 Firefox/14.0.1",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; cs; rv:1.9.2.4) Gecko/20100513 Firefox/3.6.4 (.NET CLR 3.5.30729)",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; de; rv:1.9.2.3) Gecko/20121221 Firefox/3.6.8",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; de; rv:1.9.2.8) Gecko/20100722 Firefox 3.6.8",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; en-GB; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8 ( .NET CLR 3.5.30729; .NET4.0C)",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2.6) Gecko/20100625 Firefox/3.6.6 (.NET CLR 3.5.30729)",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2b1) Gecko/20091014 Firefox/3.6b1 GTB5",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2b5) Gecko/20091204 Firefox/3.6b5",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:2.0b10) Gecko/20110126 Firefox/4.0b10",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; fr; rv:1.9.2.8) Gecko/20100722 Firefox 3.6.8 GTB7.1",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; he; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; hu; rv:1.9.2.7) Gecko/20100713 Firefox/3.6.7 GTB7.1",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; it; rv:1.9.2.6) Gecko/20100625 Firefox/3.6.6 ( .NET CLR 3.5.30729)",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; it; rv:1.9.2.8) Gecko/20100722 AskTbADAP/3.9.1.14019 Firefox/3.6.8",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; ja; rv:1.9.2.4) Gecko/20100611 Firefox/3.6.4 GTB7.1",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; pt-BR; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8 GTB7.1",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; pt-PT; rv:1.9.2.6) Gecko/20100625 Firefox/3.6.6",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.3) Gecko/20100401 Firefox/4.0 (.NET CLR 3.5.30729)",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.4) Gecko/20100513 Firefox/3.6.4",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2b5) Gecko/20091204 Firefox/3.6b5",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; rv:1.9.2.9) Gecko/20100913 Firefox/3.6.9",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; zh-CN; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; zh-TW; rv:1.9.2.4) Gecko/20100611 Firefox/3.6.4 ( .NET CLR 3.5.30729)",
			"Mozilla/5.0 (Windows; Windows NT 5.1; en-US; rv:1.9.2a1pre) Gecko/20090402 Firefox/3.6a1pre",
			"Mozilla/5.0 (Windows; Windows NT 5.1; es-ES; rv:1.9.2a1pre) Gecko/20090402 Firefox/3.6a1pre",
			"Mozilla/5.0 (X11; Arch Linux i686; rv:2.0) Gecko/20110321 Firefox/4.0",
			"Mozilla/5.0 (X11; FreeBSD amd64; rv:5.0) Gecko/20100101 Firefox/5.0",
			"Mozilla/5.0 (X11; Linux AMD64) Gecko Firefox/5.0",
			"Mozilla/5.0 (X11; Linux i586; rv:31.0) Gecko/20100101 Firefox/31.0",
			"Mozilla/5.0 (X11; Linux i686 on x86_64; rv:5.0a2) Gecko/20110524 Firefox/5.0a2",
			"Mozilla/5.0 (X11; Linux i686; rv:2.0.1) Gecko/20110518 Firefox/4.0.1",
			"Mozilla/5.0 (X11; Linux i686; rv:2.0b10) Gecko/20100101 Firefox/4.0b10",
			"Mozilla/5.0 (X11; Linux i686; rv:2.0b12pre) Gecko/20100101 Firefox/4.0b12pre",
			"Mozilla/5.0 (X11; Linux i686; rv:2.0b12pre) Gecko/20110204 Firefox/4.0b12pre",
			"Mozilla/5.0 (X11; Linux i686; rv:2.0b3pre) Gecko/20100731 Firefox/4.0b3pre",
			"Mozilla/5.0 (X11; Linux i686; rv:21.0) Gecko/20100101 Firefox/21.0",
			"Mozilla/5.0 (X11; Linux i686; rv:6.0) Gecko/20100101 Firefox/6.0",
			"Mozilla/5.0 (X11; Linux ppc; rv:5.0) Gecko/20100101 Firefox/5.0",
			"Mozilla/5.0 (X11; Linux x86_64) Gecko Firefox/5.0",
			"Mozilla/5.0 (X11; Linux x86_64; rv:2.0.1) Gecko/20110506 Firefox/4.0.1",
			"Mozilla/5.0 (X11; Linux x86_64; rv:2.0b4) Gecko/20100818 Firefox/4.0b4",
			"Mozilla/5.0 (X11; Linux x86_64; rv:2.0b9pre) Gecko/20110111 Firefox/4.0b9pre",
			"Mozilla/5.0 (X11; Linux x86_64; rv:2.2a1pre) Gecko/20100101 Firefox/4.2a1pre",
			"Mozilla/5.0 (X11; Linux x86_64; rv:2.2a1pre) Gecko/20110324 Firefox/4.2a1pre",
			"Mozilla/5.0 (X11; Linux x86_64; rv:28.0) Gecko/20100101 Firefox/28.0",
			"Mozilla/5.0 (X11; Linux x86_64; rv:5.0) Gecko/20100101 Firefox/5.0 FirePHP/0.5",
			"Mozilla/5.0 (X11; Linux x86_64; rv:5.0) Gecko/20100101 Firefox/5.0 Firefox/5.0",
			"Mozilla/5.0 (X11; Linux) Gecko Firefox/5.0",
			"Mozilla/5.0 (X11; Mageia; Linux x86_64; rv:10.0.9) Gecko/20100101 Firefox/10.0.9",
			"Mozilla/5.0 (X11; NetBSD amd64; rv:16.0) Gecko/20121102 Firefox/16.0",
			"Mozilla/5.0 (X11; OpenBSD amd64; rv:28.0) Gecko/20100101 Firefox/28.0",
			"Mozilla/5.0 (X11; U; FreeBSD i386; de-CH; rv:1.9.2.8) Gecko/20100729 Firefox/3.6.8",
			"Mozilla/5.0 (X11; U; FreeBSD i386; en-US; rv:1.9.2.9) Gecko/20100913 Firefox/3.6.9",
			"Mozilla/5.0 (X11; U; Linux amd64; en-US; rv:5.0) Gecko/20110619 Firefox/5.0",
			"Mozilla/5.0 (X11; U; Linux amd64; rv:5.0) Gecko/20100101 Firefox/5.0 (Debian)",
			"Mozilla/5.0 (X11; U; Linux i586; de; rv:5.0) Gecko/20100101 Firefox/5.0",
			"Mozilla/5.0 (X11; U; Linux i686; de-DE; rv:1.9.2.8) Gecko/20100725 Gentoo Firefox/3.6.8",
			"Mozilla/5.0 (X11; U; Linux i686; en-GB; rv:2.0) Gecko/20110404 Fedora/16-dev Firefox/4.0",
			"Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.1.16) Gecko/20120421 Firefox/11.0",
			"Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.1.16) Gecko/20120421 Gecko Firefox/11.0",
			"Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2.4) Gecko/20100625 Gentoo Firefox/3.6.4",
			"Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2.7) Gecko/20100726 CentOS/3.6-3.el5.centos Firefox/3.6.7",
			"Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2.8) Gecko/20100727 Firefox/3.6.8",
			"Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2.9) Gecko/20100827 Red Hat/3.6.9-2.el6 Firefox/3.6.9",
			"Mozilla/5.0 (X11; U; Linux i686; fa; rv:1.8.1.4) Gecko/20100527 Firefox/3.6.4",
			"Mozilla/5.0 (X11; U; Linux i686; fi-FI; rv:1.9.2.8) Gecko/20100723 Ubuntu/10.04 (lucid) Firefox/3.6.8",
			"Mozilla/5.0 (X11; U; Linux i686; it-IT; rv:1.9.0.2) Gecko/2008092313 Ubuntu/9.25 (jaunty) Firefox/3.8",
			"Mozilla/5.0 (X11; U; Linux i686; pl-PL; rv:1.9.0.2) Gecko/2008092313 Ubuntu/9.25 (jaunty) Firefox/3.8",
			"Mozilla/5.0 (X11; U; Linux i686; pl-PL; rv:1.9.0.2) Gecko/20121223 Ubuntu/9.25 (jaunty) Firefox/3.8",
			"Mozilla/5.0 (X11; U; Linux i686; ru-RU; rv:1.9.2a1pre) Gecko/20090405 Ubuntu/9.04 (jaunty) Firefox/3.6a1pre",
			"Mozilla/5.0 (X11; U; Linux i686; ru; rv:1.9.1.3) Gecko/20091020 Ubuntu/10.04 (lucid) Firefox/4.0.1",
			"Mozilla/5.0 (X11; U; Linux i686; ru; rv:1.9.2.8) Gecko/20100723 Ubuntu/10.04 (lucid) Firefox/3.6.8",
			"Mozilla/5.0 (X11; U; Linux i686; ru; rv:1.9.3a5pre) Gecko/20100526 Firefox/3.7a5pre",
			"Mozilla/5.0 (X11; U; Linux i686; zh-CN; rv:1.9.2.8) Gecko/20100722 Ubuntu/10.04 (lucid) Firefox/3.6.8",
			"Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.4) Gecko/20100614 Ubuntu/10.04 (lucid) Firefox/3.6.4",
			"Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.6) Gecko/20100628 Ubuntu/10.04 (lucid) Firefox/3.6.6",
			"Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.6) Gecko/20100628 Ubuntu/10.04 (lucid) Firefox/3.6.6 (.NET CLR 3.5.30729)",
			"Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.6) Gecko/20100628 Ubuntu/10.04 (lucid) Firefox/3.6.6 GTB7.0",
			"Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.6) Gecko/20100628 Ubuntu/10.04 (lucid) Firefox/3.6.6 GTB7.1",
			"Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.7) Gecko/20100723 Fedora/3.6.7-1.fc13 Firefox/3.6.7",
			"Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.7) Gecko/20100809 Fedora/3.6.7-1.fc14 Firefox/3.6.7",
			"Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.8) Gecko/20100723 SUSE/3.6.8-0.1.1 Firefox/3.6.8",
			"Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.8) Gecko/20100804 Gentoo Firefox/3.6.8",
			"Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.9) Gecko/20100915 Gentoo Firefox/3.6.9",
			"Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2a1pre) Gecko/20090405 Firefox/3.6a1pre",
			"Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2a1pre) Gecko/20090428 Firefox/3.6a1pre",
			"Mozilla/5.0 (X11; U; Linux x86_64; pl-PL; rv:2.0) Gecko/20110307 Firefox/4.0",
			"Mozilla/5.0 (X11; U; OpenBSD i386; en-US; rv:1.9.2.8) Gecko/20101230 Firefox/3.6.8",
			"Mozilla/5.0 (X11; Ubuntu; Linux armv7l; rv:17.0) Gecko/20100101 Firefox/17.0",
			"Mozilla/5.0 (X11; Ubuntu; Linux i686; rv:14.0) Gecko/20100101 Firefox/14.0.1",
			"Mozilla/5.0 (X11; Ubuntu; Linux i686; rv:15.0) Gecko/20100101 Firefox/15.0.1",
			"Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:14.0) Gecko/20100101 Firefox/14.0.1",
			"Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:17.0) Gecko/20100101 Firefox/17.0.6",
			"Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:21.0) Gecko/20100101 Firefox/21.0",
			"Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:21.0) Gecko/20130331 Firefox/21.0",
			"Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:24.0) Gecko/20100101 Firefox/24.0",
			"Mozilla/5.0 (compatible; Windows; U; Windows NT 6.2; WOW64; en-US; rv:12.0) Gecko/20120403211507 Firefox/12.0",
			"Mozilla/6.0 (Macintosh; I; Intel Mac OS X 11_7_9; de-LI; rv:1.9b4) Gecko/2012010317 Firefox/10.0a4",
			"Mozilla/6.0 (Windows NT 6.2; WOW64; rv:16.0.1) Gecko/20121011 Firefox/16.0.1",
			"Mozilla/3.0 (Windows NT 6.1; rv:2.0.1) Gecko/20100101 Firefox/5.0.1"
		};
		this.string_3 = new string[0];
		this.object_0 = RuntimeHelpers.GetObjectValue(new object());
		this.random_0 = new Random();
		this.string_6 = "YES";
		this.string_8 = "d";
		this.string_9 = "[a-zA-Z0-9._%+-]+@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}:(?:[a-zA-Z0-9]{5,})";
		this.cookieContainer_0 = new CookieContainer();
		this.int_6 = 0;
		this.int_7 = 0;
		this.string_10 = new string[]
		{
			"com",
			"ac",
			"fr",
			"tn",
			"ru"
		};
		this.string_11 = new string[]
		{
			"Mozilla/4.0 (compatible; Intel Mac OS X 10.6; rv:2.0b8) Gecko/20100101 Firefox/4.0b8)",
			"Mozilla/5.0 (Macintosh; I; Intel Mac OS X 11_7_9; de-LI; rv:1.9b4) Gecko/2012010317 Firefox/10.0a4",
			"Mozilla/5.0 (Macintosh; Intel Mac OS X 10.6; rv:2.0b11pre) Gecko/20110126 Firefox/4.0b11pre",
			"Mozilla/5.0 (Macintosh; Intel Mac OS X 10.6; rv:2.0b8) Gecko/20100101 Firefox/4.0b8",
			"Mozilla/5.0 (Macintosh; Intel Mac OS X 10.6; rv:25.0) Gecko/20100101 Firefox/25.0",
			"Mozilla/5.0 (Macintosh; Intel Mac OS X 10.6; rv:9.0) Gecko/20100101 Firefox/9.0",
			"Mozilla/5.0 (Macintosh; Intel Mac OS X 10.6; rv:9.0a2) Gecko/20111101 Firefox/9.0a2",
			"Mozilla/5.0 (Macintosh; Intel Mac OS X 10.8; rv:21.0) Gecko/20100101 Firefox/21.0",
			"Mozilla/5.0 (Macintosh; Intel Mac OS X 10.8; rv:24.0) Gecko/20100101 Firefox/24.0",
			"Mozilla/5.0 (Macintosh; Intel Mac OS X 10_10; rv:33.0) Gecko/20100101 Firefox/33.0",
			"Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10.5; en-US; rv:1.9.2.4) Gecko/20100527 Firefox/3.6.4",
			"Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10.6; en-US; rv:1.9.2) Gecko/20091218 Firefox 3.6b5",
			"Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10.6;en-US; rv:1.9.2.9) Gecko/20100824 Firefox/3.6.9",
			"Mozilla/5.0 (Macintosh; U; Intel Mac OS X; de-AT; rv:1.9.1.8) Gecko/20100625 Firefox/3.6.6",
			"Mozilla/5.0 (Macintosh; U; PPC Mac OS X 10.5; en-US; rv:1.9.2.4) Gecko/20100611 Firefox/3.6.4 GTB7.0",
			"Mozilla/5.0 (Microsoft Windows NT 6.2.9200.0); rv:22.0) Gecko/20130405 Firefox/22.0",
			"Mozilla/5.0 (Windows NT 5.0; WOW64; rv:5.0) Gecko/20100101 Firefox/5.0",
			"Mozilla/5.0 (Windows NT 5.0; WOW64; rv:6.0) Gecko/20100101 Firefox/6.0",
			"Mozilla/5.0 (Windows NT 5.0; rv:21.0) Gecko/20100101 Firefox/21.0",
			"Mozilla/5.0 (Windows NT 5.0; rv:5.0) Gecko/20100101 Firefox/5.0",
			"Mozilla/5.0 (Windows NT 5.1; U; rv:5.0) Gecko/20100101 Firefox/5.0",
			"Mozilla/5.0 (Windows NT 5.1; rv:11.0) Gecko Firefox/11.0",
			"Mozilla/5.0 (Windows NT 5.1; rv:12.0) Gecko/20120403211507 Firefox/12.0",
			"Mozilla/5.0 (Windows NT 5.1; rv:14.0) Gecko/20120405 Firefox/14.0a1",
			"Mozilla/5.0 (Windows NT 5.1; rv:15.0) Gecko/20100101 Firefox/13.0.1",
			"Mozilla/5.0 (Windows NT 5.1; rv:2.0.1) Gecko/20100101 Firefox/5.0",
			"Mozilla/5.0 (Windows NT 5.1; rv:2.0b13pre) Gecko/20110223 Firefox/4.0b13pre",
			"Mozilla/5.0 (Windows NT 5.1; rv:2.0b8pre) Gecko/20101127 Firefox/4.0b8pre",
			"Mozilla/5.0 (Windows NT 5.1; rv:2.0b9pre) Gecko/20110105 Firefox/4.0b9pre",
			"Mozilla/5.0 (Windows NT 5.1; rv:21.0) Gecko/20100101 Firefox/21.0",
			"Mozilla/5.0 (Windows NT 5.1; rv:21.0) Gecko/20130331 Firefox/21.0",
			"Mozilla/5.0 (Windows NT 5.1; rv:21.0) Gecko/20130401 Firefox/21.0",
			"Mozilla/5.0 (Windows NT 5.1; rv:31.0) Gecko/20100101 Firefox/31.0",
			"Mozilla/5.0 (Windows NT 5.1; rv:6.0) Gecko/20100101 Firefox/6.0 FirePHP/0.6",
			"Mozilla/5.0 (Windows NT 5.1; rv:8.0; en_us) Gecko/20100101 Firefox/8.0",
			"Mozilla/5.0 (Windows NT 5.2; WOW64; rv:5.0) Gecko/20100101 Firefox/5.0",
			"Mozilla/5.0 (Windows NT 5.2; rv:2.0b13pre) Gecko/20110304 Firefox/4.0b13pre",
			"Mozilla/5.0 (Windows NT 6.0; WOW64; rv:24.0) Gecko/20100101 Firefox/24.0",
			"Mozilla/5.0 (Windows NT 6.0; rv:14.0) Gecko/20100101 Firefox/14.0.1",
			"Mozilla/5.0 (Windows NT 6.1.1; rv:5.0) Gecko/20100101 Firefox/5.0",
			"Mozilla/5.0 (Windows NT 6.1; U; ru; rv:5.0.1.6) Gecko/20110501 Firefox/5.0.1 Firefox/5.0.1",
			"Mozilla/5.0 (Windows NT 6.1; U;WOW64; de;rv:11.0) Gecko Firefox/11.0",
			"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:11.0) Gecko Firefox/11.0",
			"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:15.0) Gecko/20120427 Firefox/15.0a1",
			"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:18.0) Gecko/20100101 Firefox/18.0",
			"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0b11pre) Gecko/20110128 Firefox/4.0b11pre",
			"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0b6pre) Gecko/20100903 Firefox/4.0b6pre",
			"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0b7) Gecko/20100101 Firefox/4.0b7",
			"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0b7) Gecko/20101111 Firefox/4.0b7",
			"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0b8pre) Gecko/20101114 Firefox/4.0b8pre",
			"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:21.0) Gecko/20100101 Firefox/21.0",
			"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:21.0) Gecko/20130330 Firefox/21.0",
			"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:21.0) Gecko/20130331 Firefox/21.0",
			"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:21.0) Gecko/20130401 Firefox/21.0",
			"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20130406 Firefox/23.0",
			"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:29.0) Gecko/20120101 Firefox/29.0",
			"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:31.0) Gecko/20130401 Firefox/31.0",
			"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:40.0) Gecko/20100101 Firefox/40.1",
			"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:6.0a2) Gecko/20110612 Firefox/6.0a2",
			"Mozilla/5.0 (Windows NT 6.1; WOW64; rv:6.0a2) Gecko/20110613 Firefox/6.0a2",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:14.0) Gecko/20120405 Firefox/14.0a1",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:16.0.1) Gecko/20121011 Firefox/21.0.1",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b10pre) Gecko/20110118 Firefox/4.0b10pre",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b11pre) Gecko/20110128 Firefox/4.0b11pre",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b11pre) Gecko/20110129 Firefox/4.0b11pre",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b11pre) Gecko/20110131 Firefox/4.0b11pre",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b8pre) Gecko/20101114 Firefox/4.0b8pre",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b8pre) Gecko/20101128 Firefox/4.0b8pre",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b8pre) Gecko/20101213 Firefox/4.0b8pre",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.0b9pre) Gecko/20101228 Firefox/4.0b9pre",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.2a1pre) Gecko/20110208 Firefox/4.2a1pre",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.2a1pre) Gecko/20110323 Firefox/4.2a1pre",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:2.2a1pre) Gecko/20110324 Firefox/4.2a1pre",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:22.0) Gecko/20130328 Firefox/22.0",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:23.0) Gecko/20131011 Firefox/23.0",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:25.0) Gecko/20100101 Firefox/25.0",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:25.0) Gecko/20100101 Firefox/29.0",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:5.0) Gecko/20100101 Firefox/5.0",
			"Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:5.0) Gecko/20110619 Firefox/5.0",
			"Mozilla/5.0 (Windows NT 6.1; de;rv:12.0) Gecko/20120403211507 Firefox/12.0",
			"Mozilla/5.0 (Windows NT 6.1; rv:1.9) Gecko/20100101 Firefox/4.0",
			"Mozilla/5.0 (Windows NT 6.1; rv:12.0) Gecko/ 20120405 Firefox/14.0.1",
			"Mozilla/5.0 (Windows NT 6.1; rv:12.0) Gecko/20120403211507 Firefox/12.0",
			"Mozilla/5.0 (Windows NT 6.1; rv:12.0) Gecko/20120403211507 Firefox/14.0.1",
			"Mozilla/5.0 (Windows NT 6.1; rv:14.0) Gecko/20100101 Firefox/18.0.1",
			"Mozilla/5.0 (Windows NT 6.1; rv:14.0) Gecko/20120405 Firefox/14.0a1",
			"Mozilla/5.0 (Windows NT 6.1; rv:15.0) Gecko/20120716 Firefox/15.0a2",
			"Mozilla/5.0 (Windows NT 6.1; rv:2.0) Gecko/20110319 Firefox/4.0",
			"Mozilla/5.0 (Windows NT 6.1; rv:2.0b10) Gecko/20110126 Firefox/4.0b10",
			"Mozilla/5.0 (Windows NT 6.1; rv:2.0b10pre) Gecko/20110113 Firefox/4.0b10pre",
			"Mozilla/5.0 (Windows NT 6.1; rv:2.0b11pre) Gecko/20110126 Firefox/4.0b11pre",
			"Mozilla/5.0 (Windows NT 6.1; rv:2.0b6pre) Gecko/20100903 Firefox/4.0b6pre Firefox/4.0b6pre",
			"Mozilla/5.0 (Windows NT 6.1; rv:2.0b7pre) Gecko/20100921 Firefox/4.0b7pre",
			"Mozilla/5.0 (Windows NT 6.1; rv:21.0) Gecko/20100101 Firefox/21.0",
			"Mozilla/5.0 (Windows NT 6.1; rv:21.0) Gecko/20130328 Firefox/21.0",
			"Mozilla/5.0 (Windows NT 6.1; rv:21.0) Gecko/20130401 Firefox/21.0",
			"Mozilla/5.0 (Windows NT 6.1; rv:22.0) Gecko/20130405 Firefox/22.0",
			"Mozilla/5.0 (Windows NT 6.1; rv:27.3) Gecko/20130101 Firefox/27.3",
			"Mozilla/5.0 (Windows NT 6.1; rv:6.0) Gecko/20100101 Firefox/19.0",
			"Mozilla/5.0 (Windows NT 6.1; rv:6.0) Gecko/20100101 Firefox/5.0",
			"Mozilla/5.0 (Windows NT 6.1; rv:6.0) Gecko/20100101 Firefox/7.0",
			"Mozilla/5.0 (Windows NT 6.1; rv:6.0) Gecko/20110814 Firefox/6.0",
			"Mozilla/5.0 (Windows NT 6.2; WOW64; rv:15.0) Gecko/20120910144328 Firefox/15.0.2",
			"Mozilla/5.0 (Windows NT 6.2; WOW64; rv:16.0.1) Gecko/20121011 Firefox/16.0.1",
			"Mozilla/5.0 (Windows NT 6.2; WOW64; rv:21.0) Gecko/20130514 Firefox/21.0",
			"Mozilla/5.0 (Windows NT 6.2; WOW64; rv:5.0) Gecko/20100101 Firefox/5.0",
			"Mozilla/5.0 (Windows NT 6.2; Win64; x64; rv:16.0.1) Gecko/20121011 Firefox/16.0.1",
			"Mozilla/5.0 (Windows NT 6.2; Win64; x64; rv:16.0.1) Gecko/20121011 Firefox/21.0.1",
			"Mozilla/5.0 (Windows NT 6.2; Win64; x64; rv:21.0.0) Gecko/20121011 Firefox/21.0.0",
			"Mozilla/5.0 (Windows NT 6.2; Win64; x64; rv:27.0) Gecko/20121011 Firefox/27.0",
			"Mozilla/5.0 (Windows NT 6.2; Win64; x64;) Gecko/20100101 Firefox/20.0",
			"Mozilla/5.0 (Windows NT 6.2; rv:21.0) Gecko/20130326 Firefox/21.0",
			"Mozilla/5.0 (Windows NT 6.2; rv:22.0) Gecko/20130405 Firefox/22.0",
			"Mozilla/5.0 (Windows NT 6.2; rv:22.0) Gecko/20130405 Firefox/23.0",
			"Mozilla/5.0 (Windows NT 6.2; rv:9.0.1) Gecko/20100101 Firefox/9.0.1",
			"Mozilla/5.0 (Windows NT 6.3; rv:36.0) Gecko/20100101 Firefox/36.0",
			"Mozilla/5.0 (Windows x86; rv:19.0) Gecko/20100101 Firefox/19.0",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; cs; rv:1.9.2.4) Gecko/20100611 Firefox/3.6.4",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.1.16) Gecko/20120427 Firefox/15.0a1",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.2.28) Gecko/20120306 Firefox/5.0.1",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.2.3) Gecko/20100401 Mozilla/5.0 (X11; U; Linux i686; it-IT; rv:1.9.0.2) Gecko/2008092313 Ubuntu/9.25 (jaunty) Firefox/3.8",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.9.2b4) Gecko/20091124 Firefox/3.6b4",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:2.0.1) Gecko/20110606 Firefox/4.0.1",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; fr; rv:1.9.2b4) Gecko/20091124 Firefox/3.6b4 (.NET CLR 3.5.30729)",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; fr; rv:1.9.2b5) Gecko/20091204 Firefox/3.6b5",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; it; rv:1.9.2.6) Gecko/20100625 Firefox/3.6.6 ( .NET CLR 3.5.30729; .NET4.0E)",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; ja; rv:1.9.2a1pre) Gecko/20090402 Firefox/3.6a1pre (.NET CLR 3.5.30729)",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; ko; rv:1.9.2.4) Gecko/20100523 Firefox/3.6.4",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; nb-NO; rv:1.9.2.4) Gecko/20100611 Firefox/3.6.4 (.NET CLR 3.5.30729)",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; pt-PT; rv:1.9.2.7) Gecko/20100713 Firefox/3.6.7 (.NET CLR 3.5.30729)",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; ru; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.7 (.NET CLR 3.5.30729)",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; rv:15.0) Gecko/20121011 Firefox/15.0.1",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; tr; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8 ( .NET CLR 3.5.30729; .NET4.0E)",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; zh-CN; rv:1.9.2.4) Gecko/20100503 Firefox/3.6.4 ( .NET CLR 3.5.30729)",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; zh-CN; rv:1.9.2.4) Gecko/20100513 Firefox/3.6.4 (.NET CLR 3.5.30729)",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; zh-CN; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8",
			"Mozilla/5.0 (Windows; U; Windows NT 5.1; zh-TW; rv:1.9.2.4) Gecko/20100611 Firefox/3.6.4 GTB7.0 ( .NET CLR 3.5.30729)",
			"Mozilla/5.0 (Windows; U; Windows NT 5.2; en-CA; rv:1.9.2.4) Gecko/20100523 Firefox/3.6.4",
			"Mozilla/5.0 (Windows; U; Windows NT 5.2; en-GB; rv:1.9.2.9) Gecko/20100824 Firefox/3.6.9",
			"Mozilla/5.0 (Windows; U; Windows NT 5.2; zh-TW; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8",
			"Mozilla/5.0 (Windows; U; Windows NT 6.0; en-GB; rv:1.9.2.9) Gecko/20100824 Firefox/3.6.9 ( .NET CLR 3.5.30729; .NET CLR 4.0.20506)",
			"Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.2.4) Gecko/20100513 Firefox/3.6.4 (.NET CLR 3.5.30729)",
			"Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.2.4) Gecko/20100523 Firefox/3.6.4 ( .NET CLR 3.5.30729)",
			"Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.2.4) Gecko/20100527 Firefox/3.6.4",
			"Mozilla/5.0 (Windows; U; Windows NT 6.0; en-US; rv:1.9.2.4) Gecko/20100527 Firefox/3.6.4 (.NET CLR 3.5.30729)",
			"Mozilla/5.0 (Windows; U; Windows NT 6.0; fr; rv:1.9.2.4) Gecko/20100523 Firefox/3.6.4 ( .NET CLR 3.5.30729)",
			"Mozilla/5.0 (Windows; U; Windows NT 6.0; ja; rv:1.9.2.4) Gecko/20100513 Firefox/3.6.4 ( .NET CLR 3.5.30729)",
			"Mozilla/5.0 (Windows; U; Windows NT 6.0; nl; rv:1.9.2.6) Gecko/20100625 Firefox/3.6.6",
			"Mozilla/5.0 (Windows; U; Windows NT 6.0; zh-CN; rv:1.9.2.4) Gecko/20100513 Firefox/3.6.4",
			"Mozilla/5.0 (Windows; U; Windows NT 6.0; zh-CN; rv:1.9.2.6) Gecko/20100625 Firefox/3.6.6 GTB7.1",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; WOW64; en-US; rv:2.0.4) Gecko/20120718 AskTbAVR-IDW/3.12.5.17700 Firefox/14.0.1",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; cs; rv:1.9.2.4) Gecko/20100513 Firefox/3.6.4 (.NET CLR 3.5.30729)",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; de; rv:1.9.2.3) Gecko/20121221 Firefox/3.6.8",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; de; rv:1.9.2.8) Gecko/20100722 Firefox 3.6.8",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; en-GB; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8 ( .NET CLR 3.5.30729; .NET4.0C)",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2.6) Gecko/20100625 Firefox/3.6.6 (.NET CLR 3.5.30729)",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2b1) Gecko/20091014 Firefox/3.6b1 GTB5",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2b5) Gecko/20091204 Firefox/3.6b5",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:2.0b10) Gecko/20110126 Firefox/4.0b10",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; fr; rv:1.9.2.8) Gecko/20100722 Firefox 3.6.8 GTB7.1",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; he; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; hu; rv:1.9.2.7) Gecko/20100713 Firefox/3.6.7 GTB7.1",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; it; rv:1.9.2.6) Gecko/20100625 Firefox/3.6.6 ( .NET CLR 3.5.30729)",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; it; rv:1.9.2.8) Gecko/20100722 AskTbADAP/3.9.1.14019 Firefox/3.6.8",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; ja; rv:1.9.2.4) Gecko/20100611 Firefox/3.6.4 GTB7.1",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; pt-BR; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8 GTB7.1",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; pt-PT; rv:1.9.2.6) Gecko/20100625 Firefox/3.6.6",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.3) Gecko/20100401 Firefox/4.0 (.NET CLR 3.5.30729)",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.4) Gecko/20100513 Firefox/3.6.4",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2b5) Gecko/20091204 Firefox/3.6b5",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; rv:1.9.2.9) Gecko/20100913 Firefox/3.6.9",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; zh-CN; rv:1.9.2.8) Gecko/20100722 Firefox/3.6.8",
			"Mozilla/5.0 (Windows; U; Windows NT 6.1; zh-TW; rv:1.9.2.4) Gecko/20100611 Firefox/3.6.4 ( .NET CLR 3.5.30729)",
			"Mozilla/5.0 (Windows; Windows NT 5.1; en-US; rv:1.9.2a1pre) Gecko/20090402 Firefox/3.6a1pre",
			"Mozilla/5.0 (Windows; Windows NT 5.1; es-ES; rv:1.9.2a1pre) Gecko/20090402 Firefox/3.6a1pre",
			"Mozilla/5.0 (X11; Arch Linux i686; rv:2.0) Gecko/20110321 Firefox/4.0",
			"Mozilla/5.0 (X11; FreeBSD amd64; rv:5.0) Gecko/20100101 Firefox/5.0",
			"Mozilla/5.0 (X11; Linux AMD64) Gecko Firefox/5.0",
			"Mozilla/5.0 (X11; Linux i586; rv:31.0) Gecko/20100101 Firefox/31.0",
			"Mozilla/5.0 (X11; Linux i686 on x86_64; rv:5.0a2) Gecko/20110524 Firefox/5.0a2",
			"Mozilla/5.0 (X11; Linux i686; rv:2.0.1) Gecko/20110518 Firefox/4.0.1",
			"Mozilla/5.0 (X11; Linux i686; rv:2.0b10) Gecko/20100101 Firefox/4.0b10",
			"Mozilla/5.0 (X11; Linux i686; rv:2.0b12pre) Gecko/20100101 Firefox/4.0b12pre",
			"Mozilla/5.0 (X11; Linux i686; rv:2.0b12pre) Gecko/20110204 Firefox/4.0b12pre",
			"Mozilla/5.0 (X11; Linux i686; rv:2.0b3pre) Gecko/20100731 Firefox/4.0b3pre",
			"Mozilla/5.0 (X11; Linux i686; rv:21.0) Gecko/20100101 Firefox/21.0",
			"Mozilla/5.0 (X11; Linux i686; rv:6.0) Gecko/20100101 Firefox/6.0",
			"Mozilla/5.0 (X11; Linux ppc; rv:5.0) Gecko/20100101 Firefox/5.0",
			"Mozilla/5.0 (X11; Linux x86_64) Gecko Firefox/5.0",
			"Mozilla/5.0 (X11; Linux x86_64; rv:2.0.1) Gecko/20110506 Firefox/4.0.1",
			"Mozilla/5.0 (X11; Linux x86_64; rv:2.0b4) Gecko/20100818 Firefox/4.0b4",
			"Mozilla/5.0 (X11; Linux x86_64; rv:2.0b9pre) Gecko/20110111 Firefox/4.0b9pre",
			"Mozilla/5.0 (X11; Linux x86_64; rv:2.2a1pre) Gecko/20100101 Firefox/4.2a1pre",
			"Mozilla/5.0 (X11; Linux x86_64; rv:2.2a1pre) Gecko/20110324 Firefox/4.2a1pre",
			"Mozilla/5.0 (X11; Linux x86_64; rv:28.0) Gecko/20100101 Firefox/28.0",
			"Mozilla/5.0 (X11; Linux x86_64; rv:5.0) Gecko/20100101 Firefox/5.0 FirePHP/0.5",
			"Mozilla/5.0 (X11; Linux x86_64; rv:5.0) Gecko/20100101 Firefox/5.0 Firefox/5.0",
			"Mozilla/5.0 (X11; Linux) Gecko Firefox/5.0",
			"Mozilla/5.0 (X11; Mageia; Linux x86_64; rv:10.0.9) Gecko/20100101 Firefox/10.0.9",
			"Mozilla/5.0 (X11; NetBSD amd64; rv:16.0) Gecko/20121102 Firefox/16.0",
			"Mozilla/5.0 (X11; OpenBSD amd64; rv:28.0) Gecko/20100101 Firefox/28.0",
			"Mozilla/5.0 (X11; U; FreeBSD i386; de-CH; rv:1.9.2.8) Gecko/20100729 Firefox/3.6.8",
			"Mozilla/5.0 (X11; U; FreeBSD i386; en-US; rv:1.9.2.9) Gecko/20100913 Firefox/3.6.9",
			"Mozilla/5.0 (X11; U; Linux amd64; en-US; rv:5.0) Gecko/20110619 Firefox/5.0",
			"Mozilla/5.0 (X11; U; Linux amd64; rv:5.0) Gecko/20100101 Firefox/5.0 (Debian)",
			"Mozilla/5.0 (X11; U; Linux i586; de; rv:5.0) Gecko/20100101 Firefox/5.0",
			"Mozilla/5.0 (X11; U; Linux i686; de-DE; rv:1.9.2.8) Gecko/20100725 Gentoo Firefox/3.6.8",
			"Mozilla/5.0 (X11; U; Linux i686; en-GB; rv:2.0) Gecko/20110404 Fedora/16-dev Firefox/4.0",
			"Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.1.16) Gecko/20120421 Firefox/11.0",
			"Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.1.16) Gecko/20120421 Gecko Firefox/11.0",
			"Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2.4) Gecko/20100625 Gentoo Firefox/3.6.4",
			"Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2.7) Gecko/20100726 CentOS/3.6-3.el5.centos Firefox/3.6.7",
			"Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2.8) Gecko/20100727 Firefox/3.6.8",
			"Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.9.2.9) Gecko/20100827 Red Hat/3.6.9-2.el6 Firefox/3.6.9",
			"Mozilla/5.0 (X11; U; Linux i686; fa; rv:1.8.1.4) Gecko/20100527 Firefox/3.6.4",
			"Mozilla/5.0 (X11; U; Linux i686; fi-FI; rv:1.9.2.8) Gecko/20100723 Ubuntu/10.04 (lucid) Firefox/3.6.8",
			"Mozilla/5.0 (X11; U; Linux i686; it-IT; rv:1.9.0.2) Gecko/2008092313 Ubuntu/9.25 (jaunty) Firefox/3.8",
			"Mozilla/5.0 (X11; U; Linux i686; pl-PL; rv:1.9.0.2) Gecko/2008092313 Ubuntu/9.25 (jaunty) Firefox/3.8",
			"Mozilla/5.0 (X11; U; Linux i686; pl-PL; rv:1.9.0.2) Gecko/20121223 Ubuntu/9.25 (jaunty) Firefox/3.8",
			"Mozilla/5.0 (X11; U; Linux i686; ru-RU; rv:1.9.2a1pre) Gecko/20090405 Ubuntu/9.04 (jaunty) Firefox/3.6a1pre",
			"Mozilla/5.0 (X11; U; Linux i686; ru; rv:1.9.1.3) Gecko/20091020 Ubuntu/10.04 (lucid) Firefox/4.0.1",
			"Mozilla/5.0 (X11; U; Linux i686; ru; rv:1.9.2.8) Gecko/20100723 Ubuntu/10.04 (lucid) Firefox/3.6.8",
			"Mozilla/5.0 (X11; U; Linux i686; ru; rv:1.9.3a5pre) Gecko/20100526 Firefox/3.7a5pre",
			"Mozilla/5.0 (X11; U; Linux i686; zh-CN; rv:1.9.2.8) Gecko/20100722 Ubuntu/10.04 (lucid) Firefox/3.6.8",
			"Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.4) Gecko/20100614 Ubuntu/10.04 (lucid) Firefox/3.6.4",
			"Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.6) Gecko/20100628 Ubuntu/10.04 (lucid) Firefox/3.6.6",
			"Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.6) Gecko/20100628 Ubuntu/10.04 (lucid) Firefox/3.6.6 (.NET CLR 3.5.30729)",
			"Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.6) Gecko/20100628 Ubuntu/10.04 (lucid) Firefox/3.6.6 GTB7.0",
			"Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.6) Gecko/20100628 Ubuntu/10.04 (lucid) Firefox/3.6.6 GTB7.1",
			"Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.7) Gecko/20100723 Fedora/3.6.7-1.fc13 Firefox/3.6.7",
			"Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.7) Gecko/20100809 Fedora/3.6.7-1.fc14 Firefox/3.6.7",
			"Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.8) Gecko/20100723 SUSE/3.6.8-0.1.1 Firefox/3.6.8",
			"Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.8) Gecko/20100804 Gentoo Firefox/3.6.8",
			"Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2.9) Gecko/20100915 Gentoo Firefox/3.6.9",
			"Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2a1pre) Gecko/20090405 Firefox/3.6a1pre",
			"Mozilla/5.0 (X11; U; Linux x86_64; en-US; rv:1.9.2a1pre) Gecko/20090428 Firefox/3.6a1pre",
			"Mozilla/5.0 (X11; U; Linux x86_64; pl-PL; rv:2.0) Gecko/20110307 Firefox/4.0",
			"Mozilla/5.0 (X11; U; OpenBSD i386; en-US; rv:1.9.2.8) Gecko/20101230 Firefox/3.6.8",
			"Mozilla/5.0 (X11; Ubuntu; Linux armv7l; rv:17.0) Gecko/20100101 Firefox/17.0",
			"Mozilla/5.0 (X11; Ubuntu; Linux i686; rv:14.0) Gecko/20100101 Firefox/14.0.1",
			"Mozilla/5.0 (X11; Ubuntu; Linux i686; rv:15.0) Gecko/20100101 Firefox/15.0.1",
			"Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:14.0) Gecko/20100101 Firefox/14.0.1",
			"Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:17.0) Gecko/20100101 Firefox/17.0.6",
			"Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:21.0) Gecko/20100101 Firefox/21.0",
			"Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:21.0) Gecko/20130331 Firefox/21.0",
			"Mozilla/5.0 (X11; Ubuntu; Linux x86_64; rv:24.0) Gecko/20100101 Firefox/24.0",
			"Mozilla/5.0 (compatible; Windows; U; Windows NT 6.2; WOW64; en-US; rv:12.0) Gecko/20120403211507 Firefox/12.0",
			"Mozilla/6.0 (Macintosh; I; Intel Mac OS X 11_7_9; de-LI; rv:1.9b4) Gecko/2012010317 Firefox/10.0a4",
			"Mozilla/6.0 (Windows NT 6.2; WOW64; rv:16.0.1) Gecko/20121011 Firefox/16.0.1",
			"Mozilla/3.0 (Windows NT 6.1; rv:2.0.1) Gecko/20100101 Firefox/5.0.1",
			Http.ChromeUserAgent(),
			Http.FirefoxUserAgent()
		};
		this.int_8 = 0;
		this.bool_1 = false;
		this.string_12 = "";
		this.InitializeComponent();
		this.CMResultat.SelectedIndex = 0;
		this.CMType.SelectedIndex = 0;
		this.text_proxyType.SelectedIndex = 3;
		this.Text = "SLAYER Leecher v0.6 [ " + Environment.UserName + " ]";
		this.object_1 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(new object())));
		Control.CheckForIllegalCrossThreadCalls = false;
		this.BackgroundWorker_0.WorkerSupportsCancellation = true;
		this.BackgroundWorker_1.WorkerSupportsCancellation = true;
		this.BackgroundWorker_2.WorkerSupportsCancellation = true;
		this.BackgroundWorker_3.WorkerSupportsCancellation = true;
		this.BackgroundWorker_4.WorkerSupportsCancellation = true;
		this.BackgroundWorker_5.WorkerSupportsCancellation = true;
		this.BackgroundWorker_6.WorkerSupportsCancellation = true;
		this.BackgroundWorker_7.WorkerSupportsCancellation = true;
		this.BackgroundWorker_8.WorkerSupportsCancellation = true;
		this.CustomTabcontrol1.SelectedIndex = 0;
	}

	// Token: 0x06000172 RID: 370 RVA: 0x0000EC4C File Offset: 0x0000CE4C
	private int method_0()
	{
		return new Random().Next(0, 5);
	}

	// Token: 0x06000173 RID: 371 RVA: 0x0000EC68 File Offset: 0x0000CE68
	private string method_1()
	{
		return this.string_10[this.method_0()];
	}

	// Token: 0x06000174 RID: 372 RVA: 0x0000EC84 File Offset: 0x0000CE84
	private void method_2(object sender, DoWorkEventArgs e)
	{
		checked
		{
			try
			{
				int num = 1;
				foreach (string text in this.TextBox1.Text.Split(new char[]
				{
					'\r'
				}))
				{
					try
					{
						HttpWebRequest httpWebRequest;
						if (this.bool_1)
						{
							httpWebRequest = (HttpWebRequest)WebRequest.Create(string.Concat(new string[]
							{
								"https://www.google." + this.method_1() + "/search?q=site:pastebin.com+",
								text,
								"&num=100&tbs=qdr:",
								this.string_8
							}));
						}
						else
						{
							httpWebRequest = (HttpWebRequest)WebRequest.Create(this.string_12);
						}
						HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
						string text2 = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
						string text3 = text2;
						this.RichTextBox2.Text = text3;
						MatchCollection matchCollection = new Regex("(https\\:\\/\\/pastebin\\.com\\/[a-zA-Z1-9]*)").Matches(this.RichTextBox2.Text);
						StringBuilder stringBuilder = new StringBuilder();
						try
						{
							foreach (object obj in matchCollection)
							{
								stringBuilder.AppendLine(((Match)obj).ToString());
							}
						}
						finally
						{
							IEnumerator enumerator;
							if (enumerator is IDisposable)
							{
								(enumerator as IDisposable).Dispose();
							}
						}
						this.TextBox3.Text = this.TextBox3.Text + stringBuilder.ToString();
						MatchCollection matchCollection2 = new Regex("(https\\:\\/\\/pastebin\\.com\\/[a-zA-Z1-9]*)").Matches(this.RichTextBox2.Text);
						StringBuilder stringBuilder2 = new StringBuilder();
						try
						{
							foreach (object obj2 in matchCollection2)
							{
								stringBuilder2.AppendLine(((Match)obj2).ToString());
							}
						}
						finally
						{
							IEnumerator enumerator2;
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
						this.TextBox3.Text = this.TextBox3.Text + stringBuilder2.ToString();
						num++;
						if (this.BackgroundWorker_0.CancellationPending)
						{
							e.Cancel = true;
							break;
						}
					}
					catch (Exception ex)
					{
						this.int_7++;
						this.CERR.Text = this.int_7.ToString();
					}
				}
			}
			catch (Exception ex2)
			{
			}
		}
	}

	// Token: 0x06000175 RID: 373 RVA: 0x0000EF54 File Offset: 0x0000D154
	private void method_3(object sender, DoWorkEventArgs e)
	{
		checked
		{
			try
			{
				string[] array = this.TextBox1.Text.Split(new char[]
				{
					'\r'
				});
				int num = 0;
				for (;;)
				{
					if (num < array.Length)
					{
						string text = array[num];
						try
						{
							string text2 = new HttpRequest
							{
								ConnectTimeout = 10000,
								Proxy = null,
								AllowAutoRedirect = true,
								KeepAlive = true,
								IgnoreProtocolErrors = true
							}.Get(string.Concat(new string[]
							{
								"https://www.bing.com/search?q=site:pastebin.com+",
								text,
								"&num=100&tbs=qdr:y&ei=-d2PUqnoIOyp7AbP2IGoBQ&start=",
								Conversions.ToString(200),
								"&sa=N&biw=1366&bih=604"
							}), null).ToString();
							this.RCHp.Text = text2;
							MatchCollection matchCollection = new Regex("(https\\:\\/\\/pastebin\\.com\\/[a-zA-Z1-9]*)").Matches(this.RCHp.Text);
							StringBuilder stringBuilder = new StringBuilder();
							try
							{
								foreach (object obj in matchCollection)
								{
									stringBuilder.AppendLine(((Match)obj).ToString());
								}
							}
							finally
							{
								IEnumerator enumerator;
								if (enumerator is IDisposable)
								{
									(enumerator as IDisposable).Dispose();
								}
							}
							this.TextBox3.Text = this.TextBox3.Text + stringBuilder.ToString();
							MatchCollection matchCollection2 = new Regex("(https\\:\\/\\/pastebin\\.com\\/[a-zA-Z1-9]*)").Matches(this.RCHp.Text);
							StringBuilder stringBuilder2 = new StringBuilder();
							try
							{
								foreach (object obj2 in matchCollection2)
								{
									stringBuilder2.AppendLine(((Match)obj2).ToString());
								}
							}
							finally
							{
								IEnumerator enumerator2;
								if (enumerator2 is IDisposable)
								{
									(enumerator2 as IDisposable).Dispose();
								}
							}
							this.TextBox3.Text = this.TextBox3.Text + stringBuilder2.ToString();
							if (this.BackgroundWorker_1.CancellationPending)
							{
								e.Cancel = true;
								break;
							}
							goto IL_200;
						}
						catch (Exception ex)
						{
							goto IL_200;
						}
						continue;
						IL_200:
						num++;
					}
				}
			}
			catch (Exception ex2)
			{
			}
		}
	}

	// Token: 0x06000176 RID: 374 RVA: 0x0000F1F0 File Offset: 0x0000D3F0
	private void method_4(object sender, DoWorkEventArgs e)
	{
		try
		{
			foreach (string text in this.TextBox1.Text.Split(new char[]
			{
				'\r'
			}))
			{
				try
				{
					string text2 = new HttpRequest
					{
						ConnectTimeout = 10000,
						Proxy = null,
						AllowAutoRedirect = true,
						KeepAlive = true,
						IgnoreProtocolErrors = true
					}.Get(string.Concat(new string[]
					{
						"http://www.google.",
						this.method_1(),
						"/search?q=",
						text,
						"&num=100&tbs=qdr:",
						this.string_8,
						"&ei=-d2PUqnoIOyp7AbP2IGoBQ&start=50&sa=N&biw=1366&bih=604"
					}), null).ToString();
					this.RichTextBox3.Text = text2;
					MatchCollection matchCollection = new Regex("q=http://+(?:[a-zA-Z0-9./_+-]{3,})").Matches(this.RichTextBox3.Text);
					StringBuilder stringBuilder = new StringBuilder();
					try
					{
						foreach (object obj in matchCollection)
						{
							stringBuilder.AppendLine(((Match)obj).ToString());
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					this.TextBox3.Text = this.TextBox3.Text + stringBuilder.ToString();
					MatchCollection matchCollection2 = new Regex("q=https://+(?:[a-zA-Z0-9./_+-]{3,})").Matches(this.RichTextBox3.Text);
					StringBuilder stringBuilder2 = new StringBuilder();
					try
					{
						foreach (object obj2 in matchCollection2)
						{
							stringBuilder2.AppendLine(((Match)obj2).ToString());
						}
					}
					finally
					{
						IEnumerator enumerator2;
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
					this.TextBox3.Text = this.TextBox3.Text + stringBuilder2.ToString();
					if (this.BackgroundWorker_2.CancellationPending)
					{
						e.Cancel = true;
						break;
					}
				}
				catch (Exception ex)
				{
				}
			}
		}
		catch (Exception ex2)
		{
		}
	}

	// Token: 0x06000177 RID: 375 RVA: 0x0000F494 File Offset: 0x0000D694
	private void method_5(object sender, DoWorkEventArgs e)
	{
		try
		{
			foreach (string text in this.TextBox1.Text.Split(new char[]
			{
				'\r'
			}))
			{
				try
				{
					string text2 = new HttpRequest
					{
						ConnectTimeout = 10000,
						Proxy = null,
						AllowAutoRedirect = true,
						KeepAlive = true,
						IgnoreProtocolErrors = true
					}.Get(string.Concat(new string[]
					{
						"https://duckduckgo.com/?q=site%3Apastebin.com+",
						text,
						"&num=100&tbs=qdr:w&ei=-d2PUqnoIOyp7AbP2IGoBQ&start=",
						Conversions.ToString(800),
						"&sa=N&biw=1366&bih=604"
					}), null).ToString();
					this.RichTextBox4.Text = text2;
					MatchCollection matchCollection = new Regex("https://+(?:[a-zA-Z0-9./_+-]{3,})").Matches(this.RichTextBox4.Text);
					StringBuilder stringBuilder = new StringBuilder();
					try
					{
						foreach (object obj in matchCollection)
						{
							stringBuilder.AppendLine(((Match)obj).ToString());
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					this.TextBox3.Text = this.TextBox3.Text + stringBuilder.ToString();
					MatchCollection matchCollection2 = new Regex("https://+(?:[a-zA-Z0-9./_+-]{3,})").Matches(this.RichTextBox4.Text);
					StringBuilder stringBuilder2 = new StringBuilder();
					try
					{
						foreach (object obj2 in matchCollection2)
						{
							stringBuilder2.AppendLine(((Match)obj2).ToString());
						}
					}
					finally
					{
						IEnumerator enumerator2;
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
					this.TextBox3.Text = this.TextBox3.Text + stringBuilder2.ToString();
					if (this.BackgroundWorker_3.CancellationPending)
					{
						e.Cancel = true;
						break;
					}
				}
				catch (Exception ex)
				{
				}
			}
		}
		catch (Exception ex2)
		{
		}
	}

	// Token: 0x06000178 RID: 376 RVA: 0x0000F728 File Offset: 0x0000D928
	private void method_6(object sender, DoWorkEventArgs e)
	{
		try
		{
			foreach (string str in this.TextBox1.Text.Split(new char[]
			{
				'\r'
			}))
			{
				try
				{
					string text = new HttpRequest
					{
						ConnectTimeout = 10000,
						Proxy = null,
						AllowAutoRedirect = true,
						KeepAlive = true,
						IgnoreProtocolErrors = true
					}.Get("https://yandex.ru/search/?text=" + str + "&start=50", null).ToString();
					this.RichTextBox6.Text = text;
					MatchCollection matchCollection = new Regex("q=http://+(?:[a-zA-Z0-9./_+-]{3,})").Matches(this.RichTextBox5.Text);
					StringBuilder stringBuilder = new StringBuilder();
					try
					{
						foreach (object obj in matchCollection)
						{
							stringBuilder.AppendLine(((Match)obj).ToString());
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					this.TextBox3.Text = this.TextBox3.Text + stringBuilder.ToString();
					MatchCollection matchCollection2 = new Regex("q=https://+(?:[a-zA-Z0-9./_+-]{3,})").Matches(this.RichTextBox5.Text);
					StringBuilder stringBuilder2 = new StringBuilder();
					try
					{
						foreach (object obj2 in matchCollection2)
						{
							stringBuilder2.AppendLine(((Match)obj2).ToString());
						}
					}
					finally
					{
						IEnumerator enumerator2;
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
					this.TextBox3.Text = this.TextBox3.Text + stringBuilder2.ToString();
					if (this.BackgroundWorker_4.CancellationPending)
					{
						e.Cancel = true;
						break;
					}
				}
				catch (Exception ex)
				{
				}
			}
		}
		catch (Exception ex2)
		{
		}
	}

	// Token: 0x06000179 RID: 377 RVA: 0x0000F990 File Offset: 0x0000DB90
	private void method_7(object sender, DoWorkEventArgs e)
	{
		try
		{
			foreach (string str in this.TextBox1.Text.Split(new char[]
			{
				'\r'
			}))
			{
				try
				{
					string text = new HttpRequest
					{
						ConnectTimeout = 10000,
						Proxy = null,
						AllowAutoRedirect = true,
						KeepAlive = true,
						IgnoreProtocolErrors = true
					}.Get("http://www.bing.com/search?q=" + str + "&start=55", null).ToString();
					this.RichTextBox5.Text = text;
					MatchCollection matchCollection = new Regex("q=http://+(?:[a-zA-Z0-9./_+-]{3,})").Matches(this.RichTextBox6.Text);
					StringBuilder stringBuilder = new StringBuilder();
					try
					{
						foreach (object obj in matchCollection)
						{
							stringBuilder.AppendLine(((Match)obj).ToString());
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					this.TextBox3.Text = this.TextBox3.Text + stringBuilder.ToString();
					MatchCollection matchCollection2 = new Regex("q=https://+(?:[a-zA-Z0-9./_+-]{3,})").Matches(this.RichTextBox6.Text);
					StringBuilder stringBuilder2 = new StringBuilder();
					try
					{
						foreach (object obj2 in matchCollection2)
						{
							stringBuilder2.AppendLine(((Match)obj2).ToString());
						}
					}
					finally
					{
						IEnumerator enumerator2;
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
					this.TextBox3.Text = this.TextBox3.Text + stringBuilder2.ToString();
					if (this.BackgroundWorker_5.CancellationPending)
					{
						e.Cancel = true;
						break;
					}
				}
				catch (Exception ex)
				{
				}
			}
		}
		catch (Exception ex2)
		{
		}
	}

	// Token: 0x0600017A RID: 378 RVA: 0x0000FBF8 File Offset: 0x0000DDF8
	public void method_8()
	{
		Regex regex = new Regex("(https|http):\\/\\/+(?:[a-zA-Z0-9./_+-]{3,})");
		MatchCollection matchCollection = regex.Matches(this.TextBox3.Text);
		StringBuilder stringBuilder = new StringBuilder();
		IEnumerator enumerator = matchCollection.GetEnumerator();
		while (enumerator.MoveNext())
		{
			object obj = enumerator.Current;
			Match match = (Match)obj;
			stringBuilder.AppendLine(match.ToString());
		}
		if (enumerator is IDisposable)
		{
			(enumerator as IDisposable).Dispose();
		}
		this.TextBox4.Text = (this.TextBox4.Text + stringBuilder.ToString()).Trim();
		this.method_14();
	}

	// Token: 0x0600017B RID: 379 RVA: 0x0000FC98 File Offset: 0x0000DE98
	private void method_9(object sender, DoWorkEventArgs e)
	{
		int num3;
		int num4;
		object obj;
		try
		{
			IL_01:
			int num = 1;
			int num2 = 0;
			IL_06:
			num = 2;
			string[] array = this.TextBox1.Text.Split(new char[]
			{
				'\r'
			});
			int i = 0;
			checked
			{
				while (i < array.Length)
				{
					string address = array[i];
					IL_42:
					ProjectData.ClearProjectError();
					num3 = -2;
					IL_4B:
					num = 4;
					HttpRequest httpRequest = new HttpRequest();
					IL_55:
					num = 5;
					httpRequest.Cookies = new CookieDictionary(false);
					IL_65:
					num = 6;
					httpRequest.ConnectTimeout = 10000;
					IL_74:
					num = 7;
					httpRequest.Proxy = null;
					IL_7F:
					num = 8;
					httpRequest.AllowAutoRedirect = true;
					IL_8A:
					num = 9;
					httpRequest.KeepAlive = true;
					IL_96:
					num = 10;
					httpRequest.IgnoreProtocolErrors = true;
					IL_A2:
					num = 11;
					httpRequest.UserAgent = Http.ChromeUserAgent();
					IL_B2:
					num = 12;
					string input = httpRequest.Get(address, null).ToString();
					IL_C7:
					num = 13;
					Regex regex = new Regex(this.string_9);
					IL_D8:
					num = 14;
					MatchCollection matchCollection = regex.Matches(input);
					IL_E6:
					num = 15;
					this.l12.ForeColor = Color.Blue;
					IL_FA:
					num = 16;
					this.l12.Text = Conversions.ToString(num2 + 1);
					IL_111:
					num = 17;
					StringBuilder stringBuilder = new StringBuilder();
					IL_11B:
					num = 18;
					IEnumerator enumerator = matchCollection.GetEnumerator();
					for (;;)
					{
						IL_29A:
						num = 20;
						if (!enumerator.MoveNext())
						{
							break;
						}
						IL_12B:
						num = 21;
						Match match = (Match)enumerator.Current;
						IL_13C:
						num = 22;
						stringBuilder.AppendLine(match.ToString());
					}
					IL_153:
					num = 24;
					if (enumerator is IDisposable)
					{
						IL_162:
						num = 25;
						(enumerator as IDisposable).Dispose();
					}
					IL_171:
					num = 27;
					this.TXT2.Text = (this.TXT2.Text + stringBuilder.ToString()).Trim();
					IL_19B:
					num = 28;
					input = string.Empty;
					IL_1A6:
					num = 29;
					num2++;
					IL_1AE:
					num = 30;
					if (this.BackgroundWorker_9.CancellationPending)
					{
						IL_2AE:
						num = 31;
						e.Cancel = true;
						break;
					}
					IL_1C2:
					num = 34;
					if (Operators.ConditionalCompareObjectEqual(Conversion.Int(this.l12.Text), Conversion.Int(this.lbl3.Text), false))
					{
						IL_1F1:
						num = 35;
						this.lbl9.ForeColor = Color.Blue;
						IL_205:
						num = 36;
						this.lbl9.Text = "Leching Finished!";
						IL_219:
						num = 37;
						this.Button8.Enabled = true;
						IL_229:
						num = 38;
						this.Button5.Enabled = false;
						IL_239:
						num = 39;
						this.BTN1.Enabled = true;
						IL_249:
						num = 40;
						this.BTNLoad.Enabled = true;
						IL_259:
						num = 41;
						this.CMType.Enabled = true;
						IL_269:
						num = 42;
						Interaction.MsgBox("Work Has Been Completed ^_^\r[+]Resultat : " + this.lblc.Text, MsgBoxStyle.Information, null);
					}
					IL_28B:
					i++;
					IL_291:
					num = 44;
				}
				IL_2B9:
				goto IL_3D2;
				IL_2BE:
				num4 = num;
				if (num3 <= -2)
				{
					goto IL_2DC;
				}
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_2D7:
				goto IL_3C7;
				IL_2DC:;
			}
			int num5 = num4 + 1;
			num4 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num5);
			IL_3A0:;
		}
		catch when (endfilter(obj is Exception & num3 != 0 & num4 == 0))
		{
			Exception ex = (Exception)obj2;
			goto IL_2BE;
		}
		IL_3C7:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_3D2:
		if (num4 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	// Token: 0x0600017C RID: 380 RVA: 0x0001009C File Offset: 0x0000E29C
	private void method_10(object sender, RunWorkerCompletedEventArgs e)
	{
		checked
		{
			try
			{
				this.int_5++;
				this.Label3.Text = this.TextBox2.Lines[this.int_5];
				this.BackgroundWorker_6.RunWorkerAsync();
			}
			catch (Exception ex)
			{
				Interaction.MsgBox("Done", MsgBoxStyle.Information, null);
			}
		}
	}

	// Token: 0x0600017D RID: 381 RVA: 0x0001011C File Offset: 0x0000E31C
	private void method_11(object sender, EventArgs e)
	{
		if (Operators.CompareString(this.TextBox1.Text, "", false) == 0)
		{
			Interaction.MsgBox("No Keywords Founded !", MsgBoxStyle.Critical, null);
		}
		else
		{
			this.Button1.Enabled = false;
			this.PictureBox2.Enabled = false;
			this.CMResultat.Enabled = false;
			this.GroupBox3.Enabled = false;
			this.Button6.Enabled = true;
			this.RichTextBox1.Clear();
			this.RichTextBox2.Clear();
			this.RichTextBox3.Clear();
			this.TextBox4.Clear();
			this.TextBox3.Clear();
			this.TextBox2.Text = "";
			if (Class12.MySettings_0.Pastebin)
			{
				this.BackgroundWorker_0.RunWorkerAsync();
				this.BackgroundWorker_1.RunWorkerAsync();
				this.BackgroundWorker_3.RunWorkerAsync();
			}
			if (Class12.MySettings_0.GOOGLE)
			{
				this.BackgroundWorker_8.RunWorkerAsync();
				this.BackgroundWorker_2.RunWorkerAsync();
			}
			if (Class12.MySettings_0.YANDEX)
			{
				this.BackgroundWorker_4.RunWorkerAsync();
				this.BackgroundWorker_7.RunWorkerAsync();
			}
			if (Class12.MySettings_0.Bing)
			{
				this.BackgroundWorker_5.RunWorkerAsync();
			}
		}
	}

	// Token: 0x0600017E RID: 382 RVA: 0x00010264 File Offset: 0x0000E464
	private void method_12(object sender, EventArgs e)
	{
		if (Operators.CompareString(this.TextBox3.Text, "", false) == 0)
		{
			Interaction.MsgBox("No data to filter.", MsgBoxStyle.Critical, null);
		}
		else
		{
			this.TextBox3.Text = this.TextBox3.Text.Replace("q=http://webcache.googleusercontent.com/search", "").Trim();
			this.TextBox3.Text = this.TextBox3.Text.Replace("q=https://www.youtube.com/watch", "").Trim();
			MatchCollection matchCollection = new Regex("https://+(?:[a-zA-Z0-9./_+-]{3,})").Matches(this.TextBox3.Text);
			StringBuilder stringBuilder = new StringBuilder();
			try
			{
				foreach (object obj in matchCollection)
				{
					stringBuilder.AppendLine(((Match)obj).ToString());
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			this.TextBox2.Text = this.TextBox2.Text + stringBuilder.ToString();
			MatchCollection matchCollection2 = new Regex("q=https://+(?:[a-zA-Z0-9./_+-]{3,})").Matches(this.TextBox3.Text);
			StringBuilder stringBuilder2 = new StringBuilder();
			try
			{
				foreach (object obj2 in matchCollection2)
				{
					stringBuilder2.AppendLine(((Match)obj2).ToString());
				}
			}
			finally
			{
				IEnumerator enumerator2;
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			this.TextBox2.Text = this.TextBox2.Text + stringBuilder2.ToString();
			Interaction.MsgBox("Filtred Done Try To Grab Your Data", MsgBoxStyle.Information, null);
		}
	}

	// Token: 0x0600017F RID: 383 RVA: 0x00010428 File Offset: 0x0000E628
	private void method_13(object sender, EventArgs e)
	{
		if (Operators.CompareString(this.TextBox2.Text, "", false) == 0)
		{
			Interaction.MsgBox("Data Not Found!", MsgBoxStyle.Critical, null);
		}
		else
		{
			this.Label3.Text = this.TextBox2.Lines[0];
			Thread thread = new Thread(new ThreadStart(this.method_8));
			thread.Start();
		}
	}

	// Token: 0x06000180 RID: 384 RVA: 0x00010494 File Offset: 0x0000E694
	public void method_14()
	{
		string[] source = this.TextBox4.Text.Split(new string[]
		{
			"\r\n"
		}, StringSplitOptions.RemoveEmptyEntries);
		source.Distinct<string>().Count<string>();
		this.TextBox4.Text = string.Join("\r\n", source.Distinct<string>());
		Interaction.MsgBox("Duplicate Removed", MsgBoxStyle.Information, null);
	}

	// Token: 0x06000181 RID: 385 RVA: 0x000104FC File Offset: 0x0000E6FC
	private void method_15(object sender, EventArgs e)
	{
		if (this.BackgroundWorker_0.IsBusy)
		{
			this.BackgroundWorker_0.CancelAsync();
		}
		if (this.BackgroundWorker_1.IsBusy)
		{
			this.BackgroundWorker_1.CancelAsync();
		}
		if (this.BackgroundWorker_2.IsBusy)
		{
			this.BackgroundWorker_2.CancelAsync();
		}
		if (this.BackgroundWorker_3.IsBusy)
		{
			this.BackgroundWorker_3.CancelAsync();
		}
		if (this.BackgroundWorker_4.IsBusy)
		{
			this.BackgroundWorker_4.CancelAsync();
		}
		if (this.BackgroundWorker_5.IsBusy)
		{
			this.BackgroundWorker_5.CancelAsync();
		}
		if (this.BackgroundWorker_6.IsBusy)
		{
			this.BackgroundWorker_6.CancelAsync();
		}
		if (this.BackgroundWorker_7.IsBusy)
		{
			this.BackgroundWorker_7.CancelAsync();
		}
		if (this.BackgroundWorker_8.IsBusy)
		{
			this.BackgroundWorker_8.CancelAsync();
		}
		this.GroupBox3.Enabled = true;
		this.CMResultat.Enabled = true;
		this.Button1.Enabled = true;
		this.PictureBox2.Enabled = true;
		this.Button6.Enabled = false;
	}

	// Token: 0x06000182 RID: 386 RVA: 0x00010620 File Offset: 0x0000E820
	private void method_16(object sender, EventArgs e)
	{
		if (Operators.CompareString(this.TextBox4.Text, "", false) == 0)
		{
			Interaction.MsgBox("No Data To Save!", MsgBoxStyle.Critical, null);
		}
		else
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog
			{
				RestoreDirectory = true,
				Filter = "TXT Files (*.txt)|*.txt",
				FilterIndex = 1
			};
			saveFileDialog.ShowDialog();
			if (Operators.CompareString(saveFileDialog.FileName, null, false) != 0)
			{
				using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName))
				{
					streamWriter.WriteLine(this.TextBox4.Text);
				}
			}
		}
	}

	// Token: 0x06000183 RID: 387 RVA: 0x000106D4 File Offset: 0x0000E8D4
	private void method_17(object sender, EventArgs e)
	{
		this.TextBox1.Text = Class12.MySettings_0.Config;
	}

	// Token: 0x06000184 RID: 388 RVA: 0x000106F8 File Offset: 0x0000E8F8
	private void method_18(object sender, EventArgs e)
	{
		this.TextBox1.Text = Clipboard.GetText();
	}

	// Token: 0x06000185 RID: 389 RVA: 0x00010718 File Offset: 0x0000E918
	private void method_19(object sender, EventArgs e)
	{
		this.TextBox1.Text = string.Empty;
	}

	// Token: 0x06000186 RID: 390 RVA: 0x00010738 File Offset: 0x0000E938
	private void method_20(object sender, EventArgs e)
	{
		this.l6.Text = Conversions.ToString(this.TextBox2.Lines.Count<string>());
	}

	// Token: 0x06000187 RID: 391 RVA: 0x00010768 File Offset: 0x0000E968
	private void method_21(object sender, EventArgs e)
	{
		this.l5.Text = Conversions.ToString(this.TextBox3.Lines.Count<string>());
	}

	// Token: 0x06000188 RID: 392 RVA: 0x00010798 File Offset: 0x0000E998
	private void method_22(object sender, EventArgs e)
	{
		this.l8.Text = Conversions.ToString(this.TextBox4.Lines.Count<string>());
	}

	// Token: 0x06000189 RID: 393 RVA: 0x000107C8 File Offset: 0x0000E9C8
	private void method_23(object sender, EventArgs e)
	{
		checked
		{
			if (this.int_0 == 0)
			{
				Interaction.MsgBox("No Links To Check !!", MsgBoxStyle.Exclamation, null);
			}
			else if (this.bproxy.Enabled & this.int_1 == 0)
			{
				Interaction.MsgBox("Load Proxy Or Select NO PROXY", MsgBoxStyle.Exclamation, null);
			}
			else
			{
				switch (this.text_proxyType.SelectedIndex)
				{
				case 0:
					this.proxyType_0 = ProxyType.Http;
					break;
				case 1:
					this.proxyType_0 = ProxyType.Socks4;
					break;
				case 2:
					this.proxyType_0 = ProxyType.Socks5;
					break;
				case 3:
					this.string_6 = "YES";
					break;
				default:
					Interaction.MsgBox("Please select the type of proxy!", MsgBoxStyle.Information, null);
					return;
				}
				this.TXT2.Text = "";
				this.Button8.Enabled = false;
				this.Button5.Enabled = true;
				this.BTN1.Enabled = false;
				this.BTNLoad.Enabled = false;
				this.CMType.Enabled = false;
				this.text_proxyType.Enabled = false;
				this.bproxy.Enabled = false;
				this.int_3 = 0;
				this.int_4 = 0;
				this.string_3 = null;
				this.queue_0 = new Queue();
				int num = 0;
				int num2 = this.int_0 - 1;
				int num3 = num;
				for (;;)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					this.queue_0.Enqueue(this.string_4[num3]);
					num3++;
				}
				this.int_2 = Convert.ToInt32(this.numericUpDown1.Value);
				this.thread_0 = new Thread[this.int_2 - 1 + 1];
				int num6 = 0;
				int num7 = this.int_2 - 1;
				int num8 = num6;
				for (;;)
				{
					int num9 = num8;
					int num5 = num7;
					if (num9 > num5)
					{
						break;
					}
					this.thread_0[num8] = new Thread(new ThreadStart(this.method_43));
					this.thread_0[num8].IsBackground = true;
					this.thread_0[num8].Start();
					num8++;
				}
				this.lbl9.ForeColor = Color.Green;
				this.lbl9.Text = "Waiting For Crowling...";
				this.Timer_0.Enabled = true;
				this.bool_0 = true;
				this.int_8 = 1;
			}
		}
	}

	// Token: 0x0600018A RID: 394 RVA: 0x000109E0 File Offset: 0x0000EBE0
	private void method_24(object sender, EventArgs e)
	{
		this.Button5.Enabled = false;
		this.bool_0 = false;
		this.int_8 = 0;
		this.method_45();
		this.Timer_0.Enabled = false;
		this.BTN1.Enabled = true;
		this.Button8.Enabled = true;
		this.BTNLoad.Enabled = true;
		this.CMType.Enabled = true;
		this.text_proxyType.Enabled = true;
		if (this.text_proxyType.SelectedIndex != 3)
		{
			this.bproxy.Enabled = true;
		}
		this.lbl9.ForeColor = Color.Coral;
		this.lbl9.Text = "Leeching Canceled X";
	}

	// Token: 0x0600018B RID: 395 RVA: 0x00010A94 File Offset: 0x0000EC94
	private void method_25(object sender, EventArgs e)
	{
		if (Operators.CompareString(this.TXT2.Text, "", false) == 0)
		{
			Interaction.MsgBox("No Data To Save", MsgBoxStyle.Critical, null);
		}
		else
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "txt files (*.txt)|*.txt";
			saveFileDialog.Title = "Save Results";
			saveFileDialog.FileName = "";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				File.WriteAllLines(saveFileDialog.FileName, this.TXT2.Lines);
			}
			Interaction.MsgBox("Saved To : " + saveFileDialog.FileName, MsgBoxStyle.Information, "SLAYER Leecher v0.6");
		}
	}

	// Token: 0x0600018C RID: 396 RVA: 0x00006BE8 File Offset: 0x00004DE8
	private void method_26(object sender, EventArgs e)
	{
	}

	// Token: 0x0600018D RID: 397 RVA: 0x00010B34 File Offset: 0x0000ED34
	private void method_27(object sender, EventArgs e)
	{
		using (OpenFileDialog openFileDialog = new OpenFileDialog())
		{
			openFileDialog.Filter = "Тext Files|*.txt";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				char[] separator = new char[]
				{
					'\n'
				};
				this.string_4 = File.ReadAllText(openFileDialog.FileName).Trim().TrimEnd(new char[0]).Replace(";", ":").Split(separator).Distinct<string>().ToArray<string>();
				this.int_0 = this.string_4.Length;
				this.lbl3.Text = this.int_0.ToString();
			}
		}
	}

	// Token: 0x0600018E RID: 398 RVA: 0x00010BF4 File Offset: 0x0000EDF4
	private void method_28(object sender, EventArgs e)
	{
		this.TextBox3.Copy();
	}

	// Token: 0x0600018F RID: 399 RVA: 0x00010C0C File Offset: 0x0000EE0C
	private void method_29(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://www.youtube.com/channel/UCNhHoOMBv2pgAKduePC0_Fg?sub_confirmation=1");
	}

	// Token: 0x06000190 RID: 400 RVA: 0x00010C24 File Offset: 0x0000EE24
	private void method_30(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://twitter.com/IHEB_X_SLAYER");
	}

	// Token: 0x06000191 RID: 401 RVA: 0x00010C3C File Offset: 0x0000EE3C
	private void method_31(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://www.facebook.com/ihebbriki1");
	}

	// Token: 0x06000192 RID: 402 RVA: 0x00010C54 File Offset: 0x0000EE54
	private void method_32(object sender, EventArgs e)
	{
		this.TXT2.Clear();
	}

	// Token: 0x06000193 RID: 403 RVA: 0x00010C6C File Offset: 0x0000EE6C
	public void method_33()
	{
		try
		{
			string[] lines = this.TXT2.Lines;
			lines.Distinct<string>().Count<string>();
			this.TXT2.Text = string.Join("\r\n", lines.Distinct<string>());
			Interaction.MsgBox("Duplicate Removed", MsgBoxStyle.Information, null);
		}
		catch (Exception ex)
		{
		}
	}

	// Token: 0x06000194 RID: 404 RVA: 0x00010CDC File Offset: 0x0000EEDC
	private void method_34(object sender, EventArgs e)
	{
		Thread thread = new Thread(new ThreadStart(this.method_33));
		thread.Start();
	}

	// Token: 0x06000195 RID: 405 RVA: 0x00010D04 File Offset: 0x0000EF04
	private void method_35(object sender, EventArgs e)
	{
		if (this.CMResultat.SelectedIndex != 0)
		{
			if (this.CMResultat.SelectedIndex != 1)
			{
				if (this.CMResultat.SelectedIndex == 2)
				{
					this.string_8 = "m";
				}
				else if (this.CMResultat.SelectedIndex != 3)
				{
					if (this.CMResultat.SelectedIndex != 4)
					{
						if (this.CMResultat.SelectedIndex == 5)
						{
							Class6.Class7_0.Custom_0.ShowDialog();
						}
						else
						{
							this.string_8 = "all";
						}
					}
					else
					{
						this.string_8 = "d";
					}
				}
				else
				{
					this.string_8 = "w";
				}
			}
			else
			{
				this.string_8 = "y";
			}
		}
		else
		{
			this.string_8 = "all";
		}
	}

	// Token: 0x06000196 RID: 406 RVA: 0x00010DD8 File Offset: 0x0000EFD8
	private void method_36(object sender, RunWorkerCompletedEventArgs e)
	{
		Interaction.MsgBox("Done ^__^", MsgBoxStyle.Information, Environment.UserName);
	}

	// Token: 0x06000197 RID: 407 RVA: 0x00010DF8 File Offset: 0x0000EFF8
	public void method_37()
	{
		try
		{
			this.imgversion.Image = Class11.Bitmap_0;
			string right = "0.6";
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://pastebin.com/raw/NPNC4LYX");
			if (Operators.CompareString(text.Split(new char[]
			{
				'|'
			})[0], right, false) == 0)
			{
				this.imgversion.Image = Class11.Bitmap_4;
				this.lnews.Text = "This version Is Up-To-Date";
				this.lblyes.Text = "No Version Updated ";
			}
			else
			{
				this.imgversion.Image = Class11.Bitmap_1;
				this.lnews.Text = "New version Has Been Updated";
				this.lblyes.Text = "New Version Updated With New Features";
				if (Interaction.MsgBox("New Version Updated\rDo You Want To Check", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes)
				{
					Process.Start(text.Split(new char[]
					{
						'|'
					})[1]);
				}
			}
		}
		catch (Exception ex)
		{
			Interaction.MsgBox("Your Connexion Low To Check For Updates", MsgBoxStyle.Exclamation, null);
			this.imgversion.Image = Class11.Bitmap_4;
		}
	}

	// Token: 0x06000198 RID: 408 RVA: 0x00010F24 File Offset: 0x0000F124
	private void method_38(object sender, EventArgs e)
	{
		Thread thread = new Thread(new ThreadStart(this.method_37));
		thread.SetApartmentState(ApartmentState.STA);
		thread.Start();
	}

	// Token: 0x06000199 RID: 409 RVA: 0x00010F54 File Offset: 0x0000F154
	private void method_39(object sender, DoWorkEventArgs e)
	{
		checked
		{
			try
			{
				foreach (string text in this.TextBox1.Text.Split(new char[]
				{
					'\r'
				}))
				{
					try
					{
						HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string.Concat(new string[]
						{
							"https://yandex.ru/search/?text=",
							text,
							"&num=100&tbs=qdr:",
							this.string_8,
							"&ei=-d2PUqnoIOyp7AbP2IGoBQ&start=",
							Conversions.ToString(22),
							"&sa=N&biw=1366&bih=604"
						}));
						HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
						string text2 = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
						this.RchYandex.Text = text2;
						MatchCollection matchCollection = new Regex("q=http://+(?:[a-zA-Z0-9./_+-]{3,})").Matches(this.RchYandex.Text);
						StringBuilder stringBuilder = new StringBuilder();
						try
						{
							foreach (object obj in matchCollection)
							{
								stringBuilder.AppendLine(((Match)obj).ToString());
							}
						}
						finally
						{
							IEnumerator enumerator;
							if (enumerator is IDisposable)
							{
								(enumerator as IDisposable).Dispose();
							}
						}
						this.TextBox3.Text = this.TextBox3.Text + stringBuilder.ToString();
						MatchCollection matchCollection2 = new Regex("q=https://+(?:[a-zA-Z0-9./_+-]{3,})").Matches(this.RchYandex.Text);
						StringBuilder stringBuilder2 = new StringBuilder();
						try
						{
							foreach (object obj2 in matchCollection2)
							{
								stringBuilder2.AppendLine(((Match)obj2).ToString());
							}
						}
						finally
						{
							IEnumerator enumerator2;
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
						this.TextBox3.Text = this.TextBox3.Text + stringBuilder2.ToString();
						if (this.BackgroundWorker_7.CancellationPending)
						{
							e.Cancel = true;
							break;
						}
					}
					catch (Exception ex)
					{
						this.int_7++;
						this.CERR.Text = this.int_7.ToString();
					}
				}
			}
			catch (Exception ex2)
			{
			}
		}
	}

	// Token: 0x0600019A RID: 410 RVA: 0x00010F24 File Offset: 0x0000F124
	private void Form1_Shown(object sender, EventArgs e)
	{
		Thread thread = new Thread(new ThreadStart(this.method_37));
		thread.SetApartmentState(ApartmentState.STA);
		thread.Start();
	}

	// Token: 0x0600019B RID: 411 RVA: 0x00011208 File Offset: 0x0000F408
	private void method_40(object sender, DoWorkEventArgs e)
	{
		checked
		{
			try
			{
				foreach (string text in this.TextBox1.Text.Split(new char[]
				{
					'\r'
				}))
				{
					try
					{
						HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string.Concat(new string[]
						{
							"https://www.google.com/search?q=",
							text,
							"&num=100&tbs=qdr:",
							this.string_8,
							"&ei=-d2PUqnoIOyp7AbP2IGoBQ&start=",
							Conversions.ToString(22),
							"&sa=N&biw=1366&bih=604"
						}));
						HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
						string text2 = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
						this.RCHp.Text = text2;
						MatchCollection matchCollection = new Regex("q=http://+(?:[a-zA-Z0-9./_+-]{3,})").Matches(this.RCHp.Text);
						StringBuilder stringBuilder = new StringBuilder();
						try
						{
							foreach (object obj in matchCollection)
							{
								stringBuilder.AppendLine(((Match)obj).ToString());
							}
						}
						finally
						{
							IEnumerator enumerator;
							if (enumerator is IDisposable)
							{
								(enumerator as IDisposable).Dispose();
							}
						}
						this.TextBox3.Text = this.TextBox3.Text + stringBuilder.ToString();
						MatchCollection matchCollection2 = new Regex("q=https://+(?:[a-zA-Z0-9./_+-]{3,})").Matches(this.RCHp.Text);
						StringBuilder stringBuilder2 = new StringBuilder();
						try
						{
							foreach (object obj2 in matchCollection2)
							{
								stringBuilder2.AppendLine(((Match)obj2).ToString());
							}
						}
						finally
						{
							IEnumerator enumerator2;
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
						this.TextBox3.Text = this.TextBox3.Text + stringBuilder2.ToString();
						if (this.BackgroundWorker_8.CancellationPending)
						{
							e.Cancel = true;
							break;
						}
					}
					catch (Exception ex)
					{
						this.int_7++;
						this.CERR.Text = this.int_7.ToString();
					}
				}
			}
			catch (Exception ex2)
			{
			}
		}
	}

	// Token: 0x0600019C RID: 412 RVA: 0x000114BC File Offset: 0x0000F6BC
	private string method_41()
	{
		return this.string_0[this.method_42()];
	}

	// Token: 0x0600019D RID: 413 RVA: 0x000114D8 File Offset: 0x0000F6D8
	private int method_42()
	{
		return new Random().Next(0, 251);
	}

	// Token: 0x0600019E RID: 414 RVA: 0x000114F8 File Offset: 0x0000F6F8
	public void method_43()
	{
		checked
		{
			while (this.queue_0.Count != 0)
			{
				if (Operators.CompareString(this.string_6, "YES", false) != 0)
				{
					this.string_7 = this.string_5[this.random_0.Next(0, this.int_1)];
				}
				object objectValue = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(this.object_0)));
				ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue));
				object objectValue2 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(this.object_1)));
				bool flag = false;
				string text;
				try
				{
					object objectValue3 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objectValue2)));
					object objectValue4 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objectValue3)));
					Monitor.Enter(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objectValue3))), ref flag);
					try
					{
						text = this.queue_0.Peek().ToString().TrimEnd(new char[]
						{
							'\r'
						}).Trim();
						this.queue_0.Dequeue();
					}
					catch (Exception ex)
					{
					}
				}
				finally
				{
					if (flag)
					{
						object objectValue4;
						Monitor.Exit(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objectValue4))));
					}
				}
				try
				{
					using (HttpRequest httpRequest = new HttpRequest())
					{
						CookieDictionary cookies = new CookieDictionary(false);
						if (Operators.CompareString(this.string_6, "YES", false) != 0)
						{
							httpRequest.Proxy = ProxyClient.Parse(this.proxyType_0, this.string_7);
						}
						else
						{
							httpRequest.Proxy = null;
						}
						httpRequest.Cookies = cookies;
						httpRequest.AllowAutoRedirect = true;
						httpRequest.KeepAlive = true;
						httpRequest.IgnoreProtocolErrors = true;
						httpRequest.UserAgent = this.method_41();
						string string_ = httpRequest.Get(text, null).ToString();
						objectValue = RuntimeHelpers.GetObjectValue(this.object_0);
						object obj = objectValue;
						ObjectFlowControl.CheckForSyncLockOnValueType(obj);
						lock (obj)
						{
							if (this.bool_0)
							{
								this.method_44(string_, this.string_9);
							}
						}
						this.int_3++;
					}
					if (!this.bool_0)
					{
						break;
					}
				}
				catch (Exception ex2)
				{
					this.int_4++;
					this.queue_0.Enqueue(text);
					if (Operators.CompareString(this.string_6, "YES", false) != 0)
					{
						this.string_7 = this.string_5[this.random_0.Next(0, this.int_1)];
					}
				}
			}
			if (this.int_3 >= this.int_0)
			{
				this.bool_0 = false;
			}
		}
	}

	// Token: 0x0600019F RID: 415 RVA: 0x000117F8 File Offset: 0x0000F9F8
	public void method_44(string string_13, string string_14)
	{
		Regex regex = new Regex(string_14);
		MatchCollection matchCollection = regex.Matches(string_13);
		StringBuilder stringBuilder = new StringBuilder();
		IEnumerator enumerator = matchCollection.GetEnumerator();
		while (enumerator.MoveNext())
		{
			object obj = enumerator.Current;
			Match match = (Match)obj;
			stringBuilder.AppendLine(match.ToString());
		}
		if (enumerator is IDisposable)
		{
			(enumerator as IDisposable).Dispose();
		}
		this.TXT2.Text = (this.TXT2.Text + stringBuilder.ToString()).Trim();
		string_13 = null;
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x00011888 File Offset: 0x0000FA88
	public void method_45()
	{
		int num = 0;
		checked
		{
			int num2 = this.int_2 - 1;
			int num3 = num;
			for (;;)
			{
				int num4 = num3;
				int num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				this.thread_0[num3] = new Thread(new ThreadStart(this.method_43));
				this.thread_0[num3].IsBackground = true;
				this.thread_0[num3].Abort();
				this.bool_0 = false;
				num3++;
			}
		}
	}

	// Token: 0x060001A1 RID: 417 RVA: 0x00006BE8 File Offset: 0x00004DE8
	private void method_46(object sender, EventArgs e)
	{
	}

	// Token: 0x060001A2 RID: 418 RVA: 0x000118E8 File Offset: 0x0000FAE8
	private void method_47(object sender, EventArgs e)
	{
		if (this.CMType.SelectedIndex != 0)
		{
			if (this.CMType.SelectedIndex != 1)
			{
				if (this.CMType.SelectedIndex == 2)
				{
					this.string_9 = "([\\w+]{3,10}\\:[\\w+]{3,10})";
				}
				else
				{
					string left = Interaction.InputBox("Add A Specific Regex", "Specific Regex", "", -1, -1);
					if (Operators.CompareString(left, string.Empty, false) == 0)
					{
						this.CMType.SelectedIndex = 0;
						this.string_9 = "[a-zA-Z0-9._%+-]+@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}:(?:[a-zA-Z0-9]{5,})";
					}
					else
					{
						this.string_9 = left;
					}
				}
			}
			else
			{
				this.string_9 = "[a-zA-Z0-9._%+-]+@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}";
			}
		}
		else
		{
			this.string_9 = "[a-zA-Z0-9._%+-]+@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}:(?:[a-zA-Z0-9]{5,})";
		}
	}

	// Token: 0x060001A3 RID: 419 RVA: 0x00011998 File Offset: 0x0000FB98
	private void method_48(object sender, EventArgs e)
	{
		Class6.Class7_0.Search_Engine_0.ShowDialog();
	}

	// Token: 0x060001A4 RID: 420 RVA: 0x000119B8 File Offset: 0x0000FBB8
	private void method_49(object sender, EventArgs e)
	{
		this.PictureBox2.Image = Class11.Bitmap_2;
	}

	// Token: 0x060001A5 RID: 421 RVA: 0x000119D8 File Offset: 0x0000FBD8
	private void method_50(object sender, EventArgs e)
	{
		this.PictureBox2.Image = Class11.Bitmap_3;
	}

	// Token: 0x060001A6 RID: 422 RVA: 0x000119F8 File Offset: 0x0000FBF8
	private void method_51(object sender, EventArgs e)
	{
		if (Operators.CompareString(this.TextBox4.Text, string.Empty, false) != 0)
		{
			char[] separator = new char[]
			{
				'\n'
			};
			this.string_4 = File.ReadAllText(this.TextBox4.Text).Trim().TrimEnd(new char[0]).Replace(";", ":").Split(separator).Distinct<string>().ToArray<string>();
			this.int_0 = this.string_4.Length;
			this.lbl3.Text = this.int_0.ToString();
			this.CustomTabcontrol1.SelectedTab = this.TabPage2;
		}
		else
		{
			Interaction.MsgBox("No Links To Leech", MsgBoxStyle.Information, null);
		}
	}

	// Token: 0x060001A7 RID: 423 RVA: 0x00011AC0 File Offset: 0x0000FCC0
	private void method_52(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Clipboard.SetText("1BwmJGbs7gJXHE4wfYbBhqBQQpFbCaKY9j");
	}

	// Token: 0x060001A8 RID: 424 RVA: 0x00011AD8 File Offset: 0x0000FCD8
	private void method_53(object sender, EventArgs e)
	{
		this.l12.Text = this.int_3.ToString();
		this.err.Text = this.int_4.ToString();
	}

	// Token: 0x060001A9 RID: 425 RVA: 0x00011B14 File Offset: 0x0000FD14
	private void method_54(object sender, EventArgs e)
	{
		int num;
		int num3;
		object obj;
		try
		{
			IL_01:
			ProjectData.ClearProjectError();
			num = -2;
			IL_09:
			int num2 = 2;
			Application.DoEvents();
			IL_10:
			num2 = 3;
			this.lblc.Text = Conversions.ToString(this.TXT2.Lines.Count<string>());
			IL_32:
			num2 = 4;
			this.TXT2.Select(this.TXT2.Text.Length, 0);
			IL_50:
			num2 = 5;
			this.TXT2.ScrollToCaret();
			IL_5D:
			goto IL_C9;
			IL_5F:
			num3 = num2;
			if (num <= -2)
			{
				goto IL_76;
			}
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_74:
			goto IL_BE;
			IL_76:
			int num4 = num3 + 1;
			num3 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
			IL_9C:;
		}
		catch when (endfilter(obj is Exception & num != 0 & num3 == 0))
		{
			Exception ex = (Exception)obj2;
			goto IL_5F;
		}
		IL_BE:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_C9:
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	// Token: 0x060001AA RID: 426 RVA: 0x00011C04 File Offset: 0x0000FE04
	private void method_55(object sender, DragEventArgs e)
	{
		char[] separator = new char[]
		{
			'\n'
		};
		this.string_4 = File.ReadAllText(Conversions.ToString(NewLateBinding.LateIndexGet(e.Data.GetData(DataFormats.FileDrop), new object[]
		{
			0
		}, null))).Trim().TrimEnd(new char[0]).Replace(";", ":").Split(separator).Distinct<string>().ToArray<string>();
		this.int_0 = this.string_4.Length;
		this.lbl3.Text = this.int_0.ToString();
	}

	// Token: 0x060001AB RID: 427 RVA: 0x00011CAC File Offset: 0x0000FEAC
	private void method_56(object sender, DragEventArgs e)
	{
		if (e.Data.GetDataPresent(DataFormats.FileDrop))
		{
			e.Effect = DragDropEffects.All;
		}
	}

	// Token: 0x060001AC RID: 428 RVA: 0x00011CD8 File Offset: 0x0000FED8
	private void method_57(object sender, EventArgs e)
	{
		int num;
		int num4;
		object obj;
		try
		{
			IL_01:
			ProjectData.ClearProjectError();
			num = -2;
			IL_09:
			int num2 = 2;
			string path = Path.GetTempPath() + "passtoleecher.txt";
			IL_1C:
			num2 = 3;
			if (!File.Exists(path))
			{
				goto IL_30;
			}
			IL_27:
			num2 = 4;
			File.Delete(path);
			IL_30:
			num2 = 6;
			File.WriteAllText(path, this.TextBox4.Text);
			IL_44:
			num2 = 7;
			char[] separator = new char[]
			{
				'\n'
			};
			IL_55:
			num2 = 8;
			this.string_4 = File.ReadAllText(path).Trim().TrimEnd(new char[0]).Replace(";", ":").Split(separator).Distinct<string>().ToArray<string>();
			IL_93:
			num2 = 9;
			this.int_0 = this.string_4.Length;
			IL_A5:
			num2 = 10;
			this.lbl3.Text = this.int_0.ToString();
			IL_BF:
			num2 = 11;
			this.CustomTabcontrol1.SelectedIndex = 1;
			IL_CF:
			goto IL_15F;
			IL_D4:
			int num3 = num4 + 1;
			num4 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
			IL_114:
			goto IL_154;
			IL_116:
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			goto IL_131;
			IL_126:
			num4 = num2;
			if (num > -2)
			{
				goto IL_116;
			}
			goto IL_D4;
			IL_131:;
		}
		catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
		{
			Exception ex = (Exception)obj2;
			goto IL_126;
		}
		IL_154:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_15F:
		if (num4 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	// Token: 0x060001AD RID: 429 RVA: 0x00011E6C File Offset: 0x0001006C
	private void method_58(object sender, EventArgs e)
	{
		using (OpenFileDialog openFileDialog = new OpenFileDialog())
		{
			openFileDialog.Filter = "Text Files|*.txt";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.string_5 = File.ReadAllLines(openFileDialog.FileName).Distinct<string>().ToArray<string>();
				this.int_1 = this.string_5.Length;
				this.bproxy.Text = "Loaded Proxy: " + this.int_1.ToString();
			}
		}
	}

	// Token: 0x060001AE RID: 430 RVA: 0x00011F00 File Offset: 0x00010100
	private void method_59(object sender, DragEventArgs e)
	{
		this.string_5 = File.ReadAllLines(Conversions.ToString(NewLateBinding.LateIndexGet(e.Data.GetData(DataFormats.FileDrop), new object[]
		{
			0
		}, null))).Distinct<string>().ToArray<string>();
		this.int_1 = this.string_5.Length;
		this.bproxy.Text = "Loaded Proxy: " + this.int_1.ToString();
	}

	// Token: 0x060001AF RID: 431 RVA: 0x00011CAC File Offset: 0x0000FEAC
	private void method_60(object sender, DragEventArgs e)
	{
		if (e.Data.GetDataPresent(DataFormats.FileDrop))
		{
			e.Effect = DragDropEffects.All;
		}
	}

	// Token: 0x060001B0 RID: 432 RVA: 0x00011F7C File Offset: 0x0001017C
	private void method_61(object sender, EventArgs e)
	{
		if (this.text_proxyType.SelectedIndex != 3)
		{
			this.bproxy.Enabled = true;
		}
		else
		{
			this.bproxy.Enabled = false;
		}
	}

	// Token: 0x060001B1 RID: 433 RVA: 0x00011FB4 File Offset: 0x000101B4
	private void method_62(object sender, EventArgs e)
	{
		this.PictureBox1.Visible = false;
	}

	// Token: 0x060001B2 RID: 434 RVA: 0x00011FD0 File Offset: 0x000101D0
	private void method_63(object sender, EventArgs e)
	{
		this.PictureBox1.Visible = true;
	}

	// Token: 0x060001B3 RID: 435 RVA: 0x00011FEC File Offset: 0x000101EC
	private void method_64(object sender, EventArgs e)
	{
		if (this.CustomTabcontrol1.SelectedIndex == 2)
		{
			try
			{
				Class6.Class5_0.Audio.Play(Class11.UnmanagedMemoryStream_0, AudioPlayMode.BackgroundLoop);
				return;
			}
			catch (Exception ex)
			{
				return;
			}
		}
		Class6.Class5_0.Audio.Stop();
	}

	// Token: 0x060001B4 RID: 436 RVA: 0x00012050 File Offset: 0x00010250
	private void method_65(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://www.facebook.com/XSLAYER404");
	}

	// Token: 0x04000041 RID: 65
	private static List<WeakReference> list_0 = new List<WeakReference>();

	// Token: 0x04000043 RID: 67
	[AccessedThroughProperty("CustomTabcontrol1")]
	private GControl0 _CustomTabcontrol1;

	// Token: 0x04000044 RID: 68
	[AccessedThroughProperty("TabPage1")]
	private TabPage _TabPage1;

	// Token: 0x04000045 RID: 69
	[AccessedThroughProperty("TabPage2")]
	private TabPage _TabPage2;

	// Token: 0x04000046 RID: 70
	[AccessedThroughProperty("TabPage3")]
	private TabPage _TabPage3;

	// Token: 0x04000047 RID: 71
	[AccessedThroughProperty("IL_TabControl")]
	private ImageList imageList_0;

	// Token: 0x04000048 RID: 72
	[AccessedThroughProperty("RichTextBox1")]
	private RichTextBox _RichTextBox1;

	// Token: 0x04000049 RID: 73
	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	// Token: 0x0400004A RID: 74
	[AccessedThroughProperty("RichTextBox2")]
	private RichTextBox _RichTextBox2;

	// Token: 0x0400004B RID: 75
	[AccessedThroughProperty("RichTextBox3")]
	private RichTextBox _RichTextBox3;

	// Token: 0x0400004C RID: 76
	[AccessedThroughProperty("RichTextBox4")]
	private RichTextBox _RichTextBox4;

	// Token: 0x0400004D RID: 77
	[AccessedThroughProperty("TextBox3")]
	private TextBox _TextBox3;

	// Token: 0x0400004E RID: 78
	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	// Token: 0x0400004F RID: 79
	[AccessedThroughProperty("RichTextBox6")]
	private RichTextBox _RichTextBox6;

	// Token: 0x04000050 RID: 80
	[AccessedThroughProperty("RichTextBox5")]
	private RichTextBox _RichTextBox5;

	// Token: 0x04000051 RID: 81
	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	// Token: 0x04000052 RID: 82
	[AccessedThroughProperty("Button6")]
	private Button _Button6;

	// Token: 0x04000053 RID: 83
	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	// Token: 0x04000054 RID: 84
	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	// Token: 0x04000055 RID: 85
	[AccessedThroughProperty("l9")]
	private Label _l9;

	// Token: 0x04000056 RID: 86
	[AccessedThroughProperty("l6")]
	private Label _l6;

	// Token: 0x04000057 RID: 87
	[AccessedThroughProperty("l7")]
	private Label _l7;

	// Token: 0x04000058 RID: 88
	[AccessedThroughProperty("l5")]
	private Label _l5;

	// Token: 0x04000059 RID: 89
	[AccessedThroughProperty("l4")]
	private Label _l4;

	// Token: 0x0400005A RID: 90
	[AccessedThroughProperty("l8")]
	private Label _l8;

	// Token: 0x0400005B RID: 91
	[AccessedThroughProperty("TextBox4")]
	private TextBox _TextBox4;

	// Token: 0x0400005C RID: 92
	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	// Token: 0x0400005D RID: 93
	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	// Token: 0x0400005E RID: 94
	[AccessedThroughProperty("GroupBox2")]
	private GroupBox _GroupBox2;

	// Token: 0x0400005F RID: 95
	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	// Token: 0x04000060 RID: 96
	[AccessedThroughProperty("GroupBox3")]
	private GroupBox _GroupBox3;

	// Token: 0x04000061 RID: 97
	[AccessedThroughProperty("Button7")]
	private Button _Button7;

	// Token: 0x04000062 RID: 98
	[AccessedThroughProperty("BackgroundWorker1")]
	private BackgroundWorker backgroundWorker_0;

	// Token: 0x04000063 RID: 99
	[AccessedThroughProperty("BackgroundWorker2")]
	private BackgroundWorker backgroundWorker_1;

	// Token: 0x04000064 RID: 100
	[AccessedThroughProperty("BackgroundWorker3")]
	private BackgroundWorker backgroundWorker_2;

	// Token: 0x04000065 RID: 101
	[AccessedThroughProperty("BackgroundWorker4")]
	private BackgroundWorker backgroundWorker_3;

	// Token: 0x04000066 RID: 102
	[AccessedThroughProperty("BackgroundWorker5")]
	private BackgroundWorker backgroundWorker_4;

	// Token: 0x04000067 RID: 103
	[AccessedThroughProperty("BackgroundWorker6")]
	private BackgroundWorker backgroundWorker_5;

	// Token: 0x04000068 RID: 104
	[AccessedThroughProperty("BackgroundWorker7")]
	private BackgroundWorker backgroundWorker_6;

	// Token: 0x04000069 RID: 105
	[AccessedThroughProperty("CMP")]
	private ContextMenuStrip _CMP;

	// Token: 0x0400006A RID: 106
	[AccessedThroughProperty("ConfigParDefaultToolStripMenuItem")]
	private ToolStripMenuItem _ConfigParDefaultToolStripMenuItem;

	// Token: 0x0400006B RID: 107
	[AccessedThroughProperty("PastKeywordConfigToolStripMenuItem")]
	private ToolStripMenuItem _PastKeywordConfigToolStripMenuItem;

	// Token: 0x0400006C RID: 108
	[AccessedThroughProperty("ClearKeywordToolStripMenuItem")]
	private ToolStripMenuItem _ClearKeywordToolStripMenuItem;

	// Token: 0x0400006D RID: 109
	[AccessedThroughProperty("l2")]
	private Label _l2;

	// Token: 0x0400006E RID: 110
	[AccessedThroughProperty("GroupBox4")]
	private GroupBox _GroupBox4;

	// Token: 0x0400006F RID: 111
	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	// Token: 0x04000070 RID: 112
	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	// Token: 0x04000071 RID: 113
	[AccessedThroughProperty("lbl3")]
	private Label _lbl3;

	// Token: 0x04000072 RID: 114
	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	// Token: 0x04000073 RID: 115
	[AccessedThroughProperty("lbl9")]
	private Label _lbl9;

	// Token: 0x04000074 RID: 116
	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	// Token: 0x04000075 RID: 117
	[AccessedThroughProperty("GroupBox5")]
	private GroupBox _GroupBox5;

	// Token: 0x04000076 RID: 118
	[AccessedThroughProperty("Button8")]
	private Button _Button8;

	// Token: 0x04000077 RID: 119
	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	// Token: 0x04000078 RID: 120
	[AccessedThroughProperty("BTN1")]
	private Button _BTN1;

	// Token: 0x04000079 RID: 121
	[AccessedThroughProperty("BTNLoad")]
	private Button _BTNLoad;

	// Token: 0x0400007A RID: 122
	[AccessedThroughProperty("l12")]
	private Label _l12;

	// Token: 0x0400007B RID: 123
	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	// Token: 0x0400007C RID: 124
	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	// Token: 0x0400007D RID: 125
	[AccessedThroughProperty("TextBox5")]
	private TextBox _TextBox5;

	// Token: 0x0400007E RID: 126
	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	// Token: 0x0400007F RID: 127
	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	// Token: 0x04000080 RID: 128
	[AccessedThroughProperty("LinkLabel3")]
	private LinkLabel _LinkLabel3;

	// Token: 0x04000081 RID: 129
	[AccessedThroughProperty("LinkLabel2")]
	private LinkLabel _LinkLabel2;

	// Token: 0x04000082 RID: 130
	[AccessedThroughProperty("LinkLabel1")]
	private LinkLabel _LinkLabel1;

	// Token: 0x04000083 RID: 131
	[AccessedThroughProperty("Label17")]
	private Label _Label17;

	// Token: 0x04000084 RID: 132
	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	// Token: 0x04000085 RID: 133
	[AccessedThroughProperty("Label19")]
	private Label _Label19;

	// Token: 0x04000086 RID: 134
	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	// Token: 0x04000087 RID: 135
	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	// Token: 0x04000088 RID: 136
	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	// Token: 0x04000089 RID: 137
	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	// Token: 0x0400008A RID: 138
	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	// Token: 0x0400008B RID: 139
	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	// Token: 0x0400008C RID: 140
	[AccessedThroughProperty("Button10")]
	private Button _Button10;

	// Token: 0x0400008D RID: 141
	[AccessedThroughProperty("Button9")]
	private Button _Button9;

	// Token: 0x0400008E RID: 142
	[AccessedThroughProperty("CMResultat")]
	private ComboBox _CMResultat;

	// Token: 0x0400008F RID: 143
	[AccessedThroughProperty("Label23")]
	private Label _Label23;

	// Token: 0x04000090 RID: 144
	[AccessedThroughProperty("lblc")]
	private Label _lblc;

	// Token: 0x04000091 RID: 145
	[AccessedThroughProperty("RichLeech")]
	private RichTextBox _RichLeech;

	// Token: 0x04000092 RID: 146
	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	// Token: 0x04000093 RID: 147
	[AccessedThroughProperty("lblyes")]
	private Label _lblyes;

	// Token: 0x04000094 RID: 148
	[AccessedThroughProperty("lnews")]
	private Label _lnews;

	// Token: 0x04000095 RID: 149
	[AccessedThroughProperty("imgversion")]
	private PictureBox _imgversion;

	// Token: 0x04000096 RID: 150
	[AccessedThroughProperty("Button11")]
	private Button _Button11;

	// Token: 0x04000097 RID: 151
	[AccessedThroughProperty("BckYandex")]
	private BackgroundWorker backgroundWorker_7;

	// Token: 0x04000098 RID: 152
	[AccessedThroughProperty("RchYandex")]
	private RichTextBox _RchYandex;

	// Token: 0x04000099 RID: 153
	[AccessedThroughProperty("RCHp")]
	private RichTextBox _RCHp;

	// Token: 0x0400009A RID: 154
	[AccessedThroughProperty("Bgoogle")]
	private BackgroundWorker backgroundWorker_8;

	// Token: 0x0400009B RID: 155
	[AccessedThroughProperty("Leeching")]
	private BackgroundWorker backgroundWorker_9;

	// Token: 0x0400009C RID: 156
	[AccessedThroughProperty("CMType")]
	private ComboBox _CMType;

	// Token: 0x0400009D RID: 157
	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	// Token: 0x0400009E RID: 158
	[AccessedThroughProperty("Label20")]
	private Label _Label20;

	// Token: 0x0400009F RID: 159
	[AccessedThroughProperty("Label21")]
	private Label _Label21;

	// Token: 0x040000A0 RID: 160
	[AccessedThroughProperty("err")]
	private Label _err;

	// Token: 0x040000A1 RID: 161
	[AccessedThroughProperty("CERR")]
	private Label _CERR;

	// Token: 0x040000A2 RID: 162
	[AccessedThroughProperty("Label24")]
	private Label _Label24;

	// Token: 0x040000A3 RID: 163
	[AccessedThroughProperty("Toll")]
	private ToolTip toolTip_0;

	// Token: 0x040000A4 RID: 164
	[AccessedThroughProperty("Label22")]
	private Label _Label22;

	// Token: 0x040000A5 RID: 165
	[AccessedThroughProperty("LinkLabel4")]
	private LinkLabel _LinkLabel4;

	// Token: 0x040000A6 RID: 166
	[AccessedThroughProperty("numericUpDown1")]
	private NumericUpDown _numericUpDown1;

	// Token: 0x040000A7 RID: 167
	[AccessedThroughProperty("GroupBox7")]
	private GroupBox _GroupBox7;

	// Token: 0x040000A8 RID: 168
	[AccessedThroughProperty("Label25")]
	private Label _Label25;

	// Token: 0x040000A9 RID: 169
	[AccessedThroughProperty("Label26")]
	private Label _Label26;

	// Token: 0x040000AA RID: 170
	[AccessedThroughProperty("updateStats")]
	private System.Windows.Forms.Timer timer_0;

	// Token: 0x040000AB RID: 171
	[AccessedThroughProperty("TXT2")]
	private RichTextBox _TXT2;

	// Token: 0x040000AC RID: 172
	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	// Token: 0x040000AD RID: 173
	[AccessedThroughProperty("Button4")]
	private Button _Button4;

	// Token: 0x040000AE RID: 174
	[AccessedThroughProperty("bproxy")]
	private Button _bproxy;

	// Token: 0x040000AF RID: 175
	[AccessedThroughProperty("Label27")]
	private Label _Label27;

	// Token: 0x040000B0 RID: 176
	[AccessedThroughProperty("text_proxyType")]
	private ComboBox _text_proxyType;

	// Token: 0x040000B1 RID: 177
	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	// Token: 0x040000B2 RID: 178
	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	// Token: 0x040000B3 RID: 179
	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	// Token: 0x040000B4 RID: 180
	[AccessedThroughProperty("LinkLabel5")]
	private LinkLabel _LinkLabel5;

	// Token: 0x040000B5 RID: 181
	[AccessedThroughProperty("Label28")]
	private Label _Label28;

	// Token: 0x040000B6 RID: 182
	[AccessedThroughProperty("T1")]
	private ToolTip toolTip_1;

	// Token: 0x040000B7 RID: 183
	[AccessedThroughProperty("Label30")]
	private Label _Label30;

	// Token: 0x040000B8 RID: 184
	[AccessedThroughProperty("Label29")]
	private Label _Label29;

	// Token: 0x040000B9 RID: 185
	[AccessedThroughProperty("PictureBox4")]
	private PictureBox _PictureBox4;

	// Token: 0x040000BA RID: 186
	[AccessedThroughProperty("VisualStyler1")]
	private VisualStyler visualStyler_0;

	// Token: 0x040000BB RID: 187
	private readonly string[] string_0;

	// Token: 0x040000BC RID: 188
	public bool bool_0;

	// Token: 0x040000BD RID: 189
	public string string_1;

	// Token: 0x040000BE RID: 190
	public string string_2;

	// Token: 0x040000BF RID: 191
	public int int_0;

	// Token: 0x040000C0 RID: 192
	public int int_1;

	// Token: 0x040000C1 RID: 193
	public int int_2;

	// Token: 0x040000C2 RID: 194
	public string[] string_3;

	// Token: 0x040000C3 RID: 195
	public Queue queue_0;

	// Token: 0x040000C4 RID: 196
	public string[] string_4;

	// Token: 0x040000C5 RID: 197
	public object object_0;

	// Token: 0x040000C6 RID: 198
	public ProxyType proxyType_0;

	// Token: 0x040000C7 RID: 199
	public string[] string_5;

	// Token: 0x040000C8 RID: 200
	public Random random_0;

	// Token: 0x040000C9 RID: 201
	public Thread[] thread_0;

	// Token: 0x040000CA RID: 202
	public object object_1;

	// Token: 0x040000CB RID: 203
	public int int_3;

	// Token: 0x040000CC RID: 204
	public int int_4;

	// Token: 0x040000CD RID: 205
	public string string_6;

	// Token: 0x040000CE RID: 206
	private string string_7;

	// Token: 0x040000CF RID: 207
	private int int_5;

	// Token: 0x040000D0 RID: 208
	private string string_8;

	// Token: 0x040000D1 RID: 209
	private string string_9;

	// Token: 0x040000D2 RID: 210
	private HttpWebResponse httpWebResponse_0;

	// Token: 0x040000D3 RID: 211
	private CookieContainer cookieContainer_0;

	// Token: 0x040000D4 RID: 212
	private int int_6;

	// Token: 0x040000D5 RID: 213
	private int int_7;

	// Token: 0x040000D6 RID: 214
	public string[] string_10;

	// Token: 0x040000D7 RID: 215
	public string[] string_11;

	// Token: 0x040000D8 RID: 216
	private int int_8;

	// Token: 0x040000D9 RID: 217
	public bool bool_1;

	// Token: 0x040000DA RID: 218
	public string string_12;
}
