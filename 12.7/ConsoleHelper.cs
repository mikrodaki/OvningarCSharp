using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.IO
{
	internal class ConsoleHelper
	{
		public static int ReadInt(string prompt, bool mustBeNonZero)
		{
			while (true)
			{
				Console.Write(prompt);
				string? input = Console.ReadLine();

				if (!int.TryParse(input, out int value))
				{
					Console.WriteLine("Fel: ange ett heltal.");
					continue;
				}

				if (mustBeNonZero && value == 0)
				{
					Console.WriteLine("Fel: värdet får inte vara 0.");
					continue;
				}

				return value;
			}
		}

		public static int ReadInt(string text, int min, int max) 
		{
			while (true)
			{
				Console.Write(text);
				string? input = Console.ReadLine();

				if (!int.TryParse(input, out int value))
				{
					Console.WriteLine("Fel: ange ett heltal.");
					continue;
				}

				if (value < min || value > max)
				{
					Console.WriteLine($"Fel: värdet måste vara inom intervallet {min} och {max}");
					continue;
				}

				return value;
			}
		}
	}
}
