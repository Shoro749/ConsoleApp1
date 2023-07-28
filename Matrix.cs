using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Matrix
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
        public int[,] getMatrix
        {
            get { return _arr; }
            set { _arr = value; }
        }

        public void ShowMatrix()
        {
            Console.Write("\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
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

        public int getNum(int num1, int num2) { return _arr[num1, num2]; }

        public static Matrix operator +(Matrix arr, Matrix arr1)
        {
            Matrix result = new Matrix();
            int[,] matrix = new int[3,3];
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0;j < 3; j++)
                {
                    matrix[i,j] = arr.getNum(i, j) + arr1.getNum(i, j);
                }
            }
            result.getMatrix = matrix;
            return result;
        }
        public static Matrix operator -(Matrix arr, Matrix arr1)
        {
            Matrix result = new Matrix();
            int[,] matrix = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = arr.getNum(i, j) - arr1.getNum(i, j);
                }
            }
            result.getMatrix = matrix;
            return result;
        }
        public static Matrix operator *(Matrix arr, Matrix arr1)
        {
            Matrix result = new Matrix();
            int[,] matrix = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = arr.getNum(i, j) * arr1.getNum(i, j);
                }
            }
            result.getMatrix = matrix;
            return result;
        }
        public static bool operator ==(Matrix arr, Matrix arr1)
        {
            bool checking = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (arr.getNum(i, j) != arr1.getNum(i, j))
                    {
                        checking = false; break;
                    }
                }
            }

            return checking;
        }

        public static bool operator !=(Matrix arr, Matrix arr1)
        {
            bool checking = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (arr.getNum(i, j) != arr1.getNum(i, j))
                    {
                        checking = false; break;
                    }
                }
            }

            return checking;
        }
    }
}
