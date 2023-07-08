using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Реалізуйте клас «Співробітник». Необхідно зберігати у
полях класу: ПІБ, дату народження, контактний телефон,
робочий email, посаду, опис службових обов’язків. Реалізуйте методи класу для введення даних, виведення даних.
Реалізуйте доступ до окремих полів через методи класу.*/

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
        public Employee()
        {
            NSM = "NoName";
            birthday = "00.00.0000";
            telephone = 0;
            email = "NULL";
            position = "NoPosition";
            JobDescription = "NULL";
        }
        public Employee(string nSM, string birthday, int telephone, string email, string position, string jobDescription)
        {
            NSM = nSM;
            this.birthday = birthday;
            this.telephone = telephone;
            this.email = email;
            this.position = position;
            JobDescription = jobDescription;
        }
        public void getInfo()
        {
            Console.WriteLine($"ПІБ: {NSM}\nДата народження: {birthday}\nНомер телефону: {telephone}\n" +
                $"Емейл: {email}\nПосада: {position}\nОпис службових обов’язків:{JobDescription}\n");
        }

        public void setNSM(string nSM) { NSM = nSM; }
        public void setBirthday(string birthday) { this.birthday = birthday; }
        public void setTel(int tel) { telephone = tel; }
        public void setEmail(string email) { this.email = email; }
        public void setPosition(string position) {  this.position = position; }
        public void setJobDescription(string JobDescription) { this.JobDescription = JobDescription; }

    }
}
