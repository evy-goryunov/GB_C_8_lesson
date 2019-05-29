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
/// а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок 
/// (не создана база данных, обращение к несуществующему вопросу, открытие слишком большого файла и т.д.).
/// б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив другие «косметические» улучшения на свое усмотрение.
/// в) Добавить в приложение меню «О программе» с информацией о программе(автор, версия, авторские права и др.).
/// г)* Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных(элемент SaveFileDialog).
/// </summary>

namespace Weather_Parser
{
	public partial class Form1 : Form
	{
		public Form1()
		{

				Dictionary<string, string> citys = new Dictionary<string, string>()
				{
					["Москва"] = "https://xml.meteoservice.ru/export/gismeteo/point/7707.xml",
					["Смоленск"] = "https://xml.meteoservice.ru/export/gismeteo/point/118.xml",
					["Ярославль"] = "https://xml.meteoservice.ru/export/gismeteo/point/92.xml",
					["Владимир"] = "https://xml.meteoservice.ru/export/gismeteo/point/123.xml",
					["Владивосток"] = "https://xml.meteoservice.ru/export/gismeteo/point/98.xml"
				};

				new LoadData(this.listBox1, citys);

			InitializeComponent();

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
