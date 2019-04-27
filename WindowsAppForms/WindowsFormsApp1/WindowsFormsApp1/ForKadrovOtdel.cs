using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ForKadrovOtdel : Form
    {
        public ForKadrovOtdel()
        {
            InitializeComponent();
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
            }
            else
            {
                MessageBox.Show("Введите задачу", "Добавление", MessageBoxButtons.OK);
            }
        }
    }
}
