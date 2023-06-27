using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Користувач з клавіатури вводить шестизначне число.
                Необхідно перевернути число і відобразити результат.
                Наприклад, якщо введено 341256, результат 652143.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                Console.Write("Введіть шестизначне число: ");
                int num = Convert.ToInt32(Console.ReadLine());
                
                if (num < 100000 && num > 999999) 
                {
                    throw new Exception("Число повинно бути шестизначним!");
                }

                string sNum = num.ToString();
                int[] numbers = new int[6];

                for (int i = sNum.Length-1; i > -1; i--)
                {
                    Console.Write(sNum[i]);
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