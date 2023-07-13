using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Створіть клас «Магазин». Необхідно зберігати у полях
                класу: назву магазину, адреса, опис профілю магазину,
                контактний телефон, email. Реалізуйте методи класу для
                введення даних, виведення даних. Реалізуйте доступ до
                окремих полів через методи класу.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                var v = new Shop("ATБ", "s.Taras`s Shevchenko`s", "Тут продається все", 0986782166, "АТБ@gmail.com");

                while (true)
                {
                    bool Exit = false;
                    Console.WriteLine("\n1) Змінити назву магазину");
                    Console.WriteLine("2) Змінити адресу");
                    Console.WriteLine("3) Змінити опис профілю магазину");
                    Console.WriteLine("4) Змінити контактний номер магазину");
                    Console.WriteLine("5) Змінити еmail магазина");
                    Console.WriteLine("6) Показати інформацію про магазин");
                    Console.WriteLine("7) Вихід");
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
                            Console.WriteLine($"\nНазва журналу: {v.Name}\nРік випуску: {v.Address}" +
                                $"\nОпис: {v.Description}\nКонтактний номер: {v.Telephone}\nЕmail: {v.Email}\n");
                            break;

                        case 7:
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