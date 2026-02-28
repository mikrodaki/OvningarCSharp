namespace _12._16___Tärning
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();
			List<int> dices = new List<int>();
			var numberOfFours = 0;
			var numberOfThrows = 50;

			for (int i = 0; i < numberOfThrows; i++)
			{
				int diceThrow = rnd.Next(1, 7);
				dices.Add(diceThrow);
			}

			foreach (var diceThrow in dices)
			{
				if (diceThrow == 4)
					numberOfFours++;
			}

			double percentageOfFours = (double)numberOfFours / numberOfThrows * 100;

			Console.WriteLine($"Procentandelen fyror: {percentageOfFours}%");
		}
	}
}
