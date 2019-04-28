namespace WindowsFormsApp1
{
    partial class PersonalFiles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.militaryCompanyDataSet = new WindowsFormsApp1.MilitaryCompanyDataSet();
            this.personalfileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personal_fileTableAdapter = new WindowsFormsApp1.MilitaryCompanyDataSetTableAdapters.personal_fileTableAdapter();
            this.buttonMkNewPerson = new System.Windows.Forms.Button();
            this.buttonChangePersons = new System.Windows.Forms.Button();
            this.buttonDeletePersons = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.cmboBoxSettingsOfSearch = new System.Windows.Forms.ComboBox();
            this.cmboBoxSelectSettings = new System.Windows.Forms.ComboBox();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxParaSelectFrom = new System.Windows.Forms.TextBox();
            this.textBoxParaSelectTo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonUpdateTable = new System.Windows.Forms.Button();
            this.cmbBoxStringOfSearch = new System.Windows.Forms.ComboBox();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Secondname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YoB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Specialize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Salary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewPerson = new System.Windows.Forms.ListView();
            this.checkBoxLoadFromHard = new System.Windows.Forms.CheckBox();
            this.labelLastLoadTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.militaryCompanyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalfileBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // militaryCompanyDataSet
            // 
            this.militaryCompanyDataSet.DataSetName = "MilitaryCompanyDataSet";
            this.militaryCompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personalfileBindingSource
            // 
            this.personalfileBindingSource.DataMember = "personal_file";
            this.personalfileBindingSource.DataSource = this.militaryCompanyDataSet;
            // 
            // personal_fileTableAdapter
            // 
            this.personal_fileTableAdapter.ClearBeforeFill = true;
            // 
            // buttonMkNewPerson
            // 
            this.buttonMkNewPerson.Location = new System.Drawing.Point(10, 37);
            this.buttonMkNewPerson.Name = "buttonMkNewPerson";
            this.buttonMkNewPerson.Size = new System.Drawing.Size(116, 30);
            this.buttonMkNewPerson.TabIndex = 1;
            this.buttonMkNewPerson.Text = "Создать";
            this.buttonMkNewPerson.UseVisualStyleBackColor = true;
            this.buttonMkNewPerson.Click += new System.EventHandler(this.buttonMkNewPerson_Click);
            // 
            // buttonChangePersons
            // 
            this.buttonChangePersons.Location = new System.Drawing.Point(10, 92);
            this.buttonChangePersons.Name = "buttonChangePersons";
            this.buttonChangePersons.Size = new System.Drawing.Size(116, 30);
            this.buttonChangePersons.TabIndex = 2;
            this.buttonChangePersons.Text = "Изменить";
            this.buttonChangePersons.UseVisualStyleBackColor = true;
            // 
            // buttonDeletePersons
            // 
            this.buttonDeletePersons.Location = new System.Drawing.Point(10, 148);
            this.buttonDeletePersons.Name = "buttonDeletePersons";
            this.buttonDeletePersons.Size = new System.Drawing.Size(116, 30);
            this.buttonDeletePersons.TabIndex = 3;
            this.buttonDeletePersons.Text = "Удалить";
            this.buttonDeletePersons.UseVisualStyleBackColor = true;
            this.buttonDeletePersons.Click += new System.EventHandler(this.buttonDeletePersons_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(150, 16);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(96, 31);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // cmboBoxSettingsOfSearch
            // 
            this.cmboBoxSettingsOfSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBoxSettingsOfSearch.FormattingEnabled = true;
            this.cmboBoxSettingsOfSearch.Location = new System.Drawing.Point(263, 23);
            this.cmboBoxSettingsOfSearch.Name = "cmboBoxSettingsOfSearch";
            this.cmboBoxSettingsOfSearch.Size = new System.Drawing.Size(157, 24);
            this.cmboBoxSettingsOfSearch.TabIndex = 6;
            this.cmboBoxSettingsOfSearch.SelectedIndexChanged += new System.EventHandler(this.cmboBoxSettingsOfSearch_SelectedIndexChanged);
            // 
            // cmboBoxSelectSettings
            // 
            this.cmboBoxSelectSettings.FormattingEnabled = true;
            this.cmboBoxSelectSettings.Location = new System.Drawing.Point(263, 434);
            this.cmboBoxSelectSettings.Name = "cmboBoxSelectSettings";
            this.cmboBoxSelectSettings.Size = new System.Drawing.Size(157, 24);
            this.cmboBoxSelectSettings.TabIndex = 8;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(150, 424);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(96, 34);
            this.buttonSelect.TabIndex = 9;
            this.buttonSelect.Text = "Выборка";
            this.buttonSelect.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "От";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "До";
            // 
            // textBoxParaSelectFrom
            // 
            this.textBoxParaSelectFrom.Location = new System.Drawing.Point(38, 38);
            this.textBoxParaSelectFrom.Name = "textBoxParaSelectFrom";
            this.textBoxParaSelectFrom.Size = new System.Drawing.Size(100, 22);
            this.textBoxParaSelectFrom.TabIndex = 12;
            this.textBoxParaSelectFrom.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxParaSelectTo
            // 
            this.textBoxParaSelectTo.Location = new System.Drawing.Point(201, 38);
            this.textBoxParaSelectTo.Name = "textBoxParaSelectTo";
            this.textBoxParaSelectTo.Size = new System.Drawing.Size(100, 22);
            this.textBoxParaSelectTo.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxParaSelectTo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxParaSelectFrom);
            this.groupBox1.Location = new System.Drawing.Point(467, 413);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 79);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите диапазон";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonUpdateTable);
            this.groupBox2.Controls.Add(this.buttonDeletePersons);
            this.groupBox2.Controls.Add(this.buttonMkNewPerson);
            this.groupBox2.Controls.Add(this.buttonChangePersons);
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 304);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Операции";
            // 
            // buttonUpdateTable
            // 
            this.buttonUpdateTable.Location = new System.Drawing.Point(10, 237);
            this.buttonUpdateTable.Name = "buttonUpdateTable";
            this.buttonUpdateTable.Size = new System.Drawing.Size(116, 30);
            this.buttonUpdateTable.TabIndex = 17;
            this.buttonUpdateTable.Text = "Обновить";
            this.buttonUpdateTable.UseVisualStyleBackColor = true;
            this.buttonUpdateTable.Click += new System.EventHandler(this.buttonUpdateTable_Click);
            // 
            // cmbBoxStringOfSearch
            // 
            this.cmbBoxStringOfSearch.Location = new System.Drawing.Point(437, 21);
            this.cmbBoxStringOfSearch.Name = "cmbBoxStringOfSearch";
            this.cmbBoxStringOfSearch.Size = new System.Drawing.Size(356, 24);
            this.cmbBoxStringOfSearch.TabIndex = 17;
            this.cmbBoxStringOfSearch.SelectedIndexChanged += new System.EventHandler(this.cmbBoxStringOfSearch_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Surname
            // 
            this.Surname.Text = "Фамилия";
            this.Surname.Width = 89;
            // 
            // FirstName
            // 
            this.FirstName.Text = "Имя";
            this.FirstName.Width = 88;
            // 
            // Secondname
            // 
            this.Secondname.Text = "Отчество";
            this.Secondname.Width = 84;
            // 
            // YoB
            // 
            this.YoB.Text = "Год рождения";
            this.YoB.Width = 109;
            // 
            // Specialize
            // 
            this.Specialize.Text = "Специальность";
            this.Specialize.Width = 122;
            // 
            // Position
            // 
            this.Position.Text = "Должность";
            this.Position.Width = 98;
            // 
            // Salary
            // 
            this.Salary.Text = "З/П";
            this.Salary.Width = 74;
            // 
            // Status
            // 
            this.Status.Text = "Статус";
            this.Status.Width = 77;
            // 
            // listViewPerson
            // 
            this.listViewPerson.CheckBoxes = true;
            this.listViewPerson.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Surname,
            this.FirstName,
            this.Secondname,
            this.YoB,
            this.Specialize,
            this.Position,
            this.Salary,
            this.Status});
            this.listViewPerson.Location = new System.Drawing.Point(150, 71);
            this.listViewPerson.Name = "listViewPerson";
            this.listViewPerson.Size = new System.Drawing.Size(843, 336);
            this.listViewPerson.TabIndex = 0;
            this.listViewPerson.UseCompatibleStateImageBehavior = false;
            this.listViewPerson.View = System.Windows.Forms.View.Details;
            this.listViewPerson.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // checkBoxLoadFromHard
            // 
            this.checkBoxLoadFromHard.AutoSize = true;
            this.checkBoxLoadFromHard.Location = new System.Drawing.Point(828, 27);
            this.checkBoxLoadFromHard.Name = "checkBoxLoadFromHard";
            this.checkBoxLoadFromHard.Size = new System.Drawing.Size(165, 21);
            this.checkBoxLoadFromHard.TabIndex = 18;
            this.checkBoxLoadFromHard.Text = "Локальная выгрузка";
            this.checkBoxLoadFromHard.UseVisualStyleBackColor = true;
            this.checkBoxLoadFromHard.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // labelLastLoadTime
            // 
            this.labelLastLoadTime.AutoSize = true;
            this.labelLastLoadTime.Location = new System.Drawing.Point(860, 51);
            this.labelLastLoadTime.Name = "labelLastLoadTime";
            this.labelLastLoadTime.Size = new System.Drawing.Size(125, 17);
            this.labelLastLoadTime.TabIndex = 19;
            this.labelLastLoadTime.Text = "Дата обновления";
            this.labelLastLoadTime.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(769, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "LastUpdate:";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // PersonalFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 517);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelLastLoadTime);
            this.Controls.Add(this.checkBoxLoadFromHard);
            this.Controls.Add(this.cmbBoxStringOfSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.cmboBoxSelectSettings);
            this.Controls.Add(this.cmboBoxSettingsOfSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.listViewPerson);
            this.Name = "PersonalFiles";
            this.Text = "Личные дела";
            this.Load += new System.EventHandler(this.PersonalFiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.militaryCompanyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalfileBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MilitaryCompanyDataSet militaryCompanyDataSet;
        private System.Windows.Forms.BindingSource personalfileBindingSource;
        private MilitaryCompanyDataSetTableAdapters.personal_fileTableAdapter personal_fileTableAdapter;
        private System.Windows.Forms.Button buttonMkNewPerson;
        private System.Windows.Forms.Button buttonChangePersons;
        private System.Windows.Forms.Button buttonDeletePersons;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox cmboBoxSettingsOfSearch;
        private System.Windows.Forms.ComboBox cmboBoxSelectSettings;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxParaSelectFrom;
        private System.Windows.Forms.TextBox textBoxParaSelectTo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonUpdateTable;
        private System.Windows.Forms.ComboBox cmbBoxStringOfSearch;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Surname;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader Secondname;
        private System.Windows.Forms.ColumnHeader YoB;
        private System.Windows.Forms.ColumnHeader Specialize;
        private System.Windows.Forms.ColumnHeader Position;
        private System.Windows.Forms.ColumnHeader Salary;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ListView listViewPerson;
        private System.Windows.Forms.CheckBox checkBoxLoadFromHard;
        private System.Windows.Forms.Label labelLastLoadTime;
        private System.Windows.Forms.Label label3;
    }
}