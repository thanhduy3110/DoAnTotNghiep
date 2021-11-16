using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DAO
{
    public class DAOThongKe
    {
        DataSet dsThongKe = new DataSet();
        dbConnectionData db = new dbConnectionData();
        string[] name = { };
        object[] value = { };

        public DataTable bieudo_select()
        {
            return db.Laydulieu("bieudo_select");
        }

        //public DataTable ThongKeHD(string NgayBD,string NgayKT)//rồi, đã xem xong 1 loạt thủ tục ở dal
        //                                                             //đây là thủ tục sẽ dùng ở form đăng nhập, với điều kiện là trùng mã tài khoản và mật khẩu. ok?
        //{
        //    name = new string[2];
        //    value = new object[2];

        //    name[0] = "@NgayLap"; value[0] = NgayBD;
        //    name[1] = "@NgayLap"; value[1] = NgayKT;

        //    return db.LayDuLieuCoDK("ThongKeHD", name, value, 2);
        //}

        public void ThongKeHD(DataGridView dgv,string dtp1,string dtp2)
        {
            dsThongKe = db.LayDanhSach("select MaHD as N'Mã hóa đơn',Phong.SoPhong as N'Số phòng', TongTienPhong as N'Tổng tiền phòng',TongTienDV as N'Tổng tiền dịch vụ',TongTien as N'Tổng tiền'  from HoaDon, Phong where HoaDon.ID_Phong = Phong.ID and HoaDon.NgayLap between '"+dtp1+"' and '"+dtp2+"' order by MaHD");
            dgv.DataSource = dsThongKe.Tables[0];
        }

        public DataTable ThongKeSLT()
        {
            return  db.Laydulieu("ThongKeSLT");
        }

        public DataTable THongKePhongChoKhach()
        {
            return db.Laydulieu("THongKePhongChoKhach");
        }

        public void ThongKeDV(DataGridView dgv, string dtp1, string dtp2)
        {
            DataSet dsDV = new DataSet();
            dsDV = db.LayDanhSach("select TenDV,Sum(SoLuong) as N'Tổng số lượng' from CTHD, DichVu, HoaDon where DichVu.ID = CTHD.ID_DV and HoaDon.ID = CTHD.ID and NgayLap between '" + dtp1 + "' and '" + dtp2 + "' group by TenDV");
            dgv.DataSource = dsDV.Tables[0];
        }

        public DataTable ThongKePhongSuaChua()
        {
            return db.Laydulieu("ThongKePhongSuaChua");
        }
    }
}
