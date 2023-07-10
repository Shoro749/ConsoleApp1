using System.Globalization;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Користувач з клавіатури вводить певний текст. Додаток
                має змінювати регістр першої літери кожного речення на
                літеру у верхньому регістрі.
                Наприклад, якщо користувач ввів: today is a good
                day for walking. i will try to walk near the sea.
                Результат роботи додатку: Today is a good day for
                walking. I will try to walk near the sea.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;
                Console.WriteLine("Введіть текст:");
                string input = Console.ReadLine();

                string capitalized = CapitalizeFirstLetter(input);
                Console.WriteLine("Результат: " + capitalized);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red; 
                Console.WriteLine($"Помилка! {ex.Message}");
            }
            Console.ReadKey();
            Console.ResetColor();
        }

        static string CapitalizeFirstLetter(string input)
        {
            string[] sentences = input.Split('.');

            for (int i = 0; i < sentences.Length; i++)
            {
                string sentence = sentences[i].Trim();

                if (!string.IsNullOrEmpty(sentence))
                {
                    string firstLetter = sentence.Substring(0, 1);
                    string restOfSentence = sentence.Substring(1);

                    sentences[i] = firstLetter.ToUpper() + restOfSentence;
                }
            }

            return string.Join(". ", sentences);
        }
    }
}