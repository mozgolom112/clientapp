namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.militaryCompanyDataSet = new WindowsFormsApp1.MilitaryCompanyDataSet();
            this.addition_techBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addition_techTableAdapter = new WindowsFormsApp1.MilitaryCompanyDataSetTableAdapters.addition_techTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.MilitaryCompanyDataSetTableAdapters.TableAdapterManager();
            this.addition_techBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.addition_techBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.addition_techDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.militaryCompanyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addition_techBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addition_techBindingNavigator)).BeginInit();
            this.addition_techBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addition_techDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // militaryCompanyDataSet
            // 
            this.militaryCompanyDataSet.DataSetName = "MilitaryCompanyDataSet";
            this.militaryCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addition_techBindingSource
            // 
            this.addition_techBindingSource.DataMember = "addition_tech";
            this.addition_techBindingSource.DataSource = this.militaryCompanyDataSet;
            // 
            // addition_techTableAdapter
            // 
            this.addition_techTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.addition_personal_gunTableAdapter = null;
            this.tableAdapterManager.addition_techTableAdapter = this.addition_techTableAdapter;
            this.tableAdapterManager.ammoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.crewTableAdapter = null;
            this.tableAdapterManager.FuelTableAdapter = null;
            this.tableAdapterManager.groupTableAdapter = null;
            this.tableAdapterManager.gunTableAdapter = null;
            this.tableAdapterManager.ID_techTableAdapter = null;
            this.tableAdapterManager.IDpersonalgunTableAdapter = null;
            this.tableAdapterManager.KomandirovkiTableAdapter = null;
            this.tableAdapterManager.Model_of_personalgunTableAdapter = null;
            this.tableAdapterManager.ModelTableAdapter = null;
            this.tableAdapterManager.personal_fileTableAdapter = null;
            this.tableAdapterManager.Plan_of_repaireTableAdapter = null;
            this.tableAdapterManager.RepaireTableAdapter = null;
            this.tableAdapterManager.ScladofammoTableAdapter = null;
            this.tableAdapterManager.ScladoffuelTableAdapter = null;
            this.tableAdapterManager.sootvetctvieTableAdapter = null;
            this.tableAdapterManager.specializeTableAdapter = null;
            this.tableAdapterManager.status_of_personal_gunTableAdapter = null;
            this.tableAdapterManager.Status_of_repaireTableAdapter = null;
            this.tableAdapterManager.statusoftechTableAdapter = null;
            this.tableAdapterManager.statusTableAdapter = null;
            this.tableAdapterManager.tech_with_TTXTableAdapter = null;
            this.tableAdapterManager.TTXTableAdapter = null;
            this.tableAdapterManager.type_of_personalgunTableAdapter = null;
            this.tableAdapterManager.typeandmodelTableAdapter = null;
            this.tableAdapterManager.typeoftechTableAdapter = null;
            this.tableAdapterManager.typewithmodelgunTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.MilitaryCompanyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // addition_techBindingNavigator
            // 
            this.addition_techBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.addition_techBindingNavigator.BindingSource = this.addition_techBindingSource;
            this.addition_techBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.addition_techBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.addition_techBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.addition_techBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.addition_techBindingNavigatorSaveItem});
            this.addition_techBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.addition_techBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.addition_techBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.addition_techBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.addition_techBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.addition_techBindingNavigator.Name = "addition_techBindingNavigator";
            this.addition_techBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.addition_techBindingNavigator.Size = new System.Drawing.Size(862, 30);
            this.addition_techBindingNavigator.TabIndex = 0;
            this.addition_techBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 30);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(61, 23);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 27);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // addition_techBindingNavigatorSaveItem
            // 
            this.addition_techBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addition_techBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("addition_techBindingNavigatorSaveItem.Image")));
            this.addition_techBindingNavigatorSaveItem.Name = "addition_techBindingNavigatorSaveItem";
            this.addition_techBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.addition_techBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.addition_techBindingNavigatorSaveItem.Click += new System.EventHandler(this.addition_techBindingNavigatorSaveItem_Click);
            // 
            // addition_techDataGridView
            // 
            this.addition_techDataGridView.AutoGenerateColumns = false;
            this.addition_techDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addition_techDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.addition_techDataGridView.DataSource = this.addition_techBindingSource;
            this.addition_techDataGridView.Location = new System.Drawing.Point(283, 115);
            this.addition_techDataGridView.Name = "addition_techDataGridView";
            this.addition_techDataGridView.RowTemplate.Height = 24;
            this.addition_techDataGridView.Size = new System.Drawing.Size(300, 220);
            this.addition_techDataGridView.TabIndex = 1;
            this.addition_techDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.addition_techDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_person";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_person";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_tech";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_tech";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 434);
            this.Controls.Add(this.addition_techDataGridView);
            this.Controls.Add(this.addition_techBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.militaryCompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addition_techBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addition_techBindingNavigator)).EndInit();
            this.addition_techBindingNavigator.ResumeLayout(false);
            this.addition_techBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addition_techDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MilitaryCompanyDataSet militaryCompanyDataSet;
        private System.Windows.Forms.BindingSource addition_techBindingSource;
        private MilitaryCompanyDataSetTableAdapters.addition_techTableAdapter addition_techTableAdapter;
        private MilitaryCompanyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator addition_techBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton addition_techBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView addition_techDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

