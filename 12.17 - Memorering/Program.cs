using App.IO;

namespace _12._17___Memorering
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();
			List<int> randomNumbers = new List<int>();
			int numberOfNumbers = 10;
			bool playerLose = false;

			for (int i = 0; i < numberOfNumbers; i++)
			{
				randomNumbers.Add(rnd.Next(0, 11)); // 0..10
			}

			ConsoleHelper.ClearScreen("Memorera följande tal. Tryck på ENTER när du är redo.");

			foreach (int n in randomNumbers)
				Console.Write(n + " ");

			while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }

			ConsoleHelper.ClearScreen("Ange talen du memorerade");

			for (int i = 0; i < numberOfNumbers; i++)
			{
				int input = ConsoleHelper.ReadInt($"Vilket tal var nr {i + 1}? ");
				if (input == randomNumbers[i])
					Console.WriteLine("Rätt!");
				else
				{
					playerLose = true;
					break;
				}
			}

			Console.WriteLine(playerLose ? "Fel! Du förlorade." : "Du vann!");
		}
	}
}
