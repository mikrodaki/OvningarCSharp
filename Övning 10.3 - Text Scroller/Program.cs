namespace Övning_10._3___Text_Scroller
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int panelWidth = 20;
			string emptyText = new string(' ', panelWidth);
			string text = emptyText + "Hagsätra 1min  Farsta strand 3min  Skarpnäck 5min  Hagsätra 6min  Farsta strand 8min  Skarpnäck 12min" + emptyText;

			Console.CursorVisible = false;

			// Draw train board
			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.SetCursorPosition(50, 10);
			Console.Write("╔═══╩═══════════╩════╗");
			Console.SetCursorPosition(50, 11);
			Console.Write("║                    ║");
			Console.SetCursorPosition(50, 12);
			Console.Write("╚════════════════════╝");

			// Draw Arriavals
			Console.SetCursorPosition(51, 11);
			Console.ForegroundColor = ConsoleColor.Yellow;
			int startIndex = 0;
			while (true)
			{
				Console.SetCursorPosition(51, 11);
				Console.Write(text.Substring(startIndex, panelWidth));
				System.Threading.Thread.Sleep(100);
				if (startIndex == text.Length - panelWidth)
					startIndex = 0;
				else
					startIndex++;
			}
		}
	}
}
