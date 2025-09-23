using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Pattern
{
	internal class Class29
	{
		public static void demo()
		{
			int num = 4;
			int count = 1;
			for(int i = 1; i <= num; i++)
			{
			for(int j = 1; j <= i; j++)
				{
					Console.Write(count+" ");
					count++;
				}
				Console.WriteLine();
			}
		}
	}
}
