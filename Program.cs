using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Створіть клас «Журнал». Необхідно зберігати у полях
                класу: назву журналу, рік заснування, опис журналу,
                контактний телефон, email. Реалізуйте методи класу для
                введення даних, виведення даних. Реалізуйте доступ до
                окремих полів через методи класу.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                var v = new Magazine("GoodMorning", 2016, "Цей журнал розповідає про новини в світі!", "0986782166", "goodmorning@gmail.com");

                while (true)
                {
                    bool Exit = false;
                    Console.WriteLine("\n1) Змінити назву журналу");
                    Console.WriteLine("2) Змінити рік випуску");
                    Console.WriteLine("3) Змінити опис журналу");
                    Console.WriteLine("4) Змінити контактний номер журналу");
                    Console.WriteLine("5) Змінити еmail журналу");
                    Console.WriteLine("6) Показати інформацію про журнал");
                    Console.WriteLine("7) Вихід");
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
                            Console.WriteLine($"\nНазва журналу: {v.Name}\nРік випуску: {v.Year}" +
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