using App.IO;

namespace _12._18___Poker
{
	internal class Program
	{
		static Random rnd = new Random();
		static void Main(string[] args)
		{
			List<string> deck = new List<string>();
			List<string> myHand = new List<string>();
			int numberOfCards = 5;

			ConsoleHelper.ClearScreen("POKER");
			AddCardsToDeck(deck);
			AddCardsToMyHand(deck, myHand, numberOfCards);
			PrintMyHand(myHand);
			Console.WriteLine();
			var choice = ConsoleHelper.ReadYesNo("Vill du kasta några kort (j/n)? ");
			if (choice == "j")
			{
				var numberOfCardsInHand = myHand.Count;
				var indexesToRemove = ConsoleHelper.ReadStringIntPoker("Vilka index vill du kasta? ", numberOfCardsInHand - 1);
				RemoveCardsFromMyHand(myHand, indexesToRemove);
				int numberOfCardsRemoved = indexesToRemove.Length;
				AddCardsToMyHand(deck, myHand, numberOfCardsRemoved);
				Console.WriteLine();
				PrintMyHand(myHand);
			}
		}
		static void AddCardsToDeck(List<string> deck)
		{
			deck.Add("Hjärter 2");
			deck.Add("Hjärter 3");
			deck.Add("Hjärter 4");
			deck.Add("Hjärter 5");
			deck.Add("Hjärter 6");
			deck.Add("Hjärter 7");
			deck.Add("Hjärter 8");
			deck.Add("Hjärter 9");
			deck.Add("Hjärter 10");
			deck.Add("Hjärter knekt");
			deck.Add("Hjärter dam");
			deck.Add("Hjärter kung");
			deck.Add("Hjärter ess");
			deck.Add("Ruter 2");
			deck.Add("Ruter 3");
			deck.Add("Ruter 4");
			deck.Add("Ruter 5");
			deck.Add("Ruter 6");
			deck.Add("Ruter 7");
			deck.Add("Ruter 8");
			deck.Add("Ruter 9");
			deck.Add("Ruter 10");
			deck.Add("Ruter knekt");
			deck.Add("Ruter dam");
			deck.Add("Ruter kung");
			deck.Add("Ruter ess");
			deck.Add("Spader 2");
			deck.Add("Spader 3");
			deck.Add("Spader 4");
			deck.Add("Spader 5");
			deck.Add("Spader 6");
			deck.Add("Spader 7");
			deck.Add("Spader 8");
			deck.Add("Spader 9");
			deck.Add("Spader 10");
			deck.Add("Spader knekt");
			deck.Add("Spader dam");
			deck.Add("Spader kung");
			deck.Add("Spader ess");
			deck.Add("Klöver 2");
			deck.Add("Klöver 3");
			deck.Add("Klöver 4");
			deck.Add("Klöver 5");
			deck.Add("Klöver 6");
			deck.Add("Klöver 7");
			deck.Add("Klöver 8");
			deck.Add("Klöver 9");
			deck.Add("Klöver 10");
			deck.Add("Klöver knekt");
			deck.Add("Klöver dam");
			deck.Add("Klöver kung");
			deck.Add("Klöver ess");
		}
		static void AddCardsToMyHand( List<string> deck, List<string> myHand, int noOfCards)
		{
			for (int i = 0; i < noOfCards; i++)
			{
				var randomIndex = rnd.Next(0, deck.Count);
				var randomCard = deck[randomIndex];
				myHand.Add(randomCard);
				RemoveCardFromDeck(deck, randomCard);
			}
		}
		static void RemoveCardFromDeck(List<string> deck, string card)
		{
			deck.Remove(card);
		}
		static void PrintMyHand(List<string> myHand)
		{
			for (int i = 0; i < myHand.Count; i++)
			{
				Console.WriteLine($"[{i}] {myHand[i]}");
			}
		}
		static void RemoveCardsFromMyHand(List<string> myHand, string indexes)
		{
			List<int> sortedIndexes = new List<int>();

			foreach (var c in indexes)
			{
				sortedIndexes.Add(c - '0');
			}

			sortedIndexes.Sort();
			sortedIndexes.Reverse();

			foreach (var c in sortedIndexes)
			{
				myHand.RemoveAt(c);
			}
		}
	}
}
