using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
	public interface IOnOff
	{
		bool IsOn
		{
			get;
			set;
		}

	}
}
