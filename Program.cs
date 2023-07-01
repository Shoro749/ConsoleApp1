using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Розробіть додаток, який знаходитиме мінімальне і
                максимальне значення у двовимірному масиві.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;
                Random rnd = new Random();

                int[,] arr = new int[3, 3];
                int max = int.MinValue, min = int.MaxValue;

                Console.Write("Array:\n");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        arr[i, j] = rnd.Next() % 100;
                        Console.Write($"{arr[i, j]} ");
                        if (max < arr[i, j])
                        {
                            max = arr[i, j];
                        }
                        if (min > arr[i, j])
                        {
                            min = arr[i, j];
                        }
                    }
                    Console.Write("\n");
                }

                Console.WriteLine($"\nMax value: {max}\nMin value: {min}");
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