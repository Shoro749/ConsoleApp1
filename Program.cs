using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Користувач вводить речення з клавіатури. Вам необхідно підрахувати кількість слів у ньому*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                Console.Write("Введіть речення: ");
                string ?str = Convert.ToString(Console.ReadLine());
                var words = str.Split(' ', ',', '.');
                foreach(var word in words)
                {
                    Console.Write(word);
                }
                Console.WriteLine(str.Split(' ', ',', '.'));
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