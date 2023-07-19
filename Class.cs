using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Створіть гру «Вгадай число». Комп’ютер вгадує число,
яке загадав користувач у вказаному діапазоні. Використовуйте механізми просторів імен.*/

namespace Attempt
{
    public class Class
    {
        public bool guessing(int[] arr, int attempt)
        {
            Random rnd = new Random();
            int temp;

            while (true)
            {
                bool pass = true;
                temp = rnd.Next(1, 11);
                foreach (var item in arr)
                {
                    if (item > 0)
                    {
                        if (item == temp)
                        {
                            pass = false;
                        }
                    }
                }
                if (pass == true)
                {
                    break;
                }
            }

            Console.WriteLine($"Ви загадали число {temp}?");
            Console.Write("Напишіть 'Так' або 'Ні': ");
            string? select = Convert.ToString(Console.ReadLine());
            if (select == "Так")
            {
                if (attempt == 0)
                {
                    Console.WriteLine($"\nКомп'ютер вгадав за 1 спробу!");
                }
                else
                {
                    Console.WriteLine($"\nКомп'ютер вгадав за {attempt+1} спроб!");
                }
                return true;
            }
            else if (select == "Ні")
            {
                arr[attempt] = temp;
                Console.Write("\n");

                return false;
            }
            else { throw new Exception("Неправильний вибір!"); }
        }
    }
}

