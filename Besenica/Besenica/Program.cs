
namespace Besenica
{
    public class Program
    {
        public static void Main()
        {
            bool exitGame = false;

            while (!exitGame)
            {
                Options.DisplayMainMenu();

                Console.Write("\n >> ");

                string? userChoice = Console.ReadLine()?.Trim();

                switch (userChoice)
                {
                    case "1":
                        Options.DisplayGameMenu();
                        GameNavigator.HandleGameMenu();
                        break;
                    case "2":
                        Console.Clear();
                        FileManager.ReadGameDataFromFile();
                        break;
                    case "3":
                        exitGame = true;
                        Console.WriteLine("\nExiting the game. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("\nInvalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
