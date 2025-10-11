namespace Övning_5._19
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int y = 5;
			int x = Console.WindowWidth / 2 - 30;

			Console.BackgroundColor = ConsoleColor.Gray;
			Console.Clear();

			for (int i = 0; i < 18; i++)
			{
				Console.SetCursorPosition(x, y);
				for (int j = 0; j < 60; j++)
				{
					if (j < 20)
						Console.BackgroundColor = ConsoleColor.Green;
					else if (j < 40)
						Console.BackgroundColor = ConsoleColor.White;
					else 
						Console.BackgroundColor = ConsoleColor.Red;
					Console.Write(" ");
				}
				Console.WriteLine();
				y++;
			}
			Console.ReadKey();
		}
	}
}

