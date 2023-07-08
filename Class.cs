using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Domain.Model
{
    public class Class
    {
        private int _range1;
        private int _range2;

        public Class() 
        { 
            _range1 = 0;
            _range2 = 0;
        }

        public Class(int range1, int range2)
        {
            if (range1 < range2)
            {
                _range1 = range1;
                _range2 = range2;
            }
            else
            {
                _range1 = range2;
                _range2 = range1;
            }
        }

        public int Range1
        {
            get { return _range1; }
            set { _range1 = value; }
        }

        public int Range2
        {
            get { return _range2; }
            set { _range2 = value; }
        }

        public int Dobutok() 
        {
            int d = 1;

            for (int i = _range1; i < _range2; i++)
            {
                d *= i;
            }

            return d;
        }
    }
}
