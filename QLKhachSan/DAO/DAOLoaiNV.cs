using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAOLoaiNV
    {
        //public static DataTable getData()
        //{
        //    //SqlConnection Conn = dataKhachSan.();
        //    SqlCommand cmd = new SqlCommand("ds_LoaiNV",Conn);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    Conn.Open();
        //    SqlDataAdapter da = new SqlDataAdapter();
        //    da.SelectCommand = cmd;
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    Conn.Close();
        //    return dt;
        //}

        //public static void InsertLoaiNV(DTOLoaiNV LoaiNV)
        //{
        //    //SqlConnection Conn = dataKhachSan.();
        //    SqlCommand cmd = new SqlCommand("lnv_InsertLoaiNV", Conn);
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    cmd.Parameters.Add("@ID", SqlDbType.Int);
        //    cmd.Parameters.Add("@TenLoaiNV", SqlDbType.NVarChar, 100);
        //    cmd.Parameters.Add("@HieuLuc", SqlDbType.Bit);
        //    cmd.Parameters["@ID"].Value = LoaiNV.ID1;
        //    cmd.Parameters["@TenLoaiNV"].Value = LoaiNV.TenLoaiNV1;
        //    cmd.Parameters["@HieuLuc"].Value = LoaiNV.HieuLuc1;

        //    Conn.Open();
        //    cmd.ExecuteScalar();
        //    Conn.Close();
            
        //}

        //public static void UpdateLoaiNV(DTOLoaiNV LoaiNV)
        //{
        //    SqlConnection Conn = dbConnectionData.KetNoi();
        //    SqlCommand cmd = new SqlCommand("lnv_UpdateLoaiNV", Conn);
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    cmd.Parameters.Add("@ID", SqlDbType.Int);
        //    cmd.Parameters.Add("@TenLoaiNV", SqlDbType.NVarChar, 100);
        //    cmd.Parameters.Add("@HieuLuc", SqlDbType.Bit);
        //    cmd.Parameters["@ID"].Value = LoaiNV.ID1;
        //    cmd.Parameters["@TenLoaiNV"].Value = LoaiNV.TenLoaiNV1;
        //    cmd.Parameters["@HieuLuc"].Value = LoaiNV.HieuLuc1;
        //    Conn.Open();
        //    cmd.ExecuteScalar();
        //    Conn.Close();
        //}
    }
}
