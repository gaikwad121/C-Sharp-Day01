using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C_Pattern
{
	public class ArrayCode
	{
		public static void program()
		{
			int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			int sum = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				sum += arr[i];
			}
			Console.WriteLine(sum);
		}
		//Write a program to store and display 5 numbers in an array.

		public static void displayArray()
		{
			int[] arr = new int[5];   // fixed-size array
			Console.WriteLine("Enter 5 array elements:");

			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write($"Element {i + 1}: ");
				arr[i] = int.Parse(Console.ReadLine());  // convert input to int
			}

			Console.WriteLine("\nArray elements are:");
			foreach (int a in arr)
			{
				Console.WriteLine(a);
			}
		}
		// Input 10 integers in an array and print them in reverse order.
		public static void reverseOrder()
		{
			int[] arr = { 1, 2, 4, 5, 6, 7, 8, 9, 10 };
			for (int i = arr.Length - 1; i >= 0; i--)
			{
				Console.WriteLine(arr[i]);
			}
		}
		public static void reverseArray2(int[] arr)
		{
			int i = 0;
			int j = arr.Length - 1;


			while (i < j)
			{
				int temp = arr[i];
				arr[i] = arr[j];
				arr[j] = temp;
				i++;
				j--;
			}
			foreach (int a in arr)
			{
				Console.WriteLine(a);
			}
		}
		//Find the sum and average of all elements in an array.
		public static void average(int[] arr)
		{
			double avg = 0;
			double sum = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				sum += arr[i];
			}
			avg = sum / arr.Length;
			Console.WriteLine(avg);



		}


		//Find the maximum and minimum number in an array.
		public static void maxValue(int[] arr)
		{
			int maxValue = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] > maxValue)
				{
					maxValue = arr[i];
				}
			}
			Console.WriteLine(maxValue);
		}

		public static void minValue(int[] arr)
		{
			int minValue = arr[0];
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] < minValue)
				{
					minValue = arr[i];
				}
			}
			Console.WriteLine(minValue);
		}
		public static void ArrayAsInputValue()
		{
			double sum = 0;
			int[] arr = new int[6];

			// Input
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write($"Enter array Element {i + 1}: ");
				arr[i] = int.Parse(Console.ReadLine());
				sum += arr[i];
			}

			// Print array elements
			Console.WriteLine("\nYou entered:");
			for (int i = 0; i < arr.Length; i++)
			{
				Console.WriteLine($"Element {i + 1} = {arr[i]}");
			}

			// Average
			double avg = sum / arr.Length;
			Console.WriteLine($"\nAverage is: {avg:F2}"); // 2 decimal places
		}

		// Count how many numbers are even and odd in an array.
		public static void evenOddCount(int[] arr)
		{
			int countEven = 0;
			int countOdd = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] % 2 == 0)
				{
					countEven++;
				}
				else
				{
					countOdd++;
				}
			}
			Console.WriteLine($"Evene count : {countEven}, Odd count : {countOdd}");
		}

		//Sort an array in ascending and descending order without using built-in functions.
		public static void ArrayAscOrDSC(int[] arr)
		{
			Console.WriteLine("Enter your choice (ASC or DSC):");
			string choice = Console.ReadLine().ToUpper(); // Make input case-insensitive

			if (choice != "ASC" && choice != "DSC")
			{
				Console.WriteLine("Invalid choice! Please enter ASC or DSC.");
				return; // Exit the method
			}

			// Sorting using simple nested loops
			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = i + 1; j < arr.Length; j++)
				{
					if ((choice == "ASC" && arr[i] > arr[j]) || (choice == "DSC" && arr[i] < arr[j]))
					{
						int temp = arr[i];
						arr[i] = arr[j];
						arr[j] = temp;
					}
				}
			}

			Console.WriteLine($"Array sorted in {choice} order:");
			foreach (int a in arr)
			{
				Console.WriteLine(a);
			}
		}
		// Search for an element in an array using linear search.
		public static void SearchEle(int[] arr)
		{
			int num = 5; // Number to search
			int count = 0;

			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == num)
				{
					count++;
				}
			}

			if (count > 0)
			{
				Console.WriteLine($"The number {num} is found {count} time(s) in the array.");
			}
			else
			{
				Console.WriteLine($"The number {num} is not found in the array.");
			}
		}
	}
}
