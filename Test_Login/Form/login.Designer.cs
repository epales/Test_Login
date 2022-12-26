namespace Test_Login
{
    partial class login
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.auto_login = new System.Windows.Forms.CheckBox();
            this.id_save = new System.Windows.Forms.CheckBox();
            this.Register = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.user_password = new System.Windows.Forms.TextBox();
            this.user_id = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.auto_login);
            this.groupBox1.Controls.Add(this.id_save);
            this.groupBox1.Controls.Add(this.Register);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.user_password);
            this.groupBox1.Controls.Add(this.user_id);
            this.groupBox1.Controls.Add(this.loginButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // auto_login
            // 
            this.auto_login.AutoSize = true;
            this.auto_login.Location = new System.Drawing.Point(118, 142);
            this.auto_login.Name = "auto_login";
            this.auto_login.Size = new System.Drawing.Size(88, 16);
            this.auto_login.TabIndex = 4;
            this.auto_login.Text = "자동 로그인";
            this.auto_login.UseVisualStyleBackColor = true;
            this.auto_login.CheckedChanged += new System.EventHandler(this.auto_login_CheckedChanged);
            this.auto_login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_KeyDown);
            // 
            // id_save
            // 
            this.id_save.AutoSize = true;
            this.id_save.Location = new System.Drawing.Point(8, 142);
            this.id_save.Name = "id_save";
            this.id_save.Size = new System.Drawing.Size(88, 16);
            this.id_save.TabIndex = 3;
            this.id_save.Text = "아이디 저장";
            this.id_save.UseVisualStyleBackColor = true;
            this.id_save.CheckedChanged += new System.EventHandler(this.id_save_CheckedChanged);
            this.id_save.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_KeyDown);
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(8, 179);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(196, 23);
            this.Register.TabIndex = 5;
            this.Register.Text = "회원가입";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // user_password
            // 
            this.user_password.Location = new System.Drawing.Point(6, 99);
            this.user_password.Name = "user_password";
            this.user_password.PasswordChar = '*';
            this.user_password.Size = new System.Drawing.Size(198, 21);
            this.user_password.TabIndex = 2;
            this.user_password.TextChanged += new System.EventHandler(this.Password);
            this.user_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_KeyDown);
            // 
            // user_id
            // 
            this.user_id.Location = new System.Drawing.Point(6, 44);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(198, 21);
            this.user_id.TabIndex = 1;
            this.user_id.TextChanged += new System.EventHandler(this.Id);
            this.user_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_KeyDown);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(8, 208);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(196, 23);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "로그인";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.Login_Click);
            this.loginButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_KeyDown);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(234, 261);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(700, 300);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Program";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.login_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox user_password;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.CheckBox auto_login;
        private System.Windows.Forms.CheckBox id_save;
        private System.Windows.Forms.TextBox user_id;
    }
}

