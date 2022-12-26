namespace Test_Login
{
    partial class join
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(join));
            this.user_id = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.user_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Password_Check = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passcheck = new System.Windows.Forms.TextBox();
            this.id_check = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.ComboBox();
            this.company = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grade = new System.Windows.Forms.ComboBox();
            this.team = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BankCheck = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.banksabun = new System.Windows.Forms.TextBox();
            this.bankcertpw = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.out_svn_id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.out_svn_pw = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.in_svn_id = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.in_svn_pw = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.BankCheck.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // user_id
            // 
            this.user_id.BackColor = System.Drawing.SystemColors.Window;
            this.user_id.Location = new System.Drawing.Point(8, 32);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(198, 21);
            this.user_id.TabIndex = 1;
            this.user_id.MouseCaptureChanged += new System.EventHandler(this.ID);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.BankCheck);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 410);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "회원가입";
            this.groupBox1.MouseCaptureChanged += new System.EventHandler(this.ID);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.user_id);
            this.groupBox4.Controls.Add(this.user_password);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.Password_Check);
            this.groupBox4.Controls.Add(this.user_name);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.passcheck);
            this.groupBox4.Controls.Add(this.id_check);
            this.groupBox4.Location = new System.Drawing.Point(6, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(216, 225);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.MouseCaptureChanged += new System.EventHandler(this.ID);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            this.label1.MouseCaptureChanged += new System.EventHandler(this.ID);
            // 
            // user_password
            // 
            this.user_password.BackColor = System.Drawing.SystemColors.Window;
            this.user_password.Location = new System.Drawing.Point(8, 87);
            this.user_password.Name = "user_password";
            this.user_password.PasswordChar = '*';
            this.user_password.Size = new System.Drawing.Size(198, 21);
            this.user_password.TabIndex = 2;
            this.user_password.TextChanged += new System.EventHandler(this.Password);
            this.user_password.MouseCaptureChanged += new System.EventHandler(this.ID);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            this.label2.MouseCaptureChanged += new System.EventHandler(this.ID);
            // 
            // Password_Check
            // 
            this.Password_Check.AutoSize = true;
            this.Password_Check.BackColor = System.Drawing.SystemColors.Control;
            this.Password_Check.ForeColor = System.Drawing.Color.Red;
            this.Password_Check.Location = new System.Drawing.Point(6, 152);
            this.Password_Check.Name = "Password_Check";
            this.Password_Check.Size = new System.Drawing.Size(145, 12);
            this.Password_Check.TabIndex = 12;
            this.Password_Check.Text = "비밀번호를 입력해주세요.";
            this.Password_Check.MouseCaptureChanged += new System.EventHandler(this.ID);
            // 
            // user_name
            // 
            this.user_name.BackColor = System.Drawing.SystemColors.Window;
            this.user_name.Location = new System.Drawing.Point(8, 187);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(198, 21);
            this.user_name.TabIndex = 4;
            this.user_name.TextChanged += new System.EventHandler(this.username);
            this.user_name.MouseCaptureChanged += new System.EventHandler(this.ID);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password Check";
            this.label4.MouseCaptureChanged += new System.EventHandler(this.ID);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            this.label3.MouseCaptureChanged += new System.EventHandler(this.ID);
            // 
            // passcheck
            // 
            this.passcheck.BackColor = System.Drawing.SystemColors.Window;
            this.passcheck.Location = new System.Drawing.Point(8, 128);
            this.passcheck.Name = "passcheck";
            this.passcheck.PasswordChar = '*';
            this.passcheck.Size = new System.Drawing.Size(198, 21);
            this.passcheck.TabIndex = 3;
            this.passcheck.TextChanged += new System.EventHandler(this.passwordcheck);
            this.passcheck.MouseCaptureChanged += new System.EventHandler(this.ID);
            // 
            // id_check
            // 
            this.id_check.AutoSize = true;
            this.id_check.BackColor = System.Drawing.SystemColors.Control;
            this.id_check.ForeColor = System.Drawing.Color.Red;
            this.id_check.Location = new System.Drawing.Point(6, 56);
            this.id_check.Name = "id_check";
            this.id_check.Size = new System.Drawing.Size(133, 12);
            this.id_check.TabIndex = 8;
            this.id_check.Text = "아이디를 입력해주세요.";
            this.id_check.MouseCaptureChanged += new System.EventHandler(this.ID);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.level);
            this.groupBox3.Controls.Add(this.company);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.grade);
            this.groupBox3.Controls.Add(this.team);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(458, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(140, 225);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.MouseCaptureChanged += new System.EventHandler(this.ID);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "직급";
            this.label6.MouseCaptureChanged += new System.EventHandler(this.ID);
            // 
            // level
            // 
            this.level.Cursor = System.Windows.Forms.Cursors.Default;
            this.level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.level.FormattingEnabled = true;
            this.level.IntegralHeight = false;
            this.level.ItemHeight = 12;
            this.level.Location = new System.Drawing.Point(8, 135);
            this.level.MaxDropDownItems = 5;
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(121, 20);
            this.level.TabIndex = 9;
            this.level.SelectedIndexChanged += new System.EventHandler(this.level_SelectedIndexChanged);
            this.level.MouseCaptureChanged += new System.EventHandler(this.ID);
            // 
            // company
            // 
            this.company.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.company.FormattingEnabled = true;
            this.company.IntegralHeight = false;
            this.company.ItemHeight = 12;
            this.company.Items.AddRange(new object[] {
            "신한은행",
            "핑거",
            "SK"});
            this.company.Location = new System.Drawing.Point(8, 32);
            this.company.MaxDropDownItems = 3;
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(121, 20);
            this.company.TabIndex = 11;
            this.company.SelectedIndexChanged += new System.EventHandler(this.company_SelectedIndexChanged);
            this.company.MouseCaptureChanged += new System.EventHandler(this.ID);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 20;
            this.label9.Text = "등급";
            this.label9.MouseCaptureChanged += new System.EventHandler(this.ID);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "회사명";
            this.label7.MouseCaptureChanged += new System.EventHandler(this.ID);
            // 
            // grade
            // 
            this.grade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grade.FormattingEnabled = true;
            this.grade.IntegralHeight = false;
            this.grade.ItemHeight = 12;
            this.grade.Location = new System.Drawing.Point(8, 187);
            this.grade.MaxDropDownItems = 5;
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(121, 20);
            this.grade.TabIndex = 12;
            this.grade.SelectedIndexChanged += new System.EventHandler(this.grade_SelectedIndexChanged);
            this.grade.MouseCaptureChanged += new System.EventHandler(this.ID);
            // 
            // team
            // 
            this.team.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.team.FormattingEnabled = true;
            this.team.IntegralHeight = false;
            this.team.ItemHeight = 12;
            this.team.Location = new System.Drawing.Point(8, 80);
            this.team.MaxDropDownItems = 3;
            this.team.Name = "team";
            this.team.Size = new System.Drawing.Size(121, 20);
            this.team.TabIndex = 10;
            this.team.SelectedIndexChanged += new System.EventHandler(this.team_SelectedIndexChanged);
            this.team.MouseCaptureChanged += new System.EventHandler(this.ID);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "소속 팀";
            this.label8.MouseCaptureChanged += new System.EventHandler(this.ID);
            // 
            // BankCheck
            // 
            this.BankCheck.Controls.Add(this.label14);
            this.BankCheck.Controls.Add(this.label15);
            this.BankCheck.Controls.Add(this.banksabun);
            this.BankCheck.Controls.Add(this.bankcertpw);
            this.BankCheck.Location = new System.Drawing.Point(6, 251);
            this.BankCheck.Name = "BankCheck";
            this.BankCheck.Size = new System.Drawing.Size(592, 115);
            this.BankCheck.TabIndex = 4;
            this.BankCheck.TabStop = false;
            this.BankCheck.Text = "Bank";
            this.BankCheck.UseCompatibleTextRendering = true;
            this.BankCheck.MouseCaptureChanged += new System.EventHandler(this.ID);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(197, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 30;
            this.label14.Text = "사번";
            this.label14.MouseCaptureChanged += new System.EventHandler(this.ID);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(145, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 12);
            this.label15.TabIndex = 32;
            this.label15.Text = "인증 패스워드";
            this.label15.MouseCaptureChanged += new System.EventHandler(this.ID);
            // 
            // banksabun
            // 
            this.banksabun.BackColor = System.Drawing.SystemColors.Window;
            this.banksabun.Location = new System.Drawing.Point(232, 32);
            this.banksabun.Name = "banksabun";
            this.banksabun.Size = new System.Drawing.Size(124, 21);
            this.banksabun.TabIndex = 13;
            this.banksabun.TextChanged += new System.EventHandler(this.banksabun_TextChanged);
            this.banksabun.MouseCaptureChanged += new System.EventHandler(this.ID);
            // 
            // bankcertpw
            // 
            this.bankcertpw.Location = new System.Drawing.Point(232, 80);
            this.bankcertpw.Name = "bankcertpw";
            this.bankcertpw.PasswordChar = '*';
            this.bankcertpw.Size = new System.Drawing.Size(124, 21);
            this.bankcertpw.TabIndex = 14;
            this.bankcertpw.TextChanged += new System.EventHandler(this.bankcertpw_TextChanged);
            this.bankcertpw.MouseCaptureChanged += new System.EventHandler(this.ID);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.out_svn_id);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.out_svn_pw);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.in_svn_id);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.in_svn_pw);
            this.groupBox2.Location = new System.Drawing.Point(230, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 225);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.MouseCaptureChanged += new System.EventHandler(this.ID);
            // 
            // out_svn_id
            // 
            this.out_svn_id.Location = new System.Drawing.Point(8, 32);
            this.out_svn_id.Name = "out_svn_id";
            this.out_svn_id.Size = new System.Drawing.Size(198, 21);
            this.out_svn_id.TabIndex = 5;
            this.out_svn_id.TextChanged += new System.EventHandler(this.out_svn_id_TextChanged);
            this.out_svn_id.MouseCaptureChanged += new System.EventHandler(this.ID);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 12);
            this.label11.TabIndex = 21;
            this.label11.Text = "외부 SVN ID";
            this.label11.MouseCaptureChanged += new System.EventHandler(this.ID);
            // 
            // out_svn_pw
            // 
            this.out_svn_pw.Location = new System.Drawing.Point(8, 80);
            this.out_svn_pw.Name = "out_svn_pw";
            this.out_svn_pw.PasswordChar = '*';
            this.out_svn_pw.Size = new System.Drawing.Size(198, 21);
            this.out_svn_pw.TabIndex = 6;
            this.out_svn_pw.TextChanged += new System.EventHandler(this.out_svn_pw_TextChanged);
            this.out_svn_pw.MouseCaptureChanged += new System.EventHandler(this.ID);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 12);
            this.label10.TabIndex = 24;
            this.label10.Text = "외부 SVN PW";
            this.label10.MouseCaptureChanged += new System.EventHandler(this.ID);
            // 
            // in_svn_id
            // 
            this.in_svn_id.Location = new System.Drawing.Point(8, 135);
            this.in_svn_id.Name = "in_svn_id";
            this.in_svn_id.Size = new System.Drawing.Size(198, 21);
            this.in_svn_id.TabIndex = 7;
            this.in_svn_id.TextChanged += new System.EventHandler(this.in_svn_id_TextChanged);
            this.in_svn_id.MouseCaptureChanged += new System.EventHandler(this.ID);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 12);
            this.label12.TabIndex = 28;
            this.label12.Text = "내부 SVN PW";
            this.label12.MouseCaptureChanged += new System.EventHandler(this.ID);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 12);
            this.label13.TabIndex = 25;
            this.label13.Text = "내부 SVN ID";
            this.label13.MouseCaptureChanged += new System.EventHandler(this.ID);
            // 
            // in_svn_pw
            // 
            this.in_svn_pw.Location = new System.Drawing.Point(8, 187);
            this.in_svn_pw.Name = "in_svn_pw";
            this.in_svn_pw.PasswordChar = '*';
            this.in_svn_pw.Size = new System.Drawing.Size(198, 21);
            this.in_svn_pw.TabIndex = 8;
            this.in_svn_pw.TextChanged += new System.EventHandler(this.in_svn_pw_TextChanged);
            this.in_svn_pw.MouseCaptureChanged += new System.EventHandler(this.ID);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "아이디/비밀번호 찾기";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(402, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "취소";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "회원가입";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // join
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(629, 436);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(650, 300);
            this.Name = "join";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "join";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.join_FormClosed);
            this.Load += new System.EventHandler(this.join_Load);
            this.MouseCaptureChanged += new System.EventHandler(this.ID);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.BankCheck.ResumeLayout(false);
            this.BankCheck.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox user_id;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user_password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label id_check;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox in_svn_pw;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox in_svn_id;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox out_svn_pw;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox out_svn_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox grade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox team;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox company;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox level;
        private System.Windows.Forms.Label Password_Check;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passcheck;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox BankCheck;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox banksabun;
        private System.Windows.Forms.TextBox bankcertpw;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}