using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DAODichVu
    {
        DataSet dsLoaiDV = new DataSet();
        DataSet dsHinhAnh = new DataSet();
        DataSet dsDichVu = new DataSet();
        dbConnectionData db = new dbConnectionData();

        string[] name = { };
        object[] value = { };

        public void HienThiLoaiDV(ComboBox cboTenLoaiDV)
        {
            dsLoaiDV = db.LayDanhSach("select ID, TenLoaiDV from LoaiDV");// truy vấn lên sql
            cboTenLoaiDV.DataSource = dsLoaiDV.Tables[0];
            cboTenLoaiDV.DisplayMember = "tenloaidv";
            cboTenLoaiDV.ValueMember = "id";
        }
        public void HienThiDanhSach(string sTimKiem, DataGridView d)
        {
            dsDichVu = db.LayDanhSach("select * from DichVu where TenDV like '%" + sTimKiem + "%'");
            d.DataSource = dsDichVu.Tables[0];
        }
        public void HienThiAnh(PictureBox pic)
        {
            dsHinhAnh = db.LayDanhSach("select HinhAnh from DichVu");
        }
        public DataTable dichvu_select()
        {
            return db.Laydulieu("dichvu_select");
        }

        public int dichvu_them(string ID, string ID_LoaiDV, string TenDV, string MoTa, string HinhAnh, string GiaTien, string SLTon, string DVT, string GhiChu, string HieuLuc)
        {
            name = new string[10];
            value = new object[10];

            name[0] = "@ID"; value[0] = ID;
            name[1] = "@ID_LoaiDV"; value[1] = ID_LoaiDV;
            name[2] = "@TenDV"; value[2] = TenDV;
            name[3] = "@MoTa"; value[3] = MoTa;
            name[4] = "@HinhAnh"; value[4] = HinhAnh;
            name[5] = "@GiaTien"; value[5] = GiaTien;
            name[6] = "@SLTon"; value[6] = SLTon;
            name[7] = "@DVT"; value[7] = DVT;
            name[8] = "@GhiChu"; value[8] = GhiChu;
            name[9] = "@HieuLuc"; value[9] = HieuLuc;

            return db.ThucHien("dichvu_them", name, value, 10);
        }

        public int dichvu_capnhat(string ID, string ID_LoaiDV, string TenDV, string MoTa, string HinhAnh, string GiaTien, string SLTon, string DVT, string GhiChu, string HieuLuc)
        {
            name = new string[10];
            value = new object[10];

            name[0] = "@ID"; value[0] = ID;
            name[1] = "@ID_LoaiDV"; value[1] = ID_LoaiDV;
            name[2] = "@TenDV"; value[2] = TenDV;
            name[3] = "@MoTa"; value[3] = MoTa;
            name[4] = "@HinhAnh"; value[4] = HinhAnh;
            name[5] = "@GiaTien"; value[5] = GiaTien;
            name[6] = "@SLTon"; value[6] = SLTon;
            name[7] = "@DVT"; value[7] = DVT;
            name[8] = "@GhiChu"; value[8] = GhiChu;
            name[9] = "@HieuLuc"; value[9] = HieuLuc;

            return db.ThucHien("dichvu_capnhat", name, value, 10);
        }

        public int dichvu_xoa(string ID)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@ID"; value[0] = ID;
            return db.ThucHien("dichvu_xoa", name, value, 1);
        }
    }
}
