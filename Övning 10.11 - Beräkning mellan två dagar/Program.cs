namespace Övning_10._11___Beräkning_mellan_två_dagar
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("DAGAR MELLAN TVÅ DATUM\n---------------------------------");
			while (true)
			{
				string firstDate = GetValidDateInput("Ange datum 1 på formatet yyyymmdd: ");
				string secondDate = GetValidDateInput("Ange datum 2 på formatet yyyymmdd: ");
				int yearFirstDate = int.Parse(firstDate.Substring(0, 4));
				int monthFirstDate = int.Parse(firstDate.Substring(4, 2));
				int dayFirstDate = int.Parse(firstDate.Substring(6, 2));
				int yearSecondDate = int.Parse(secondDate.Substring(0, 4));
				int monthSecondDate = int.Parse(secondDate.Substring(4, 2));
				int daySecondDate = int.Parse(secondDate.Substring(6, 2));
				Console.WriteLine($"Antalet dagar mellan {firstDate} och {secondDate} är " +
					$"{Math.Abs(DaysSinceBeginningOfTime(yearFirstDate, monthFirstDate, dayFirstDate)
					- DaysSinceBeginningOfTime(yearSecondDate, monthSecondDate, daySecondDate))}\n");
				Console.Write("Tryck (q)uit för att avsluta. ");
				ConsoleKeyInfo userInput = Console.ReadKey();
				if (userInput.KeyChar == 'q')
					break;
			}
			Console.WriteLine();
		}
		static string GetValidDateInput(string message)
		{
			string input = string.Empty;
			bool invalidInput;
			do
			{
				invalidInput = false;
				Console.Write(message);
				input = Console.ReadLine();
				if (input.Length == 8)
				{
					for (int i = 0; i < input.Length; i++)
					{
						if (input[i] < '0' || input[i] > '9')
						{
							invalidInput = true;
							break;
						}
					}
					int year = int.Parse(input.Substring(0, 4));
					int month = int.Parse(input.Substring(4, 2));
					int day = int.Parse(input.Substring(6, 2));
					if (year < 1 || month < 1 || month > 12 || day < 1)
						invalidInput = true;
					else if (GetDaysInMonth(year, month) < day)
						invalidInput = true;
				}
				else
				{
					invalidInput = true;
				}
				if (invalidInput)
					Console.WriteLine("Ogiltig inmatning. Försök igen.");
			} while (invalidInput);
			return input;
		}

		static int GetDaysInMonth(int year, int month)
		{
			int[] noOfDaysInMonth = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
			if (IsLeapYear(year) && month == 2)
				return 29;

			return noOfDaysInMonth[month - 1];
		}

		static bool IsLeapYear(int year)
		{
			if (year % 400 == 0)
				return true;
			if (year % 100 == 0)
				return false;
			if (year % 4 == 0)
				return true;
			return false;
		}

		static int DaysSinceBeginningOfTime(int year, int month, int day)
		{
			int days = 0;

			for (int i = 1; i < year; i++)
			{
				if (IsLeapYear(i))
					days += 366;
				else
					days += 365;
			}

			for (int i = 1; i < month; i++)
			{
				days += GetDaysInMonth(year, i);
			}

			return days + (day - 1);
		}
	}

}
