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