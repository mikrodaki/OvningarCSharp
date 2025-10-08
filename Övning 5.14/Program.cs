namespace Övning_5._14
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int x = 0;
			int y = 5;
			int y2 = 6;
			int width = Console.WindowWidth - 1;
			int i = width;
			// int height = Console.WindowHeight;

			Console.CursorVisible = false;
			Console.SetCursorPosition(x,y);
			Console.Clear();

			while (true) 
			{ 
				while(x < width / 2 && i > width / 2) 
				{
					Console.SetCursorPosition(x, y);
					Console.Write("o");
					Console.SetCursorPosition(i, y2);
					Console.Write("o");
					Thread.Sleep(25);
					Console.SetCursorPosition(x, y);
					Console.Write(" ");
					Console.SetCursorPosition(i, y2);
					Console.Write(" ");
					x++;
					i--;
				}
				while (x > 0  && i < width)
				{
					Console.SetCursorPosition(x, y);
					Console.Write("o");
					Console.SetCursorPosition(i, y2);
					Console.Write("o");
					Thread.Sleep(25);
					Console.SetCursorPosition(x, y);
					Console.Write(" ");
					Console.SetCursorPosition(i, y2);
					Console.Write(" ");
					x--;
					i++;
				}
			}

		}
	}
}
