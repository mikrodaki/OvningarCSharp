using System.Diagnostics.Metrics;

namespace Övning_8._10___Moving_droid
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int x = 60;
			int y = 14;

			Console.Clear();
			Console.CursorVisible = false;
			
			while (true)
			{
				/* 
				 Flag to break the while loop from the switch if the droid has reached an end
				 of if the user pressed an invalid key
				*/
				bool breakLoop = false;
				// How many steps the droid has taken
				int numberOfSteps = 0;

				// Draw droid
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.SetCursorPosition(x, y);
				Console.Write(" ▄▄▄ ");
				Console.SetCursorPosition(x, y + 1);
				Console.Write("█▄█▄█");
				Console.SetCursorPosition(x, y + 2);
				Console.Write("╚   ╝");

				Console.SetCursorPosition(0, 0);
				
				Console.Write("Vilket håll ska roboten röra sig? (U)pp, (N)er, (V)änster, (H)öger");
				ConsoleKeyInfo key = Console.ReadKey(true); // true = visa inte knappen
				char direction = char.ToLower(key.KeyChar);

				// Delete droid
				Console.SetCursorPosition(x, y);
				Console.Write("     ");
				Console.SetCursorPosition(x, y + 1);
				Console.Write("     ");
				Console.SetCursorPosition(x, y + 2);
				Console.Write("     ");

				while (numberOfSteps < 20 && !breakLoop) {
	
					switch (direction)
					{
						case 'u':
							if (y == 1)
								breakLoop = true;
							else
								y--;
							break;
						case 'n':
							if (y == 26)
								breakLoop = true;
							else
								y++;
							break;
						case 'h':
							if (x == 115)
								breakLoop = true;
							else
								x++;
							break;
						case 'v':
							if (x == 1)
								breakLoop = true;
							else
								x--;
							break;
						default:
							breakLoop = true;
							break;
					}

					Console.CursorVisible = false;

					// Draw droid
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.SetCursorPosition(x, y);
					Console.Write(" ▄▄▄ ");
					Console.SetCursorPosition(x, y + 1);
					Console.Write("█▄█▄█");
					Console.SetCursorPosition(x, y + 2);
					Console.Write("╚   ╝");

					// Pause
					System.Threading.Thread.Sleep(20);

					// Delete droid
					Console.SetCursorPosition(x, y);
					Console.Write("     ");
					Console.SetCursorPosition(x, y + 1);
					Console.Write("     ");
					Console.SetCursorPosition(x, y + 2);
					Console.Write("     ");
					numberOfSteps++;
				}
			}
		}
	}
}
