using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

// Token: 0x02000016 RID: 22
public class GControl0 : TabControl
{
	// Token: 0x060001CF RID: 463 RVA: 0x00012C10 File Offset: 0x00010E10
	[DebuggerNonUserCode]
	private static void smethod_0(object object_0)
	{
		List<WeakReference> obj = GControl0.list_0;
		checked
		{
			lock (obj)
			{
				if (GControl0.list_0.Count == GControl0.list_0.Capacity)
				{
					int num = 0;
					int num2 = 0;
					int num3 = GControl0.list_0.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = GControl0.list_0[num4];
						if (weakReference.IsAlive)
						{
							if (num4 != num)
							{
								GControl0.list_0[num] = GControl0.list_0[num4];
							}
							num++;
						}
						num4++;
					}
					GControl0.list_0.RemoveRange(num, GControl0.list_0.Count - num);
					GControl0.list_0.Capacity = GControl0.list_0.Count;
				}
				GControl0.list_0.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_0)));
			}
		}
	}

	// Token: 0x060001D0 RID: 464 RVA: 0x00012D00 File Offset: 0x00010F00
	public GControl0()
	{
		GControl0.smethod_0(this);
		this.timer_0 = new Timer
		{
			Interval = 5,
			Enabled = false
		};
		this.double_0 = 0.0;
		this.color_0 = Color.FromArgb(30, 10, 100, 200);
		this.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		this.DoubleBuffered = true;
		this.DrawMode = TabDrawMode.OwnerDrawFixed;
		this.Alignment = TabAlignment.Left;
		this.SizeMode = TabSizeMode.Fixed;
		Size itemSize = new Size(40, 150);
		this.ItemSize = itemSize;
		this.Dock = DockStyle.Fill;
		this.Font = new Font("Segoe UI", 10f);
	}

	// Token: 0x060001D1 RID: 465 RVA: 0x00012DB4 File Offset: 0x00010FB4
	protected virtual void OnPaint(PaintEventArgs e)
	{
		e.Graphics.Clear(SystemColors.Control);
		int num = 0;
		checked
		{
			try
			{
				foreach (object obj in this.TabPages)
				{
					TabPage tabPage = (TabPage)obj;
					Rectangle tabRect = this.GetTabRect(num);
					Rectangle r = new Rectangle(tabRect.X + 52, tabRect.Y + 5, tabRect.Width - 55, tabRect.Height - 10);
					if (!this.DesignMode)
					{
						tabPage.BackColor = SystemColors.Control;
						tabPage.ForeColor = Color.Black;
					}
					if (num != this.TabPages.Count - 1)
					{
						Point pt = new Point(12, tabRect.Bottom - 1);
						Point pt2 = new Point(tabRect.Width - 24, tabRect.Bottom - 1);
						e.Graphics.DrawLine(new Pen(Color.FromArgb(210, 210, 210)), pt, pt2);
					}
					if (num == this.SelectedIndex)
					{
						Rectangle rect = new Rectangle(5, tabRect.Y, tabRect.Width - 13, tabRect.Height);
						e.Graphics.FillRectangle(new SolidBrush(this.color_0), rect);
						rect = new Rectangle(5, tabRect.Y - 1, tabRect.Width - 13, tabRect.Height);
						e.Graphics.DrawRectangle(new Pen(Color.FromArgb(65, 186, 255)), rect);
						rect = new Rectangle((int)Math.Round(Math.Round(unchecked(this.double_0 * (double)(checked(this.ItemSize.Height * 2))))), tabRect.Y, tabRect.Width, tabRect.Height);
						LinearGradientBrush brush = new LinearGradientBrush(rect, Color.Gray, Color.Transparent, 0f);
						rect = new Rectangle(5, tabRect.Y - 1, tabRect.Width - 13, tabRect.Height);
						e.Graphics.DrawRectangle(new Pen(brush), rect);
					}
					if (this.ImageList != null && num < this.ImageList.Images.Count)
					{
						e.Graphics.InterpolationMode = InterpolationMode.Bicubic;
						Rectangle rect = new Rectangle(tabRect.X + 10, tabRect.Y + 4, 32, 32);
						e.Graphics.DrawImage(this.ImageList.Images[num], rect);
					}
					StringFormat stringFormat = new StringFormat();
					stringFormat.LineAlignment = StringAlignment.Center;
					e.Graphics.DrawString(tabPage.Text, this.Font, Brushes.Black, r, stringFormat);
					e.Graphics.DrawLine(new Pen(Color.FromArgb(200, 200, 200)), this.ItemSize.Height - 2, 5, this.ItemSize.Height - 2, this.Height - 5);
					num++;
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
		}
	}

	// Token: 0x060001D2 RID: 466 RVA: 0x000130F8 File Offset: 0x000112F8
	protected virtual void OnSelectedIndexChanged(EventArgs e)
	{
		base.OnSelectedIndexChanged(e);
		this.double_0 = 0.0;
		this.timer_0.Start();
	}

	// Token: 0x060001D3 RID: 467 RVA: 0x00013128 File Offset: 0x00011328
	private void method_0(object sender, EventArgs e)
	{
		this.double_0 += 0.02;
		if (this.double_0 > 1.0)
		{
			this.timer_0.Stop();
			this.double_0 = 1.0;
		}
		this.Invalidate();
	}

	// Token: 0x17000092 RID: 146
	// (get) Token: 0x060001D4 RID: 468 RVA: 0x00013180 File Offset: 0x00011380
	// (set) Token: 0x060001D5 RID: 469 RVA: 0x00013198 File Offset: 0x00011398
	public Color Color_0
	{
		get
		{
			return this.color_0;
		}
		set
		{
			this.color_0 = value;
			this.Invalidate();
		}
	}

	// Token: 0x040000E6 RID: 230
	private static List<WeakReference> list_0 = new List<WeakReference>();

	// Token: 0x040000E7 RID: 231
	private Color color_0;

	// Token: 0x040000E8 RID: 232
	[AccessedThroughProperty("tmrAnimation")]
	private Timer timer_0;

	// Token: 0x040000E9 RID: 233
	private double double_0;
}
