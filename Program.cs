using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Дано 2 масиви розмірності M і N відповідно.
                Необхідно переписати до третього масиву загальні
                елементи перших двох масивів без повторень.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                int temp = 0;
                int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                int[] arr2 = new int[7] { 1, 12, 3, 14, 5, 16, 7 };
                int[] arr3 = new int[7];

                Console.WriteLine("Масив 1");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write($"{arr[i]} ");
                }

                Console.WriteLine("\nМасив 2");
                for (int i = 0; i < arr2.Length; i++)
                {
                    Console.Write($"{arr[i]} ");
                }

                for (int i = 0; i < arr3.Length ; i++)
                {
                    for (int j = 0; j < arr3.Length; j++)
                    {
                        if (arr[i] == arr2[j])
                        {
                            arr3[temp] = arr[i];
                            temp++;
                        }
                    }
                }
                int[] arr4 = arr3.Distinct().ToArray();

                Console.Write("\n\nРезультат: ");
                foreach (var item in arr3)
                {
                    if (item == 0)
                    {
                        break;
                    }
                    Console.Write($"{item} ");
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