using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Login
{
    public partial class alarm : Form
    {
        public Button alarm_check { get; set; }
        public string username { get; set; }
        public alarm()
        {
            InitializeComponent();
        }

        private void alarm_Load(object sender, EventArgs e)
        {
        }
        public void reset()
        {
            this.Close();
            Console.WriteLine("리셋");
        }
        private void alarm_FormClosed(object sender, FormClosedEventArgs e)
        {
            alarm_check.Enabled = true;
        }
    }
}
