using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Напишіть метод, який перевіряє чи є число числом
                Фібоначчі. Число передається як параметр. Якщо число
                просте, потрібно повернути з методу true, інакше — false*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                Console.Write("Введіть число: ");
                int num = Convert.ToInt32(Console.ReadLine());

                var v = new Class(num);
                Console.Write(v.Check());
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