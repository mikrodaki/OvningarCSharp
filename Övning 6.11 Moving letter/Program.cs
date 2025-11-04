namespace Övning_6._11_Moving_letter
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int width = Console.WindowWidth;
			int height = Console.WindowHeight;
			int centerX = width / 2;
			int centerY = height / 2;
			ConsoleKeyInfo userInput;

			Console.WriteLine("Ange riktning (u)pp, (n)er, (v)änster, (h)öger, (a)vsluta: ");
			Console.SetCursorPosition(centerX, centerY);
			Console.Write("o");
			//Console.CursorVisible = false;

			do
			{
				// Hämta nuvarande position
				int x = Console.CursorLeft;
				int y = Console.CursorTop;
				int numberOfSteps = 0;

				userInput = Console.ReadKey(intercept: true);
				if (userInput.KeyChar == 'u') 
				{ 
					while (y > 1 && numberOfSteps < 8) 
					{
						Console.SetCursorPosition(x - 1, y);
						Console.Write(" ");
						y--;
						Console.SetCursorPosition(x - 1, y);
						Console.Write("o");
						Thread.Sleep(20);
						numberOfSteps++;
					}
				}
				else if (userInput.KeyChar == 'n') 
				{
					while (y < height - 1 && numberOfSteps < 8)
					{
						Console.SetCursorPosition(x - 1, y);
						Console.Write(" ");
						y++;
						Console.SetCursorPosition(x - 1, y);
						Console.Write("o");
						Thread.Sleep(20);
						numberOfSteps++;
					}
				}
				else if (userInput.KeyChar == 'v')
				{
					while (x > 1 && numberOfSteps < 8)
					{
						Console.SetCursorPosition(x - 1, y);
						Console.Write(" ");
						x--;
					    Console.SetCursorPosition(x - 1, y);
						Console.Write("o");
						Thread.Sleep(20);
						numberOfSteps++;
					}
				}
				else if (userInput.KeyChar == 'h') 
				{
					while (x < width - 1 && numberOfSteps < 8)
					{
						Console.SetCursorPosition(x - 1, y);
						Console.Write(" o");
						Thread.Sleep(50);
						numberOfSteps++;
						x++;
					}
				}

			} while (userInput.KeyChar != 'a');
		}
	}
}
