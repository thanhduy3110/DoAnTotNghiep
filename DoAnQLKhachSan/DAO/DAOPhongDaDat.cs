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
        string[] name = { };
        object[] value = { };
        public void HienThiMaPhong(ComboBox cboMaPhong)
        {
            ds = db.LayDanhSach("select ID, SoPhong from Phong");// truy vấn lên sql
            cboMaPhong.DataSource = ds.Tables[0];
            cboMaPhong.DisplayMember = "sophong";
            cboMaPhong.ValueMember = "id";
        }

        public void HienThiID_PDD(ComboBox cboID_PDD, DateTimePicker dtpNgayDen, DateTimePicker dtpNgayDi)
        {
            ds = db.LayDanhSach("select * from PhieuDatPhong");// truy vấn lên sql
            cboID_PDD.DataSource = ds.Tables[0];
            cboID_PDD.DisplayMember = "id";
            cboID_PDD.ValueMember = "id";
            dtpNgayDen.DataBindings.Add("Text", cboID_PDD.DataSource, "ngayden");
            dtpNgayDi.DataBindings.Add("Text", cboID_PDD.DataSource, "ngaydi");
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
