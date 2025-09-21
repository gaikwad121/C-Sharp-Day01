using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Pattern
{
	internal class Class14
	{
		int num;
		public Class14(int n)
		{
			this.num = n;
			Console.WriteLine("the num is prime  : " + " " + isPrime());
		}
		public bool isPrime()
		{
			for (int i = 2; i <= num / 2; i++)
			{
				if (i % 2 == 0)
				{
					return false;
				}
				else
				{
					return true;
				}
			}
			return true;
		}
	}
}
