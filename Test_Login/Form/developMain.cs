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
    public partial class developMain : Form
    {
        static DBConnection DB = new DBConnection();
        SqlConnection conn = new SqlConnection(DB.DBstr());

        main mainForm;
        public string userId { get; set; }
        string dev_listCat;
        bool exit;
        public developMain(main main)
        {
            mainForm = main;
            InitializeComponent();
        }

        private void developMain_Load(object sender, EventArgs e)
        {
            call_searchDate();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today; 
            dev_class.SelectedIndex = 0;
            dev_cat1.SelectedIndex = 0;
            call_developList();
            call_manager();
        }
        private void call_searchDate()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            string sqlQuary = "SELECT * FROM [DevelopList.search]";

            adapter.SelectCommand = new SqlCommand(sqlQuary, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable table = ds.Tables[0];

            searchDate.DataSource = table;
            searchDate.DisplayMember = "date";
            searchDate.ValueMember = "quary";
        }
        private string selectDate(string date)
        {
            conn.Open();

            string sql = "SELECT quary FROM [DevelopList.search] WHERE date = @date";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@date", date);

            SqlDataReader reader = cmd.ExecuteReader();
            
            reader.Read();

            date = (string)reader["quary"];

            reader.Close();
            conn.Close();
            
            return date;
        }

        private void searchDevList(string search)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            string sqlQuary = "SELECT seq," +
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
                                     "reg_id FROM DevelopList WHERE " + search + " >= @minSearchDate AND " +
                                                                        search + " <= @maxSearchDate AND " +
                                                                        "manage_people = @manage_people ";

            if(dev_class.Text != "전체")
            {
                sqlQuary += "AND dev_class = @dev_class ";
            }
            if(dev_type.Text != "전체")
            {
                sqlQuary += "AND dev_type = @dev_type ";
            }
            if (dev_status.Text != "전체")
            {
                sqlQuary += "AND status = @dev_status ";
            }
            if (dev_listCat != "")
            {
                sqlQuary += "AND category = @category ";
            }
            if(document_num.Text != "")
            {
                sqlQuary += "AND document_num LIKE @document_num ";
                
            }
            if(dev_name.Text != "")
            {
                sqlQuary += "AND dev_name LIKE @dev_name ";
            }

            string docu = "%" + document_num.Text + "%";
            string devName = "%" + dev_name.Text + "%";

            adapter.SelectCommand = new SqlCommand(sqlQuary, conn);

            adapter.SelectCommand.Parameters.AddWithValue("@minSearchDate", dateTimePicker1.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@maxSearchDate", dateTimePicker2.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@manage_people", manager.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@dev_Class", dev_class.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@dev_type", dev_type.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@dev_status", dev_status.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@category", dev_listCat);
            adapter.SelectCommand.Parameters.AddWithValue("@document_num", docu);
            adapter.SelectCommand.Parameters.AddWithValue("@dev_name", devName);

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable table = ds.Tables[0];

            DataGridView.DataSource = table;
        }

        public void call_developList()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            string sqlQuary = "SELECT seq," +
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
                                     "reg_id FROM DevelopList";

            adapter.SelectCommand = new SqlCommand(sqlQuary, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable table = ds.Tables[0];

            DataGridView.DataSource = table;

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
        private void call_devCatList(string devClass ,string devType)
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

        private void call_manager()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            string sqlQuary = "SELECT user_name FROM Members";

            adapter.SelectCommand = new SqlCommand(sqlQuary, conn);

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable table = ds.Tables[0];

            manager.DataSource = table;
            manager.DisplayMember = "user_name";
            manager.ValueMember = "user_name";
        }
       
        private void del_devList(string seq)
        {
            conn.Open();

            string sql = "DELETE FROM DevelopList WHERE seq = @seq";

            SqlCommand cmd = new SqlCommand(sql, conn);
           
            cmd.Parameters.AddWithValue("@seq", seq);

            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            conn.Close();

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
            table = table.DefaultView.ToTable(true, new string[] { "dev_cat1", "dev_cat2" });
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
            table = table.DefaultView.ToTable(true, new string[] { "dev_cat1", "dev_cat2", "dev_cat3" });
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
            table = table.DefaultView.ToTable(true, new string[] { "dev_cat1", "dev_cat2", "dev_cat3", "dev_cat4" });

            dev_cat4.DataSource = table;
            dev_cat4.DisplayMember = "dev_cat4";
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

            cmd.Parameters.AddWithValue("@dev1", dev_cat1.Text);
            cmd.Parameters.AddWithValue("@dev2", dev_cat2.Text);
            cmd.Parameters.AddWithValue("@dev3", dev_cat3.Text);
            cmd.Parameters.AddWithValue("@dev4", dev_cat4.Text);

            SqlDataReader reader = cmd.ExecuteReader();


            if (reader.Read())
            {
                dev_listCat = (string)reader["dev_listCat"];
            }
            else
            {
                dev_listCat = "";
            }
            Console.WriteLine("카테고리" + dev_listCat);
            reader.Close();
            conn.Close();


        }
        private void developMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (exit)
            {
                return;
            }

            Application.Exit();
        }

        private void dev_class_IndexChanged(object sender, EventArgs e)
        {
            dev_type.Text = "";
            call_devClassList(dev_class.Text);
        }

        private void dev_type_IndexChanged(object sender, EventArgs e)
        {
            dev_status.Text = "";
            call_devCatList(dev_class.Text, dev_type.Text);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            exit = true;
            this.Close();
            mainForm.Visible = true;
        }

        private void dev_insert_click(object sender, EventArgs e)
        {
            develop_Project_Insert devIns = new develop_Project_Insert(this);
            devIns.userId = userId;
            devIns.ShowDialog();
        }
         
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewButtonCell cell = DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                if (cell == null)
                {
                    return;
                }
            
                if (cell.Value.Equals("수정"))
                {
                    develop_Project_update dev_update = new develop_Project_update(this);
                    dev_update.dev_seq = DataGridView.SelectedRows[0].Cells[3].Value.ToString();
                    dev_update.ShowDialog();

                }
                else if (cell.Value.Equals("복사"))
                {
                    MessageBox.Show("복사");  
                }
                else if (cell.Value.Equals("삭제"))
                {
                    string seq = DataGridView.SelectedRows[0].Cells[3].Value.ToString();
                    Console.WriteLine(seq);
                    del_devList(seq);
                    call_developList();
                }
            }
        }
        
        private void searchDev_Click(object sender, EventArgs e)
        {
            string date = searchDate.Text;
            call_devlistCat();
            searchDevList(selectDate(date));
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimePicker1.Value > dateTimePicker2.Value)
            {
                
                dateTimePicker1.Value = dateTimePicker2.Value;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                dateTimePicker2.Value = dateTimePicker1.Value;
            }
        }

        private void oneDay_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker2.Value.AddDays(-1);
        }

        private void oneWeek_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker2.Value.AddDays(-7);
        }

        private void oneMonth_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker2.Value.AddMonths(-1);
        }

        private void threeMonths_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker2.Value.AddMonths(-3);
        }

        private void sixMonths_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker2.Value.AddMonths(-6);
        }

        private void oneYear_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker2.Value.AddYears(-1);
        }

        private void dev_cat1_SelectedIndexChanged(object sender, EventArgs e)
        {
            call_devCat2StyleList(dev_cat1.Text);
        }

        private void dev_cat2_SelectedIndexChanged(object sender, EventArgs e)
        {
            call_devCat3StyleList(dev_cat1.Text, dev_cat2.Text);
        }

        private void dev_cat3_SelectedIndexChanged(object sender, EventArgs e)
        {
            call_devCat4StyleList(dev_cat1.Text, dev_cat2.Text, dev_cat3.Text);
        }

        private void dev_cat4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
