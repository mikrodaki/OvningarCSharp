namespace Övning_4._16
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hej och välkommen till programmet som " +
				"räknar ut linjens ekvation på formeln y = kx + m");
			Console.WriteLine("-------");
			while (true) 
			{  
				Console.Write("Ange x för första koordinaten: ");
				int x1 = Convert.ToInt32(Console.ReadLine());
				Console.Write("Ange y för första koordinaten: ");
				int y1 = Convert.ToInt32(Console.ReadLine());
				Console.Write("Ange x för andra koordinaten: ");
				int x2 = Convert.ToInt32(Console.ReadLine());
				Console.Write("Ange y för andra koordinaten: ");
				int y2 = Convert.ToInt32(Console.ReadLine());

				if (x1 == x2 &&  y1 == y2)
					Console.WriteLine("Linjens funtion går ej att beräkna");
				else if (x1 == x2)
					Console.WriteLine("Funktion saknas, linjen är vertial");
				else 
				{ 
					// Räkna ut k
					double k = (double)(y2 - y1) / (x2 - x1);

					// Räkna u m
					double m = y1 - k * x1;

					if (k == 0)
						Console.WriteLine($"Svaret är y = {m}");
					else if (m == 0 && k != 0)
						Console.WriteLine($"Svaret är y = {k}x");
					else
						Console.WriteLine($"Svaret är y = {k}x + {m}");
				}
			}

		}
	}
}
