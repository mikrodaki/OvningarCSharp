namespace Övning_5._16b
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int i = 1;
			int j = 1;
			int k = 1;
			int numberOfRows = 10;
			int numberOfA = 1;
			int numberOfB = 9;


			while (i <= numberOfRows)
			{
				while (j <= numberOfA) 
				{
					Console.Write("a");
					j++;
				}

				while (k <= numberOfB)
				{
					Console.Write("b");
					k++;
				}
				numberOfA++;
				numberOfB--;
				i++;
				j--;
				k--;
				Console.WriteLine();
			}
		}
	}
}
