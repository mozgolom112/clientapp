using System.Data.SqlClient;

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
            this.buttonStatusAuth = new System.Windows.Forms.Button();
            this.Statusofauth = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.bottonStatusConn = new System.Windows.Forms.Button();
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            this.DBName = new System.Windows.Forms.ComboBox();
            this.NameOfServer = new System.Windows.Forms.ComboBox();
            this.labelStatusOfConnection = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonForConn = new System.Windows.Forms.Button();
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя пользователя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 266);
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
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(73, 12);
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
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ButtonForConn);
            this.splitContainer1.Panel2.Controls.Add(this.buttonStatusAuth);
            this.splitContainer1.Panel2.Controls.Add(this.Statusofauth);
            this.splitContainer1.Panel2.Controls.Add(this.UserName);
            this.splitContainer1.Panel2.Controls.Add(this.bottonStatusConn);
            this.splitContainer1.Panel2.Controls.Add(this.ShowPassword);
            this.splitContainer1.Panel2.Controls.Add(this.DBName);
            this.splitContainer1.Panel2.Controls.Add(this.NameOfServer);
            this.splitContainer1.Panel2.Controls.Add(this.labelStatusOfConnection);
            this.splitContainer1.Panel2.Controls.Add(this.Password);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Size = new System.Drawing.Size(695, 391);
            this.splitContainer1.SplitterDistance = 254;
            this.splitContainer1.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 203);
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
            // 
            // buttonStatusAuth
            // 
            this.buttonStatusAuth.Location = new System.Drawing.Point(10, 346);
            this.buttonStatusAuth.Name = "buttonStatusAuth";
            this.buttonStatusAuth.Size = new System.Drawing.Size(193, 31);
            this.buttonStatusAuth.TabIndex = 25;
            this.buttonStatusAuth.Text = "Статус авторизации:";
            this.buttonStatusAuth.UseVisualStyleBackColor = true;
            this.buttonStatusAuth.Click += new System.EventHandler(this.button2_Click);
            // 
            // Statusofauth
            // 
            this.Statusofauth.AutoSize = true;
            this.Statusofauth.Location = new System.Drawing.Point(237, 353);
            this.Statusofauth.Name = "Statusofauth";
            this.Statusofauth.Size = new System.Drawing.Size(76, 17);
            this.Statusofauth.TabIndex = 24;
            this.Statusofauth.Text = "Ожидание";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(10, 223);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(223, 22);
            this.UserName.TabIndex = 22;
            // 
            // bottonStatusConn
            // 
            this.bottonStatusConn.Location = new System.Drawing.Point(10, 122);
            this.bottonStatusConn.Name = "bottonStatusConn";
            this.bottonStatusConn.Size = new System.Drawing.Size(188, 31);
            this.bottonStatusConn.TabIndex = 21;
            this.bottonStatusConn.Text = "Статус подключения:";
            this.bottonStatusConn.UseVisualStyleBackColor = true;
            this.bottonStatusConn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.Location = new System.Drawing.Point(364, 267);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(18, 17);
            this.ShowPassword.TabIndex = 20;
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // DBName
            // 
            this.DBName.FormattingEnabled = true;
            this.DBName.Items.AddRange(new object[] {
            "MilitaryCompany"});
            this.DBName.Location = new System.Drawing.Point(10, 83);
            this.DBName.Name = "DBName";
            this.DBName.Size = new System.Drawing.Size(223, 24);
            this.DBName.TabIndex = 18;
            this.DBName.SelectedIndexChanged += new System.EventHandler(this.DBName_SelectedIndexChanged);
            // 
            // NameOfServer
            // 
            this.NameOfServer.FormattingEnabled = true;
            this.NameOfServer.Items.AddRange(new object[] {
            "HOME-PC"});
            this.NameOfServer.Location = new System.Drawing.Point(10, 45);
            this.NameOfServer.Name = "NameOfServer";
            this.NameOfServer.Size = new System.Drawing.Size(223, 24);
            this.NameOfServer.TabIndex = 17;
            this.NameOfServer.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelStatusOfConnection
            // 
            this.labelStatusOfConnection.AutoSize = true;
            this.labelStatusOfConnection.Location = new System.Drawing.Point(204, 129);
            this.labelStatusOfConnection.Name = "labelStatusOfConnection";
            this.labelStatusOfConnection.Size = new System.Drawing.Size(222, 17);
            this.labelStatusOfConnection.TabIndex = 16;
            this.labelStatusOfConnection.Text = "Выберите сервер и базу данных";
            this.labelStatusOfConnection.Click += new System.EventHandler(this.labelStatusOfConnection_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(10, 261);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(223, 22);
            this.Password.TabIndex = 11;
            this.Password.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Показать пароль";
            // 
            // ButtonForConn
            // 
            this.ButtonForConn.Location = new System.Drawing.Point(10, 311);
            this.ButtonForConn.Name = "ButtonForConn";
            this.ButtonForConn.Size = new System.Drawing.Size(139, 29);
            this.ButtonForConn.TabIndex = 17;
            this.ButtonForConn.Text = "Соединить";
            this.ButtonForConn.UseVisualStyleBackColor = true;
            this.ButtonForConn.Click += new System.EventHandler(this.ButtonForConn_Click);
            // 
            // WinForAuthorisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "WinForAuthorisation";
            this.Text = "Соединение с сервером";
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelStatusOfConnection;
        private System.Windows.Forms.Button ButtonForConn;
        private System.Windows.Forms.ComboBox DBName;
        private System.Windows.Forms.ComboBox NameOfServer;
        private System.Windows.Forms.CheckBox ShowPassword;
        private System.Windows.Forms.Button bottonStatusConn;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label Statusofauth;
        private System.Windows.Forms.Button buttonStatusAuth;
    }
}