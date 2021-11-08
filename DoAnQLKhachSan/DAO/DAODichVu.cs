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
            dsLoaiDV = db.LayDanhSach("select ID, TenLoaiDV from LoaiDV where HieuLuc=1");// truy vấn lên sql
            cboTenLoaiDV.DataSource = dsLoaiDV.Tables[0];
            cboTenLoaiDV.DisplayMember = "TenLoaiDV";
            cboTenLoaiDV.ValueMember = "ID";
        }
        public void HienThiDanhSach(string sTimKiem, DataGridView d)
        {
            dsDichVu = db.LayDanhSach("select DichVu.ID,TenLoaiDV,TenDV,MoTa,HinhAnh,GiaTien,SLTon,DVT,GhiChu,dbo.DV_HieuLuc(DichVu.HieuLuc) as HieuLuc from DichVu,LoaiDV where DichVu.ID_LoaiDV=LoaiDV.ID and DichVu.HieuLuc=1 and TenLoaiDV like '%" + sTimKiem + "%' or TenDV like '%" + sTimKiem + "%'");
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

        public int dichvu_them(int ID, int ID_LoaiDV, string TenDV, string MoTa, string HinhAnh, string GiaTien, string SLTon, string DVT, string GhiChu, bool HieuLuc)
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

        public int dichvu_capnhat(int ID, int ID_LoaiDV, string TenDV, string MoTa, string HinhAnh, string GiaTien, string SLTon, string DVT, string GhiChu, bool HieuLuc)
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

        public int dichvu_capnhatSLTon(string ID,int SL)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@ID"; value[0] = ID;
            name[1] = "@SLTon"; value[1] = SL;
            return db.ThucHien("dichvu_capnhatSLTon", name, value, 2);
        }

        public DataTable DV_Select(int ID)//rồi, đã xem xong 1 loạt thủ tục ở dal
                                                                     //đây là thủ tục sẽ dùng ở form đăng nhập, với điều kiện là trùng mã tài khoản và mật khẩu. ok?
        {
            name = new string[1];
            value = new object[1];

            name[0] = "@ID"; value[0] = ID;

            return db.LayDuLieuCoDK("DV_Select", name, value, 1);
        }
    }
}
