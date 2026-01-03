namespace Övning_10e
{
	internal class Program
	{
		static void Main(string[] args)
		{
			bool notANumber = true;
			do
			{
				Console.Clear();
				Console.Write("Ange ett tal: ");
				var input = Console.ReadLine();
				try
				{
					int number = int.Parse(input);
					notANumber = false;
				}
				catch (Exception e)
				{
					Console.Write("Ange endast tal. Försök igen. ");
					Console.ReadKey();
				}
			} while (notANumber);

			Console.Write("Du har angivit ett giltigt tal");
		}
	}
}
