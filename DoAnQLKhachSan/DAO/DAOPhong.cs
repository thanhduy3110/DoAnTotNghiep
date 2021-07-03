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
            dsLoaiPhong = db.LayDanhSach("select ID, TenLoaiPhong from LoaiPhong");// truy vấn lên sql
            cboTenLP.DataSource = dsLoaiPhong.Tables[0];
            cboTenLP.DisplayMember = "tenloaiphong";
            cboTenLP.ValueMember = "id";
        }

        public void HienThiDanhSach(string sTimKiem, DataGridView d)
        {
            dsPhong = db.LayDanhSach("select * from Phong where SoPhong like N'%" + sTimKiem + "%'");
            d.DataSource = dsPhong.Tables[0];
        }
        public DataTable phong_select()
        {
            return db.Laydulieu("phong_select");
        }
        public int phong_them(string ID, string ID_LoaiPhong, string SoPhong, string Tang, string GiaThueNgay, string GiaThueGio, string GhiChu, string GocNhin, string BonTam, string ConTrong, string HieuLuc)
        {

            name = new string[11];
            value = new object[11];
            name[0] = "@ID"; value[0] = ID;
            name[1] = "@ID_LoaiPhong"; value[1] = ID_LoaiPhong;
            name[2] = "@SoPhong"; value[2] = SoPhong;
            name[3] = "@Tang"; value[3] = Tang;
            name[4] = "@GiaThueNgay"; value[4] = GiaThueNgay;
            name[5] = "@GiaThueGio"; value[5] = GiaThueGio;
            name[6] = "@GhiChu"; value[6] = GhiChu;
            name[7] = "@GocNhin"; value[7] = GocNhin;
            name[8] = "@BonTam"; value[8] = BonTam;
            name[9] = "@ConTrong"; value[9] = ConTrong;
            name[10] = "@HieuLuc"; value[10] = HieuLuc;

            return db.ThucHien("phong_them", name, value, 11);
        }
        public int phong_capnhat(string ID, string ID_LoaiPhong, string SoPhong, string Tang, string GiaThueNgay, string GiaThueGio, string GhiChu, string GocNhin, string BonTam, string ConTrong, string HieuLuc)
        {
            name = new string[11];
            value = new object[11];
            name[0] = "@ID"; value[0] = ID;
            name[1] = "@ID_LoaiPhong"; value[1] = ID_LoaiPhong;
            name[2] = "@SoPhong"; value[2] = SoPhong;
            name[3] = "@Tang"; value[3] = Tang;
            name[4] = "@GiaThueNgay"; value[4] = GiaThueNgay;
            name[5] = "@GiaThueGio"; value[5] = GiaThueGio;
            name[6] = "@GhiChu"; value[6] = GhiChu;
            name[7] = "@GocNhin"; value[7] = GocNhin;
            name[8] = "@BonTam"; value[8] = BonTam;
            name[9] = "@ConTrong"; value[9] = ConTrong;
            name[10] = "@HieuLuc"; value[10] = HieuLuc;

            return db.ThucHien("phong_capnhat", name, value, 11);
        }

    }
}
