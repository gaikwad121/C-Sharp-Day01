using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Pattern
{
	internal class Class16
	{
		string name;

		public Class16(string name)
		{
			this.name = name;
			Console.WriteLine(stringRev());
			palindrome();
		}
		public string stringRev()
		{
			string rev = "";
			for (int i = name.Length - 1; i >= 0; i--)
			{
				rev = rev + name[i];
			}
			return rev;
		}

		public void palindrome()
		{
			string temp = name;
			if (stringRev().Equals(temp))
			{
				Console.WriteLine("is palindrome number");
			}
			else
			{
				Console.WriteLine("not palindrome number");
			}
		}
	}
}
