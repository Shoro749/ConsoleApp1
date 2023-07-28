using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CreditCard
    {
        private string _number;
        private int _sum;

        public CreditCard(string number, int sum)
        {
            _number = number;
            _sum = sum;
        }

        public string Num
        {
            get { return _number; }
            set { if (value.Length != 19) { throw new Exception("Неправильний номер катки!"); }
                else { _number = value; }
            }
        }

        public int Sum
        {
            get { return _sum; }
            set { if (value < 0) { throw new Exception("Сума на рахунку менше нуля!"); }
                else { _sum = value; }
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"\nНомер картки: {Num}\nСума коштів: {Sum}");
        }

        public static int operator +(CreditCard v, int num) { return v.Sum + num; }
        public static int operator -(CreditCard v, int num) { return v.Sum - num; }
        public static bool operator ==(CreditCard v, int num) { return v.Sum == num; }
        public static bool operator !=(CreditCard v, int num) { return v.Sum != num; }
        public static bool operator >(CreditCard v, int num) { return v.Sum > num; }
        public static bool operator <(CreditCard v, int num) { return v.Sum < num; }
    }
}
