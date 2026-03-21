namespace Binärsökning
{
	internal class Program
	{
		static Random rnd = new Random();
		static int vectorLength = 20;
		static void Main(string[] args)
		{
			Console.CursorVisible = false;

			Console.Clear();
			var numbers = PopulateVector(new List<int>());
			var numbersUnsorted = new List<int>(numbers);
			var key = rnd.Next(vectorLength);
			var result = BinarySearch(numbers, key);
			Console.Write("BINÄR SÖKNING \n------------------\nLISTAN: ");
			bool keyFound = false;
			int lineBreak = 0;
			foreach (int number in numbersUnsorted)
			{
				if (key == number && !keyFound)
				{
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write(number + " ");
					keyFound = true;
					Console.ForegroundColor = ConsoleColor.White;
				}
				else
					Console.Write(number + " ");
				lineBreak++;
			}
			Console.WriteLine("\n");
			if (result.index != -1)
				Console.WriteLine($"Talet {key} finns på index {numbersUnsorted.IndexOf(key)} i listan. " +
					$"Det tog {result.steps} iterationer för att hitta talet.");
			else
				Console.WriteLine($"Talet {key} finns inte med i listan. " +
					$"Det tog {result.steps} iterationer för att komma fram till det.");
			Console.ReadKey();
		}


		static (int index, int steps) BinarySearch(List<int> numbers, int key)
		{
			int steps = 0;
			if (numbers.Count == 0)
				return (-1, steps);
			numbers.Sort();
			int first = 0;
			int last = numbers.Count - 1;
			while (first <= last)
			{
				steps++;
				int mid = (first + last) / 2;
				if (key > numbers[mid])
					first = mid + 1;
				else if (key < numbers[mid])
					last = mid - 1;
				else
					return (mid, steps);
			}
			return (-1, steps);
		}

		static List<int> PopulateVector(List<int> numbers)
		{
			for (int i = 0; i < vectorLength; i++)
			{
				numbers.Add(rnd.Next(vectorLength));
			}
			return numbers;
		}
	}
}
