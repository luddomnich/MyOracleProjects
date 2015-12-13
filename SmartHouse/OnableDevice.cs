using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
	abstract class OnableDevice : SmartObj, IOnOff
	{
		public abstract bool IsOn { get; set; }
		public  OnableDevice(string name) : base(name)
		{
		}
	}
}
