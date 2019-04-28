using System;
using System.Collections;
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
    public partial class PersonalFiles : Form
    {

        private SqlConnection connection;

        private ArrayList CollectionOfStatus;
        private ArrayList CollectionOfSpec;

        string TypeOfSearch;
        string ValueOfSearch;

        public PersonalFiles(SqlConnection current_conn)
        {
            
            InitializeComponent();

            this.connection = current_conn;

            CollectionOfStatus = new ArrayList();
            CollectionOfSpec = new ArrayList();

            TypeOfSearch = "";
            ValueOfSearch = "";

            cmboBoxSettingsOfSearch.Items.AddRange(new string[] { "ID", "Фамилия" ,"Имя" ,
                                                                "Год рождения","Специальность","Должность",
                                                                "Статус","Выбрать всех" });
            cmboBoxSettingsOfSearch.SelectedIndex = 7;

            SqlDataReader dataReader;

            SqlCommand TakeCollStatus = new SqlCommand("Select Type from status", connection);
            dataReader = TakeCollStatus.ExecuteReader();
            while (dataReader.Read())
            {
                CollectionOfStatus.Add(dataReader.GetValue(0));
            }
            dataReader.Close();

            SqlCommand TakeCollSpec = new SqlCommand("Select describe from specialize", connection);
            dataReader = TakeCollSpec.ExecuteReader();
            while (dataReader.Read())
            {
                CollectionOfSpec.Add(dataReader.GetValue(0));
            }
            dataReader.Close();


        }

        private void PersonalFiles_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "militaryCompanyDataSet.personal_file". При необходимости она может быть перемещена или удалена.
            this.personal_fileTableAdapter.Fill(this.militaryCompanyDataSet.personal_file);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmboBoxSettingsOfSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbBoxStringOfSearch.Enabled = true;
            switch (cmboBoxSettingsOfSearch.SelectedIndex){               
                case 0: //ID
                    {
                        TypeOfSearch = "ID";
                        cmbBoxStringOfSearch.DropDownStyle = ComboBoxStyle.Simple;
                        break;
                    }
                case 1: //Фамилия
                    {
                        TypeOfSearch = "Surname";
                        cmbBoxStringOfSearch.DropDownStyle = ComboBoxStyle.Simple;
                        break;
                    }
                case 2: //Имя
                    {
                        TypeOfSearch = "Firstname";
                        cmbBoxStringOfSearch.DropDownStyle = ComboBoxStyle.Simple;
                        break;
                    }
                case 3: //Год рождения
                    {
                        TypeOfSearch = "yearofbirthday";
                        cmbBoxStringOfSearch.DropDownStyle = ComboBoxStyle.Simple;
                        break;
                    }
                case 4: //Специальность
                    {
                        TypeOfSearch = "Specialize";

                        cmbBoxStringOfSearch.DropDownStyle = ComboBoxStyle.DropDownList;
                        cmbBoxStringOfSearch.Items.Clear();
                        cmbBoxStringOfSearch.Items.AddRange(CollectionOfSpec.ToArray());

                        break;
                    }
                case 5: //Должнось
                    {
                        TypeOfSearch = "Position";

                        cmbBoxStringOfSearch.DropDownStyle = ComboBoxStyle.Simple;
                        break;
                    }
                case 6: //Статус
                    {
                        TypeOfSearch = "Status";

                        cmbBoxStringOfSearch.DropDownStyle = ComboBoxStyle.DropDownList;
                        cmbBoxStringOfSearch.Items.Clear();
                        cmbBoxStringOfSearch.Items.AddRange(CollectionOfStatus.ToArray());
                        break;
                    }
                case 7: //Выбрать всех
                    {
                        TypeOfSearch = "*";

                        cmbBoxStringOfSearch.Enabled = false;
                        break;
                    }
                default:
                    {
                        
                        break;
                    }
            }
            cmbBoxStringOfSearch.Text = "";
            cmbBoxStringOfSearch.Focus();
        }

        private void cmbBoxStringOfSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            //try { connection.Open(); } catch { return; } //проверяем еще раз коннект
            Console.WriteLine(ValueOfSearch);
            SqlDataAdapter adapter;
            DataSet dataSet;
            string sql = 
                             "create table #result_of_search(ID int, " +
                             "Surname varchar(50), " +
                             "Firstname varchar(50), " +
                             "SecondName varchar(50), " +
                             "YoB int, Spec varchar(100), " +
                             "Pos varchar(50),Salary int, " +
                             "Stat varchar(50)) " +
                         "insert #result_of_search " +
                         "exec prall_about_person_info " +
                         "SELECT * FROM #result_of_search ";

            if ((cmboBoxSettingsOfSearch.SelectedIndex == 7) ||(cmbBoxStringOfSearch.Text=="")) //если выбрать все, то вызываем просто процедуру
            {
                sql = "Exec prall_about_person_info";
            }
            else {
                        sql += "WHERE "+ TypeOfSearch + " = " + ValueOfSearch;
            }

            adapter = new SqlDataAdapter(sql, connection);

            dataSet = new DataSet();

            adapter.Fill(dataSet);

            DataTableReader reader = dataSet.CreateDataReader();

           // SqlCommand sqlCom = new SqlCommand(sql, connection);
            //SqlDataReader reader = sqlCom.ExecuteReader(CommandBehavior.CloseConnection))

                while (reader.Read())
                {

                    string[] lvi_string = new string[reader.FieldCount];
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        lvi_string[i] = reader.GetValue(i).ToString();

                    }
                    ListViewItem lvi = new ListViewItem(lvi_string);
                    listViewPerson.Items.Add(lvi);

                }
            
            
        }
    }
}
