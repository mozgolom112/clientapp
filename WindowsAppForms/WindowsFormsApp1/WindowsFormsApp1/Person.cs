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
        private int Salary;
        private int status_key;

        public string GetSurname()
        {
            return Surname;
        }

        public string GetFirstname()
        {
            return Firstname;
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
            if (ID > 0) { PersonalID = ID; }
            else {
                throw new Exception("Ошибка! ID не может быть отрицательным");
            }
        }

        public void SetSurname(string Surname)
        {
            if (Surname != "")
                this.Surname = Surname;
            else
                throw new Exception("Ошибка! Это поле не должно быть пустым");
        }

        public void SetFirstname(string Firstname)
        {
            if (Firstname != "")
                this.Firstname = Firstname;
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
            if (key >= 0) { 
            this.Spec_key = key;
            }
            else
            {
                throw new Exception("Ошибка! Это поле не может быть отрицательным!");
            }
        }

        public void SetPosition(string Position)
        {
            if (Position != "") { 
            this.Position = Position;
            }
            else
                throw new Exception("Ошибка! Это поле не должно быть пустым");
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
            if (key >= 0)
            {
                this.status_key = key;
            }
            else
            {
                throw new Exception("Ошибка! Это поле не может быть отрицательным!");
            }     
        }




    }
}
