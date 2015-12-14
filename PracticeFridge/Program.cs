using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFrige
{
	class Program
	{
		 
		static void Main(string[] args)
		{
			Freezer freezer = new Freezer(Modes.middle);
			Fridge fridge = new Fridge(Modes.middle);


			while(true)
			{
				Console.Clear();
				Console.WriteLine(fridge.Info() + "\n");
				Console.WriteLine("Нажмите клавишу для выполнения действия:");
				Console.WriteLine("1 - Включить холодильник");
				Console.WriteLine("2 - Выключить холодильник");
				Console.WriteLine("3 - Установить минимальный режим");
				Console.WriteLine("4 - Установить средний режим");
				Console.WriteLine("5 - Установить максимальный режим");
				Console.WriteLine("6 - Oткрыть холодильник");
				Console.WriteLine("7 - Закрыть холодильник");
				Console.WriteLine("+ - Увеличить температуру");
				Console.WriteLine("- - Снизить температуру");
				Console.WriteLine("e - Выйти");

				 char key = Console.ReadKey().KeyChar;
				 switch (key)
				 {
					 case '1':
						 fridge.On();
						 break;
					 case '2':
						 fridge.Off();
						 break;
					 case '3':
						 fridge.ModeOfFridge = Modes.minimum;
						 ;
						 break;
					 case '4':
						 fridge.ModeOfFridge = Modes.middle;
						 break;
					 case '5':
						 fridge.ModeOfFridge = Modes.maximum;
						 break; 
					
					 case '6':
						 fridge.Open();
						 break;
					 case '7':
						 fridge.Close();
						 break;
					 case '+':
					 case '=':
						 fridge.Temperature++;
						// fridge.ModeOfFridge = Modes.manual;
						 break;
					 case '-':
						 fridge.Temperature--;
						// fridge.ModeOfFridge = Modes.manual;
						 break;
					 case 'e':
						 return;
				 }
				//freezer.ModeOfFridge = Modes.middle;
				//Console.WriteLine("temp {0}/{1}", freezer.Temperature, fridge.Temperature);
				//Console.ReadKey();


			}
		}
	}
}
