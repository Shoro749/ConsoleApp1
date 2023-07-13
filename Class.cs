using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Напишіть метод, який відображає квадрат із деякого
символу. Метод приймає довжину сторони квадрата як
параметр, — символ.*/

namespace ConsoleApp1.Domain.Model
{
    public class Class
    {
        private int _length;
        private string _symbol;
        public Class() { _length = 0; _symbol = " "; }
        public Class(int length, string symbol) 
        { 
            _length = length;
            if (symbol.Length > 1)
            {
                throw new Exception("Тільки один символ приймається!");
            }
            else { _symbol = symbol; }
        }

        public void Square()
        {
            Console.WriteLine("\n");
            for (int j = 0; j < _length; j++)
            {
                for (int i = 0; i < _length; i++)
                {
                    Console.Write(_symbol + _symbol);
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n");
        }
    }
}
