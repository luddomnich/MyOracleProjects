using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
	 class Fridge : GeneralFridge
	{
		 public override double Temperature
		 {
			 get
			 {
				 return temperature;
			 }
			 set
			 {
				 modeOfFridge = Modes.manual;
				 temperature = value;
				 if (temperature > 6)
				 {
					 temperature = 6;
				 }
				 else if (temperature < 1)
				 {
					 temperature = 1;
				 }
			 }
		 } 
		 public override Modes ModeOfFridge
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
		 
		 public Fridge(string name, Modes mode): base(name, mode)
		{
		}
		 
	}
}
