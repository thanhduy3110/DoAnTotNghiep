using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace DAO
{
    public class DAOPhieuDatPhong
    {
        dbConnectionData db = new dbConnectionData();
        DataSet dsID_KH = new DataSet();
        DataSet dsPDP = new DataSet();
        string[] name = { };
        object[] value = { };
        public void HienThiID_KH(ComboBox cboID_KH)
        {
            dsID_KH = db.LayDanhSach("select ID from KhachHang");// truy vấn lên sql
            cboID_KH.DataSource = dsID_KH.Tables[0];
            cboID_KH.DisplayMember = "id";
            cboID_KH.ValueMember = "id";
        }
        public void HienThiDanhSach(string sTimKiem, DataGridView d)
        {
            dsPDP = db.LayDanhSach("select * from PhieuDatPhong where ID_KH like '%" + sTimKiem + "%'");
            d.DataSource = dsPDP.Tables[0];
        }
        public DataTable phieudatphong_select()
        {
            return db.Laydulieu("phieudatphong_select");
        }

        public int phieudatphong_them(string ID, string ID_KH, string NgayDen, string NgayDi, string HinhThucThue, string SoKhach, string GhiChu, string DaXuLy, string HieuLuc)
        {
            name = new string[9];
            value = new object[9];

            name[0] = "@ID"; value[0] = ID;
            name[1] = "@ID_KH"; value[1] = ID_KH;
            name[2] = "@NgayDen"; value[2] = NgayDen;
            name[3] = "@NgayDi"; value[3] = NgayDi;
            name[4] = "@HinhThucThue"; value[4] = HinhThucThue;
            name[5] = "@SoKhach"; value[5] = SoKhach;
            name[6] = "@GhiChu"; value[6] = GhiChu;
            name[7] = "@DaXuLy"; value[7] = DaXuLy;
            name[8] = "@HieuLuc"; value[8] = HieuLuc;


            return db.ThucHien("phieudatphong_them", name, value, 9);
        }
        public int phieudatphong_capnhat(string ID, string ID_KH, string NgayDen, string NgayDi, string HinhThucThue, string SoKhach, string GhiChu, string DaXuLy, string HieuLuc)
        {
            name = new string[9];
            value = new object[9];

            name[0] = "@ID"; value[0] = ID;
            name[1] = "@ID_KH"; value[1] = ID_KH;
            name[2] = "@NgayDen"; value[2] = NgayDen;
            name[3] = "@NgayDi"; value[3] = NgayDi;
            name[4] = "@HinhThucThue"; value[4] = HinhThucThue;
            name[5] = "@SoKhach"; value[5] = SoKhach;
            name[6] = "@GhiChu"; value[6] = GhiChu;
            name[7] = "@DaXuLy"; value[7] = DaXuLy;
            name[8] = "@HieuLuc"; value[8] = HieuLuc;


            return db.ThucHien("phieudatphong_capnhat", name, value, 9);
        }


    }
}
