using System;

namespace PacmanGame
{
	class Ghost
	{
		public int x;
		public int y;
		ConsoleColor color;
		int direction;
		Random random = new Random();
		public Ghost(int x, int y, ConsoleColor color)
		{
			this.x = x;
			this.y = y;
			this.color = color;
		}

		public int GetOpposite(int direction)
		{
			switch (direction)
			{
				case Constants.UP: return Constants.DOWN;
				case Constants.RIGHT: return Constants.LEFT;
				case Constants.DOWN: return Constants.UP;
				case Constants.LEFT: return Constants.RIGHT;
				default: return Constants.IDLE;
			}
		}

		public void ChangeDirection(int[,] maze)
		{
			List<int> possibleDirections = new List<int>();

			if (maze[y - 1, x] != Constants.WALL)
				possibleDirections.Add(Constants.UP);

			if (maze[y + 1, x] != Constants.WALL)
				possibleDirections.Add(Constants.DOWN);

			if (maze[y, x - 1] != Constants.WALL)
				possibleDirections.Add(Constants.LEFT);

			if (maze[y, x + 1] != Constants.WALL)
				possibleDirections.Add(Constants.RIGHT);

			// Ta bort bakåt
			int opposite = GetOpposite(direction);
			possibleDirections.Remove(opposite);

			// Slumpa ny riktning
			direction = possibleDirections[random.Next(possibleDirections.Count)];
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

			if (maze[newY, newX] != Constants.WALL)
			{
				x = newX;
				y = newY;
			}
		}



		/*
         * Draw
         *
         * Draws a red @ at (x, y) coordinate
         *
         */
		public void Draw()
		{
			Console.ForegroundColor = color;
			WriteAt("ᗣ");
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

		/*
         * Delete
         *
         * Deletes @ at (x, y) coordinate
         *
         */
		public void Delete(int[,] maze)
		{
			if (maze[y, x] == Constants.PELLET)
				WriteAt(".");
			else
				WriteAt(" ");
		}
	}
}
