using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Створіть додаток, який відображає кількість значень у
                масиві менше заданого параметра користувачем. Наприклад,
                кількість значень менших, ніж 7 (7 введено користувачем
                з клавіатури).*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;
                Random rnd = new Random();

                int[] arr = new int[10];
                int n = 0;

                Console.Write("Введіть число: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.Write("Масив: ");

                for (int i = 0; i < 10; i++)
                {
                    arr[i] = rnd.Next() % 100;
                    Console.Write($"{arr[i]} ");
                    if (arr[i] < num)
                    {
                        n++;
                    }
                }

                Console.WriteLine($"\n\nКількість чисел менше {num}: {n}!");
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