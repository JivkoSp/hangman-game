using System.Text;

namespace Besenica
{
    // This class is responsible for the core domain logic of the game.
    internal static class GameController
    {
        public static void Play(string word)
        {
            Console.Clear();

            if (string.IsNullOrEmpty(word))
            {
                Console.WriteLine("The word must not be empty!");
                return;
            }

            var wordDict = new Dictionary<char, List<int>>();
            string userTries = " | | | | | |"; 
            var userWord = new StringBuilder();
            int attempts = 6;

            FileManager.WriteGameRoundDataToFile(word, false); // By default the user has NOT guessed the word.

            for (int i = 0; i < word.Length; i++)
            {
                if (!wordDict.ContainsKey(word[i]))
                {
                    wordDict[word[i]] = new List<int>();
                }

                wordDict[word[i]].Add(i);
            }

            for (int i = 0; i < word.Length; i++)
            {
                userWord.Append("- ");
            }

            bool goBack = false;

            while (attempts > 0 && !goBack)
            {
                Console.Clear();

                Console.WriteLine($"\nWord: {userWord}");
                Console.WriteLine($"\nYour tries: {userTries}");
                Console.WriteLine("Enter a letter or type 'back' to go back.");
                Console.Write("\n>> ");

                string? input = Console.ReadLine()?.ToLower();

                if (input == "back")
                {
                    goBack = true;
                    break;
                }

                if (string.IsNullOrEmpty(input) || input.Length > 1 || !char.IsLetter(input[0]))
                {
                    Console.WriteLine("\nYou need to enter a valid single letter!");
                    Console.ReadKey();

                    continue;
                }

                char chosenLetter = input[0];

                // Check if the letter is in the word
                if (wordDict.ContainsKey(chosenLetter))
                {
                    foreach (var letterPosition in wordDict[chosenLetter])
                    {
                        userWord[letterPosition * 2] = chosenLetter; // *2 because of spaces in userWord.
                    }

                    // Remove the letter from the dictionary to prevent duplicate matches.
                    wordDict.Remove(chosenLetter);
                }
                else
                {
                    // Wrong guess - reduce attempts and update user tries.
                    attempts--;
                    userTries = userTries.Remove(userTries.LastIndexOf('|'), 1);
                }

                // Check if the user has guessed the word.
                if (!userWord.ToString().Contains('-'))
                {
                    FileManager.WriteGameRoundDataToFile(word, true);

                    Console.Clear();
                    Console.WriteLine($"\nCongratulations! You guessed the word: {word}");
                    Console.WriteLine("Press any key to go back to the Game Menu...");
                    Console.ReadKey();
                    break;
                }
            }

            if (attempts == 0)
            {
                Console.Clear();
                Console.WriteLine("\nGame over! You've been hanged.");
                Console.WriteLine($"The word was: {word}");
                Console.WriteLine("Press any key to go back to the Game Menu...");
                Console.ReadKey();
            }
        }
    }
}
