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

        public void HienThiDanhSach(string sTimKiem, DataGridView d)
        {
            p.HienThiDanhSach(sTimKiem, d);
        }
        public void HienThiLP(ComboBox cboTenLP)
        {
            p.HienThiLoaiPhong(cboTenLP);
        }


        public DataTable phong_ChuyenPhong()
        {
            return p.phong_ChuyenPhong();
        }
        public DataTable Phong_Select()
        {
            return p.phong_select();
        }
        public int P_Them(string ID, string ID_LoaiPhong, string SoPhong, string Tang, string GiaThueNgay, string GhiChu, int GocNhin, bool BonTam, int ConTrong, bool HieuLuc)
        {
            return p.phong_them(ID, ID_LoaiPhong, SoPhong, Tang, GiaThueNgay, GhiChu, GocNhin, BonTam, ConTrong, HieuLuc);
        }
        public int P_CapNhat(string ID, string ID_LoaiPhong, string SoPhong, string Tang, string GiaThueNgay, string GhiChu, int GocNhin, bool BonTam, int ConTrong, bool HieuLuc)
        {
            return p.phong_capnhat(ID, ID_LoaiPhong, SoPhong, Tang, GiaThueNgay, GhiChu, GocNhin, BonTam, ConTrong, HieuLuc);
        }

        public int Phong_Xoa(int ID, bool HieuLuc)
        {
            return p.Phong_Xoa(ID, HieuLuc);
        }

        public int phong_CNConTrong(int ID, int ConTrong)
        {
            return p.phong_CNConTrong(ID, ConTrong);
        }
    }
}
