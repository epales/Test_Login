
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
using Tetris;

namespace Test_Login
{
    public partial class main : Form
    {
        #region DB 초기화
        static DBConnection DB = new DBConnection();
        SqlConnection conn = new SqlConnection(DB.DBstr());
        login loginForm;
        bool logout;
        #endregion

        #region 로그인 유저 정보 초기화
        public string userId { get; set; }
        #endregion

        #region Form 이동
        public main(login login)
        {
            InitializeComponent();
            loginForm = login;
        }

        #endregion

        #region 로그아웃 기능
        private void Logout_Click(object sender, EventArgs e)
        {
            Console.WriteLine("=============== 로그아웃 ===============");
            Console.WriteLine("=============== 메인화면 창 종료 ===============");
            Properties.Settings.Default.LoginAutoLoginCheck = false;
            Properties.Settings.Default.LoginPWDSave = "";
            Properties.Settings.Default.Save();

            logout = true;

            this.Close();
        }
        #endregion

        #region 메인화면
        private void main_Load(object sender, EventArgs e)
        {
            Console.WriteLine("=============== 메인화면 창 활성화 ===============");
           
            conn.Open();
            string sql = "SELECT * FROM Members WHERE user_id = @user_id";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@user_id", userId);

            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            if ((string)reader["user_name"] != "" && (string)reader["seq"] != "")
            {
                name.Text = (string)reader["user_name"];
                seq.Text = (string)reader["seq"];
                company.Text = (string)reader["user_company"];
                team.Text = (string)reader["user_team"];
                level.Text = (string)reader["user_level"];
                grade.Text = (string)reader["user_grade"];

            }
            else
            {
                name.Text = "(NONE)";
                seq.Text = "(NONE)";
                company.Text = "(NONE)";
                team.Text = "(NONE)";
                level.Text = "(NONE)";
                grade.Text = "(NONE)";
            }

            conn.Close();

            reader.Close();

            switchTeamData(team.Text);
            switchLevelData(level.Text);
            switchGradeData(grade.Text);
        }
        #endregion

        #region 유저 데이터 변환

        private void switchTeamData(string teamName)
        {
            conn.Open();
            string sql = "SELECT * FROM [Members.Extra.team] WHERE number = @number";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@number", teamName);
            
            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            team.Text = (string)reader["team_list"];

            reader.Close();
            conn.Close();
        }

        private void switchGradeData(string gradeName)
        {
            conn.Open();

            string sql = "SELECT * FROM [Members.Extra.grade] WHERE number = @number";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@number", gradeName);

            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            grade.Text = (string)reader["grade_list"];

            reader.Close();
            conn.Close();

        }
        private void switchLevelData(string levelName)
        {
            conn.Open();

            string sql = "SELECT * FROM [Members.Extra.level] WHERE number = @number";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@number", levelName);

            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            level.Text = (string)reader["level_list"];

            reader.Close();
            conn.Close();

        }
        #endregion

        #region 시스템 종료
        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (logout)
            {
                loginForm.reset();
                return;
            }

            Application.Exit();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            var tetris = new Form1();
            tetris.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            developMain dep = new developMain(this);
            dep.userId = userId;
            this.Visible = false;
            dep.ShowDialog();
        }
    }
}
