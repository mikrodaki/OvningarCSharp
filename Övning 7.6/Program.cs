namespace Övning_7._6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			bool a = false;
			bool b = false;
			bool left;
			bool right;

			for (int i = 0; i <= 3; i++)
			{
				switch (i) 
				{
					case 0:
						a = false;
						b = false;
						break;
					case 1:
						a = true;
						b = false;
						break;
					case 2:
						a = false;
						b = true;
						break;
					case 3:
						a = true;
						b = true;
						break;
				}
				left = !(a && b);
				right = !a || !b;
				bool ok = left == right;
				Console.WriteLine($"När a är {a} och b är {b} så är utrycket {ok}");
			}
		}
	}
}
