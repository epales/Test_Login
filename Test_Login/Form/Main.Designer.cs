namespace Test_Login
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.Logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.seq = new System.Windows.Forms.Label();
            this.번호 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.company = new System.Windows.Forms.Label();
            this.team = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grade = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Alarm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(12, 226);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(210, 23);
            this.Logout.TabIndex = 0;
            this.Logout.Text = "로그아웃";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "이름 :";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(55, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 12);
            this.name.TabIndex = 2;
            this.name.Text = "None";
            this.name.Click += new System.EventHandler(this.main_Load);
            // 
            // seq
            // 
            this.seq.AutoSize = true;
            this.seq.Location = new System.Drawing.Point(55, 31);
            this.seq.Name = "seq";
            this.seq.Size = new System.Drawing.Size(35, 12);
            this.seq.TabIndex = 4;
            this.seq.Text = "None";
            // 
            // 번호
            // 
            this.번호.AutoSize = true;
            this.번호.Location = new System.Drawing.Point(12, 31);
            this.번호.Name = "번호";
            this.번호.Size = new System.Drawing.Size(37, 12);
            this.번호.TabIndex = 3;
            this.번호.Text = "번호 :";
            this.번호.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "테트리스 하기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "회사명 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "파트명 :";
            // 
            // company
            // 
            this.company.AutoSize = true;
            this.company.Location = new System.Drawing.Point(67, 53);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(35, 12);
            this.company.TabIndex = 8;
            this.company.Text = "None";
            // 
            // team
            // 
            this.team.AutoSize = true;
            this.team.Location = new System.Drawing.Point(67, 75);
            this.team.Name = "team";
            this.team.Size = new System.Drawing.Size(35, 12);
            this.team.TabIndex = 9;
            this.team.Text = "None";
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.Location = new System.Drawing.Point(55, 96);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(35, 12);
            this.level.TabIndex = 11;
            this.level.Text = "None";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "직급 :";
            // 
            // grade
            // 
            this.grade.AutoSize = true;
            this.grade.Location = new System.Drawing.Point(55, 117);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(35, 12);
            this.grade.TabIndex = 13;
            this.grade.Text = "None";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "등급 :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "개발 목록";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "알림:";
            // 
            // Alarm
            // 
            this.Alarm.AutoSize = true;
            this.Alarm.Location = new System.Drawing.Point(172, 9);
            this.Alarm.Name = "Alarm";
            this.Alarm.Size = new System.Drawing.Size(27, 12);
            this.Alarm.TabIndex = 16;
            this.Alarm.Text = "? 건";
            this.Alarm.Click += new System.EventHandler(this.Alarm_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(234, 261);
            this.Controls.Add(this.Alarm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.level);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.team);
            this.Controls.Add(this.company);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.seq);
            this.Controls.Add(this.번호);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Logout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(700, 300);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.main_FormClosed);
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label seq;
        private System.Windows.Forms.Label 번호;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label company;
        private System.Windows.Forms.Label team;
        private System.Windows.Forms.Label level;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label grade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Alarm;
    }
}