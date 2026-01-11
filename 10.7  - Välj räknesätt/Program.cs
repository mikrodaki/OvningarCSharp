namespace _10._7____Välj_räknesätt
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double firstNumber = 0;
			double secondNumber = 0;
			double result = 0;
			bool invalidInput = true;
			string calculationMethod = string.Empty;
			char calculationMethodChar = ' ';

			do
			{
				try
				{
					Console.Write("Ange ett tal: ");
					firstNumber = Convert.ToDouble(Console.ReadLine());
					invalidInput = false;
				}
				catch (Exception)
				{
					Console.WriteLine("Talet måste vara ett heltal eller ett decimaltal. Försök igen.");
				}
			}
			while (invalidInput);

			invalidInput = true;

			do
			{
				try
				{
					Console.Write("Ange ett till tal: ");
					secondNumber = Convert.ToDouble(Console.ReadLine());
					invalidInput = false;
				}
				catch (Exception)
				{
					Console.WriteLine("Talet måste vara ett heltal eller ett decimaltal. Försök igen.");
				}
			}
			while (invalidInput);

			invalidInput = true;

			do
			{
				Console.Write("\nAnge ett räknesätt (M)ultiplication, (D)ivision, (A)ddition, (S)ubtraktion: ");
				calculationMethod = Console.ReadLine().ToLower();
				if (calculationMethod == "m" ||
					calculationMethod == "d" ||
					calculationMethod == "a" ||
					calculationMethod == "s")
				{
					if (calculationMethod == "d" && secondNumber == 0)
						Console.WriteLine("Ogiltigt val!. Division med 0 är inte tillåtet. Ange ett annat räknesätt.");
					else
						invalidInput = false;
				}
				else
				{
					Console.WriteLine("Ogiltigt val! Försök igen.");
				}
			}
			while (invalidInput);

			switch (calculationMethod)
			{
				case "m":
					calculationMethodChar = '*';
					result = firstNumber * secondNumber;
					break;
				case "d":
					calculationMethodChar = '/';
					result = firstNumber / secondNumber;
					break;
				case "a":
					calculationMethodChar = '+';
					result = firstNumber + secondNumber;
					break;
				case "s":
					calculationMethodChar = '-';
					result = firstNumber - secondNumber;
					break;
				default:
					break;
			}
			Console.WriteLine($"\nResultatet av {firstNumber} {calculationMethodChar} {secondNumber} = {result} ");
			Console.ReadKey();
		}
	}
}
