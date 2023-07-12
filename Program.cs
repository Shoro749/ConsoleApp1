using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Реалізуйте клас «Літак». Необхідно зберігати у полях
                класу: назву літака, назву виробника, рік випуску, тип літака. Реалізуйте конструктори і методи класу для введення
                і виведення даних. Реалізуйте доступ до окремих полів
                через методи класу. Використовуйте механізм навантаження методів.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                var v = new Airplane("Eagle", "AirplaneFactory", 2020, "Passenger's");

                while (true)
                {
                    bool Exit = false;
                    Console.WriteLine("1) Змінити назву");
                    Console.WriteLine("2) Змінити назву виробника");
                    Console.WriteLine("3) Змінити рік випуску");
                    Console.WriteLine("4) Змінити тип літака");
                    Console.WriteLine("5) Показати інформацію про літак");
                    Console.WriteLine("6) Вихід");
                    Console.Write("Введіть свій вибір: ");
                    int select = Convert.ToInt32(Console.ReadLine());

                    switch (select)
                    {
                        case 1:
                            Console.Write("\nВведіть нову назву: ");
                            v.Name = Convert.ToString(Console.ReadLine());
                            break;

                        case 2:
                            Console.Write("\nВведіть новий рік випуску: ");
                            v.ManufacturerName = Convert.ToString(Console.ReadLine());
                            break;

                        case 3:
                            Console.Write("\nВведіть нову назву виробника: ");
                            v.GraduationYear = Convert.ToInt32(Console.ReadLine());
                            break;

                        case 4:
                            Console.Write("\nВведіть новий тип літака: ");
                            v.Type = Convert.ToString(Console.ReadLine());
                            break;

                        case 5:
                            Console.WriteLine($"\nНазва літака: {v.Name}\nНазва виробника: {v.ManufacturerName}" +
                                $"\nРік випуску: {v.GraduationYear}\nТип літака: {v.Type}\n");
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