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

                int[] arr = new int[10];
                int attempt = 0;

                Console.WriteLine("Загадайте число в межах (1-10)\nНажміть Enter щоб продовжити\n");
                Console.ReadKey();

                Attempt.Class _class = new Attempt.Class();

                while (true)
                {
                    if (_class.guessing(arr, attempt) == true)
                    {
                        break;
                    }

                    attempt++;

                    if (attempt == 10)
                    {
                        throw new Exception("Ви загадали число за межами!");
                    }
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