namespace SortingAlgorithms
{
	public static class Sorter
	{
		public static void BubbleSort(int[] numbers)
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

        public static void BubbleSortDecending(int[] numbers)
        {
            int max = numbers.Length - 1;
            for (int i = 0; i < max; i++)
            {
                int nrLeft = max - i;
                for (int j = 0; j < nrLeft; j++)
                {
                    if (numbers[j] < numbers[j + 1])
                        Swap(ref numbers[j], ref numbers[j + 1]);
                }
            }
        }

        public static void SelectionSort(int[] numbers)
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

		public static void InsertionSort(int[] numbers)
		{
			for (int i = 1; i < numbers.Length; i++)
			{
				int current = numbers[i];
				int j = i - 1;

				while (j >= 0 && numbers[j] > current)
				{
					numbers[j + 1] = numbers[j];
					j--;
				}
				numbers[j + 1] = current;
			}
		}

		public static void QuickSort(int[] numbers) 
		{ 
			
		}

		static void Swap(ref int a, ref int b)
		{
			int temp = a;
			a = b;
			b = temp;
		}
	}
}
