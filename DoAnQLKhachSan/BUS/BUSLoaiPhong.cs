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
    public class BUSLoaiPhong
    {
        //loại phòng
        DAOLoaiPhong lpd = new DAOLoaiPhong();

        public void HienThiDanhSach(string sTimKiem, DataGridView d)
        {
            lpd.HienThiDanhSach(sTimKiem, d);
        }
        //loai phong ở DAO
        public DataTable LP_Select()
        {
            return lpd.loaiphong_select();
        }
        public int LP_Them(string id, string TenLoaiPhong, string SoGiuongDoi, string SoGiuongDon, string SoKhach, bool HieuLuc)
        {
            return lpd.loaiphong_them(id, TenLoaiPhong, SoGiuongDoi, SoGiuongDon, SoKhach, HieuLuc);
        }
        public int LP_CapNhat(string id, string TenLoaiPhong, string SoGiuongDoi, string SoGiuongDon, string SoKhach, bool HieuLuc)
        {
            return lpd.loaiphong_capnhat(id, TenLoaiPhong, SoGiuongDoi, SoGiuongDon, SoKhach, HieuLuc);
        }
        public int LP_Xoa(int ID,bool HieuLuc)
        {
            return lpd.loaiphong_xoa(ID,HieuLuc);
        }
        public DataTable ID_MAX_SELECT()
        {
            return lpd.id_max_select();
        }
    }
}
