using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Напишіть метод, який сортує масив за зменшенням
                або зростанням, залежно від вибору користувача.
                Алгоритм сортування реалізуйте самостійно. Наприклад, може бути реалізоване сортування методом
                перестановок*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;
                Random rnd = new Random();

                int[] arr = new int[10];

                Console.Write("Введіть 1 щоб сортувати за збільшенням, або 2 за зменшенням: ");
                int select = Convert.ToInt32(Console.ReadLine());

                if (select > 2 && select < 1) { throw new Exception("Неправильний вибір!"); }

                Console.WriteLine("Масив на початку: ");

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rnd.Next(0, 100);
                    Console.Write(arr[i] + " ");
                }

                Console.WriteLine("\n");

                var v = new SortClass(select);
                v.Sorting(arr);
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