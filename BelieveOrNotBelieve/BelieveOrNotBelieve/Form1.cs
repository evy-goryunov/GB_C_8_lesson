﻿using System;
using System.Windows.Forms;
namespace BelieveOrNotBelieve
{
	public partial class Form1 : Form
	{
		// База данных с вопросами
		TrueFalse database;
		public Form1()
		{
			InitializeComponent();
		}
		
		// Обработчик события изменения значения numericUpDown
		private void nudNumber_ValueChanged(object sender, EventArgs e)
		{
			tboxQuestion.Text = database[(int)nudNumber.Value - 1].text;
			tboxQuestion.Checked = database[(int)nudNumber.Value - 1].trueFalse;
		}
		
		private void miExit_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}

		private void miNew_Click_1(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				database = new TrueFalse(sfd.FileName);
				database.Add("123", true);
				database.Save();
				nudNumber.Minimum = 1;
				nudNumber.Maximum = 1;
				nudNumber.Value = 1;
			};
		}

		private void miOpen_Click_1(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				database = new TrueFalse(ofd.FileName);
				database.Load();
				nudNumber.Minimum = 1;
				nudNumber.Maximum = database.Count;
				nudNumber.Value = 1;
			}
		}

		private void miSave_Click_1(object sender, EventArgs e)
		{
			if (database != null) database.Save();
			else MessageBox.Show("База данных не создана");
		}

		private void btnAdd_Click_1(object sender, EventArgs e)
		{
			if (database == null)
			{
				MessageBox.Show("Создайте новую базу данных", "Сообщение");
				return;
			}
			database.Add((database.Count + 1).ToString(), true);
			nudNumber.Maximum = database.Count;
			nudNumber.Value = database.Count;
		}

		private void btnDelete_Click_1(object sender, EventArgs e)
		{
			if (nudNumber.Maximum == 1 || database == null) return;
			database.Remove((int)nudNumber.Value);
			nudNumber.Maximum--;
			if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
		}

		private void btnSaveQuest_Click_1(object sender, EventArgs e)
		{
			database[(int)nudNumber.Value - 1].text = tboxQuestion.Text;
			database[(int)nudNumber.Value - 1].trueFalse = tboxQuestion.Checked;
		}
	}
}
