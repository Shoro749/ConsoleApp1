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

                Console.Write("Введіть число: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num > 0 && num < 100)
                {
                    if (num % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else
                    {
                        if (num % 5 == 0)
                        {
                            Console.WriteLine("Buzz");
                        }
                        else
                        {
                            Console.WriteLine(num);
                        }
                    }
                }
                else
                {
                    throw new Exception("Число не в діапазоні від 1 до 100!");
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
