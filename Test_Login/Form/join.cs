using Org.BouncyCastle.Utilities;
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
    public partial class join : Form
    {
        #region 초기화

        static DBConnection DB = new DBConnection();
        SqlConnection conn = new SqlConnection(DB.DBstr());
        login loginForm;
        bool main;

        bool id;
        bool passwordChk;
        private void buttonDisable()
        {
            if (user_id.Text == "" || user_password.Text == "" || user_name.Text == "" || passcheck.Text == "" ||
                level.Text == "" || company.Text == "" || grade.Text == "" || banksabun.Text == "" || bankcertpw.Text == "" ||
                team.Text == "" || in_svn_id.Text == "" || in_svn_pw.Text == "" || out_svn_id.Text == "" || out_svn_pw.Text == "")
            {
                button1.Enabled = false;
            }
        }
        private void buttonEnable()
        {
            if (id && passwordChk && user_id.Text != "" && user_password.Text != "" && user_name.Text != "" && passcheck.Text != "" &&
                level.Text != "" && company.Text != "" && grade.Text != "" && banksabun.Text != "" && bankcertpw.Text != "" &&
                team.Text != "" && in_svn_id.Text != "" && in_svn_pw.Text != "" && out_svn_id.Text != "" && out_svn_pw.Text != "")
            {
                button1.Enabled = true;
            }
        }
        private void passwordEnable()
        {
            if (user_password.Text != "" && passcheck.Text != "")
            {
                if (user_password.Text != passcheck.Text)
                {
                    passwordChk = false;
                    button1.Enabled = false;
                    Password_Check.Text = "비밀번호가 일치하지 않습니다.";
                    Password_Check.ForeColor = Color.Red;
                }
                else
                {
                    if (id && user_name.Text != "" && passcheck.Text != "" &&
                        level.Text != "" && company.Text != "" && grade.Text != "" && banksabun.Text != "" && bankcertpw.Text != "" &&
                        team.Text != "" && in_svn_id.Text != "" && in_svn_pw.Text != "" && out_svn_id.Text != "" && out_svn_pw.Text != "")
                    {

                        button1.Enabled = true;
                    }
                    passwordChk = true;
                    Password_Check.Text = "비밀번호가 일치합니다.";
                    Password_Check.ForeColor = Color.Green;
                }
            }
            else
            {
                passwordChk = false;
                button1.Enabled = false;
                Password_Check.Text = "비밀번호를 입력해주세요.";
                Password_Check.ForeColor = Color.Red;
            }
        }
        private void comboBox_control()
        {
            if(company.Text == "")
            {
                team.Enabled = false;
                level.Enabled = false;
                grade.Enabled = false;
            }
            else
            {
                team.Enabled = true;

                if(team.Text == "")
                {
                    level.Enabled = false;
                }
                else
                {
                    level.Enabled = true;
                    if(level.Text == "")
                    {
                        grade.Enabled = false;
                    }
                    else
                    {
                        grade.Enabled = true;
                    }
                }
            }
        }

        private void companySelect(string company)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            string sqlQuary = "SELECT * FROM [Members.Extra.team] WHERE company_list = @company";
            
            adapter.SelectCommand = new SqlCommand(sqlQuary, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@company", company);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable table = ds.Tables[0];
            
            team.DataSource = table;
            team.DisplayMember = "team_list";
            team.ValueMember = "team_list";

        }

        private void teamSelect(string company)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            string sqlQuary = "SELECT * FROM [Members.Extra.level] WHERE company_list = @company";

            adapter.SelectCommand = new SqlCommand(sqlQuary, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@company", company);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable table = ds.Tables[0];

            level.DataSource = table;
            level.DisplayMember = "level_list";
            level.ValueMember = "level_list";

        }
        private void levelSelect(string team)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            string sqlQuary = "SELECT * FROM [Members.Extra.grade] WHERE team_list = @team_list";

            adapter.SelectCommand = new SqlCommand(sqlQuary, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@team_list", team);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable table = ds.Tables[0];


            grade.DataSource = table;
            grade.DisplayMember = "grade_list";
            grade.ValueMember = "grade_list";

        }

        private string teamNum(string company, string team)
        {
            conn.Open();

            string sql = "SELECT number FROM [Members.Extra.team] WHERE company_list = @company AND team_list = @team";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@company", company);
            cmd.Parameters.Add(new SqlParameter("@team", SqlDbType.VarChar, 50)).Value = team;

            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            string sort_order = (string)reader["number"];

            reader.Close();
            conn.Close();

            return sort_order;
        }

        private string levelNum(string company,string level)
        {
            conn.Open();

            string sql = "SELECT number FROM [Members.Extra.level] WHERE company_list = @company AND level_list = @level";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@company", company);
            cmd.Parameters.Add(new SqlParameter("@level", SqlDbType.VarChar, 50)).Value = level;

            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            string sort_order = (string)reader["number"];

            reader.Close();
            conn.Close();

            return sort_order;

        }
        private string gradeNum(string team, string grade)
        {
            conn.Open();

            string sql = "SELECT number FROM [Members.Extra.grade] WHERE team_list = @team AND grade_list = @grade";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@team", team);
            cmd.Parameters.Add(new SqlParameter("@grade", SqlDbType.VarChar, 50)).Value = grade;

            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            string sort_order = (string)reader["number"];

            reader.Close();
            conn.Close();

            return sort_order;
        }
        #endregion

        #region Form 이동

        public join(login login)
        {
            InitializeComponent();
            loginForm = login;
        }

        #endregion

        #region 시스템 종료

        private void join_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(main == true)
            {
                return;
            }

            Application.Exit();
        }

        #endregion

        #region 로그인 폼 이동

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("=============== 회원가입 시스템 종료 ===============");
            main = true;
            this.Close();
            loginForm.reset();
        }

        #endregion

        #region 회원가입

        private void button1_Click(object sender, EventArgs e)
        {
            ID(sender, e);

            if (!id)
            {
                return;
            }

            string userlevel = levelNum(company.Text,level.Text);
            string usergrade = gradeNum(team.Text,grade.Text);
            string userteam = teamNum(company.Text, team.Text);
            string sort_order = userlevel + usergrade + userteam;

            conn.Open();

            string sqlstr = "INSERT INTO Members(seq," +
                                                "user_id," +
                                                "user_password," +
                                                "user_name," +
                                                "user_level,"+
                                                "user_company," +
                                                "user_grade," +
                                                "user_banksabun," +
                                                "user_bankcertpw," +
                                                "user_team," +
                                                "insvn_id," +
                                                "insvn_pw," +
                                                "outsvn_id," +
                                                "outsvn_pw," +
                                                "sort_order) VALUES(NEXT VALUE FOR seq," +
                                                                                 "@user_id," +
                                                                                 "@user_password," +
                                                                                 "@user_name," +
                                                                                 "@user_level," +
                                                                                 "@user_company," +
                                                                                 "@user_grade," +
                                                                                 "@user_banksabun," +
                                                                                 "@user_bankcertpw," +
                                                                                 "@user_team," +
                                                                                 "@insvn_id," +
                                                                                 "@insvn_pw," +
                                                                                 "@outsvn_id," +
                                                                                 "@outsvn_pw," +
                                                                                 "@sort_order)";

            SqlCommand cmd = new SqlCommand(sqlstr,conn);

            cmd.Parameters.AddWithValue("@user_id", user_id.Text);
            cmd.Parameters.AddWithValue("@user_password", user_password.Text);
            cmd.Parameters.AddWithValue("@user_name", user_name.Text);
            cmd.Parameters.AddWithValue("@user_level", userlevel);
            cmd.Parameters.AddWithValue("@user_company", company.Text);
            cmd.Parameters.AddWithValue("@user_grade", usergrade);
            cmd.Parameters.AddWithValue("@user_banksabun", banksabun.Text);
            cmd.Parameters.AddWithValue("@user_bankcertpw", bankcertpw.Text);
            cmd.Parameters.AddWithValue("@user_team", userteam);
            cmd.Parameters.AddWithValue("@insvn_id", in_svn_id.Text);
            cmd.Parameters.AddWithValue("@insvn_pw", in_svn_pw.Text);
            cmd.Parameters.AddWithValue("@outsvn_id", out_svn_id.Text);
            cmd.Parameters.AddWithValue("@outsvn_pw", out_svn_pw.Text);
            cmd.Parameters.AddWithValue("@sort_order", sort_order);
            
            cmd.ExecuteNonQuery(); 
            conn.Close();

            MessageBox.Show("회원 가입이 완료되었습니다.", "회원가입");

            Console.WriteLine("=============== 회원가입 완료 ===============");
            main = true;
            this.Close();
            
            loginForm.allReset();
        }

        #endregion

        #region 회원가입 버튼 초기화, 제한

        private void join_Load(object sender, EventArgs e)
        {
            Console.WriteLine("=============== 회원가입 시스템 시작 ===============");
            button1.Enabled = false;
            level.Enabled = false;
            grade.Enabled = false;
            team.Enabled = false;
        }

        #region 아이디 중복체크, 텍스트 입력
        private void ID(object sender, EventArgs e)
        {
            if (user_id.Text != "")
            {
                SqlConnection conn = new SqlConnection(DB.DBstr());
                conn.Open();
                string sql = "SELECT user_id FROM Members WHERE user_id = @user_id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@user_id", user_id.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                
                if (reader.Read() && (user_id.Text).Equals((string)reader["user_id"]))
                {
                    Console.WriteLine("=============== 아이디 중복 ===============");
                    id = false;
                    button1.Enabled = false;
                    id_check.Text = "중복된 아이디 입니다.";
                    id_check.ForeColor = Color.Red;
                } 
                else
                {
                    id = true;
                    button1.Enabled = true;
                    id_check.Text = "사용가능한 아이디 입니다.";
                    id_check.ForeColor = Color.Green;
                }

                conn.Close();
                reader.Close();
            }
            else
            {
                id_check.Text = "아이디를 입력해주세요.";
                id_check.ForeColor = Color.Red;
            }
            buttonDisable();
        }
        #endregion

        #region 패스워드 텍스트 입력
        private void Password(object sender, EventArgs e)
        {
            buttonDisable();

            passwordEnable();
            

        }

        private void passwordcheck(object sender, EventArgs e)
        {
            buttonDisable();
            passwordEnable();

        }

        #endregion

        #region 이름 텍스트 입력
        private void username(object sender, EventArgs e)
        {
            buttonDisable();
            buttonEnable();
        }
        #endregion

        private void out_svn_id_TextChanged(object sender, EventArgs e)
        {
            buttonDisable();
            buttonEnable();
        }
        private void out_svn_pw_TextChanged(object sender, EventArgs e)
        {
            buttonDisable();
            buttonEnable();
        }

        private void in_svn_id_TextChanged(object sender, EventArgs e)
        {
            buttonDisable();
            buttonEnable();
        }

        private void in_svn_pw_TextChanged(object sender, EventArgs e)
        {
            buttonDisable();
            buttonEnable();
        }
        private void company_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDisable();
            buttonEnable();
            comboBox_control();
            companySelect(company.Text);
            
        }
        private void team_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDisable();
            buttonEnable();
            comboBox_control();
            teamSelect(company.Text);
            level.Text = "";
        }
        
        private void level_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDisable();
            buttonEnable();
            comboBox_control();
            levelSelect(team.Text);
            grade.Text = "";
        }
        
        private void grade_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDisable();
            buttonEnable();
            comboBox_control();
        }

        private void banksabun_TextChanged(object sender, EventArgs e)
        {
            buttonDisable();
            buttonEnable();
        }

        private void bankcertpw_TextChanged(object sender, EventArgs e)
        {
            buttonDisable();
            buttonEnable();
        }
        #endregion

        #region 아이디/비밀번호 찾기 폼 이동
        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("=============== 회원가입 시스템 종료 ===============");
            
            main = true;
            this.Visible = false;
            findIdPw find = new findIdPw(this , loginForm);
            find.ShowDialog();
        }



        #endregion

    }
}
