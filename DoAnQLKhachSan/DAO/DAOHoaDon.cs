﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DAOHoaDon
    {
        DataSet dsHoaDon = new DataSet();
        dbConnectionData db = new dbConnectionData();

        //Lấy danh sách ID và TenLoaiNV gán vào combobox cbTenLoaiNV
        public void HienThiTenNV(ComboBox cboTenNV)
        {
            dsHoaDon = db.LayDanhSach("select ID, HoTen from NhanVien where HieuLuc=1");// truy vấn lên sql
            cboTenNV.DataSource = dsHoaDon.Tables[0];
            cboTenNV.DisplayMember = "HoTen";
            cboTenNV.ValueMember = "ID";
        }

        //public void HienThiTenKH(ComboBox cboTenKH)
        //{
        //    dsHoaDon = db.LayDanhSach("select ID, HoTen from KhachHang where HieuLuc=1");// truy vấn lên sql
        //    cboTenKH.DataSource = dsHoaDon.Tables[0];
        //    cboTenKH.DisplayMember = "HoTen";
        //    cboTenKH.ValueMember = "ID";
        //}

        public void HienThiTenKH(ComboBox cboSDT,TextBox txtTenKH)
        {
            DataSet dsKH = new DataSet();
            dsKH = db.LayDanhSach("select * from KhachHang");
            cboSDT.DataSource = dsKH.Tables[0];
            txtTenKH.DataBindings.Clear();
            txtTenKH.DataBindings.Add("Text", cboSDT.DataSource, "HoTen");

        }

        public void HienThiSDT(ComboBox cboSDT)
        {
            DataSet dsKH = new DataSet();
            dsKH = db.LayDanhSach("select ID,SDT from KhachHang");// truy vấn lên sql
            cboSDT.DataSource = dsKH.Tables[0];
            cboSDT.DisplayMember = "SDT";
            cboSDT.ValueMember = "ID";
        }

        public void HienThiMaPhong(ComboBox cboMaPhong)
        {

            dsHoaDon = db.LayDanhSach("select ID,SoPhong from Phong");// truy vấn lên sql
            cboMaPhong.DataSource = dsHoaDon.Tables[0];
            cboMaPhong.DisplayMember = "SoPhong";
            cboMaPhong.ValueMember = "ID";
        }

        public void HienThiTienPhong(ComboBox cboMaPhong,ComboBox cboHTT,Label lblTongTienPhong, int i)
        {
            DataSet dsPhong = new DataSet();
            dsPhong = db.LayDanhSach("select * from Phong");
            cboMaPhong.DataSource = dsPhong.Tables[0];
            if (i==0)
            {
                lblTongTienPhong.DataBindings.Clear();
                lblTongTienPhong.DataBindings.Add("Text", cboMaPhong.DataSource, "GiaThueNgay");
            }    
            else if(i==1)
            {
                lblTongTienPhong.DataBindings.Clear();
                lblTongTienPhong.DataBindings.Add("Text", cboMaPhong.DataSource, "GiaThueGio");
            }    
           
            
        }

        public DataTable TienPhong(int SoPhong)//rồi, đã xem xong 1 loạt thủ tục ở dal
                                                                     //đây là thủ tục sẽ dùng ở form đăng nhập, với điều kiện là trùng mã tài khoản và mật khẩu. ok?
        {
            name = new string[1];
            value = new object[1];

            name[0] = "@SoPhong"; value[0] = SoPhong;
          

            return db.LayDuLieuCoDK("TienPhong", name, value, 1);
        }



        //khai báo 2 mảng để truyền tên tham số và giá trị tham số vào stored procedures
        string[] name = { };
        object[] value = { };

        //phương thức này gọi đến phương thức LayduLieu ở dbConnectionData để lấy dữ liệu
        public DataTable HoaDon_Select()
        {
            return db.Laydulieu("HoaDon_Select");
        }

        //phương thức này gọi đến phương thức ThucHien ở dbConnectionData để thêm dữ liệu
        public int HoaDon_Them(int ID, string MaHD, string ID_NV, string ID_KH, string ID_Phong, string NgayLap, string NgayDen, string NgayDi, int HinhThucThue, int TTPhong, string TTDV, int TT, string GhiChu, bool TToan, bool HieuLuc)
        {
            name = new string[15];
            value = new object[15];
            name[0] = "@ID"; value[0] = ID;
            name[1] = "@MaHD"; value[1] = MaHD;
            name[2] = "@ID_NV"; value[2] = ID_NV;
            name[3] = "@ID_KH"; value[3] = ID_KH;
            name[4] = "@ID_Phong"; value[4] = ID_Phong;
            name[5] = "@NgayLap"; value[5] = NgayLap;
            name[6] = "@NgayDen"; value[6] = NgayDen;
            name[7] = "@NgayDi"; value[7] = NgayDi;
            name[8] = "@HinhThucThue"; value[8] = HinhThucThue;
            name[9] = "@TongTienPhong"; value[9] = TTPhong;
            name[10] = "@TongTienDV"; value[10] = TTDV;
            name[11] = "@TongTien"; value[11] = TT;
            name[12] = "@GhiChu"; value[12] = GhiChu;
            name[13] = "@ThanhToan"; value[13] = TToan;
            name[14] = "@HieuLuc"; value[14] = HieuLuc;
            return db.ThucHien("HoaDon_Them", name, value, 15);
        }

        public int HoaDon_XacNhanDatPhong(int ID, string MaHD, string ID_NV, string ID_KH, string ID_Phong, string NgayLap, string NgayDen, string NgayDi, int HinhThucThue, int TTPhong, int TT,bool ThanhToan, bool HieuLuc)
        {
            name = new string[13];
            value = new object[13];
            name[0] = "@ID"; value[0] = ID;
            name[1] = "@MaHD"; value[1] = MaHD;
            name[2] = "@ID_NV"; value[2] = ID_NV;
            name[3] = "@ID_KH"; value[3] = ID_KH;
            name[4] = "@ID_Phong"; value[4] = ID_Phong;
            name[5] = "@NgayLap"; value[5] = NgayLap;
            name[6] = "@NgayDen"; value[6] = NgayDen;
            name[7] = "@NgayDi"; value[7] = NgayDi;
            name[8] = "@HinhThucThue"; value[8] = HinhThucThue;
            name[9] = "@TongTienPhong"; value[9] = TTPhong;
            name[10] = "@TongTien"; value[10] = TT;
            name[11] = "@ThanhToan"; value[11] = ThanhToan;
            name[12] = "@HieuLuc"; value[12] = HieuLuc;
            return db.ThucHien("HoaDon_Them", name, value, 13);
        }

        //update
        public int HoaDon_CapNhat(int ID, string MaHD, string ID_NV, string ID_KH, string ID_Phong, string NgayLap, string NgayDen, string NgayDi, int HinhThucThue, string TTPhong, string TTDV, string TT, string GhiChu, bool TToan, bool HieuLuc)
        {
            name = new string[15];
            value = new object[15];
            name[0] = "@ID"; value[0] = ID;
            name[1] = "@MaHD"; value[1] = MaHD;
            name[2] = "@ID_NV"; value[2] = ID_NV;
            name[3] = "@ID_KH"; value[3] = ID_KH;
            name[4] = "@ID_Phong"; value[4] = ID_Phong;
            name[5] = "@NgayLap"; value[5] = NgayLap;
            name[6] = "@NgayDen"; value[6] = NgayDen;
            name[7] = "@NgayDi"; value[7] = NgayDi;
            name[8] = "@HinhThucThue"; value[8] = HinhThucThue;
            name[9] = "@TongTienPhong"; value[9] = TTPhong;
            name[10] = "@TongTienDV"; value[10] = TTDV;
            name[11] = "@TongTien"; value[11] = TT;
            name[12] = "@GhiChu"; value[12] = GhiChu;
            name[13] = "@ThanhToan"; value[13] = TToan;
            name[14] = "@HieuLuc"; value[14] = HieuLuc;
            return db.ThucHien("HoaDon_CapNhat", name, value, 15);
        }

        public int HoaDon_CapNhatChuyenPhong(int ID,string sophong,int TTP,int TongTien)
        {
            name = new string[4];
            value = new object[4];
            name[0] = "@ID"; value[0] = ID;
            name[1] = "@ID_Phong"; value[1] = sophong;
            name[2] = "@TongTienPhong";value[2] = TTP;
            name[3] = "@TongTien"; value[3] = TongTien;
            return db.ThucHien("HoaDon_CapNhatChuyenPhong", name, value, 4);
        }

        public int HoaDon_Xoa(int ID, bool HieuLuc)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@ID"; value[0] = ID;
            name[1] = "@HieuLuc"; value[1] = HieuLuc;
            return db.ThucHien("HoaDon_Xoa", name, value, 2);
        }
    }
}
