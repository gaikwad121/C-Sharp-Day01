using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Pattern
{
	internal class ArrayListProgram
	{
		public void SortingArr()
		{
			int[] arr = { 3, 2, 5, 6, 7, 1, 2, 9 };

			Array.Sort(arr);
			foreach (int i in arr)
			
			Console.WriteLine(i);
			List<int> list = new List<int>(arr);
			list.Sort();
			foreach (int i in list)
			{
				Console.WriteLine(i);

			}

		}
	}
}
