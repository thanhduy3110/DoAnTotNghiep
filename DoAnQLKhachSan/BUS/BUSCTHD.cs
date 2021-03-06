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
    public class BUSCTHD
    {
        DAOCTHD CTHD = new DAOCTHD();

        public void HienThiTenDV(ComboBox cboTenDV, Label lblDonGia)
        {
            CTHD.HienThiTenDV(cboTenDV, lblDonGia);
        }


        public void HienThiDSCTHD(DataGridView dgvDSCTHD, int ID_HD)
        {
            CTHD.HienThiDSCTHD(dgvDSCTHD, ID_HD);
        }

        //public void TongID(TextBox txtID)
        //{
        //    CTHD.TongID(txtID);
        //}
        public DataTable CTHD_Select()
        {
            return CTHD.CTHD_Select();
        }
        public int CTHD_Them(int ID, int ID_HD, string ID_DV, string SoLuong, string DonGia,string ThoiGian)
        {
            return CTHD.CTHD_Them(ID, ID_HD,ID_DV, SoLuong, DonGia,ThoiGian);
        }

        public int CTHD_CongDonSL(string ID, string SoLuong)
        {
            return CTHD.CTHD_CongDonSL(ID, SoLuong);
        }

        public int CTHD_CapNhat(int ID, int ID_HD, string ID_DV, string SoLuong, string DonGia, string ThoiGian)
        {
            return CTHD.CTHD_CapNhat(ID, ID_HD, ID_DV, SoLuong, DonGia, ThoiGian);
        }

        public int CTHD_Xoa(string ID)
        {
            return CTHD.CTHD_Xoa(ID);
        }
    }
}
