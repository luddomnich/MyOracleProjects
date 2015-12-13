using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
	class Oven : OnableDevice, IHasTemperature, IHasTimer, IOpenable, IHasLight 
	{

		     public bool IsLightOn { get; set; }
			 public Oven(string name) : base(name)
			 {
				
			 }

			 public double Temperature { get; set; }


			 public TimeSpan Time { get; set; }

			 
			 public override bool IsOn { get; set; }





			 public bool IsOpen
			 {
				 get;
				 set;

			 }

			 public void Open()
			 {
				 IsOpen = true;
				 if (IsOn)
				 {
					 IsLightOn = true;
				 }
			 }

			 public void Close()
			 {
				 IsOpen = false;
			 }

			
	}
}
