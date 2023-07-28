using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class City
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
        public static int operator +(City v, int num)
        {
            return v.CityNumberInfo + num;
        }
        public static int operator -(City v, int num)
        {
            return v.CityNumberInfo - num;
        }
        public static bool operator ==(City v, City q)
        {
            return v.CityNumberInfo == q.CityNumberInfo;
        }
        public static bool operator !=(City v, City q)
        {
            return v.CityNumberInfo != q.CityNumberInfo;
        }
        public static bool operator >(City v, City q)
        {
            return v.CityNumberInfo > q.CityNumberInfo;
        }
        public static bool operator <(City v, City q)
        {
            return v.CityNumberInfo < q.CityNumberInfo;
        }
    }
}
