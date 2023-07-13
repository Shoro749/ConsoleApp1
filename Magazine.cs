using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Створіть клас «Журнал». Необхідно зберігати у полях
класу: назву журналу, рік заснування, опис журналу,
контактний телефон, email. Реалізуйте методи класу для
введення даних, виведення даних. Реалізуйте доступ до
окремих полів через методи класу.*/

namespace ConsoleApp1
{
    internal class Magazine
    {
        private string _name;
        private int _year;
        private string _description;
        private string _telephone;
        private string _email;

        public Magazine()
        {
            _name = "Noname";
            _year = 0000;
            _description = "No_description";
            _telephone = "+3800000000000";
            _email = "No_email";
        }
        public Magazine(string name, int year, string description, string tel, string email)
        {
            _name = name;
            _year = year;
            _description = description;
            _telephone = "+380" + tel;
            _email = email;
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
    }
}
