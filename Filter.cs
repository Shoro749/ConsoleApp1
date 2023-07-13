using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Напишіть метод, який фільтрує масив за переданими
параметрами. Метод приймає параметри: оригінальний_масив, масив_з_даними_для_фільтрації.
Метод повертає оригінальний масив без елементів,
які знаходяться у масиві для фільтрації.
Наприклад:
1 2 6 -1 88 7 6 — оригінальний масив
6 88 7 — масив для фільтрації
1 2 -1 — результат роботи методу*/

namespace ConsoleApp1
{
    internal class Filter
    {
        public void filter(int[] arr, int[] filter) 
        {
            int[] newArr = new int[arr.Length];
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                bool check = true;
                for (int j = 0; j < filter.Length; j++)
                {
                    if (arr[i] == filter[j])
                    {
                        check = false;
                    }
                }
                if (check)
                {
                    newArr[temp] = arr[i];
                    temp++;
                }
            }

            foreach (var item in newArr) 
            {
                if (item > 0)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
