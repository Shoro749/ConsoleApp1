using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Напишіть метод, який перевіряє чи є передане число
                «паліндромом». Число передається як параметр. Якщо
                число — паліндром, потрібно повернути з методу true,
                інакше — false.
                Паліндром — число, яке однаково читається в обох
                напрямках (зліва направо та справа наліво).
                Наприклад:
                1221 — паліндром;
                3443 — паліндром;
                7854 — не паліндром.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                Console.Write("Введіть чотирьохзначне число: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num < 1000 || num > 9999)
                {
                    throw new Exception("Введено неправильне число!");
                }

                var v = new Palindrome(num);
                v.Checking(num);
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