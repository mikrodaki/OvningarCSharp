namespace Övning_5._5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var r = new Random();
			int tossResult = 0;
			for (int i = 0; i <= 5; i++)
			{
				tossResult = r.Next(1, 7);
                Console.WriteLine(tossResult);
            }

			int temp = 0;
			string str = null;
			do
			{
                Console.Write("Mät vattnet. Hur många grader är det nu?: ");
				str = Console.ReadLine();	
				temp = Convert.ToInt32(str);
            }while(temp < 100) ;

            Console.WriteLine("Nu kokar det!");


        }
	}
}
