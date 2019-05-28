using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Parser
{
	class WeatherData
	{
		public string CityName { get; set; }
		public string TempMin { get { return $"{tempMin}c"; } set { tempMin = value; } }
		public string TempMax { get { return $"{tempMax}c"; } set { tempMax = value; } }

		string tempMin, tempMax;

		public override string ToString()
		{
			return this.CityName;
		}
	}
}
