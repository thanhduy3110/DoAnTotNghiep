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
    public class BUSLoaiDV
    {
        DAOLoaiDV ldv = new DAOLoaiDV();

        public void HienThiDanhSach(string sTimKiem, DataGridView d)
        {
            ldv.HienThiDanhSach(sTimKiem, d);
        }
        public DataTable LDV_Select()
        {
            return ldv.loaidv_select();
        }

        public int LDV_Them(string ID, string TenLoaiDV, string HieuLuc)
        {
            return ldv.loaidv_them(ID, TenLoaiDV, HieuLuc);
        }
        public int LDV_CapNhat(string ID, string TenLoaiDV, string HieuLuc)
        {
            return ldv.loaidv_capnhat(ID, TenLoaiDV, HieuLuc);
        }




    }
}
