using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
	abstract class  SmartObj
	{
		public string Name { get; set; }

		public SmartObj (string name)
		{
			Name = name;


		}
	}
}
