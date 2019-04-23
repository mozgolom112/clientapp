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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void WinForAuthorisation_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }





        //ComboBox for Server Name

        


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine(NameOfServer.SelectedItem.ToString());
            //Console.WriteLine(NameOfServer.Items[NameOfServer.SelectedIndex].ToString());
            if (DBName.SelectedIndex >= 0)
            {
                SqlConnection testconn = TestConn.TestNewConn(@NameOfServer.SelectedItem.ToString(), DBName.SelectedItem.ToString());
                try
                {
                    testconn.Open();
                    labelStatusOfConnection.Text = "Сервер готов к подклчючению";
                    connIsReady = true;
                }
                catch (Exception ex)
                {
                    labelStatusOfConnection.Text = "Сервер не доступен. Нажмите на Инфо, чтобы узнать об ошибке";
                    connIsReady = false;
                    //ErrMessage = ex.Message;
                }
                connection = testconn;
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

        }

        private void DBName_SelectedIndexChanged(object sender, EventArgs e)
        {
               if (NameOfServer.SelectedIndex >= 0)
                {
                    SqlConnection testconn = TestConn.TestNewConn(@NameOfServer.SelectedItem.ToString(), DBName.SelectedItem.ToString());
                    try
                    {
                    testconn.Open();
                    labelStatusOfConnection.Text = "Сервер готов к подклчючению";
                    connIsReady = true;
                    }
                    catch (Exception ex)
                    {
                    labelStatusOfConnection.Text = "Сервер не доступен. Нажмите на Инфо, чтобы узнать об ошибке";
                    connIsReady = false;
                    //ErrMessage = ex.Message;

                }
                connection = testconn;
                }
        }

        SqlConnection connection;
        string ErrMessage = "Выберите сервер и базу данных";
        bool connIsReady = false;
        bool loginIsMade = false;
        private void labelStatusOfConnection_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ErrandInfoMessage.MakeMessage(connection, connIsReady, loginIsMade);
        }
        
    }
}
