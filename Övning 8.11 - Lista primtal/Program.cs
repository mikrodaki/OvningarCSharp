namespace Övning_8._11___Lista_primtal
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				int userNumber = 0;
				Console.WriteLine("Välkommen till primtalslistningen!\n-----------------------------\n");
				Console.Write("Ange ett primtal: ");
				string input = Console.ReadLine();
				bool success = int.TryParse(input, out userNumber);

				while (!success)
				{
					Console.Clear();
					Console.WriteLine("Välkommen till primtalslistningen!\n-----------------------------\n");
					Console.Write("Felaktig inmatning, ange ett primtal: ");
					input = Console.ReadLine();
					success = int.TryParse(input, out userNumber);
				}

				if (userNumber == 2)
				{
					Console.Write($"\nTalet {userNumber} är ett primtal");
				}
				else if (userNumber <= 1)
				{
					Console.Write($"\nTalet {userNumber} är inte ett primtal");
				}
				else if (userNumber % 2 == 0)
				{
					Console.Write($"\nTalet {userNumber} är jämnt och således inte ett primtal");
				}
				else if (isPrimeMethod(userNumber))
				{
					Console.WriteLine($"\nHär följer en lista av primtal upp till primtalet {userNumber}\n");
					Console.Write("2 ");
					int printThePrime = 3;
					int rowCounter = 1;
					while (printThePrime < userNumber)
					{
						if (isPrimeMethod(printThePrime))
						{
							Console.Write($"{printThePrime} ");
							if (rowCounter % 15 == 0)
							{
								Console.WriteLine("\n");
							}
							rowCounter++;
						}
						printThePrime += 2;
					}
					Console.Write(userNumber);
				}
				else
					Console.Write($"\nTalet {userNumber} är inte ett primtal");
				Console.ReadKey();
				Console.Clear();
			}

			static bool isPrimeMethod(int number)
			{
				bool isNumberPrime = true;

				if (number == 2)
				{
					isNumberPrime = true;
				}
				else if (number <= 1)
				{
					isNumberPrime = false;
				}
				else if (number % 2 == 0)
				{
					isNumberPrime = false;
				}
				else
				{
					double squareRoot = Math.Sqrt(number);

					for (int i = 2; i <= squareRoot; i++)
					{
						if (number % i == 0)
						{
							isNumberPrime = false;
							break;
						}
					}
				}
				return isNumberPrime;
			}
		}
	}
}

