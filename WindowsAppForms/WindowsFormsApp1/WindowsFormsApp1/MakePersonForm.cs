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
    public partial class MakePersonForm : Form
    {
        bool[] Check;

        SqlConnection connection;
        Person NewPerson;
        private ArrayList CollectionOfStatus;
        private ArrayList CollectionOfSpec;

        public MakePersonForm(SqlConnection connection)
        {
            InitializeComponent();

            CollectionOfStatus = new ArrayList();
            CollectionOfSpec = new ArrayList();

            Check = new bool[10];
            for(int i = 0; i < Check.Length; i++)
            {
                Check[i] = false;
            }


            this.connection = connection;

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
            NewPerson = new Person();

            comboSpec.Items.AddRange(CollectionOfSpec.ToArray());
            comboStatus.Items.AddRange(CollectionOfStatus.ToArray());


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MakePersonForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool ReadyForInsert = true;
            for (int i = 0; i < Check.Length; i++)
            {
                if (Check[i] == false)
                {
                    ReadyForInsert = false;
                }
            }
            if (ReadyForInsert)
            {
               DialogResult result = MessageBox.Show("Вы уверены что хотите вставить?", 
                   "Проверка", 
                   MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SqlTransaction transaction = connection.BeginTransaction();
                    SqlCommand command = NewPerson.MkInsert();
                    command.Connection = connection;
                    command.Transaction = transaction;
                    
                    //SqlCommand command = NewPerson.MkInsert();
                    //command.connection.CreateCommand();
                    //command.Connection.CreateCommand();
                    //command.Transaction = transaction;
                    try
                    {
                        //SqlCommand command = NewPerson.MkInsert();
                        command.ExecuteNonQuery();

                        transaction.Commit();

                        DialogResult resultfinish = MessageBox.Show("Данные успешно вставленны.\nХотите создать еще?", "Успех", MessageBoxButtons.YesNo);
                        if (resultfinish == DialogResult.Yes)
                        {
                            buttonClearAll.PerformClick();
                            return;
                        }
                        else
                        {
                            this.Dispose();
                            this.Close();
                        }
                    }
                    catch(Exception exp)
                    {

                        MessageBox.Show("Вставка не была успешна. Ошибка: \n" 
                            + exp.Message, 
                            "Ошибка", MessageBoxButtons.OK);
                        transaction.Rollback();
                    }
                    

                }
                else { return; }
            }
            else
            {
                MessageBox.Show("Данные не заполненны или имеют ошибки", "Проверка", MessageBoxButtons.OK);

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Text = "Согласен";
                Check[9] = true;
            }
            else
            {
                checkBox1.Text = "Не согласен";
                Check[9] = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try {
            NewPerson.SetSurname(textBoxSurname.Text);
                labelSurname.BackColor = Color.Green;
                Check[0] = true;
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка ввода", MessageBoxButtons.OK);
                labelSurname.BackColor = Color.Red;
                Check[0] = false;
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NewPerson.SetFirstname(textBoxName.Text);
                labelName.BackColor = Color.Green;
                Check[1] = true;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка ввода", MessageBoxButtons.OK);
                labelName.BackColor = Color.Red;
                Check[1] = false;
            }
        }

        private void textBoxSecondname_TextChanged(object sender, EventArgs e)
        {          
                NewPerson.SetSecondname(textBoxSecondname.Text);
                labelSecondName.BackColor = Color.Green;
                Check[2] = true;
        }

        private void textBoxYoB_TextChanged(object sender, EventArgs e)
        {
            Int32 value;
            bool numbers = Int32.TryParse(textBoxYoB.Text,out value);
            if (!numbers|| value<1700) { Check[3] = false; return; }
            try
            {
                NewPerson.Setyear(value);
                labelYoB.BackColor = Color.Green;
                Check[3] = true;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка ввода", MessageBoxButtons.OK);
                labelYoB.BackColor = Color.Red;
                Check[3] = false;
            }
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            SqlCommand sql = new SqlCommand("select ID from personal_file where ID = " + textBoxID.Text, 
                                    connection);
            SqlDataReader reader = sql.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show("Ошибка! Не может быть два одинаковых ID.\nИзмените на уникальный", 
                    "Ошибка", 
                    MessageBoxButtons.OK);
                    labelPersonalID.BackColor = Color.Red;
                    Check[4] = false;
            }
            else
            {
                try
                {
                    NewPerson.SetPersonalID(Int32.Parse(textBoxID.Text));
                    labelPersonalID.BackColor = Color.Green;
                    Check[4] = true;
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message, "Ошибка ввода", MessageBoxButtons.OK);
                    labelPersonalID.BackColor = Color.Red;
                    Check[4] = false;
                }
            }
            reader.Close();
        }

        private void comboSpec_SelectedIndexChanged(object sender, EventArgs e)
        {
            int key = comboSpec.SelectedIndex;
            if (comboSpec.SelectedIndex > 1)
            {
                key += 2;
            }
            else
            {
                key++;
            }
            try { 
                NewPerson.SetSpec_key(key);
                labelSpecialize.BackColor = Color.Green;
                Check[5] = true;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка ввода", MessageBoxButtons.OK);
                labelSpecialize.BackColor = Color.Red;
                Check[5] = false;
            }

        }

        private void textBoxPosition_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NewPerson.SetPosition(textBoxPosition.Text);
                labelPosition.BackColor = Color.Green;
                Check[6] = true;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка ввода", MessageBoxButtons.OK);
                labelPosition.BackColor = Color.Red;
                Check[6] = false;
            }
        }

        private void comboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = comboStatus.SelectedIndex + 1;

            try
            {
                NewPerson.SetStatus(value);
                labelStatus.BackColor = Color.Green;
                Check[7] = true;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка ввода", MessageBoxButtons.OK);
                labelStatus.BackColor = Color.Green;
                Check[7] = false;
            }
        }

        private void textBoxSalary_TextChanged(object sender, EventArgs e)
        {
            Int32 value;
            bool numbers = Int32.TryParse(textBoxSalary.Text, out value);
            if (!numbers || value < 0) { Check[8] = false; return; }
            try
            {
                NewPerson.SetSalary(value);
                labelSalary.BackColor = Color.Green;
                Check[8] = true;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка ввода", MessageBoxButtons.OK);
                labelSalary.BackColor = Color.Red;
                Check[8] = false;
            }
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            bool ReadyForInsert=true;
            for(int i = 0; i < Check.Length; i++)
            {
                if(Check[i] == false)
                {
                    ReadyForInsert = false;
                }
            }
            if (ReadyForInsert)
            {
                MessageBox.Show("Данные готовы для вставки", "Проверка", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Данные не заполненны или имеют ошибки", "Проверка", MessageBoxButtons.OK);

            }
        }
    }
}
