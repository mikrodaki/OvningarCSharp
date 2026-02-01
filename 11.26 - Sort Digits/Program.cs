namespace _11._26___Sort_Digits
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("SORTERA SIFFROR\n-----------------------------");
			var input = ReadDigitString("Ange en sträng av godtyckliga siffror: ");
		}

		/* Write a message to the console and returns 
		 * a string consisting of only digits.
		 */
		private static string ReadDigitString(string message)
		{
			while (true)
			{
				Console.Write(message);
				string input = Console.ReadLine();

				if (input == null || input.Length == 0)
				{
					Console.WriteLine("Felaktig inmatning! Du måste skriva minst en siffra.");
					continue;
				}

				bool onlyDigits = true;

				for (int i = 0; i < input.Length; i++)
				{
					if (input[i] < '0' || input[i] > '9')
					{
						onlyDigits = false;
						break;
					}
				}

				if (onlyDigits)
					return input;

				Console.WriteLine("Felaktig inmatning! Ange endast siffror.");
			}
		}

	}
}
