using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class TestConn
    {
        public static SqlConnection TestNewConn(string datasource, string database)
        {
            string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=False;User ID=Tester; Password=123;";      //добавь потом роль для вывода информцаии     
            //string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=False;";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}
