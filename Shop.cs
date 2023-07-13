using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Створіть клас «Магазин». Необхідно зберігати у полях
класу: назву магазину, адреса, опис профілю магазину,
контактний телефон, email. Реалізуйте методи класу для
введення даних, виведення даних. Реалізуйте доступ до
окремих полів через методи класу.*/

namespace ConsoleApp1
{
    internal class Shop
    {
        private string _name;
        private string _address;
        private string _description;
        private long _tel;
        private string _email;

        public Shop() 
        {
            _name = "Noname";
            _address = "No_Address";
            _description = "No_description";
            _tel = 0;
            _email = "No_email";
        }
        public Shop(string name, string address, string descripction, long telephone, string email)
        {
            _name = name;
            _address = address;
            _description = descripction;
            _tel = telephone;
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
    }
}
