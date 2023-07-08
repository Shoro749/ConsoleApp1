using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SortClass
    {
        private int select;

        public SortClass()
        {
            select = 1;
        }
        public SortClass(int sel)
        {
            select = sel;
        }

        public void Sorting(int[] arr)
        {
            int temp;
            if (select == 1)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] > arr[j])
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] < arr[j])
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
            }

            Console.WriteLine("Новий масив: ");

            foreach(var item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
