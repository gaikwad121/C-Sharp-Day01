using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Pattern
{
	internal class Class24
	{
		//(𝗘𝘅𝗮𝗺𝗽𝗹𝗲: HexAwarE → hEXaWARe).
		string str;
		public Class24(string s)
		{
			this.str = s;
			changeCase();
			changeCase2();
		}
		public void changeCase()
		{
			char[] ch = str.ToCharArray();
			string newstr = "";
			foreach(char c in ch)
			{
				if (char.IsUpper(c))
				{
					newstr += char.ToLower(c);
				}
				else
				{
					newstr += char.ToUpper(c);

				}
			}
			Console.WriteLine(newstr);
		}
		public void changeCase2()
		{
			string s = "";
			char[] ch = str.ToCharArray();
			foreach(char ch1 in ch)
			{
				if(ch1>=65 && ch1 <= 90)
				{
					s = s + ch1.ToString().ToLower();
				}
				else
				{
					s = s + ch1.ToString().ToUpper();
				}
			}
			Console.WriteLine(s);
		}
			}
		
}
