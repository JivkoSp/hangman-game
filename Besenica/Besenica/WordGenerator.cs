
namespace Besenica
{
    internal static class WordGenerator
    {
        public static HashSet<string> GenerateRandomWords()
        {
            string[] wordArray = new string[]
            {
                "apple", "banana", "cherry", "orange", "grape", "lemon", "peach", "pear",
                "plum", "mango", "berry", "melon", "kiwi", "lime", "fig", "date",
                "olive", "apricot", "coconut", "papaya", "carrot", "tomato", "potato",
                "onion", "garlic", "ginger", "cucumber", "pepper", "broccoli", "spinach"
            };

            Random random = new Random();

            HashSet<string> randomWords = new HashSet<string>();

            int count = random.Next(wordArray.Length);

            while (randomWords.Count < count)
            {
                for (int i = 0; i < count; i++)
                {
                    int randomIndex = random.Next(wordArray.Length);

                    randomWords.Add(wordArray[randomIndex]);
                }
            }

            return randomWords;
        }
    }
}
