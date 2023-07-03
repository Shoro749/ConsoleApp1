using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Користувач вводить з клавіатури речення. Додаток має
                підрахувати кількість голосних літер у реченні.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                Console.Write("Введіть речення(eng): ");
                string ?str = Convert.ToString(Console.ReadLine());
                str = str.Trim();
                string[] words = str.Split('e', 'a', 'i', 'o', 'u', 'y');

                Console.Write($"Кількість голосних: {words.Length-1}");
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