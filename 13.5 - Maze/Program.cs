namespace Maze
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.CursorVisible = false;
			Maze maze = new Maze();
			maze.Draw();
			Player player = new Player();
			while (true)
			{
				ReadKeys(player);
				player.ChangeDirection(maze);
				player.Delete();
				player.Move(maze);
				player.Draw();
				if (maze.maze[player.y, player.x] == 2)
				{
					Console.SetCursorPosition(Constants.X_SCREEN_POS, Constants.Y_SCREEN_POS + maze.maze.GetLength(0));
					Console.WriteLine("GAME OVER!");
					break;
				}
				Thread.Sleep(200);
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
				keyInfo = Console.ReadKey();

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
	}
}
