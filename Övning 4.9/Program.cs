namespace Övning_4._9
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//string userName = "Daniel";
			//string password = "sesam";
			//string messsage = "";
			//bool userNameOk = false;
			//bool passwordOk = false;

			//while (!userNameOk || !passwordOk) 
			//{
			//	Console.Write("Användarnamn: ");
			//	userName = Console.ReadLine();
			//	Console.Write("Lösenord: ");
			//	password = Console.ReadLine();

			//	switch (userName)
			//	{
			//		case "Daniel":
			//			userNameOk = true;
			//			break;
			//		case "":
			//			messsage = "Användarnamn saknas";
			//			break;
			//		default:
			//			messsage = "Användarnamn felaktigt";
			//			break;
			//	}

			//	if (messsage == "")
			//	{
			//		switch (password)
			//		{
			//			case "sesam":
			//				passwordOk = true;
			//				break;
			//			case "":
			//				messsage = "Lösenord saknas";
			//				break;
			//			default:
			//				messsage = "Felaktigt lösenord";
			//				break;
			//		}
			//	}

			//	if (userNameOk && passwordOk)
			//		Console.WriteLine("Välkommen!");
			//	else
			//	{
			//		Console.WriteLine(messsage);
			//		passwordOk = false;
			//		userNameOk = false;
			//		messsage = "";
			//	}

			string correctPass = "sesam";
			string correctUser = "Daniel";

			while (true)
			{
				Console.Write("Användarnamn: ");
				string userName = Console.ReadLine();

				Console.Write("Lösenord: ");
				string password = Console.ReadLine();

				if (userName == "")
				{
					Console.WriteLine("Användarnamn saknas");
				}
				else if (password == "")
				{
					Console.WriteLine("Lösenord saknas");
				}
				else if (userName != correctUser)
				{
					Console.WriteLine("Användarnamn felaktigt");
				}
				else if (password != correctPass)
				{
					Console.WriteLine("Felaktigt lösenord");
				}
				else
				{
					Console.WriteLine("Välkommen!");
					break; // avsluta loopen när båda är rätt
				}
			}

		}
	}
}
