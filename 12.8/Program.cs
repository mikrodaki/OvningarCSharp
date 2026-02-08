using App.IO;

namespace _12._8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int noOfNames = ConsoleHelper.ReadInt("Ange antal namn: ", true);
			string[] names = new string[noOfNames];
			for (int i = 0; i < names.Length - 1; i++)
			{
				int nameNumber = i + 1;
				string name = ConsoleHelper.ReadString("Ange namn " + nameNumber + ": ");
				names[nameNumber] = name;
			}
		}
	}
}
