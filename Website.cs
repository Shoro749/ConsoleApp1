using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Створіть клас «Веб-сайт». Необхідно зберігати у
полях класу: назву сайту, шлях до сайту, опис сайту,
ip-адресу сайту. Реалізуйте методи класу для введення
даних, виведення даних. Реалізуйте доступ до окремих
полів через методи класу.*/

namespace ConsoleApp1
{
    internal class Website
    {
        private string _name;
        private string _way;
        private string _description;
        private string _ip;

        public Website()
        {
            _name = "Noname";
            _way = "Nope";
            _description = "No_description";
            _ip = "000.0.0.0";
        }

        public Website(string name, string way, string description, string ip)
        {
            _name = name;
            _way = way;
            _description = description;
            _ip = ip;
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

        public string Way
        {
            get { return _way; }
            set
            {
                if (value is null)
                    throw new Exception("Введено пусте поле!");
                else
                    _way = value;
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

        public string IP
        {
            get { return _ip; }
            set
            {
                if (value is null)
                    throw new Exception("Введено пусте поле!");
                else
                    _ip = value;
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"\nНазва сайту: {Name}\nШлях до сайту: {Way}\n" +
                $"Опис: {Description}\nIp-адреса: {IP}\n");
        }
    }
}
