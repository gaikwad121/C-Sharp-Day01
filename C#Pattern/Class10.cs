using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Pattern
{
	internal class Class10
	{
		int num;

	public 	Class10(int n)
		{
			this.num = n;
			Console.WriteLine(countDigit());
			Console.WriteLine("sum of digit :  " + sumDigit());
		}
		
		int sumDigit()
		{
			int sum = 0;
			int num = 987654321;
			while (num > 0)
			{
				int n = num % 10;
				sum += n;
				num /= 10;
			}
		
			return sum;
		}
		int countDigit()
		{
			int count = 0;
			while (num > 0)
			{
				count++;
				num /= 10;
			}
			return count;
		}
	}
}
