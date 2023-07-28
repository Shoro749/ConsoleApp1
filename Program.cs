using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*В одному з попередніх практичних завдань ви створювали клас «Магазин». Додайте до вже створеного класу
                інформацію про площу магазину. Виконайте навантаження + (для збільшення площі магазину на вказаний
                розмір), — (для зменшення площі магазину на вказаний
                розмір), == (перевірка на рівність площ магазинів), < і >
                (перевірка магазинів менших або більших за площею),
                != і Equals. Використовуйте механізм властивостей
                полів класу.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                Shop q = new Shop("Сільпо", "s.Street", "Тут продається все", 0981111111, "silpo@gmail.com", 60);
                Shop v = new Shop("ATБ", "s.Taras`s Shevchenko`s", "Тут продається все", 0986782166, "АТБ@gmail.com", 75);

                while (true)
                {
                    bool Exit = false;
                    Console.WriteLine("\n1) Змінити назву магазину");
                    Console.WriteLine("2) Змінити адресу");
                    Console.WriteLine("3) Змінити опис профілю магазину");
                    Console.WriteLine("4) Змінити контактний номер магазину");
                    Console.WriteLine("5) Змінити еmail магазина");
                    Console.WriteLine("6) Змінити площу магазину");
                    Console.WriteLine("7) Порівняти площі магазинів");
                    Console.WriteLine("8) Показати інформацію про магазин");
                    Console.WriteLine("9) Вихід");
                    Console.Write("Введіть свій вибір: ");
                    int select = Convert.ToInt32(Console.ReadLine());

                    switch (select)
                    {
                        case 1:
                            Console.Write("\nВведіть нову назву магазина: ");
                            v.Name = Convert.ToString(Console.ReadLine());
                            break;

                        case 2:
                            Console.Write("\nВведіть нову адресу: ");
                            v.Address = Convert.ToString(Console.ReadLine());
                            break;

                        case 3:
                            Console.Write("\nВведіть новий опис магазина: ");
                            v.Description = Convert.ToString(Console.ReadLine());
                            break;

                        case 4:
                            Console.Write("\nВведіть новий контактний номер: +380");
                            v.Telephone = Convert.ToInt64(Console.ReadLine());
                            break;

                        case 5:
                            Console.Write("\nВведіть новий еmail: ");
                            v.Email = Convert.ToString(Console.ReadLine());
                            break;

                        case 6:
                            Console.Write("\nВведіть 1 щоб збільшити, або 2 щоб зменшити площу: ");
                            select = Convert.ToInt32(Console.ReadLine());
                            int num;

                            if (select == 1)
                            {
                                Console.Write("\nВведіть число: ");
                                num = Convert.ToInt32(Console.ReadLine());
                                v.Area = v.Area + num;
                            }
                            else
                            {
                                Console.Write("\nВведіть число: ");
                                num = Convert.ToInt32(Console.ReadLine());
                                v.Area = v.Area - num;
                            }
                            break;

                        case 7:
                            if (v.Area == q.Area)
                            {
                                Console.WriteLine($"\nПлоща магазину {v.Name} дорівнює площі магазину {q.Name}!");
                            }
                            else if (v.Area > q.Area)
                            {
                                Console.WriteLine($"\nПлоща магазину {v.Name} більша ніж площа магазину {q.Name}!");
                            }
                            else
                            {
                                Console.WriteLine($"\nПлоща магазину {v.Name} менша ніж площа магазину {q.Name}!");
                            }
                            break;

                        case 8:
                            Console.WriteLine($"\nНазва журналу: {v.Name}\nРік випуску: {v.Address}" +
                                $"\nОпис: {v.Description}\nКонтактний номер: {v.Telephone}\nЕmail: {v.Email}\n" +
                                $"Площа: {v.Area}\n");
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