namespace _11._25___MyTemperature
{
	internal class Program
	{
		static void Main(string[] args)
		{
			float celsius = 99.5f;

			float fahrenheit = MyTemperature.CelsiusToFahrenheit(celsius);
			Console.WriteLine("Vattnet är " + fahrenheit + " grader fahrenheit.");

			if (MyTemperature.IsBoiling(fahrenheit))
			{
				Console.WriteLine("Det kokar!");
			}
			else
			{
				Console.WriteLine("Det kokar inte än.");
			}

			Console.ReadKey();
		}
	}
}
