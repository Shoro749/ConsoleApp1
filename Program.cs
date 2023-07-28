using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*В одному з попередніх практичних завдань ви створювали клас «Журнал». Додайте до вже створеного класу
                інформацію про кількість працівників. Виконайте навантаження + (для збільшення кількості працівників на вказану кількість), — (для зменшення кількості працівників
                на вказану кількість), == (перевірка на рівність кількості
                працівників), < і > (перевірка на меншу чи більшу кількість працівників), != і Equals. Використовуйте механізм
                властивостей полів класу.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;
                Magazine v = new Magazine("GoodMorning", 2016, "Цей журнал розповідає про новини в світі!", "0986782166", "goodmorning@gmail.com", 12);

                while (true)
                {
                    bool Exit = false;
                    Console.WriteLine("\n1) Змінити назву журналу");
                    Console.WriteLine("2) Змінити рік випуску");
                    Console.WriteLine("3) Змінити опис журналу");
                    Console.WriteLine("4) Змінити контактний номер журналу");
                    Console.WriteLine("5) Змінити еmail журналу");
                    Console.WriteLine("6) Змінити кількість працівників");
                    Console.WriteLine("7) Порівняти кількість працівників");
                    Console.WriteLine("8) Показати інформацію про журнал");
                    Console.WriteLine("9) Вихід");
                    Console.Write("Введіть свій вибір: ");
                    int select = Convert.ToInt32(Console.ReadLine());

                    switch (select)
                    {
                        case 1:
                            Console.Write("\nВведіть нову назву журналу: ");
                            v.Name = Convert.ToString(Console.ReadLine());
                            break;

                        case 2:
                            Console.Write("\nВведіть новий рік випуску: ");
                            v.Year = Convert.ToInt32(Console.ReadLine());
                            break;

                        case 3:
                            Console.Write("\nВведіть новий опис журналу: ");
                            v.Description = Convert.ToString(Console.ReadLine());
                            break;

                        case 4:
                            Console.Write("\nВведіть новий контактний номер: ");
                            v.Telephone = Convert.ToString(Console.ReadLine());
                            break;

                        case 5:
                            Console.Write("\nВведіть новий еmail: ");
                            v.Email = Convert.ToString(Console.ReadLine());
                            break;

                        case 6:
                            Console.Write("\nВведіть 1 щоб збільшити, або 2 щоб зменшити кількість працівників: ");
                            select = Convert.ToInt32(Console.ReadLine());
                            int num;

                            if (select == 1)
                            {
                                Console.Write("\nВведіть число: ");
                                num = Convert.ToInt32(Console.ReadLine());
                                v.Employees = v.Employees + num;
                            }
                            else
                            {
                                Console.Write("\nВведіть число: ");
                                num = Convert.ToInt32(Console.ReadLine());
                                v.Employees = v.Employees - num;
                            }
                            break;

                        case 7:
                            Console.Write("\nВведіть число: ");
                            select = Convert.ToInt32(Console.ReadLine());

                            if (v.Employees == select)
                            {
                                Console.WriteLine($"\nЧисло працівників дорінює вашому числу!");
                            }
                            else if (v.Employees > select)
                            {
                                Console.WriteLine($"\nЧисло працівників більша ніж {select}!");
                            }
                            else
                            {
                                Console.WriteLine($"\nЧисло працівників менша ніж {select}!");
                            }
                            break;

                        case 8:
                            Console.WriteLine($"\nНазва журналу: {v.Name}\nРік випуску: {v.Year}" +
                                $"\nОпис: {v.Description}\nКонтактний номер: {v.Telephone}\nЕmail: {v.Email}\n" +
                                $"Кількість працівників: {v.Employees}\n");
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