using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class dbConnectionData
    {
        SqlConnection con = new SqlConnection();
        public static SqlConnection KetNoi()
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-MGN3IP8\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True");
            return Conn;


        }
    }
}
