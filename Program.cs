using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*В одному з попередніх практичних завдань ви створювали клас «Місто». Виконайте перевантаження + (для
                збільшення кількості жителів на вказану кількість), – (для
                зменшення кількості жителів на вказану кількість), ==
                (перевірка на рівність двох міст за кількістю жителів),
                < і > (перевірка на меншу чи більшу кількість мешканців), != і Equals. Використовуйте механізм властивостей
                полів класу.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                string[] arr = new string[5] { "Район1", "Район2", "Район3", "Район4", "Район5", };
                var v = new City("Місто", "Країна", 25000, 098, arr);
                City q = new City("City", "Country", 16000, 097, arr);

                Console.WriteLine("\n");

                while (true)
                {
                    int select = 0;
                    bool exit = false;
                    Console.WriteLine("1) Вивести назву міста");
                    Console.WriteLine("2) Вивести назву країни");
                    Console.WriteLine("3) Вивести число населення");
                    Console.WriteLine("4) Вивести телефонний код міста");
                    Console.WriteLine("5) Вивести назви районів міста");
                    Console.WriteLine("6) Дальше");
                    Console.Write("Введіть вибір: ");
                    select = Convert.ToInt32(Console.ReadLine());

                    switch (select)
                    {
                        case 1:
                            Console.Write($"Назва міста: {v.CityNameInfo}\n");
                            break;

                        case 2:
                            Console.Write($"Назва міста: {v.CityNameInfo}\n");
                            break;

                        case 3:
                            Console.Write($"Число населення: {v.CityNumberInfo}\n");
                            break;

                        case 4:
                            Console.Write($"Введіть новий телефонний код: {v.TelCodeInfo} \n");
                            break ; 
                        
                        case 5:
                            foreach (var item in v.DistrictsInfo)
                            {
                                Console.WriteLine(item);
                            }
                            break;

                        case 6:
                            exit = true;
                            break;
                    }

                    if (exit) { break; }
                }

                Console.WriteLine("\n");

                while (true)
                {
                    bool exit = false;
                    int select = 0;
                    Console.WriteLine("1) Ввести назву міста");
                    Console.WriteLine("2) Ввести назву країни");
                    Console.WriteLine("3) Ввести число населення");
                    Console.WriteLine("4) Ввести телефонний код міста");
                    Console.WriteLine("5) Ввести назви районів міста");
                    Console.WriteLine("6) Змінити число населення міста");
                    Console.WriteLine("7) Порівняти число населення міста");
                    Console.WriteLine("8) Вийти");
                    Console.Write("Введіть вибір: ");
                    select = Convert.ToInt32(Console.ReadLine());

                    switch (select)
                    {
                        case 1:
                            Console.Write("Введіть нову назву міста: ");
                            v.CityNameInfo = Convert.ToString(Console.ReadLine());
                            break;

                        case 2:
                            Console.Write("Введіть нову назву країни: ");
                            v.CountryNameInfo = Convert.ToString(Console.ReadLine());
                            break;

                        case 3:
                            Console.Write("Введіть нове число населення: ");
                            v.CityNumberInfo = Convert.ToInt32(Console.ReadLine());
                            break;

                        case 4:
                            Console.Write("Введіть новий телефонний код: ");
                            v.TelCodeInfo = Convert.ToInt32(Console.ReadLine());
                            break;

                        case 5:
                            for (int i = 0; i < 5; i++)
                            {
                                arr[i] = Convert.ToString(Console.ReadLine());
                            }
                            v.DistrictsInfo = arr;
                            break;

                        case 6:
                            Console.Write("\nВведіть 1 щоб збільшити, або 2 щоб зменшити: ");
                            select = Convert.ToInt32(Console.ReadLine());
                            int num;

                            if (select == 1)
                            {
                                Console.Write("\nВведіть число: ");
                                num = Convert.ToInt32(Console.ReadLine());
                                v.CityNumberInfo = v.CityNumberInfo + num;
                            }
                            else
                            {
                                Console.Write("\nВведіть число: ");
                                num = Convert.ToInt32(Console.ReadLine());
                                v.CityNumberInfo = v.CityNumberInfo - num;
                            }
                            break;

                        case 7:
                            if (v.CityNumberInfo == q.CityNumberInfo)
                            {
                                Console.WriteLine($"\nЧисло населення {v.CityNameInfo} i {q.CityNameInfo} однакова!");
                            }
                            else if (v.CityNumberInfo > q.CityNumberInfo)
                            {
                                Console.WriteLine($"\nЧисло населення міста {v.CityNameInfo} більша, ніж в місті {q.CityNameInfo}!");
                            }
                            else
                            {
                                Console.WriteLine($"\nЧисло населення міста {v.CityNameInfo} менша, ніж в місті {q.CityNameInfo}!");
                            }
                            break;

                        case 8:
                            exit = true;
                            break;
                    }
                    if (exit) { break; }
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