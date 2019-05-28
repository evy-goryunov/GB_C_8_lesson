using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Горюнов Евгений
/// Создайте простую форму на котором свяжите свойство Text элемента TextBox со свойством Value элемента NumericUpDown
/// </summary>

namespace TextBoxAndNumeric
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			numericUpDown1.Value = Int32.Parse(textBox1.Text);
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			textBox1.Text = numericUpDown1.Value.ToString();
		}
	}
}
