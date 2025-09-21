using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Pattern
{
	internal class Class13
	{
		int num;
public  Class13(int n)
		{
			this.num = n;
			Console.WriteLine("factorial of " + num + " is : " + fact());
		}
		public int fact()
		{
			int factorial = 1;
			for(int i=1;i<=num;i++)
			{
				factorial = factorial * i;
			}
			return factorial;
		}
	}
}
