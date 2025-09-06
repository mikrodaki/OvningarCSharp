namespace Övning_5._2
{
	internal class Program
	{
		static void Main(string[] args)
		{
            Console.Write("Mata inte ett tal mellan 1 till 100: ");
			string input = Console.ReadLine();
			try
			{
				int tal = int.Parse(input);
				if ( tal < 100 && tal > 0 ) 
				{	
					while ( tal <= 100 ) 
					{
				        Console.Write(tal + " ");
						tal++;
				    }
				}
				else
				{
                    Console.WriteLine("Du skrev in ett feltaktigt tal");
                }
			}
			catch (Exception ex)
			{
				Console.WriteLine("Du krashade programmet");
                Console.WriteLine(ex.Message);
            }

        }
	}
}
