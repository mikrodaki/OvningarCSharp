using SortingAlgorithms;

namespace _14___Sorteringsalgoritmer
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5, 8, 3, 5, 2, 1 };
            //GenerateRandomList(numbers);
            //Console.WriteLine("List generated.");
            for (int i = 0; i < numbers.Length; i++)
                Console.Write(numbers[i] + " ");
            Sorter.BubbleSort(numbers);
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
