using System;

namespace Övning_5._12
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Välkommen till sten, sax, påse");
			Console.WriteLine("-------------------------------");

			int playerScore = 0;
			int cmpScore = 0;
			int cmpChoice = 0;
			int playerChoice = 0;

			var rnd = new Random();
			string[] tools = { "", "sten", "sax", "påse" };

			for (int i = 0; i < 5; i++)
			{
				cmpChoice = rnd.Next(1, 4); // datorn väljer (1–3)
				Console.Write("Ange 1 för sten, 2 för sax eller 3 för påse: ");
				string input = Console.ReadLine();

				// Kontrollera att inmatningen är ett heltal mellan 1–3
				if (int.TryParse(input, out playerChoice) && playerChoice >= 1 && playerChoice <= 3)
				{
					Console.WriteLine($"Du valde {tools[playerChoice]} och datorn valde {tools[cmpChoice]}");

					if (playerChoice == cmpChoice)
					{
						Console.WriteLine("Oavgjort!");
					}
					else if ((playerChoice == 1 && cmpChoice == 2) ||
							 (playerChoice == 2 && cmpChoice == 3) ||
							 (playerChoice == 3 && cmpChoice == 1))
					{
						Console.WriteLine("Du vann rundan!");
						playerScore++;
					}
					else
					{
						Console.WriteLine("Datorn vann rundan!");
						cmpScore++;
					}
				}
				else
				{
					// Ogiltigt val – användaren förlorar rundan
					Console.WriteLine("Ogiltigt val, du förlorade rundan!");
					cmpScore++;
				}

				Console.WriteLine();
			}

			// Slutresultat
			if (playerScore > cmpScore)
				Console.WriteLine($"Du vann matchen med {playerScore} mot {cmpScore}!");
			else if (cmpScore > playerScore)
				Console.WriteLine($"Datorn vann matchen med {cmpScore} mot {playerScore}!");
			else
				Console.WriteLine($"Oavgjort! Slutresultat {playerScore} - {cmpScore}.");
		}
	}
}
