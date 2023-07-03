using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Дано двовимірний масив розміром 5×5, заповнений випадковими числами з діапазону від –100 до 100.
                Визначити суму елементів масиву, розташованих між
                мінімальним і максимальним елементами.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;
                Random rnd = new Random();

                int[,] arr = new int[5, 5];
                int sum = 0, min = int.MaxValue, max = int.MinValue;

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        arr[i, j] = rnd.Next(-100, 100);
                        Console.Write(arr[i, j] + " ");
                        if (max < arr[i, j]) { max = arr[i, j]; }
                        if (min > arr[i, j]) { min = arr[i, j]; }
                        sum += arr[i, j];
                    }
                    Console.Write("\n");
                }
                sum -= max;
                sum -= min;

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"\nСума чисел в діапазоні від {min} до {max}: {sum}");
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