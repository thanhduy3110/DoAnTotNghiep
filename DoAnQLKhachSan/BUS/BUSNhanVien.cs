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
    public class BUSNhanVien
    {
        DAONhanVien NV = new DAONhanVien();
        public void HienThiTenLoaiNV(ComboBox cboTenLoaiNV)
        {
            NV.HienThiTenLoaiNV(cboTenLoaiNV);
        }

        public void HienThiDanhSach(string sTimKiem, DataGridView d)
        {
            NV.HienThiDanhSach(sTimKiem, d);
        }

        //public DataTable TimKiemNV(string MaNV)
        //{
        //    return NV.TimKiemNV(MaNV);
        //}
        public DataTable NhanVien_Select()
        {
            return NV.NhanVien_Select();
        }

        //Thêm Nhân Viên
        public int NhanVien_Them(int ID, int ID_LoaiNV, string MaNV, string MK, string Hoten, string NgaySinh, string SDT, string DChi, string Email, int CMND, bool GioiTinh, string Hinh, bool HieuLuc)
        {
            return NV.NhanVien_Them(ID, ID_LoaiNV, MaNV, MK, Hoten, NgaySinh, SDT, DChi, Email, CMND, GioiTinh, Hinh, HieuLuc);
        }

        //Sữa Nhân Viên
        public int NhanVien_CapNhat(int ID, int ID_LoaiNV, string MaNV, string MK, string Hoten, string NgaySinh, string SDT, string DChi, string Email, int CMND, bool GioiTinh, string Hinh, bool HieuLuc)
        {
            return NV.NhanVien_CapNhat(ID, ID_LoaiNV, MaNV, MK, Hoten, NgaySinh, SDT, DChi, Email, CMND, GioiTinh, Hinh, HieuLuc);
        }

        //Xóa Nhân Viên
        public int NhanVien_Xoa(int ID, bool HieuLuc)
        {
            return NV.NhanVien_Xoa(ID, HieuLuc);
        }
    }
}
