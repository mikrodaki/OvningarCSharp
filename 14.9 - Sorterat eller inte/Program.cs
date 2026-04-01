using App.IO;

namespace _14._9___Sorterat_eller_inte
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				ConsoleHelper.ClearScreen("ÄR LISTAN SORTERAD ELLER INTE");
				Console.WriteLine("Mata in en serie av heltal. Tryck ENTER när du inte vill mata in fler.\n");
				int counter = 1;
				List<int> userList = new List<int>();
				while (true)
				{
					int? number = ConsoleHelper.ReadIntCheckNullable($"Mata in tal {counter}: ", false);
					if (number == null)
						break;
					userList.Add(number.Value);
					counter++;
				}
				if (userList.Count == 0)
					Console.WriteLine("\nDu matade inte in några tal");
				else if (userList.Count == 1)
					Console.WriteLine("\nEn lista med bara 1 tal är alltid sorterad");
				else
				{
					Console.WriteLine();
					bool isSortedAscending = IsSortedAscending(userList);
					bool isSortedDescending = IsSortedDescending(userList);
					foreach (int number in userList)
					{
						Console.Write(number + " ");
					}
					if (isSortedAscending)
						Console.WriteLine("\nListan du angav är sorterad i stigande ordning");
					else if (isSortedDescending)
						Console.WriteLine("\nListan du angav är sorterad i fallande ordning");
					else
						Console.WriteLine("\nListan du angav är inte sorterad");
				}
				Console.Write("\nTryck ENTER för att köra igen eller 'q' för att avsluta");
				var keyPressed = Console.ReadKey();
				char key = char.ToLower(keyPressed.KeyChar);
				if (key == 'q')
					Environment.Exit(0);
			}
		}

		static bool IsSortedAscending(List<int> numbers)
		{
			for (int i = 0; i < numbers.Count - 1; i++)
			{
				if (numbers[i] > numbers[i + 1])
					return false;
			}
			return true;
		}

		static bool IsSortedDescending(List<int> numbers)
		{
			for (int i = 0; i < numbers.Count - 1; i++)
			{
				if (numbers[i] < numbers[i + 1])
					return false;
			}
			return true;
		}
	}
}
