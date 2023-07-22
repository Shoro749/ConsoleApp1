using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee
    {
        private string NSM;
        private string birthday;
        private int telephone;
        private string email;
        private string position;
        private string JobDescription;
        private int salary;
        public Employee()
        {
            NSM = "NoName";
            birthday = "00.00.0000";
            telephone = 0;
            email = "NULL";
            position = "NoPosition";
            JobDescription = "NULL";
            salary = 0;
        }
        public Employee(string nSM, string birthday, int telephone, string email, string position, string jobDescription, int salary)
        {
            NSM = nSM;
            this.birthday = birthday;
            this.telephone = telephone;
            this.email = email;
            this.position = position;
            JobDescription = jobDescription;
            this.salary = salary;
        }
        public void getInfo()
        {
            Console.WriteLine($"\nПІБ: {NSM}\nДата народження: {birthday}\nНомер телефону: {telephone}\n" +
                $"Емейл: {email}\nПосада: {position}\nОпис службових обов’язків:{JobDescription}\n" +
                $"Зарплата: {salary}\n");
        }

        public string NSM_ 
        {
            get { return NSM; }
            set { NSM = value; }
        }
        public void setBirthday(string birthday) { this.birthday = birthday; }
        public void setTel(int tel) { telephone = tel; }
        public void setEmail(string email) { this.email = email; }
        public void setPosition(string position) { this.position = position; }
        public void setJobDescription(string JobDescription) { this.JobDescription = JobDescription; }
        public int Salary {
            get { return salary; }
            set { salary = value; }
        }
        public static int operator+(Employee salary, int sum)
        {
            return salary + sum;
        }
        public static int operator -(Employee salary, int sum)
        {
            return salary - sum;
        }
        public static bool operator ==(Employee v, Employee q)
        {
            return v.Salary == q.Salary;
        }
        public static bool operator !=(Employee v, Employee q)
        {
            return !(v == q);
        }
        public static bool operator >(Employee v, Employee q)
        {
            return v > q;
        }
        public static bool operator <(Employee v, Employee q)
        {
            return v < q;
        }
    }
}
