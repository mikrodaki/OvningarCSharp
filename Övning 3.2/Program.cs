internal class Program
{
	private static void Main(string[] args)
	{
		int firstNo = checkSubmittedNo("Ange tal nummer 1: ");
		int secondNo = checkSubmittedNo("Ange tal nummer 2: ");
		int thirdNo = checkSubmittedNo("Ange tal nummer 3: ");

		int sum = firstNo + secondNo + thirdNo;
		double average = sum / 3.0;
		Console.WriteLine("Summan av talen är: " + sum);
		Console.WriteLine("Medelvärdet för talen är: " + average.ToString("F2"));

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