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
			var enemy = new Enemy(5, 1, Constants.DOWN);
			player.Draw();
			enemy.Draw();
			while (true)
			{
				player.ChangeDirection(maze);
				enemy.ChangeDirection(maze);
				player.Move(maze);
				enemy.Move(maze);
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
