using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Реалізуйте клас «Співробітник». Необхідно зберігати у
                полях класу: ПІБ, дату народження, контактний телефон,
                робочий email, посаду, опис службових обов’язків. Реалізуйте методи класу для введення даних, виведення даних.
                Реалізуйте доступ до окремих полів через методи класу.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                Console.Write("Введіть ПІБ: ");
                string ?NSM = Convert.ToString(Console.ReadLine());
                Console.Write("Введіть дату народження: ");
                string ?birthday = Convert.ToString(Console.ReadLine());
                Console.Write("Введіть номер телефону: ");
                int tel = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введіть робочий email: ");
                string ?email = Convert.ToString(Console.ReadLine());
                Console.Write("Введіть посаду: ");
                string ?position = Convert.ToString(Console.ReadLine());
                Console.Write("Введіть опис службових обов’язків: ");
                string ?JobDescription = Convert.ToString(Console.ReadLine());

                var v = new Employee(NSM, birthday, tel, email, position, JobDescription);
                bool Exit = false;

                while (Exit)
                {
                    int select;
                    Console.WriteLine($"1) Вивести інформацію");
                    Console.WriteLine($"2) Змінити ПІБ");
                    Console.WriteLine($"3) Змінити дату народження");
                    Console.WriteLine($"4) Змінити номер телефону");
                    Console.WriteLine($"5) Змінити емейл");
                    Console.WriteLine($"6) Змінити посаду");
                    Console.WriteLine($"7) Змінити опис службових обов’язків");
                    Console.WriteLine($"8) Вихід");
                    Console.Write("Введіть вибір: ");
                    select = Convert.ToInt32(Console.ReadLine());

                    switch (select)
                    {
                        case 1:
                            v.getInfo();
                            break;
                        case 2:
                            Console.WriteLine("Введіть ПІБ:");
                            NSM = Convert.ToString(Console.ReadLine());
                            v.setNSM(NSM);
                            break;
                        case 3:
                            Console.WriteLine("Введіть нову дату народження:");
                            birthday = Convert.ToString(Console.ReadLine());
                            v.setBirthday(birthday);
                            break;
                        case 4:
                            Console.WriteLine("Введіть новий номер телефону:");
                            tel = Convert.ToInt32(Console.ReadLine());
                            v.setTel(tel);
                            break;
                        case 5:
                            Console.WriteLine("Введіть новий емейл:");
                            email = Convert.ToString(Console.ReadLine());
                            v.setEmail(email);
                            break;
                        case 6:
                            Console.WriteLine("Введіть нову посаду:");
                            position = Convert.ToString(Console.ReadLine());
                            v.setPosition(position);
                            break;
                        case 7:
                            Console.WriteLine("Введіть новий опис службових обов’язків:");
                            JobDescription = Convert.ToString(Console.ReadLine());
                            v.setJobDescription(JobDescription);
                            break;
                        case 8:
                            Exit = true;
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