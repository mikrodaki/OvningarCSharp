using System.ComponentModel;

namespace _11._23a
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("Beräkning av summa, differens, produkt och kvot av a/b och c/d.");

				// Send a message to the method and a flag if zero is accepted. 
				int a = ReadInt("Ange a: ", false);
				int b = ReadInt("Ange b: ", true);
				int c = ReadInt("Ange c: ", false);
				int d = ReadInt("Ange d: ", true);

				int numerator = 0;
				int denumerator = 0;

				// Calculate a/b + c/d
				// Lägg till anrop till metoden Add i klassen Fraction här
				Fraction.Add(a, b, c, d, ref numerator, ref denumerator);
				Console.WriteLine(a + "/" + b + " + " + c + "/" + d + " = " + numerator + "/" + denumerator);

				// Calculate a/b - c/d
				// Lägg till anrop till metoden Subtract i klassen Fraction här
				Fraction.Subtract(a, b, c, d, ref numerator, ref denumerator);
				Console.WriteLine(a + "/" + b + " - " + c + "/" + d + " = " + numerator + "/" + denumerator);

				// Calculate a/b * c/d
				// Lägg till anrop till metoden Multiply i klassen Fraction här
				Fraction.Multiply(a, b, c, d, ref numerator, ref denumerator);
				Console.WriteLine(a + "/" + b + " * " + c + "/" + d + " = " + numerator + "/" + denumerator);

				// Caculate a/b / c/d
				// Lägg till anrop till metoden Divide i klassen Fraction här
				Fraction.Divide(a, b, c, d, ref numerator, ref denumerator);
				Console.WriteLine(a + "/" + b + " / " + c + "/" + d + " = " + numerator + "/" + denumerator);

				Console.ReadKey();
				Console.Clear();
			}
		}

		// Method to check the user input and return an integer.
		// Also checks for zero input in certain cases. 
		static int ReadInt(string prompt, bool mustBeNonZero)
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


	}
}
