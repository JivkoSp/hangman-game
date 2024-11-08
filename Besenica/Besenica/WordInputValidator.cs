
namespace Besenica
{
    internal static class WordInputValidator
    {
        public static string ValidateWordInput()
        {
            string word = "";

            do
            {
                Console.Write("\nEnter a word: ");

                word = WordInput.GetWordFromUser();

                if (string.IsNullOrEmpty(word))
                {
                    Console.WriteLine(" *** The word is not valid! ***");
                    Console.WriteLine(" Please enter a valid word.");
                }
            }
            while (string.IsNullOrEmpty(word));

            return word;
        }
    }
}
