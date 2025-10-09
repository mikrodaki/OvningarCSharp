namespace Övning_5._18
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int y = 5;
			int x = 0;
			int i,j,k;

			Console.BackgroundColor = ConsoleColor.Gray;
			Console.Clear();

			for (i = 1; i <= 3; i++)
			{
				for (j = 1; j <= 6; j++)
				{
					x = Console.WindowWidth / 2 - 30;
					for (k = 1; k <= 60; k++)
					{
						if (i == 1)
							Console.BackgroundColor = ConsoleColor.Black;
						else if (i == 2 )
							Console.BackgroundColor = ConsoleColor.Red;
						else if (i == 3)
							Console.BackgroundColor = ConsoleColor.Yellow;

						Console.SetCursorPosition(x, y);
						Console.Write(" ");
						x++;
					}
					Console.WriteLine();
					y++;
				}
			}
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.BackgroundColor = ConsoleColor.Gray;
			Console.CursorVisible = false;
		}
	}
}
