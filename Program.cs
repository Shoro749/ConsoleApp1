using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                Console.Write("Введіть перше число: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введіть друге число: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                if (num1 > num2)
                {
                    int temp = num1;
                    num1 = num2;
                    num2 = temp;
                }

                for (int i = num1; i < num2; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($"{i} ");
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