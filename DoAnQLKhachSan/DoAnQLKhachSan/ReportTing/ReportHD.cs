using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQLKhachSan.ReportTing
{
    public class ReportHD
    {
        public string MaHD { get; set; }
        public string TenNV { get; set; }
        public string TenKH { get; set; }
        public DateTime NgayDen { get; set; }
        public DateTime NgayDi { get; set; }
        public int SoPhong { get; set; }
        public int TongTienPhong { get; set; }
        public int TongTienDV { get; set; }
        public int TongTien { get; set; }

        public string TenDV { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }

    }
}
