
namespace Besenica
{
    internal sealed class Options
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
            Console.WriteLine("\n *** Game Menu *** \n");
            Console.WriteLine("1. View the game rules");
            Console.WriteLine("2. Enter a word");
            Console.WriteLine("3. Guess a random word");
            Console.WriteLine("4. Go back");
            Console.WriteLine();
        }
    }
}
