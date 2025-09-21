using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Pattern
{
	internal class Class15
	{
		int num;
		public Class15(int n)
		{
			this.num = n;
			printPrimeNum();

		}
		public void printPrimeNum()
		{
			
			for(int i = 2; i <= num; i++)
			{
				int count = 0;
				for (int j = 2; j <= i / 2; j++)
				{
					if (i % j == 0)
					{
						count++;
						break;
					}
				}
					if (count == 0)
					{
						//Console.WriteLine(count);
						Console.WriteLine(i);
					}
				}

			}
			
		}
	}

