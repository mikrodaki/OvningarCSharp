using App.IO;
using ConsoleGame.UI;

namespace _12._14._2___Hit_the_target
{
    internal class Program
    {
        static int[,] shotsFired = new int[4, 4];
        static void Main(string[] args)
        {
            Board.DrawFrame();
            Board.DrawConsoleFrame();

            // Set the target
            (int x, int y) target = Board.RandomizeTarget();
            shotsFired[target.x - 1, target.y - 1] = 2;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(10, 7);
            Console.WriteLine("Gissa var målet finns!");

            bool gameOver = false;
            while (!gameOver)
            {
                string s1 = "Ange rad (1-4): ";
                Console.SetCursorPosition(10, 9);
                int row = ConsoleHelper.ReadInt(s1, 1, 4, 10, 9);

                string s2 = "Ange kolumn (1-4): ";
                Console.SetCursorPosition(10, 10);
                int col = ConsoleHelper.ReadInt(s2, 1, 4, 10, 10);

                if (shotsFired[row - 1, col - 1] == 0)
                    shotsFired[row - 1, col - 1] = 1;
                else if (shotsFired[row - 1, col - 1] == 2) 
                { 
					shotsFired[row - 1, col - 1] = 3;
                    gameOver = true;
                }

				Board.Draw(shotsFired);

                // Clears the previous numbers, uses the string to know what to clear. 
                Board.ClearNumbers(10, 9, s1);
				Board.ClearNumbers(10, 10, s2);
			}
			Console.ReadKey();
        }
    }
}
