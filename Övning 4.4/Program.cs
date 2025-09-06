namespace Övning_4._4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string city1 = "London";
			string city2 = "Liverpool";
			int tempCity1, tempCity2 = 0;

			while (true)
			{
				tempCity1 = checkSubmittedNo($"Ange temperaturen för {city1}: ");
				tempCity2 = checkSubmittedNo($"Ange temperaturen för {city2}: ");

				if (tempCity1 > tempCity2)
				{
					Console.WriteLine($"Det är kallast i {city2}");
				}
				else if (tempCity1 < tempCity2) 
				{ 
					Console.WriteLine($"Det är kallast i {city1}");
				}
				else
				{
					Console.WriteLine($"Det är lika kallt i både {city1} och {city2}");
				}
				Console.Write("Vill du fortsätta? j/n ?: ");
				string goOn = Console.ReadLine();
				if (goOn == "n" || goOn == "N")
					break;
			}

			int checkSubmittedNo(string message)
			{
				int result = 0;
				Console.Write(message);
				while (!int.TryParse(Console.ReadLine(), out result))
				{
					Console.WriteLine("Vänligen mata in ett heltal!");
					Console.Write(message);
				}
				return result;
			}
		}
	}
}
