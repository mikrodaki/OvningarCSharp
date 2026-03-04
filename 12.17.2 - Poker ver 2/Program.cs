using System.Text;
using App.IO;

namespace Poker
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberOfCards = 5;
			Console.BackgroundColor = ConsoleColor.DarkGreen;
			// Viktig rad för att symbolerna ska synas
			Console.OutputEncoding = Encoding.UTF8;
			Console.Clear();
			Console.ReadKey();
			List<int> deck = new List<int>();
			Card.AddCardsToDeck(deck);
			List<int> myHand = new List<int>();
			Card.AddCardsToMyHand(deck, myHand, numberOfCards);
			Card.DrawCards(myHand);
			Console.SetCursorPosition(0,15);
			Console.CursorVisible = true;
			Console.ForegroundColor = ConsoleColor.Black;
			var choice = Card.ReadYesNo("Vill du kasta några kort (j/n)? ");
			if (choice == "j")
			{
				var numberOfCardsInHand = myHand.Count;
				var indexesToRemove = Card.ReadStringIntPoker("Vilka index vill du kasta? ", numberOfCardsInHand - 1);
				Card.RemoveCardsFromMyHand(myHand, indexesToRemove);
				int numberOfCardsRemoved = indexesToRemove.Length;
				Card.AddCardsToMyHand(deck, myHand, numberOfCardsRemoved);
				Card.DrawCards(myHand);
				Console.ReadKey();
			}
		}

	}
}