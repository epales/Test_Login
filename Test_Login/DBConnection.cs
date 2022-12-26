using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Login
{
    class DBConnection
    {
        private static string uid = "dzicube";
        private static string password = "ejwhs123$";
        private static string database = "INSMANAGER";
        private static string server = "10.25.60.185,3433";

        string connStr = "SERVER=" + server + "; DATABASE=" + database + "; UID=" + uid + ";PASSWORD=" + password + ";";

        public string DBstr() {
            return connStr;
        }
    }
}
