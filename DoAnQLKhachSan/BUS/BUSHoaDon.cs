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

        //public void HienThiTenKH(ComboBox cboTenKH)
        //{
        //    HD.HienThiTenKH(cboTenKH);
        //}

        public void HienThiSDT(ComboBox cboSDT)
        {
            HD.HienThiSDT(cboSDT);
        }

        public void HienThiTenKH(ComboBox cboSDT, TextBox txtTenKH)
        {
            HD.HienThiTenKH(cboSDT,txtTenKH);
        }


        public void HienThiMaPhong(ComboBox cboMaPhong)
        {
            HD.HienThiMaPhong(cboMaPhong);
        }
        public void HienThiTienPhong(ComboBox cboMaPhong, ComboBox cboHTT, Label lblTTPhong,int i)
        {
            HD.HienThiTienPhong(cboMaPhong, cboHTT, lblTTPhong,i);
        }

        public DataTable TienPhong(int SoPhong)
        {
            return HD.TienPhong(SoPhong);
        }

        public void HienThiDanhSach(string sTimKiem, DataGridView d)
        {
            HD.HienThiDanhSach(sTimKiem, d);
        }

         public DataTable HoaDon_PhatSinhMa()
        {
            return HD.HoaDon_PhatSinhMa();
        }
        public DataTable HoaDon_Select()
        {
            return HD.HoaDon_Select();
        }


        public int HoaDon_Them(int ID, string MaHD, string ID_NV, string ID_KH, string ID_Phong, string NgayLap, string NgayDen, string NgayDi, int HinhThucThue, int TTPhong, string TTDV, int TT, string GhiChu, bool TToan, bool HieuLuc)
        {
            return HD.HoaDon_Them(ID, MaHD, ID_NV, ID_KH, ID_Phong, NgayLap, NgayDen, NgayDi, HinhThucThue, TTPhong, TTDV, TT, GhiChu, TToan, HieuLuc);
        }

        public int HoaDon_XacNhanDatPhong(int ID, string MaHD, string ID_NV, string ID_KH, string ID_Phong, string NgayLap, string NgayDen, string NgayDi, int HinhThucThue, int TTPhong, int TT,bool ThanhToan, bool HieuLuc)
        {
            return HD.HoaDon_XacNhanDatPhong(ID, MaHD, ID_NV, ID_KH, ID_Phong, NgayLap, NgayDen, NgayDi, HinhThucThue, TTPhong, TT, ThanhToan, HieuLuc);
        }
            public int HoaDon_CapNhat(int ID, string MaHD, string ID_NV, string ID_KH, string ID_Phong, string NgayLap, string NgayDen, string NgayDi, int HinhThucThue, string TTPhong, string TTDV, string TT, string GhiChu, bool TToan, bool HieuLuc)
        {
            return HD.HoaDon_CapNhat(ID, MaHD, ID_NV, ID_KH, ID_Phong, NgayLap, NgayDen, NgayDi, HinhThucThue, TTPhong, TTDV, TT, GhiChu, TToan, HieuLuc);
        }

        public int HoaDon_CapNhatChuyenPhong(int ID,int sophong,int TTP,int TongTien)
        {
            return HD.HoaDon_CapNhatChuyenPhong(ID, sophong,TTP,TongTien);
        }

        public int HoaDon_Xoa(int ID, bool HieuLuc)
        {
            return HD.HoaDon_Xoa(ID, HieuLuc);
        }

        public int HoaDon_ThanhToan(int ID, bool ThanhToan)
        {
            return HD.HoaDon_ThanhToan(ID, ThanhToan);
        }
    }
}

