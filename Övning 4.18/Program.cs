namespace Övning_4._18
{
	internal class Program
	{
		static void Main(string[] args)
		{

			while (true) 
			{ 
				string answer = "";
				int resultFromDivision = 0;
				int rest;
				Console.WriteLine("Välkommen till programmet som konverterar" +
					"ett decimaltal mellan 0-64 till binärt");
				Console.WriteLine("-------");
				Console.Write("Ange ett tal mellan 0-64: ");
				int submittedNumber = Convert.ToInt32(Console.ReadLine());
				resultFromDivision = submittedNumber;

				while (resultFromDivision != 0) 
				{
					resultFromDivision = resultFromDivision / 2;
					rest = resultFromDivision % 2;
					answer = answer + rest.ToString();
				}
			}
			
		}
	}
}
