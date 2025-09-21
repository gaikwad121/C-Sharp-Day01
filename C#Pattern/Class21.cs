using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Pattern
{
	// print number of word
	internal class Class21
	{
		string sen;
	public  Class21(string s)
		{
			this.sen = s;
			Console.WriteLine(countNumOfWord());
		}
		public int countNumOfWord()
		{
			int count = 0;
			string[] words = sen.Split(" ");
			count = words.Length;
			return count;
		}
		 
	}
}
