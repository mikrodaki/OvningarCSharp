namespace Övning_11._13
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int nr = AddNumbers(3, 4);
			Console.WriteLine(nr);
			Console.WriteLine(IsMean(5, 7, 5, 3));
			Console.WriteLine(IsMean(4, 5, 5, 5));
			Console.WriteLine(IsRightAngeledTriangle(1.5, 2.0, 2.6));
			Console.WriteLine($"Är 'hej' numeriskt? Svar: {IsNumeric("hej")}");
			Console.WriteLine($"Är '132' numeriskt? Svar: {IsNumeric("132")}");
			Console.WriteLine($"Är '0' numeriskt? Svar: {IsNumeric("0")}");
			Console.WriteLine($"Är ' ' numeriskt? Svar: {IsNumeric("")}");
			Console.WriteLine($"Är 'a1b23' numeriskt? Svar: {IsNumeric("a1b23")}");
			Console.WriteLine($"Är '12 34' numeriskt? Svar: {IsNumeric("12 34")}");
			Console.WriteLine($"Är 'Anna' ett palindrom? Svar: {IsPalindrome("Anna")}");
			Console.WriteLine($"Är 'A n nA!' ett palindrom? Svar: {IsPalindrome("A n nA!")}");
			Console.WriteLine($"Är 'radar' ett palindrom? Svar: {IsPalindrome("radar")}");
			Console.WriteLine($"Är ' ' ett palindrom? Svar: {IsPalindrome("")}");
			Console.WriteLine($"Är 'hello' ett palindrom? Svar: {IsPalindrome("hello")}");
		}

		static int AddNumbers(int a, int b)
		{
			return a + b;
		}

		static bool IsMean(double mean, double a, double b, double c)
		{
			if ((a + b + c) / 3 == mean)
				return true;
			else
				return false;
		}

		static bool IsRightAngeledTriangle(double a, double b, double c)
		{
			if (a * a + b * b == c * c)
				return true;
			else
				return false;
		}

		static bool IsNumeric(string text)
		{
			if (string.IsNullOrEmpty(text))
				return false;

			for (int i = 0; i < text.Length; i++)
			{
				char c = text[i];
				if (c < '0' || c > '9')
					return false;
			}
			return true;
		}

		static bool IsPalindrome(string text)
		{
			string textWithoutSpaces = string.Empty;

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
					return false;
				}
			}
			return true;
		}
	}
}
