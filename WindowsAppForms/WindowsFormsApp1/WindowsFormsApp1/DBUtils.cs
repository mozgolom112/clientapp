using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {

            string dse = "HOME-PC";

            string datasource = "HOME-PC";
            string database = "MilitaryCompany";
            string username = "SuperClient";
            string password = "123";
            return DBSQLServerUtils.GetDBConnection(datasource, database,username,password);//, username, password);
        }
    }
}
