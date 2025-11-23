namespace Övning_8._7___Fredriks_facit
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int x = 2;
			int y = 2;
			int dirX = 1;
			int dirY = 0;
			int count = 0;

			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Clear();
			Console.CursorVisible = false;     // Turn of cursor

			// Draw frame
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

				// Pause 40ms
				System.Threading.Thread.Sleep(40);

				// Delete ghost
				Console.SetCursorPosition(x, y);
				Console.WriteLine("     ");
				Console.SetCursorPosition(x, y + 1);
				Console.WriteLine("     ");
				Console.SetCursorPosition(x, y + 2);
				Console.WriteLine("     ");

				// Check if it is time to set new direction
				switch (count)
				{
					case 0:
					case 39:
						// Move right
						dirX = 1;
						dirY = 0;
						break;

					case 28:
					case 68:
						// Move down
						dirX = 0;
						dirY = 1;
						break;

					case 79:
						// Move left
						dirX = -1;
						dirY = 0;
						break;

					case 136:
						// Move up
						dirX = 0;
						dirY = -1;
						break;

					case 157:
						// Reset counter when lap completed
						count = -1;
						break;

					default:
						break;
				}

				// Move ghost in current direction
				x = x + dirX;
				y = y + dirY;

				// Increase step counter
				count++;
			}
		}
	}
}
