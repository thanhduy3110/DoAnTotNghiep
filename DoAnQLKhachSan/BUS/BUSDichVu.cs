using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using System.Data;

namespace BUS
{
    public class BUSDichVu
    {
        DAODichVu ldv = new DAODichVu();

        public void HienTHiLoaiDichVu(ComboBox cboTenLoaiDV)
        {
            ldv.HienThiLoaiDV(cboTenLoaiDV);
        }

        public void HienThiDanhSach(string sTimKiem, DataGridView d)
        {
            ldv.HienThiDanhSach(sTimKiem, d);
        }
        public void PICTURE(PictureBox pic)
        {
            ldv.HienThiAnh(pic);
        }

        public DataTable DV_Select()
        {
            return ldv.dichvu_select();
        }
        public int DV_Them(int ID, int ID_LoaiDV, string TenDV, string MoTa, string HinhAnh, string GiaTien, string SLTon, string DVT, string GhiChu, bool HieuLuc)
        {
            return ldv.dichvu_them(ID, ID_LoaiDV, TenDV, MoTa, HinhAnh, GiaTien, SLTon, DVT, GhiChu, HieuLuc);
        }
        public int DV_CapNhat(int ID, int ID_LoaiDV, string TenDV, string MoTa, string HinhAnh, string GiaTien, string SLTon, string DVT, string GhiChu, bool HieuLuc)
        {
            return ldv.dichvu_capnhat(ID, ID_LoaiDV, TenDV, MoTa, HinhAnh, GiaTien, SLTon, DVT, GhiChu, HieuLuc);
        }
        public int DV_Xoa(string ID)
        {
            return ldv.dichvu_xoa(ID);
        }
    }
}
