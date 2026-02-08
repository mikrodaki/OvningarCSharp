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
		public static int ReadInt(string prompt, bool mustBeGreaterThanZero)
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

				if (mustBeGreaterThanZero && value < 1)
				{
					Console.WriteLine("Fel: värdet måste vara större än 0.");
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

		public static string ReadString(string text) 
		{
			while (true) 
			{
				Console.Write(text);
				string? input = Console.ReadLine();
				if (string.IsNullOrEmpty(input) || !input.All(char.IsLetter))
					Console.WriteLine("Du måste ange ett namn!");
				else
					return input;
			} 
		}
	}
}
