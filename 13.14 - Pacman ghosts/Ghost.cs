namespace Ghost
{
	public class Ghost
	{
		private int x;
		private int y;
		private ConsoleColor color;
		private int eyePos;
		private List<string> eyes = new List<string>();


		public Ghost(int x, int y, ConsoleColor color, int eyePosition)
		{
			this.x = x;
			this.y = y;
			this.color = color;
			this.eyePos = eyePosition;
			eyes.Add("▀ ");
			eyes.Add(" ▀");
			eyes.Add(" ▄");
			eyes.Add("▄ ");
		}

		public void Draw()
		{
			Console.ForegroundColor = color;
			Console.SetCursorPosition(x, y);
			Console.WriteLine(" ▄▄▄▄▄");
			Console.SetCursorPosition(x, y + 1);
			Console.WriteLine("▐  █  ▌");
			Console.SetCursorPosition(x, y + 2);
			Console.WriteLine("███████");
			Console.SetCursorPosition(x, y + 3);
			Console.WriteLine("▀ ▀ ▀ ▀");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.BackgroundColor = ConsoleColor.White;
			Console.SetCursorPosition(x + 1, y + 1);
			Console.WriteLine(eyes[eyePos]);
			Console.SetCursorPosition(x + 4, y + 1);
			Console.WriteLine(eyes[eyePos]);
			Console.BackgroundColor = ConsoleColor.Black;
		}

		public void ChangeEyePosition()
		{
			eyePos = (eyePos + 1) % 4;
		}
	}
}
