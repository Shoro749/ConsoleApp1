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
            Console.WriteLine("\t\t\t\t\t\t\t\t*");
            Console.WriteLine("\t\t\t\t\t\t\t**");
            Console.WriteLine("\t\t\t\t\t\t****");
            Console.WriteLine("\t\t\t\t\t******");
            Console.WriteLine("\t\t\t\t********");
            Console.WriteLine("\t\t\t**********");
            Console.WriteLine("\t\t************");
            Console.WriteLine("\t**************");
            Console.WriteLine("****************");
        }
    }
}

namespace Rectangle
{
    public class Geometry
    {
    }
}

namespace Square
{
    public class Geometry
    {
    }
}
