namespace Dog
{
	public class Dog
	{
		public string name;
		private string race = "Sausage";
		private int age = 4;

		public string PrintInfo() 
		{
			return $"{name} {race} {age}";
		}

		public bool IsOld() 
		{
			return age > 10;
		}

		public void SetAge(int newAge)
		{
			age = newAge;
		}
	}
}
