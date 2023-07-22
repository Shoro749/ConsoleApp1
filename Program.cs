using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*В одному з попередніх практичних завдань ви створювали клас «Співробітник». Додайте до вже створеного класу
                інформацію про заробітну плату працівника. Виконайте
                навантаження + (для збільшення зарплати на вказану кількість), – (для зменшення зарплати на вказану кількість), ==
                (перевірка на рівність зарплат працівників), < і > (перевірка
                на меншу чи більшу кількість зарплат працівників), != і
                Equals. Використовуйте механізм властивостей полів класу.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                var v = new Employee("ПІБ", "2000", 0981234567, "ПІБ@gmail.com", "Cleaner", "Прибирання", 10000);
                var q = new Employee("Bob", "2001", 0987654321, "Bob@gmail.com", "Programmer", "Писати код", 25000);

                while (true)
                {
                    bool Exit = false;
                    int select;
                    Console.WriteLine($"\n1) Вивести інформацію");
                    Console.WriteLine($"2) Змінити ПІБ");
                    Console.WriteLine($"3) Змінити дату народження");
                    Console.WriteLine($"4) Змінити номер телефону");
                    Console.WriteLine($"5) Змінити емейл");
                    Console.WriteLine($"6) Змінити посаду");
                    Console.WriteLine($"7) Змінити опис службових обов’язків");
                    Console.WriteLine($"8) Змінити зарплату працівника");
                    Console.WriteLine($"9) Перевіриити зарплати працівників");
                    Console.WriteLine($"10) Вихід");
                    Console.Write("Введіть вибір: ");
                    select = Convert.ToInt32(Console.ReadLine());

                    switch (select)
                    {
                        case 1:
                            v.getInfo();
                            q.getInfo();
                            break;

                        case 2:
                            Console.WriteLine("Введіть ПІБ:");
                            v.NSM_ = Convert.ToString(Console.ReadLine());
                            break;

                        case 3:
                            Console.WriteLine("Введіть нову дату народження:");
                            string birthday = Convert.ToString(Console.ReadLine());
                            v.setBirthday(birthday);
                            break;

                        case 4:
                            Console.WriteLine("Введіть новий номер телефону:");
                            int tel = Convert.ToInt32(Console.ReadLine());
                            v.setTel(tel);
                            break;

                        case 5:
                            Console.WriteLine("Введіть новий емейл:");
                            string email = Convert.ToString(Console.ReadLine());
                            v.setEmail(email);
                            break;

                        case 6:
                            Console.WriteLine("Введіть нову посаду:");
                            string position = Convert.ToString(Console.ReadLine());
                            v.setPosition(position);
                            break;

                        case 7:
                            Console.WriteLine("Введіть новий опис службових обов’язків:");
                            string JobDescription = Convert.ToString(Console.ReadLine());
                            v.setJobDescription(JobDescription);
                            break;

                        case 8:
                            Console.Write("\nВведіть + щоб підвищити зарплату, або - зменшити: ");
                            string _select = Convert.ToString(Console.ReadLine());
                            if (_select == "+")
                            {
                                Console.Write("\nВведіть на скільки збільшити зарплату: ");
                                int sum = Convert.ToInt32(Console.ReadLine());
                                v.Salary = v.Salary + sum;
                            }
                            else if (_select == "-")
                            {
                                Console.Write("\nВведіть на скільки зменшити зарплату: ");
                                int sum = Convert.ToInt32(Console.ReadLine());
                                v.Salary = v.Salary - sum;
                            }
                            else
                            {
                                throw new Exception("Неправильний вибір!");
                            }
                            break;

                        case 9:
                            Console.Write("\nВведіть 1 щоб перевірити зарплату працівників на рівність,\nабо 2 більше/менше: ");
                            select = Convert.ToInt32(Console.ReadLine());
                            if (select == 1)
                            {
                                if (v.Salary == q.Salary) { Console.WriteLine("\nЗарплата однакова!"); }
                                else { Console.WriteLine("\nЗарплата не однакова!"); }
                            }
                            else if (select == 2)
                            {
                                if (v.Salary > q.Salary) { Console.WriteLine($"\nЗарплата {q.NSM_} менша!"); }
                                else { Console.WriteLine($"\nЗарплата {q.NSM_} більша!"); }
                            }
                            else { throw new Exception("Неправильний вибір!"); }
                            break;

                        case 10:
                            Exit = true;
                            break;
                    }

                    if (Exit == true)
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