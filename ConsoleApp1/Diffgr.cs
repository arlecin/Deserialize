using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1
{
	[XmlRoot("diffgram", Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1")]
	public class Diffgr
	{
		[XmlElement("valuteData", Namespace = "")]
		public ValuteData ValuteData { get; set; }
	}
}
