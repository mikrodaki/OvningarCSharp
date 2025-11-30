namespace _8._9_Ball___Fredriks_facit
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int x = 40;
			int y = 8;
			int row = 6;
			int dirX = 1;   // 1=right, -1=left
			int dirY = 1;   // 1=down,  -1=up

			Console.Clear();
			Console.CursorVisible = false;

			// Draw square
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.SetCursorPosition(35, 5);
			Console.WriteLine("╔═══════════════════════════════════════════════════╗");
			while (row < 24)
			{
				Console.SetCursorPosition(35, row);
				Console.WriteLine("║                                                   ║");
				row++;
			}
			Console.SetCursorPosition(35, 23);
			Console.WriteLine("╚═══════════════════════════════════════════════════╝");


			// Move ball
			Console.ForegroundColor = ConsoleColor.Yellow;
			while (true)
			{
				// Draw
				Console.SetCursorPosition(x, y);
				Console.Write("o");

				// Pause
				System.Threading.Thread.Sleep(40);

				// Delete
				Console.SetCursorPosition(x, y);
				Console.Write(" ");

				// Change x direction
				if (x < 37 || x > 85)
					dirX = -dirX;

				// Change y direction
				if (y < 7 || y > 21)
					dirY = -dirY;

				// Move
				x = x + dirX;
				y = y + dirY;
			}
		}
	}
}
