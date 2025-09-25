using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Pattern
{
	internal class Class37
	{
		public static void method2()
		{
			int num = 5;
			for(int i = 1; i <= num; i++)
			{
				for(int j = 1; j <= i; j++)
				{
					Console.Write(j);
				}
				Console.WriteLine();
			}
		}
	}
}
