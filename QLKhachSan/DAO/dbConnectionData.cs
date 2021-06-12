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
    public class dbConnectionData
    {
        SqlConnection con;
        public void ketnoiCSDL()
        {
            con= new SqlConnection(@"data source =DESKTOP-DDKM1BA\SQLEXPRESS; initial catalog=QLKhachSan; integrated security=true");
           
                con.Open();
        }
        private void NgatKetNoi()
        {
            con.Close();
            con.Dispose();
        }

        //public dbConnectionData()
        //{
        //    ketnoiCSDL();
        //}

        //select dữ liệu
        public DataTable Laydulieu(string ID)
        {
            ketnoiCSDL();

            //thực thi lấy dữ liệu
            SqlCommand cmd = new SqlCommand(ID, con);
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
            SqlCommand cmd = new SqlCommand(data, con);
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
            SqlCommand cmd = new SqlCommand(data, con);
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

        public DataSet LayDanhSach(string sql)
        {
            ketnoiCSDL();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(ds);
            NgatKetNoi();
            return ds;
        }

    }
}
