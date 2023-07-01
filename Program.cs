using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Створіть додаток, який відображає кількість парних,
                непарних, унікальних елементів масиву.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                int[] arr = new int[10] { 1, 2, 2, 5, 6, 10, 7, 8, 9, 1 };
                int p = 0, n = 0, u = 0;

                for (int i = 0; i < 10; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        p++;
                    }
                    if (arr[i] % 2 != 0)
                    {
                        n++;
                    }
                }
                u = arr.Distinct().Count();
                Console.WriteLine($"Парні: {p}\nНепарні: {n}\nУнікальні: {u}");
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