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

        private DataSet DataCurrentSet;

        DateTime LastUpdate;
        
        string TypeOfSearch;
        string ValueOfSearch;

        string TypeOfSelect;

        private void CheckOutFromDB(SqlConnection conn)
        {
            try
            {
                this.DataCurrentSet = new DataSet();
                string sql = "Exec prall_about_person_info";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(DataCurrentSet);
                this.LastUpdate = DateTime.Now;
                labelLastLoadTime.Text = LastUpdate.ToString();
            }
            catch (Exception exp)
            {
                DialogResult result = MessageBox.Show("\tОшибка подключения: \n" + exp.Message +
                    "\t\nНевозможно подключиться к БД", "Соединение с сервером", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Retry)
                {
                    CheckOutFromDB(conn);
                }
                else
                {
                    return;
                }
            }   
        }
        public PersonalFiles(SqlConnection current_conn)
        {
            
            InitializeComponent();

            this.connection = current_conn;

            CollectionOfStatus = new ArrayList();
            CollectionOfSpec = new ArrayList();

            TypeOfSearch = "";
            ValueOfSearch = "";

           // SqlDataReader r = DataCurrentSet.Tables.Add CreateDataReader();

            cmboBoxSettingsOfSearch.Items.AddRange(new string[] { "ID", "Фамилия" ,"Имя" ,
                                                                "Год рождения","Специальность","Должность",
                                                                "Статус","Выбрать всех" });
            cmboBoxSettingsOfSearch.SelectedIndex = 7;

            cmboBoxSelectSettings.Items.AddRange(new string[] { "ID", "Год рождения", "Зарплата" });

            cmboBoxSelectSettings.SelectedIndex = 0;

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

            //создание локальной версии
            try {
                CheckOutFromDB(connection);
            }
            catch(Exception exp)
            {
                DialogResult result = MessageBox.Show("\tОшибка подключения: \n" +exp.Message+
                    "\t\nНевозможно подключиться к БД", "Соединение с сервером", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Retry)
                {
                    
                }
            }

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

            DataSet DataSetWay;
            DataTableReader reader;
            ValueOfSearch = cmbBoxStringOfSearch.Text.ToString();

            if (connection.State != ConnectionState.Open) { checkBoxLoadFromHard.Checked = true; }

        if (!checkBoxLoadFromHard.Checked) {  //выгрузка данных
            bool FullUpdate = false;
    
            SqlDataAdapter adapter;
            DataSet DataSetFromServer;
                
            string sql;
            

            if ((cmboBoxSettingsOfSearch.SelectedIndex == 7) ||(ValueOfSearch=="")) //если выбрать все, то вызываем просто процедуру
            {
                sql = "Exec prall_about_person_info";
                    FullUpdate = true;
            }
            else {
                    sql = 
                             "create table #result_of_search(ID int, " +
                             "Surname varchar(50), " +
                             "Firstname varchar(50), " +
                             "SecondName varchar(50), " +
                             "yearofbirthday int, " +
                             "Specialize varchar(100), " +
                             "Position varchar(50), " +
                             "Salary int, " +
                             "Status varchar(50)) " +
                         "insert #result_of_search " +
                         "exec prall_about_person_info " +
                         "SELECT * FROM #result_of_search "+
                         "WHERE " + TypeOfSearch + " = " + "'" +ValueOfSearch + "'";
            }
            try {
            adapter = new SqlDataAdapter(sql, connection);
            DataSetFromServer = new DataSet();
            adapter.Fill(DataSetFromServer);
            }
            catch (Exception exp)
            {
                    MessageBox.Show("Ошибка чтения. Обратитесь в службу поддержки\nОшибка: " + exp.Message, "Ошибка", MessageBoxButtons.OK);
                    return;
            }

                if (FullUpdate) //обновим заодно и нашу версию
                { DataCurrentSet = DataSetFromServer;
                 LastUpdate = DateTime.Now;
                 labelLastLoadTime.Text = LastUpdate.ToString();
                } 

                DataSetWay = DataSetFromServer;

                reader = DataSetWay.CreateDataReader();

                try
                {
                    SqlCommand rmTable = new SqlCommand("drop table #result_of_search", connection);
                    rmTable.ExecuteNonQuery();
                    //готово к выгрузке
                    listViewPerson.Items.Clear();
                }
                catch
                {
                    //уже удалена или не была создана временная таблица
                }
                listViewPerson.Items.Clear();
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
            else
            {
                if (DataCurrentSet.IsInitialized != false) {
                    DataSetWay = DataCurrentSet;
                    reader = DataSetWay.CreateDataReader();
                }
                else
                {
                    MessageBox.Show("Ошибка выгрузки данных. Попробуйте еще раз", "Ошибка", MessageBoxButtons.OK);
                    CheckOutFromDB(connection);
                    return;
                }
            

            
            
            listViewPerson.Items.Clear();

            int indexofsearch = cmboBoxSettingsOfSearch.SelectedIndex;
            if (indexofsearch > 2)
            {
                indexofsearch++; //сместили указатель на 1
            }
            
            while (reader.Read())
                {
                    if ((reader.GetValue(indexofsearch).ToString() == ValueOfSearch)||(indexofsearch==8)||(ValueOfSearch == ""))
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

        private void buttonDeletePersons_Click(object sender, EventArgs e)
        {
            
            if (listViewPerson.CheckedItems.Count == 0)
            {
                MessageBox.Show("Выберите личные дела для удаления", "Удаление", MessageBoxButtons.OK);
                return;
            }

            string[] IDForDelete = new string[listViewPerson.CheckedItems.Count];

            ListView.CheckedListViewItemCollection checkedItems = listViewPerson.CheckedItems;
            int i = 0;
            foreach (ListViewItem item in checkedItems)
            {

                IDForDelete[i] = item.SubItems[0].Text;
                i++;
            }

            string strfordelete = "Delete from personal_file where ID = ";
            
            SqlTransaction transaction = connection.BeginTransaction();
            SqlCommand command = connection.CreateCommand();
            command.Transaction = transaction;
            

            try {
                for(i=0; i < listViewPerson.CheckedItems.Count; i++)
                {

                    string sql = strfordelete + IDForDelete[i];                  
                    command.CommandText = sql;                 
                    command.ExecuteNonQuery();
                }

                DialogResult result = MessageBox.Show("\tВыбранные данные успешно готовы к удалению. \n\tПодтвердите удаление" +
                    "\n\t Внимание! Данные востановить будет невозможно!", "Удаление", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    
                    transaction.Commit();
                    buttonUpdateTable.PerformClick(); 
                    buttonSearch.PerformClick();

                }
                else
                {
                    transaction.Rollback();
                    return;
                }
                
                
            }
            catch(Exception excp)
            {
                Console.WriteLine(excp.Message);
                //Console.WriteLine("Rollback");
                MessageBox.Show("\tОшибка удаления!" +
                    "\n" + excp.Message + "\n\tПроверьте эту ошибку или обратитесь в службу поддержки", "Удаление", MessageBoxButtons.OK);
                transaction.Rollback();
                return;
            }
        }

        private void buttonMkNewPerson_Click(object sender, EventArgs e)
        {
            MakePersonForm form = new MakePersonForm(connection);
            form.Show();
        }

        private void buttonUpdateTable_Click(object sender, EventArgs e)
        {
            CheckOutFromDB(connection);
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (textBoxParaSelectFrom.Text == "" || textBoxParaSelectTo.Text == "")
            {
                MessageBox.Show("Выберете диапазон", "Выборка", MessageBoxButtons.OK);
                return;
            }


            int indexofselect=0;

            Int32 rangeFrom = Int32.Parse(textBoxParaSelectFrom.Text);
            Int32 rangeTo = Int32.Parse(textBoxParaSelectTo.Text);

            if (rangeFrom > rangeTo)
            {
                MessageBox.Show("Выберете диапазон правильно\nЛевое значение должно быть меньше правого", "Выборка", MessageBoxButtons.OK);
                return;
            }

            switch (cmboBoxSelectSettings.SelectedIndex)
            {
                case 0: { indexofselect = 0; break; }
                case 1: { indexofselect = 4; break; }
                case 2: { indexofselect = 7; break; }
            }


            foreach(ListViewItem item in listViewPerson.Items)
            {
                
                Int32 value = Int32.Parse(item.SubItems[indexofselect].Text);
                if (value >= rangeFrom && value <= rangeTo) { }
                else
                {
                    item.Remove();
                }
            }
            

        }

        private void cmboBoxSelectSettings_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxParaSelectFrom.Clear();
            textBoxParaSelectTo.Clear();

            textBoxParaSelectFrom.Focus();
        }

        private void buttonCancelSelect_Click(object sender, EventArgs e)
        {
            buttonSearch.PerformClick();
        }

        private void buttonCheckedAll_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listViewPerson.Items)
            {
                item.Checked = true;
            }
        }

        private void buttonCleanCheck_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewPerson.CheckedItems)
            {
                item.Checked = false;
            }
        }

        private void buttonChangePersons_Click(object sender, EventArgs e)
        {
            
            ListView.CheckedListViewItemCollection list_for_edit = listViewPerson.CheckedItems;
            if (list_for_edit.Count == 0)
            {
                MessageBox.Show("Выберите элементы для изменения", "Редактирование", MessageBoxButtons.OK);
                return;
            }
            else { 
            EditPersonForm FormEdit = new EditPersonForm(list_for_edit, connection);
            FormEdit.Show();
            }
        }
    }
}
