using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Lesson
{
    public class Program
    {
        public static void Main()  // точка входа в программу, программа стартует с этой функции (метода)
        {
            Console.OutputEncoding = Encoding.UTF8;

            const int wordsNumber = 5;
            const string lineSymbol = "_";
            var attemptsCounter = 0;
            var words = new string[wordsNumber] { "Cat", "dog", "phone", "camel", "computer" };

            var rnd = new Random();
            var secretWord = "hello";//words[rnd.Next(words.Length - 1)];
            var letters = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                letters.Append(lineSymbol);
            }

            while (true)
            {
                if (letters.ToString() == secretWord)
                {
                    Console.WriteLine($"You guessed word: {secretWord}. Attempts: {attemptsCounter}");
                    break;
                }

                Console.WriteLine(letters);
                Console.WriteLine("Enter your letter: ");
                var letter = Console.ReadLine()?.Trim();

                try
                {
                    // заменить эти проверки регуляркой которая проверить строку: один символ который является буквой
                    if (string.IsNullOrEmpty(letter) || letter.Length > 1)
                        throw new Exception("Incorrect letter!");

                    attemptsCounter++;

                    for (int i = 0; i < secretWord.Length; i++)
                    {
                        if (letter.ToLower() == secretWord[i].ToString())
                        {
                            letters[i] = Convert.ToChar(letter);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}