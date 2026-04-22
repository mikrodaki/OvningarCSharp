namespace PacmanGame
{
    class Ghost
    {
        public int x;
        public int y;
        ConsoleColor color;
        int direction;
        public Ghost(int x, int y, ConsoleColor color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
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

            //if (!maze.IsWall(newY, newX))
            //{
            //    Delete();
            //    x = newX;
            //    y = newY;
            //    Draw();
            //}
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
            if (maze[y, x] == 2)
                WriteAt(".");
            else if (maze[y, x] == 1)
                WriteAt(" ");
        }
    }
}
