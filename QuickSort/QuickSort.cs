using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortProgram
{
	class QuickSort
	{
		 static int partition(int[] array, int start, int end)
		{
			int marker = start;
			for (int i = start; i <= end; i++)
			{
				if (array[i] <= array[end])
				{
					int temp = array[marker]; 
					array[marker] = array[i];
					array[i] = temp;
					marker += 1;
				}
			}
			return marker - 1;
		}

		public static void quicksort(int[] array, int start, int end)
		{
			if (start < end)
			{
				int rod = partition(array, start, end);
				quicksort(array, start, rod - 1);
				quicksort(array, rod + 1, end);
			}
		}
		
	}
}
