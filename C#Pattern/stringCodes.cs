using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Pattern
{
	internal class stringCodes
	{
		public static void revString()
		{
			string str = "hello world";
			string rev = "";
			char[] ch = str.ToCharArray();

			for (int i = ch.Length - 1; i >= 0; i--)
			{
				rev = rev + ch[i];
			}


			Console.WriteLine(rev);
		}
		public static void countChar()
		{
			String str = "Hello";
			char[] ch = str.ToCharArray();
			Console.WriteLine(ch.Length);
		}

		public  static void removeDuplicateChar(string str)
		{
			char[] ch = str.ToCharArray();
			HashSet<Char> hs = new HashSet<char>();
			HashSet<Char> hs1 = new HashSet<char>();
			foreach (char c in ch)
			{

				hs.Add(c);
			}
			foreach(char ch1 in hs){
				Console.WriteLine(ch1);

			}
		}
public static void WordCount()
		{
			string str = "Hello world good morning";
			string[] words = str.Split(' ');
			Console.WriteLine("word count is : " + words.Length);
		}
	}
}
