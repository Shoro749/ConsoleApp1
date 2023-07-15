using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Створіть класи для створення парних чисел, непарних
чисел, простих чисел, чисел Фібоначчі. Використовуйте
механізми просторів імен.*/

namespace Even
{
    public class Class
    {
        public void Numbers(int[] arr)
        {
            int temp = 0;
            for (int i = 1; i < 30; i++)
            {
                if (temp == arr.Length) { break; }
                if (i % 2 == 0)
                {
                    arr[temp] = i;
                    temp++;
                }
            }
        }
    }
}

namespace NotEven
{
    public class Class
    {
        public void Numbers(int[] arr)
        {
            int temp = 0;
            for (int i = 1; i < 30; i++)
            {
                if (temp == arr.Length) { break; }
                if (i % 2 == 1)
                {
                    arr[temp] = i;
                    temp++;
                }
            }
        }
    }
}

namespace PrimeNumbers
{
    public class Class
    {
        public void Numbers(int[] arr)
        {
            int temp = 0, i = 0;
            while (true)
            {
                if (temp == arr.Length) { break; }
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }

                    if (j == i - 1)
                    {
                        arr[temp] = i;
                        temp++;
                        break;
                    }
                }
                i++;
            }
        }
    }
}

namespace FibonacciNumbers
{
    public class Class
    {
        public void Numbers(int[] arr)
        {
            int temp = 0, i = 0, num1 = 0, num2 = 1;
            while (true)
            {
                if (temp == arr.Length) { break; }

                arr[temp] = num1;
                temp++;
                num1 += num2;
                arr[temp] = num2;
                temp++;
                num2 += num1;
                i++;
            }
        }
    }
}
