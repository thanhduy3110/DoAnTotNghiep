using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DAOLogin
    {
        dbConnectionData db = new dbConnectionData();

        string[] name;
        object[] value;
        // phương thức lấy dữ liệu khi đăng nhập
        public DataTable DangNhap_Select(string MaNV, string MatKhau)//rồi, đã xem xong 1 loạt thủ tục ở dal
                                                                                   //đây là thủ tục sẽ dùng ở form đăng nhập, với điều kiện là trùng mã tài khoản và mật khẩu. ok?
        {
            name = new string[2];
            value = new object[2];

            name[0] = "@MaNV"; value[0] = MaNV;
            name[1] = "@MatKhau"; value[1] = MatKhau;

            return db.LayDuLieuCoDK("DangNhap_Select", name, value, 2);
        }

        public DataTable ThongTinDangNhap(string MaNV)
        {
            name = new string[1];
            value = new object[1];

            name[0] = "@MaNV"; value[0] = MaNV;

            return db.LayDuLieuCoDK("ThongTinDangNhap", name, value, 1);
        }
    }
}
