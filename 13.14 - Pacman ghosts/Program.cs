using System;

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
			ghosts.Add(new Ghost(x += spaceBetween, y, ConsoleColor.Green, 3));
			ghosts.Add(new Ghost(x += spaceBetween, y, ConsoleColor.Cyan, 1));
			ghosts.Add(new Ghost(x += spaceBetween, y, ConsoleColor.DarkYellow, 2));
			ghosts.Add(new Ghost(x += spaceBetween, y, ConsoleColor.Red, 0));
			ghosts.Add(new Ghost(x += spaceBetween, y, ConsoleColor.Magenta, 2));


			foreach (Ghost g in ghosts)
			{
				g.Draw();
			}

			while (true)
			{
				foreach (Ghost g in ghosts)
				{
					g.ChangeEyePosition();
					Thread.Sleep(1000);
					g.Draw();
				}
			}

			Console.ReadKey();


			/*


			int eyePos = 0;
			

			*/
		}
	}
}