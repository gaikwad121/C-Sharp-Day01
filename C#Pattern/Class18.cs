using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Pattern
{
	internal class Class18
	{
		public static int maxNum(int [] arr)
		{
			int max = int.MinValue;
			for(int i = 0; i < arr.Length; i++)
			{
				if (arr[i] > max)
				{
					max = arr[i];
				}
			}
			int secondMAx = int.MinValue;
			for (int i = 0; i < arr.Length; i++) {
				if (arr[i]!=max && arr[i] > secondMAx)
				{
					secondMAx = arr[i];
				}
			}
				return secondMAx;
		}
		public static int minNum(int[] arr)
		{
			int max = int.MaxValue;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] < max)
				{
					max = arr[i];
				}
			}
			int secondMAx = int.MaxValue;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] != max && arr[i] < secondMAx)
				{
					secondMAx = arr[i];
				}
			}
			return secondMAx;
		}
		public static int thirdMinNum(int[] arr)
		{
			int max = int.MaxValue;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] < max)
				{
					max = arr[i];
				}
			}
			int secondMAx = int.MaxValue;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] != max && arr[i] < secondMAx)
				{
					secondMAx = arr[i];
				}
			}
			int thirdMAx = int.MaxValue;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] != max && arr[i]!=secondMAx && arr[i]< thirdMAx)
				{
					thirdMAx = arr[i];
				}
			}
			return thirdMAx;
		}
	}
}

	

