using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*В одному з попередніх практичних завдань ви створювали клас «Кредитна картка». Додайте до вже створеного
                класу інформацію про суму грошей на картці. Виконайте перевантаження + (для збільшення суми грошей на
                вказану кількість), – (для зменшення суми грошей на
                вказану кількість), == (перевірка на рівність CVC коду),
                < і > (перевірка на меншу чи більшу кількість суми грошей), != і Equals. Використовуйте механізм властивостей
                полів класу.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                CreditCard v = new CreditCard("1234 5678 9123 4567", 25000);

                while (true)
                {
                    bool Exit = false;
                    Console.WriteLine("\n1) Показати інформацію про картку");
                    Console.WriteLine("2) Переписати номер картки");
                    Console.WriteLine("3) Поповнити картку");
                    Console.WriteLine("4) Оплатита картою");
                    Console.WriteLine("5) Перевірка коштів");
                    Console.WriteLine("6) Вихід");
                    Console.Write("Введіть свій вибір: ");
                    int select = Convert.ToInt32(Console.ReadLine());

                    switch (select)
                    {
                        case 1:
                            v.ShowInfo();
                            break;

                        case 2:
                            Console.Write("\nВведіть новий номер картки: ");
                            v.Num = Convert.ToString(Console.ReadLine());
                            break;

                        case 3:
                            Console.Write("\nВведіть на яку суму ви хочете поповнити: ");
                            select = Convert.ToInt32(Console.ReadLine());
                            v.Sum = v.Sum + select;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nКарту поповнено на суму " + select);
                            break;

                        case 4:
                            Console.Write("\nВведіть суму для оплати: ");
                            select = Convert.ToInt32(Console.ReadLine());

                            if (v.Sum < select) { Console.ForegroundColor = ConsoleColor.DarkYellow; 
                                Console.WriteLine("\nНедостатньо на рахунку!"); }
                            else { v.Sum = v.Sum - select; Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nЗ карти було знято на суму " + select); }
                            break;

                        case 5:
                            Console.Write("\nВведіть число: ");
                            select = Convert.ToInt32(Console.ReadLine());

                            if (v.Sum == select)
                            {
                                Console.WriteLine("Сума на вашому рахунку дорівнює тій, що ви ввели!");
                            }
                            else if (v.Sum > select)
                            {
                                Console.WriteLine("Сума на вашому рахунку більша, ніж та що ви ввели!");
                            }
                            else
                            {
                                Console.WriteLine("Сума на вашому рахунку менша, ніж та що ви ввели!");
                            }
                            break;

                        case 6:
                            Exit = true;
                            break;
                    }
                    Console.ResetColor();
                    if (Exit) { break; }
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