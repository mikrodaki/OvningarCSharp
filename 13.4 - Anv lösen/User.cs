namespace User
{
	class User
	{
		private string user = "admin";
		private string password = "sesam";

		public bool CheckPassword(string submittedUser, string submittedPassword)
		{
			return submittedPassword == password && submittedUser == user;
		}
	}
}
