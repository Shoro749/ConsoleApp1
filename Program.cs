using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Створіть класи для створення парних чисел, непарних
                чисел, простих чисел, чисел Фібоначчі. Використовуйте
                механізми просторів імен.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                int[] arr = new int[10];

                Console.WriteLine("1) Створити парні числа");
                Console.WriteLine("2) Створити не парні числа");
                Console.WriteLine("3) Створити прості числа");
                Console.WriteLine("4) Створити числа Фібоначчі");
                Console.Write("Введіть свій вибір: ");
                int select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        Even.Class @class1 = new Even.Class();
                        @class1.Numbers(arr);
                        Console.Write("\n");
                        foreach (var item in arr) Console.Write(item + " ");
                        break;

                    case 2:
                        NotEven.Class @class2 = new NotEven.Class();
                        @class2.Numbers(arr);
                        Console.Write("\n");
                        foreach (var item in arr) Console.Write(item + " ");
                        break;

                    case 3:
                        PrimeNumbers.Class @class3 = new PrimeNumbers.Class();
                        @class3.Numbers(arr);
                        Console.Write("\n");
                        foreach (var item in arr) Console.Write(item + " ");
                        break;

                    case 4:
                        FibonacciNumbers.Class @class4 = new FibonacciNumbers.Class();
                        @class4.Numbers(arr);
                        Console.Write("\n");
                        foreach (var item in arr) Console.Write(item + " ");
                        break;
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