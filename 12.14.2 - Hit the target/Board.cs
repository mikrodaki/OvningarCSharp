using System;

namespace ConsoleGame.UI
{
    class Board
    {
		static Random rnd = new Random();
		public static void Draw(int[,] shotsFired)
        {
            int x = 61;
            int y = 12;

            for (int i = 0; i < shotsFired.GetLength(0); i++)
            {
                for (int j = 0; j < shotsFired.GetLength(1); j++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    if (shotsFired[i, j] == 1)
                        WriteAt(x, y, "*");
                    else if (shotsFired[i, j] == 3) 
                    {
						Console.ForegroundColor = ConsoleColor.Red;
						WriteAt(x, y, "X");
                        Console.SetCursorPosition(55, 15);
						Console.WriteLine("       BOOM!!!     ");
                    }
					x += 2;
                }
                y += 2;
                x = 61;
            }
        }

        public static void ClearNumbers(int x, int y, string text) 
        {
            string blank = new string(' ', text.Length + 2);
            Console.SetCursorPosition(x, y);
			Console.WriteLine(blank);
        }

        /*
         * DrawConsoleFrame
         * 
         * Draw a outer frame and
         * animates game title
         * 
         */
        public static void DrawConsoleFrame()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            WriteAt(1, 1, "╔");
            WriteAt(118, 1, "╗");

            for (int i = 2; i < 118; i++)
            {
                WriteAt(i, 1, "═");
                WriteAt(i, 28, "═");
            }

            for (int i = 2; i < 28; i++)
            {
                WriteAt(1, i, "║");
                WriteAt(118, i, "║");
            }

            WriteAt(1, 28, "╚");
            WriteAt(118, 28, "╝");

            string label = "HIT THE TARGET";
            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < label.Length; i++)
            {
                WriteAt(50 + i * 2, 2, label[i].ToString());
                WriteAt(50 + i * 2, 27, label[i].ToString());
                WriteAt(2, i + 7, label[i].ToString());
                WriteAt(117, i + 7, label[i].ToString());

                System.Threading.Thread.Sleep(70);

                Console.CursorVisible = true;
            }
        }



        /*
         * DrawFrame
         * 
         * Draws board frame
         * 
         */
        public static void DrawFrame()
        {
            int x = 58;
            int y = 9;

            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            WriteAt(x, y, "╔═╤═╤═╤═╤═╗");

            for (int i = 1; i < 9; i += 2)
            {
                WriteAt(x, y + i, "║ │ │ │ │ ║");
                WriteAt(x, y + i + 1, "╟─┼─┼─┼─┼─╢");
            }

            WriteAt(x, y + 9, "║ │ │ │ │ ║");
            WriteAt(x, y + 10, "╚═╧═╧═╧═╧═╝");

            Console.ForegroundColor = ConsoleColor.Green;
            System.Threading.Thread.Sleep(300);

            for (int i = 1; i < 5; i++)
            {
                WriteAt(x + i * 2 + 1, y + 1, i.ToString());
                WriteAt(x + 1, y + i * 2 + 1, i.ToString());
                System.Threading.Thread.Sleep(140);
            }
        }



        /*
         * WriteAt 
         * 
         * Help method to write a text at a
         * certain coordinate.
         * 
         */
        static void WriteAt(int x, int y, string text)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(text);
        }

		public static (int row, int col) RandomizeTarget()
		{
			int row = rnd.Next(1, 5);
			int col = rnd.Next(1, 5);
			return (row, col);
		}
	}
}
