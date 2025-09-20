using System.Collections.Specialized;

namespace Övning_4._14
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int noOfSeconds = 0;

			while (true) 
				{ 
				Console.Write("Ange antal sekunder: ");
				noOfSeconds = int.Parse(Console.ReadLine());
				if (noOfSeconds <= 60) 
				{
				    Console.WriteLine($"{noOfSeconds} är {noOfSeconds} sekunder");
				}
				else if(noOfSeconds > 60 && noOfSeconds <= 3600) 
				{ 
					int noOfMinutes = noOfSeconds / 60;
					int noOfSecondsRest = noOfSeconds % 60;
					Console.WriteLine($"Det är {noOfMinutes} minuter och {noOfSecondsRest} sekunder.");
				}
				else if (noOfSeconds > 3600)
				{
					int noOfHours = noOfSeconds / 3600;
					int rest = noOfSeconds % 3600;
					int noOfMinutes = rest / 60;
					int noOfSecondsRest = rest % 60;
					Console.WriteLine($"Det är {noOfHours} timmar, {noOfMinutes} minuter och {noOfSecondsRest} sekunder.");
				}
			}
		}
	}
}
