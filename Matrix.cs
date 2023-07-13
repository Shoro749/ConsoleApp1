using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Реалізуйте клас Матриця». Реалізуйте конструктори і
методи класу для введення і виведення даних, підрахунку
максимуму і мінімуму. Використовуйте механізм навантаження методів.*/

namespace ConsoleApp1
{
    internal class Matrix
    {
        private int[,] _arr = new int[3, 3];
        public Matrix() 
        { 
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    _arr[i, j] = 0;
                }
            }
        }
        public Matrix(int[,] arr)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    _arr[i, j] = arr[i, j];
                }
            }
        }

        public void ShowMatrix()
        {
            Console.Write("\n");
            for (int i = 0;i < 3; i++)
            {
                for (int j = 0;j < 3; j++)
                {
                    Console.Write(_arr[i, j] + " ");
                }
                Console.Write("\n");
            }
        }

        public void WriteMatrix()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Ввеідть число: ");
                    _arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            ShowMatrix();
        }

        public int getM()
        {
            int min = int.MaxValue;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (_arr[i, j] < min)
                    {
                        min = _arr[i, j];
                    }
                }
            }

            return min;
        }

        public int getM(int[,] arr)
        {
            int max = int.MinValue;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
            }

            return max;
        }
    }
}
