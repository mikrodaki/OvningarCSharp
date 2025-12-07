using System.Formats.Asn1;

namespace Övning_8._13___Ghost_moving
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int x = 2;
			int y = 2;
			int dirX = 1;
			int dirY = 0;

			// String that holds the directions
			string directions = "lrud";

			char randomDirection = 'r';
			Random rnd = new Random();
			char currentDirection = 'r';
			int minX = 2;
			int maxX = 100;
			int minY = 2;
			int maxY = 23;
			bool firstMove = true;

			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Clear();
			Console.CursorVisible = false;

			Console.WriteLine();
			Console.WriteLine(" ╔═══════════════════════════════════════════════════════════════════════════════════════════════════════╗");
			Console.WriteLine(" ║                                                                                                       ║");
			Console.WriteLine(" ║                                                                                                       ║");
			Console.WriteLine(" ║                                                                                                       ║");

			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine(" ║     ╔═══════╗     ╔═══════╗     ╔═══════╗     ╔═══════╗     ╔═══════╗     ╔═══════╗     ╔═══════╗     ║");
				Console.WriteLine(" ║     ║       ║     ║       ║     ║       ║     ║       ║     ║       ║     ║       ║     ║       ║     ║");
				Console.WriteLine(" ║     ║       ║     ║       ║     ║       ║     ║       ║     ║       ║     ║       ║     ║       ║     ║");
				Console.WriteLine(" ║     ╚═══════╝     ╚═══════╝     ╚═══════╝     ╚═══════╝     ╚═══════╝     ╚═══════╝     ╚═══════╝     ║");
				Console.WriteLine(" ║                                                                                                       ║");
				Console.WriteLine(" ║                                                                                                       ║");
				Console.WriteLine(" ║                                                                                                       ║");
			}

			Console.WriteLine(" ╚═══════════════════════════════════════════════════════════════════════════════════════════════════════╝");

			while (true)
			{
				// Draw
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
				System.Threading.Thread.Sleep(50);

				// Delete
				Console.SetCursorPosition(x, y);
				Console.WriteLine("     ");
				Console.SetCursorPosition(x, y + 1);
				Console.WriteLine("     ");
				Console.SetCursorPosition(x, y + 2);
				Console.WriteLine("     ");

				// Move

				// True if ghost is at an intersection
				if (x % 14 == 2 && y % 7 == 2)
				{
					// The ghost has to start to the right firstMove is true from the begining then false
					if (!firstMove)
					{
						// Remove all the impossible directions
						if (x == minX)
							directions = directions.Replace("l", "");
						if (x == maxX)
							directions = directions.Replace("r", "");
						if (y == minY)
							directions = directions.Replace("u", "");
						if (y == maxY)
							directions = directions.Replace("d", "");
						if (currentDirection == 'l')
							directions = directions.Replace("r", "");
						if (currentDirection == 'r')
							directions = directions.Replace("l", "");
						if (currentDirection == 'u')
							directions = directions.Replace("d", "");
						if (currentDirection == 'd')
							directions = directions.Replace("u", "");

						// Remove the direction that the ghost currently has
						directions = directions.Replace(currentDirection.ToString(), "");

						// Get a random direction from the possible ones
						randomDirection = directions[rnd.Next(directions.Length)];

						currentDirection = randomDirection;

						// Reset the direction list to default = all directions availiable
						directions = "lrud";
					}
					else
					{
						firstMove = false;
					}
				}


				switch (randomDirection)
				{
					case 'r':
						{
							dirX = 1;
							dirY = 0;
							break;
						}
					case 'l':
						{
							dirX = -1;
							dirY = 0;
							break;
						}
					case 'u':
						{
							dirX = 0;
							dirY = -1;
							break;
						}
					case 'd':
						{
							dirX = 0;
							dirY = 1;
							break;
						}
				}

				// Move the ghost in the current direction
				x = x + dirX;
				y = y + dirY;
			}
		}
	}
}
