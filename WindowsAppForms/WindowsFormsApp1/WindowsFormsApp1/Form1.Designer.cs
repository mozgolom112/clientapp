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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.button1.Location = new System.Drawing.Point(83, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Make select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(377, 75);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(429, 296);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 53);
            this.button2.TabIndex = 2;
            this.button2.Text = "Make insert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(83, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 53);
            this.button3.TabIndex = 3;
            this.button3.Text = "Make simple insert";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(235, 169);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 53);
            this.button4.TabIndex = 4;
            this.button4.Text = "Update with status 4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите ID бойца, чтобы обновить статус 4";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(695, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(111, 22);
            this.textBox2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 434);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.militaryCompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addition_techBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MilitaryCompanyDataSet militaryCompanyDataSet;
        private System.Windows.Forms.BindingSource addition_techBindingSource;
        private MilitaryCompanyDataSetTableAdapters.addition_techTableAdapter addition_techTableAdapter;
        private MilitaryCompanyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MilitaryCompanyDataSetTableAdapters.ID_techTableAdapter iD_techTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

