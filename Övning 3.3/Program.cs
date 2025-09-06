namespace Övning_3._3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double decimalNo = checkSubmittedNo("Ange ett decimaltal: ");
			int number = Convert.ToInt32(Math.Round(decimalNo));
			Console.Write($"Decimaltalet {decimalNo} avrundas till heltalet {number}");

			double checkSubmittedNo(string message)
			{
				double result;
				Console.Write(message);
				while (!double.TryParse(Console.ReadLine(), out result) || result % 1 == 0)
				{
					Console.WriteLine("Vänligen mata in ett decimaltal!");
					Console.Write(message);
				}
				return result;
			}
		}
	}
}
