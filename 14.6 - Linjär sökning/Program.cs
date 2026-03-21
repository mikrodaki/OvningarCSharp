namespace _14._6___Linjär_sökning
{
	internal class Program
	{
		static Random rnd = new Random();
		static int vectorLength = 20;
		static void Main(string[] args)
		{
			Console.CursorVisible = false;
			for (int j = 0; j < 5; j++)
			{
				Console.Clear();
				var numbers = PopulateVector(new int[vectorLength]);
				var key = rnd.Next(vectorLength);
				var result = LinearSearch(numbers, key);
				Console.Write("LINJÄR SÖKNING \n------------------\nLISTAN: ");
				bool keyFound = false;
				for (int i = 0; i < numbers.Length; i++)
				{
					if (key == numbers[i] && !keyFound)
					{
						Console.ForegroundColor = ConsoleColor.Green;
						Console.Write(numbers[i] + " ");
						keyFound = true;
						Console.ForegroundColor = ConsoleColor.White;
					}
					else
						Console.Write(numbers[i] + " ");
				}
				Console.WriteLine("\n");
				if (result.index != -1)
					Console.WriteLine($"Talet {key} finns på index {result.index} i listan. " +
						$"Det tog {result.steps} iterationer för att hitta talet.");
				else
					Console.WriteLine($"Talet {key} finns inte med i listan. " +
						$"Det tog {result.steps} iterationer för att komma fram till det.");
				Console.ReadKey();
			}
		}

		static (int index, int steps) LinearSearch(int[] numbers, int key)
		{
			int steps = 0;
			if (numbers.Length == 0)
				return (-1, steps);
			for (int i = 0; i < numbers.Length; i++)
			{
				steps++;
				if (numbers[i] == key)
					return (i, steps);
			}
			return (-1, steps);
		}

		static int[] PopulateVector(int[] numbers)
		{
			for (int i = 0; i < numbers.Length; i++)
			{
				numbers[i] = rnd.Next(vectorLength);
			}
			return numbers;
		}
	}
}
