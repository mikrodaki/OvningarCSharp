using Poker;

namespace Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.ReadKey();
            List<int> deck = new List<int>();
            Card.AddCardsToDeck(deck);
            List<int> myHand = new List<int>();

        }

    }
}