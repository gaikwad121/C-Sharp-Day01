using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Pattern
{
	internal class Class26
	{
		string s;
	internal  Class26(string str)
		{
			this.s = str;
			revEachWord();
		}
		public void revEachWord()
		{
			string rev = "";
			string[] s2 = s.Split(' ');
			foreach (string s3 in s2)
			{
				string revw = "";
				for (int i = s3.Length - 1; i >= 0; i--)
				{
					revw = revw + s3[i];
				}

				rev = rev + revw + " ";

			}
			Console.WriteLine(rev);
		}
	}
}
