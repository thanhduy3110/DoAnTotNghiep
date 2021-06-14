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
    public class BUSPhong
    {

        DAOPhong p = new DAOPhong();

        public void HienThiLP(ComboBox cboTenLP)
        {
            p.HienThiLoaiPhong(cboTenLP);
        }

        public DataTable Phong_Select()
        {
            return p.phong_select();
        }
        public int P_Them(string ID, string ID_LoaiPhong, string SoPhong, string Tang, string GiaThueNgay, string GiaThueGio, string GhiChu, string GocNhin, string BonTam, string ConTrong, string HieuLuc)
        {
            return p.phong_them(ID, ID_LoaiPhong, SoPhong, Tang, GiaThueNgay, GiaThueGio, GhiChu, GocNhin, BonTam, ConTrong, HieuLuc);
        }
        public int P_CapNhat(string ID, string ID_LoaiPhong, string SoPhong, string Tang, string GiaThueNgay, string GiaThueGio, string GhiChu, string GocNhin, string BonTam, string ConTrong, string HieuLuc)
        {
            return p.phong_capnhat(ID, ID_LoaiPhong, SoPhong, Tang, GiaThueNgay, GiaThueGio, GhiChu, GocNhin, BonTam, ConTrong, HieuLuc);
        }

    }
}
