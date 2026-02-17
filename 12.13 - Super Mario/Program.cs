using ColorConstants;

namespace _12._13___Super_Mario
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.BackgroundColor = ConsoleColor.Gray;
			Console.Clear();
			int x = 20;
			for (int i = 0; i < 4; i++)
			{
				DrawMario(x, 5, Color.hatAndShirts[i], Color.pants[i]);
				x += 20;
			}
			Console.CursorVisible = false;
		}

		static void DrawMario(int x, int y, int hatShirtColor, int pantsColor)
		{
			/*
			 * 0 = background
			 * 1 = hat, shirt
			 * 2 = hair, mustasch, feet
			 * 3 = skin, buttons
			 * 4 = pants
			 */
			int[,] sprite = new int[,] {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
										{0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0},
										{0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0},
										{0, 0, 0, 2, 2, 2, 2, 3, 3, 2, 3, 0, 0, 0, 0, 0},
										{0, 0, 2, 2, 3, 2, 3, 3, 3, 2, 3, 3, 3, 0, 0, 0},
										{0, 0, 2, 2, 3, 2, 2, 3, 3, 3, 2, 3, 3, 3, 0, 0},
										{0, 0, 0, 2, 2, 3, 3, 3, 3, 2, 2, 2, 2, 0, 0, 0},
										{0, 0, 0, 0, 3, 3, 3, 3 ,3 ,3 ,3 ,3 ,0, 0, 0, 0},
										{0, 0, 0, 1, 1, 4, 1, 1, 1, 1, 4, 1, 1, 0, 0, 0},
										{0, 0, 1, 1, 1, 4, 1, 1, 1, 1, 4, 1, 1, 1, 0, 0},
										{0, 1, 1, 1, 1, 4, 4, 4, 4, 4, 4, 1, 1, 1, 1, 0},
										{0, 3, 3, 1, 4, 3, 4, 4, 4, 4, 3, 4, 1, 3, 3, 0},
										{0, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4, 4, 3, 3, 3, 0},
										{0, 3, 3, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 3, 3, 0},
										{0, 0, 0, 4, 4, 4, 4, 0, 0, 4, 4, 4, 4, 0, 0, 0},
										{0, 0, 2, 2, 2, 2, 0, 0, 0, 0, 2, 2, 2, 2, 0, 0},
										{0, 2, 2, 2, 2, 2, 0, 0, 0, 0, 2, 2, 2, 2, 2, 0}};

			for (int row = 0; row < sprite.GetLength(0); row++)
			{
				Console.SetCursorPosition(x, y + row);
				for (int col = 0; col < sprite.GetLength(1); col++)
				{
					int pixel = sprite[row, col];
					switch (pixel)
					{
						case 0: Console.BackgroundColor = ConsoleColor.Gray; break;
						case 2: Console.BackgroundColor = ConsoleColor.Black; break;
						case 3: Console.BackgroundColor = ConsoleColor.Yellow; break;
						case 1: Console.BackgroundColor = ConvertColor(hatShirtColor); break;
						case 4: Console.BackgroundColor = ConvertColor(pantsColor); break;
					}

					Console.Write(" ");
				}
			}
		}

		static ConsoleColor ConvertColor(int c)
		{
			switch (c)
			{
				case Color.RED: return ConsoleColor.Red;
				case Color.CYAN: return ConsoleColor.Cyan;
				case Color.GREEN: return ConsoleColor.Green;
				case Color.MAGENTA: return ConsoleColor.Magenta;
				case Color.BLUE: return ConsoleColor.Blue;
				case Color.DARKRED: return ConsoleColor.DarkRed;
				case Color.DARKMAGENTA: return ConsoleColor.DarkMagenta;
				case Color.DARKYELLOW: return ConsoleColor.DarkYellow;
				default: return ConsoleColor.DarkGray;
			}
		}

	}
}
