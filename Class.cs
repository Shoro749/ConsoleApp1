using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class
    {
        private int number;

        public Class()
        {
            number = 0;
        }
        public Class(int num)
        {
            number = num;
        }
        public bool Check()
        {
            int num1 = 0;
            int num2 = 1;

            while (true)
            {
                if (num1 > number && num2 > number)
                {
                    return false;
                }

                num1 = num1 + num2;

                if (number == num1)
                {
                    return true;
                }

                num2 = num2 + num1;

                if (number == num2)
                {
                    return true;
                }
            }
        }
    }
}
