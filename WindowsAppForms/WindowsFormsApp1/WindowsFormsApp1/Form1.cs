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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addition_techBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.addition_techBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.militaryCompanyDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "militaryCompanyDataSet.addition_tech". При необходимости она может быть перемещена или удалена.
            this.addition_techTableAdapter.Fill(this.militaryCompanyDataSet.addition_tech);

        }

        private void addition_techDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
