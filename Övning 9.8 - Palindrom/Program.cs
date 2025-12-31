namespace Övning_9._8___Palindrom
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				bool isPalindrome = true;
				Console.Clear();
				Console.WriteLine("PALINDROMTEST\n----------------");
				Console.Write("Ange ett ord: ");
				string text = Console.ReadLine();
				string textWithoutSpaces = "";

				// Remove all special characters
				for (int i = 0; i < text.Length; i++)
				{
					char c = char.ToLower(text[i]);

					if ((c >= 'a' && c <= 'z') || c == 'å' || c == 'ä' || c == 'ö')
					{
						textWithoutSpaces += c;
					}
				}

				for (int i = 0; i < textWithoutSpaces.Length / 2; i++)
				{
					if (textWithoutSpaces[i] != textWithoutSpaces[textWithoutSpaces.Length - 1 - i])
					{
						isPalindrome = false;
						break;
					}
				}

				Console.WriteLine(
						isPalindrome
							? $"{text} är ett palindrom"
							: $"{text} är inte ett palindrom"
					);
				Console.ReadKey();
			}
		}
	}
}
