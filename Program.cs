using System.Security.Claims;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /* Напишіть метод, який повертає добуток чисел у вказаному діапазоні. 
                 * Межі діапазону передаються як параметри.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                Console.Write("Введіть перший діапазон: ");
                int range1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введіть другий діапазон: ");
                int range2 = Convert.ToInt32(Console.ReadLine());

                var v = new Class();
                v.Range1 = range1;
                v.Range2 = range2;

                Console.Write($"Добуток в діапазоні {range1} до {range2}: {v.Dobutok()}");
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