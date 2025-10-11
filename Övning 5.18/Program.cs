namespace Övning_5._18
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int y = 5;
			int x = 0;

			Console.BackgroundColor = ConsoleColor.Gray;
			Console.Clear();

			// Yttre loopen ändrar färg
			for (int i = 1; i <= 3; i++)
			{
				switch (i) 
				{
					case 1:
						Console.BackgroundColor = ConsoleColor.Black;
						break;
					case 2:
						Console.BackgroundColor = ConsoleColor.Red;
						break;
					case 3:
						Console.BackgroundColor = ConsoleColor.Yellow;
						break;
				}

				// Mellersta loopen byter rad
				for (int j = 1; j <= 6; j++)
				{
					x = Console.WindowWidth / 2 - 30;

					// Innersta loopen ritar raderna
					Console.SetCursorPosition(x, y);
					for (int k = 1; k <= 60; k++)
					{
						Console.Write(" ");
						x++;
					}
					Console.WriteLine();
					y++;
				}
			}
			Console.ReadKey();
		}
	}
}
