using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DevComponents.Editors.DateTimeAdv;

namespace BUS
{
    public class BUSPhongDaDat
    {
        DAOPhongDaDat PDD = new DAOPhongDaDat();


        public void HienThiDanhSach(string sTimKiem, DataGridView d)
        {
            PDD.HienThiDanhSach(sTimKiem, d);
        }
        public void HienThiMaPhong(ComboBox cboMaPhong, TextBox txtSoKhach)
        {
            PDD.HienThiMaPhong(cboMaPhong, txtSoKhach);
        }

        public void HienThiID_PDD(ComboBox cboID_PDD, DateTimeInput dtpNgayDen, DateTimeInput dtpNgayDi)
        {
            PDD.HienThiID_PDD(cboID_PDD, dtpNgayDen, dtpNgayDi);
        }

        public void HienThiSDT(ComboBox cboSDT, DateTimeInput dtpNgayDen, DateTimeInput dtpNgayDi, TextBox txtHoTen)
        {
            PDD.HienThiSDT(cboSDT, dtpNgayDen, dtpNgayDi, txtHoTen);
        }

            public DataTable PhongDaDat_Select()
        {
            return PDD.PhongDaDat_Select();
        }

        public int PhongDaDat_Them( string ID_PhieuDP, string ID_Phong, string NgayDen, string NgayDi)
        {
            return PDD.PhongDaDat_Them( ID_PhieuDP, ID_Phong, NgayDen, NgayDi);
        }

        public int PhongDaDat_CapNhat(string ID, string ID_PhieuDP, string ID_Phong, string NgayDen, string NgayDi)
        {
            return PDD.PhongDaDat_CapNhat(ID, ID_PhieuDP, ID_Phong, NgayDen, NgayDi);
        }

        public int PhongDaDat_Xoa(string ID)
        {
            return PDD.PhongDaDat_Xoa(ID);
        }
    }
}
