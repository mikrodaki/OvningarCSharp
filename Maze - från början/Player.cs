namespace MazeGame
{
	class Player
	{
		public int x = 1;
		public int y = 1;
		private int direction = Constants.IDLE;
		private int nextdirection = Constants.IDLE;


		/*
         * Draw
         * 
         * Draw X at current coordinate
         * 
         */
		public void Draw()
		{
			Console.ForegroundColor = ConsoleColor.White;
			WriteAt("X");
		}


		/*
         * Delete
         * 
         * Deletes X from current coordinate
         * 
         */
		public void Delete()
		{
			WriteAt(" ");
		}


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

			if (maze.grid[newY, newX] != 1)
			{
				Delete();
				x = newX;
				y = newY;
				Draw();
			}
		}


		public void SetNextDirection(int direction) 
		{ 
			nextdirection = direction;
		}


		public void ChangeDirection(Maze maze) 
		{
			int newX = x;
			int newY = y;

			switch (nextdirection)
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
			}

			if (maze.grid[newY, newX] != 1)
			{
				direction = nextdirection;
			}
		}


		/*
         * WriteAt
         * 
         * Private help method that prints a text
         * at a specific coordinate
         * 
         */
		void WriteAt(string text)
		{
			Console.SetCursorPosition(x + Constants.X_SCREEN_POS, y + Constants.Y_SCREEN_POS);
			Console.Write(text);
		}
	}
}
