namespace timestampyo
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000006 RID: 6 RVA: 0x000021E1 File Offset: 0x000003E1
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002200 File Offset: 0x00000400
		private void InitializeComponent()
		{
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.yyyy = new global::System.Windows.Forms.TextBox();
			this.dd = new global::System.Windows.Forms.TextBox();
			this.MM = new global::System.Windows.Forms.TextBox();
			this.hh = new global::System.Windows.Forms.TextBox();
			this.Mi = new global::System.Windows.Forms.TextBox();
			this.ss = new global::System.Windows.Forms.TextBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.convertedText = new global::System.Windows.Forms.TextBox();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.label7 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 6.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(58, 7);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(23, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "Year";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 6.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(111, 7);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(22, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "Day";
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 6.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.Location = new global::System.Drawing.Point(150, 7);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(32, 12);
			this.label3.TabIndex = 2;
			this.label3.Text = "Month";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 6.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.Location = new global::System.Drawing.Point(205, 7);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(25, 12);
			this.label4.TabIndex = 3;
			this.label4.Text = "Hour";
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 6.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.Location = new global::System.Drawing.Point(246, 7);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(21, 12);
			this.label5.TabIndex = 4;
			this.label5.Text = "Min";
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 6.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.Location = new global::System.Drawing.Point(286, 7);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(21, 12);
			this.label6.TabIndex = 5;
			this.label6.Text = "Sec";
			this.yyyy.Location = new global::System.Drawing.Point(45, 22);
			this.yyyy.MaxLength = 4;
			this.yyyy.Name = "yyyy";
			this.yyyy.Size = new global::System.Drawing.Size(52, 20);
			this.yyyy.TabIndex = 6;
			this.yyyy.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.dd.Location = new global::System.Drawing.Point(110, 22);
			this.dd.MaxLength = 2;
			this.dd.Name = "dd";
			this.dd.Size = new global::System.Drawing.Size(25, 20);
			this.dd.TabIndex = 7;
			this.dd.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.MM.Location = new global::System.Drawing.Point(153, 22);
			this.MM.MaxLength = 2;
			this.MM.Name = "MM";
			this.MM.Size = new global::System.Drawing.Size(25, 20);
			this.MM.TabIndex = 8;
			this.MM.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.hh.Location = new global::System.Drawing.Point(205, 22);
			this.hh.MaxLength = 2;
			this.hh.Name = "hh";
			this.hh.Size = new global::System.Drawing.Size(25, 20);
			this.hh.TabIndex = 9;
			this.hh.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.Mi.Location = new global::System.Drawing.Point(245, 22);
			this.Mi.MaxLength = 2;
			this.Mi.Name = "Mi";
			this.Mi.Size = new global::System.Drawing.Size(25, 20);
			this.Mi.TabIndex = 10;
			this.Mi.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.ss.Location = new global::System.Drawing.Point(284, 22);
			this.ss.MaxLength = 2;
			this.ss.Name = "ss";
			this.ss.Size = new global::System.Drawing.Size(25, 20);
			this.ss.TabIndex = 11;
			this.ss.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.button1.Location = new global::System.Drawing.Point(140, 48);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(79, 22);
			this.button1.TabIndex = 12;
			this.button1.Text = "generate";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.convertedText.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.convertedText.ForeColor = global::System.Drawing.SystemColors.MenuHighlight;
			this.convertedText.Location = new global::System.Drawing.Point(98, 78);
			this.convertedText.MaxLength = 327676874;
			this.convertedText.Name = "convertedText";
			this.convertedText.Size = new global::System.Drawing.Size(164, 20);
			this.convertedText.TabIndex = 13;
			this.convertedText.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.button2.Location = new global::System.Drawing.Point(188, 104);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(74, 29);
			this.button2.TabIndex = 14;
			this.button2.Text = "reset";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button3.Location = new global::System.Drawing.Point(98, 104);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(74, 29);
			this.button3.TabIndex = 15;
			this.button3.Text = "copy";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 6.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.Location = new global::System.Drawing.Point(137, 137);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(83, 12);
			this.label7.TabIndex = 16;
			this.label7.Text = "created by Inaudax";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(363, 158);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.convertedText);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.ss);
			base.Controls.Add(this.Mi);
			base.Controls.Add(this.hh);
			base.Controls.Add(this.MM);
			base.Controls.Add(this.dd);
			base.Controls.Add(this.yyyy);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			this.MaximumSize = new global::System.Drawing.Size(379, 196);
			this.MinimumSize = new global::System.Drawing.Size(379, 196);
			base.Name = "Form1";
			this.Text = "Playstation 3 Trophy Timestamp Generator";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000001 RID: 1
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000002 RID: 2
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.TextBox yyyy;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.TextBox dd;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.TextBox MM;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.TextBox hh;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.TextBox Mi;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.TextBox ss;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.TextBox convertedText;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.Label label7;
	}
}
