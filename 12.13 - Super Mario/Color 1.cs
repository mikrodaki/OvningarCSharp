namespace ColorConstants
{
    class Color
    {
	// Background color
	public const int GREY = 0;

	// Hat and shirt color
        public const int RED = 1;

	// Hair, eyes, mustache
	public const int BLACK = 2;

	// Skin color
	public const int YELLOW = 3;

	// Pants
	public const int BLUE = 4;

	// Alternative hat and shirt colors
        public const int CYAN = 5;
        public const int GREEN = 6;
        public const int MAGENTA  = 7;

	// Alternative pants colors
        public const int DARKRED = 8;
        public const int DARKMAGENTA = 9;
        public const int DARKYELLOW = 10;

        public static int[] hatAndShirts = new int[] { RED, CYAN, GREEN, MAGENTA };
        public static int[] pants = new int[] { BLUE, DARKRED, DARKMAGENTA, DARKYELLOW };
    }
}
