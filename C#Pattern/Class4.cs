using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Pattern
{
    internal class Class4
    {
        // count char  n spcial char and number in string
		public static void countSpecialCharDigit() { 
        string str = "jg.jyotigaikwad121@gmail.com";
			int LetterCount = 0;
			int DigitCount = 0;
			int SpecialCharCount = 0;
			string sp = "";
			string digit = "";
			string letter = "";
		char[] chars = str.ToCharArray();
		for(int i = 0; i < chars.Length; i++)
			{
				if (Char.IsLetter(chars[i]))
				{
					LetterCount++;
					letter = letter + chars[i];
				}
				else if (char.IsDigit(chars[i]))
				{
					DigitCount++;

					digit = digit + chars[i];
				}
				else
				{
					SpecialCharCount++;
					sp = sp + chars[i];
				}
			}
			Console.WriteLine("letter count :" + LetterCount + " " + letter);
			Console.WriteLine("Digit Count :" + DigitCount + " " + digit);
			Console.WriteLine("SpecialChar Count :" + SpecialCharCount + " " + sp);

		}
	}
}
