using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Pattern
{
	internal class Class28
	{
		// print only number
		public static void numPrint(string s)
		{
			char[] ch = s.ToCharArray();
		foreach(char ch1 in ch)
			{
				if(ch1>='0' && ch1 <= '9')
				{
					Console.Write(ch1);
				}

			}
		}
	}
}
