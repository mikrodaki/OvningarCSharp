namespace _5._11___Digital_klocka
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int hours = 14;
			int minutes = 59;
			int seconds = 50;
			Console.CursorVisible = false;

			while (true)
			{
				while (hours < 24)
				{
					while (minutes < 60)
					{
						while (seconds < 60)
						{
							Console.SetCursorPosition(30, 10);
							Console.Write($"{hours:D2}:{minutes:D2}:{seconds:D2}");
							Thread.Sleep(1000);
							seconds++;
						}
						minutes++;
						seconds = 0;
					}
					hours++;
					minutes = 0;
				}
				hours = 0;
			}
		}
	}
}
