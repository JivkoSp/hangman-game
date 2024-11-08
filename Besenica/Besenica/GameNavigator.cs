
namespace Besenica
{
    internal static class GameNavigator
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
                    var word = WordInputValidator.ValidateWordInput();
                    HangmanController.PlayHangman(word);
                    break;
                case "3":
                    string filePath = "words.txt";

                    if (!File.Exists(filePath))
                    {
                        // If the file does not exist, create it with 20 (by default) random words
                        FileManager.CreateAndInitializeFileWithWords();
                    }

                    var randomWord = FileManager.GetRandomWordFromFile(filePath);
                    HangmanController.PlayHangman(randomWord);
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
