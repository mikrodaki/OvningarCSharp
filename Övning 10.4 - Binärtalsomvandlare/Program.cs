namespace Övning_10._4___Binärtalsomvandlare
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("BINÄRTALSOMVANDLARE \n----------------------------");
			bool invalidInput;
			string input = string.Empty;
			string binaryNumberString = string.Empty;

			// Loop until the user has submitted a string that only consists of zeros and ones. 
			do
			{
				invalidInput = false;
				Console.Write("Ange ett binärtal: ");
				try
				{
					input = Console.ReadLine();
					if (input == "")
						throw new Exception();
					for (int i = 0; i < input.Length; i++)
					{
						if (input[i] != '0' && input[i] != '1')
						{
							throw new Exception();
						}
					}
				}
				catch (Exception)
				{
					invalidInput = true;
					Console.WriteLine("Felaktig inmatning. Försök igen.");
				}
			} while (invalidInput);

			binaryNumberString = input;
			int decimalRepresentation = 0;
			int postition = 0;

			// Loop from the right and do calculations
			for (int i = binaryNumberString.Length - 1; i >= 0; i--)
			{
				int binaryDigit = Convert.ToInt32(binaryNumberString.Substring(i, 1));
				decimalRepresentation += (int)Math.Pow(2, postition) * binaryDigit;
				postition++;	
			}
			Console.WriteLine($"Talet du angivit skrivs som {decimalRepresentation} decimalt");
		}
	}
}
