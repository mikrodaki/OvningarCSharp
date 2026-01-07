namespace Övning_11._10
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int firstNumber = GetNotZeroUserInteger(false);
			int secondNumber = GetNotZeroUserInteger(true);
			int thirdNumber = CheckIntegerInput("Ange tal 3: ");
			Console.WriteLine($"Största talet är: {Biggest(firstNumber, secondNumber, thirdNumber)}");
		}

		static int Biggest(int a, int b, int c)
		{
			int biggest = a;
			if (b > biggest)
				biggest = b;
			if (c > biggest)
				biggest = c;
			return biggest;
		}

		static int CheckIntegerInput(string message)
		{
			int result = 0;
			Console.Write(message);
			while (!int.TryParse(Console.ReadLine(), out result))
			{
				Console.WriteLine("Felaktigt inmatning. Försök igen.");
				Console.Write(message);
			}
			return result;
		}

		static int GetUserInteger()
		{
			int result = 0;
			while (true)
			{
				try
				{
					Console.Write("Ange ett heltal: ");
					string input = Console.ReadLine();
					result = int.Parse(input);
					break;
				}
				catch (Exception)
				{
					Console.WriteLine("Ogiltigt värde. Ange ett heltal. Försök igen.");
				}
			}
			return result;
		}

		static int GetNotZeroUserInteger(bool acceptZero)
		{
			int result = 0;
			while (true)
			{
				try
				{
					Console.Write("Ange ett heltal: ");
					string input = Console.ReadLine();
					result = int.Parse(input);
					if (!acceptZero && result == 0)
						Console.WriteLine("Värdet får inte vara noll. Försök igen.");
					else
						break;
				}
				catch (Exception)
				{
					Console.WriteLine("Ogiltigt värde. Ange ett heltal. Försök igen.");
				}
			}
			return result;
		}
	}
}
