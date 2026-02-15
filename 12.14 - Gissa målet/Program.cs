using App.IO;

namespace _12._14___Gissa_målet
{
	internal class Program
	{
		static string[,] gameBoard = new string[,] { {"   "," 1 "," 2 "," 3 "," 4 "},
													 {"1  ","   ","   ","   ","   "},
													 {"2  ","   ","   ","   ","   "},
													 {"3  ","   ","   ","   ","   "},
													 {"4  ","   ","   ","   ","   "},};
		static (int x, int y) target = (2, 3);

		static void Main(string[] args)
		{
			ConsoleHelper.ClearScreen("Gissa på vilken koordinat målet finns på.");
			DrawGameBoard();
			while (true)
			{
				int x = ConsoleHelper.ReadInt("Ange x-koordinat: ", 1, 4);
				int y = ConsoleHelper.ReadInt("Ange y-koordinat: ", 1, 4);
				gameBoard[x, y] = " * ";
				DrawGameBoard();
				if (x == target.x && y == target.y) 
				{ 
					Console.WriteLine("Rätt!");
				}
			}
		}

		static void DrawGameBoard()
		{
			for (int i = 0; i < gameBoard.GetLength(0); i++)
			{
				for (int j = 0; j < gameBoard.GetLength(1); j++)
				{
					Console.Write(gameBoard[i, j]);
				}
				Console.WriteLine();
			}
		}
	}
}
