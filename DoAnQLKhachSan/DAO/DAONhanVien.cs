using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DAONhanVien
    {
        DataSet dsNhanVien = new DataSet();
        dbConnectionData db = new dbConnectionData();

        //Lấy danh sách ID và TenLoaiNV gán vào combobox cbTenLoaiNV
        public void HienThiTenLoaiNV(ComboBox cboTenLoaiNV)
        {
            dsNhanVien = db.LayDanhSach("select ID, TenLoaiNV from LoaiNV where HieuLuc=1");// truy vấn lên sql
            cboTenLoaiNV.DataSource = dsNhanVien.Tables[0];
            cboTenLoaiNV.DisplayMember = "tenloainv";
            cboTenLoaiNV.ValueMember = "id";
        }

        public void HienThiDanhSach(string sTimKiem, DataGridView d)
        {
            DataSet DSTimKiem = new DataSet();
            DSTimKiem = db.LayDanhSach("select NhanVien.ID,TenLoaiNV,MaNV,MatKhau,HoTen,NgaySinh,SDT,DiaChi,Email,CMND,dbo.NV_GioiTinh(GioiTinh) as GioiTinh,HinhAnh,dbo.NV_HieuLuc(NhanVien.HieuLuc) as HieuLuc from NhanVien,LoaiNV where NhanVien.ID_LoaiNV=LoaiNV.ID and NhanVien.HieuLuc = 1 and (MaNV like N'%" + sTimKiem + "%' or CMND like '%"+sTimKiem+ "%' or SDT like '%" + sTimKiem + "%')");
            d.DataSource = DSTimKiem.Tables[0];
        }

        //public DataTable TimKiemNV(string MaNV)//rồi, đã xem xong 1 loạt thủ tục ở dal
        //                                                             //đây là thủ tục sẽ dùng ở form đăng nhập, với điều kiện là trùng mã tài khoản và mật khẩu. ok?
        //{
        //    name = new string[1];
        //    value = new object[1];

        //    name[0] = "@MaNV"; value[0] = MaNV;
        //    //name[1] = "@Hoten"; value[1] = Hoten;
        //    //name[2] = "@SDT"; value[2] = SDT;
        //    //name[3] = "@CMND"; value[3] = CMND;

        //    return db.LayDuLieuCoDK("TimKiemNV", name, value, 1);
        //}
        //khai báo 2 mảng để truyền tên tham số và giá trị tham số vào stored procedures
        string[] name = { };
        object[] value = { };

        //phương thức này gọi đến phương thức LayduLieu ở dbConnectionData để lấy dữ liệu
        public DataTable NhanVien_Select()
        {
            return db.Laydulieu("NhanVien_Select");
        }

        //phương thức này gọi đến phương thức ThucHien ở dbConnectionData để thêm dữ liệu
        public int NhanVien_Them(int ID, int ID_LoaiNV, string MaNV, string MK, string Hoten, string NgaySinh, string SDT, string DChi, string Email, int CMND, bool GioiTinh, string Hinh, bool HieuLuc)
        {
            name = new string[13];
            value = new object[13];
            name[0] = "@ID"; value[0] = ID;
            name[1] = "@ID_LoaiNV"; value[1] = ID_LoaiNV;
            name[2] = "@MaNV"; value[2] = MaNV;
            name[3] = "@MatKhau"; value[3] = MK;
            name[4] = "@Hoten"; value[4] = Hoten;
            name[5] = "@NgaySinh"; value[5] = NgaySinh;
            name[6] = "@SDT"; value[6] = SDT;
            name[7] = "@DiaChi"; value[7] = DChi;
            name[8] = "@Email"; value[8] = Email;
            name[9] = "@CMND"; value[9] = CMND;
            name[10] = "@GioiTinh"; value[10] = GioiTinh;
            name[11] = "@HinhAnh"; value[11] = Hinh;
            name[12] = "@HieuLuc"; value[12] = HieuLuc;
            return db.ThucHien("NhanVien_Them", name, value, 13);
        }

        //update
        public int NhanVien_CapNhat(int ID, int ID_LoaiNV, string MaNV, string MK, string Hoten, string NgaySinh, string SDT, string DChi, string Email, int CMND, bool GioiTinh, string Hinh, bool HieuLuc)
        {
            name = new string[13];
            value = new object[13];
            name[0] = "@ID"; value[0] = ID;
            name[1] = "@ID_LoaiNV"; value[1] = ID_LoaiNV;
            name[2] = "@MaNV"; value[2] = MaNV;
            name[3] = "@MatKhau"; value[3] = MK;
            name[4] = "@Hoten"; value[4] = Hoten;
            name[5] = "@NgaySinh"; value[5] = NgaySinh;
            name[6] = "@SDT"; value[6] = SDT;
            name[7] = "@DiaChi"; value[7] = DChi;
            name[8] = "@Email"; value[8] = Email;
            name[9] = "@CMND"; value[9] = CMND;
            name[10] = "@GioiTinh"; value[10] = GioiTinh;
            name[11] = "@HinhAnh"; value[11] = Hinh;
            name[12] = "@HieuLuc"; value[12] = HieuLuc;
            return db.ThucHien("NhanVien_CapNhat", name, value, 13);
        }
        //delete
        public int NhanVien_Xoa(int ID, bool HieuLuc)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@ID"; value[0] = ID;
            name[1] = "@HieuLuc"; value[1] = HieuLuc;
            return db.ThucHien("NhanVien_Xoa", name, value, 2);
        }
    }
}
