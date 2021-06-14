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

        dbConnectionData db = new dbConnectionData();

        //khai báo 2 mảng để truyền tên tham số và giá trị tham số vào stored procedures
        string[] name = { };
        object[] value = { };

        //phương thức này gọi đến phương thức LayduLieu ở dbConnectionData để lấy dữ liệu
        public DataTable LoaiNV_Select()
        {
            return db.Laydulieu("LoaiNV_Select");
        }

        //phương thức này gọi đến phương thức ThucHien ở dbConnectionData để thêm dữ liệu
        public int LoaiNV_Them(int ID, string TenLoaiNV  , int HieuLuc)
        {
            name = new string[3];
            value = new object[3];
            name[0] = "@id"; value[0] = ID;
            name[1] = "@TenLoaiNV"; value[1] = TenLoaiNV;
            name[2] = "@HieuLuc"; value[2] = HieuLuc;
            return db.ThucHien("LoaiNV_Them", name, value, 3);
        }

        //update
        public int LoaiNV_CapNhat(int ID, string TenLoaiNV, int HieuLuc)
        {
            name = new string[3];
            value = new object[3];
            name[0] = "@id"; value[0] = ID;
            name[1] = "@TenLoaiNV"; value[1] = TenLoaiNV;
            name[2] = "@HieuLuc"; value[2] = HieuLuc;
            return db.ThucHien("LoaiNV_CapNhat", name, value, 3);
        }

        //delete
        public int LoaiNV_Xoa(int ID, int HieuLuc)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@ID"; value[0] = ID;
            name[1] = "@HieuLuc"; value[1] = HieuLuc;
            return db.ThucHien("LoaiNV_Xoa", name, value, 2);
        }
    }
}
