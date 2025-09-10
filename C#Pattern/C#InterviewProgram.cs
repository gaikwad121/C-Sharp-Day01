using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace C_Pattern
{
	internal class C_InterviewProgram
	{
		public static void primeOrNot(int num)
		{
			bool result = false; // prime number
			for (int i = 2; i < num / 2; i++)
			{
				if (num % i == 0)
				{
					result = true; // not prime number
				}
			}
			if (result)
			{
				Console.WriteLine("Not prime num");
			}
			else
			{
				Console.WriteLine(" prime num");

			}
		}
		internal static void revString(string str)
		{
			char[] ch = str.ToCharArray();
			string rev = "";
			for (int i = ch.Length - 1; i >= 0; i--)
			{
				rev = rev + ch[i];
			}

			Console.WriteLine(rev);
		}


		internal static void revNum(int num)
		{
			int rev = 0;
			while (num > 0)
			{
				rev = rev * 10 + num % 10;
				num /= 10;
			}
			Console.WriteLine(rev);
		}

		internal static void StringLength(string str)
		{
			str = str.Trim();
			char[] ch = str.ToCharArray();
			if (ch.Length != 0)
				Console.WriteLine(ch.Length);
			//string [] str1= str.Split(" ");

			//int length = str1.Length;
			//Console.WriteLine(length);
		}

		internal static BigInteger Factorial(int n)
		{
			if (n < 0)
			{
				throw new ArgumentException("Factorial is not defined for negative numbers.");
			}

			BigInteger fact = 1;
			for (int i = 1; i <= n; i++)
			{
				fact *= i;
			}
			return fact;
		}
		internal static void Fibonnaci(int n)
		{
			int a = 0, b = 1;
			Console.Write(a + " " + b);

			for (int i = 0; i < n; i++)
			{
				int temp = a + b;
				Console.Write(" " + temp);
				a = b;
				b = temp;
			}
			Console.WriteLine();
		}

		internal static void swapNum()
		{
			int a = 78;
			int b = 34;
			a = a * b;
			b = a / b;
			a = a / b;
			Console.WriteLine(a + " " + b);
		}
		internal static void sumOfNum()
		{
			int num = 987654321;
			int sum = 0;
			while (num > 0)
			{
				int n = num % 10;
				sum += n;
				num /= 10;
			}
			Console.WriteLine(sum);
		}

		internal static void evenOdd(int num)
		{
			if (num % 2 == 0)
			{
				Console.WriteLine("Even");
			}
			else
			{
				Console.WriteLine("odd");
			}
	
		}
		internal static void palindrome(string str)
		{
			string rev = "";
			string temp = str;
			for(int i = str.Length - 1; i >= 0; i--)
			{
				rev = rev + str[i];
			}
			if (rev.Equals(temp))
			{
				Console.WriteLine("palindrome");
			}
			else
			{
				Console.WriteLine("not palindrome");
			}
		}
	}
}
