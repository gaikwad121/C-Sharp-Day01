using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Pattern
{
	internal class Class35
	{
		public static void devideZero()
		{
			int a = 67;
			int b = 0;
			try
			{
				int c = a / b;
			}
			catch (DivideByZeroException e)
			{
				Console.WriteLine(e.Message);
			}


		}
	}
}
