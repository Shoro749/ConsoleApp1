using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Користувач вводить з клавіатури чотири цифри. Необхідно створити число, яке містить ці цифри. 
            Наприклад, якщо з клавіатури введено 1, 5, 7, 8 тоді потрібно
            сформувати число 1578.*/
            try
            {
                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                Console.Write("Введіть перше число: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введіть друге число: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введіть третэ число: ");
                int num3 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введіть четверте число: ");
                int num4 = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Результат: {(num1 * 1000)+(num2 * 100)+(num3 * 10)+(num4)}");
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