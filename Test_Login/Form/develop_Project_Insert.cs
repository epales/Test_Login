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
    public partial class develop_Project_Insert : Form
    {
        //------------------------------------------------------------------------------------------------------
        #region 변수 선언, DB 초기화
        //------------------------------------------------------------------------------------------------------
        static DBConnection DB = new DBConnection();
        SqlConnection conn = new SqlConnection(DB.DBstr());

        developMain developMain;
        bool exit;
        string dev_listCat ="";
        int count = 0;
        public string userId { get; set; }
        #endregion
        //------------------------------------------------------------------------------------------------------
        #region Form 이동
        //------------------------------------------------------------------------------------------------------
        public develop_Project_Insert(developMain devMain)
        {
            developMain = devMain;
            InitializeComponent();
        }
        #endregion
        //------------------------------------------------------------------------------------------------------
        #region Form Load 실행
        //------------------------------------------------------------------------------------------------------
        private void develop_Project_Insert_Load(object sender, EventArgs e)
        {
            reg_id.Text = userId;
            dev_class.SelectedIndex = 0;
            dev_cat1.SelectedIndex = 0;
            call_Manager();
        }
        #endregion
        //------------------------------------------------------------------------------------------------------
        #region 변수 입력
        //------------------------------------------------------------------------------------------------------
        private void call_Manager()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            string sqlQuary = "SELECT user_name FROM Members WHERE user_grade IN(SELECT number FROM [Members.Extra.grade] " +
                                                                                              "WHERE grade_list = @grade)";

            adapter.SelectCommand = new SqlCommand(sqlQuary, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@grade", "개발");
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable table = ds.Tables[0];

            Manager_check.DataSource = table;
            Manager_check.DisplayMember = "user_name";
            Manager_check.ValueMember = "user_name";
            
        }
        #endregion
        //------------------------------------------------------------------------------------------------------
        #region Call CategoryList
        //------------------------------------------------------------------------------------------------------
        private void call_devCat2StyleList(string devcat1)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            string sqlQuary = "SELECT * FROM [DevelopList.devCat.Style] WHERE dev_cat1 = @dev";

            adapter.SelectCommand = new SqlCommand(sqlQuary, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@dev", devcat1);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable table = ds.Tables[0];
            table = table.DefaultView.ToTable(true, new string[] { "dev_cat1", "dev_cat2" });
            dev_cat2.DataSource = table;
            dev_cat2.DisplayMember = "dev_cat2";
        }
        //------------------------------------------------------------------------------------------------------
        private void call_devCat3StyleList(string devcat1, string devcat2)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            string sqlQuary = "SELECT * FROM [DevelopList.devCat.Style] WHERE dev_cat1 = @dev1 " +
                                                                         "AND dev_cat2 = @dev2 ";

            adapter.SelectCommand = new SqlCommand(sqlQuary, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@dev1", devcat1);
            adapter.SelectCommand.Parameters.AddWithValue("@dev2", devcat2);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable table = ds.Tables[0];
            table = table.DefaultView.ToTable(true, new string[] { "dev_cat1", "dev_cat2","dev_cat3" });
            dev_cat3.DataSource = table;
            dev_cat3.DisplayMember = "dev_cat3";
        }
        //------------------------------------------------------------------------------------------------------
        private void call_devCat4StyleList(string devcat1, string devcat2, string devcat3)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            string sqlQuary = "SELECT * FROM [DevelopList.devCat.Style] WHERE dev_cat1 = @dev1 " +
                                                                         "AND dev_cat2 = @dev2 " +
                                                                         "AND dev_cat3 = @dev3 ";

            adapter.SelectCommand = new SqlCommand(sqlQuary, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@dev1", devcat1);
            adapter.SelectCommand.Parameters.AddWithValue("@dev2", devcat2);
            adapter.SelectCommand.Parameters.AddWithValue("@dev3", devcat3);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable table = ds.Tables[0];
            table = table.DefaultView.ToTable(true, new string[] { "dev_cat1", "dev_cat2", "dev_cat3","dev_cat4" });

            dev_cat4.DataSource = table;
            dev_cat4.DisplayMember = "dev_cat4";
        }
        //------------------------------------------------------------------------------------------------------
        private void call_devClassList(string devClass)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            string sqlQuary = "SELECT * FROM [DevelopList.devClass] WHERE dev_class = @dev";

            adapter.SelectCommand = new SqlCommand(sqlQuary, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@dev", devClass);

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable table = ds.Tables[0];

            dev_type.DataSource = table;
            dev_type.DisplayMember = "dev_type";
            dev_type.ValueMember = "dev_type";

        }
        //------------------------------------------------------------------------------------------------------
        private void call_devTypeList(string devClass, string devType)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            string sqlQuary = "SELECT * FROM [DevelopList.devCat] WHERE dev_type = @devType AND dev_class = @devClass";

            adapter.SelectCommand = new SqlCommand(sqlQuary, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@devType", devType);
            adapter.SelectCommand.Parameters.AddWithValue("@devClass", devClass);

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable table = ds.Tables[0];

            dev_status.DataSource = table;
            dev_status.DisplayMember = "dev_status";
            dev_status.ValueMember = "dev_status";

        }
        //------------------------------------------------------------------------------------------------------
        private void call_devCat()
        {
            conn.Open();

            string sql = "SELECT * FROM [DevelopList.devCat.Style] WHERE dev_cat1 = @dev1 " +
                                                                  "AND dev_cat2 = @dev2 " +
                                                                  "AND dev_cat3 = @dev3 " +
                                                                  "AND dev_cat4 = @dev4 " +
                                                                  "AND dev_add = 1";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@dev1", dev_cat1.Text);
            cmd.Parameters.AddWithValue("@dev2", dev_cat2.Text);
            cmd.Parameters.AddWithValue("@dev3", dev_cat3.Text);
            cmd.Parameters.AddWithValue("@dev4", dev_cat4.Text);

            SqlDataReader reader = cmd.ExecuteReader();


            if (reader.Read())
            {
                if (count == 0 && dataGridView1.Rows.Count <= 1)
                {
                    dataGridView1.Rows.Clear();
                    dataGridView1.Rows.Add((string)reader["dev_cat1"],
                                           (string)reader["dev_cat2"],
                                           (string)reader["dev_cat3"],
                                           (string)reader["dev_cat4"]);
                } 
                else if (count == 1 && dataGridView1.Rows.Count > 1)
                {
                    dataGridView1.Rows.Remove(dataGridView1.Rows[1]);
                    dataGridView1.Rows.Add((string)reader["dev_cat1"],
                                           (string)reader["dev_cat2"],
                                           (string)reader["dev_cat3"],
                                           (string)reader["dev_cat4"]);
                } else if(count == 1 && dataGridView1.Rows.Count == 1)
                {
                    dataGridView1.Rows.Add((string)reader["dev_cat1"],
                                           (string)reader["dev_cat2"],
                                           (string)reader["dev_cat3"],
                                           (string)reader["dev_cat4"]);
                }
            }
            reader.Close();
            conn.Close();
        }
        //------------------------------------------------------------------------------------------------------
        private void call_devlistCat()
        {
            conn.Open();

            string sql = "SELECT * FROM [DevelopList.devCat.Style] WHERE dev_cat1 = @dev1 " +
                                                                  "AND dev_cat2 = @dev2 " +
                                                                  "AND dev_cat3 = @dev3 " +
                                                                  "AND dev_cat4 = @dev4 " +
                                                                  "AND dev_add = 1";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@dev1", dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            cmd.Parameters.AddWithValue("@dev2", dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            cmd.Parameters.AddWithValue("@dev3", dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            cmd.Parameters.AddWithValue("@dev4", dataGridView1.SelectedRows[0].Cells[3].Value.ToString());

            SqlDataReader reader = cmd.ExecuteReader();


            if (reader.Read())
            {
                dev_listCat = (string)reader["dev_listCat"];   
            }
            reader.Close();
            conn.Close();


        }
        #endregion
        //------------------------------------------------------------------------------------------------------
        #region DevelopList Insert
        //------------------------------------------------------------------------------------------------------
        private void InsertDev()
        {
            conn.Open();

            

            string sqlstr = "INSERT INTO DevelopList(seq," +
                                                "dev_class," +
                                                "dev_type," +
                                                "document_num," +
                                                "category," +
                                                "dev_name," +
                                                "req_date," +
                                                "assign_date," +
                                                "start_date," +
                                                "ex_complete_date," +
                                                "complete_date," +
                                                "fulfillment_date," +
                                                "resource," +
                                                "manage_people," +
                                                "status," +
                                                "detail," +
                                                "dev_module," +
                                                "reg_id," +
                                                "scheduler_yn," +
                                                "migration_yn," +
                                                "bizbank_yn," +
                                                "bizbank_date) VALUES (NEXT VALUE FOR seq," +
                                                                                  "@dev_class," +
                                                                                  "@dev_type," +
                                                                                  "@document_num," +
                                                                                  "@category," +
                                                                                  "@dev_name," +
                                                                                  "@req_date," +
                                                                                  "@assign_date," +
                                                                                  "@start_date," +
                                                                                  "@ex_complete_date," +
                                                                                  "@complete_date," +
                                                                                  "@fulfillment_date," +
                                                                                  "@resource," +
                                                                                  "@manage_people," +
                                                                                  "@status," +
                                                                                  "@detail," +
                                                                                  "@dev_module," +
                                                                                  "@reg_id," +
                                                                                  "@scheduler_yn," +
                                                                                  "@migration_yn," +
                                                                                  "@bizbank_yn," +
                                                                                  "@bizbank_date)";

            SqlCommand cmd = new SqlCommand(sqlstr, conn);
            //
            cmd.Parameters.AddWithValue("@dev_class", dev_class.Text);
            cmd.Parameters.AddWithValue("@dev_type", dev_type.Text);
            cmd.Parameters.AddWithValue("@document_num", document_num.Text);
            cmd.Parameters.AddWithValue("@category", dev_listCat);
            cmd.Parameters.AddWithValue("@dev_name", dev_name.Text);
            cmd.Parameters.AddWithValue("@req_date", start_date.Text);
            cmd.Parameters.AddWithValue("@assign_date", start_date.Text);
            cmd.Parameters.AddWithValue("@start_date", start_date.Text);
            cmd.Parameters.AddWithValue("@ex_complete_date", start_date.Text);
            cmd.Parameters.AddWithValue("@complete_date", start_date.Text);
            cmd.Parameters.AddWithValue("@fulfillment_date", start_date.Text);
            cmd.Parameters.AddWithValue("@resource", "");
            cmd.Parameters.AddWithValue("@manage_people", Manager_check.SelectedValue);
            cmd.Parameters.AddWithValue("@reg_id", reg_id.Text);
            cmd.Parameters.AddWithValue("@status", dev_status.Text);
            cmd.Parameters.AddWithValue("@detail", detail.Text);
            cmd.Parameters.AddWithValue("@dev_module", dev_module.Text);

            if (scheduler_yn.Checked)
            {
                cmd.Parameters.AddWithValue("@scheduler_yn", "Y");
            }
            else
            {
                cmd.Parameters.AddWithValue("@scheduler_yn", "N");
            }

            if (migration_yn.Checked)
            {
                cmd.Parameters.AddWithValue("@migration_yn", "N");
            }
            else
            {
                cmd.Parameters.AddWithValue("@migration_yn", "N");
            }

            if (bizbank_yn.Checked)
            {
                cmd.Parameters.AddWithValue("@bizbank_yn", "N");
            }
            else
            {
                cmd.Parameters.AddWithValue("@bizbank_yn", "N");
            }



            cmd.Parameters.AddWithValue("@bizbank_date", bizbank_date.Text);

            cmd.ExecuteNonQuery();
            conn.Close();

            exit = true;
            this.Close();
            developMain.Visible = true;
            developMain.call_developList();
        }
        #endregion
        //------------------------------------------------------------------------------------------------------
        #region Form Closed
        //------------------------------------------------------------------------------------------------------
        private void develop_Project_Insert_FormClosed(object sender, FormClosedEventArgs e)
        {
           /* if (exit)
            {
                return;
            }
            Application.Exit();*/
        }
        #endregion
        //------------------------------------------------------------------------------------------------------
        #region Click Event
        //------------------------------------------------------------------------------------------------------
        private void Exit_Click(object sender, EventArgs e)
        {
            exit = true;
            this.Close();
        }
        //------------------------------------------------------------------------------------------------------
        private void search_Click(object sender, EventArgs e)
        {
            call_devCat();
        }
        //------------------------------------------------------------------------------------------------------
        private void add_Click(object sender, EventArgs e)
        {
            if (count == 0 && dataGridView1.Rows.Count > 0)
            {
                call_devlistCat();
                dataGridView1.SelectedRows[0].DefaultCellStyle.SelectionBackColor = Color.Gray;
                dataGridView1.SelectedRows[0].DefaultCellStyle.BackColor = Color.Gray;
                count++;
                Console.WriteLine(dev_listCat);
            }
        }
        //------------------------------------------------------------------------------------------------------
        private void delete_Click(object sender, EventArgs e)
        {
            if (count == 1 && dataGridView1.SelectedRows[0].DefaultCellStyle.BackColor == Color.Gray)
            {
                dev_listCat = "";
                dataGridView1.SelectedRows[0].DefaultCellStyle.SelectionBackColor = Color.Blue;
                dataGridView1.SelectedRows[0].DefaultCellStyle.BackColor = Color.White;
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                count--;
                Console.WriteLine("삭제");
            }
            else if (count == 1 && dataGridView1.SelectedRows[0].DefaultCellStyle.BackColor != Color.Gray)
            {
                dev_listCat = "";
                dataGridView1.SelectedRows[0].DefaultCellStyle.SelectionBackColor = Color.Blue;
                dataGridView1.SelectedRows[0].DefaultCellStyle.BackColor = Color.White;
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
            else if (count == 0 && dataGridView1.Rows.Count > 0)
            {
                dev_listCat = "";
                dataGridView1.SelectedRows[0].DefaultCellStyle.SelectionBackColor = Color.Blue;
                dataGridView1.SelectedRows[0].DefaultCellStyle.BackColor = Color.White;
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
        }
        //------------------------------------------------------------------------------------------------------
        private void Up_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int rows_cnt = dataGridView1.CurrentRow.Index;

                if (rows_cnt > 0)
                {
                    rows_cnt -= 1;
                }
                dataGridView1.CurrentCell = dataGridView1.Rows[rows_cnt].Cells[0];
            }

        }
        //------------------------------------------------------------------------------------------------------
        private void Down_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int rows_max = dataGridView1.Rows.Count - 1;
                int rows_cnt = dataGridView1.CurrentRow.Index;

                if (rows_cnt < rows_max)
                {
                    rows_cnt += 1;
                }

                dataGridView1.CurrentCell = dataGridView1.Rows[rows_cnt].Cells[0];
            }
        }
        //------------------------------------------------------------------------------------------------------
        private void Manager_check_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            if (e.NewValue == CheckState.Checked)
            {
                for (int cnt = 0; cnt < Manager_check.Items.Count; ++cnt)
                {
                    if (e.Index != cnt)
                    {
                        Manager_check.SetItemChecked(cnt, false);
                    }
                }
            }

        }
        //------------------------------------------------------------------------------------------------------
        private void Insert_Click(object sender, EventArgs e)
        {
            if (dev_listCat == "")
            {
                MessageBox.Show("카테고리를 추가해주세요");
                return;
            }
            if (!Manager_check.GetItemChecked(Manager_check.SelectedIndex))
            {
                MessageBox.Show("담당자를 선택해주세요");
                return;
            }
            InsertDev();
        }
        //------------------------------------------------------------------------------------------------------
        ///초기화///
        //------------------------------------------------------------------------------------------------------
        private void reset_Click(object sender, EventArgs e)
        {
            dev_class.Text = "전체";
            dev_type.Text = "전체";
            dev_status.Text = "전체";

            count = 0;
            dataGridView1.Rows.Clear();
            dev_listCat = "";

            dev_name.Text = "";
            dev_module.Text = "";
            document_num.Text = "";
            detail.Text = "";
            dev_cat1.Text = "선택";

            scheduler_yn.Checked = false;
            bizbank_yn.Checked = false;
            migration_yn.Checked = false;

            start_date.Value = DateTime.Today;
            req_date.Value = DateTime.Today;
            assign_date.Value = DateTime.Today;
            ex_complete_date.Value = DateTime.Today;
            complete_date.Value = DateTime.Today;
            fulfillment_date.Value = DateTime.Today;
            bizbank_date.Value = DateTime.Today;

            for (int cnt = 0; cnt < Manager_check.Items.Count; ++cnt)
            {
                Manager_check.SetItemChecked(cnt, false);
            }
        }
        #endregion
        //------------------------------------------------------------------------------------------------------
        #region TextChanged Event
        //------------------------------------------------------------------------------------------------------
        private void dev_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            call_devClassList(dev_class.Text);
        }
        //------------------------------------------------------------------------------------------------------
        private void dev_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            call_devTypeList(dev_class.Text, dev_type.Text);
        }
        //------------------------------------------------------------------------------------------------------
        private void dev_cat1_SelectedIndexChanged(object sender, EventArgs e)
        {
            call_devCat2StyleList(dev_cat1.Text);
        }
        //------------------------------------------------------------------------------------------------------
        private void dev_cat2_SelectedIndexChanged(object sender, EventArgs e)
        {
            call_devCat3StyleList(dev_cat1.Text, dev_cat2.Text);
        }
        //------------------------------------------------------------------------------------------------------
        private void dev_cat3_SelectedIndexChanged(object sender, EventArgs e)
        {
            call_devCat4StyleList(dev_cat1.Text, dev_cat2.Text, dev_cat3.Text);
        }
        #endregion
        //------------------------------------------------------------------------------------------------------
    }
}
