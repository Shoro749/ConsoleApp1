using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Напишіть метод, який фільтрує масив за переданими
                параметрами. Метод приймає параметри: оригінальний_масив, масив_з_даними_для_фільтрації.
                Метод повертає оригінальний масив без елементів,
                які знаходяться у масиві для фільтрації.
                Наприклад:
                1 2 6 -1 88 7 6 — оригінальний масив
                6 88 7 — масив для фільтрації
                1 2 -1 — результат роботи методу*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;
                Random rnd = new Random();

                int[] arr = new int[8];
                int[] filter = new int[3];

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rnd.Next(0, 100);
                    Console.Write(arr[i] + " ");
                }

                Console.Write("\n");

                for (int i = 0; i < filter.Length; i++) 
                {
                    Console.Write($"\n{i+1}) Введіть число для фільтра: ");
                    filter[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.Write("\n");

                var v = new Filter();
                v.filter(arr, filter);
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