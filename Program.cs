using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Створіть додаток для підрахунку кількості входжень
                підрядка в рядок. Користувач вводить вихідний рядок і
                слово для пошуку. Додаток відображає результат пошуку.
                Наприклад:
                користувач ввів: Why she had to go. I don't know, she
                wouldn't say;
                підрядок для пошуку: she;
                результат пошуку: 2.*/
                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                Console.Write("Введіть речення: ");
                string ?str = Convert.ToString(Console.ReadLine());
                Console.Write("Введіть підрядок для пошуку: ");
                string? str2 = Convert.ToString(Console.ReadLine());

                str = str.Trim();
                string[] separation = str.Split(str2);
                Console.Write($"Результат пошуку: {separation.Length - 1}");
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