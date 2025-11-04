namespace Övning_6._11_Fredriks_facit
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Start coordinate in the middle of the consol window
			int x = 60;
			int y = 13;

			// Information to user
			Console.WriteLine("Det här programmet ritar ut ett o som du ");
			Console.WriteLine("kan flytta runt genom att ange en riktning.");
			Console.WriteLine("Programmet animerar o:et 8 steg i vald riktning.");
			Console.WriteLine("Tryck på enter för att börja");
			Console.ReadLine();
			Console.Clear();

			// Write the o at the start position in the middle of the screen
			Console.SetCursorPosition(x, y);
			Console.WriteLine("o");

			/*
             * Main loop. User enters a direction,
             * the o is animated 8 steps in that direction. 
             * 
             */
			while (true)
			{
				Console.CursorVisible = true;

				Console.SetCursorPosition(0, 0);
				Console.WriteLine("Ange riktning (u)pp, (n)er, (v)änster, (h)öger, (a)vsluta: ");
				string direction = Console.ReadLine();
				Console.Clear();

				// Quit program if user enters 'a'
				if (direction == "a")
					break;

				Console.CursorVisible = false;

				// Animate the o 8 steps in the selected direction
				for (int i = 0; i < 8; i++)
				{
					// Delete o
					Console.SetCursorPosition(x, y);
					Console.WriteLine(" ");

					// Change coordinate one step in the selected direction
					switch (direction)
					{
						case "u":
							if (y > 0)
								y--;
							break;

						case "n":
							if (y < 28)
								y++;
							break;

						case "v":
							if (x > 0)
								x--;
							break;

						case "h":
							if (x < 119)
								x++;
							break;

						default:
							break;
					}

					// Draw o at new coordinate
					Console.SetCursorPosition(x, y);
					Console.WriteLine("o");

					// Pause
					System.Threading.Thread.Sleep(100);
				}
			}
		}
	}
}
