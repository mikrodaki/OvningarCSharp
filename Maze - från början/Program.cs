namespace MazeGame
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.CursorVisible = false;
			var maze = new Maze();
			maze.Draw();
			var player = new Player();
			player.Draw();
			while (true)
			{
				//player.Draw();
				//player.Delete();
				player.ChangeDirection(maze);
				player.Move(maze);
				ReadKeys(player);
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
