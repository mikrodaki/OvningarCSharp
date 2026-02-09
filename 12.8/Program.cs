using App.IO;

namespace _12._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.ClearScreen("Namnlistan");
            int noOfNames = ConsoleHelper.ReadInt("Ange antal namn: ", true);
            string[] names = new string[noOfNames];
            for (int i = 0; i < names.Length; i++)
            {
                int nameNumber = i + 1;
                string name = ConsoleHelper.ReadString("Ange namn " + nameNumber + ": ");
                names[i] = name;
            }
            int userChoice = 0;
            do
            {
                ConsoleHelper.ClearScreen("Namnlistan");
                ConsoleHelper.PrintOptions();
                userChoice = ConsoleHelper.ReadInt("Ditt val: ", 1, 3);
                if (userChoice == 1)
                {
                    int nameChangeIndex = ConsoleHelper.ReadInt($"Ange numret på namnet du vill ändra (1-{names.Length}): ", 1, names.Length);
                    string newName = ConsoleHelper.ReadString($"Ange det nya namnet för index nummer {nameChangeIndex}: ");
                    names[nameChangeIndex - 1] = newName;
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine();
                    for (int i = 0; i < names.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}-{names[i]}");
                    }
                    Console.ReadKey();
                }
            } while (userChoice != 3);
        }
    }
}
