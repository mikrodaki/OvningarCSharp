namespace Övning_5._16b
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int row = 1;
			int numberOfRows = 9;
			int numberOfA = 1;
			int numberOfB = 9;
			int i = 1;

			while (row <= numberOfRows)
			{
				while (i <= numberOfA)
				{
					Console.Write("a");
					i++;
				}

				i = 1;

				while (i <= numberOfB)
				{
					Console.Write("b");
					i++;
				}

				Console.WriteLine();
				row++;
				numberOfA++;
				numberOfB--;
				i = 1;
			}
		}
	}
}
