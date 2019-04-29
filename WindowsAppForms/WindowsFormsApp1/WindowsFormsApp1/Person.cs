using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;

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

        public Person() { }

        public Person(ListViewItem collection, ArrayList SpecKey, ArrayList StatusKey)
        {
            SetPersonalID(Int32.Parse(collection.SubItems[0].Text));
            
            Surname = collection.SubItems[1].Text;
            Firstname = collection.SubItems[2].Text;
            Secondname = collection.SubItems[3].Text;

            year = Int32.Parse(collection.SubItems[4].Text);

            Spec_key = SpecKey.IndexOf(collection.SubItems[5].Text);
            if(Spec_key>1)
            {
                Spec_key += 2;
            }
            else
            {
                Spec_key++;
            }

            Position = collection.SubItems[6].Text;

            Salary = Int32.Parse(collection.SubItems[7].Text);

            status_key = StatusKey.IndexOf(collection.SubItems[8].Text) + 1;
            

        }

        public SqlCommand MkUpdate(bool[] changes)
        {
            string sqlExpression = "";
            bool updateCrew = false;
            for(int i = 1; i <= 4; i++)
            {
                if (i == 4) { i = 7; }
                if (changes[i]) {
                    if (updateCrew)
                    {
                        sqlExpression = "Update crew Set ";
                    }
                    string add = "";
                    switch (i)
                    {
                        case 1: { add = " Surname = " + GetSurname(); break; }
                        case 2: { add = " Firstname = " + GetFirstname(); break; }
                        case 3: { add = " Secondname = " + GetSecondname(); break; }
                        case 7: { add = " Status = " + GetStatusKey().ToString(); break; }
                    }
                    sqlExpression += add;
                }
            }

            

        }


        public SqlCommand MkInsert()
        {
            string sqlExpression = "exec prAddPersonInfo " +
                                     "@ID_person, " +

                                     "@Group, " +
                                     "@Spec, " +
                                     "@Position, " +
                                     "@Salary, " +

                                     "@Surname, " +
                                     "@Firstname, " +
                                     "@Secondname, " +

                                     "@Status, " +
                                     "@year ";
            SqlCommand command = new SqlCommand(sqlExpression);

            SqlParameter ID_person = new SqlParameter("@ID_person", GetPersonalID());
            command.Parameters.Add(ID_person);

            SqlParameter Group = new SqlParameter("@Group", 1);
            command.Parameters.Add(Group);

            SqlParameter Spec = new SqlParameter("@Spec", GetSpecKey());
            command.Parameters.Add(Spec);

            SqlParameter Position = new SqlParameter("@Position", GetPosition());
            command.Parameters.Add(Position);

            SqlParameter Salary = new SqlParameter("@Salary", GetSalary());
            command.Parameters.Add(Salary);

            SqlParameter Surname = new SqlParameter("@Surname", GetSurname());
            command.Parameters.Add(Surname);

            SqlParameter Firstname = new SqlParameter("@Firstname", GetFirstname());
            command.Parameters.Add(Firstname);

            SqlParameter Secondname = new SqlParameter("@Secondname", GetSecondname());
            command.Parameters.Add(Secondname);

            SqlParameter Status = new SqlParameter("@Status", GetStatusKey());
            command.Parameters.Add(Status);

            SqlParameter year = new SqlParameter("@year", GetYear());
            command.Parameters.Add(year);

            return command;
        }

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

        public string GetSecondname()
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
