using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Користувач вводить з клавіатури межі числового діапазону. Потрібно показати усі числа Фібоначчі з цього
                діапазону. Числа Фібоначчі — елементи числової послідовності, у якій перші два числа дорівнюють 0 і 1, а кожне
                наступне число дорівнює сумі двох попередніх чисел.
                Наприклад, якщо вказано діапазон 0–20, результат буде:
                0, 1, 1, 2, 3, 5, 8, 13.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                int num1 = 0, num2 = 1;

                Console.Write("Введіть діапазон: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num < 1)
                {
                    throw new Exception("Діапазон мяє бути хоча б 2!");
                }

                Console.Write($"{num1} {num2}");

                while (true)
                {
                    num1 = num1 + num2;
                    num2 = num1 + num2;

                    if (num1 > num || num2 > num)
                    {
                        break;
                    }

                    Console.Write($" {num1}");
                    Console.Write($" {num2}");
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