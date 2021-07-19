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
    public class BUSLoaiNV
    {
        DAOLoaiNV LNV = new DAOLoaiNV();

        public void HienThiDanhSach(string sTimKiem, DataGridView d)
        {
            LNV.HienThiDanhSach(sTimKiem, d);
        }
        //Loại nhân viên ở DAO
        public DataTable LoaiNV_selecl()
        {
            return LNV.LoaiNV_Select();
        }
        public int LoaiNV_Them(int ID, string TenLoaiNV, bool HieuLuc)
        {
            return LNV.LoaiNV_Them(ID, TenLoaiNV, HieuLuc);
        }
        public int LoaiNV_CapNhat(int ID, string TenLoaiNV, bool HieuLuc)
        {
            return LNV.LoaiNV_CapNhat(ID, TenLoaiNV, HieuLuc);
        }

        public int LoaiNV_Xoa(int ID, int HieuLuc)
        {
            return LNV.LoaiNV_Xoa(ID, HieuLuc);
        }
    }
}
