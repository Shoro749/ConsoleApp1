using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*В одному з попередніх практичних завдань ви створювали клас «Матриця». Виконайте перевантаження +
                (для додавання матриць), – (для віднімання матриць). *
                (множення матриць одна на одну, множення матриці на
                число), == (перевірка матриць на рівність), != і Equals.
                Використовуйте механізм властивостей полів класу і механізм індексаторів.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;
                Random rnd = new Random();

                int[,] arr = new int[3, 3];
                int[,] arr1 = new int[3, 3];

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        arr[i, j] = rnd.Next(0, 100);
                        Console.Write(arr[i, j] + " ");
                    }
                    Console.Write("\n");
                }

                Console.Write("\n");

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        arr1[i, j] = rnd.Next(0, 100);
                        Console.Write(arr1[i, j] + " ");
                    }
                    Console.Write("\n");
                }

                var v = new Matrix(arr);
                var q = new Matrix(arr1);

                while (true)
                {
                    bool Exit = false;
                    Console.WriteLine("\n1) Показати матрицю");
                    Console.WriteLine("2) Переписати матрицю");
                    Console.WriteLine("3) Найти мінімум");
                    Console.WriteLine("4) Найти максимум");
                    Console.WriteLine("5) Додати матриці");
                    Console.WriteLine("6) Відняти матриці");
                    Console.WriteLine("7) Множення матриці");
                    Console.WriteLine("8) Порівняти матриці");
                    Console.WriteLine("9) Вихід");
                    Console.Write("Введіть свій вибір: ");
                    int select = Convert.ToInt32(Console.ReadLine());

                    switch (select)
                    {
                        case 1:
                            v.ShowMatrix();
                            break;

                        case 2:
                            v.WriteMatrix();
                            break;

                        case 3:
                            Console.WriteLine("\nМінімум: " + v.getM());
                            break;

                        case 4:
                            Console.WriteLine("\nМаксимум: " + v.getM(arr));
                            break;

                        case 5:
                            Console.WriteLine("Результат: ");
                            Matrix new_matrix = new Matrix();
                            new_matrix = v + q;
                            new_matrix.ShowMatrix();
                            break;

                        case 6:
                            Console.WriteLine("Результат: ");
                            Matrix n_matrix = new Matrix();
                            n_matrix = v - q;
                            n_matrix.ShowMatrix();
                            break;

                        case 7:
                            Console.WriteLine("Результат: ");
                            Matrix nw_matrix = new Matrix();
                            nw_matrix = v * q;
                            nw_matrix.ShowMatrix();
                            break;

                        case 8:
                            if (v == q) { Console.WriteLine("\nМатриці однакові!"); }
                            else { Console.WriteLine("\nМатриці не однакові!"); }
                            break;

                        case 9:
                            Exit = true;
                            break;
                    }

                    if (Exit)
                    {
                        break;
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