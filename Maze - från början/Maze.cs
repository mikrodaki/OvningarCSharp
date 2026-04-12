namespace MazeGame
{
	class Maze
	{
		public int[,] grid = new int[,]
		{
				{1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
				{1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1},
				{1, 1, 1, 1, 1, 0, 1, 0, 1, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1},
				{1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 1},
				{1, 0, 1, 1, 1, 0, 1, 0, 1, 0, 1, 1, 1, 0, 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0, 1},
				{1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 7, 0, 1},
				{1, 1, 1, 1, 1, 0, 1, 1, 1, 6, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1, 0, 1, 0, 1, 1, 1, 0, 1},
				{1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1, 1, 1, 0, 0, 0, 1},
				{1, 0, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 0, 1, 0, 1, 1, 1},
				{1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1},
				{1, 1, 1, 0, 1, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 0, 1},
				{1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 4, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1},
				{1, 0, 1, 1, 1, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 0, 1},
				{1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1},
				{1, 0, 1, 0, 1, 1, 1, 0, 1, 0, 1, 0, 1, 1, 1, 0, 1, 0, 1, 1, 1, 0, 1, 0, 1, 0, 1, 1, 1, 1, 1},
				{1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1},
				{1, 1, 1, 0, 1, 0, 1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 8, 1},
				{1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1},
				{1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1},
				{1, 3, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 5, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 2, 1},
				{1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
		};

		public void Draw()
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			for (int row = 0; row < grid.GetLength(0); row++)
			{
				for (int col = 0; col < grid.GetLength(1); col++)
				{
					Console.SetCursorPosition(col + Constants.X_SCREEN_POS, row + Constants.Y_SCREEN_POS);
					switch (grid[row, col])
					{
						case Constants.WALL:
							Console.ForegroundColor = ConsoleColor.DarkYellow;
							Console.Write("▓");
							break;
						case Constants.GOAL:
							Console.ForegroundColor = ConsoleColor.Green;
							Console.Write("»");
							break;
						case Constants.KEY1:
							Console.ForegroundColor = ConsoleColor.Yellow;
							Console.Write("⚷");
							break;
						case Constants.KEY2:
							Console.ForegroundColor = ConsoleColor.Blue;
							Console.Write("⚷");
							break;
						case Constants.KEY3:
							Console.ForegroundColor = ConsoleColor.Magenta;
							Console.Write("⚷");
							break;
						case Constants.DOOR1:
							Console.ForegroundColor = ConsoleColor.Yellow;
							Console.Write("═");
							break;
						case Constants.DOOR2:
							Console.ForegroundColor = ConsoleColor.Blue;
							Console.Write("║");
							break;
						case Constants.DOOR3:
							Console.ForegroundColor = ConsoleColor.Magenta;
							Console.Write("║");
							break;
					}
				}
			}
		}

		public bool IsWall(int row, int col)
		{
			return (grid[row, col] == Constants.WALL);
		}
		public bool IsGoal(int row, int col)
		{
			return (grid[row, col] == Constants.GOAL);
		}
		public bool IsYellowKey(int row, int col)
		{
			return (grid[row, col] == Constants.KEY1);
		}
		public bool IsBlueKey(int row, int col)
		{
			return (grid[row, col] == Constants.KEY2);
		}
		public bool IsMagentaKey(int row, int col)
		{
			return (grid[row, col] == Constants.KEY3);
		}
		public bool IsYellowDoor(int row, int col)
		{
			return (grid[row, col] == Constants.DOOR1);
		}
		public bool IsBlueDoor(int row, int col)
		{
			return (grid[row, col] == Constants.DOOR2);
		}
		public bool IsMagentaDoor(int row, int col)
		{
			return (grid[row, col] == Constants.DOOR3);
		}
		public bool IsDoor(int row, int col)
		{
			return grid[row, col] == Constants.DOOR1 ||
				   grid[row, col] == Constants.DOOR2 ||
				   grid[row, col] == Constants.DOOR3;
		}

		public bool IsBlocked(int row, int col)
		{
			return (IsWall(row, col) || IsDoor(row, col));
		}

		// ▓   Använd detta tecken som vägg
		// »   Använd detta tecken som mål
		// ⚷   Tecknet som ska föreställa en nyckel
		// ═   Horisontell dörr
		// ║   Vertikal dörr 
		/*
		 * (1, 19)	- Gul nyckel
		   (19, 11)	- Blå nyckel
		   (17, 19)	- Magenta nyckel
		
		   (9, 6)	- Gul dörr
		   (28, 5)  - Blå dörr
		   (29, 16)	- Magenta dörr
		*/
}
}
