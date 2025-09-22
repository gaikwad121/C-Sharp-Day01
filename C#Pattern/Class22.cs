using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Pattern
{
	internal class Class22
	{
		int num = 10;
		internal Class22(int n)
		{
			this.num = n;
			test();
		}
		public void test()
		{
			int a = 0; int b = 1;
			Console.Write(a + " " + b+" ");
			for (int i = 2; i <= num; i++)
			{
				int c = a + b;
				Console.Write(c+ " ");

				a = b;
				b = c;

			}
			Console.WriteLine();
		}
	}
	}
