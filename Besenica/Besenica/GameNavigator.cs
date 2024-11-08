
namespace Besenica
{
    internal sealed class GameNavigator
    {
        public static void HandleGameMenu()
        {
            Console.Write("\n>> ");

            string? gameChoice = Console.ReadLine()?.Trim();

            switch (gameChoice)
            {
                case "1":
                    Options.DisplayGameRules();
                    break;
                case "2":
                    // TODO
                    // validate the word input
                    // create separate class for handling the core game logic
                    break;
                case "3":
                    // TODO
                    // open a txt file and get a random word from it.
                    break;
                case "4":
                    return; // Go back to the main menu
                default:
                    Console.WriteLine("\nInvalid option. Please try again.");
                    break;
            }
        }
    }
}
