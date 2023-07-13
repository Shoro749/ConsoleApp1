using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Створіть клас «Веб-сайт». Необхідно зберігати у
                полях класу: назву сайту, шлях до сайту, опис сайту,
                ip-адресу сайту. Реалізуйте методи класу для введення
                даних, виведення даних. Реалізуйте доступ до окремих
                полів через методи класу.*/

                var v = new Website("YouTube", "www.youtube.com", "Website for watching video!", "8.8.8.8");

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                while (true)
                {
                    bool Exit = false;
                    Console.WriteLine("\n1) Змінити назву сайта");
                    Console.WriteLine("2) Змінити шлях до сайту");
                    Console.WriteLine("3) Змінити опис сайту");
                    Console.WriteLine("4) Змінити ip-адресу сайту");
                    Console.WriteLine("5) Показати інформацію про сайт");
                    Console.WriteLine("6) Вихід");
                    Console.Write("Введіть свій вибір: ");
                    int select = Convert.ToInt32(Console.ReadLine());

                    switch (select)
                    {
                        case 1:
                            Console.Write("\nВведіть нову назву сайту: ");
                            v.Name = Convert.ToString(Console.ReadLine()); 
                            break;

                        case 2:
                            Console.Write("\nВведіть новий шлях до сайту: ");
                            v.Way = Convert.ToString(Console.ReadLine());
                            break;

                        case 3:
                            Console.Write("\nВведіть новий опис сайту: ");
                            v.Description = Convert.ToString(Console.ReadLine());
                            break;

                        case 4:
                            Console.Write("\nВведіть нову ip-адресу сайту: ");
                            v.IP = Convert.ToString(Console.ReadLine());
                            break;

                        case 5:
                            v.ShowInfo();
                            break;

                        case 6:
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