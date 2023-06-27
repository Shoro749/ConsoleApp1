using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                Console.Write("Введіть температуру: ");
                int degrees = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("1) Фаренгейт 2) Цельсій ");
                Console.Write("В яку температуру перевести(1, 2): ");
                int select = Convert.ToInt32(Console.ReadLine());
                
                if (select == 1)
                {
                    Console.WriteLine($"{degrees * 1.8 + 32} фаренгейт!");
                } 
                else if (select == 2)
                {
                    Console.WriteLine($"{(degrees - 32) / 1.8} цельсій!");
                }
                else
                {
                    throw new Exception("Невірний вибір!");
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