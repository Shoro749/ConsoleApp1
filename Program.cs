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

                const int size = 5;
                int[] numbers = new int[size];
                int max = int.MinValue, min = int.MaxValue, sum = 0, d = 1;

                for (int i = 0; i < size; i++)
                {
                    Console.Write($"{i+1}) Введіть число: ");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                    if (max < numbers[i])
                    {
                        max = numbers[i];
                    }
                    if (min > numbers[i])
                    {
                        min = numbers[i];
                    }
                    sum += numbers[i];
                    d *= numbers[i];
                }

                Console.WriteLine($"Сума: {sum};\nДобуток: {d};\nМінімальне: {min};\nМаксимальне: {max};");
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