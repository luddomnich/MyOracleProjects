using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortProgram
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array = { 1, 3, 6, 7, 9, 50, 9 };
			int start = array[0];
			int end = array.Length - 1;

			Console.WriteLine("Befofe sort: ");
			print(array);
			QuickSort.quicksort (array , start, end);
			Console.WriteLine("After sorting: ");
			print(array);
			Console.ReadLine();
			
		
		}

		public static void print(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write(array[i] + " ");
			}
			Console.WriteLine();
		}
	}
}
