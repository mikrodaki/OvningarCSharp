using System.Security.Cryptography;

namespace Binärsökning_2
{
	internal class Program
	{
		static Random rnd = new Random();
		static int vectorLength = 10;
		static int range = 15;
		static void Main(string[] args)
		{
			Console.CursorVisible = false;
			while (true)
			{
				Console.Clear();
				var numbers = PopulateVector(new List<int>());
				var key = rnd.Next(range);
				numbers.Sort();
				int x = 0;
				int y = 0;
				for (int i = 0; i < numbers.Count; i++)
				{
					y = 0;
					Console.SetCursorPosition(x, y);
					Console.Write($"{i}");
					y++;
					Console.SetCursorPosition(x, y);
					Console.Write($"{numbers[i]}");
					x += 5;
				}
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine($"Siffran vi söker: {key}");
				var result = BinarySearchFirstOccurence(numbers, key);
				if (result != -1)
					Console.WriteLine($"Siffran {key} är på index {result}");
				else
					Console.WriteLine($"Siffran {key} finns inte i listan");
				Console.ReadKey();
			}
		}

		static int BinarySearch(List<int> numbers, int key)
		{
			if (numbers.Count == 0)
				return (-1);
			int first = 0;
			int mid = 0;
			int last = numbers.Count - 1;
			while (first <= last)
			{
				mid = (first + last) / 2;
				Console.WriteLine($"First = {first} Last = {last} Mid = {mid}");
				Console.ReadKey();
				if (key > numbers[mid])
					first = mid + 1;
				else if (key < numbers[mid])
					last = mid - 1;
				else
					return mid;
			}
			Console.WriteLine($"First = {first} Last = {last} Mid = {mid}");
			return (-1);
		}

		static int BinarySearchFirstOccurence(List<int> numbers, int key)
		{
			if (numbers.Count == 0)
				return (-1);
			int first = 0;
			int mid = 0;
			int last = numbers.Count - 1;
			int result = -1;

			while (first <= last)
			{
				mid = (first + last) / 2;
				Console.WriteLine($"First = {first} Last = {last} Mid = {mid}");
				Console.ReadKey();
				if (key > numbers[mid])
					first = mid + 1;
				else if (key < numbers[mid])
					last = mid - 1;
				else
				{
					result = mid;
					last = mid - 1;
				}
			}
			return result;
		}

		static List<int> PopulateVector(List<int> numbers)
		{
			for (int i = 0; i < vectorLength; i++)
			{
				numbers.Add(rnd.Next(range));
			}
			return numbers;
		}
	}
}
