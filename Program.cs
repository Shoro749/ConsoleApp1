using System.Drawing;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*Створіть класи для відображення різних геометричних
                фігур: трикутника, прямокутника, квадрата. Використовуйте механізми просторів імен.*/

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                Console.WriteLine("1) Показати трикутник");
                Console.WriteLine("2) Показати прямокутник");
                Console.WriteLine("3) Показати квадрат");
                Console.Write("Введіть свій вибір: ");
                int select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        Triangle.Geometry figure1 = new Triangle.Geometry();
                        figure1.ShowFigure();
                        break;

                    case 2:
                        Rectangle.Geometry figure2 = new Rectangle.Geometry();
                        figure2.ShowFigure();
                        break;

                    case 3:
                        Square.Geometry figure3 = new Square.Geometry();
                        figure3.ShowFigure();
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