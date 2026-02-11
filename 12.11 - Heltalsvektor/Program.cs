namespace _12._11___Heltalsvektor
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[,] twoDArray = new int[2, 3] {  { 0, 1, 2, },
												{ 4, 5, 6 } };

			for (int i = 0; i < twoDArray.GetLength(0); i++)
			{
				for (int j = 0; j < twoDArray.GetLength(1); j++)
				{
					Console.Write(twoDArray[i, j] + " ");
				}
				Console.WriteLine();
			}
		}
	}
}
