using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace WindowsFormsApp1
{
    class Person
    {
        private int PersonalID;

        private string Surname;
        private string Firstname;
        private string Secondname;

        private int year;

        private int Spec_key;

        private string Position;
        private decimal Salary;
        private int status_key;

        public string GetSurname()
        {
            return Surname;
        }


        public int GetPersonalID()
        {
            return PersonalID;
        }

        public string GetSecondname(string Secondname)
        {
           return this.Secondname;
        }

        public int GetYear()
        {
            return year;
        }

        public int GetSpecKey()
        {
            return Spec_key;
        }

        public string GetPosition()
        {
            return Position;
        }

        public decimal GetSalary()
        {
            return Salary;
        }

        public int GetStatusKey()
        {
            return status_key;
        }

        public void SetPersonalID(int ID)
        {
            PersonalID = ID;
        }

        public void SetSurname(string Surname)
        {
            if (Surname != "")
                this.Surname = Surname;
            else
                throw new Exception("Ошибка! Это поле не должно быть пустым");
        }

        public void SetSecondname(string Secondname)
        {
            this.Secondname = Secondname;
        }

        public void Setyear(int YoB)
        {
            
            if (YoB < 1800 || YoB > (DateTime.Now.Year-18))
            {
                throw new Exception("Год рождения выбрана не верно.");
            }
            else
            {
                this.year = YoB;
            }
        }

        public void SetSpec_key(int key)
        {
            this.Spec_key = key;
        }

        public void SetPosition(string Position)
        {
            this.Position = Position;
        }

        public void SetSalary(int salary)
        {
            if (salary < 0)
            {
                throw new Exception("Это поле не может быть отрицательным");
            }
            else
            {
                this.Salary = salary;
            }
        }

        public void SetStatus(int key)
        {
            this.status_key = key;
        }




    }
}
