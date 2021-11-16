using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DAOPhong
    {
        DataSet dsLoaiPhong = new DataSet();
        DataSet dsPhong = new DataSet();
        dbConnectionData db = new dbConnectionData();

        string[] name = { };
        object[] value = { };
        //Lấy danh sách ID và TenLoaiPhong gán vào combobox cbTenLP
        public void HienThiLoaiPhong(ComboBox cboTenLP)
        {
            dsLoaiPhong = db.LayDanhSach("select ID, TenLoaiPhong from LoaiPhong where HieuLuc=1");// truy vấn lên sql
            cboTenLP.DataSource = dsLoaiPhong.Tables[0];
            cboTenLP.DisplayMember = "tenloaiphong";
            cboTenLP.ValueMember = "id";
        }

        public void HienThiDanhSach(string sTimKiem, DataGridView d)
        {
            dsPhong = db.LayDanhSach("select Phong.ID,TenLoaiPhong,SoPhong,Tang,GiaThueNgay,GhiChu,dbo.Phong_GocNhin(GocNhin)as GocNhin,dbo.Phong_BonTam(BonTam)as BonTam,dbo.Phong_ConTrong(ConTrong)as ConTrong,dbo.Phong_HieuLuc(Phong.HieuLuc)as HieuLuc  from Phong,LoaiPhong where Phong.ID_LoaiPhong=LoaiPhong.ID and Phong.HieuLuc=1 and SoPhong like N'%" + sTimKiem + "%'");
            d.DataSource = dsPhong.Tables[0];
        }
        public DataTable phong_select()
        {
            return db.Laydulieu("phong_select");
        }

        public DataTable phong_ChuyenPhong()
        {
            return db.Laydulieu("phong_ChuyenPhong");
        }
        public int phong_them(string ID, string ID_LoaiPhong, string SoPhong, string Tang, string GiaThueNgay, string GhiChu, int GocNhin, bool BonTam, int ConTrong, bool HieuLuc)
        {

            name = new string[10];
            value = new object[10];
            name[0] = "@ID"; value[0] = ID;
            name[1] = "@ID_LoaiPhong"; value[1] = ID_LoaiPhong;
            name[2] = "@SoPhong"; value[2] = SoPhong;
            name[3] = "@Tang"; value[3] = Tang;
            name[4] = "@GiaThueNgay"; value[4] = GiaThueNgay;
            name[5] = "@GhiChu"; value[5] = GhiChu;
            name[6] = "@GocNhin"; value[6] = GocNhin;
            name[7] = "@BonTam"; value[7] = BonTam;
            name[8] = "@ConTrong"; value[8] = ConTrong;
            name[9] = "@HieuLuc"; value[9] = HieuLuc;

            return db.ThucHien("phong_them", name, value, 10);
        }
        public int phong_capnhat(string ID, string ID_LoaiPhong, string SoPhong, string Tang, string GiaThueNgay,  string GhiChu, int GocNhin, bool BonTam, int ConTrong, bool HieuLuc)
        {
            name = new string[10];
            value = new object[10];
            name[0] = "@ID"; value[0] = ID;
            name[1] = "@ID_LoaiPhong"; value[1] = ID_LoaiPhong;
            name[2] = "@SoPhong"; value[2] = SoPhong;
            name[3] = "@Tang"; value[3] = Tang;
            name[4] = "@GiaThueNgay"; value[4] = GiaThueNgay;
            name[5] = "@GhiChu"; value[5] = GhiChu;
            name[6] = "@GocNhin"; value[6] = GocNhin;
            name[7] = "@BonTam"; value[7] = BonTam;
            name[8] = "@ConTrong"; value[8] = ConTrong;
            name[9] = "@HieuLuc"; value[9] = HieuLuc;

            return db.ThucHien("phong_capnhat", name, value, 10);
        }

        public int Phong_Xoa(int ID, bool HieuLuc)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@ID"; value[0] = ID;
            name[1] = "@HieuLuc"; value[1] = HieuLuc;
            return db.ThucHien("Phong_Xoa", name, value, 2);
        }


        public int phong_CNConTrong(int ID, int ConTrong)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@ID"; value[0] = ID;
            name[1] = "@ConTrong"; value[1] = ConTrong;
            return db.ThucHien("phong_CNConTrong", name, value, 2);
        }
    }
}
