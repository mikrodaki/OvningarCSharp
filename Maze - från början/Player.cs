namespace MazeGame
{
	class Player
	{
		public int x = 1;
		public int y = 1;
		private int direction = Constants.IDLE;
		private int nextDirection = Constants.IDLE;


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

			if (!maze.IsWall(newY, newX))
			{
				Delete();
				x = newX;
				y = newY;
				Draw();
			}
		}


		public void SetNextDirection(int nextDirection)
		{
			this.nextDirection = nextDirection;
		}


		public void ChangeDirection(Maze maze)
		{
			int newX = x;
			int newY = y;

			switch (nextDirection)
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

			if (!maze.IsWall(newY, newX))
			{
				direction = nextDirection;
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
