using DevComponents.Editors.DateTimeAdv;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DAOPhongDaDat
    {
        dbConnectionData db = new dbConnectionData();
        DataSet ds = new DataSet();
        DataSet dsPDD = new DataSet();
        string[] name = { };
        object[] value = { };
        public void HienThiMaPhong(ComboBox cboMaPhong)
        {
            ds = db.LayDanhSach("select ID, SoPhong from Phong");// truy vấn lên sql
            cboMaPhong.DataSource = ds.Tables[0];
            cboMaPhong.DisplayMember = "sophong";
            cboMaPhong.ValueMember = "id";
        }

        public void HienThiID_PDD(ComboBox cboID_PDD, DateTimeInput dtpNgayDen, DateTimeInput dtpNgayDi)
        {
            ds = db.LayDanhSach("select * from PhieuDatPhong");// truy vấn lên sql
            cboID_PDD.DataSource = ds.Tables[0];
            cboID_PDD.DisplayMember = "id";
            cboID_PDD.ValueMember = "id";
            dtpNgayDen.DataBindings.Add("Text", cboID_PDD.DataSource, "ngayden");
            dtpNgayDi.DataBindings.Add("Text", cboID_PDD.DataSource, "ngaydi");
        }

        public void HienThiDanhSach(string sTimKiem, DataGridView d)
        {
            dsPDD = db.LayDanhSach("select PDD.ID as ID,PDP.ID as ID_PhieuDP,KH.HoTen as HoTenKH,SDT,PDP.HinhThucThue as HTT,Phong.GiaThueGio as GTG,Phong.GiaThueNgay as GTN,ID_KH,Phong.SoPhong as SoPhong,PDP.NgayDen as NgayDen,PDP.NgayDi as NgayDi,Phong.ID as IDPHONG from KhachHang KH,PhieuDatPhong PDP,PhongDaDat PDD,Phong  where KH.ID=PDP.ID_KH and PDD.ID_PhieuDP=PDP.ID and Phong.ID=PDD.ID_Phong and HoTenKH like '%" + sTimKiem + "%' and SDT like '%" + sTimKiem + "%' SoPhong like '%" + sTimKiem + "%'");
            d.DataSource = dsPDD.Tables[0];
        }

        //public void HienThiSDT(ComboBox cboSDT)
        //{
        //    DataSet dsKH = new DataSet();
        //    dsKH = db.LayDanhSach("select SDT,ID_KH from KhachHang KH ,PhieuDatPhong where KH.ID=ID_KH");// truy vấn lên sql
        //    cboSDT.DataSource = dsKH.Tables[0];
        //    cboSDT.DisplayMember = "SDT";
        //    cboSDT.ValueMember = "ID_KH";
        //}


        public void HienThiSDT(ComboBox cboSDT, DateTimeInput dtpNgayDen, DateTimeInput dtpNgayDi, TextBox txtHoTen)
        {
            DataSet dsKH = new DataSet();
            dsKH = db.LayDanhSach("select PDD.ID as ID,SDT,KH.HoTen as HoTenKH,PDP.NgayDen as NgayDen,PDP.NgayDi as NgayDi,PDP.HinhThucThue as HTT,Phong.GiaThueGio as GTG,Phong.GiaThueNgay as GTN,Phong.SoPhong,PDP.ID as ID_PhieuDP,ID_KH  from KhachHang KH, PhieuDatPhong PDP, PhongDaDat PDD, Phong where KH.ID = PDP.ID_KH and PDD.ID_PhieuDP = PDP.ID and Phong.ID = PDD.ID_Phong");// truy vấn lên sql
            cboSDT.DataSource = dsKH.Tables[0];
            cboSDT.DisplayMember = "SDT";
            cboSDT.ValueMember = "ID_PhieuDP";
            dtpNgayDen.DataBindings.Add("Text", cboSDT.DataSource, "ngayden");
            dtpNgayDi.DataBindings.Add("Text", cboSDT.DataSource, "ngaydi");
            txtHoTen.DataBindings.Add("Text", cboSDT.DataSource, "HoTenKH");
        }


        public DataTable PhongDaDat_Select()
        {
            return db.Laydulieu("PhongDaDat_Select");
        }

        public int PhongDaDat_Them(string ID, string ID_PhieuDP, string ID_Phong, string NgayDen, string NgayDi)
        {
            name = new string[5];
            value = new object[5];

            name[0] = "@ID"; value[0] = ID;
            name[1] = "@ID_PhieuDP"; value[1] = ID_PhieuDP;
            name[2] = "@ID_Phong"; value[2] = ID_Phong;
            name[3] = "@NgayDen"; value[3] = NgayDen;
            name[4] = "@NgayDi"; value[4] = NgayDi;
            return db.ThucHien("PhongDaDat_Them", name, value, 5);
        }
        public int PhongDaDat_CapNhat(string ID, string ID_PhieuDP, string ID_Phong, string NgayDen, string NgayDi)
        {
            name = new string[5];
            value = new object[5];

            name[0] = "@ID"; value[0] = ID;
            name[1] = "@ID_PhieuDP"; value[1] = ID_PhieuDP;
            name[2] = "@ID_Phong"; value[2] = ID_Phong;
            name[3] = "@NgayDen"; value[3] = NgayDen;
            name[4] = "@NgayDi"; value[4] = NgayDi;
            return db.ThucHien("PhongDaDat_CapNhat", name, value, 5);
        }

        public int PhongDaDat_Xoa(string ID)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@ID"; value[0] = ID;
            return db.ThucHien("PhongDaDat_Xoa", name, value, 1);
        }


    }
}
