using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Pattern
{
	internal class Class5
	{
		public static void countCharSpDigit()
		{
			int charCount = 0;
			int digitCount = 0;
			int capsCount = 0;
			int spCount = 0;
			String chars = "";
			String digit = "";
			String sp = "";
			string str = "jg.jyotigaikwad121@gmail.com";
			char[] ch = str.ToCharArray();
			foreach (char ch1 in ch)
			{
				if (ch1 >= 97 && ch1 <= 122)
				{
					charCount++;
					chars = chars + ch1;
				}
				//else if (ch1>=65 && ch1<=90)
				//{
				else if (ch1 >= 48 && ch1 <= 57)
				{
					digitCount++;
					digit = digit + ch1;

				}
				else
				{
					spCount++;
					sp = sp + ch1;
				}
			}
				Console.WriteLine("Char count : " + charCount + " " + chars);
				Console.WriteLine("digit count : " + digitCount + " " + digit);
				Console.WriteLine("Sp count : " + spCount + " " + sp);


			}
		}
		
	}
