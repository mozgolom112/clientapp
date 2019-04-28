namespace WindowsFormsApp1
{
    partial class MakePersonForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSecondName = new System.Windows.Forms.Label();
            this.labelYoB = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelPersonalID = new System.Windows.Forms.Label();
            this.labelSpecialize = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(245, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Анкета нового сотрудника";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(22, 61);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 17);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Имя:";
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
            // labelYoB
            // 
            this.labelYoB.AutoSize = true;
            this.labelYoB.Location = new System.Drawing.Point(22, 125);
            this.labelYoB.Name = "labelYoB";
            this.labelYoB.Size = new System.Drawing.Size(105, 17);
            this.labelYoB.TabIndex = 5;
            this.labelYoB.Text = "Год рождения:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.labelYoB);
            this.groupBox1.Controls.Add(this.labelSurname);
            this.groupBox1.Controls.Add(this.labelSecondName);
            this.groupBox1.Location = new System.Drawing.Point(31, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 169);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Персональные данные";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.labelStatus);
            this.groupBox2.Controls.Add(this.labelPosition);
            this.groupBox2.Controls.Add(this.labelSpecialize);
            this.groupBox2.Controls.Add(this.labelPersonalID);
            this.groupBox2.Location = new System.Drawing.Point(422, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 168);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные сотрудника";
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
            // labelSpecialize
            // 
            this.labelSpecialize.AutoSize = true;
            this.labelSpecialize.Location = new System.Drawing.Point(19, 61);
            this.labelSpecialize.Name = "labelSpecialize";
            this.labelSpecialize.Size = new System.Drawing.Size(113, 17);
            this.labelSpecialize.TabIndex = 1;
            this.labelSpecialize.Text = "Специальность:";
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
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(19, 128);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(117, 17);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "Текущий статус:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(31, 298);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(357, 100);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Условия договора";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Заработная плата:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(428, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 31);
            this.button2.TabIndex = 9;
            this.button2.Text = "Проверить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(425, 298);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(332, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "С условиями договора сотрудник ознакомлен(а):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(425, 331);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Подпись:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(508, 330);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(111, 21);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Не согласен";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 22);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(160, 91);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(191, 22);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(160, 125);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(191, 22);
            this.textBox4.TabIndex = 13;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(151, 91);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(191, 22);
            this.textBox6.TabIndex = 16;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(151, 25);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(191, 22);
            this.textBox8.TabIndex = 14;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(157, 32);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(191, 22);
            this.textBox9.TabIndex = 18;
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(151, 124);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 24);
            this.comboBox1.TabIndex = 17;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(151, 58);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(191, 24);
            this.comboBox2.TabIndex = 18;
            // 
            // MakePersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "MakePersonForm";
            this.Text = "Добавление сотрудника";
            this.Load += new System.EventHandler(this.MakePersonForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSecondName;
        private System.Windows.Forms.Label labelYoB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelSpecialize;
        private System.Windows.Forms.Label labelPersonalID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}