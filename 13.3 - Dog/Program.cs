namespace Dog
{
	class Program
	{
		static void Main(string[] args)
		{
			Dog Dog1 = new Dog();
			Dog1.name = "Orvar";
			Dog1.IsOld();
			Console.WriteLine(Dog1.PrintInfo());
			Dog1.SetAge(7);
			Console.WriteLine(Dog1.PrintInfo());
		}
	}
}
