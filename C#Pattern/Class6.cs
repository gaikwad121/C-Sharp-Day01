namespace C_Pattern
{
	internal class Class6
	{
		public static void CapAndSmall()
		{
			string str = "hELLOwORLD";
			char[] ch = str.ToCharArray();

			for (int i = 0; i < ch.Length; i++)
			{
				if (char.IsUpper(ch[i]))
				{
					ch[i] = char.ToLower(ch[i]);  // Uppercase to lowercase
				}
				else if (char.IsLower(ch[i]))
				{
					ch[i] = char.ToUpper(ch[i]);  // Lowercase to uppercase
				}
			}

			Console.WriteLine(new string(ch));  // Print the modified string
		}

	}
}
