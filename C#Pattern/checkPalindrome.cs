using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace C_Pattern
{
	internal class checkPalindrome
	{
		int num;
		public checkPalindrome(int n)
		{
			this.num = n;
			Console.WriteLine("isPalindrome : " + palindrome());
		}
		public bool palindrome()
		{
			int rev = 0;
			int temp = num;
			while (num > 0)
			{
				rev = rev * 10 + num % 10;
				num /= 10;
			}
			if (rev == temp)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		
	}
	
}
