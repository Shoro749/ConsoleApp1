using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Користувач вводить рядок із клавіатури. Необхідно
                зашифрувати цей рядок, використовуючи шифр Цезаря.*//////////////////////

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                string? ABC = "abcdefghijklmnopqrstuvwxyz";
                Console.Write("Введіть текст: ");
                string ?str = Convert.ToString(Console.Read());


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