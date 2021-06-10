using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace BUS
{
    public class BUSLoaiPhong
    {
        //loại phòng
        DAOLoaiPhong lpd = new DAOLoaiPhong();

        //loai phong ở DAO
        public DataTable LP_Select()
        {
            return lpd.loaiphong_select();
        }
        public int LP_Them(string id,string TenLoaiPhong, string SoGiuongDoi, string SoGiuongDon, string SoKhach, string HieuLuc)
        {
            return lpd.loaiphong_them(id,TenLoaiPhong, SoGiuongDoi, SoGiuongDon, SoKhach, HieuLuc);
        }
        public int LP_CapNhat(string id, string TenLoaiPhong, string SoGiuongDoi, string SoGiuongDon, string SoKhach, string HieuLuc)
        {
            return lpd.loaiphong_capnhat(id, TenLoaiPhong, SoGiuongDoi, SoGiuongDon, SoKhach, HieuLuc);
        }
        public int LP_Xoa(string ID)
        {
            return lpd.loaiphong_xoa(ID);
        }
        public DataTable ID_MAX_SELECT()
        {
            return lpd.id_max_select();
        }
    }
}
