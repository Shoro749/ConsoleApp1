using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Реалізуйте клас Матриця». Реалізуйте конструктори і
                методи класу для введення і виведення даних, підрахунку
                максимуму і мінімуму. Використовуйте механізм навантаження методів.*//////////////////////////////

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;
                Random rnd = new Random();

                int[,] arr = new int[3,3];
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        arr[i,j] = rnd.Next(0, 100);
                        Console.Write(arr[i,j] + " ");
                    }
                    Console.Write("\n");
                }

                var v = new Matrix(arr);

                while (true)
                {
                    bool Exit = false;
                    Console.WriteLine("1) Показати матрицю");
                    Console.WriteLine("2) Переписати матрицю");
                    Console.WriteLine("3) Найти мінімум");
                    Console.WriteLine("4) Найти максимум");
                    Console.WriteLine("5) Вихід");
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
                            v.getMin();
                            break;

                        case 4:
                            v.getMax();
                            break;

                        case 5:
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