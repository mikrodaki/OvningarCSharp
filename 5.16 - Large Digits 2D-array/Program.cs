using System;

namespace Digits
{
	class Program
	{
		static void Main(string[] args)
		{
			string[,] digits =
			{
				{"╔╗", "║║", "╚╝"},// 0

			    {" ╗", " ║", " ╩"}, // 1

			    {"╔╗", "╔╝", "╚╝"}, // 2

			    {"╔╗", " ╣", "╚╝"}, // 3

			    {"╗╗", "╚╣", " ╩"}, // 4

			    {"╔╗", "╚╗", "╚╝"}, // 5

			    {"╔╗", "╠╗", "╚╝"}, // 6

			    {"╔╗", " ║", " ╩"}, // 7

			    {"╔╗", "╠╣", "╚╝"}, // 8

			    {"╔╗", "╚╣", " ╩"}  // 9
			};

			Console.Write("Ange ett heltal: ");
			string nr = Console.ReadLine();

			for (int i = 0; i < nr.Length; i++)
				for (int j = 0; j < 3; j++)
				{
					int digitPos = Convert.ToInt32(nr[i].ToString());
					Console.SetCursorPosition(10 + i * 2, 10 + j);
					Console.WriteLine(digits[digitPos, j]);
				}

			Console.ReadKey();
		}
	}
}
