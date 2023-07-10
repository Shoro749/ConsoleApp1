using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Створіть додаток, який перевіряє текст на неприпустимі слова. Якщо неприпустиме слово знайдено, воно
                має бути замінено набором символів *. За підсумками
                роботи програми, необхідно показати статистику дій.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                Console.Write("Введіть текст: ");
                string? str = Convert.ToString(Console.ReadLine());
                Console.Write("Введіть неприпустиме слово: ");
                string? notApproved = Convert.ToString(Console.ReadLine());
                string[] words = str.Split(' ', '.', ',', '?', ':', ';', '-', '!');

                foreach (var word in words)
                {
                    if (word.Length > 0)
                    {
                        if (word == notApproved)
                        {
                            for (int i = 0; i < word.Length; i++)
                            {
                                Console.Write("*");  
                            }
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write(word + " ");
                        }
                    }
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