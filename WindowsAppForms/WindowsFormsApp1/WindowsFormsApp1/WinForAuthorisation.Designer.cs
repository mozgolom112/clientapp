namespace WindowsFormsApp1
{
    partial class WinForAuthorisation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.ComboBox();
            this.DBName = new System.Windows.Forms.ComboBox();
            this.NameOfServer = new System.Windows.Forms.ComboBox();
            this.StatusOfConnection = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProgressBarOfConn = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ButtonForConn = new System.Windows.Forms.Button();
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя сервера:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя пользователя:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "База данных:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(116, 56);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ShowPassword);
            this.splitContainer1.Panel2.Controls.Add(this.User);
            this.splitContainer1.Panel2.Controls.Add(this.DBName);
            this.splitContainer1.Panel2.Controls.Add(this.NameOfServer);
            this.splitContainer1.Panel2.Controls.Add(this.StatusOfConnection);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.Password);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Size = new System.Drawing.Size(558, 306);
            this.splitContainer1.SplitterDistance = 204;
            this.splitContainer1.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Авторизация";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Подключение";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // User
            // 
            this.User.FormattingEnabled = true;
            this.User.Location = new System.Drawing.Point(75, 192);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(193, 24);
            this.User.TabIndex = 19;
            // 
            // DBName
            // 
            this.DBName.FormattingEnabled = true;
            this.DBName.Items.AddRange(new object[] {
            "MilitaryCompany"});
            this.DBName.Location = new System.Drawing.Point(45, 87);
            this.DBName.Name = "DBName";
            this.DBName.Size = new System.Drawing.Size(223, 24);
            this.DBName.TabIndex = 18;
            // 
            // NameOfServer
            // 
            this.NameOfServer.FormattingEnabled = true;
            this.NameOfServer.Items.AddRange(new object[] {
            "HOME - PC"});
            this.NameOfServer.Location = new System.Drawing.Point(45, 49);
            this.NameOfServer.Name = "NameOfServer";
            this.NameOfServer.Size = new System.Drawing.Size(223, 24);
            this.NameOfServer.TabIndex = 17;
            this.NameOfServer.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // StatusOfConnection
            // 
            this.StatusOfConnection.AutoSize = true;
            this.StatusOfConnection.Location = new System.Drawing.Point(72, 134);
            this.StatusOfConnection.Name = "StatusOfConnection";
            this.StatusOfConnection.Size = new System.Drawing.Size(46, 17);
            this.StatusOfConnection.TabIndex = 16;
            this.StatusOfConnection.Text = "label9";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Статус:";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(75, 228);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(193, 22);
            this.Password.TabIndex = 11;
            this.Password.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Показать пароль";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ProgressBarOfConn
            // 
            this.ProgressBarOfConn.Location = new System.Drawing.Point(626, 385);
            this.ProgressBarOfConn.Name = "ProgressBarOfConn";
            this.ProgressBarOfConn.Size = new System.Drawing.Size(136, 29);
            this.ProgressBarOfConn.TabIndex = 6;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // ButtonForConn
            // 
            this.ButtonForConn.Location = new System.Drawing.Point(464, 385);
            this.ButtonForConn.Name = "ButtonForConn";
            this.ButtonForConn.Size = new System.Drawing.Size(139, 29);
            this.ButtonForConn.TabIndex = 17;
            this.ButtonForConn.Text = "Соединить";
            this.ButtonForConn.UseVisualStyleBackColor = true;
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.Location = new System.Drawing.Point(212, 264);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(18, 17);
            this.ShowPassword.TabIndex = 20;
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // WinForAuthorisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonForConn);
            this.Controls.Add(this.ProgressBarOfConn);
            this.Controls.Add(this.splitContainer1);
            this.Name = "WinForAuthorisation";
            this.Text = "Соединение с сервером";
            this.Load += new System.EventHandler(this.WinForAuthorisation_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar ProgressBarOfConn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label StatusOfConnection;
        private System.Windows.Forms.Button ButtonForConn;
        private System.Windows.Forms.ComboBox User;
        private System.Windows.Forms.ComboBox DBName;
        private System.Windows.Forms.ComboBox NameOfServer;
        private System.Windows.Forms.CheckBox ShowPassword;
    }
}