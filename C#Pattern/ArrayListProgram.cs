using System;
using System.Collections.Generic;

namespace C_Pattern
{
	internal class ArrayListProgram
	{
		public void SortingArr()
		{
			int[] arr = { 3, 2, 5, 6, 7, 1, 2, 9 };
			string[] student = { "apple", "cucumber", "mango", "chiku", "banana" };

			// ---- Sorting string list ----
			List<string> studentName = new List<string>(student);
			studentName.Sort(); // ascending (A–Z)

			Console.WriteLine("Sorted student names:");
			foreach (string s in studentName)
			{
				Console.WriteLine(s);
			}

			// ---- Sorting integer array ----
			Array.Sort(arr);
			Console.WriteLine("\nSorted array:");
			foreach (int i in arr)
			{
				Console.WriteLine(i);
			}

			// ---- Sorting integer list ----
			List<int> list = new List<int>(arr);
			list.Sort();
			Console.WriteLine("\nSorted list:");
			foreach (int i in list)
			{
				Console.WriteLine(i);
			}
		}
	}

}
