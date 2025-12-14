namespace Övning_9._5___Robot_bug
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int x = 58;
			int y = 13;
			int dirX = 0;
			int dirY = 0;
			int minX = 0;
			int minY = 1;
			int maxX = Console.WindowWidth - 6;
			int maxY = Console.WindowHeight - 4;
			int direction = 0;
			int animation = 0;

			Console.CursorVisible = false;
			drawBug();

			while (true)
			{
				Console.SetCursorPosition(0, 0);
				Console.Write("Robot bug - f(orward) l(eft) r(ight) q(uit) ");
				ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
				char keyPressed = consoleKeyInfo.KeyChar;

				if (keyPressed == 'q')
					break;
				if (keyPressed == 'f')
					moveForward();
				if (keyPressed == 'l')
				{
					eraseBug();
					turnLeft();
					drawBug();
				}
				if (keyPressed == 'r')
				{
					eraseBug();
					turnRight();
					drawBug();
				}
			}

			void moveForward()
			{
				for (int i = 0; i < 10; i++)
				{
					if (direction == 0)
					{
						dirX = 0;
						dirY = -1;
					}
					if (direction == 1)
					{
						dirX = 1;
						dirY = 0;
					}
					if (direction == 2)
					{
						dirX = 0;
						dirY = 1;
					}
					if (direction == 3)
					{
						dirX = -1;
						dirY = 0;
					}

					if (!(direction == 0 && y == minY) &&
						!(direction == 1 && x == maxX) &&
						!(direction == 2 && y == maxY) &&
						!(direction == 3 && x == minX))
					{
						toggleAnimation();
						eraseBug();
						x += dirX;
						y += dirY;
						drawBug();
						Thread.Sleep(50);
					}
				}
			}

			void turnLeft()
			{
				//direction = (direction + 3) % 4;
				if (direction > 0)
					direction--;
				else
					direction = 3;
			}

			void turnRight()
			{
				//direction = (direction + 1) % 4;
				if (direction < 3)
					direction++;
				else
					direction = 0;
			}

			void toggleAnimation()
			{
				if (animation == 0)
					animation = 1;
				else
					animation = 0;
			}

			void eraseBug()
			{
				// Delete bug
				Console.SetCursorPosition(x, y);
				Console.Write("      ");
				Console.SetCursorPosition(x, y + 1);
				Console.Write("      ");
				Console.SetCursorPosition(x, y + 2);
				Console.Write("      ");
				Console.SetCursorPosition(x, y + 3);
				Console.Write("      ");
			}

			void drawBug()
			{
				switch (direction)
				{
					case 0:
						if (animation == 0)
						{
							// Draw bug facing up
							Console.SetCursorPosition(x, y);
							Console.Write("  ┐┌");
							Console.SetCursorPosition(x, y + 1);
							Console.Write(" ╔██╗");
							Console.SetCursorPosition(x, y + 2);
							Console.Write(" ╔██╗");
							Console.SetCursorPosition(x, y + 3);
							Console.Write(" ╔██╗");
						}
						else if (animation == 1)
						{
							// Draw bug facing up with straight legs
							Console.SetCursorPosition(x, y);
							Console.Write("  ┐┌");
							Console.SetCursorPosition(x, y + 1);
							Console.Write(" ═██═");
							Console.SetCursorPosition(x, y + 2);
							Console.Write(" ═██═");
							Console.SetCursorPosition(x, y + 3);
							Console.Write(" ═██═");
						}
						break;
					case 1:
						if (animation == 0)
						{
							// Draw bug facing right
							Console.SetCursorPosition(x, y);
							Console.Write("╗ ╗ ╗");
							Console.SetCursorPosition(x, y + 1);
							Console.Write("█████╡");
							Console.SetCursorPosition(x, y + 2);
							Console.Write("╝ ╝ ╝");
						}
						else if (animation == 1)
						{
							// Draw bug facing right with straight legs
							Console.SetCursorPosition(x, y);
							Console.Write("║ ║ ║");
							Console.SetCursorPosition(x, y + 1);
							Console.Write("█████╡");
							Console.SetCursorPosition(x, y + 2);
							Console.Write("║ ║ ║");
						}
						break;
					case 2:
						if (animation == 0)
						{
							// Draw bug facing down
							Console.SetCursorPosition(x, y);
							Console.Write(" ╚██╝");
							Console.SetCursorPosition(x, y + 1);
							Console.Write(" ╚██╝");
							Console.SetCursorPosition(x, y + 2);
							Console.Write(" ╚██╝");
							Console.SetCursorPosition(x, y + 3);
							Console.Write("  ┘└");
						}
						else if (animation == 1)
						{
							// Draw bug facing down with straight legs
							Console.SetCursorPosition(x, y);
							Console.Write(" ═██═");
							Console.SetCursorPosition(x, y + 1);
							Console.Write(" ═██═");
							Console.SetCursorPosition(x, y + 2);
							Console.Write(" ═██═");
							Console.SetCursorPosition(x, y + 3);
							Console.Write("  ┘└");
						}
						break;
					case 3:
						if (animation == 0)
						{
							// Draw bug facing left
							Console.SetCursorPosition(x, y);
							Console.Write(" ╔ ╔ ╔");
							Console.SetCursorPosition(x, y + 1);
							Console.Write("╞█████");
							Console.SetCursorPosition(x, y + 2);
							Console.Write(" ╚ ╚ ╚");
						}
						else if (animation == 1)
						{
							// Draw bug facing left with straight legs
							Console.SetCursorPosition(x, y);
							Console.Write(" ║ ║ ║");
							Console.SetCursorPosition(x, y + 1);
							Console.Write("╞█████");
							Console.SetCursorPosition(x, y + 2);
							Console.Write(" ║ ║ ║");
						}
						break;
				}
			}
		}
	}
}
