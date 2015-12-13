using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
	 class Freezer : GeneralFridge
	{
		  public override double Temperature
		 {
			 get
			 {
				 return temperature;
			 }
			 set
			 {
				 temperature = value;
				 if (Temperature > -1)
				 {
					 Temperature = -1;
				 }
				 else if (Temperature < -10)
				 {
					 Temperature = -10;
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
				 switch (ModeOfFridge)
				 {
					 case Modes.minimum:
						 Temperature = -10;
						 break;
					 case Modes.middle:
						 Temperature = -5;
						 break;
					 case Modes.maximum:
						 Temperature = -1;
						 break;
					 default:
						 break;
				 }
			 }
		 }
		
		 public Freezer(string name, Modes mode)
			 : base(name, mode)
		{
		}
	}
}
