using System;
using System.Linq;

namespace Ghost
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ghost> ghosts = new List<Ghost>();
            int x = 35;
            int y = 10;
            int spaceBetween = 10;

            Console.Clear();
            Console.CursorVisible = false;

            ghosts.Add(new Ghost(x, y, ConsoleColor.Red, 0));
            ghosts.Add(new Ghost(x += spaceBetween, y, ConsoleColor.Green, 1));
            ghosts.Add(new Ghost(x += spaceBetween, y, ConsoleColor.Cyan, 2));
            ghosts.Add(new Ghost(x += spaceBetween, y, ConsoleColor.DarkYellow, 3));


            foreach (Ghost g in ghosts)
            {
                g.Draw();
            }

            while (true)
            {
                foreach (Ghost g in ghosts)
                {
                    g.ChangeEyePosition();
                    Thread.Sleep(500);
                    g.Draw();
                }
                for (int i = ghosts.Count - 2; i > 0; i--)
                {
                    ghosts[i].ChangeEyePosition();
                    Thread.Sleep(500);
                    ghosts[i].Draw();
                }
            }

            Console.ReadKey();
        }
    }
}