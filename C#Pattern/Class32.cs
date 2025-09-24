using System;

class StringTools
{
	// Reverse a string
	public static string Reverse(string input)
	{
		char[] chars = input.ToCharArray();
		Array.Reverse(chars);
		return new string(chars);
	}

	// Count vowels in a string
	public static int CountVowels(string input)
	{
		int count = 0;
		string vowels = "aeiouAEIOU";
		foreach (char c in input)
		{
			if (vowels.Contains(c)) count++;
		}
		return count;
	}

	// Trim and normalize whitespace
	public static string CleanWhitespace(string input)
	{
		return string.Join(" ", input.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries));
	}
}
