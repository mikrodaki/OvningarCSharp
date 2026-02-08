using App.IO;

namespace _12._7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int age = ConsoleHelper.ReadInt("Ange din ålder: ", false);
			Console.WriteLine($"Din ålder är {age}.");
			int number = ConsoleHelper.ReadInt("Ange ett tal mellan 1 och 3: ", 1, 3);
			Console.WriteLine("Du lyckades ange ett tal i intervallet");
		}
	}
}
