using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Test_Login.Properties;

namespace Test_Login
{
    
    public partial class login : Form
    {
        #region Form
        public login()
        {
            InitializeComponent();
        }
        
        public void reset()
        {
            Console.WriteLine("=============== 로그인 화면 복귀 ===============");
            if (!id_save.Checked)
            {
                user_id.Text = "";
            }
            auto_login.Checked = false;
            user_password.Text = "";

            this.Visible = true;
        }
        public void allReset()
        {
            Console.WriteLine("=============== 회원가입 완료 로그인 화면 초기화 ===============");

            Properties.Settings.Default.LoginIDSaveCheck = false;
            Properties.Settings.Default.LoginIDSave = "";
            Properties.Settings.Default.LoginAutoLoginCheck = false;
            Properties.Settings.Default.LoginPWDSave = "";
            Properties.Settings.Default.Save();

            user_id.Text = "";
            user_password.Text = "";
            id_save.Checked = false;
            auto_login.Checked = false;
            
            this.Visible = true;
        }
        #endregion

        #region Load
       
        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("=============== 로그인 시스템 시작 ===============");
            user_id.Text = Properties.Settings.Default.LoginIDSave;
            user_password.Text = Properties.Settings.Default.LoginPWDSave;
            id_save.Checked = Properties.Settings.Default.LoginIDSaveCheck;
            auto_login.Checked = Properties.Settings.Default.LoginAutoLoginCheck;

            if (user_id.Text != "" && user_password.Text != "")
            {
                loginButton.Enabled = true;
                if (auto_login.Checked)
                {
                    Console.WriteLine("=============== 자동 로그인 ===============");
                    Login_Click(sender, e);
                }
            }
            else
            {
                loginButton.Enabled = false;
            }
            if (!id_save.Checked)
            {
                auto_login.Enabled = false;
            }
        }
        
        // Enter 키 입력 시 로그인 실행
        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && loginButton.Enabled == true)
            {
                Login_Click(sender, e);
            }
        }
        #endregion

        #region 텍스트 미 입력시 로그인 버튼 차단
        private void Id(object sender, EventArgs e)
        {
            if (user_id.Text != "" && user_password.Text != "")
            {
                loginButton.Enabled = true;
            }
            if (user_id.Text == "" || user_password.Text == "")
            {
                loginButton.Enabled = false;
            }
        }

        private void Password(object sender, EventArgs e)
        {
            if (user_id.Text != "" && user_password.Text != "")
            {
                loginButton.Enabled = true;
            }
            if (user_id.Text == "" || user_password.Text == "")
            {
                loginButton.Enabled = false;
            }
        }
        #endregion

        #region 로그인
        private void Login_Click(object sender, EventArgs e)
        {
            DBConnection DB = new DBConnection();

            SqlConnection conn = new SqlConnection(DB.DBstr());

            Console.WriteLine("=============== 로그인 시도 ===============");

            string userId = user_id.Text;
            string userPassword = user_password.Text;
           
            conn.Open();

            string sql = "SELECT * FROM Members WHERE user_id = @user_id And user_password = @user_password";

            SqlCommand cmd = new SqlCommand(sql , conn);

            cmd.Parameters.AddWithValue("@user_id", userId);
            cmd.Parameters.Add(new SqlParameter("@user_password", SqlDbType.VarChar, 50)).Value = userPassword;

            SqlDataReader reader = cmd.ExecuteReader();
            
            if(reader.Read() == true && userId != "" && userPassword != "")
            {
                if (userId.Equals((string)reader["user_id"]) && userPassword.Equals((string)reader["user_password"]))
                {
                    Console.WriteLine("=============== 로그인 성공 ===============");
                    if (id_save.Checked)
                    {
                        Properties.Settings.Default.LoginIDSaveCheck = true;
                        Properties.Settings.Default.LoginIDSave = userId;
                        if (auto_login.Checked && auto_login.Enabled == true)
                        { 
                            Properties.Settings.Default.LoginAutoLoginCheck = true;
                            Properties.Settings.Default.LoginPWDSave = userPassword;
                        }
                        else
                        {
                            Properties.Settings.Default.LoginAutoLoginCheck = false;
                            Properties.Settings.Default.LoginPWDSave = "";
                        }
                    }
                    else
                    {
                        Properties.Settings.Default.LoginIDSaveCheck = false;
                        Properties.Settings.Default.LoginIDSave = "";
                        Properties.Settings.Default.LoginAutoLoginCheck = false;
                        Properties.Settings.Default.LoginPWDSave = "";
                    }
                    
                    Properties.Settings.Default.Save();
                    this.Visible = false;
                    main main = new main(this);
                    main.userId = userId;
                    main.ShowDialog();
                    
                }
            }
            else
            {
                Console.WriteLine("=============== 로그인 실패 ===============");
                user_password.Text = "";
                MessageBox.Show("아이디 혹은 비밀번호가 일치하지 않습니다.", "로그인");
            }

            conn.Close();
            reader.Close();
        }
        #endregion

        #region 시스템 종료
        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine("=============== 시스템 종료 ===============");
            Properties.Settings.Default.Save();
            Application.Exit();
        }
        #endregion

        #region 회원가입 창 이동
        private void Register_Click(object sender, EventArgs e)
        {
            Console.WriteLine("=============== 회원가입 창 이동 ===============");

            this.Hide();
            join join = new join(this);
            join.ShowDialog();
        }
        #endregion

        #region 아이디 저장, 자동로그인 체크

        #region 아이디 저장
        private void id_save_CheckedChanged(object sender, EventArgs e)
        {
            if (!id_save.Checked)
            {
                Console.WriteLine("=============== 아이디 저장 체크 취소 ===============");
                Properties.Settings.Default.LoginIDSaveCheck = false;
                Properties.Settings.Default.LoginIDSave = "";
                auto_login.Enabled = false;
            }
            else
            {
                Console.WriteLine("=============== 아이디 저장 체크 ===============");
                auto_login.Enabled = true;
            }

        }
        #endregion

        #region 자동 로그인
        private void auto_login_CheckedChanged(object sender, EventArgs e)
        {
            if (!auto_login.Checked)
            {
                Console.WriteLine("=============== 자동 로그인 체크 취소 ===============");
                Properties.Settings.Default.LoginAutoLoginCheck = false;
            }
            else
            {
                Console.WriteLine("=============== 자동 로그인 체크 ===============");
            }
        }

        #endregion

        #endregion

        
    }
}
