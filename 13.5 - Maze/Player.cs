using System;

namespace Maze
{
    class Player
    {
        public int x = 1;
        public int y = 1;
        public int direction = Constants.RIGHT;
        public int nextdirection = Constants.IDLE;


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
            int dirX = 0;
            int dirY = 0;

            switch (direction) 
            { 
                case Constants.UP:
                    dirY = -1;
                    break;
                case Constants.DOWN:
                    dirY = 1; 
                    break;
                case Constants.LEFT:
                    dirX = -1;
                    break;
                case Constants.RIGHT:
                    dirX = 1;
                    break;
            }

            int newX = x + dirX;
            int newY = y + dirY;

            if (maze.maze[newY,newX] != 1) 
            { 
                x = newX;
                y = newY;
            }
        }


        // public static void SetNextDirection..


        // public static void ChangeDirection..


        /*
         * WriteAt
         * 
         * Help method that prints a text
         * at a specific coordinate
         * 
         */
        public void WriteAt(string text)
        {
            Console.SetCursorPosition(x + Constants.X_SCREEN_POS, y + Constants.Y_SCREEN_POS);
            Console.Write(text);
        }
    }
}
