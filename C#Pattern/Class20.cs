using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Pattern
{
	internal class Class20
	{
		string name;

		public Class20(string name)
		{
			this.name = name;
			Console.WriteLine(numberOfChar());
		}
		public int numberOfChar()
		{
			int count = 0;
			char[] ch = name.ToCharArray();
			count = ch.Length;
			return count;
		}
	}
}
