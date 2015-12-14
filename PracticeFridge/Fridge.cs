using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFrige
{
	class Fridge : GeneralFridge
	{
		internal override double Temperature
		{ 
			get
			{
				return temperature;
			}
			set
			{
			    modeOfFridge = Modes.manual;
				temperature = value;
				if(temperature > 6)
				{
					temperature = 6;
				}
				else if(temperature < 1)
				{
					temperature = 1;
				}
			}
		} 


		public Fridge(Modes mode):base(mode)
		{
		}
		internal override Modes ModeOfFridge
		{
			get
			{
				return modeOfFridge;
			}

			set
			{
				modeOfFridge = value;
				switch (modeOfFridge)
				{
					case Modes.minimum:
						temperature = 1;
						break;
					case Modes.middle:
						temperature = 3;
						break;
					case Modes.maximum:
						temperature = 6;
						break;
					default:
						break;
				}
			}
		}
	}
}
