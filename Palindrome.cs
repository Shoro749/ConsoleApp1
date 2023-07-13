using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Напишіть метод, який перевіряє чи є передане число
«паліндромом». Число передається як параметр. Якщо
число — паліндром, потрібно повернути з методу true,
інакше — false.
Паліндром — число, яке однаково читається в обох
напрямках (зліва направо та справа наліво).
Наприклад:
1221 — паліндром;
3443 — паліндром;
7854 — не паліндром.*/

namespace ConsoleApp1
{
    internal class Palindrome
    {
        private int _num;
        public Palindrome() { _num = 0; }
        public Palindrome(int num) { _num = num; }

        public void Checking(int num)
        {
            int[] number = new int[4];
            int[] numb = new int[4];
            int temp = 4, x = 0;

            while (_num > 0)
            {
                temp--;
                int digit = _num % 10;
                number[temp] = digit;
                numb[x] = digit; 
                _num /= 10;
                x++;
            }

            bool check = true;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] != numb[i]) 
                {
                    check = false; 
                    break;
                }
            }

            Console.WriteLine(check);
        }
    }
}
