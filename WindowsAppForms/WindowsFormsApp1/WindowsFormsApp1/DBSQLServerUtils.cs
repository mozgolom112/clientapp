using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class DBSQLServerUtils
    {
        private static string TestUser = "Tester";
        private static string TestUserPass = "123";


        public static SqlConnection GetDBConnection(string datasource, string database, string username, string password)
        {
            string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=False;User ID=" + username + ";Password=" + password;
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
        public static SqlConnection GetDBConnection(string datasource, string database)
        {          
            string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=False;";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
        public static SqlConnection GetTestDBConnection(string datasource, string database)
        {
            string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=False;User ID=" + TestUser + ";Password=" + TestUserPass;
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}
