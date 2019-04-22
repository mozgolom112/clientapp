using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addition_techBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.addition_techBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.militaryCompanyDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "militaryCompanyDataSet.addition_tech". При необходимости она может быть перемещена или удалена.
            this.addition_techTableAdapter.Fill(this.militaryCompanyDataSet.addition_tech);

        }

        private void addition_techDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
               // Console.WriteLine("Connection successfull!");
            }
            catch (Exception excpt)
            {
            }

            SqlCommand cmdSelectAll = new SqlCommand("SELECT * FROM crew", conn);

            using (SqlDataReader dr = cmdSelectAll.ExecuteReader(CommandBehavior.CloseConnection))
            {
                for (int i=0; i< dr.FieldCount; i++)
                {
                    Console.Write("{0}\t", dr.GetName(i).ToString().Trim());
                }
                while (dr.Read())
                {

                    for (int i=0; i < dr.FieldCount; i++)
                    {
                        Console.Write("{0}\t", dr.GetValue(i));
                        textBox1.Text += dr.GetValue(i).ToString();                      
                    }
                    //Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", dr.GetV)
                    Console.WriteLine();   
                }
                conn.Close();
                conn.Dispose();
                Console.WriteLine("Finall");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
            }
            catch(Exception exp)
            {
                
            }
            SqlCommand cmdInsert = new SqlCommand("Insert into crew (ID,Surname,Firstname,Secondname,Status,yearofbirthday)"+
                "Values (@ID,@Surname,@Firstname,@Secondname,@Status,@yearofbirthday)", conn);
            SqlParameter param = new SqlParameter();
            //параметр ID
            param.ParameterName = "@ID";
            param.Value = 9009;
            param.SqlDbType = SqlDbType.Int;
            cmdInsert.Parameters.Add(param);

            //параметр 

            param = new SqlParameter();
            param.ParameterName = "@Surname";
            param.Value = "Gilontev";
            param.SqlDbType = SqlDbType.VarChar;
            cmdInsert.Parameters.Add(param);

            //параметр 
            param = new SqlParameter();
            param.ParameterName = "@Firstname";
            param.Value = "Vasiliy";
            param.SqlDbType = SqlDbType.VarChar;
            cmdInsert.Parameters.Add(param);

            //параметр 
            param = new SqlParameter();
            param.ParameterName = "@Secondname";
            param.Value = "Sergeevich";
            param.SqlDbType = SqlDbType.VarChar;
            cmdInsert.Parameters.Add(param);

            //параметр status
            param = new SqlParameter();
            param.ParameterName = "@Status";
            param.Value = 1;
            param.SqlDbType = SqlDbType.Int;
            cmdInsert.Parameters.Add(param);

            //параметр year
            param = new SqlParameter();
            param.ParameterName = "@yearofbirthday";
            param.Value = 1989;
            param.SqlDbType = SqlDbType.Int;
            cmdInsert.Parameters.Add(param);

            Console.WriteLine("Try to insert");
            try
            {
                cmdInsert.ExecuteNonQuery();
            }
            catch(Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            
            conn.Close();
            conn.Dispose();
            Console.WriteLine();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //parametrs
            int nwID = 9011;
            string Firstname = "Ivanichex";
            string Secondname = "Oliver";
            string Surname = "Kilonter";
            int status = 1;
            int year = 1977;
            //sql запрос 
            string sqlExpresion = String.Format("Insert into crew Values ({0}, '{1}', '{2}', '{3}', {4}, {5})", nwID, Surname, Firstname, Secondname, status, year);

            using (SqlConnection connection = DBUtils.GetDBConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sqlExpresion, connection);
                try { 
                int number = command.ExecuteNonQuery();
                Console.WriteLine("Добавлено объектов: {0}", number);
                }
                catch (Exception excpt)
                {
                    Console.WriteLine(excpt.Message);
                    Console.WriteLine("Произошла ошибка. Неверный запрос");

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                Console.WriteLine("Введите номер бойца!");
                return;

            }
            int persID = Int32.Parse(textBox2.Text);
            string check = string.Format("Select ID from crew where ID = {0}", persID);

            using (SqlConnection connection = DBUtils.GetDBConnection())
            {
                connection.Open();
                /* нужно переделать
                SqlCommand cmdCheck = new SqlCommand(check, connection);
                Console.WriteLine(cmdCheck.ExecuteNonQuery().ToString());
                if (cmdCheck.ExecuteNonQuery().ToString() == "") { //возвращает -1 если пустые строки
                    Console.WriteLine("Такого бойца нет в таблице crew");
                    return;
                }
                else
                {*/
                    string update = string.Format("Update crew SET Status = 4 WHERE ID = {0}", persID);
                    SqlCommand cmdUpdate = new SqlCommand(update, connection);
                    int number = cmdUpdate.ExecuteNonQuery();
                    Console.WriteLine("Обновлено объектов: {0}", number);
                    Console.WriteLine("Хотите вызвать(обновить) обновленную таблицу?");
                    Console.WriteLine("Введите y/n: ");
                    button1.PerformClick();

                    if (Console.Read() == 'y')
                    {
                        button1.PerformClick();
                    }
//}
                connection.Close();
                connection.Dispose();


            }
        }
    }
}
