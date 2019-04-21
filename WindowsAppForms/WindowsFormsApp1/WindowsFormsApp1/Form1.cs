﻿using System;
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
                Console.WriteLine(exp.ToString());
                conn.Close();
                conn.Dispose();
            }
            conn.Close();
            conn.Dispose();
            Console.WriteLine();
        }
    }
}
