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
    public partial class EditPersonForm : Form
    {
        bool[] Modified;
        bool[,] Changes;
        bool[,] NewChanges;
        bool[] ReadyToUpdate;

        ListView.CheckedListViewItemCollection ListForEdit;
        SqlConnection connection;

        private ArrayList CollectionOfStatus;
        private ArrayList CollectionOfSpec;

        Person[] ListModifyPerson;

        Person[] NewPerson;

        public EditPersonForm(ListView.CheckedListViewItemCollection CurrentList, SqlConnection connection)
        {
            InitializeComponent();

            this.ListForEdit = CurrentList;
            this.connection = connection;

            CollectionOfStatus = new ArrayList();
            CollectionOfSpec = new ArrayList();

            ListModifyPerson = new Person[ListForEdit.Count];
            NewPerson = new Person[ListForEdit.Count];

            Modified = new bool[ListForEdit.Count];

            Changes = new bool[ListForEdit.Count, 10];

            NewChanges = new bool[ListForEdit.Count, 10];

            ReadyToUpdate = new bool[ListForEdit.Count]; ;
            for (int i = 0; i < Modified.Length; i++)
            {
                Modified[i] = false;
                ReadyToUpdate[i] = false;
                for (int j = 0; j < 10; j++)
                {
                    NewChanges[i, j] = false;
                    Changes[i, j] = true;
                }
            }

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

            for (int i = 0; i < ListForEdit.Count; i++)
            {
                checkedListEdit12.Items.Add(ListForEdit[i].SubItems[0].Text + " "
                    + ListForEdit[i].SubItems[1].Text);
                ListModifyPerson[i] = new Person(ListForEdit[i], CollectionOfSpec, CollectionOfStatus);
                NewPerson[i] = new Person(ListForEdit[i], CollectionOfSpec, CollectionOfStatus);

            }

            comboSpec.Items.AddRange(CollectionOfSpec.ToArray());
            comboStatus.Items.AddRange(CollectionOfStatus.ToArray());

            checkedListEdit12.SelectedIndex = 0;

        }

        private void EmptyInsertValue()
        {
            textBoxSurname.Text = "";

        }

        private void ChangeColorMod(bool[] Modify,bool[] NC, bool ModOn)
        {
            if (Modify[0] &&ModOn&&NC[0]) { labelSurname.BackColor = Color.Yellow; } else { labelSurname.BackColor = Color.Green; }
            if (Modify[1] && ModOn && NC[1]) { labelName.BackColor = Color.Yellow; } else { labelName.BackColor = Color.Green; }
            if (Modify[2] && ModOn && NC[2]) { labelSecondName.BackColor = Color.Green; } else { labelSecondName.BackColor = Color.Green; }
            if (Modify[3] && ModOn && NC[3]) { labelYoB.BackColor = Color.Yellow; } else { labelYoB.BackColor = Color.Green; }
            if (Modify[4] && ModOn && NC[4]) { labelPersonalID.BackColor = Color.Yellow; } else { labelPersonalID.BackColor = Color.Green; }
            if (Modify[5] && ModOn && NC[5]) { labelSpecialize.BackColor = Color.Yellow; } else { labelSpecialize.BackColor = Color.Green; }
            if (Modify[6] && ModOn && NC[6]) { labelPosition.BackColor = Color.Yellow; } else { labelPosition.BackColor = Color.Green; }
            if (Modify[7] && ModOn && NC[7]) { labelStatus.BackColor = Color.Yellow; } else { labelStatus.BackColor = Color.Green; }
            if (Modify[8] && ModOn && NC[8]) { labelSalary.BackColor = Color.Yellow; } else { labelSalary.BackColor = Color.Green; }

        }

        private void InsertValue(Person person)
        {
            textBoxSurname.TextChanged -= textBoxSurname_TextChanged;
            textBoxSurname.Text = person.GetSurname();
            textBoxSurname.TextChanged += textBoxSurname_TextChanged;


            textBoxName.TextChanged -= textBoxName_TextChanged;
            textBoxName.Text = person.GetFirstname();
            textBoxName.TextChanged += textBoxName_TextChanged;

            textBoxSecondname.TextChanged -= textBoxSecondname_TextChanged;
            textBoxSecondname.Text = person.GetSecondname();
            textBoxSecondname.TextChanged += textBoxSecondname_TextChanged;


            textBoxYoB.TextChanged -= textBoxYoB_TextChanged;
            textBoxYoB.Text = person.GetYear().ToString();
            textBoxYoB.TextChanged += textBoxYoB_TextChanged;
            

            textBoxID.Text = person.GetPersonalID().ToString();


            comboSpec.SelectedIndexChanged-= comboSpec_SelectedIndexChanged;
            if (person.GetSpecKey() >= 6) { comboSpec.SelectedIndex = person.GetSpecKey() - 2; }
                if (person.GetSpecKey() >= 4)
            {
                comboSpec.SelectedIndex = person.GetSpecKey() - 2;
            }
            else
            {
                comboSpec.SelectedIndex = person.GetSpecKey() - 1;
            }

            comboSpec.SelectedIndexChanged += comboSpec_SelectedIndexChanged;


            textBoxPosition.TextChanged -= textBoxPosition_TextChanged;
            textBoxPosition.Text = person.GetPosition();
            textBoxPosition.TextChanged += textBoxPosition_TextChanged;


            comboStatus.SelectedIndexChanged -= comboStatus_SelectedIndexChanged;
            comboStatus.SelectedIndex = person.GetStatusKey() - 1;
            comboStatus.SelectedIndexChanged += comboStatus_SelectedIndexChanged;


            textBoxSalary.TextChanged -= textBoxSalary_TextChanged;
            textBoxSalary.Text = person.GetSalary().ToString();
            textBoxSalary.TextChanged += textBoxSalary_TextChanged;


            checkBox1.Checked = false;
        }
       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Text = "Согласен";
                Changes[checkedListEdit12.SelectedIndex, 9] = true;
            }
            else
            {
                checkBox1.Text = "Не согласен";
                Changes[checkedListEdit12.SelectedIndex, 9] = false;
            }
        }

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NewPerson[checkedListEdit12.SelectedIndex].SetSurname(textBoxSurname.Text);
                labelSurname.BackColor = Color.Yellow;
                Changes[checkedListEdit12.SelectedIndex, 0] = true;
                NewChanges[checkedListEdit12.SelectedIndex, 0] = true;
                Modified[checkedListEdit12.SelectedIndex] = false;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка ввода", MessageBoxButtons.OK);
                labelSurname.BackColor = Color.Red;
                Changes[checkedListEdit12.SelectedIndex, 0] = false;
                NewChanges[checkedListEdit12.SelectedIndex, 0] = true;
                Modified[checkedListEdit12.SelectedIndex] = false;
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NewPerson[checkedListEdit12.SelectedIndex].SetFirstname(textBoxName.Text);
                labelName.BackColor = Color.Yellow;
                Changes[checkedListEdit12.SelectedIndex, 1] = true;
                NewChanges[checkedListEdit12.SelectedIndex, 1] = true;
                Modified[checkedListEdit12.SelectedIndex] = false;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка ввода", MessageBoxButtons.OK);
                labelName.BackColor = Color.Red;
                Changes[checkedListEdit12.SelectedIndex, 1] = false;
                NewChanges[checkedListEdit12.SelectedIndex, 1] = true;
                Modified[checkedListEdit12.SelectedIndex] = false;
            }
        }

        private void textBoxSecondname_TextChanged(object sender, EventArgs e)
        {
            NewPerson[checkedListEdit12.SelectedIndex].SetSecondname(textBoxSecondname.Text);
            labelSecondName.BackColor = Color.Yellow;
            Changes[checkedListEdit12.SelectedIndex, 2] = true;
            NewChanges[checkedListEdit12.SelectedIndex, 2] = true;
            Modified[checkedListEdit12.SelectedIndex] = false;
        }

        private void textBoxYoB_TextChanged(object sender, EventArgs e)
        {
            Int32 value;
            bool numbers = Int32.TryParse(textBoxYoB.Text, out value);             
            if (numbers && value < 0) {
                MessageBox.Show("Дата не может быть отрицательная", "Ошибка ввода", MessageBoxButtons.OK);
                labelYoB.BackColor = Color.Red;
            }
            if (value < 1700) { return; }
            if (!numbers || value < 1700)
            { Changes[checkedListEdit12.SelectedIndex, 3] = false;
                NewChanges[checkedListEdit12.SelectedIndex, 3] = true;
                Modified[checkedListEdit12.SelectedIndex] = false;
                labelYoB.BackColor = Color.Red;
                MessageBox.Show("Дата не может быть отрицательная или быть текстом", "Ошибка ввода", MessageBoxButtons.OK);
                return; }
            try
            {
                NewPerson[checkedListEdit12.SelectedIndex].Setyear(value);
                labelYoB.BackColor = Color.Yellow;
                Changes[checkedListEdit12.SelectedIndex, 3] = true;
                NewChanges[checkedListEdit12.SelectedIndex, 3] = true;
                Modified[checkedListEdit12.SelectedIndex] = false;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка ввода", MessageBoxButtons.OK);
                labelYoB.BackColor = Color.Red;
                Changes[checkedListEdit12.SelectedIndex, 3] = false;
                NewChanges[checkedListEdit12.SelectedIndex, 3] = true;
                Modified[checkedListEdit12.SelectedIndex] = false;
            }
        }

        private void comboSpec_SelectedIndexChanged(object sender, EventArgs e)
        {   //Косяк базы! Костыль
            int key = comboSpec.SelectedIndex;
            if (comboSpec.SelectedIndex > 1)
            {
                key += 2;
            }
            else
            {
                key++;
            }
            if (comboSpec.SelectedIndex > 4)
            {
                key++;
            }
            try
            {
                NewPerson[checkedListEdit12.SelectedIndex].SetSpec_key(key);
                labelSpecialize.BackColor = Color.Yellow;
                Changes[checkedListEdit12.SelectedIndex, 5] = true;
                NewChanges[checkedListEdit12.SelectedIndex, 5] = true;
                Modified[checkedListEdit12.SelectedIndex] = false;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка ввода", MessageBoxButtons.OK);
                labelSpecialize.BackColor = Color.Red;
                Changes[checkedListEdit12.SelectedIndex, 5] = false;
                NewChanges[checkedListEdit12.SelectedIndex, 5] = true;
                Modified[checkedListEdit12.SelectedIndex] = false;
            }

        }

        private void textBoxPosition_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NewPerson[checkedListEdit12.SelectedIndex].SetPosition(textBoxPosition.Text);
                labelPosition.BackColor = Color.Yellow;
                Changes[checkedListEdit12.SelectedIndex, 6] = true;
                NewChanges[checkedListEdit12.SelectedIndex, 6] = true;
                Modified[checkedListEdit12.SelectedIndex] = false;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка ввода", MessageBoxButtons.OK);
                labelPosition.BackColor = Color.Red;
                Changes[checkedListEdit12.SelectedIndex, 6] = false;
                NewChanges[checkedListEdit12.SelectedIndex, 6] = true;
                Modified[checkedListEdit12.SelectedIndex] = false;
            }
        }

        private void comboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = comboStatus.SelectedIndex + 1;

            try
            {
                NewPerson[checkedListEdit12.SelectedIndex].SetStatus(value);
                labelStatus.BackColor = Color.Yellow;
                Changes[checkedListEdit12.SelectedIndex, 7] = true;
                NewChanges[checkedListEdit12.SelectedIndex, 7] = true;
                Modified[checkedListEdit12.SelectedIndex] = false;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка ввода", MessageBoxButtons.OK);
                labelStatus.BackColor = Color.Red;
                Changes[checkedListEdit12.SelectedIndex, 7] = false;
                NewChanges[checkedListEdit12.SelectedIndex, 7] = true;
                Modified[checkedListEdit12.SelectedIndex] = false;
            }
        }

        private void textBoxSalary_TextChanged(object sender, EventArgs e)
        {
            Int32 value;
            bool numbers = Int32.TryParse(textBoxSalary.Text, out value);
            if (!numbers || value < 0) {
                Changes[checkedListEdit12.SelectedIndex, 8] = false;
                NewChanges[checkedListEdit12.SelectedIndex, 8] = true;
                Modified[checkedListEdit12.SelectedIndex] = false;
                labelSalary.BackColor = Color.Red;
                MessageBox.Show("Зарплата не может быть отрицательная или быть текстом", "Ошибка ввода", MessageBoxButtons.OK);           
                return; }
            try
            {
                NewPerson[checkedListEdit12.SelectedIndex].SetSalary(value);
                labelSalary.BackColor = Color.Yellow;
                Changes[checkedListEdit12.SelectedIndex, 8] = true;
                NewChanges[checkedListEdit12.SelectedIndex, 8] = true;
                Modified[checkedListEdit12.SelectedIndex] = false;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка ввода", MessageBoxButtons.OK);
                labelSalary.BackColor = Color.Red;
                Changes[checkedListEdit12.SelectedIndex, 8] = false;
                NewChanges[checkedListEdit12.SelectedIndex, 8] = true;
                Modified[checkedListEdit12.SelectedIndex] = false;
            }
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            ReadyToUpdate[checkedListEdit12.SelectedIndex] = true;
            for (int i = 0; i < 10; i++)
            {
                if (Changes[checkedListEdit12.SelectedIndex, i] == false)
                {
                    ReadyToUpdate[checkedListEdit12.SelectedIndex] = false;
                    Modified[checkedListEdit12.SelectedIndex] = false;
                }
            }
            if (ReadyToUpdate[checkedListEdit12.SelectedIndex])
            {
                MessageBox.Show("Данные готовы для обновления", "Проверка", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Данные не заполненны или имеют ошибки", "Проверка", MessageBoxButtons.OK);
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            ReadyToUpdate[checkedListEdit12.SelectedIndex] = true;
            for (int i = 0; i < 10; i++)
            {
                if (Changes[checkedListEdit12.SelectedIndex, i] == false)
                {
                    ReadyToUpdate[checkedListEdit12.SelectedIndex] = false;
                }
            }
            if (ReadyToUpdate[checkedListEdit12.SelectedIndex])
            {
                Modified[checkedListEdit12.SelectedIndex] = true;
                MessageBox.Show("Данные готовы для обновления", "Проверка", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Данные не заполненны или имеют ошибки", "Проверка", MessageBoxButtons.OK);

            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool[] colormod_checked = new bool[10];
            bool[] colormod_newchecked = new bool[10];
            labelwithtitleID.Text = checkedListEdit12.SelectedItem.ToString();
            foreach (int index in checkedListEdit12.CheckedIndices) 
            {
                if (index == checkedListEdit12.SelectedIndex)
                {
                    Modified[checkedListEdit12.SelectedIndex] = true;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                colormod_checked[i] = Changes[checkedListEdit12.SelectedIndex, i];
                colormod_newchecked[i] = NewChanges[checkedListEdit12.SelectedIndex, i];

            }
            ChangeColorMod(colormod_checked, colormod_newchecked, Modified[checkedListEdit12.SelectedIndex]);
            if (Modified[checkedListEdit12.SelectedIndex])
            {
                InsertValue(NewPerson[checkedListEdit12.SelectedIndex]);

            }
            else
            {
                InsertValue(ListModifyPerson[checkedListEdit12.SelectedIndex]);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string textErr = "";
            bool AllOk = true;
            DialogResult result = MessageBox.Show("Вы уверены что хотите обновить данные" +
                "\nСтарые данные будут утеряны?",
                   "Проверка",
                   MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                for(int i = 0; i < Modified.Length; i++)
                {
                    if (Modified[i]) {

                        bool[] NC = new bool[10];
                        for(int j = 0; j < 10; j++)
                        {
                            NC[j] = NewChanges[i, j];
                        }

                        SqlTransaction transaction = connection.BeginTransaction();
                        SqlCommand command = NewPerson[i].MkUpdate(NC);
                    command.Connection = connection;
                    command.Transaction = transaction;


                    try { 
                        command.ExecuteNonQuery();
                        transaction.Commit();
                            ListModifyPerson[i] = NewPerson[i];
                            for (int j = 0; j < 10; j++)
                            {
                                NewChanges[i, j] = false;
                            }
                        }
                        catch (Exception exp)
                    {
                        AllOk = false;
                        textErr += "\n Номер дела:" + NewPerson[i].GetPersonalID() + " - "+exp.Message;
                        transaction.Rollback();
                    }

                        }
                }
                if (AllOk)
                {
                    MessageBox.Show("Все транзакции прошли успешно. Данные обновленны", "Успех", MessageBoxButtons.OK);

                }
                else
                {
                    MessageBox.Show("Не все транзакции прошли успешно. Ошибки: " + textErr, "Ошибка", MessageBoxButtons.OK);
                }
                if (checkedListEdit12.Items != null)
                {                    
                        //если остался хотя бы один элемент
                }
                else
                {
                    MessageBox.Show("Документов не осталось.", "Переход", MessageBoxButtons.OK);
                    buttonClearAll.PerformClick(); //очищаем просто
                    textBoxID.Text = "Перейдите в окно создания";
                    buttonExit.PerformClick();
                }
            }
            else { return; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonalFiles form = new PersonalFiles(connection);
            this.Close();
            form.Show();
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            Person empty = new Person();
            InsertValue(empty);
            int index = checkedListEdit12.SelectedIndex;
            textBoxID.Text = ListModifyPerson[index].GetPersonalID().ToString();
            for (int j = 0; j < 10; j++)
            {
                Changes[index, j] = false;
            }

        }

        private void buttonUpdateGroupOnly_Click(object sender, EventArgs e)
        {
            string textErr = "";
            bool AllOk = true;
            string TextBigCommand = "";
            DialogResult result = MessageBox.Show("Вы уверены что хотите обновить данные" +
                "\nСтарые данные будут утеряны?",
                   "Проверка",
                   MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlTransaction transaction = connection.BeginTransaction();
                for (int i = 0; i < Modified.Length; i++)
                {
                    if (Modified[i])
                    {

                        bool[] NC = new bool[10];
                        for (int j = 0; j < 10; j++)
                        {
                            NC[j] = NewChanges[i, j];
                        }
                        SqlCommand command = NewPerson[i].MkUpdate(NC);
                        TextBigCommand += command.CommandText.ToString() + " ";
                    }
                }
                try
                {
                    SqlCommand BigCommand = new SqlCommand(TextBigCommand);
                    BigCommand.Connection = connection;
                    BigCommand.Transaction = transaction;
                    BigCommand.ExecuteNonQuery();
                    transaction.Commit();

                    for (int i = 0; i < Modified.Length; i++)
                    {
                        if (Modified[i])
                        {
                            ListModifyPerson[i] = NewPerson[i];
                            for (int j = 0; j < 10; j++)
                            {
                                NewChanges[i, j] = false;
                            }

                        }
                    }
                }
                catch (Exception exp)
                {
                    AllOk = false;
                    textErr = exp.Message;
                    transaction.Rollback();
                }

                    
                
                if (AllOk)
                {
                    MessageBox.Show("Все транзакции прошли успешно. Данные обновленны", "Успех", MessageBoxButtons.OK);

                }
                else
                {
                    MessageBox.Show("Не все транзакции прошли успешно. Транзакция полностью отменена. " +
                        "\nРекомендуется вызвать изменения последовательно. Так вы узнаете в каком месте произошла ошибка" +
                        "\nОшибки: " + textErr, "Ошибка", MessageBoxButtons.OK);
                }
                if (checkedListEdit12.Items != null)
                {
                    //если остался хотя бы один элемент
                }
                else
                {
                    MessageBox.Show("Документов не осталось.", "Переход", MessageBoxButtons.OK);
                    buttonClearAll.PerformClick(); //очищаем просто
                    textBoxID.Text = "Перейдите в окно создания";
                    buttonExit.PerformClick();
                }
            }
            else { return; }
        }


    }
}
