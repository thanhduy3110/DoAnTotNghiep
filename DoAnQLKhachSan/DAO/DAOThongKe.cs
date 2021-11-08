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
       

        public DataTable bieudo_select()
        {
            return db.Laydulieu("bieudo_select");
        }

        public DataSet ThongKeSLT()
        {
            return dsThongKe = db.LayDanhSach("select TenDV as N'Tên dịch vụ',TenLoaiDV as N'Tên loại dịch vụ', SLTon as N'Số lượng tồn' from DichVu, LoaiDV where DichVu.ID_LoaiDV = LoaiDV.ID");
        }

        public DataSet ThongKeHD()
        {
            return dsThongKe = db.LayDanhSach("select MaHD as N'Mã hóa đơn',Phong.SoPhong as N'Số phòng', TongTienPhong as N'Tổng tiền phòng',TongTienDV as N'Tổng tiền dịch vụ',TongTien as N'Tổng tiền' from HoaDon, Phong where HoaDon.ID_Phong=Phong.ID");
        }
    }
}
