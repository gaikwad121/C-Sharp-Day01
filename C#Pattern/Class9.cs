using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Pattern
{
	public class Class9
	{
		int num;

		public Class9(int n)
		{
			this.num = n;
			Console.WriteLine(evenNum());
			PrintEvenNum();
		}
		public string  evenNum()
		{
			return (num % 2 == 0) ? "even" : "odd";

		}
		
		public void PrintEvenNum()
		{
			for (int i = 0; i <= num; i++)
			{
				if (i % 2 == 0)
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}
