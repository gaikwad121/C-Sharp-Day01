using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Pattern
{
	internal class Class11
	{
		int num;
		public Class11(int n)
		{
			this.num = n;
	armStrongNum();
		}
		public void armStrongNum()
		{
			int temp = num;
			int arm = 0;
			while (num > 0)
			{
				int n = num % 10;
				arm = arm + (n * n * n);
				num /= 10;
			}
			if (arm == temp)
			{
				Console.WriteLine("Armstrong num");
			}
			else
			{
				Console.WriteLine("not Armstrong num");

			}
		}
	}
}
