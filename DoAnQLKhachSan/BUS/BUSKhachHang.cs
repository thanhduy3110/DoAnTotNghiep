using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;
using System.Windows.Forms;

namespace BUS
{
    public class BUSKhachHang
    {
        DAOKhachHang kh = new DAOKhachHang();

        public void HienThiDanhSach(string sTimKiem, DataGridView d)
        {
            kh.HienThiDanhSach(sTimKiem, d);
        }
        public DataTable KH_Select()
        {
            return kh.khachhang_select();
        }

        public int KH_Them(string ID, string HoTen, string NgaySinh, string SDT, string Email, string CMND, bool GioiTinh, string QuocTich, bool HieuLuc)
        {
            return kh.khachhang_them(ID, HoTen, NgaySinh, SDT, Email, CMND, GioiTinh, QuocTich, HieuLuc);
        }

        public int KH_CapNhat(string ID, string HoTen, string NgaySinh, string SDT, string Email, string CMND, bool GioiTinh, string QuocTich, bool HieuLuc)
        {
            return kh.khachang_capnhat(ID, HoTen, NgaySinh, SDT, Email, CMND, GioiTinh, QuocTich, HieuLuc);
        }
    }
}
