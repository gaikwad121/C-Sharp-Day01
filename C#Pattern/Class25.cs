using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Pattern
{
	internal class Class25
	{
		string s;
		public Class25(string str)
		{
			this.s = str;
			ASc();
		}
		public void ASc()
		{
			char[] ch = s.ToCharArray();
			for (int i = 0; i < ch.Length; i++)
			{
				for (int j = 0; j < ch.Length; j++)
				{
					if (ch[i] < ch[j])
					{
						char ch2 = ch[i];
						ch[i] = ch[j];
						ch[j] = ch2;
					}
				}
			}
				Console.WriteLine(new string(ch));
			}
		}
	}

