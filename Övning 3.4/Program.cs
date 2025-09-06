namespace Övning_3._4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Ange namnet på person nummer 1: ");
			string person1 = Console.ReadLine();
			Console.Write("Ange namnet på person nummer 2: ");
			string person2 = Console.ReadLine();
			Console.Write($"Här kommer en liten historia om {person1} och {person2} \nNu är sagan slut.");
		}
	}
}
