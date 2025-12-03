namespace Övning_8._11___Lista_primtal
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("Välkommen till primtalslistningen!\n------------------------------\n");
				Console.Write("Ange ett primtal: ");
				string input = Console.ReadLine();
				bool success = int.TryParse(input, out int userNumber);

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
					Console.Write($"Talet {userNumber} är ett primtal");
				}
				else if (userNumber <= 1)
				{
					Console.Write($"Talet {userNumber} är inte ett primtal");
				}
				else if (userNumber % 2 == 0)
				{
					Console.Write($"Talet {userNumber} är jämnt och således inte ett primtal");
				}
				else
				{
					bool isPrime = true;
					double squareRoot = Math.Sqrt(userNumber);

					for (int i = 2; i <= squareRoot; i++)
					{
						if (userNumber % i == 0)
						{
							isPrime = false;
							break;
						}
					}

					if (isPrime) 
					{
						Console.WriteLine($"\nHär följer en lista av primtal upp till primtalet {userNumber}\n");
						Console.Write("2 ");
						int printThePrime = 3;
						int rowCounter = 1;
						while (printThePrime < userNumber) 
						{
							isPrime = true;
							double squareRoot2 = Math.Sqrt(printThePrime);
							for (int i = 2; i <= squareRoot2; i++)
							{
								if (printThePrime % i == 0) 
								{ 
									isPrime = false;
									break;
								}
							}
							if (isPrime) 
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
						Console.Write($"Talet {userNumber} är inte ett primtal");
				}
				Console.ReadKey();
				Console.Clear();
			}
		}
	}
}
