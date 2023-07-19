using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Створіть додаток для перекладу звичайного тексту в
                азбуку Морзе. Користувач вводить текст. Додаток виводить
                введений текст азбукою Морзе. Використовуйте механізми
                просторів імен.*/

                string[] morze = new string[26] { "*-", "-***", "-*-*", "-**", "*", "**-*", "--*",
                    "****", "**", "*---", "-*-", "*-**", "--", "-*", "---", "*--*", "--*-", "*-*",
                    "***", "-", "**-", "***-", "*--", "-**-", "-*--", "--**"};
                string[] abc = new string[26] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                    "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v",  "w", "x", "y", "z",};

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                Console.Write("1) Текст -> морзе\n2) Морзе -> текст\nВведіть свій вибір: ");
                int select = Convert.ToInt32(Console.ReadLine()); 
                switch(select)
                {
                    case 1:
                        Console.Write("Введіть текст(eng): ");
                        string? str = Convert.ToString(Console.ReadLine());
                        ToMorze.Translator translator = new ToMorze.Translator();
                        translator.translating(str, morze, abc);
                        break;

                    case 2:
                        Console.Write("Введіть текст: ");
                        str = Convert.ToString(Console.ReadLine());
                        ToAbc.Translator _translator = new ToAbc.Translator();
                        _translator.translating(str, morze, abc);
                        break;
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