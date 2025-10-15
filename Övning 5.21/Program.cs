namespace Övning_5._21
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int x = Console.WindowWidth / 2;
			int y = 5;
			int randomNumber;
			int randomColor;
			Random random = new Random();

			Console.BackgroundColor = ConsoleColor.Green;

			for (int i = 1; i < 40; i = i + 2)
			{
				Console.SetCursorPosition(x, y);
				for (int j = 0; j < i; j++)
				{
					randomNumber = random.Next(0,9);
					randomColor = random.Next(1,4);
					if (randomNumber == 0) 
					{ 
						switch (randomColor) 
						{ 
							case 1:
								Console.ForegroundColor = ConsoleColor.Red;
								break;
							case 2:
								Console.ForegroundColor = ConsoleColor.Yellow;
								break;
							case 3:
								Console.ForegroundColor = ConsoleColor.DarkBlue;
								break;
						}
						Console.Write("0");
					}
					else
						Console.Write(" ");
				}
				x--;
				y++;
			}
			Console.ReadKey();
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.White
				;
		}
	}
}
