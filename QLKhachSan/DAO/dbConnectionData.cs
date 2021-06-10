using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DAO
{
    public class dataKhachSan
    {
        SqlConnection cn;
        public void ketnoiCSDL()
        {
            cn = new SqlConnection(@"Data Source=DESKTOP-DDKM1BA\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True");
            cn.Open();
        }
        private void NgatKetNoi()
        {
            cn.Close();
            cn.Dispose();
        }

        //select dữ liệu
        public DataTable Laydulieu(string ID)
        {
            ketnoiCSDL();

            //thực thi lấy dữ liệu
            SqlCommand cmd = new SqlCommand(ID, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);


            //ngắt kết nối
            NgatKetNoi();

            //dữ liệu lấy được
            return dt;
        }

        //thêm, sửa, xóa
        public int ThucHien(string data, string[] name, object[] value, int n)
        {
            ketnoiCSDL();
            SqlCommand cmd = new SqlCommand(data, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < n; i++)
            {
                cmd.Parameters.AddWithValue(name[i], value[i]);
            }
            return cmd.ExecuteNonQuery();
        }

        public DataTable LayCSDL(string data, string[] name, object[] value, int n)
        {
            ketnoiCSDL();
            SqlCommand cmd = new SqlCommand(data, cn);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < n; i++)
            {
                cmd.Parameters.AddWithValue(name[i], value[i]);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

    }
}
