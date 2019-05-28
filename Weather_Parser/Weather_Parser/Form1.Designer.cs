namespace Weather_Parser
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblTempValueMax = new System.Windows.Forms.Label();
			this.lblTempValueMin = new System.Windows.Forms.Label();
			this.max = new System.Windows.Forms.Label();
			this.min = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(12, 12);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(239, 420);
			this.listBox1.TabIndex = 0;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblTempValueMax);
			this.groupBox1.Controls.Add(this.lblTempValueMin);
			this.groupBox1.Controls.Add(this.max);
			this.groupBox1.Controls.Add(this.min);
			this.groupBox1.Location = new System.Drawing.Point(257, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(86, 88);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Temperature";
			// 
			// lblTempValueMax
			// 
			this.lblTempValueMax.AutoSize = true;
			this.lblTempValueMax.Location = new System.Drawing.Point(38, 51);
			this.lblTempValueMax.Name = "lblTempValueMax";
			this.lblTempValueMax.Size = new System.Drawing.Size(35, 13);
			this.lblTempValueMax.TabIndex = 3;
			this.lblTempValueMax.Text = "label4";
			// 
			// lblTempValueMin
			// 
			this.lblTempValueMin.AutoSize = true;
			this.lblTempValueMin.Location = new System.Drawing.Point(38, 26);
			this.lblTempValueMin.Name = "lblTempValueMin";
			this.lblTempValueMin.Size = new System.Drawing.Size(35, 13);
			this.lblTempValueMin.TabIndex = 2;
			this.lblTempValueMin.Text = "label3";
			// 
			// max
			// 
			this.max.AutoSize = true;
			this.max.Location = new System.Drawing.Point(6, 51);
			this.max.Name = "max";
			this.max.Size = new System.Drawing.Size(29, 13);
			this.max.TabIndex = 1;
			this.max.Text = "max:";
			// 
			// min
			// 
			this.min.AutoSize = true;
			this.min.Location = new System.Drawing.Point(6, 26);
			this.min.Name = "min";
			this.min.Size = new System.Drawing.Size(26, 13);
			this.min.TabIndex = 0;
			this.min.Text = "min:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(759, 450);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.listBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblTempValueMax;
		private System.Windows.Forms.Label lblTempValueMin;
		private System.Windows.Forms.Label max;
		private System.Windows.Forms.Label min;
	}
}

