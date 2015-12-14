using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFrige
{
	abstract class GeneralFridge
	{
		internal abstract double Temperature { get; set; } 
		internal abstract Modes ModeOfFridge { get; set; }
		protected double temperature;
		protected Modes modeOfFridge;
		internal bool powerStatus { get; private set; }
		internal bool isOpen { get; private set; }
		//public bool IsLightOn { get { return IsOpen && PowerStatus;  } }
		internal bool isLightOn { get; private set; }
		////internal GeneralFridge()
		//{
		//}
		public GeneralFridge(Modes mode)
		{
			this.ModeOfFridge = mode;
		}
		/*
		public GeneralFridge(double t, Modes m, bool s, bool i)
		{
			Temperature = t;
			ModeOfFridge = m;
			PowerStatus = s;
			IsOpen = i;
		}
		 */

		public void On()
		{
			powerStatus = true;
		}
		public void Off()
		{
			powerStatus = false;
		}
		public void Close()
		{
			isOpen = false;
			isLightOn = false;
			
		}
		public void Open()
		{
			isOpen = true;
			if (powerStatus)
			{
				isLightOn = true;
			}
			
		}

		public string Info()
		{
			string power;
			if(powerStatus)
			{
				power = "включен";
			}
			else
			{
				power = "выключен";
			}

			string mode;
			if (modeOfFridge == Modes.minimum)
			{
				mode = "минимальный";
			}
			else if(modeOfFridge == Modes.middle)
			{
				mode = "средний";
			}
			else if (modeOfFridge == Modes.maximum)
			{
				mode = "максимальный";
			}

			else
			{
				mode = "другой";
			}

			string light;
			if (isLightOn)
			{
				light = "включен";
			}
			else
			{
				light = "выключен";
			}
			string door;
			 if(isOpen)
			 {
				 door = "открыта";
			 }
			else
			 {
				 door = "закрыта";
			 }


			return "Состояние : " + power + ", Температурный режим: " + mode +  ", Дверь: " + door +",\n Свет: " + light + ", Температура: " + Temperature;
		}
	}
}
