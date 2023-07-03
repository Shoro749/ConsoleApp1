using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Оголосити одновимірний (5 елементів) масив з назвою
                A i двовимірний масив (3 рядки, 4 стовпці) дробових чисел
                з назвою B. Заповнити одновимірний масив А числами,
                введеними з клавіатури користувачем, а двовимірний
                масив В — випадковими числами за допомогою циклів.
                Вивести на екран значення масивів: масиву А — в один
                рядок, масиву В — у вигляді матриці. Знайти у даних
                масивах загальний максимальний елемент, мінімальний
                елемент, загальну суму усіх елементів, загальний добуток
                усіх елементів, суму парних елементів масиву А, суму
                непарних стовпців масиву В.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;
                Random rnd = new Random();

                int[] A = new int[5];
                int[,] B = new int[3, 4];
                int maxB = int.MinValue, minB = int.MaxValue, sumA = 0, dA = 1, sumB = 0, dB = 1, evenSum = 0, oddSum = 0;

                for (int i = 0; i < A.Length; i++)
                {
                    Console.Write($"{i+1}) Введіть число: ");
                    A[i] = Convert.ToInt32(Console.ReadLine());
                    sumA += A[i];
                    dA *= A[i];
                    if (A[i] % 2 == 0) { evenSum += A[i]; }
                }

                Console.WriteLine("\nМасив А:");
                for (int i = 0; i < A.Length; i++)
                {
                    Console.Write(A[i] + " ");
                }

                Console.WriteLine("\n\nМасив В:");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 4; j++) 
                    {
                        B[i, j] = rnd.Next() % 100;
                        Console.Write(B[i, j] + " ");
                        if (maxB < B[i, j]) { maxB = B[i, j]; }
                        if (minB > B[i, j]) { minB = B[i, j]; }
                        if (B[i, j] % 2 == 1) { oddSum += B[i, j]; }
                        sumB += B[i, j];
                        dB *= B[i, j];
                    }
                    Console.Write("\n");
                }

                int maxA = A.Max();
                int minA = A.Min();
                int max, min;

                if (maxA > maxB) { max = maxA; }
                else { max = maxB; }
                if (minA > minB) {  min = minB; }
                else { min = minA; }
                int sum = sumA + sumB;
                int d = dA * dB;

                Console.WriteLine($"\n\nМаксимум: {max}; \nМінімум: {min}; \nЗагальна сума: {sum}; " +
                    $"\nЗагальний добуток: {d}; \nСума парних чисел масиву А: {evenSum};\nСума " +
                    $"непарних чисел масиву В: {oddSum};");
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