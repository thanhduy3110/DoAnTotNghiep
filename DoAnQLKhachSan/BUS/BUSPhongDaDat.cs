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
    public class BUSPhongDaDat
    {
        DAOPhongDaDat PDD = new DAOPhongDaDat();

        public void HienThiMaPhong(ComboBox cboMaPhong)
        {
            PDD.HienThiMaPhong(cboMaPhong);
        }

        public void HienThiID_PDD(ComboBox cboID_PDD, DateTimePicker dtpNgayDen, DateTimePicker dtpNgayDi)
        {
            PDD.HienThiID_PDD(cboID_PDD, dtpNgayDen, dtpNgayDi);
        }

        public DataTable PhongDaDat_Select()
        {
            return PDD.PhongDaDat_Select();
        }

        public int PhongDaDat_Them(string ID, string ID_PhieuDP, string ID_Phong, string NgayDen, string NgayDi)
        {
            return PDD.PhongDaDat_Them(ID, ID_PhieuDP, ID_Phong, NgayDen, NgayDi);
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
