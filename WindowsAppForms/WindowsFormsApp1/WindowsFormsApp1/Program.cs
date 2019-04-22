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

            }

            // Вывод информации о подключении
            Console.WriteLine("Свойства подключения:");
            Console.WriteLine("\tСтрока подключения: {0}", conn.ConnectionString);
            Console.WriteLine("\tБаза данных: {0}", conn.Database);
            Console.WriteLine("\tСервер: {0}", conn.DataSource);
            Console.WriteLine("\tВерсия сервера: {0}", conn.ServerVersion);
            Console.WriteLine("\tСостояние: {0}", conn.State);
            Console.WriteLine("\tWorkstationld: {0}", conn.WorkstationId);
            Console.WriteLine("\tКлиент: {0}", conn.ClientConnectionId);



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
