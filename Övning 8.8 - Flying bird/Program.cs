namespace Övning_8._8___Flying_bird
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int animation = 0;
			// Räknare för att ha kolla på vilket varv man är på
			int animationCounter = 0;
			int x = 55;
			int y = 10;
			// Array för att styra animationen
			int[] animations = { 0, 1, 2, 3, 4, 3, 2, 1, 0, 1, 2, 2, 2, 2, 2, 2, 3, 4, 3, 2, 1 };

			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.CursorVisible = false;

			while (true)
			{
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

				System.Threading.Thread.Sleep(150);

				animationCounter++;

				// Om countern är lika med längden på arrayen så har man nått slutet av animationen
				if (animationCounter == animations.Length)
					animationCounter = 0;

			}
		}
	}
}
