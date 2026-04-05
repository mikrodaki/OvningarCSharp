namespace Maze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] enemyX = new int[] { 5, 7, 15, 29, 23, 1, 11, 15 };
            int[] enemyY = new int[] { 1, 3, 1, 1, 15, 15, 17, 11 };
            int[] enemyDir = new int[] { 2, 4, 4, 2, 4, 4, 4, 2 };
            List<Enemy> enemies = new List<Enemy>();
            Maze maze = new Maze();
            Player player = new Player();
            //Enemy enemy = new Enemy(5, 1, Constants.DOWN);
            for (int i = 0; i < enemyX.Length; i++)
            {
                enemies.Add(new Enemy(enemyX[i], enemyY[i], enemyDir[i]));
            }

            //Console.CursorVisible = false;
            maze.Draw();
            while (true)
            {
                /*  
                 *  Läs in knapptryckning från användaren och
				    sätt nextDirection-variabeln i player 
				    till knapptryckningen */
                ReadKeys(player);
                /*  
                 *  Ändra direction-variablen i player till nextDirection
                 *  om det går. */
                player.ChangeDirection(maze);
                player.Delete();
                player.Move(maze);
                foreach (Enemy enemy in enemies)
                {
                    if (enemy.x == player.x && enemy.y == player.y)
                    {
                        Hit(enemy.x, enemy.y);
                        player = new Player();
                    }
                }
                player.Draw();
                foreach (Enemy enemy in enemies)
                {
                    enemy.ChangeDirection(maze.maze);
                }
                foreach (Enemy enemy in enemies)
                {
                    enemy.Delete();
                }
                foreach (Enemy enemy in enemies)
                {
                    enemy.Move(maze.maze);
                }
                foreach(Enemy enemy in enemies) 
                {
                    if (enemy.x == player.x && enemy.y == player.y) 
                    { 
                        Hit(enemy.x,enemy.y);
                        player = new Player();
                    }
                }
                foreach (Enemy enemy in enemies)
                {
                    enemy.Draw();
                }
                if (maze.maze[player.y, player.x] == Constants.GOAL)
                {
                    Console.SetCursorPosition(Constants.X_SCREEN_POS + maze.maze.GetLength(1) / 3, Constants.Y_SCREEN_POS + maze.maze.GetLength(0) + 1);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("GOAL!!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    break;
                }
                Thread.Sleep(150);
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
            System.Threading.Thread.Sleep(80);
        }
    }
}
