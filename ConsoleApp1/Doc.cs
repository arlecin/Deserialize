﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1
{
	[XmlType("doc")]
	public class Doc
	{
		[XmlElement("name")]
		public string Name { get; set; }
	}
}
