using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*В одному з попередніх практичних завдань ви створювали клас «Журнал». Додайте до вже створеного класу
інформацію про кількість працівників. Виконайте навантаження + (для збільшення кількості працівників на вказану кількість), — (для зменшення кількості працівників
на вказану кількість), == (перевірка на рівність кількості
працівників), < і > (перевірка на меншу чи більшу кількість працівників), != і Equals. Використовуйте механізм
властивостей полів класу.*/

namespace ConsoleApp1
{
    public class Magazine
    {
        private string _name;
        private int _year;
        private string _description;
        private string _telephone;
        private string _email;
        private int _employees;

        public Magazine()
        {
            _name = "Noname";
            _year = 0000;
            _description = "No_description";
            _telephone = "+3800000000000";
            _email = "No_email";
            _employees = 0;
        }
        public Magazine(string name, int year, string description, string tel, string email, int employees)
        {
            _name = name;
            _year = year;
            _description = description;
            _telephone = "+380" + tel;
            _email = email;
            _employees = employees;
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

        public int Year
        {
            get { return _year; }
            set
            {
                if (value < 1000 || value > 9999)
                    throw new Exception("Введено неправильний рік!");
                else
                    _year = value;
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

        public string Telephone
        {
            get { return _telephone; }
            set
            {
                if (value is null)
                    throw new Exception("Введено пусте поле!");
                else
                    _telephone = "+380" + value;
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

        public int Employees
        {
            get { return _employees; }
            set { _employees = value; }
        }

        public static int operator +(Magazine v, int num) { return v.Employees + num; }
        public static int operator -(Magazine v, int num) { return v.Employees - num; }
        public static bool operator ==(Magazine v, int num) { return v.Employees == num; }
        public static bool operator !=(Magazine v, int num) { return v.Employees != num; }
        public static bool operator >(Magazine v, int num) { return v.Employees > num; }
        public static bool operator <(Magazine v, int num) { return v.Employees < num; }
    }
}