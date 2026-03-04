namespace Poker
{
    class Card
    {
        static Random rnd = new Random();
        /*
         * AddCardsToDeck
         * 
         * Adds 52 card numbers 0-51.
         * 0-12 Hearts
         * 13-25 Diamonds
         * 26-38 Spades
         * 39-51 Clubs
         *
         */
        public static void AddCardsToDeck(List<int> deck) 
        {
            for (int i = 0; i < deck.Count; i++) 
            { 
                deck.Add(i);
            }
        }



        /*
         * AddCardsToMyHand
         * 
         * Adds a number of randomly selected cards
         * from deck to player's hand.
         * 
         */
        public static void AddCardsToMyHand(List<int> deck, List<int> myHand, int numberOfCards) 
        {
            foreach (int card in deck) 
            { 
                int randomCard = rnd.Next(1, 53);
            }
        }



        /*
         * DrawCards
         * 
         * Draws the cards in player's hand
         * 
         */
        //public static void DrawCards ..



        /*
         * DrawCard
         * 
         * Draws a card with a symbol and rank, black or red on a white background. 
         * 
         * Parameters:
         * value - A value between 0-51. 0-12 hearts, for exampel value 1 is 2 of hearts.
         * x - x position for upper left card corner
         * y - y position for upper left card corner
         * 
         */
        static void DrawCard(int value, int x, int y)
        {
            string[] symbols = { "♥", "♦", "♠", "♣" };
            string[] ranks = { "E", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Kn", "D", "K" };

            Console.BackgroundColor = ConsoleColor.White;

            if (value < 26)
                Console.ForegroundColor = ConsoleColor.Red;
            else
                Console.ForegroundColor = ConsoleColor.Black;

            WriteAt(x, y, "┌─────────┐");
            for (int i = 0; i < 8; i++)
                WriteAt(x, y + i + 1, "│         │");
            WriteAt(x, y + 8, "└─────────┘");

            int suitIndex = value / 13;
            WriteAt(x + 5, y + 4, symbols[suitIndex]);

            int rankIndex = value % 13;
            WriteAt(x + 1, y + 1, ranks[rankIndex]);

            int xPos = x + 9;

            if (rankIndex == 9 || rankIndex == 10)
                xPos--;

            WriteAt(xPos, y + 7, ranks[rankIndex]);
        }


        /*
         * WriteAt
         * 
         * Help method that writes a text at 
         * a specific coordinate.
         * 
         */

        static void WriteAt(int x, int y, string text)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(text);
        }
    }
}
