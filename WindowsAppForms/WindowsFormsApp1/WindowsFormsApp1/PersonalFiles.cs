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

        ArrayList CollectionOfStatus = new ArrayList();
        ArrayList CollectionOfSpec = new ArrayList();


        public PersonalFiles(SqlConnection current_conn)
        {
            
            InitializeComponent();

            this.connection = current_conn;

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
                        cmbBoxStringOfSearch.Text = "";
                        cmbBoxStringOfSearch.Focus();
                        cmbBoxStringOfSearch.DropDownStyle = ComboBoxStyle.Simple;
                        break;
                    }
                case 1: //Фамилия
                    {
                        cmbBoxStringOfSearch.DropDownStyle = ComboBoxStyle.Simple;
                        break;
                    }
                case 2: //Имя
                    {
                        cmbBoxStringOfSearch.DropDownStyle = ComboBoxStyle.Simple;
                        break;
                    }
                case 3: //Год рождения
                    {
                        cmbBoxStringOfSearch.DropDownStyle = ComboBoxStyle.Simple;
                        break;
                    }
                case 4: //Специальность
                    {

                        cmbBoxStringOfSearch.DropDownStyle = ComboBoxStyle.DropDownList;
                        cmbBoxStringOfSearch.Items.Clear();
                        cmbBoxStringOfSearch.Items.AddRange(CollectionOfSpec.ToArray());

                        break;
                    }
                case 5: //Должнось
                    {

                        cmbBoxStringOfSearch.DropDownStyle = ComboBoxStyle.Simple;
                        break;
                    }
                case 6: //Статус
                    {
                        cmbBoxStringOfSearch.DropDownStyle = ComboBoxStyle.DropDownList;
                        cmbBoxStringOfSearch.Items.Clear();
                        cmbBoxStringOfSearch.Items.AddRange(CollectionOfStatus.ToArray());
                        break;
                    }
                case 7: //Выбрать всех
                    {

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
    }
}
