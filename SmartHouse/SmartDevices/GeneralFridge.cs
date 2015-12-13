using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
	abstract class GeneralFridge : OnableDevice, IHasTemperature, IHasMode, IOpenable, IHasLight
	{
		protected Modes modeOfFridge;
		protected double temperature;
		
		public bool IsOpen { get; set; }
		
		public GeneralFridge(string name, Modes mode): base(name)
		{
		      this.ModeOfFridge = mode;
		}

		public void Close()
		{
			IsOpen = false;
			IsLightOn = false;

		}
		public void Open()
		{
			IsOpen = true;
			if (IsOn)
			{
				IsLightOn = true;
			}

		}

		public abstract Modes ModeOfFridge { get; set; }


		public abstract double Temperature { get; set; }


		public bool IsLightOn { get;  set; }


		public override bool IsOn { get; set; }
		
	}
}
