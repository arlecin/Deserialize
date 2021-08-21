using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1
{
	[XmlType("valuteData")]
	public class ValuteData
	{
		[XmlArray("docs")]
		[XmlArrayItem("doc", typeof(Doc))]
		public HashSet<Doc> Docs { get; set; }
	}
}
