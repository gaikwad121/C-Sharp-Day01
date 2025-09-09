using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Pattern
{
	internal class LambdaExpressionCode
	{
		public static void LambdaExp()
		{
			Func<int, int, int> add = (a, b) => (a + b);
			Console.WriteLine(add(43, 57));
		}

		public static void sumOfAllIntger()
		{
			int num = 523186;
			int sum = 0;
			while (num > 0)
			{
				int n = num % 10;
				sum += n;
				num /= 10;
			}
			Console.WriteLine(sum);

		}
	}
}

