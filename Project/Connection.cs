using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Project
{
    internal class Connection
    {
        public static MySqlConnection connect = new MySqlConnection("server=127.0.0.1; port=3306; username=root; password=; database=tourfirm;");
        public static MySqlDataAdapter adap = new MySqlDataAdapter();
        public static MySqlDataReader reader;
        public static string UserLogin = "";
        public static string FIOUser = "";
        public static bool admin = false;
    }
}

