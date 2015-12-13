using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHouse
{
	public class ObjManager
	{
		public void Start()
		{
			List<SmartObj> objs = new List<SmartObj>();
			objs.Add(new Freezer("Морозильная камера", Modes.minimum));
			objs.Add(new Fridge("Холодильник", Modes.minimum));
			objs.Add(new Oven("Духовка"));
			objs.Add(new Closet("Гардероб"));
			objs.Add(new Heater("Обогрев дома"));
			objs.Add(new AirConditioner("Кондиционер"));

			
			while (true)
			{
				Console.Clear();
				byte ObgNumber = 1;
				foreach (var deviсe in objs)
				{
					Console.WriteLine("{0} - Выбрать {1}", ObgNumber++, deviсe.Name);
				}
					Console.WriteLine("0 - Выход");
					Console.WriteLine("Введите номер приборa: ");
					try
					{
						int devNum = Convert.ToInt32(Console.ReadLine());
						if (devNum == 0)
						{
							return;
						}
						DeviceAbility(objs[devNum - 1]);
					}
					catch (Exception)
					{
						Console.WriteLine("Неверный номер");
						Console.ReadLine();
					}
			}
		}

		private void DeviceAbility(SmartObj smartObj)
		{
			Console.Clear();
			while(true)
			{
				Console.WriteLine("Операции для фигуры " + smartObj.Name + ":");
				 
				if (smartObj is IOnOff)
				{
					Console.WriteLine("toff - включить");
					Console.WriteLine("ton - выключить");

				}
				if ( smartObj is IHasTemperature)
				{
					Console.WriteLine("gt - получить темрпературу ");
					Console.WriteLine("st - установить температуру");
				}
				if (smartObj is IOpenable)
				{
					Console.WriteLine("o - открыть ");
					Console.WriteLine("c - закрыть ");
				}
				if (smartObj is IHasMode)
				{
					Console.WriteLine("gm - получить режим");
					Console.WriteLine("sm - установить режим");
				}
				if (smartObj is IHasTimer)
				{
					Console.WriteLine("gtm - получить время");
					Console.WriteLine("stm - установить таймер");
				}
				Console.WriteLine("b - вернуться в главное меню");
				Console.Write("Введите команду: ");
				string command = Console.ReadLine();
				Console.Clear();
				switch (command)
				{
					case "toff":
						if (smartObj is IOnOff)
						{
							((IOnOff)smartObj).IsOn = false;
							Console.WriteLine("Прибор : " + (((IOnOff)smartObj).IsOn ? "Включен" : "Выключен"));
						}
						break;

					case "ton":
						if (smartObj is IOnOff)
						{
							((IOnOff)smartObj).IsOn = true;
							Console.WriteLine("Прибор : " + (((IOnOff)smartObj).IsOn ? "Включен" : "Выключен"));
						}
						break;
						
					case "gt":
						 if (smartObj is IHasTemperature)
                        {
							Console.WriteLine("Teмпература : " + ((IHasTemperature)smartObj).Temperature);
                        }
                        break;
						
					case "st":
						if (smartObj is IHasTemperature)
						{
							 Console.Write("Укажите значение температуры : ");
							 ((IHasTemperature)smartObj).Temperature = Convert.ToDouble(Console.ReadLine());
							 Console.Clear();
							 Console.WriteLine("Teмпература : " + ((IHasTemperature)smartObj).Temperature);

						}

						break;
					case "o":

						
						if (smartObj is IOpenable)
						{
							((IOpenable)smartObj).Open();
							Console.WriteLine("Прибор : " + (((IOnOff)smartObj).IsOn ? "Включен" : "Выключен"));
							Console.WriteLine("Состояние прибора : " + (((IOpenable)smartObj).IsOpen ? "Открыт":"закрыт") );
							if (smartObj is IHasLight)
								Console.WriteLine("Свет : " + (((IHasLight)smartObj).IsLightOn ? "Включен" : "Выключен"));
						}
						
						break;
					case "c":
						if (smartObj is IOpenable)
						{
							((IOpenable)smartObj).Close();
							Console.WriteLine("Прибор : " + (((IOnOff)smartObj).IsOn ? "Включен" : "Выключен"));
							Console.WriteLine("Состояние прибора : " + (((IOpenable)smartObj).IsOpen ? "Открыт":"закрыт") );
							if (smartObj is IHasLight)
								Console.WriteLine("Свет : " + (((IHasLight)smartObj).IsLightOn ? "Включен" : "Выключен"));
						}	
						
						break;
					case "gm":
						 if (smartObj is IHasMode)
                        {
							Console.WriteLine("Режим : " + ((IHasMode)smartObj).ModeOfFridge);
                        }
						break;
					case "sm":
						if (smartObj is IHasMode)
						{
							Console.WriteLine("1 - минимальный");
							Console.WriteLine("2 - средний");
							Console.WriteLine("3 - максимальный");
							Console.Write("Выберите pежим : ");
							((IHasMode)smartObj).ModeOfFridge =(Modes) Convert.ToInt32(Console.ReadLine());
							Console.Clear();
							Console.WriteLine("Teмпература : " + ((IHasMode)smartObj).ModeOfFridge);
						}
						break;
					case "gtm" :
						if(smartObj is IHasTimer)
							{
								Console.WriteLine("Установленое время : " + ((IHasTimer)smartObj).Time);
							}
						break;
					case "stm":
						if (smartObj is IHasTimer)
						{
							Console.WriteLine("Установите время : ");
							((IHasTimer)smartObj).Time = TimeSpan.FromMinutes(Convert.ToDouble(Console.ReadLine()));
						}
						break;

					case "b":
						return;
					default:
						Console.WriteLine("Неизвестная команда");
						break;
				}
			}
		}
	}
}
