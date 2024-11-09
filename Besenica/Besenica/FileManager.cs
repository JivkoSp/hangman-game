
namespace Besenica
{
    internal static class FileManager
    {
        public static void CreateAndInitializeFileWithWords(string filePath = "words.txt")
        {
            var words = WordGenerator.GenerateRandomWords();

            File.WriteAllLines(filePath, words);
        }

        private static void CreateGameScoreFile(string filePath)
        {
            File.WriteAllText(filePath, "Word | Guessed | Time");
        }

        public static void WriteGameRoundDataToFile(string word, bool guessed, string filePath = "game_scores.txt")
        {
            if(!File.Exists(filePath))
            {
                CreateGameScoreFile(filePath);
            }

            File.AppendAllText(filePath, $"\n{word} | {guessed} | {DateTime.Now}");
        }

        public static string GetRandomWordFromFile(string filePath)
        {
            string[] words = File.ReadAllLines(filePath);

            if (words.Length == 0)
            {
                return "No words found in the file.";
            }

            Random random = new Random();

            int randomIndex = random.Next(words.Length);

            return words[randomIndex];
        }
    }
}
