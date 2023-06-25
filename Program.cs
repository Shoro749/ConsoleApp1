using System.Globalization;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Користувач вводить шестизначне число. Потім, користувач вводить номери розрядів для заміни цифр.
            Наприклад, якщо користувач ввів 1 і 6 — це означає, що
            треба поміняти місцями першу та шосту цифри.
            Число 723895 має перетворитися на 523897.
            Якщо користувач ввів не шестизначне число, потрібно
            вивести повідомлення про помилку.*/
            try
            {
                int temp;
                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                Console.Write("Введіть шестизначне число: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num < 100000 && num > 999999)
                {
                    throw new Exception("Число повинно бути шестизначним!");
                }

                Console.Write("Введіть число яке хочете поміняти: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введіть друге число яке хочете поміняти: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                if (num1 < 0 && num1 > 6 && num2 < 0 && num1 > 2)
                {
                    throw new Exception("Числа введено не коректно!");
                }

                string numberString = num.ToString();
                int[] array = new int[numberString.Length];

                for (int i = 0; i < numberString.Length; i++)
                {
                    array[i] = int.Parse(numberString[i].ToString());
                }

                temp = array[num1 - 1];
                array[num1 - 1] = array[num2 - 1];
                array[num2 - 1] = temp;
                Console.WriteLine($"Результат: {(array[0] * 100000) + (array[1] * 10000) + (array[2] * 1000) + (array[3] * 100) + (array[4] * 10) + (array[5])}");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Помилка! {ex.Message}");
            }
            finally
            {
                Console.ReadKey();
                Console.ResetColor();
            }
        }
    }
}