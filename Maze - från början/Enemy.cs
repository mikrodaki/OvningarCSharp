namespace MazeGame
{
	class Enemy
	{
		public int x;
		public int y;
		int direction;

		public Enemy(int x, int y, int direction)
		{
			this.x = x;
			this.y = y;
			this.direction = direction;
		}


		/*
         * Draw
         *
         * Draws a red @ at (x, y) coordinate
         *
         */
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
		public void Move(Maze maze)
		{
			int newX = x;
			int newY = y;

			switch (direction)
			{
				case Constants.UP:
					newY--;
					break;
				case Constants.RIGHT:
					newX++;
					break;
				case Constants.DOWN:
					newY++;
					break;
				case Constants.LEFT:
					newX--;
					break;
				case Constants.IDLE:
					return;
			}

			if (!maze.IsWall(newY, newX))
			{
				Delete();
				x = newX;
				y = newY;
				Draw();
			}
		}


		/*
         * ChangeDirection
         *
         * ChangeDirection changes direction of the @ to 
         * the opposite direction if it has reached a wall
         *
         */
		public void ChangeDirection(Maze maze)
		{
			switch (direction)
			{
				case Constants.UP:
					if (maze.IsWall(y - 1, x))
						direction = Constants.DOWN;
					break;

				case Constants.DOWN:
					if (maze.IsWall(y + 1, x))
						direction = Constants.UP;
					break;

				case Constants.LEFT:
					if (maze.IsWall(y, x - 1))
						direction = Constants.RIGHT;
					break;

				case Constants.RIGHT:
					if (maze.IsWall(y, x + 1))
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
