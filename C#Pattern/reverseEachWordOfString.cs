using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Pattern
{
	internal class reverseEachWordOfString
	{
		public static void revWord()
		{
			String str = "Hellow world i am jyoti gaikwad";
			string[] words = str.Split(' ');
			string rev = "";
			//string revWord = "";
			foreach (string word in words)
			{
				string revWord = "";

				for (int i = word.Length - 1; i >= 0; i--)
				{
					revWord = revWord + word[i];
				}
				rev = rev + revWord + " ";
			}
				Console.WriteLine(rev);
			}
		}
	}

