
namespace Besenica
{
    // This class is responsible for providing various options to the user about the game mechanics.
    internal static class Options
    {
        public static void DisplayMainMenu()
        {
            Console.WriteLine("\n *** Main Menu *** \n");
            Console.WriteLine("1. Start a game");
            Console.WriteLine("2. View your score");
            Console.WriteLine("3. Exit");
            Console.WriteLine();
        }

        public static void DisplayGameMenu()
        {
            Console.Clear();
            Console.WriteLine("\n *** Game Menu *** \n");
            Console.WriteLine("1. View the game rules");
            Console.WriteLine("2. Enter a word");
            Console.WriteLine("3. Guess a random word");
            Console.WriteLine("4. Go back");
            Console.WriteLine();
        }

        public static void DisplayGameRules()
        {
            Console.Clear();
            Console.WriteLine("\n *** Game Rules *** \n");
            Console.WriteLine("\n Rules of Hangman\r\n" +
                              "\nThe goal is to guess the hidden word, with each of its letters represented by horizontal dashes.\r" +
                              "\nIf the guessed letter is present in the word, it will appear in the correct position(s)\n" +
                              "(including multiple times if it occurs more than once).\r\nOtherwise, the vertical dashes representing" +
                              "the remaining attempts will decrease by one.\r" +
                              "\nWhen all vertical dashes disappear after 6 incorrect guesses, the game is over — the player is \"hanged\"! \n");
        }
    }
}
