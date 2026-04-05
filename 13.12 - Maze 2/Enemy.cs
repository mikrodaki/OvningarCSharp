namespace Maze
{
	class Enemy
	{
		public int x;
		public int y;
		int direction;


		/*
         * Draw
         *
         * Draws a red @ at (x, y) coordinate
         *
         */

		public Enemy(int x, int y, int direction)
		{
			this.x = x;
			this.y = y;
			this.direction = direction;
		}
		public void Draw()
		{
			Console.ForegroundColor = ConsoleColor.Red;
			WriteAt("@");
		}


		/*
         * Delete
         *
         * Deletes @ at (x, y) coordinate
         *
         */
		public void Delete()
		{
			WriteAt(" ");
		}


		/*
         * Move
         *
         * Moves the @ one step in the current
         * direction if possible
         *
         */
		public void Move(int[,] maze)
		{
			switch (direction)
			{
				case Constants.UP:
					if (maze[y - 1, x] != 1)
						y--;
					break;

				case Constants.DOWN:
					if (maze[y + 1, x] != 1)
						y++;
					break;

				case Constants.LEFT:
					if (maze[y, x - 1] != 1)
						x--;
					break;

				case Constants.RIGHT:
					if (maze[y, x + 1] != 1)
						x++;
					break;

				default:
					break;
			}
		}


		/*
         * ChangeDirection
         *
         * ChangeDirection changes direction of the @ to 
         * the opposite direction if it has reached a wall
         *
         */
		public void ChangeDirection(int[,] maze)
		{
			switch (direction)
			{
				case Constants.UP:
					if (maze[y - 1, x] == 1)
						direction = Constants.DOWN;
					break;

				case Constants.DOWN:
					if (maze[y + 1, x] == 1)
						direction = Constants.UP;
					break;

				case Constants.LEFT:
					if (maze[y, x - 1] == 1)
						direction = Constants.RIGHT;
					break;

				case Constants.RIGHT:
					if (maze[y, x + 1] == 1)
						direction = Constants.LEFT;
					break;

				default:
					break;
			}
		}


		/*
         * WriteAt
         *
         * WriteAt is a help method that writes
         * a text at a specific coordinate
         *
         */
		void WriteAt(string text)
		{
			Console.SetCursorPosition(x + Constants.X_SCREEN_POS, y + Constants.Y_SCREEN_POS);
			Console.Write(text);
		}
	}
}
