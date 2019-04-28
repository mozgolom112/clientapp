using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                Console.WriteLine("Connection successfull!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            /*
             * //Нужны права для пользоватля, чтобы вызывать имена БД
             * //Так что пока так добавлю и все
            SqlCommand cmdDbname = new SqlCommand("MilitaryCompany.sys.sp_databases", conn);
            cmdDbname.CommandType = System.Data.CommandType.StoredProcedure;
            using (SqlDataReader namedb = cmdDbname.ExecuteReader())
            {

                if (namedb.HasRows)
                {
                    while (namedb.Read())
                    {
                        Console.WriteLine(namedb.GetValue(0).ToString());
                    }
                }
            }
            */
            // Вывод информации о подключении
            Console.WriteLine("Свойства подключения:");
            Console.WriteLine("\tСтрока подключения: {0}", conn.ConnectionString);
            Console.WriteLine("\tБаза данных: {0}", conn.Database);
            Console.WriteLine("\tСервер: {0}", conn.DataSource);
         //  Console.WriteLine("\tВерсия сервера: {0}", conn.ServerVersion);
            Console.WriteLine("\tСостояние: {0}", conn.State);
            Console.WriteLine("\tWorkstationld: {0}", conn.WorkstationId);
            Console.WriteLine("\tКлиент: {0}", conn.ClientConnectionId);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            WinForAuthorisation winForAuthorisation = new WinForAuthorisation();
            winForAuthorisation.Show();

            Form1 form = new Form1();
            form.Show();

            PersonalFiles personalFiles = new PersonalFiles(conn);
           personalFiles.Show();

            Application.Run();
            
            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            */
        }
    }
}
