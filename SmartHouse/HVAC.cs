using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
	abstract class HVAC : OnableDevice, IHasTemperature
	{
		public override bool IsOn { get; set; }
		public double Temperature { get; set; }
		  public HVAC (string name) : base(name)
			 {

			 }

		  
	}
}
