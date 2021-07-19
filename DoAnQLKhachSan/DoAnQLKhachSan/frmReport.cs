using DoAnQLKhachSan.dbContext;
using DoAnQLKhachSan.ReportTing;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQLKhachSan
{
    public partial class frmReport : Form
    {
        private int ID_HD;
        public frmReport()
        {
            InitializeComponent();
        }
        public frmReport(int ID)
        {
            this.ID_HD = ID;
            InitializeComponent();
        }
        private void frmReport_Load(object sender, EventArgs e)
        {
            HienThiHD(this.ID_HD);
            this.reportHD.RefreshReport();
     
        }
        private void HienThiHD(int ID)
        {
            using (var _dbContext = new ConnectReportHD())
            {
                string sql = "select MaHD,NhanVien.HoTen as TenNV,KhachHang.HoTen as TenKH,NgayDen,NgayDi,SoPhong,TongTienPhong,TongTienDV,TongTien from HoaDon,NhanVien,KhachHang,Phong where HoaDon.ID_NV=NhanVien.ID and HoaDon.ID_KH=KhachHang.ID and HoaDon.ID_Phong=Phong.ID and  HoaDon.ID="+ID;
                List<ReportHD> DanhSach = _dbContext.Database.SqlQuery<ReportHD>(sql).ToList();

                this.reportHD.LocalReport.ReportPath = @"D:\DoAnTotNghiep\DoAnTotNghiep\DoAnQLKhachSan\DoAnQLKhachSan\ReportTing\ReportHD.rdlc";
                var reportDatasoure = new ReportDataSource("DataSetHoaDon", DanhSach);
                this.reportHD.LocalReport.DataSources.Clear();
                this.reportHD.LocalReport.DataSources.Add(reportDatasoure);
                this.reportHD.RefreshReport();
            }

        }
    }
}
