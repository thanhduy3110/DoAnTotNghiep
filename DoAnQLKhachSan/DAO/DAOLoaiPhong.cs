using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DAOLoaiPhong
    {
        dbConnectionData dtks = new dbConnectionData();
        DataSet dsLoaiP = new DataSet();

        public void HienThiDanhSach(string sTimKiem, DataGridView d)
        {
            dsLoaiP = dtks.LayDanhSach("select * from LoaiPhong where TenLoaiPhong like N'%" + sTimKiem + "%'");
            d.DataSource = dsLoaiP.Tables[0];
        }
        //khai báo 2 mảng để truyền tên tham số và giá trị tham số vào stored procedures
        string[] name = { };
        object[] value = { };

        //phương thức này gọi đến phương thức LayduLieu ở dbConnectionData để lấy dữ liệu
        public DataTable loaiphong_select()
        {
            return dtks.Laydulieu("loaiphong_select");
        }


        //phương thức này gọi đến phương thức ThucHien ở dbConnectionData để thêm dữ liệu
        public int loaiphong_them(string ID, string TenLoaiPhong, string SoGiuongDoi, string SoGiuongDon, string SoKhach, bool HieuLuc)
        {
            name = new string[6];
            value = new object[6];
            name[0] = "@id"; value[0] = ID;
            name[1] = "@TenLoaiPhong"; value[1] = TenLoaiPhong;
            name[2] = "@SoGiuongDoi"; value[2] = SoGiuongDoi;
            name[3] = "@SoGiuongDon"; value[3] = SoGiuongDon;
            name[4] = "@SoKhach"; value[4] = SoKhach;
            name[5] = "@HieuLuc"; value[5] = HieuLuc;
            return dtks.ThucHien("loaiphong_them", name, value, 6);
        }

        //update
        public int loaiphong_capnhat(string id, string TenLoaiPhong, string SoGiuongDoi, string SoGiuongDon, string SoKhach, bool HieuLuc)
        {
            name = new string[6];
            value = new object[6];
            name[0] = "@id"; value[0] = id;
            name[1] = "@TenLoaiPhong"; value[1] = TenLoaiPhong;
            name[2] = "@SoGiuongDoi"; value[2] = SoGiuongDoi;
            name[3] = "@SoGiuongDon"; value[3] = SoGiuongDon;
            name[4] = "@SoKhach"; value[4] = SoKhach;
            name[5] = "@HieuLuc"; value[5] = HieuLuc;

            return dtks.ThucHien("loaiphong_capnhat", name, value, 6);
        }
        //delete
        public int loaiphong_xoa(string ID)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@ID"; value[0] = ID;
            return dtks.ThucHien("loaiphong_xoa", name, value, 1);
        }
        public DataTable id_max_select()
        {
            return dtks.Laydulieu("id_max_select");
        }

    }
}
