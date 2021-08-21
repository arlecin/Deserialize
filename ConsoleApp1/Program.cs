using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			var formatter = new XmlSerializer(typeof(Diffgr));

			using (FileStream fs = new FileStream(@"D:\Temp\2.xml", FileMode.OpenOrCreate))
			{
				var diffgr = (Diffgr)formatter.Deserialize(fs);
			}

			Console.WriteLine("Ok");
		}
	}
}
