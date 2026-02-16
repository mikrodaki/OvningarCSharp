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
		static Random rnd = new Random();

		static void Main(string[] args)
		{
			(int row, int col) target = RandomizeTarget();
			bool gameOver = false;
			while (!gameOver)
			{
				ConsoleHelper.ClearScreen("SÄNKA SKEPP!");
				DrawGameBoard();
				int row = ConsoleHelper.ReadInt("\nAnge rad: ", 1, 4);
				int col = ConsoleHelper.ReadInt("Ange kolumn: ", 1, 4);
				if (row == target.row && col == target.col)
				{
					gameBoard[row, col] = " X ";
					gameOver = true;
				}
				else
				{
					gameBoard[row, col] = " * ";
				}
			}
			ConsoleHelper.ClearScreen("Gissa på vilken koordinat målet finns på.");
			DrawGameBoard();
			Console.WriteLine("\nBOOM!\n");
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

		static (int row, int col) RandomizeTarget()
		{
			int row = rnd.Next(1, 5);
			int col = rnd.Next(1, 5);
			return (row, col);
		}
	}
}
