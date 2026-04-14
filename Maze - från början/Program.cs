namespace MazeGame
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.CursorVisible = false;
			var maze = new Maze();
			var player = new Player();
			var enemies = new List<Enemy>();
			int[] enemyX = new int[] { 5, 7, 15, 29, 23, 1, 11, 15 };
			int[] enemyY = new int[] { 1, 3, 1, 1, 15, 15, 17, 11 };
			int[] enemyDir = new int[] { 2, 4, 4, 2, 4, 4, 4, 2 };
			for (int i = 0; i < enemyX.Length; i++)
			{
				enemies.Add(new Enemy(enemyX[i], enemyY[i], enemyDir[i]));
			}
			maze.Draw();
			player.Draw();
			while (true)
			{
				ReadKeys(player);

				player.ChangeDirection(maze);
				foreach (Enemy enemy in enemies)
					enemy.ChangeDirection(maze);

				player.Move(maze);

				if (maze.IsGoal(player.y, player.x))
				{
					Console.SetCursorPosition(Constants.X_SCREEN_POS, Constants.Y_SCREEN_POS + maze.grid.GetLength(0) + 1);
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("GOAL! GAME OVER");
					Console.ForegroundColor = ConsoleColor.White;
					break;
				}

				if (maze.IsYellowKey(player.y, player.x)) 
				{
					maze.OpenDoorAndRemoveKey(Constants.KEY1);
				}

				//if (CheckCollision(player, enemies)) 
				//{ 
				//	player = ResetPlayer();
				//	continue;
				//}

				foreach (Enemy enemy in enemies)
					enemy.Move(maze);

				//if (CheckCollision(player, enemies))
				//{
				//	player = ResetPlayer();
				//	continue;
				//}

				Thread.Sleep(120);
			}
		}


		/*
         * ReadKeys
         * 
         * Reads arrow keys and store the next direction
         * 
         */
		static void ReadKeys(Player player)
		{
			ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();

			if (Console.KeyAvailable)
				keyInfo = Console.ReadKey(true);

			switch (keyInfo.Key)
			{
				case ConsoleKey.UpArrow:
					player.SetNextDirection(Constants.UP);
					break;

				case ConsoleKey.DownArrow:
					player.SetNextDirection(Constants.DOWN);
					break;

				case ConsoleKey.LeftArrow:
					player.SetNextDirection(Constants.LEFT);
					break;

				case ConsoleKey.RightArrow:
					player.SetNextDirection(Constants.RIGHT);
					break;

				default:
					break;
			}
		}

		/*
		 * Hit
		 * 
		 * Hit loops and shows X and @ five times 
		 * at the specified coordinate.
		 * 
		 */
		static void Hit(int x, int y)
		{
			for (int i = 0; i < 5; i++)
			{
				WriteAt(x, y, ConsoleColor.White, 'X');
				WriteAt(x, y, ConsoleColor.Red, '@');
			}

			WriteAt(x, y, ConsoleColor.Black, ' ');
		}


		/*
		 * WriteAt
		 * 
		 * WriteAt - help method that writes a char at
		 * a specific coordinate in a specified color
		 * 
		 */
		static void WriteAt(int x, int y, ConsoleColor color, char c)
		{
			Console.ForegroundColor = color;
			Console.SetCursorPosition(x + Constants.X_SCREEN_POS, y + Constants.Y_SCREEN_POS);
			Console.Write(c);
			System.Threading.Thread.Sleep(120);
		}

		static bool CheckCollision(Player player, List<Enemy> enemies)
		{
			foreach (Enemy enemy in enemies)
			{
				if (enemy.x == player.x && enemy.y == player.y)
				{
					Hit(enemy.x, enemy.y);
					return true;
				}
			}
			return false;
		}

		static Player ResetPlayer()
		{
			Player player = new Player();
			player.Draw();
			return player;
		}
	}
}
