using App.IO;

namespace _12._10___Sista_bokstaven
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ConsoleHelper.ClearScreen("STÖRSTA BOKSTAVEN I EN STRÄNG");
			string input = ConsoleHelper.ReadString("Ange en sträng: ");
			var lower = input.ToLower();
			// Assign null to biggest
			var biggest = '\0';
			for (int i = 0; i < lower.Length; i++)
			{
				if (lower[i] == ' ')
					continue;
				if (lower[i] > biggest)
					biggest = lower[i];
			}
			Console.WriteLine($"Den stösta bokstaven i strängen är {biggest}");
		}
	}
}
