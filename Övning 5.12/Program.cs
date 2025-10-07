using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Övning_5._12
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Välkommen till sten, sax, påse");
			Console.WriteLine("------------------");
			int playerScore = 0;
			int cmpScore = 0;
			int cmpChoice = 0;
			int playerChoice = 0;
			var rnd = new Random();

			for (int i = 0; i < 3; i++)
			{
				cmpChoice = rnd.Next(1, 4); // 1, 2 eller 3
				Console.Write("Ange 1 för sten, 2 för sax eller 3 för påse: ");
				string input = Console.ReadLine();
				if (int.TryParse(input, out playerChoice))
				{
					if (playerChoice >= 1 && playerChoice <= 3)
					{
						switch (playerChoice)
						{
							case (1):
								Console.WriteLine($"Du valde {playerChoice} (sten) och datorn valde {cmpChoice}");
								break;
							case (2):
								Console.WriteLine($"Du valde {playerChoice} (sax) och datorn valde {cmpChoice}");
								break;
							case (3):
								Console.WriteLine($"Du valde {playerChoice} (påse) och datorn valde {cmpChoice}");
								break;
						}
					}
					else 
					{ 
						Console.WriteLine("Ogiltigt val, du förlorade rundan");
						cmpScore++;
					}
				}
				else
				{
					Console.WriteLine("Ogiltigt val, du förlorade rundan");
					cmpScore++;
				}
			}

			string calculateScore (int choice1, int choice2) 
			{
				if (choice1 == choice2)
					return "draw";
				return "";
			}
		}
	}
}
