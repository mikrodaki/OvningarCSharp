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
				player.Draw();
				Thread.Sleep(200);
				player.Delete();
				player.Move(maze);
			}
		}


		/*
		 * ReadKeys
		 * 
		 * Reads arrow keys and store the next direction
		 * 
		 */
		static void ReadKeys()
		{
			ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();

			if (Console.KeyAvailable)
				keyInfo = Console.ReadKey();

			switch (keyInfo.Key)
			{
				case ConsoleKey.UpArrow:
					//Player.SetNextDirection(Constants.UP);
					break;

				case ConsoleKey.DownArrow:
					//Player.SetNextDirection(Constants.DOWN);
					break;

				case ConsoleKey.LeftArrow:
					//Player.SetNextDirection(Constants.LEFT);
					break;

				case ConsoleKey.RightArrow:
					//Player.SetNextDirection(Constants.RIGHT);
					break;

				default:
					break;
			}
		}
	}
}
