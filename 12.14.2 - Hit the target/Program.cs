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

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.SetCursorPosition(10, 7);
            Console.WriteLine("Gissa var målet finns!");
            while (true)
            {
                Console.SetCursorPosition(10, 9);
                int row = ConsoleHelper.ReadInt("Ange rad (1-4): ", 1, 4, 10, 9);

                Console.SetCursorPosition(10, 10);
                int col = ConsoleHelper.ReadInt("Ange kolumn (1-4): ", 1, 4, 10, 10);

                shotsFired[row - 1, col - 1] = 1;
                Board.Draw(shotsFired);
            }

            Console.ReadKey();
        }
    }
}
