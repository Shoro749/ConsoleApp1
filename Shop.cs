using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*В одному з попередніх практичних завдань ви створювали клас «Магазин». Додайте до вже створеного класу
інформацію про площу магазину. Виконайте навантаження + (для збільшення площі магазину на вказаний
розмір), — (для зменшення площі магазину на вказаний
розмір), == (перевірка на рівність площ магазинів), < і >
(перевірка магазинів менших або більших за площею),
!= і Equals. Використовуйте механізм властивостей
полів класу.*/

namespace ConsoleApp1
{
    internal class Shop
    {
        private string _name;
        private string _address;
        private string _description;
        private long _tel;
        private string _email;
        private int _area;

        public Shop()
        {
            _name = "Noname";
            _address = "No_Address";
            _description = "No_description";
            _tel = 0;
            _email = "No_email";
            _area = 0;
        }
        public Shop(string name, string address, string descripction, long telephone, string email, int area)
        {
            _name = name;
            _address = address;
            _description = descripction;
            _tel = telephone;
            _email = email;
            _area = area;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value is null)
                    throw new Exception("Введено пусте поле!");
                else
                    _name = value;
            }
        }

        public string Address
        {
            get { return _address; }
            set
            {
                if (value is null)
                    throw new Exception("Введено пусте поле!");
                else
                    _address = value;
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                if (value is null)
                    throw new Exception("Введено пусте поле!");
                else
                    _description = value;
            }
        }

        public long Telephone
        {
            get { return _tel; }
            set
            {
                if (value < 1000000000 || value > 9999999999)
                    throw new Exception("Введено неправильний номер!");
                else
                    _tel = value;
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                if (value is null)
                    throw new Exception("Введено пусте поле!");
                else
                    _email = value;
            }
        }

        public int Area
        {
            get { return _area; }
            set { _area = value; }
        }

        public static int operator +(Shop v, int num) { return v.Area + num; }
        public static int operator -(Shop v, int num) { return v.Area - num; }
        public static bool operator ==(Shop v, int num) { return v.Area == num; }
        public static bool operator !=(Shop v, int num) { return v.Area != num; }
        public static bool operator >(Shop v, int num) { return v.Area > num; }
        public static bool operator <(Shop v, int num) { return v.Area < num; }
    }
}