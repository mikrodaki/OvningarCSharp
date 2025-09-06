namespace Övning_5._3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var r = new Random();
			int tossResult = 0;
			// Console.Write("Hur många gånger vill du singla slant?: ");
			int noOfTosses = checkSubmittedNo("Hur mångs gånger vill du singla slant?: ");
			for (int i = 0; i < noOfTosses; i++)
			{
				tossResult = r.Next(0, 2);
			if (tossResult == 0)
				Console.WriteLine("Krona");
			else if (tossResult == 1)
				Console.WriteLine(" Klave");
			}

			int checkSubmittedNo(string message)
			{
				int result = 0;
				Console.Write(message);
				while (!int.TryParse(Console.ReadLine(), out result))
				{
					Console.WriteLine("Vänligen mata in ett heltal!");
					Console.Write(message);
				}
				return result;
			}
		}
	}
}