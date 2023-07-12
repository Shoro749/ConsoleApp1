using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*/*Реалізуйте клас «Літак». Необхідно зберігати у полях
класу: назву літака, назву виробника, рік випуску, тип літака. Реалізуйте конструктори і методи класу для введення
і виведення даних. Реалізуйте доступ до окремих полів
через методи класу. Використовуйте механізм навантаження методів.*/


namespace ConsoleApp1
{
    internal class Airplane
    {
        private string _name;
        private string _manufacturerName;
        private int _graduationYear;
        private string _type;

        public Airplane()
        {
            _name = "Noname";
            _manufacturerName = "Noname";
            _graduationYear = 0000;
            _type = "Notype";
        }

        public Airplane(string name, string manufacturerName, int graduationYear, string type)
        {
            _name = name;
            _manufacturerName = manufacturerName;
            _graduationYear = graduationYear;
            _type = type;
        }

        public string Name
        {
            get { return _name; }
            set { if (value is null)
                    throw new Exception("Введено пусте поле!");
                  else
                    _name = value; }
        }

        public string ManufacturerName
        {
            get { return _manufacturerName; }
            set
            {
                if (value is null)
                    throw new Exception("Введено пусте поле!");
                else
                    _manufacturerName = value;
            }
        }

        public int GraduationYear
        {
            get { return _graduationYear; }
            set
            {
                if (value < 1000 || value > 2023)
                    throw new Exception("Введено неправильний рік!");
                else
                    _graduationYear = value;
            }
        }

        public string Type
        {
            get { return _type; }
            set
            {
                if (value is null)
                    throw new Exception("Введено пусте поле!");
                else
                    _type = value;
            }
        }
    }
}
