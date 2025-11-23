namespace Övning_extra_primtal
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Primtal\n----------");
			while (true)
			{
				Console.Write("Ange ett heltal: ");
				bool numberOk = int.TryParse(Console.ReadLine(), out int number);
				while (!numberOk)
				{
					Console.WriteLine("Felaktig inmatning!");
					Console.Write("Ange ett heltal: ");
					numberOk = int.TryParse(Console.ReadLine(), out number);
				}

				if (number == 2)
					Console.WriteLine($"{number} är ett primtal");
				else if (number % 2 == 0)
					Console.WriteLine($"{number} är ett jämnt tal och således inte ett primtal");
				else
				{
					bool isPrime = true;
					double squareRoot = Math.Sqrt(number);
					for (int j = 2; j <= squareRoot; j++)
					{
						if (number % j == 0) 
						{ 
							isPrime = false;
							break;
						}
					}
					if (isPrime)
						Console.WriteLine($"{number} är ett primtal");
					else
						Console.WriteLine($"{number} är inte ett primtal");
				}
			}
		}
	}
}
