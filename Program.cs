using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Користувач вводить з клавіатури три числа. Необхідно
                підрахувати кількість разів послідовності цих трьох чисел
                в масиві.
                Наприклад:
                користувач ввів: 7 6 5;
                масив: 7 6 5 3 4 7 6 5 8 7 6 5;
                кількість повторень послідовності: 3.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                int[] arr = new int[10] { 7, 6, 5, 3 ,4, 7, 6, 5, 3, 4};
                int b = 0, s = 0;

                Console.Write("Введіть перше число: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введіть другу число: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введіть третє число: ");
                int num3 = Convert.ToInt32(Console.ReadLine());

                foreach(var item in arr)
                {
                    if (item == num)
                    {
                        b = 1;
                    }
                    if (item == num2)
                    {
                        if (b == 1)
                        {
                            b = 2;
                        }
                        else
                        {
                            b = 0;
                        }
                    }
                    if (item == num3)
                    {
                        if (b == 2)
                        {
                            s++;
                        }
                        else
                        {
                            b = 0;
                        }
                    }
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Кількість повторень: {s}");
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