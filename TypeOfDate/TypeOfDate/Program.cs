using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace TypeOfDate
{
	class Program
	{
		static void Main(string[] args)
		{
			Type typeOfDateTime = typeof(DateTime);
			foreach (var p in typeOfDateTime.GetProperties()) { Console.WriteLine(p.Name); }
		}
	}
}
