namespace Övning_9._4___Sjörövarspråket
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("Sjörövarspråket\n----------------");
				Console.Write("Ange text: ");
				string text = Console.ReadLine();
				Console.WriteLine();
				Console.Write("Sjörövarspråksverion: ");

				//for (int i = 0; i < text.Length; i++)
				//{
				//	char c = text[i];
				//	bool isNotConsonant = "aeiouyåäöAEIOUYÅÄÖ!?,: ".Contains(c);
				//	if (isNotConsonant)
				//	{
				//		Console.Write(c);
				//	}
				//	else
				//	{
				//		Console.Write($"{c}o{c}");
				//	}
				//}

				// Version 2 med substring istället för contains
				for (int i = 0; i < text.Length; i++)
				{
					char c = text[i];
					string vowelsAndOthers = "aeiouyåäöAEIOUYÅÄÖ!?,: ";

					bool isNotConsonant = false;

					for (int j = 0; j < vowelsAndOthers.Length; j++)
					{
						if (vowelsAndOthers.Substring(j, 1) == c.ToString())
						{
							isNotConsonant = true;
							break;
						}
					}

					if (isNotConsonant)
						Console.Write(c);
					else
						Console.Write($"{c}o{c}");
				}
				Console.ReadKey();
				Console.Clear();
			}
		}
	}
}
