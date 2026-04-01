using SortingAlgorithms;

namespace _14._10___Selection_och_Bubble_förbättringar
{
	internal class Program
	{
		static Random rnd = new Random();
		static void Main(string[] args)
		{
			int[] numbers = new int[] { 1, 2, 3, 10, 5, 6, 7, 8, 9, 4 };
			//GenerateRandomList(numbers);
			//Console.WriteLine("List generated.");
			for (int i = 0; i < numbers.Length; i++)
				Console.Write(numbers[i] + " ");
			Sorter.BubbleSortImproved(numbers);
			//Console.WriteLine("List sorted.");
			Console.WriteLine();
			for (int i = 0; i < numbers.Length; i++)
				Console.Write(numbers[i] + " ");
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
