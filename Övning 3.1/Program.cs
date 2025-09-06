internal class Program
{
	private static void Main(string[] args)
	{
		// Version 1, fungerar om användaren matar i ett heltal, annars krashar programmet
		/*
		Console.Write("Mata in första talet: ");
		int tal1 = int.Parse(Console.ReadLine());
		Console.Write("Mata in andra talet: ");
		int tal2 = int.Parse(Console.ReadLine());
		int sum = tal1 + tal2;
		Console.WriteLine("Summan av talen är: " + sum);
		*/

		// Version 2, fungerar korrekt men koden kan göras smartare


		int noOfNumbers = checkSubmittedNoForArray("Hur många tal vill du mata in? ");
		int[] numbers = new int [noOfNumbers];

		for (int i = 0; i < numbers.Length; i++) 
		{
			int number = checkSubmittedNo("Vänligen mata in tal nummer " + (i + 1) + ": ");
			numbers[i] = number;
		}

		Console.WriteLine("Summan av talen du matade in är: " + numbers.Sum());

		int checkSubmittedNoForArray(string message)
		{
			int result = 0;
			Console.Write(message);
			while (!int.TryParse(Console.ReadLine(), out result) || result <= 0)
			{
				Console.WriteLine("Vänligen mata in ett positivt heltal!");
				Console.Write(message);
			}
			return result;
		}

		int checkSubmittedNo (string message)
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