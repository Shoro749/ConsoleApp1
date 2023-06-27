using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Користувач з клавіатури вводить довжину лінії, символ
                заповнювач, напрямок лінії (горизонтальна, вертикальна).
                Програма відображає лінію по заданих параметрах.
                Наприклад: +++++.
                Параметри лінії: горизонтальна лінія, довжина дорівнює п'яти, символ заповнювач +.*/

                static void getLine(int lenght, string symvol, int napryamok)
                {
                    if (napryamok == 1)
                    {
                        for (int i = 0; i < lenght; i++)
                        {
                            Console.Write(symvol);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < lenght; i++)
                        {
                            Console.WriteLine(symvol);
                        }
                    }
                }

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                Console.Write("Введіть довжину лінії: ");
                int lenght = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введіть символ заповнювач: ");
                string ?symvol = Convert.ToString(Console.ReadLine());
                Console.Write("Введіть напрямок лінії(1) -, 2) | ): ");
                int napryamok = Convert.ToInt32(Console.ReadLine());

                if (napryamok > 2 || napryamok < 1)
                {
                    throw new Exception("Такого напрямку не існує!");
                }

                getLine(lenght, symvol, napryamok);
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