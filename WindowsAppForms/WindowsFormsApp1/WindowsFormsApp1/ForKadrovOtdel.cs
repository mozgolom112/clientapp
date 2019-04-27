﻿using System;
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
    public partial class ForKadrovOtdel : Form
    {
        SqlConnection connection = null;
        public ForKadrovOtdel(SqlConnection conn)
        {
            InitializeComponent();
            this.connection = conn;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            if (txtBoxNewTask.Text != "")
            {
                chListBoxTasks.Items.Add(txtBoxNewTask.Text);
                txtBoxNewTask.Clear();
            }
            else
            {
                MessageBox.Show("Введите задачу", "Добавление", MessageBoxButtons.OK);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти? Не сохраненый результат пропадет.", "Выход", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                this.Dispose();

                WinForAuthorisation winForAuthorisation = new WinForAuthorisation();
                winForAuthorisation.Show();
            }
            else
            {
                return;
            }
        }
    }
}
