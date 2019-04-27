using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class GoToWorkPlaceAsk
    {
        public static void MakeMessage(string UserName, SqlConnection conn, WinForAuthorisation current)
        {
            DialogResult result = MessageBox.Show(
       "Хотите перейти на рабочий стол?",
       "Сообщение",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Information,
       MessageBoxDefaultButton.Button1,
       MessageBoxOptions.DefaultDesktopOnly);
            
            if (result == DialogResult.Yes)
            {
                current.Close();
                //выбор рабочего стола
                switch (UserName)
                {
                    case "SuperClient":
                        ForKadrovOtdel winForKadrov = new ForKadrovOtdel(conn);
                        winForKadrov.Show();
                        break;
                    default:
                        MessageBox.Show("Нет рабочего стола для вашей роли.\n"
                                        +"Пожалуйста, обратитесь в службу поддержки.", 
                                        "Ошибка вызова рабочего стола", 
                                        MessageBoxButtons.OK);
                        break;
                }
                return;
            }
            else
            {
                return;
            }
        }
    }    
}
