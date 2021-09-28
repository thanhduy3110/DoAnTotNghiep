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
            string sql = "select CTHD.ID,ID_HD,TenDV,SoLuong,DonGia from CTHD,DichVu where DichVu.ID=CTHD.ID_DV and ID_HD = " + ID_HD;
            dsCTHD = db.LayDanhSach(sql);
            dgvDSCTHD.DataSource = dsCTHD.Tables[0];
        }

        public void TongID(TextBox txtID)
        {
            dsCTHD = db.LayDanhSach("select count(ID) as TongID from CTHD ");// truy vấn lên sql
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", dsCTHD.Tables[0], "TongID");
        }

        //khai báo 2 mảng để truyền tên tham số và giá trị tham số vào stored procedures
        string[] name = { };
        object[] value = { };


        //phương thức này gọi đến phương thức ThucHien ở dbConnectionData để thêm dữ liệu
        public int CTHD_Them(int ID, int ID_HD,string ID_DV, string SoLuong, string DonGia)
        {
            name = new string[5];
            value = new object[5];
            name[0] = "@ID"; value[0] = ID;
            name[1] = "@ID_HD"; value[1] = ID_HD;
            name[2] = "@ID_DV"; value[2] = ID_DV;
            name[3] = "@SoLuong"; value[3] = SoLuong;
            name[4] = "@DonGia"; value[4] = DonGia;
            return db.ThucHien("CTHD_Them", name, value, 5);
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
        public int CTHD_CapNhat(int ID, int ID_HD, string ID_DV, string SoLuong, string DonGia)
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

        public int CTHD_Xoa(string ID)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@ID"; value[0] = ID;
            return db.ThucHien("CTHD_Xoa", name, value, 1);
        }
    }
}

