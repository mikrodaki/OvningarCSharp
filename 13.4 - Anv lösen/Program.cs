namespace User
{
	class Program
	{
		static void Main(string[] args)
		{
			User u = new User();
			Console.WriteLine(u.CheckPassword("admin", "sesam"));
			Console.WriteLine(u.CheckPassword("admin", "sesami"));
		}
	}
}
