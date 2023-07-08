using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Створіть клас «Місто». Необхідно зберігати у полях
класу: назву міста, назву країни, кількість жителів у місті,
телефонний код міста, назву районів міста. Реалізуйте методи класу для введення даних, виведення даних. Реалізуйте
доступ до окремих полів через методи класу.*/

namespace ConsoleApp1
{
    internal class City
    {
        private string CityName;
        private string Country;
        private int Number;
        private int TelCode;
        private string[] districts = new string[5];

        public City() 
        {
            CityName = "NoName";
            Country = "NoName";
            Number = 0;
            TelCode = 0;
            for (int i = 0; i < 5; i++)
            {
                districts[i] = "NoName";
            }
        }

        public City(string city, string contry, int num, int tCode, string[] arr)
        {
            CityName = city;
            Country = contry;
            Number = num;
            TelCode = tCode;
            for (int i = 0; i < 5; i++)
            {
                districts[i] = arr[i];
            }
        }

        public string CityNameInfo
        {
            get { return CityName; }
            set { CityName = value; }
        }

        public string CountryNameInfo
        {
            get { return Country; }
            set { Country = value; }
        }

        public int CityNumberInfo
        {
            get { return Number; }
            set { Number = value; }
        }

        public int TelCodeInfo
        {
            get { return TelCode; }
            set { TelCode = value; }
        }

        public string[] DistrictsInfo
        {
            get { return districts; }
            set { districts = value; }
        }
    }
}
