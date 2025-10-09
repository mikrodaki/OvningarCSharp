using System.ComponentModel.Design;

namespace Övning_5._15a
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int x = 0;
			int y = 0;
			int triangleWidht = 0;
			int triangleHeight = 0;

			while (true) 
			{
				Console.Write("Ange rektangels bredd: ");
				int.TryParse(Console.ReadLine(), out triangleWidht);
				Console.Write("Ange rektangels höjd: ");
				int.TryParse(Console.ReadLine(), out triangleHeight);
				if(triangleWidht > 0 && triangleWidht < 120 && triangleHeight > 0 && triangleHeight < 30) 
					break;
				else
					Console.WriteLine("Ogiltiga värden!");
			}

			Console.Clear();

			Console.BackgroundColor = ConsoleColor.Green;

			for (int i = 0; i <= triangleWidht; i++)
			{
				Console.SetCursorPosition(x, y);
				Console.Write(" ");
				Thread.Sleep(10);
				x++;
			}

			for (int i = 0; i < triangleHeight; i++)
			{
				Console.SetCursorPosition(x, y);
				Console.Write(" ");
				Thread.Sleep(10);
				y++;
			}

			for (int i = 0; i <= triangleWidht; i++)
			{
				Console.SetCursorPosition(x, y);
				Console.Write(" ");
				Thread.Sleep(10);
				x--;
			}

			for (int i = 0; i < triangleHeight; i++)
			{
				Console.SetCursorPosition(x, y);
				Console.Write(" ");
				Thread.Sleep(10);
				y--;
			}

			Console.SetCursorPosition(0, triangleHeight + 1);

			Console.BackgroundColor= ConsoleColor.Black;

		}
	}
}
