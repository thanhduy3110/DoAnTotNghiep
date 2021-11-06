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
    public class BUSPhieuDatPhong
    {
        DAOPhieuDatPhong pdp = new DAOPhieuDatPhong();

        public void HienThiDanhSach(string sTimKiem, DataGridView d)
        {
            pdp.HienThiDanhSach(sTimKiem, d);
        }
        public void HienThiID_KH(ComboBox cboID_KH)
        {
            pdp.HienThiID_KH(cboID_KH);
        }

        public DataTable PDP_Select()
        {
            return pdp.phieudatphong_select();
        }

        public int PDP_Them(string ID, string ID_KH, string NgayDen, string NgayDi, bool HinhThucThue, string SoKhach, string GhiChu, bool DaXuLy, bool HieuLuc)
        {
            return pdp.phieudatphong_them(ID, ID_KH, NgayDen, NgayDi, HinhThucThue, SoKhach, GhiChu, DaXuLy, HieuLuc);
        }

        public int PDP_CapNhat(string ID, string ID_KH, string NgayDen, string NgayDi, bool HinhThucThue, string SoKhach, string GhiChu, bool DaXuLy, bool HieuLuc)
        {
            return pdp.phieudatphong_capnhat(ID, ID_KH, NgayDen, NgayDi, HinhThucThue, SoKhach, GhiChu, DaXuLy, HieuLuc);
     
       }
        public int phieudatphong_xoa(int ID, bool HieuLuc)
        {
            return pdp.phieudatphong_xoa(ID, HieuLuc);
        }
        }
}
