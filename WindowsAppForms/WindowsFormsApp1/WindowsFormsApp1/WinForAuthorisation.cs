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

    public partial class WinForAuthorisation : Form
    {
        public WinForAuthorisation()
        {
            InitializeComponent();
        }
          
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DBName.SelectedIndex >= 0)
            {
                SqlConnection testconn = DBSQLServerUtils.GetTestDBConnection(@NameOfServer.SelectedItem.ToString(), DBName.SelectedItem.ToString());
                try
                {
                    testconn.Open();
                    labelStatusOfConnection.Text = "Сервер готов к подключению";
                    connIsReady = true;
                }
                catch (Exception ex)
                {
                    labelStatusOfConnection.Text = "Сервер не доступен. Нажмите на Инфо, чтобы узнать об ошибке";
                    connIsReady = false;
                }
                connectiontest = testconn;
            }
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked == true) {
                Password.UseSystemPasswordChar = false;
            }
            else
            {
                Password.UseSystemPasswordChar = true;
            }
        }
        
        private void ButtonForConn_Click(object sender, EventArgs e)
        {
            if (NameOfServer.SelectedIndex < 0)
            {
                MessageBox.Show("\tВыберите сервер", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            if (DBName.SelectedIndex < 0)
            {
                MessageBox.Show("\tВыберите базу данных, с которой хотите работать", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            if (UserName.Text == "")
            {
                MessageBox.Show("\tВведите логин", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            if (Password.Text == "")
            {
                MessageBox.Show("\tВведите пароль", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            connectiontest.Close();
            connectionforuser = DBSQLServerUtils.GetDBConnection(@NameOfServer.SelectedItem.ToString(), 
                DBName.SelectedItem.ToString(), 
                UserName.Text, 
                Password.Text);
            try
            {
                connectionforuser.Open();
                loginIsMade = true;
                connIsReady = true;
                
                Statusofauth.Text = "Успешно";

                GoToWorkPlaceAsk.MakeMessage(UserName.Text, connectionforuser, this);

            }
            catch (Exception err)
            {
                loginIsMade = false;
                connIsReady = false;
                Statusofauth.Text = "Не успешно";
            }
        }

        private void DBName_SelectedIndexChanged(object sender, EventArgs e)
        {
               if (NameOfServer.SelectedIndex >= 0)
                {
                    SqlConnection testconn = DBSQLServerUtils.GetTestDBConnection(@NameOfServer.SelectedItem.ToString(), DBName.SelectedItem.ToString());
                    try
                    {
                    testconn.Open();
                    labelStatusOfConnection.Text = "Сервер готов к подключению";
                    connIsReady = true;
                    }
                    catch (Exception ex)
                    {
                    labelStatusOfConnection.Text = "Сервер не доступен. Нажмите на Инфо, чтобы узнать об ошибке";
                    connIsReady = false;

                }
                connectiontest = testconn;
                }
        }

        SqlConnection connectiontest;
        
        SqlConnection connectionforuser;
        string ErrMessage = "Выберите сервер и базу данных";
        bool connIsReady = false;
        bool loginIsMade = false;
        private void labelStatusOfConnection_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { connectiontest.Close(); } catch (Exception exc) {}
            try { connectionforuser.Close(); } catch (Exception exc) {}
            try { connectiontest.Open(); connIsReady = true; } catch (Exception exc) { connIsReady = false; }
                ErrandInfoMessage.MakeMessage(connectiontest, connIsReady, false);
            try { connectionforuser.Open(); connIsReady = true; } catch (Exception exc) { connIsReady = false; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ErrandInfoMessage.MakeMessage(connectionforuser, connIsReady, loginIsMade);
        }
    }
}
