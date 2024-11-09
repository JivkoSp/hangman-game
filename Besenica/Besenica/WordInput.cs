
namespace Besenica
{
    // This class is responsible for handling the word input from the user.
    internal static class WordInput
    {
        public static string GetWordFromUser()
        {
            string word = "";

            while (true)
            {
                var keyInfo = Console.ReadKey(intercept: true);

                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    break;
                }

                word += keyInfo.KeyChar;
                Console.Write("*");
            }

            return string.IsNullOrEmpty(word) || double.TryParse(word, out _) ? "" : word.ToLower();
        }
    }
}
