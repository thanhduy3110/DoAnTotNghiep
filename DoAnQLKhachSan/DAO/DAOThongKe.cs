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
        public DataSet ThongKeTheoNgay(string NgayBD,string NgayKT)
        {
           return db.LayDanhSach("select  sum(TongTien)  from HoaDon where NgayLap Between '"+NgayBD+ "' and '"+NgayKT+"' ");
            
        }

        public DataSet ThongKeDV(string NgayBD, string NgayKT)
        {
            return dsThongKe = db.LayDanhSach("select TenDV as N'Tên dịch vụ',TenLoaiDV as N'Tên loại dịch vụ', Sum(CTHD.SoLuong) as N'Số lượng',DonGia as N'Dơn giá' from CTHD, DichVu, LoaiDV, HoaDon where CTHD.ID_DV = DichVu.ID and DichVu.ID_LoaiDV = LoaiDV.ID and HoaDon.ID = CTHD.ID_HD and HoaDon.NgayLap between '"+NgayBD+"' and '"+ NgayKT +"' group by TenDV, TenLoaiDV, DonGia, CTHD.SoLuong");
        }

        public DataSet ThongKeSLT()
        {
            return dsThongKe = db.LayDanhSach("select TenDV as N'Tên dịch vụ',TenLoaiDV as N'Tên loại dịch vụ', SLTon as N'Số lượng tồn', GiaTien as N'Giá tiền' from DichVu, LoaiDV where DichVu.ID_LoaiDV = LoaiDV.ID");
        }
    }
}
