using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Pattern
{
	internal class Class7
	{
		public static void CapstoSmall()
		{
			string str = "hELLOwORLD";
			char[] ch = str.ToCharArray();
			for(int i = 0; i < ch.Length; i++)
			{
				if (ch[i]>=65 && ch[i] <= 90)
				{
					ch[i] = char.ToLower(ch[i]);
				}
				else
				{
					ch[i] = char.ToUpper(ch[i]);
				}
				Console.Write(ch[i]);
			}
		}
	}
}
