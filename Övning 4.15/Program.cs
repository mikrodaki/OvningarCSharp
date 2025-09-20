using System;

namespace Övning_4._15
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int a, b, c;
			double p, q, d, x1, x2;

			Console.WriteLine("Välkommen till programmet som löser ax\u00B2 + bx + c = 0");
			Console.WriteLine();

			while (true)
			{
				Console.Write("Mata in värdet för a: ");
				a = Convert.ToInt32(Console.ReadLine());
				Console.Write("Mata in värdet för b: ");
				b = Convert.ToInt32(Console.ReadLine());
				Console.Write("Mata in värdet för c: ");
				c = Convert.ToInt32(Console.ReadLine());

				// Sätt ekvationen i rätt form
				p = (double)b / a;
				q = (double)c / a;
				
				// Räkna ut diskriminanten
				d = Math.Pow(p / 2, 2) - q;

				if (a == 0) 
				{
					Console.WriteLine("Detta är ingen andragradsekvation");
				}
				else if (d < 0)
				{
					Console.WriteLine($"Diskriminanten är {d:F2}, alltså under 0, reell lösning saknas, avbryter");
				}
				else 
				{ 
					x1 = -p / 2 + Math.Sqrt(d);
					x2 = - p / 2 - Math.Sqrt(d);
					string termA = a == 1 ? "x²" : a == -1 ? "-x²" : $"{a}x²";
					string termB = b == 0 ? "" : (b == 1 ? "+ x" : b == -1 ? "- x" : (b > 0 ? $"+ {b}x" : $"- {Math.Abs(b)}x"));
					string termC = c == 0 ? "" : (c > 0 ? $"+ {c}" : $"- {Math.Abs(c)}");
					Console.WriteLine($"Ekvationen {termA} {termB} {termC} = 0 ger svaren: " );
					Console.WriteLine($"X1 = {x1:F2}, X2 = {x2:F2}");
				}

			}

		}
	}
}
