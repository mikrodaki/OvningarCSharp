namespace Övning_5._20
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int x, y, color, letterNumber, noOfLetters = 0;
			string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
			bool sucess = false;
			bool randomColors = false;
			bool randomCharacters = false;
			Random rnd = new Random();

			while (!sucess) 
			{ 
				Console.Write("Hur många bokstäver vill du slumpa fram: ");
				sucess = int.TryParse(Console.ReadLine(), out noOfLetters);
				if (!sucess)
					Console.WriteLine("Ogiltigt val!");
			}

			while (true)
			{
				Console.Write("Vill du ha slumpade färger j eller n: ");
				string input = Console.ReadLine();
				if (input == "j") 
				{ 
					randomColors = true;
					break;
				}
				else if (input == "n") 
					break;
				else
					Console.WriteLine("Ogiltigt val!");
			}

			while (true)
			{
				Console.Write("Vill du ha slumpade bokstäver: ");
				string input = Console.ReadLine();
				if (input == "j")
				{
					randomCharacters = true;
					break;
				}
				else if (input == "n")
					break;
				else
					Console.WriteLine("Ogiltigt val!");
			}


			Console.Clear();

			for (int i = 0; i <= noOfLetters; i++)
			{
				x = rnd.Next(1,120);
				y = rnd.Next(1, 29);
				Console.SetCursorPosition(x, y);

				if (randomColors) 
				{ 
					color = rnd.Next(1, 5);
					switch (color) 
					{
						case 1:
							Console.ForegroundColor = ConsoleColor.Green;
							break;
						case 2:
							Console.ForegroundColor = ConsoleColor.Red;
							break;
						case 3:
							Console.ForegroundColor = ConsoleColor.Blue;
							break;
						case 4:
							Console.ForegroundColor = ConsoleColor.Yellow;
							break;
					}
				}

				if (randomCharacters)
				{
					letterNumber = rnd.Next(0, 32);
					Console.Write(alphabet[letterNumber]);
				}
				else
					Console.Write("X");
			}
			Console.ReadKey();
		}
	}
}
