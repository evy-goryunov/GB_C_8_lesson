﻿namespace BelieveOrNotBelieve
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
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.miNew = new System.Windows.Forms.ToolStripMenuItem();
			this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSaveQuest = new System.Windows.Forms.Button();
			this.nudNumber = new System.Windows.Forms.NumericUpDown();
			this.tboxQuestion = new System.Windows.Forms.CheckBox();
			this.miSave = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.miExit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(505, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 28);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(475, 210);
			this.textBox1.TabIndex = 1;
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNew,
            this.miOpen,
            this.miSave,
            this.toolStripSeparator1,
            this.miExit});
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
			this.toolStripDropDownButton1.Tag = "";
			this.toolStripDropDownButton1.Text = "File";
			// 
			// miNew
			// 
			this.miNew.Name = "miNew";
			this.miNew.Size = new System.Drawing.Size(180, 22);
			this.miNew.Text = "New";
			this.miNew.Click += new System.EventHandler(this.miNew_Click_1);
			// 
			// miOpen
			// 
			this.miOpen.Name = "miOpen";
			this.miOpen.Size = new System.Drawing.Size(180, 22);
			this.miOpen.Text = "Open";
			this.miOpen.Click += new System.EventHandler(this.miOpen_Click_1);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(13, 245);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "Добавить";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(104, 244);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "Удалить";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
			// 
			// btnSaveQuest
			// 
			this.btnSaveQuest.Location = new System.Drawing.Point(186, 244);
			this.btnSaveQuest.Name = "btnSaveQuest";
			this.btnSaveQuest.Size = new System.Drawing.Size(75, 23);
			this.btnSaveQuest.TabIndex = 4;
			this.btnSaveQuest.Text = "Сохранить";
			this.btnSaveQuest.UseVisualStyleBackColor = true;
			this.btnSaveQuest.Click += new System.EventHandler(this.btnSaveQuest_Click_1);
			// 
			// nudNumber
			// 
			this.nudNumber.Location = new System.Drawing.Point(331, 247);
			this.nudNumber.Name = "nudNumber";
			this.nudNumber.Size = new System.Drawing.Size(47, 20);
			this.nudNumber.TabIndex = 5;
			// 
			// tboxQuestion
			// 
			this.tboxQuestion.AutoSize = true;
			this.tboxQuestion.Location = new System.Drawing.Point(400, 250);
			this.tboxQuestion.Name = "tboxQuestion";
			this.tboxQuestion.Size = new System.Drawing.Size(64, 17);
			this.tboxQuestion.TabIndex = 6;
			this.tboxQuestion.Text = "Правда";
			this.tboxQuestion.UseVisualStyleBackColor = true;
			// 
			// miSave
			// 
			this.miSave.Name = "miSave";
			this.miSave.Size = new System.Drawing.Size(180, 22);
			this.miSave.Text = "Save";
			this.miSave.Click += new System.EventHandler(this.miSave_Click_1);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// miExit
			// 
			this.miExit.Name = "miExit";
			this.miExit.Size = new System.Drawing.Size(180, 22);
			this.miExit.Text = "Exit";
			this.miExit.Click += new System.EventHandler(this.miExit_Click_1);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(505, 285);
			this.Controls.Add(this.tboxQuestion);
			this.Controls.Add(this.nudNumber);
			this.Controls.Add(this.btnSaveQuest);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem miNew;
		private System.Windows.Forms.ToolStripMenuItem miOpen;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnSaveQuest;
		private System.Windows.Forms.NumericUpDown nudNumber;
		private System.Windows.Forms.CheckBox tboxQuestion;
		private System.Windows.Forms.ToolStripMenuItem miSave;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem miExit;
	}
}

