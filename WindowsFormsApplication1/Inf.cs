using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Inf
    {
        public static string boss_id;
        public static string scout_id;
        public static string sql;
        public static string sftn = "";
        public static string[] id;
        public static int n;
        public static string s,c_a,c_p;
        public static string del_pid;
        public static SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=Football;Uid=sa;Pwd=sa");
    }
}
