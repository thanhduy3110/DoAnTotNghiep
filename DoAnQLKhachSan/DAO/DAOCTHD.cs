using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DAOCTHD
    {
        DataSet dsCTHD = new DataSet();
        dbConnectionData db = new dbConnectionData();



        public void HienThiTenDV(ComboBox cboTenDV, Label lblDonGia)
        {
            dsCTHD = db.LayDanhSach("select * from DichVu where HieuLuc=1");// truy vấn lên sql
            cboTenDV.DataSource = dsCTHD.Tables[0];
            cboTenDV.DisplayMember = "TenDV";
            cboTenDV.ValueMember = "ID";
            lblDonGia.DataBindings.Add("Text", cboTenDV.DataSource, "GiaTien");
        }


        public void HienThiDSCTHD(DataGridView dgvDSCTHD, int ID_HD)
        {
            string sql = "select ID,ID_HD,MaHD,ID_DV,SoLuong,DonGia from CTHD where ID_HD = " + ID_HD;
            dsCTHD = db.LayDanhSach(sql);
            dgvDSCTHD.DataSource = dsCTHD.Tables[0];
        }

        public void TongID(TextBox txtID)
        {
            dsCTHD = db.LayDanhSach("select count(ID) as TongID from CTHD ");// truy vấn lên sql
            txtID.DataBindings.Add("Text", dsCTHD.Tables[0], "TongID");
        }

        //khai báo 2 mảng để truyền tên tham số và giá trị tham số vào stored procedures
        string[] name = { };
        object[] value = { };


        //phương thức này gọi đến phương thức ThucHien ở dbConnectionData để thêm dữ liệu
        public int CTHD_Them(string ID, string ID_HD, string MaHD, string ID_DV, string SoLuong, string DonGia)
        {
            name = new string[6];
            value = new object[6];
            name[0] = "@ID"; value[0] = ID;
            name[1] = "@ID_HD"; value[1] = ID_HD;
            name[2] = "@MaHD"; value[2] = MaHD;
            name[3] = "@ID_DV"; value[3] = ID_DV;
            name[4] = "@SoLuong"; value[4] = SoLuong;
            name[5] = "@DonGia"; value[5] = DonGia;

            return db.ThucHien("CTHD_Them", name, value, 6);
        }

        public int CTHD_CongDonSL(string ID, string SoLuong)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@ID"; value[0] = ID;
            name[1] = "@SoLuong"; value[1] = SoLuong;

            return db.ThucHien("CTHD_CongDonSL", name, value, 2);
        }

        //update
        public int CTHD_CapNhat(string ID, string ID_HD, string ID_DV, string SoLuong, string DonGia)
        {
            name = new string[5];
            value = new object[5];
            name[0] = "@ID"; value[0] = ID;
            name[1] = "@ID_HD"; value[1] = ID_HD;
            name[2] = "@ID_DV"; value[2] = ID_DV;
            name[3] = "@SoLuong"; value[3] = SoLuong;
            name[4] = "@DonGia"; value[4] = DonGia;

            return db.ThucHien("CTHD_CapNhat", name, value, 5);
        }
    }
}

