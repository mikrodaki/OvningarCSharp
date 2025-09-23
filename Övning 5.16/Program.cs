using System.Data;

namespace Övning_5._16
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Ange ett heltal: ");
			string number = Console.ReadLine();
			Console.WriteLine();
			Console.WriteLine();

			// Loopa genom raderna 1 till 3
			for (int rowNumber = 1; rowNumber <= 3; rowNumber++)
			{
				// Loopa genom alla siffror i raden
				for (int j = 0; j < number.Length; j++)
				{
					// Om det är första siffran börja med ett indrag
					if (j == 0)
						Console.Write("				");
					switch (number[j]) 
					{ 
						case '0':
							if (rowNumber == 1)
								Console.Write("╔╗");
							else if (rowNumber == 2)
								Console.Write("║║");
							else if (rowNumber == 3)
								Console.Write("╚╝");
							break;

						case '1':
							if (rowNumber == 1)
								Console.Write("╗");
							else if (rowNumber == 2)
								Console.Write("║");
							else if (rowNumber == 3)
								Console.Write("╩");
							break;

						case '2':
							if (rowNumber == 1)
								Console.Write("╔╗");
							else if (rowNumber == 2)
								Console.Write("╔╝");
							else if (rowNumber == 3)
								Console.Write("╚╝");
							break;

						case '3':
							if (rowNumber == 1)
								Console.Write("╔╗");
							else if (rowNumber == 2)
								Console.Write(" ╣");
							else if (rowNumber == 3)
								Console.Write("╚╝");
							break;
					}
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}
	}
}
