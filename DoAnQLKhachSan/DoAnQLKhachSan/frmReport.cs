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
        private int ID_HD,ID_KH,IDNV;
        
        public frmReport()
        {
            InitializeComponent();
        }
        public frmReport(int IDNV,int ID_HD)
        {
            this.IDNV = IDNV;
            this.ID_HD = ID_HD;
            
            InitializeComponent();
        }
        private void frmReport_Load(object sender, EventArgs e)
        {
            HienThiHD(this.ID_HD,this.IDNV);
            this.reportHD.RefreshReport();
     
        }
        //private void HienThiHD(int ID,int ID_KH)
        //{
        //    using (var _dbContext = new QLKhachSanConText())
        //    {
        //        string sql = "select MaHD,NgayDen,NgayDi,SoPhong,TongTienPhong,TongTienDV,TongTien from HoaDon,Phong where HoaDon.ID_Phong = Phong.ID and HoaDon.ID = " + "'"+ ID+"'";
        //        List<ReportHD> DanhSach = _dbContext.Database.SqlQuery<ReportHD>(sql).ToList();

        //        string sql1 = "select KhachHang.HoTen as TenKH,Phong.SoPhong as Phong,TenDV,SoLuong,DonGia from HoaDon, KhachHang, Phong, CTHD, DichVu where HoaDon.ID_KH = KhachHang.ID and HoaDon.ID_Phong = Phong.ID and DichVu.ID = CTHD.ID_DV and CTHD.ID_HD = HoaDon.ID and HoaDon.MaHD = " + "'" + MaHD + "'";
        //        List<ReportHD1> DanhSach1 = _dbContext.Database.SqlQuery<ReportHD1>(sql1).ToList();

        //        string sql2 = "select KhachHang.HoTen as TenKH from KhachHang,HoaDon where KhachHang.ID=HoaDon.ID_KH and HoaDon.ID_KH="+ID_KH +"group by KhachHang.HoTen";
        //        List<ReportHD2> DanhSach2 = _dbContext.Database.SqlQuery<ReportHD2>(sql2).ToList();

        //        string sql3 = "select NhanVien.HoTen as TenNV,GETDATE() as NgayLap from NhanVien,HoaDon where HoaDon.ID_NV=NhanVien.ID and HoaDon.ID_NV=" +ID+ "group by NhanVien.HoTen";
        //        List<ReportHD3> DanhSach3 = _dbContext.Database.SqlQuery<ReportHD3>(sql3).ToList();

        //        this.reportHD.LocalReport.ReportPath = @"D:\DoAnTotNghiep\DoAnTotNghiep\DoAnQLKhachSan\DoAnQLKhachSan\ReportTing\ReportHD.rdlc";
        //        var reportDatasoure = new ReportDataSource("DataSetHD", DanhSach);

        //        var reportDatasoure1 = new ReportDataSource("DataSetHD1", DanhSach1);

        //        var reportDatasoure2 = new ReportDataSource("DataSetHD2", DanhSach2);

        //        var reportDatasoure3 = new ReportDataSource("DataSetHD3", DanhSach3);

        //        this.reportHD.LocalReport.DataSources.Clear();

        //        this.reportHD.LocalReport.DataSources.Add(reportDatasoure);

        //        this.reportHD.LocalReport.DataSources.Add(reportDatasoure1);

        //        this.reportHD.LocalReport.DataSources.Add(reportDatasoure2);

        //        this.reportHD.LocalReport.DataSources.Add(reportDatasoure3);

        //        this.reportHD.RefreshReport();
        //    }

        //}
        private void HienThiHD(int ID,int IDNV)
        {
            using (var _dbContext = new QLKhachSanConText())
            {
                string sql = "select MaHD,KhachHang.HoTen as TenKH,NgayDen,NgayDi,SoPhong,TongTienPhong,TongTienDV,TongTien from HoaDon, KhachHang, Phong where HoaDon.ID_KH = KhachHang.ID and HoaDon.ID_Phong = Phong.ID  and HoaDon.ID ="+ID;
                List<ReportHD> DanhSach = _dbContext.Database.SqlQuery<ReportHD>(sql).ToList();

                string sql1 = "select TenDV,SoLuong,DonGia,ThoiGianThemDV from CTHD,DichVu,HoaDon where CTHD.ID_DV = DichVu.ID and HoaDon.ID=CTHD.ID_HD and HoaDon.ID =" + ID;
                List<ReportHD1> DanhSach1 = _dbContext.Database.SqlQuery<ReportHD1>(sql1).ToList();

                string sql2 = "select NhanVien.HoTen as TenNV,GETDATE() as NgayLap from NhanVien where NhanVien.ID ="+ IDNV ;
                List<ReportHD2> DanhSach2 = _dbContext.Database.SqlQuery<ReportHD2>(sql2).ToList();

                this.reportHD.LocalReport.ReportPath = @"D:\DoAnTotNghiep\DoAnTotNghiep\DoAnQLKhachSan\DoAnQLKhachSan\ReportTing\ReportHD.rdlc";
                
                var reportDatasoure = new ReportDataSource("DataSetHD", DanhSach);

                var reportDatasoure1 = new ReportDataSource("DataSetHD1", DanhSach1);

                var reportDatasoure2 = new ReportDataSource("DataSetHD2", DanhSach2);

                this.reportHD.LocalReport.DataSources.Clear();
                this.reportHD.LocalReport.DataSources.Add(reportDatasoure);

                this.reportHD.LocalReport.DataSources.Add(reportDatasoure1);

                this.reportHD.LocalReport.DataSources.Add(reportDatasoure2);

                this.reportHD.RefreshReport();
            }

        }

        private void reportHD_Load(object sender, EventArgs e)
        {

        }
    }
}
