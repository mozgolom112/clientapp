namespace WindowsFormsApp1
{
    partial class ForKadrovOtdel
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
            this.chListBoxTasks = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxNewTask = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.militaryCompanyDataSet1 = new WindowsFormsApp1.MilitaryCompanyDataSet();
            this.buttonPersonFile = new System.Windows.Forms.Button();
            this.buttonKomandirovki = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.militaryCompanyDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // chListBoxTasks
            // 
            this.chListBoxTasks.FormattingEnabled = true;
            this.chListBoxTasks.Location = new System.Drawing.Point(39, 54);
            this.chListBoxTasks.Name = "chListBoxTasks";
            this.chListBoxTasks.Size = new System.Drawing.Size(529, 225);
            this.chListBoxTasks.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonAddTask);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtBoxNewTask);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.chListBoxTasks);
            this.groupBox2.Location = new System.Drawing.Point(371, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(590, 453);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(265, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Задачи";
            // 
            // txtBoxNewTask
            // 
            this.txtBoxNewTask.Location = new System.Drawing.Point(39, 339);
            this.txtBoxNewTask.Name = "txtBoxNewTask";
            this.txtBoxNewTask.Size = new System.Drawing.Size(529, 22);
            this.txtBoxNewTask.TabIndex = 5;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 527);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите новую задачу:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Location = new System.Drawing.Point(465, 380);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(103, 29);
            this.buttonAddTask.TabIndex = 7;
            this.buttonAddTask.Text = "Добавить";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonExit);
            this.groupBox1.Controls.Add(this.buttonKomandirovki);
            this.groupBox1.Controls.Add(this.buttonPersonFile);
            this.groupBox1.Location = new System.Drawing.Point(45, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 453);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // militaryCompanyDataSet1
            // 
            this.militaryCompanyDataSet1.DataSetName = "MilitaryCompanyDataSet";
            this.militaryCompanyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonPersonFile
            // 
            this.buttonPersonFile.Location = new System.Drawing.Point(55, 97);
            this.buttonPersonFile.Name = "buttonPersonFile";
            this.buttonPersonFile.Size = new System.Drawing.Size(178, 31);
            this.buttonPersonFile.TabIndex = 0;
            this.buttonPersonFile.Text = "Личные дела";
            this.buttonPersonFile.UseVisualStyleBackColor = true;
            // 
            // buttonKomandirovki
            // 
            this.buttonKomandirovki.Location = new System.Drawing.Point(55, 165);
            this.buttonKomandirovki.Name = "buttonKomandirovki";
            this.buttonKomandirovki.Size = new System.Drawing.Size(178, 31);
            this.buttonKomandirovki.TabIndex = 1;
            this.buttonKomandirovki.Text = "Командировки";
            this.buttonKomandirovki.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(55, 335);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(178, 31);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // ForKadrovOtdel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 527);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ForKadrovOtdel";
            this.Text = "ForKadrovOtdel";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.militaryCompanyDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckedListBox chListBoxTasks;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxNewTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonKomandirovki;
        private System.Windows.Forms.Button buttonPersonFile;
        private System.Windows.Forms.ToolTip toolTip1;
        private MilitaryCompanyDataSet militaryCompanyDataSet1;
    }
}