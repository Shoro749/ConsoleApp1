using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Створіть додаток, який здійснює операції над матрицями:
                ■ Множення матриці на число;
                ■ Додавання матриць;
                ■ Добуток матриць.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;
                Random rnd = new Random();

                int[,] arr1 = new int[3, 3];
                int[,] arr2 = new int[3, 3];

                Console.WriteLine("Перший масив: ");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        arr1[i, j] = rnd.Next(0, 15);
                        Console.Write(arr1[i, j] + " ");
                    }
                    Console.Write("\n");
                }

                Console.WriteLine("\nДругий масив: ");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        arr2[i, j] = rnd.Next(0, 15) % 100;
                        Console.Write(arr2[i, j] + " ");
                    }
                    Console.Write("\n");
                }

                Console.WriteLine("\n\n1) Помножити матрицю на число");
                Console.WriteLine("2) Додавання матриць");
                Console.WriteLine("3) Добуток матриць");
                Console.Write("Введіть вибір: ");
                int select = Convert.ToInt32(Console.ReadLine());
                if (select < 1 || select > 4) { throw new Exception("Неправильний вибір!"); }

                switch (select)
                {
                    case 1:
                        Console.Write("\nВведіть число: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\nМасив 1: ");
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                arr1[i, j] = arr1[i, j] * num;
                                Console.Write(arr1[i, j] + " ");
                            }
                            Console.Write("\n");
                        }

                        Console.WriteLine("\nМасив 2: ");
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                arr1[i, j] = arr2[i, j] * num;
                                Console.Write(arr2[i, j] + " ");
                            }
                            Console.Write("\n");
                        }
                        break;

                    case 2:
                        int[,] arr3 = new int[3,3];
                        Console.WriteLine("\nСума матриць: ");
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0;j < 3; j++)
                            {
                                arr3[i, j] = arr1[i,j] + arr2[i,j];
                                Console.Write(arr3[i, j] + " ");
                            }
                            Console.Write("\n");
                        }
                        break;

                    case 3:
                        int[,] arr4 = new int[3, 3];
                        Console.WriteLine("\nДобуток матриць: ");
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                arr4[i, j] = arr1[i, j] * arr2[i, j];
                                Console.Write(arr4[i, j] + " ");
                            }
                            Console.Write("\n");
                        }
                        break;
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