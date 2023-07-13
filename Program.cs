using ConsoleApp1.Domain.Model;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /* Напишіть метод, який відображає квадрат із деякого
                символу. Метод приймає довжину сторони квадрата як
                параметр, — символ.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                Console.Write("Введіть довжину квадрата: ");
                int length = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введіть довжину квадрата: ");
                string symbol = Convert.ToString(Console.ReadLine());

                var v = new Class(length, symbol);
                v.Square();
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