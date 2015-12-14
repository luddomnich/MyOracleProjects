using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFrige
{
	class Freezer : GeneralFridge
	{
		public Freezer(Modes mode):base(mode)
		{
		}
		internal override double Temperature
		{
			get
			{
				return temperature;
			}
			set
			{
				temperature = value;
				if (temperature > -1)
				{
					temperature = -1;
				}
				else if (temperature < -10)
				{
					temperature = -10;
				}
			}
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
						temperature = -10;
						break;
					case Modes.middle:
						temperature = -5;
						break;
					case Modes.maximum:
						temperature = -1;
						break;
					default:
						break;
				}
			}
		}
	}

}
