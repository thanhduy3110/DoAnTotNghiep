using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DAOLoaiNV
    {
        dbConnectionData db = new dbConnectionData();
        DataSet dsLoaiNV = new DataSet();

        public void HienThiDanhSach(string sTimKiem, DataGridView d)
        {
            dsLoaiNV = db.LayDanhSach("select ID,TenLoaiNV,dbo.LNV_HieuLuc(HieuLuc)as HieuLuc from LoaiNV where HieuLuc=1 and TenLoaiNV like N'%" + sTimKiem + "%'");
            d.DataSource = dsLoaiNV.Tables[0];
        }
        //khai báo 2 mảng để truyền tên tham số và giá trị tham số vào stored procedures
        string[] name = { };
        object[] value = { };

        //phương thức này gọi đến phương thức LayduLieu ở dbConnectionData để lấy dữ liệu
        public DataTable LoaiNV_Select()
        {
            return db.Laydulieu("LoaiNV_Select");
        }

        //phương thức này gọi đến phương thức ThucHien ở dbConnectionData để thêm dữ liệu
        public int LoaiNV_Them(int ID, string TenLoaiNV, bool HieuLuc)
        {
            name = new string[3];
            value = new object[3];
            name[0] = "@id"; value[0] = ID;
            name[1] = "@TenLoaiNV"; value[1] = TenLoaiNV;
            name[2] = "@HieuLuc"; value[2] = HieuLuc;
            return db.ThucHien("LoaiNV_Them", name, value, 3);
        }

        //update
        public int LoaiNV_CapNhat(int ID, string TenLoaiNV, bool HieuLuc)
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
