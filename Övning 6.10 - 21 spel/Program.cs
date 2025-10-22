namespace Övning_6._10___21_spel
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("21 spel");
			Console.WriteLine("------------------------");

			int playerSum = 0;
			Random random = new Random();
			string playerChoice = string.Empty;

			do
			{
				Console.WriteLine();
				int card = random.Next(1, 14);
				playerSum += card;
				Console.WriteLine($"Du fick {card}");
				Console.WriteLine();
				Console.WriteLine($"Summa {playerSum}.");
				Console.WriteLine();
				if (playerSum < 21)
				{
					Console.Write("Vill du dra ett till kort (j/n)? ");
					playerChoice = Console.ReadLine();
				}
			} while (playerSum < 21 && playerChoice == "j");

			if (playerSum == 21)
				Console.WriteLine("Grattis - 21!");
			else if (playerSum > 21)
				Console.WriteLine("Du förlorade.");
			else if (playerChoice != "j") 
			{
				Console.WriteLine();			
				Console.WriteLine("Spelet slut.");
			}
		}
	}
}
