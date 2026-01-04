namespace Övning_11._10
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int firstNumber = CheckIntegerInput("Ange tal 1: ");
			int secondNumber = CheckIntegerInput("Ange tal 2: ");
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
	}
}
