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
    public partial class develop_Project_update : Form
    {

        static DBConnection DB = new DBConnection();
        SqlConnection conn = new SqlConnection(DB.DBstr());

        developMain dev_Main;
        public string dev_seq { get; set; }
        string dev_listCat;
        string cat1;
        string cat2;
        string cat3;
        string cat4;
        string manager;
        int count = 0;
        bool exit;
        bool access;
        public develop_Project_update(developMain devMain)
        {
            dev_Main = devMain;
            InitializeComponent();
        }

        private void call_dev_pro(string num)
        {
            //------------------------------------------------------------------------------------------------------
            SqlDataAdapter adapter = new SqlDataAdapter();

            string sqlQuary = "SELECT * FROM [DevelopList.devClass] WHERE dev_class = @dev";

            adapter.SelectCommand = new SqlCommand(sqlQuary, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@dev", dev_class.Text);

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable table = ds.Tables[0];

            dev_type.DataSource = table;
            dev_type.DisplayMember = "dev_type";
            dev_type.ValueMember = "dev_type";

            adapter = new SqlDataAdapter();

            sqlQuary = "SELECT * FROM [DevelopList.devCat] WHERE dev_type = @devType AND dev_class = @devClass";

            adapter.SelectCommand = new SqlCommand(sqlQuary, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@devType", dev_type.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@devClass", dev_class.Text);

            ds = new DataSet();
            adapter.Fill(ds);
            table = ds.Tables[0];

            dev_status.DataSource = table;
            dev_status.DisplayMember = "dev_status";
            dev_status.ValueMember = "dev_status";

            //------------------------------------------------------------------------------------------------------

            adapter = new SqlDataAdapter();
            // 카테고리 1 수정
            sqlQuary = "SELECT * FROM [DevelopList.devCat.Style] WHERE dev_cat1 = @dev";

            adapter.SelectCommand = new SqlCommand(sqlQuary, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@dev", dev_cat1.Text);
            ds = new DataSet();
            adapter.Fill(ds);
            table = ds.Tables[0];
            table = table.DefaultView.ToTable(true, new string[] {"dev_cat2" });
            dev_cat2.DataSource = table;
            dev_cat2.DisplayMember = "dev_cat2";
            dev_cat2.ValueMember = "dev_cat2";
            adapter = new SqlDataAdapter();

            sqlQuary = "SELECT * FROM [DevelopList.devCat.Style] WHERE dev_cat1 = @dev1 " +
                                                                         "AND dev_cat2 = @dev2 ";

            adapter.SelectCommand = new SqlCommand(sqlQuary, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@dev1", dev_cat1.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@dev2", dev_cat2.Text);
            ds = new DataSet();
            adapter.Fill(ds);
            table = ds.Tables[0];
            table = table.DefaultView.ToTable(true, new string[] {"dev_cat3" });
            dev_cat3.DataSource = table;
            dev_cat3.DisplayMember = "dev_cat3";
            dev_cat3.ValueMember = "dev_cat3";

            adapter = new SqlDataAdapter();

            sqlQuary = "SELECT * FROM [DevelopList.devCat.Style] WHERE dev_cat1 = @dev1 " +
                                                                         "AND dev_cat2 = @dev2 " +
                                                                         "AND dev_cat3 = @dev3 ";

            adapter.SelectCommand = new SqlCommand(sqlQuary, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@dev1", dev_cat1.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@dev2", dev_cat2.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@dev3", dev_cat3.Text);
            ds = new DataSet();
            adapter.Fill(ds);
            table = ds.Tables[0];
            table = table.DefaultView.ToTable(true, new string[] {"dev_cat4"});

            dev_cat4.DataSource = table;
            dev_cat4.DisplayMember = "dev_cat4";
            dev_cat4.ValueMember = "dev_cat4";
            //------------------------------------------------------------------------------------------------------
            conn.Open();

            string sql = "SELECT * FROM DevelopList WHERE seq = @seq";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@seq", num);

            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();
            
            dev_name.Text = (string)reader["dev_name"];
            detail.Text = (string)reader["detail"];
            dev_module.Text = (string)reader["dev_module"];
            document_num.Text = (string)reader["document_num"];
            reg_id.Text = (string)reader["reg_id"];
            req_date.Value = (DateTime)reader["req_date"];
            assign_date.Value = (DateTime)reader["assign_date"];
            start_date.Value = (DateTime)reader["start_date"];
            ex_complete_date.Value = (DateTime)reader["ex_complete_date"];
            complete_date.Value = (DateTime)reader["complete_date"];
            fulfillment_date.Value = (DateTime)reader["fulfillment_date"];
            dev_class.Text = (string)reader["dev_class"];
            dev_type.Text = (string)reader["dev_type"];
            dev_status.Text = (string)reader["status"];
            dev_listCat = (string)reader["category"];
            manager = (string)reader["manage_people"];
            reader.Close();
            
            //------------------------------------------------------------------------------------------------------
            

            sql = "SELECT * FROM [DevelopList.devCat.Style] WHERE dev_listcat = @devlistcat AND " +
                                                                 "dev_add = 1";

            cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@devlistcat", dev_listCat);
            
            reader = cmd.ExecuteReader();
            reader.Read();
            cat1 = (string)reader["dev_cat1"];

            cat2 = (string)reader["dev_cat2"];

            cat3 = (string)reader["dev_cat3"];

            cat4 = (string)reader["dev_cat4"];

            Console.WriteLine((string)reader["dev_cat1"] +" "+ (string)reader["dev_cat2"] + " " + (string)reader["dev_cat3"] + " " + (string)reader["dev_cat4"]);
            reader.Close();
            conn.Close();

            access = true;
            //------------------------------------------------------------------------------------------------------
        }
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
        private void call_devCat2StyleList(string devcat1)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            string sqlQuary = "SELECT * FROM [DevelopList.devCat.Style] WHERE dev_cat1 = @dev";

            adapter.SelectCommand = new SqlCommand(sqlQuary, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@dev", devcat1);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable table = ds.Tables[0];
            table = table.DefaultView.ToTable(true, new string[] {"dev_cat2" });
            dev_cat2.DataSource = table;
            dev_cat2.DisplayMember = "dev_cat2";
        }
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
            table = table.DefaultView.ToTable(true, new string[] {"dev_cat3" });
            dev_cat3.DataSource = table;
            dev_cat3.DisplayMember = "dev_cat3";
        }
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
            table = table.DefaultView.ToTable(true, new string[] {"dev_cat4" });

            dev_cat4.DataSource = table;
            dev_cat4.DisplayMember = "dev_cat4";
        }

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
                }
                else if (count == 1 && dataGridView1.Rows.Count == 1)
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

        private void develop_Project_update_Load(object sender, EventArgs e)
        {
            
            dev_class.SelectedIndex = 0;
            dev_cat1.SelectedIndex = 0;

            call_Manager();
            call_dev_pro(dev_seq);

            dev_cat1.Text = cat1;
            dev_cat2.Text = cat2;
            dev_cat3.Text = cat3;
            dev_cat4.Text = cat4;

            call_devCat();
            add_Click(sender, e);

            Manager_check.SetItemChecked(Manager_check.FindStringExact(manager), true);
            
        }
        
        private void insert_exit_Click(object sender, EventArgs e)
        {
            exit = true;
            this.Close();
        }

        private void develop_Project_update_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void dev_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(access)
            {
                call_devClassList(dev_class.Text);
            }
            
        }

        private void dev_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (access)
            {
                call_devTypeList(dev_class.Text, dev_type.Text);
            }
        }

        private void dev_cat1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (access)
            {
                call_devCat2StyleList(dev_cat1.Text);
            }
        }

        private void dev_cat2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (access)
            {
                call_devCat3StyleList(dev_cat1.Text, dev_cat2.Text);
            }
        }

        private void dev_cat3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (access)
            {
                call_devCat4StyleList(dev_cat1.Text, dev_cat2.Text, dev_cat3.Text);
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            call_devCat();
        }

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

        private void update_Click(object sender, EventArgs e)
        {

        }
    }
}
