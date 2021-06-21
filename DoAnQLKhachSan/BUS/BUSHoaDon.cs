using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace BUS
{
    public class BUSHoaDon
    {
        DAOHoaDon HD = new DAOHoaDon();

        public void HienThiTenNV(ComboBox cboTenNV)
        {
            HD.HienThiTenNV(cboTenNV);
        }

        public void HienThiTenKH(ComboBox cboTenKH)
        {
            HD.HienThiTenKH(cboTenKH);
        }


        public void HienThiMaPhong(ComboBox cboMaPhong)
        {
            HD.HienThiMaPhong(cboMaPhong);
        }
        public void HienThiTienPhong(ComboBox cboMaPhong, ComboBox cboHTT, Label lblTTPhong,int i)
        {
            HD.HienThiTienPhong(cboMaPhong, cboHTT, lblTTPhong,i);
        }


            public DataTable HoaDon_Select()
        {
            return HD.HoaDon_Select();
        }

        public int HoaDon_Them(string ID, string MaHD, string ID_NV, string ID_KH, string ID_Phong, string NgayLap, string NgayDen, string NgayDi, int HinhThucThue, string TTPhong, string TTDV, string TT, string GhiChu, int TToan, int HieuLuc)
        {
            return HD.HoaDon_Them(ID, MaHD, ID_NV, ID_KH, ID_Phong, NgayLap, NgayDen, NgayDi, HinhThucThue, TTPhong, TTDV, TT, GhiChu, TToan, HieuLuc);
        }

        public int HoaDon_CapNhat(string ID, string MaHD, string ID_NV, string ID_KH, string ID_Phong, string NgayLap, string NgayDen, string NgayDi, int HinhThucThue, string TTPhong, string TTDV, string TT, string GhiChu, int TToan, int HieuLuc)
        {
            return HD.HoaDon_CapNhat(ID, MaHD, ID_NV, ID_KH, ID_Phong, NgayLap, NgayDen, NgayDi, HinhThucThue, TTPhong, TTDV, TT, GhiChu, TToan, HieuLuc);
        }
    }
}

