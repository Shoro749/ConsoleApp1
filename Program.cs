using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Створіть клас «Місто». Необхідно зберігати у полях
                класу: назву міста, назву країни, кількість жителів у місті,
                телефонний код міста, назву районів міста. Реалізуйте методи класу для введення даних, виведення даних. Реалізуйте
                доступ до окремих полів через методи класу.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                Console.Write("Введіть назву міста: ");
                string ?city = Convert.ToString(Console.ReadLine());
                Console.Write("Введіть назву країни: ");
                string ?country = Convert.ToString(Console.ReadLine());
                Console.Write("Введіть число населення міста: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введіть телефоний код міста: ");
                int telNum = Convert.ToInt32(Console.ReadLine());

                string[] arr = new string[5];

                for (int i = 0; i < 5; i++)
                {
                    Console.Write($"{i+1}) Введіть назви районів: ");
                    arr[i] = Convert.ToString(Console.ReadLine());
                }

                var v = new City(city, country, num, telNum, arr);

                Console.WriteLine("\n");

                while (true)
                {
                    int select = 0;
                    Console.WriteLine("1) Ввести назву міста");
                    Console.WriteLine("2) Ввести назву країни");
                    Console.WriteLine("3) Ввести число населення");
                    Console.WriteLine("4) Ввести телефонний код міста");
                    Console.WriteLine("5) Ввести назви районів міста");
                    Console.WriteLine("6) Дальше");
                    Console.Write("Введіть вибір: ");
                    select = Convert.ToInt32(Console.ReadLine());

                    if (select == 1)
                    {
                        Console.Write("Введіть нову назву міста: ");
                        v.CityNameInfo = Convert.ToString(Console.ReadLine());
                    }

                    if (select == 2)
                    {
                        Console.Write("Введіть нову назву країни: ");
                        v.CountryNameInfo = Convert.ToString(Console.ReadLine());
                    }

                    if (select == 3)
                    {
                        Console.Write("Введіть нове число населення: ");
                        v.CityNumberInfo = Convert.ToInt32(Console.ReadLine());
                    }

                    if (select == 4)
                    {
                        Console.Write("Введіть новий телефонний код: ");
                        v.TelCodeInfo = Convert.ToInt32(Console.ReadLine());
                    }

                    if(select == 5)
                    {
                        for (int i = 0; i < 5; i++) 
                        {
                            arr[i] = Convert.ToString(Console.ReadLine());
                        }
                        v.DistrictsInfo = arr;
                    }

                    if (select == 6)
                    {
                        break;
                    }

                    if (select < 1 && select > 6)
                    {
                        throw new Exception("Неправилний вибір");
                    }
                }

                Console.WriteLine("\n");

                while (true)
                {
                    int select = 0;
                    Console.WriteLine("1) Вивести назву міста");
                    Console.WriteLine("2) Вивести назву країни");
                    Console.WriteLine("3) Вивести число населення");
                    Console.WriteLine("4) Вивести телефонний код міста");
                    Console.WriteLine("5) Вивести назви районів міста");
                    Console.WriteLine("6) Вийти");
                    Console.Write("Введіть вибір: ");
                    select = Convert.ToInt32(Console.ReadLine());

                    if (select == 1)
                    {
                        Console.Write($"Назва міста: {v.CityNameInfo}\n");
                    }

                    if (select == 2)
                    {
                        Console.Write($"Назву країни: {v.CountryNameInfo}\n");
                    }

                    if (select == 3)
                    {
                        Console.Write($"Число населення: {v.CityNumberInfo}\n");
                    }

                    if (select == 4)
                    {
                        Console.Write($"Введіть новий телефонний код: {v.TelCodeInfo} \n");
                    }

                    if (select == 5)
                    {
                        foreach (var item in v.DistrictsInfo)
                        {
                            Console.WriteLine(item);
                        }
                    }

                    if (select == 6)
                    {
                        break;
                    }
                    
                    if (select < 1 && select > 6)
                    {
                        throw new Exception("Неправилний вибір");
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