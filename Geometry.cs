using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Створіть класи для відображення різних геометричних
фігур: трикутника, прямокутника, квадрата. Використовуйте механізми просторів імен.*/

namespace Triangle
{
    public class Geometry
    {
        public void ShowFigure()
        {
            Console.WriteLine("\n       **");
            Console.WriteLine("      ****");
            Console.WriteLine("     ******");
            Console.WriteLine("    ********");
            Console.WriteLine("   **********");
            Console.WriteLine("  ************");
            Console.WriteLine(" **************");
            Console.WriteLine("****************");
        }
    }
}

namespace Rectangle
{
    public class Geometry
    {
        public void ShowFigure()
        {
            Console.WriteLine("\n****************");
            Console.WriteLine("****************");
            Console.WriteLine("****************");
            Console.WriteLine("****************");
            Console.WriteLine("****************");
            Console.WriteLine("****************");
            Console.WriteLine("****************");
            Console.WriteLine("****************");
            Console.WriteLine("****************");
            Console.WriteLine("****************");
        }
    }
}

namespace Square
{
    public class Geometry
    {
        public void ShowFigure()
        {
            Console.WriteLine("\n****************");
            Console.WriteLine("****************");
            Console.WriteLine("****************");
            Console.WriteLine("****************");
            Console.WriteLine("****************");
            Console.WriteLine("****************");
            Console.WriteLine("****************");
            Console.WriteLine("****************");
        }
    }
}
