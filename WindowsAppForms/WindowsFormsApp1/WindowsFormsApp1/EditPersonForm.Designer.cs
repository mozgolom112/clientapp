namespace WindowsFormsApp1
{
    partial class EditPersonForm
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
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelAftograf = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.labelSalary = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboSpec = new System.Windows.Forms.ComboBox();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelSpecialize = new System.Windows.Forms.Label();
            this.labelPersonalID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxYoB = new System.Windows.Forms.TextBox();
            this.textBoxSecondname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelYoB = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelSecondName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelwithtitleID = new System.Windows.Forms.Label();
            this.checkedListEdit = new System.Windows.Forms.CheckedListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(59, 445);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(110, 32);
            this.buttonClearAll.TabIndex = 23;
            this.buttonClearAll.Text = "Очистить";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(536, 369);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(111, 21);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Не согласен";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // labelAftograf
            // 
            this.labelAftograf.AutoSize = true;
            this.labelAftograf.Location = new System.Drawing.Point(453, 370);
            this.labelAftograf.Name = "labelAftograf";
            this.labelAftograf.Size = new System.Drawing.Size(68, 17);
            this.labelAftograf.TabIndex = 21;
            this.labelAftograf.Text = "Подпись:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(453, 337);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(332, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "С условиями договора сотрудник ознакомлен(а):";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(450, 402);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(139, 64);
            this.buttonCheck.TabIndex = 19;
            this.buttonCheck.Text = "Проверить";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxSalary);
            this.groupBox3.Controls.Add(this.labelSalary);
            this.groupBox3.Location = new System.Drawing.Point(59, 337);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(357, 100);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Условия договора";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(157, 32);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(191, 22);
            this.textBoxSalary.TabIndex = 18;
            this.textBoxSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSalary.TextChanged += new System.EventHandler(this.textBoxSalary_TextChanged);
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(16, 36);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(135, 17);
            this.labelSalary.TabIndex = 0;
            this.labelSalary.Text = "Заработная плата:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboSpec);
            this.groupBox2.Controls.Add(this.comboStatus);
            this.groupBox2.Controls.Add(this.textBoxPosition);
            this.groupBox2.Controls.Add(this.textBoxID);
            this.groupBox2.Controls.Add(this.labelStatus);
            this.groupBox2.Controls.Add(this.labelPosition);
            this.groupBox2.Controls.Add(this.labelSpecialize);
            this.groupBox2.Controls.Add(this.labelPersonalID);
            this.groupBox2.Location = new System.Drawing.Point(450, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 168);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные сотрудника";
            // 
            // comboSpec
            // 
            this.comboSpec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSpec.FormattingEnabled = true;
            this.comboSpec.Location = new System.Drawing.Point(151, 58);
            this.comboSpec.Name = "comboSpec";
            this.comboSpec.Size = new System.Drawing.Size(191, 24);
            this.comboSpec.TabIndex = 18;
            this.comboSpec.SelectedIndexChanged += new System.EventHandler(this.comboSpec_SelectedIndexChanged);
            // 
            // comboStatus
            // 
            this.comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Location = new System.Drawing.Point(151, 124);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(191, 24);
            this.comboStatus.TabIndex = 17;
            this.comboStatus.SelectedIndexChanged += new System.EventHandler(this.comboStatus_SelectedIndexChanged);
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(151, 91);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(191, 22);
            this.textBoxPosition.TabIndex = 16;
            this.textBoxPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(151, 25);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(191, 22);
            this.textBoxID.TabIndex = 14;
            this.textBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(19, 128);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(117, 17);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "Текущий статус:";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(19, 94);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(85, 17);
            this.labelPosition.TabIndex = 2;
            this.labelPosition.Text = "Должность:";
            // 
            // labelSpecialize
            // 
            this.labelSpecialize.AutoSize = true;
            this.labelSpecialize.Location = new System.Drawing.Point(19, 61);
            this.labelSpecialize.Name = "labelSpecialize";
            this.labelSpecialize.Size = new System.Drawing.Size(113, 17);
            this.labelSpecialize.TabIndex = 1;
            this.labelSpecialize.Text = "Специальность:";
            // 
            // labelPersonalID
            // 
            this.labelPersonalID.AutoSize = true;
            this.labelPersonalID.Location = new System.Drawing.Point(19, 27);
            this.labelPersonalID.Name = "labelPersonalID";
            this.labelPersonalID.Size = new System.Drawing.Size(126, 17);
            this.labelPersonalID.TabIndex = 0;
            this.labelPersonalID.Text = "Личный ID номер:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxYoB);
            this.groupBox1.Controls.Add(this.textBoxSecondname);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.textBoxSurname);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.labelYoB);
            this.groupBox1.Controls.Add(this.labelSurname);
            this.groupBox1.Controls.Add(this.labelSecondName);
            this.groupBox1.Location = new System.Drawing.Point(59, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 169);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Персональные данные";
            // 
            // textBoxYoB
            // 
            this.textBoxYoB.Location = new System.Drawing.Point(160, 125);
            this.textBoxYoB.Name = "textBoxYoB";
            this.textBoxYoB.Size = new System.Drawing.Size(191, 22);
            this.textBoxYoB.TabIndex = 13;
            this.textBoxYoB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxYoB.TextChanged += new System.EventHandler(this.textBoxYoB_TextChanged);
            // 
            // textBoxSecondname
            // 
            this.textBoxSecondname.Location = new System.Drawing.Point(160, 91);
            this.textBoxSecondname.Name = "textBoxSecondname";
            this.textBoxSecondname.Size = new System.Drawing.Size(191, 22);
            this.textBoxSecondname.TabIndex = 8;
            this.textBoxSecondname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSecondname.TextChanged += new System.EventHandler(this.textBoxSecondname_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(160, 61);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(191, 22);
            this.textBoxName.TabIndex = 7;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(160, 28);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(191, 22);
            this.textBoxSurname.TabIndex = 6;
            this.textBoxSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSurname.TextChanged += new System.EventHandler(this.textBoxSurname_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(22, 61);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 17);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Имя:";
            // 
            // labelYoB
            // 
            this.labelYoB.AutoSize = true;
            this.labelYoB.Location = new System.Drawing.Point(22, 125);
            this.labelYoB.Name = "labelYoB";
            this.labelYoB.Size = new System.Drawing.Size(105, 17);
            this.labelYoB.TabIndex = 5;
            this.labelYoB.Text = "Год рождения:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(22, 28);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(74, 17);
            this.labelSurname.TabIndex = 2;
            this.labelSurname.Text = "Фамилия:";
            // 
            // labelSecondName
            // 
            this.labelSecondName.AutoSize = true;
            this.labelSecondName.Location = new System.Drawing.Point(22, 91);
            this.labelSecondName.Name = "labelSecondName";
            this.labelSecondName.Size = new System.Drawing.Size(75, 17);
            this.labelSecondName.TabIndex = 4;
            this.labelSecondName.Text = "Отчество:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(215, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Анкета сотрудника под номером ID и фамилия:";
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Location = new System.Drawing.Point(646, 402);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(139, 64);
            this.buttonSaveChanges.TabIndex = 14;
            this.buttonSaveChanges.Text = "Сохранить изменения";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelwithtitleID);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.buttonClearAll);
            this.groupBox4.Controls.Add(this.buttonSaveChanges);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.labelAftograf);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.buttonCheck);
            this.groupBox4.Location = new System.Drawing.Point(255, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(840, 556);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Режим редактирования";
            // 
            // labelwithtitleID
            // 
            this.labelwithtitleID.AutoSize = true;
            this.labelwithtitleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelwithtitleID.Location = new System.Drawing.Point(635, 76);
            this.labelwithtitleID.Name = "labelwithtitleID";
            this.labelwithtitleID.Size = new System.Drawing.Size(26, 20);
            this.labelwithtitleID.TabIndex = 24;
            this.labelwithtitleID.Text = "ID";
            // 
            // checkedListEdit
            // 
            this.checkedListEdit.FormattingEnabled = true;
            this.checkedListEdit.Location = new System.Drawing.Point(6, 38);
            this.checkedListEdit.Name = "checkedListEdit";
            this.checkedListEdit.Size = new System.Drawing.Size(210, 293);
            this.checkedListEdit.TabIndex = 25;
            this.checkedListEdit.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.checkedListEdit);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(222, 556);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Список редактирования";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(54, 515);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 26);
            this.button3.TabIndex = 28;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 62);
            this.button2.TabIndex = 27;
            this.button2.Text = "Применить изменения (Всех возможных)";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 62);
            this.button1.TabIndex = 26;
            this.button1.Text = "Применить изменения (Только группу целиком)";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EditPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 612);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Name = "EditPersonForm";
            this.Text = "Редактирование";
            this.Load += new System.EventHandler(this.EditPersonForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label labelAftograf;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboSpec;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelSpecialize;
        private System.Windows.Forms.Label labelPersonalID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxYoB;
        private System.Windows.Forms.TextBox textBoxSecondname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelYoB;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelSecondName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelwithtitleID;
        private System.Windows.Forms.CheckedListBox checkedListEdit;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}