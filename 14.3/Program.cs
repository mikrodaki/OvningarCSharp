using System.Diagnostics;
using System.Globalization;
using System.Reflection.PortableExecutable;

namespace _14._34
{
    internal class Program
    {
        static int[] numbers = new int[500000000];
        static Random rnd = new Random();
        static int key = 470000000;
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Tryck ENTER för att starta");
            Console.Clear();
            Console.WriteLine("Skapar listan...");
            var sw = Stopwatch.StartNew();
            GenerateSortedRandomList(numbers);
            sw.Stop();
            Console.WriteLine($"Det tog {sw.ElapsedMilliseconds} milisekunder att skapa listan. ");
            sw.Restart();
            int result = LinearSearch(numbers, key);
            sw.Stop();
            Console.WriteLine($"Det tog {sw.ElapsedMilliseconds} milisekunder att göra en linjärsökning. ");
            sw.Restart();
            BinarySearch(numbers, key);
            sw.Stop();
            var ticks = sw.ElapsedTicks;
            var microSeconds = (long)(ticks * (1000000.0 / Stopwatch.Frequency));
            //Console.WriteLine($"Det tog {sw.ElapsedMilliseconds} milisekunder att göra en binärsökning. ");
            Console.WriteLine($"Det tog {microSeconds} mikrosekunder att göra en binärsökning. ");

            Console.WriteLine(result != -1 ? "Värdet fanns inte i listan" : "Värdet fanns i listan");
        }

        public static void GenerateSortedRandomList(int[] list)
        {
            int randomNumber = rnd.Next(1, 6);
            list[0] = randomNumber;

            for (int i = 1; i < list.Length; i++)
            {
                randomNumber = rnd.Next(1, 6);
                list[i] = randomNumber + list[i - 1];
            }
        }

        static int BinarySearch(int[] numbers, int key)
        {
            int first = 0;
            int last = numbers.Length - 1;

            while (first <= last)
            {
                int mid = (first + last) / 2;
                if (key == numbers[mid])
                    return mid;
                else if (key > numbers[mid])
                    first = mid + 1;
                else if (key < numbers[mid])
                    last = mid - 1;
            }
            return -1;
        }

        static int LinearSearch(int[] numbers, int key)
        {

            if (numbers.Length == 0)
                return -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == key)
                    return i;
            }
            return -1;
        }
    }
}
