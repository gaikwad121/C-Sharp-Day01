using System;
using System;

namespace C_Pattern
{
	internal class Class1
	{
		// Step 1: Define a delegate type
		public delegate void printDel();

		// Step 2: Assign a method to the delegate
		private printDel d1 = print;

		public void Run()
		{
			// Step 3: Pass delegate to another class
			demo.Display(d1);
		}

		// Method that matches delegate signature
		private static void print()
		{
			Console.WriteLine("Hello World");
		}

		// Nested class
		class demo
		{
			public static void Display(printDel dell)
			{
				// Invoke delegate
				dell();
			}
		}
	
	}
}
	/*class Program
	{
		static void Main(string[] args)
		{
			Class1 obj = new Class1();
			obj.Run();  // Calls delegate, prints message
		}
	}
}*/
