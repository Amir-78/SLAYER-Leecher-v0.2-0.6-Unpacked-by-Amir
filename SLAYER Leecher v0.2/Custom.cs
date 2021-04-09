using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000012 RID: 18
[DesignerGenerated]
public partial class Custom : Form
{
	// Token: 0x06000062 RID: 98 RVA: 0x000060CC File Offset: 0x000042CC
	[DebuggerNonUserCode]
	private static void smethod_0(object object_0)
	{
		List<WeakReference> obj = Custom.list_0;
		checked
		{
			lock (obj)
			{
				if (Custom.list_0.Count == Custom.list_0.Capacity)
				{
					int num = 0;
					int num2 = 0;
					int num3 = Custom.list_0.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = Custom.list_0[num4];
						if (weakReference.IsAlive)
						{
							if (num4 != num)
							{
								Custom.list_0[num] = Custom.list_0[num4];
							}
							num++;
						}
						num4++;
					}
					Custom.list_0.RemoveRange(num, Custom.list_0.Count - num);
					Custom.list_0.Capacity = Custom.list_0.Count;
				}
				Custom.list_0.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_0)));
			}
		}
	}

	// Token: 0x06000063 RID: 99 RVA: 0x000061BC File Offset: 0x000043BC
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

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x06000065 RID: 101 RVA: 0x00006698 File Offset: 0x00004898
	// (set) Token: 0x06000066 RID: 102 RVA: 0x000066B0 File Offset: 0x000048B0
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

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x06000067 RID: 103 RVA: 0x000066C4 File Offset: 0x000048C4
	// (set) Token: 0x06000068 RID: 104 RVA: 0x000066DC File Offset: 0x000048DC
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

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x06000069 RID: 105 RVA: 0x000066F0 File Offset: 0x000048F0
	// (set) Token: 0x0600006A RID: 106 RVA: 0x00006708 File Offset: 0x00004908
	internal virtual Button OKE
	{
		[DebuggerNonUserCode]
		get
		{
			return this._OKE;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.method_2);
			if (this._OKE != null)
			{
				this._OKE.Click -= value2;
			}
			this._OKE = value;
			if (this._OKE != null)
			{
				this._OKE.Click += value2;
			}
		}
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x0600006B RID: 107 RVA: 0x00006760 File Offset: 0x00004960
	// (set) Token: 0x0600006C RID: 108 RVA: 0x00006778 File Offset: 0x00004978
	internal virtual TextBox Frm
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Frm;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Frm = value;
		}
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x0600006D RID: 109 RVA: 0x0000678C File Offset: 0x0000498C
	// (set) Token: 0x0600006E RID: 110 RVA: 0x000067A4 File Offset: 0x000049A4
	internal virtual TextBox Too
	{
		[DebuggerNonUserCode]
		get
		{
			return this._Too;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this._Too = value;
		}
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x0600006F RID: 111 RVA: 0x000067B8 File Offset: 0x000049B8
	// (set) Token: 0x06000070 RID: 112 RVA: 0x000067D0 File Offset: 0x000049D0
	internal virtual DateTimePicker DT1
	{
		[DebuggerNonUserCode]
		get
		{
			return this._DT1;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.method_3);
			if (this._DT1 != null)
			{
				this._DT1.ValueChanged -= value2;
			}
			this._DT1 = value;
			if (this._DT1 != null)
			{
				this._DT1.ValueChanged += value2;
			}
		}
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x06000071 RID: 113 RVA: 0x00006828 File Offset: 0x00004A28
	// (set) Token: 0x06000072 RID: 114 RVA: 0x00006840 File Offset: 0x00004A40
	internal virtual DateTimePicker DT2
	{
		[DebuggerNonUserCode]
		get
		{
			return this._DT2;
		}
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.method_4);
			if (this._DT2 != null)
			{
				this._DT2.ValueChanged -= value2;
			}
			this._DT2 = value;
			if (this._DT2 != null)
			{
				this._DT2.ValueChanged += value2;
			}
		}
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00006898 File Offset: 0x00004A98
	public Custom()
	{
		base.Load += this.Custom_Load;
		Custom.smethod_0(this);
		this.InitializeComponent();
	}

	// Token: 0x06000074 RID: 116 RVA: 0x000068CC File Offset: 0x00004ACC
	public bool method_0(string string_0)
	{
		bool result;
		try
		{
			DateTime.ParseExact(string_0, "MM/dd/yyyy", CultureInfo.InvariantCulture);
			result = true;
		}
		catch (FormatException ex)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00006910 File Offset: 0x00004B10
	public object method_1(ref string string_0)
	{
		string[] array = this.Frm.Text.Split(new char[]
		{
			'/'
		});
		string[] array2 = this.Too.Text.Split(new char[]
		{
			'/'
		});
		string_0 = string.Format("https://www.google.fr/search?q=site:pastebin.com+@yahoo.fr&num=100&tbs=cdr%3A1%2Ccd_min%3A{0}%2F{1}%2F{2}%2Ccd_max%3A{3}%2F{4}%2F{5}&tbm=", new object[]
		{
			array[0],
			array[1],
			array[2],
			array2[0],
			array2[1],
			array2[2]
		});
		object result;
		return result;
	}

	// Token: 0x06000076 RID: 118 RVA: 0x0000699C File Offset: 0x00004B9C
	private void method_2(object sender, EventArgs e)
	{
		if (Operators.CompareString(this.Frm.Text, null, false) == 0 & Operators.CompareString(this.Too.Text, null, false) == 0)
		{
			Class6.Class7_0.Form1_0.CMResultat.SelectedIndex = 0;
			this.Close();
		}
		else if (this.method_0(this.Frm.Text) & this.method_0(this.Too.Text))
		{
			this.method_1(ref Class6.Class7_0.Form1_0.string_12);
			Class6.Class7_0.Form1_0.bool_1 = true;
			this.Close();
		}
		else
		{
			Interaction.MsgBox("invalid date range\r\ndate must be : mm/dd/yyyy", MsgBoxStyle.Exclamation, "X-SLAYER");
		}
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00006A5C File Offset: 0x00004C5C
	private void Custom_Load(object sender, EventArgs e)
	{
		this.Frm.Text = this.DT1.Text;
		this.Too.Text = this.DT2.Text;
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00006A98 File Offset: 0x00004C98
	private void method_3(object sender, EventArgs e)
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
			this.Frm.Text = this.DT1.Text;
			IL_21:
			goto IL_81;
			IL_23:
			int num3 = num4 + 1;
			num4 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
			IL_3D:
			goto IL_76;
			IL_3F:
			num4 = num2;
			if (num <= -2)
			{
				goto IL_23;
			}
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_54:;
		}
		catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
		{
			Exception ex = (Exception)obj2;
			goto IL_3F;
		}
		IL_76:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_81:
		if (num4 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	// Token: 0x06000079 RID: 121 RVA: 0x00006B40 File Offset: 0x00004D40
	private void method_4(object sender, EventArgs e)
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
			this.Too.Text = this.DT2.Text;
			IL_21:
			goto IL_81;
			IL_23:
			num3 = num2;
			if (num <= -2)
			{
				goto IL_3A;
			}
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_38:
			goto IL_76;
			IL_3A:
			int num4 = num3 + 1;
			num3 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num4);
			IL_54:;
		}
		catch when (endfilter(obj is Exception & num != 0 & num3 == 0))
		{
			Exception ex = (Exception)obj2;
			goto IL_23;
		}
		IL_76:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_81:
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	// Token: 0x04000037 RID: 55
	private static List<WeakReference> list_0 = new List<WeakReference>();

	// Token: 0x04000038 RID: 56
	private IContainer icontainer_0;

	// Token: 0x04000039 RID: 57
	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	// Token: 0x0400003A RID: 58
	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	// Token: 0x0400003B RID: 59
	[AccessedThroughProperty("OKE")]
	private Button _OKE;

	// Token: 0x0400003C RID: 60
	[AccessedThroughProperty("Frm")]
	private TextBox _Frm;

	// Token: 0x0400003D RID: 61
	[AccessedThroughProperty("Too")]
	private TextBox _Too;

	// Token: 0x0400003E RID: 62
	[AccessedThroughProperty("DT1")]
	private DateTimePicker _DT1;

	// Token: 0x0400003F RID: 63
	[AccessedThroughProperty("DT2")]
	private DateTimePicker _DT2;
}
