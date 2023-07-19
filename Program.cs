using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Створіть додаток «Хрестики-Нулики». Користувач грає
                з комп'ютером. При старті гри рандомно обирається, хто
                перший розпочинає гру. Гравці ходять по черзі. Гра може
                закінчитися перемогою одного з гравців або нічиєю. 
                Використовуйте механізми просторів імен.*/

                /*Додайте до першого завдання можливість грати з іншим користувачем*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                Play.Game game = new Play.Game();
                game.playing();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            Console.ReadKey();
            Console.ResetColor();
        }
    }
}