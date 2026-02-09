using App.IO;

namespace _12._9___Rita_staplar
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ConsoleHelper.ClearScreen("RITA STAPLAR");
			int numberOfNumbers = ConsoleHelper.ReadInt("Antal nummer: ", 1, 15);
			int[] numbers = new int[numberOfNumbers];

			for (int i = 0; i < numberOfNumbers; i++)
			{
				int number = ConsoleHelper.ReadInt($"Ange ett tal mellan 1-100. Tal nr {i + 1}: ", 1, 100);
				numbers[i] = number;
			}

			Console.WriteLine();

			for (int i = 0; i < numbers.Length; i++)
			{
				Console.Write($"{i + 1}: ");
				for (int j = 0; j < numbers[i]; j++)
				{
					Console.BackgroundColor = ConsoleColor.Green;
					Console.Write(" ");
				}
				Console.BackgroundColor = ConsoleColor.Black;
				Console.WriteLine($"({numbers[i]})\n");
			}
		}
	}
}
