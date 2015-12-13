using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
	public interface IOpenable
	{
		bool IsOpen
		{
			get;
			set;
		}
	
		void Open();

		void Close();
	}
}
