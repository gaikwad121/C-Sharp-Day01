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
			}
		
}
