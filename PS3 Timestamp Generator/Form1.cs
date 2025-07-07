using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;

namespace timestampyo
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Form1()
		{
			this.InitializeComponent();
			base.Icon = new Icon(Assembly.GetExecutingAssembly().GetManifestResourceStream("timestampyo.plat.ico"));
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002078 File Offset: 0x00000278
		private void button1_Click(object sender, EventArgs e)
		{
			string s = string.Concat(new string[]
			{
				this.yyyy.Text,
				this.dd.Text,
				this.MM.Text,
				this.hh.Text,
				this.Mi.Text,
				this.ss.Text
			});
			DateTime dateTime;
			if (!DateTime.TryParseExact(s, "yyyyddMMHHmmss", null, DateTimeStyles.None, out dateTime))
			{
				return;
			}
			long ticks = dateTime.Ticks;
			long num = ticks / 10L;
			this.convertedText.Text = num.ToString("X");
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002128 File Offset: 0x00000328
		private void button2_Click(object sender, EventArgs e)
		{
			this.convertedText.Text = "";
			this.yyyy.Text = "";
			this.dd.Text = "";
			this.MM.Text = "";
			this.hh.Text = "";
			this.Mi.Text = "";
			this.ss.Text = "";
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000021A5 File Offset: 0x000003A5
		private void button3_Click(object sender, EventArgs e)
		{
			if (this.convertedText.Text.Equals(""))
			{
				return;
			}
			Clipboard.SetText(this.convertedText.Text);
			this.convertedText.Text = Clipboard.GetText();
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021DF File Offset: 0x000003DF
		private void Form1_Load(object sender, EventArgs e)
		{
		}
	}
}
