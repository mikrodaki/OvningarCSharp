namespace Övning_10._2___Division
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double numerator = 0;
			double denominator = 0;
			bool invalidInput = true;

			do
			{
				try
				{
					Console.Write("Ange täljaren: ");
					numerator = Convert.ToDouble(Console.ReadLine());
					invalidInput = false;
				}
				catch (Exception)
				{
					Console.WriteLine("Täljaren måste vara ett heltal eller ett decimaltal. Försök igen. ");
				}
			}
			while (invalidInput);

			invalidInput = true;

			do
			{
				try
				{
					Console.Write("Ange nämnaren: ");
					denominator = Convert.ToDouble(Console.ReadLine());
					if (denominator != 0)
					{
						invalidInput = false;
					}
					else 
					{ 
						Console.WriteLine("Nämnaren får inte vara 0. Försök igen. ");
					}
				}
				catch (Exception)
				{
					Console.WriteLine("Nämnaren måste vara ett heltal eller ett decimaltal. Försök igen. ");
				}
			}
			while (invalidInput);


			double fraction = numerator / denominator;
			Console.Write($"Kvoten av {numerator} / {denominator} är {fraction}  ");

			Console.ReadKey();
		}
	}
}
