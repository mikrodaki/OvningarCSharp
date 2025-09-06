namespace Övning_4._5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Ange temperatur för Östersund: ");
			int ostersund = Convert.ToInt32(Console.ReadLine());
			Console.Write("Ange temperatur för Åmål: ");
			int amal = Convert.ToInt32(Console.ReadLine());
			Console.Write("Ange temperatur för Arboga: ");
			int arboga = Convert.ToInt32(Console.ReadLine());

			if (ostersund < amal && ostersund < arboga)
			{
				Console.WriteLine("Det är kallast i Östersund");
			}
			else if (amal < ostersund && amal < arboga)
			{
				Console.WriteLine("Det är kallast i Åmål");	
			}
			else 
			{ 
				Console.WriteLine("Det är kallast i Arboga");
			}
		}
	}
}
