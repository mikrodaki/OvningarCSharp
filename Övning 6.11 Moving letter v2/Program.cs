namespace Övning_6._11_Moving_letter
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int width = Console.WindowWidth;
			int height = Console.WindowHeight;
			int x = width / 2;
			int y = height / 2;
			ConsoleKeyInfo userInput;

			Console.WriteLine("Ange riktning (u)pp, (n)er, (v)änster, (h)öger, (a)vsluta: ");
			Console.SetCursorPosition(x, y);
			Console.Write("o");
			Console.CursorVisible = false;

			while (true) 
			{
				userInput = Console.ReadKey(intercept: true);
				char direction = userInput.KeyChar;

				if (direction == 'a')
					break;

				for (int i = 0; i < 8; i++) 
				{
					// Delete o
					Console.SetCursorPosition(x, y);
					Console.WriteLine(" ");

					// Change coordinate one step in the selected direction
					switch (direction)
					{
						case 'u':
							if (y > 0)
								y--;
							break;

						case 'n':
							if (y < 28)
								y++;
							break;

						case 'v':
							if (x > 0)
								x--;
							break;

						case 'h':
							if (x < 119)
								x++;
							break;

						default:
							break;
					}

					// Draw o at new coordinate
					Console.SetCursorPosition(x, y);
					Console.WriteLine("o");

					// Pause
					System.Threading.Thread.Sleep(100);
				}
			}
		}
	}
}
