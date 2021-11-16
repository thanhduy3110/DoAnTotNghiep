using DevComponents.Editors.DateTimeAdv;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DAOPhongDaDat
    {
        dbConnectionData db = new dbConnectionData();
        DataSet ds = new DataSet();
        DataSet dsPDD = new DataSet();
        string[] name = { };
        object[] value = { };
        public void HienThiMaPhong(ComboBox cboMaPhong,TextBox txtSoKhach,TextBox txtTenLP)
        {
            ds = db.LayDanhSach("select Phong.ID as ID , SoPhong , SoKhach,TenLoaiPhong from Phong, LoaiPhong where Phong.ID_LoaiPhong = LoaiPhong.ID and( Phong.ConTrong=0 or Phong.ConTrong=2)");// truy vấn lên sql
            cboMaPhong.DataSource = ds.Tables[0];
            cboMaPhong.DisplayMember = "sophong";
            cboMaPhong.ValueMember = "id";
            txtSoKhach.DataBindings.Add("Text", cboMaPhong.DataSource, "sokhach");
            txtTenLP.DataBindings.Add("Text", cboMaPhong.DataSource, "TenLoaiPhong");
        }

        public void HienThiID_PDD(ComboBox cboID_PDD, DateTimeInput dtpNgayDen, DateTimeInput dtpNgayDi)
        {
            ds = db.LayDanhSach("select * from PhieuDatPhong");// truy vấn lên sql
            cboID_PDD.DataSource = ds.Tables[0];
            cboID_PDD.DisplayMember = "id";
            cboID_PDD.ValueMember = "id";
            dtpNgayDen.DataBindings.Add("Text", cboID_PDD.DataSource, "ngayden");
            dtpNgayDi.DataBindings.Add("Text", cboID_PDD.DataSource, "ngaydi");
        }

        public void HienThiDanhSach(string sTimKiem, DataGridView d)
        {
            dsPDD = db.LayDanhSach("select PDD.ID as ID,PDP.ID as ID_PhieuDP,KH.HoTen as HoTenKH,SDT,PDP.HinhThucThue as HTT,Phong.GiaThueGio as GTG,Phong.GiaThueNgay as GTN,ID_KH,Phong.SoPhong as SoPhong,PDP.NgayDen as NgayDen,PDP.NgayDi as NgayDi,Phong.ID as IDPHONG from KhachHang KH,PhieuDatPhong PDP,PhongDaDat PDD,Phong  where KH.ID=PDP.ID_KH and PDD.ID_PhieuDP=PDP.ID and Phong.ID=PDD.ID_Phong and (KH.HoTen like '%" + sTimKiem + "%' or SDT like '%" + sTimKiem + "%' or SoPhong like '%" + sTimKiem + "%')");
            d.DataSource = dsPDD.Tables[0];
        }

        //public void HienThiSDT(ComboBox cboSDT)
        //{
        //    DataSet dsKH = new DataSet();
        //    dsKH = db.LayDanhSach("select SDT,ID_KH from KhachHang KH ,PhieuDatPhong where KH.ID=ID_KH");// truy vấn lên sql
        //    cboSDT.DataSource = dsKH.Tables[0];
        //    cboSDT.DisplayMember = "SDT";
        //    cboSDT.ValueMember = "ID_KH";
        //}


        public void HienThiSDT(ComboBox cboTenKH)
        {
            DataSet dsKH = new DataSet();
            dsKH = db.LayDanhSach("select PDP.ID as ID_PhieuDP,PDP.HinhThucThue as HTT,KH.HoTen as HoTenKH,SDT, PDP.NgayDen as NgayDen, PDP.NgayDi as NgayDi ,PDP.GhiChu as GhiChu from PhieuDatPhong PDP, KhachHang KH where KH.ID = PDP.ID_KH and PDP.DaXuLy=0");// truy vấn lên sql
            cboTenKH.DataSource = dsKH.Tables[0];
            cboTenKH.DisplayMember = "HoTenKH";
            cboTenKH.ValueMember = "ID_PhieuDP";
            
        }


       
        //public DataTable PhongDaDat_HienThiDS()
        //{
        //    return db.Laydulieu("PhongDaDat_HienThiDS");
        //}

        public DataTable PhongDaDat_Select()
        {
            return db.Laydulieu("PhongDaDat_Select");
        }

        public DataTable Phong_HienTTPhong(string SoPhong)//rồi, đã xem xong 1 loạt thủ tục ở dal
                                                                     //đây là thủ tục sẽ dùng ở form đăng nhập, với điều kiện là trùng mã tài khoản và mật khẩu. ok?
        {
            name = new string[1];
            value = new object[1];

            name[0] = "@SoPhong"; value[0] = SoPhong;
           

            return db.LayDuLieuCoDK("Phong_HienTTPhong", name, value, 1);
        }

        public DataTable Phong_HienTMaPhong(string SoPhong)//rồi, đã xem xong 1 loạt thủ tục ở dal
                                                          //đây là thủ tục sẽ dùng ở form đăng nhập, với điều kiện là trùng mã tài khoản và mật khẩu. ok?
        {
            name = new string[1];
            value = new object[1];

            name[0] = "@SoPhong"; value[0] = SoPhong;


            return db.LayDuLieuCoDK("Phong_HienTMaPhong", name, value, 1);
        }

        public DataTable PhongDaDat_HTTenKH(string SDT)//rồi, đã xem xong 1 loạt thủ tục ở dal
                                                          //đây là thủ tục sẽ dùng ở form đăng nhập, với điều kiện là trùng mã tài khoản và mật khẩu. ok?
        {
            name = new string[1];
            value = new object[1];

            name[0] = "@SDT"; value[0] = SDT;


            return db.LayDuLieuCoDK("PhongDaDat_HTTenKH", name, value, 1);
        }
        public DataTable PhongDaDat_TimDSPhongDD(string NgayBD,string NgayKT,int GocNhin,bool BonTam)//rồi, đã xem xong 1 loạt thủ tục ở dal
                                                          //đây là thủ tục sẽ dùng ở form đăng nhập, với điều kiện là trùng mã tài khoản và mật khẩu. ok?
        {
            name = new string[4];
            value = new object[4];

            name[0] = "@NgayDen"; value[0] = NgayBD;
            name[1] = "@NgayDi"; value[1] = NgayKT;
            name[2] = "@GocNhin"; value[2] = GocNhin;
            name[3] = "@BonTam"; value[3] = BonTam;


            return db.LayDuLieuCoDK("PhongDaDat_TimDSPhongDD", name, value, 4);
        }


        public DataTable PhongDaDat_TimDSPhongCD(int GocNhin, bool BonTam)//rồi, đã xem xong 1 loạt thủ tục ở dal
                                                                                                        //đây là thủ tục sẽ dùng ở form đăng nhập, với điều kiện là trùng mã tài khoản và mật khẩu. ok?
        {
            name = new string[2];
            value = new object[2];

            
            name[0] = "@GocNhin"; value[0] = GocNhin;
            name[1] = "@BonTam"; value[1] = BonTam;


            return db.LayDuLieuCoDK("PhongDaDat_TimDSPhongCD", name, value, 2);
        }

        public int PhongDaDat_Them( string ID_PhieuDP, string ID_Phong, string NgayDen, string NgayDi)
        {
            name = new string[4];
            value = new object[4];

            //name[0] = "@ID"; value[0] = ID;
            name[0] = "@ID_PhieuDP"; value[0] = ID_PhieuDP;
            name[1] = "@ID_Phong"; value[1] = ID_Phong;
            name[2] = "@NgayDen"; value[2] = NgayDen;
            name[3] = "@NgayDi"; value[3] = NgayDi;
            return db.ThucHien("PhongDaDat_Them", name, value, 4);
        }
        public int PhongDaDat_CapNhat(string ID, string ID_PhieuDP, string ID_Phong, string NgayDen, string NgayDi)
        {
            name = new string[5];
            value = new object[5];

            name[0] = "@ID"; value[0] = ID;
            name[1] = "@ID_PhieuDP"; value[1] = ID_PhieuDP;
            name[2] = "@ID_Phong"; value[2] = ID_Phong;
            name[3] = "@NgayDen"; value[3] = NgayDen;
            name[4] = "@NgayDi"; value[4] = NgayDi;
            return db.ThucHien("PhongDaDat_CapNhat", name, value, 5);
        }

        public int PhongDaDat_Xoa(string ID)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@ID"; value[0] = ID;
            return db.ThucHien("PhongDaDat_Xoa", name, value, 1);
        }


    }
}
