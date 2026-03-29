namespace _14___Sorteringsalgoritmer
{
	internal class Program
	{
		static Random rnd = new Random();
		static void Main(string[] args)
		{
			int[] numbers = new int[20];
			GenerateRandomList(numbers);
			//Console.WriteLine("List generated.");
			for (int i = 0; i < numbers.Length; i++)
				Console.Write(numbers[i] + " ");
			SelectionSort(numbers);
			//Console.WriteLine("List sorted.");
			Console.WriteLine();
			for (int i = 0; i < numbers.Length; i++)
				Console.Write(numbers[i] + " ");
		}

		static void BubbleSort(int[] numbers)
		{
			int max = numbers.Length - 1;
			for (int i = 0; i < max; i++)
			{
				int nrLeft = max - i;
				for (int j = 0; j < nrLeft; j++)
				{
					if (numbers[j] > numbers[j + 1])
						Swap(ref numbers[j], ref numbers[j + 1]);
				}
			}
		}

		static void SelectionSort(int[] numbers)
		{
			for (int i = 0; i < numbers.Length - 1; i++)
			{
				int minIndex = i;

				for (int j = i + 1; j < numbers.Length; j++)
				{
					if ((numbers[j] < numbers[minIndex]))
						minIndex = j;
				}
				if (minIndex != i)
					Swap(ref numbers[i], ref numbers[minIndex]);
			}
		}

		static void Swap(ref int a, ref int b)
		{
			int temp = a;
			a = b;
			b = temp;
		}

		public static void GenerateRandomList(int[] list)
		{
			for (int i = 1; i < list.Length; i++)
			{
				list[i] = rnd.Next(10);
			}
		}
	}
}
