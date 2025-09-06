using System.Drawing;

namespace Övning_4._13
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Point a = new Point(-150, -100);
			Point b = new Point(700, -100);
			Point c = new Point(700, 800);
			Point d = new Point(-150, 800);
			int xCoordinate, yCoordinate;

			while (true) 
			{
				Console.Write("Ange x-värdet: ");
				xCoordinate = Convert.ToInt32(Console.ReadLine());
				Console.Write("Ange y-värdet: ");
				yCoordinate = Convert.ToInt32(Console.ReadLine());

				if (xCoordinate >= a.X && xCoordinate <= b.X && yCoordinate >= b.Y && yCoordinate <= c.Y)
					Console.WriteLine("Den angivna punkten är inom kvadraten");
				else
					Console.WriteLine("Den angivna punkten är utanför kvadraten");	
			}
		}
	}
}
