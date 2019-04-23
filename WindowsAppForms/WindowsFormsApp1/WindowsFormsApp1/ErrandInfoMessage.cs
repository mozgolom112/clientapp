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
            if (connIsOpen)
            {
                message = "Соединение установлено. Свойства подключения:\n"
                        + "\nСтрока подключения: " + conn.ConnectionString
                        + "\nБаза данных: " + conn.Database
                        + "\nСервер: " + conn.DataSource
                        + "\nВерсия сервера: " + conn.ServerVersion
                        + "\nСостояние: " + conn.State ;
                if (loginIsMade)
                {
                    message += "\nWorkstationld: " + conn.WorkstationId
                                +"\nКлиент: " + conn.ClientConnectionId;
                }
                caption = "Информация о подкючении";
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
    }
}
