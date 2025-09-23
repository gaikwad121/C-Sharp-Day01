using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Pattern
{
	internal class Class27
	{
		string s;
public Class27(string str)
		{
			this.s = str;
			countSpDigitChar();

		}
		public void countSpDigitChar()
		{
			int charCount = 0;
			string charPrint = "";
			int digitCount = 0;
			string digitPrint = "";
			int spCount = 0;
			string spPrint = "";
			char[] ch = s.ToCharArray();
		foreach(char c in ch)
			{
			if(c>=65 && c <= 90 || c>=97 && c<=122)
				{
					charCount++;
					charPrint = charPrint + c;

				}
			else if(c>=48 && c <= 57)
				{
					digitCount++;
					digitPrint = digitPrint + c;
				}
				else
				{
					spCount++;
					spPrint = spPrint + c;
				}
			}
			Console.WriteLine(charCount + " " + charPrint);
			Console.WriteLine(digitCount + " " + digitPrint);
			Console.WriteLine(spCount + " " + spPrint);

		}
	}
}
