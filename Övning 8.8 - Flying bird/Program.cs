namespace Övning_8._8___Flying_bird
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int animation = 0;
			// Räknare för att ha kolla på vilket varv man är på
			int animationCounter = 0;
			int x = 35;
			int y = 10;
			int bird = 1;
			int noOfBirds = 3;
			// Array för att styra animationen
			int[] animations = { 0, 1, 2, 3, 4, 3, 2, 1, 0, 1, 2, 2, 2, 2, 2, 2, 3, 4, 3, 2, 1, 1, 1, 1, 1, 1 };

			Console.CursorVisible = false;

			while (true)
			{
				while (bird <= noOfBirds) 
				{
					switch (bird) 
					{
						case 1:
							Console.ForegroundColor = ConsoleColor.Magenta;
							break;
						case 2:
							Console.ForegroundColor = ConsoleColor.Cyan;
							x += 20;
							break;
						case 3:
							Console.ForegroundColor = ConsoleColor.Yellow;
							x += 20; 
							break;
					}

					// Decide the animation
					animation = animations[animationCounter];

					switch (animation)
					{
						case 0:
							Console.SetCursorPosition(x, y);
							Console.Write("▀▀▀▄ ▄▀▀▀ ");
							Console.SetCursorPosition(x, y + 1);
							Console.Write("    █    ");
							Console.SetCursorPosition(x, y + 2);
							Console.Write("         ");
							break;

						case 1:
							Console.SetCursorPosition(x, y);
							Console.Write("▄▄▄   ▄▄▄");
							Console.SetCursorPosition(x, y + 1);
							Console.Write("   ▀█▀   ");
							Console.SetCursorPosition(x, y + 2);
							Console.Write("         ");
							break;

						case 2:
							Console.SetCursorPosition(x, y);
							Console.Write("         ");
							Console.SetCursorPosition(x, y + 1);
							Console.Write("▀▀▀▀█▀▀▀▀");
							Console.SetCursorPosition(x, y + 2);
							Console.Write("         ");
							break;

						case 3:
							Console.SetCursorPosition(x, y);
							Console.Write("         ");
							Console.SetCursorPosition(x, y + 1);
							Console.Write(" ▄▄▀█▀▄▄ ");
							Console.SetCursorPosition(x, y + 2);
							Console.Write("▀       ▀ ");
							break;

						case 4:
							Console.SetCursorPosition(x, y);
							Console.Write("         ");
							Console.SetCursorPosition(x, y + 1);
							Console.Write("  ▄▀█▀▄  ");
							Console.SetCursorPosition(x, y + 2);
							Console.Write(" ▐     ▌ ");
							break;

						default:
							break;
					}

					bird++;
				}
				System.Threading.Thread.Sleep(150);
				// The next animation
				animationCounter++;
				// Start over from the first bird
				bird = 1;
				// Reset the x-value for the first bird
				x = 35;
				// Om countern är lika med längden på arrayen så har man nått slutet av animationen
				if (animationCounter == animations.Length)
					animationCounter = 0;
			}
		}
	}
}
