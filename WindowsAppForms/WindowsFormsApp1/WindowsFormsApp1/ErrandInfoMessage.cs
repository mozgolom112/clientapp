using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp1
{
    class ErrandInfoMessage
    {
        public static void MakeMessage(SqlConnection conn, bool connIsOpen, bool loginIsMade)
        {
            string message ="";
            string caption ="";
            if(conn!= null) { 
            if (connIsOpen)
            {
                message = "\t\tСоединение установлено. \nСвойства подключения:"
                        + "\n\tБаза данных: " + conn.Database
                        + "\n\tСервер: " + conn.DataSource
                        + "\n\tВерсия сервера: " + conn.ServerVersion
                        + "\n\tСостояние: " + conn.State ;
                if (loginIsMade)
                {
                    message += "\nДанные пользователя:"
                                +"\n\tСтрока подключения: " + conn.ConnectionString
                                + "\n\tWorkstationld: " + conn.WorkstationId
                                + "\n\tКлиент: " + conn.ClientConnectionId;
                }
                caption = "Информация о подключении";
            }
            else
            {
                try { conn.Open(); }
                catch (Exception err)
                {
                    message = err.Message;
                    caption = "Информация об ошибке";
                }
            }

            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;


            result = MessageBox.Show(message, caption, buttons);
            }
            else
            {
                MessageBox.Show("Попытки подключения нет. Статуса ошибки нет", "Информация", MessageBoxButtons.OK);
            }


        }
    }
}
