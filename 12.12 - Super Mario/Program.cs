namespace _12._12___Super_Mario
{
	using System;

	namespace SuperMario
	{
		class Program
		{
			static void Main(string[] args)
			{
				Console.BackgroundColor = ConsoleColor.Gray;
				Console.Clear();
				DrawMario();
				DrawMarioFacingLeft();
				Console.CursorVisible = false;
				Console.ReadKey();
			}

			static void DrawMario()
			{
				// 0 = Grey, 1 = Red, 2 = Black, 3 = Yellow, 4 = Blue
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
					for (int col = 0; col < sprite.GetLength(1); col++)
					{
						int color = sprite[row, col];
						if (color == 0)
							Console.BackgroundColor = ConsoleColor.Gray;
						else if (color == 1)
							Console.BackgroundColor = ConsoleColor.Red;
						else if (color == 2)
							Console.BackgroundColor = ConsoleColor.Black;
						else if (color == 3)
							Console.BackgroundColor = ConsoleColor.Yellow;
						else if (color == 4)
							Console.BackgroundColor = ConsoleColor.Blue;

						Console.Write(" ");
					}
					Console.WriteLine();
				}
			}

			static void DrawMarioFacingLeft()
			{
				// 0 = Grey, 1 = Red, 2 = Black, 3 = Yellow, 4 = Blue
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

				int x = 20;
				int y = 0;

				for (int row = 0; row < sprite.GetLength(0); row++)
				{
					Console.SetCursorPosition(x, y);
					for (int col = sprite.GetLength(1) - 1; col > 0 ; col--)
					{
						int color = sprite[row, col];
						if (color == 0)
							Console.BackgroundColor = ConsoleColor.Gray;
						else if (color == 1)
							Console.BackgroundColor = ConsoleColor.Red;
						else if (color == 2)
							Console.BackgroundColor = ConsoleColor.Black;
						else if (color == 3)
							Console.BackgroundColor = ConsoleColor.Yellow;
						else if (color == 4)
							Console.BackgroundColor = ConsoleColor.Blue;

						Console.Write(" ");
					}
					Console.WriteLine();
					y++;
				}
			}
		}
	}
}
