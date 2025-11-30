namespace _8._9___Ball
{
	internal class Program
	{
		public enum Direction 
		{ 
			RightDown,
			RightUp,
			LeftDown,
			LeftUp,
		}
		static void Main(string[] args)
		{
			int x = 50;
			int y = 8;
			int c = 0;

			// Variables to check the size of the square
			int minX = 36;
			int maxX = 85;
			int minY = 6;
			int maxY = 22;

			// The current direction of the ball
			Direction direction = Direction.RightUp;
			
			Console.Clear();
			Console.CursorVisible = false;


			/*
             * Draw blue rectangle
             *
             */
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.SetCursorPosition(35, 5);
			Console.WriteLine("╔═══════════════════════════════════════════════════╗");
			while (c < 18)
			{
				Console.SetCursorPosition(35, 6 + c);
				Console.WriteLine("║                                                   ║");
				c++;
			}
			Console.SetCursorPosition(35, 23);
			Console.WriteLine("╚═══════════════════════════════════════════════════╝");


			Console.ForegroundColor = ConsoleColor.Yellow;


			// Bounce ball in rectangle
			while (true)
			{

				// Draw
				Console.SetCursorPosition(x, y);
				Console.Write("o");

				// Pause
				System.Threading.Thread.Sleep(70);

				// Delete
				Console.SetCursorPosition(x, y);
				Console.Write(" ");

				// Move
				switch (direction)
				{
					case Direction.RightDown:
						{
							x++;
							y++;
							break;
						}
					case Direction.RightUp:
						{
							x++;
							y--;
							break;
						}
					case Direction.LeftUp:
						{
							x--;
							y--;
							break;
						}
					case Direction.LeftDown:
						{
							x--;
							y++;
							break;
						}
				}

				// The ball hits the bottom
				if (y == maxY)
				{
					if (direction == Direction.RightDown)
						direction = Direction.RightUp;
					else
						direction = Direction.LeftUp;
				}

				// The ball hits the top
				if (y == minY)
				{
					if (direction == Direction.RightUp)
						direction = Direction.RightDown;
					else
						direction = Direction.LeftDown;
				}

				// The ball hits the right wall
				if (x == maxX)
				{
					if (direction == Direction.RightUp)
						direction = Direction.LeftUp;
					else
						direction = Direction.LeftDown;
				}

				// The ball hits the left wall
				if (x == minX)
				{
					if (direction == Direction.LeftUp)
						direction = Direction.RightUp;
					else
						direction = Direction.RightDown;
				}

			}
		}
	}
}
