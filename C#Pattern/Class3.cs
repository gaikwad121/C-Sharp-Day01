using System;
using System.Collections.Generic;

namespace C_Pattern
{

	public class Class3 : classDemo
	{
		public override void Duplicate()
		{
			int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 2, 3, 5 };

			List<int> duplicates = new List<int>();
			List<int> unique = new List<int>();
			HashSet<int> seen = new HashSet<int>();

			foreach (int a in arr)
			{
				if (!seen.Add(a)) // if already exists → duplicate
				{
					duplicates.Add(a);
				}
				else
				{
					unique.Add(a);
				}
			}

			Console.WriteLine("Unique values: " + string.Join(", ", unique));
			Console.WriteLine("Duplicate values: " + string.Join(", ", duplicates));
		}
	}
}
	/*class Program
	{
		static void Main(string[] args)
		{
			Class3 obj = new Class3();
			obj.Duplicate();
		}
	}
}

	*/
