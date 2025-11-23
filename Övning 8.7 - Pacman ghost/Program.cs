namespace Övning_8._7___Pacman_ghost
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int x = 2;
			int y = 2;

			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.Blue;

			Console.Clear();
			Console.CursorVisible = false;

			//Draw path
			Console.WriteLine();
			Console.WriteLine(" ╔═════════════════════════════════╗");
			Console.WriteLine(" ║                                 ║");
			Console.WriteLine(" ║                                 ║");
			Console.WriteLine(" ║                                 ║");
			Console.WriteLine(" ║     ╔═════════════════════╗     ║");
			Console.WriteLine(" ║     ║                     ║     ║");
			Console.WriteLine(" ║     ║                     ║     ║");
			Console.WriteLine(" ║     ║                     ║     ║");
			Console.WriteLine(" ║     ║                     ║     ║");
			Console.WriteLine(" ║     ║                     ║     ║");
			Console.WriteLine(" ║     ║                     ║     ║");
			Console.WriteLine(" ║     ║                     ║     ╚════════════════════════════╗");
			Console.WriteLine(" ║     ║                     ║                                  ║");
			Console.WriteLine(" ║     ║                     ║                                  ║");
			Console.WriteLine(" ║     ║                     ║                                  ║");
			Console.WriteLine(" ║     ║                     ╚════════════════════════════╗     ║");
			Console.WriteLine(" ║     ║                                                  ║     ║");
			Console.WriteLine(" ║     ║                                                  ║     ║");
			Console.WriteLine(" ║     ║                                                  ║     ║");
			Console.WriteLine(" ║     ║                                                  ║     ║");
			Console.WriteLine(" ║     ║                                                  ║     ║");
			Console.WriteLine(" ║     ║                                                  ║     ║");
			Console.WriteLine(" ║     ╚══════════════════════════════════════════════════╝     ║");
			Console.WriteLine(" ║                                                              ║");
			Console.WriteLine(" ║                                                              ║");
			Console.WriteLine(" ║                                                              ║");
			Console.WriteLine(" ╚══════════════════════════════════════════════════════════════╝");

			// Keeps track of in which direction the ghost should move
			int ghostMoves = 0;

			while (true)
			{
				// Draw ghost
				Console.ForegroundColor = ConsoleColor.Red;
				Console.SetCursorPosition(x, y);
				Console.WriteLine(" ▄▄▄");
				Console.SetCursorPosition(x, y + 1);
				Console.Write("█");
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.Write("o");
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write("█");
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.Write("o");
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("█");
				Console.SetCursorPosition(x, y + 2);
				Console.WriteLine("█▀█▀█");

				// Pause
				System.Threading.Thread.Sleep(10);

				// Delete ghost
				Console.SetCursorPosition(x, y);
				Console.WriteLine("     ");
				Console.SetCursorPosition(x, y + 1);
				Console.WriteLine("     ");
				Console.SetCursorPosition(x, y + 2);
				Console.WriteLine("     ");

				// Move
				switch (ghostMoves) 
				{ 
					case 0:
						if (x < 30)
							x++;
						else
							ghostMoves = 1;
						break;
					case 1:
						if (y < 13) 
							y++;
						else ghostMoves = 2;
						break;
					case 2:
						if (x < 59)
							x++;
						else ghostMoves = 3;
						break;
					case 3:
						if (y < 24)
							y++;
						else ghostMoves = 4;
						break;
					case 4:
						if (x > 2)
							x--;
						else ghostMoves = 5;
						break;
					case 5:
						if (y > 2)
							y--;
						else ghostMoves = 0;
						break;
				}
			}
		}
	}
}
