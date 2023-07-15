using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Створіть гру «Вгадай число». Комп’ютер вгадує число,
                яке загадав користувач у вказаному діапазоні. Використовуйте механізми просторів імен.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;
                Random rnd = new Random();

                Console.WriteLine("Загадайте число в межах (1-10)\nНажміть Enter щоб продовжити\n");
                Console.ReadKey();

                while (true)
                {

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