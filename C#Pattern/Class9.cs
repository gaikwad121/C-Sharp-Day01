using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
			PrintOddNum();
			printEvenNum1to600();
			Console.WriteLine("even count : " + evenCount());
			Console.WriteLine("odd count : " + oddCount());
			Console.WriteLine("even sum : " + evenSum());
			Console.WriteLine("odd sum : " + oddSum());
		}
		public int oddSum()
		{
			int sum = 0;
			for(int i = 0; i <= num; i++)
			{
				if (i % 2 != 0)
				{
					sum += i;
				}
			}
			return sum;
		}
		public int evenSum()
		{
			int sum = 0;
			for(int i = 0; i <= num; i++)
			{
				if (i % 2 == 0)
				{
					sum += i;
				}
			}
			return sum;
		}
		public string evenNum()
		{
			return (num % 2 == 0) ? "even" : "odd";

		}
		public int oddCount()
		{
			int count = 0;
			for (int i = 0; i <= num; i++)
			{
				if (i % 2 != 0)
				
					count++;
				
			}
		
			return count;

		}
	

		public int evenCount()
		{
			int count = 0;
			
		for(int i = 0; i <= num; i++)
			{
				if (i%2==0)
				{
					count++;
				}
			}
			return count;
		}
		public void PrintEvenNum()
		{
			for (int i = 0; i <= num; i++)
			{
				if (i % 2 == 0)
				{
					Console.WriteLine(i);
				}
			} }
		public void PrintOddNum()
		{
			for(int i = 0; i <= num; i++)
			{
				if (i % 2 != 0)
				{
					Console.WriteLine(i);
				}
			}

		}
		public void printEvenNum1to600()
		{
		for(int i = 1; i <= 600; i++)
			{
				if (i % 2 == 0)
				{
					Console.WriteLine(i);
				}
			}
		}
		}
}

