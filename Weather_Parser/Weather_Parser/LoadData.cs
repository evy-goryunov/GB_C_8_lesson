using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Weather_Parser
{
	class LoadData
	{
		WebClient client;

		public LoadData(ListBox f, Dictionary<string,string> CityNames)
		{
			client = new WebClient() { Encoding = Encoding.UTF8 };

			foreach (var intem in CityNames)
			{
				f.Items.Add(GetData(intem));
			}
		}

		private WeatherData GetData(KeyValuePair<string,string> pair)
		{
			WeatherData wet = new WeatherData();
			
			string xml = client.DownloadString(pair.Value);
			//Console.WriteLine(xml);

			var res = XDocument.Parse(xml)
								.Descendants("MMWEATHER")
								.Descendants("REPORT")
								.Descendants("TOWN")
								.Descendants("FORECAST")
								.ToArray();

			foreach (var e in res)
			{
				wet.TempMin = e.Element("TEMPERATURE").Attribute("min").Value;
				wet.TempMax = e.Element("TEMPERATURE").Attribute("max").Value;
				break;
			}

			wet.CityName = pair.Key;

			return wet; 
		}

	}
}
