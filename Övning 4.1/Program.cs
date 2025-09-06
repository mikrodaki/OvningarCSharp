namespace Övning_4._1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Är det fint väder?");
			char input;
			while (true)
			{
				input = Console.ReadKey().KeyChar;
				Console.WriteLine();
				if (input == 'j' || input == 'J')
				{
					Console.WriteLine("\nVi går på picknick!");
					break;
				}
				else if (input == 'n' || input == 'N')
				{
					Console.WriteLine("\nVi stannar inne och läser en bok");
					break;
				}
				else
				{
					Console.WriteLine("Jag förstår inte");
				}
			}

		}
	}
}
