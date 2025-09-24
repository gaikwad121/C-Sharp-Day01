using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Pattern
{
	internal class Class30
	{
		public static void revWord()
		{
			string revWord = "";
			string str = "hello how are you";
			string[] word = str.Split(' ');
			for (int i = word.Length - 1; i >= 0; i--)
			{
				revWord = revWord + word[i] + " ";
			}
			Console.WriteLine(revWord);
		}
	}
}
