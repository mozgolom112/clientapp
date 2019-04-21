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
            this.militaryCompanyDataSet = new WindowsFormsApp1.MilitaryCompanyDataSet();
            this.addition_techBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addition_techTableAdapter = new WindowsFormsApp1.MilitaryCompanyDataSetTableAdapters.addition_techTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.MilitaryCompanyDataSetTableAdapters.TableAdapterManager();
            this.iD_techTableAdapter1 = new WindowsFormsApp1.MilitaryCompanyDataSetTableAdapters.ID_techTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.militaryCompanyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addition_techBindingSource)).BeginInit();
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
            this.tableAdapterManager.ID_techTableAdapter = this.iD_techTableAdapter1;
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
            // iD_techTableAdapter1
            // 
            this.iD_techTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 434);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.militaryCompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addition_techBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MilitaryCompanyDataSet militaryCompanyDataSet;
        private System.Windows.Forms.BindingSource addition_techBindingSource;
        private MilitaryCompanyDataSetTableAdapters.addition_techTableAdapter addition_techTableAdapter;
        private MilitaryCompanyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MilitaryCompanyDataSetTableAdapters.ID_techTableAdapter iD_techTableAdapter1;
        private System.Windows.Forms.Button button1;
    }
}

