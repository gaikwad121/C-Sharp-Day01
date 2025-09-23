using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Pattern
{
	internal class Class23
	{
		string str1;

		public Class23(string str2)
		{
			this.str1 = str2;
			revWord();
		}
		public void revWord()
		{
			//string str = "Hellow world i am jyoti gaikwad from solapur maharashtra";
			string[] s = str1.Split(" ");
			string rev = "";
			foreach (string s1 in s)
			{
				string revword = "";
				char[] ch = s1.ToCharArray();
				foreach (char ch1 in ch)
				{
					revword = revword + ch1;
				}
				rev = rev + ch;
			}
			Console.WriteLine(rev);
		}
	}
}
