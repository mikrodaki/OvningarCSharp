namespace Övning_9._3___Space_wars
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.CursorVisible = false;
			Random rnd = new Random();

			// Draw the background
			for (int i = 0; i < 200; i++)
			{
				int x = rnd.Next(0, 119);
				int y = rnd.Next(0, 30);
				int color = rnd.Next(0, 3);
				switch (color) 
				{ 
					case 0:
						Console.ForegroundColor = ConsoleColor.White;
						break;
					case 1:
						Console.ForegroundColor = ConsoleColor.Gray;
						break;
					case 2:
						Console.ForegroundColor = ConsoleColor.DarkGray;
						break;
					default:
						break;
				}
				Console.SetCursorPosition(x,y);
				Console.Write(".");
			}

			// Print the headline
			Console.SetCursorPosition(55, 1);
			Console.WriteLine("Rymdspel");

			// Draw the space ship
			Console.ForegroundColor = ConsoleColor.Green;
			Console.SetCursorPosition(4, 10);
			Console.WriteLine("█████▄▄▄▄▄");
			Console.SetCursorPosition(4, 11);
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine(" ╩      ╩");


			// Start the infinite loop
			while (true)
			{
				// Wait for the users to fire the cannon
				Console.ReadKey();

				// Loop for the cannon ball
				for (int i = 14; i < 118; i++)
				{
					// Draw the cannon ball
					Console.SetCursorPosition(i, 10);
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("▄");

					// Wait, the speed on the animation
					System.Threading.Thread.Sleep(30);

					// Delete the cannon ball
					Console.SetCursorPosition(i, 10);
					Console.WriteLine(" ");
				}
			}
		}
	}
}
