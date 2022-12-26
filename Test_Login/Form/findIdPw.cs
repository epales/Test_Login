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

namespace Test_Login
{
    public partial class findIdPw : Form
    {
        #region DB 초기화
        static DBConnection DB = new DBConnection();
        SqlConnection conn = new SqlConnection(DB.DBstr());
        join joinForm;
        login loginForm;
        bool main;
        #endregion

        #region Form 이동
        public findIdPw(join join , login login)
        {
            InitializeComponent();
            joinForm = join;
            loginForm = login;

        }
        
        #endregion

        #region 아이디 / 비밀번호 찾기 로드
        private void findIdPw_Load(object sender, EventArgs e)
        {
            Console.WriteLine("=============== 아이디/비밀번호 찾기 시스템 시작 ===============");

            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";

            button1.Enabled = false;
            button2.Enabled = false;
        }
        #endregion

        #region 아이디 찾기
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            string sql = "SELECT * FROM Members WHERE user_name = @user_name And seq = @seq";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@user_name", name1.Text);
            cmd.Parameters.AddWithValue("@seq", num.Text);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                label5.Text = "아이디";
                label6.Text = (string)reader["user_id"].ToString();
            }
            else
            {
                label5.Text = "";
                label6.Text = "";
                MessageBox.Show("회원 정보가 일치하지 않습니다.");
            }

            conn.Close();
            reader.Close();
            
        }
        #endregion

        #region 비밀번호 찾기
        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();

            string sql = "SELECT * FROM Members WHERE user_name = @user_name And user_id = @user_id";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@user_name", name2.Text);
            cmd.Parameters.AddWithValue("@user_id", ID.Text);

            SqlDataReader reader = cmd.ExecuteReader();

            if(reader.Read())
            {
                label8.Text = "비밀번호";
                label7.Text = (string)reader["user_password"].ToString();
            }
            else
            {
                label8.Text = "";
                label7.Text = "";
                MessageBox.Show("회원 정보가 일치하지 않습니다.");
                
            }
            conn.Close();
            reader.Close();
            
        }
        #endregion

        #region 시스템 종료
        private void findIdPw_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (main == true)
            {
                return;
            }

            Application.Exit();
        }
        #endregion

        #region 로그인 이동
        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("=============== 아이디/비밀번호 찾기 시스템 종료 ===============");
            main = true;
            this.Close();
            joinForm.Close();
            loginForm.reset();

        }
        #endregion

        #region 아이디 / 비밀번호 찾기 버튼 제한
        private void idTyping(string name, string num)
        {
            if (name == "" || num == "")
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }
        private void pwTyping(string name, string ID)
        {
            if (name == "" || ID == "")
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
        }
        private void name1_TextChanged(object sender, EventArgs e)
        {
            idTyping(name1.Text, num.Text);
        }

        private void num_TextChanged(object sender, EventArgs e)
        {
            idTyping(name1.Text, num.Text);
        }

        private void name2_TextChanged(object sender, EventArgs e)
        {
            pwTyping(name2.Text, ID.Text);
        }

        private void ID_TextChanged(object sender, EventArgs e)
        {
            pwTyping(name2.Text, ID.Text);
        }
        #endregion

        
    }
}
