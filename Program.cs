using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    internal class Program
    {
        public static string ReverseStr(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static void Main(string[] args)
        {
            try
            {
                /*Користувач вводить речення з клавіатури. Вам необхідно перевернути кожне слово речення і вивести результат
                на екрані.
                Наприклад:
                користувач ввів: sun cat dogs cup tea;
                після перевороту: nus tac sgod puc aet.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                Console.Write("Введіть речення: ");
                string ?str = Convert.ToString(Console.ReadLine());
                str = str.Trim();
                string[] words = str.Split(' ');

                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = ReverseStr(words[i]);
                }

                foreach (string word in words)
                {
                    Console.WriteLine(word);
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red; 
                Console.WriteLine($"Помилка! {ex.Message}");
            }
            Console.ReadKey();
            Console.ResetColor();
        }
    }
}