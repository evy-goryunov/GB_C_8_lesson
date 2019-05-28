using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_Parser
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			Dictionary<string, string> citys = new Dictionary<string, string>()
			{ 
				["Москва"] = "https://xml.meteoservice.ru/export/gismeteo/point/7707.xml",
				["Смоленск"] = "https://xml.meteoservice.ru/export/gismeteo/point/118.xml",
				["Ярославль"] = "https://xml.meteoservice.ru/export/gismeteo/point/92.xml",
				["Владимир"] = "https://xml.meteoservice.ru/export/gismeteo/point/123.xml",
				["Владивосток"] = "https://xml.meteoservice.ru/export/gismeteo/point/98.xml"
			};

			new LoadData(this.listBox1, citys);


		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			WeatherData w = listBox1.SelectedItem as WeatherData;

			groupBox1.Text = w.CityName;
			lblTempValueMax.Text = w.TempMax;
			lblTempValueMin.Text = w.TempMin;
		}
	}
}
