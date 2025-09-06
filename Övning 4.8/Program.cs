using System.Diagnostics.CodeAnalysis;

namespace Övning_4._8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("[I]nsättning");
			Console.WriteLine("[U]ttag");
			Console.WriteLine("[S]aldo");
			Console.WriteLine("[A]vsluta");
            Console.WriteLine("-------------");
			char choice = default(char);
			bool leaveLoop = false;
			int balance = 100;
			string input = "";

			while (!leaveLoop) 
			{
				Console.Write("Val?: ");
				choice = char.ToLower(Console.ReadKey().KeyChar);

				switch (choice)
				{
					case 'i' :
						Console.Write("\nHur mycket vill du sätta in?: ");
						input = Console.ReadLine();
						if (checkInteger(input))
						{
							balance = balance + int.Parse(input);
                            Console.WriteLine($"{input} kr har satts in på ditt konto. " +
								$"Ditt nya saldo är {balance} kr");
                        }
						else
						{
                            Console.WriteLine("Ogiltig inmatning..");
                        }
						break;
					case 'u':
						Console.Write("\nHur mycket vill du ta ut?: ");
						input = Console.ReadLine();
						if (checkInteger(input))
						{
							if (int.Parse(input) > balance)
							{
                                Console.WriteLine("Utag godkänns ej");
                            }
							else
							{
								balance = balance - int.Parse(input);
								Console.WriteLine($"{input} kr har tagits ut från ditt konto. " +
									$"Ditt nya saldo är {balance} kr");
							}
						}
						else
						{
							Console.WriteLine("Ogiltig inmatning..");
						}
						break;
					case 's':
						Console.WriteLine($"\nDitt saldo är: {balance} kr");
						break;
					case 'a':
						Console.WriteLine("\nHej då!");
						leaveLoop = true;
						break;
					default:
						Console.WriteLine("\nOgiltigt val");
						break;
				}
			}

			static bool checkInteger (string value)
			{
				bool isPositiveInteger = int.TryParse(value, out int number) && number > 0;
				if (isPositiveInteger)
					return true;
				return false;
			}
		}
	}
}
