using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Створіть додаток «Список книг до прочитання». Додаток
                має дозволяти додавати книги до списку, видаляти книги
                зі списку, перевіряти чи є книга у списку, і т.д. Використовуйте механізм властивостей, навантаження операторів,
                індексаторів.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                string[] arr = new string[50];
                arr[0] = "451 degrees Fahrenheit";
                arr[1] = "In search of lost time";
                arr[2] = "Process";
                arr[3] = "Outsider";
                arr[4] = "Black Council";

                BookList v = new BookList(arr);

                while(true) 
                {
                    bool Exit = false;
                    Console.WriteLine("\n1) Додати книгу до списку");
                    Console.WriteLine("2) Видалити книгу з списку");
                    Console.WriteLine("3) Перевірити книгу на наявність");
                    Console.WriteLine("4) Вихід");
                    Console.Write("Введіть свій вибір: ");
                    int select = Convert.ToInt32(Console.ReadLine());

                    switch (select)
                    {
                        case 1:
                            Console.WriteLine("\nВведіть назву книги: ");
                            string ?title = Convert.ToString(Console.ReadLine());
                            v.AddBook(title);
                            break;

                        case 2:
                            Console.WriteLine("\nВведіть назву книги: ");
                            title = Convert.ToString(Console.ReadLine());
                            v.RemoveBook(title);
                            break;

                        case 3:
                            Console.WriteLine("\nВведіть назву книги: ");
                            title = Convert.ToString(Console.ReadLine());

                            if (v.InStock(title)) { Console.WriteLine("\nКнига в наявності!"); }
                            else { Console.WriteLine("\nКнига не в наявності!"); }
                            break;

                        case 4:
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