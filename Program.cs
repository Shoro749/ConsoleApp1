using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Користувач вводить з клавіатури дату. Додаток має
            відобразити назву пори року і дня тижня. Наприклад,
            якщо введено 22.12.2021, додаток має відобразити Winter
            Wednesday*/
            try
            {
                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                Console.Write("Введіть день: ");
                int day = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введіть місяць: ");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введіть рік: ");
                int year = Convert.ToInt32(Console.ReadLine());
                string ?nMonth;
                if (month >=3 && month <= 5)
                {
                    nMonth = "Весна";
                }
                else if (month >=6 && month <= 8)
                {
                    nMonth = "Літо";
                }
                else if (month >= 9 && month <= 11)
                {
                    nMonth = "Осінь";
                }
                else { nMonth = "Зима"; }

                DateTime date = new DateTime(year, month, day);
                string dayOfWeek = date.ToString("dddd");
                Console.WriteLine($"{nMonth} {dayOfWeek}");
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