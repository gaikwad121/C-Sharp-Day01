using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

		public static void removeDuplicateChar(string str)
		{
			char[] ch = str.ToCharArray();
			HashSet<Char> hs = new HashSet<char>();
			HashSet<Char> hs1 = new HashSet<char>();
			foreach (char c in ch)
			{

				hs.Add(c);
			}
			foreach (char ch1 in hs)
			{
				Console.WriteLine(ch1);

			}
		}
		public static void WordCount()
		{
			string str = "Hello world good morning";
			string[] words = str.Split(' ');
			Console.WriteLine("word count is : " + words.Length);
		}

		public static void numCount()
		{
			string str = "Hello123Hell8976";
			char[] ch = str.ToCharArray();
			for (int i = 0; i < ch.Length; i++)
			{
				if (Char.IsDigit(ch[i]))
				{
					Console.Write(ch[i]);
				}
			}
		}
		// Fix for CS1729: 'SimpleDateFormat' does not contain a constructor that takes 1 arguments
		// The code is using Java-style date handling. In C#, use DateTime and DateTime.Parse, and DateTime.AddYears.
		// Also, IDE0090: 'new' expression can be simplified is not applicable here since the code is being rewritten.

		public static void numDate()
		{
			string dt = "2025-10-28";
			DateTime date = DateTime.ParseExact(dt, "yyyy-MM-dd", CultureInfo.InvariantCulture);
			date = date.AddYears(3);
			dt = date.ToString("yyyy-MM-dd");
			Console.WriteLine(dt);
		}
		}
}
