using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace DoAnQLKhachSan
{
    public partial class frmHoaDon : Form
    {
        private string HoTen="";
        private int IDNV;
      
        public frmHoaDon()
        {
            InitializeComponent();
        }
        public frmHoaDon(int ID,string TenNV)
        {
            this.IDNV = ID;
            this.HoTen = TenNV;
            InitializeComponent();
        }
        BUSHoaDon bHD = new BUSHoaDon();
        BUSCTHD bCTHD = new BUSCTHD();
        BUSDichVu bDV = new BUSDichVu();
        BUSPhong bPhong = new BUSPhong();
        DataSet DsHD = new DataSet();
        bool flag = false;

        //void Tang_ID()
        //{
        //    int count = 0;
        //    count = dgvDSHD.Rows.Count;
        //    string chuoi = "";
        //    int chuoi2 = 0;
        //    if (count <= 1)
        //    {
        //        txtID.Text = "0";
        //    }
        //    else
        //    {
        //        chuoi = Convert.ToString(dgvDSHD.Rows[count - 2].Cells[0].Value);
        //        chuoi2 = Convert.ToInt32((chuoi.Remove(0, 0)));
        //        if (chuoi2 + 1 < 10)
        //        {
        //            txtID.Text = "" + (chuoi2 + 1).ToString();
        //        }
        //        else if (chuoi2 + 1 < 100)
        //        {
        //            txtID.Text = "" + (chuoi2 + 1).ToString();
        //        }

        //    }
        //}

        string PhatSinhMaTuDong()
        {
            string MaHD = "";
            int dem = bHD.HoaDon_Select().Rows.Count+1;
            if (dem < 10)
            {
                MaHD = "HD00" + dem.ToString();
            }
            else
            {
                MaHD = "HD0" + dem.ToString();
            }

            return MaHD;
        }

        void clear_textbox()
        {

            txtMaHD.Text = PhatSinhMaTuDong();
            txtSDT.Text = "";
            cboMaPhong.Text = "";
            dtpNgayDen.Text = "";
            dtpNgayDi.Text = "";
          
            rtxtGhiChu.Text = "";
            lblTongTienPhong.Text = "0";
            lblTongTienDV.Text = "0";
            lblTongTien.Text = "0";
           
        }

        void clear_textboxThemPhong()
        {

            txtMaHD.Text = PhatSinhMaTuDong();
            rtxtGhiChu.Text = "";
            lblTongTienPhong.Text = "0";
            lblTongTienDV.Text = "0";
            lblTongTien.Text = "0";

        }

        void xulychucnang(Boolean t)
        {
            btnThem.Enabled = t;
            btnSua.Enabled = t;
            btnXoa.Enabled = t;
        }

        void xulytextbox(Boolean t)
        {
            
            rtxtGhiChu.ReadOnly = t;
        }
        int iIdInHD;
        string InMaHD;
        public void hienthi_textbox(int numrow)
        {
            iIdInHD = int.Parse(dgvDSHD.Rows[numrow].Cells[0].Value.ToString());
            //InMaHD = dgvDSHD.Rows[numrow].Cells[1].Value.ToString();
            //txtID.Text = dgvDSHD.Rows[numrow].Cells[0].Value.ToString();
            //txtID_HD.Text = dgvDSHD.Rows[numrow].Cells[0].Value.ToString();
            txtMaHD.Text = dgvDSHD.Rows[numrow].Cells[1].Value.ToString();
            txtTenNV.Text = dgvDSHD.Rows[numrow].Cells[2].Value.ToString();
            cboTenKH.Text = dgvDSHD.Rows[numrow].Cells[3].Value.ToString();
            cboMaPhong.Text = dgvDSHD.Rows[numrow].Cells[4].Value.ToString();
            dtpNgayDen.Text = dgvDSHD.Rows[numrow].Cells[6].Value.ToString();
            dtpNgayDi.Text = dgvDSHD.Rows[numrow].Cells[7].Value.ToString();
            lblTongTienPhong.Text = dgvDSHD.Rows[numrow].Cells[9].Value.ToString();
            lblTongTienDV.Text = dgvDSHD.Rows[numrow].Cells[10].Value.ToString();
            lblTongTien.Text = dgvDSHD.Rows[numrow].Cells[11].Value.ToString();
            rtxtGhiChu.Text = dgvDSHD.Rows[numrow].Cells[12].Value.ToString();
            txtSDT.Text = dgvDSHD.Rows[numrow].Cells[17].Value.ToString();

            //cboHinhThucThue.Text = dgvDSHD.Rows[numrow].Cells[8].Value.ToString();
           

            string TT = dgvDSHD.Rows[numrow].Cells[13].Value.ToString();
            if (TT == "Đã thanh toán")
            {
                chkThanhToan.Checked = true;
            }
            else
            {
                chkThanhToan.Checked = false;
            }


            string HL = dgvDSHD.Rows[numrow].Cells[14].Value.ToString();

            if (HL == "Còn hiệu lực")
            {
                chkHL.Checked = true;
            }
            else
            {
                chkHL.Checked = false;
            }

            string HTT  = dgvDSHD.Rows[numrow].Cells[8].Value.ToString();

            if (HTT == "Thuê theo ngày")
            {
                chkThueTheoNgay.Checked = true;
            }
            else
            {
                chkThueTheoNgay.Checked = false;
            }
        }


       
            
  

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (flag == false)
            {
                txtSDT.ReadOnly = false;
                clear_textbox();
                xulytextbox(false);
                chkHL.Checked = true;
                chkThueTheoNgay.Checked = true;
                cboMaPhong.SelectedIndex = 0;
                chkThanhToan.Checked = false;
                flag = true;
            }
            else if (flag == true)
            {

                if (dtpNgayDen.Value.Day < DateTime.Now.Day || dtpNgayDen.Value.Month < DateTime.Now.Month || dtpNgayDen.Value.Year < DateTime.Now.Year || dtpNgayDi.Value.Day < DateTime.Now.Day || dtpNgayDi.Value.Month < DateTime.Now.Month || dtpNgayDi.Value.Year < DateTime.Now.Year)
                {
                    MessageBox.Show("Thời gian đến không được nhỏ hơn ngày hiện tại");
                    return;
                }

                if (dtpNgayDen.Value.Month == dtpNgayDi.Value.Month && dtpNgayDen.Value.Year == dtpNgayDi.Value.Year)
                {
                    if (dtpNgayDen.Value.Day > dtpNgayDi.Value.Day|| dtpNgayDen.Value.Day == dtpNgayDi.Value.Day)
                    {
                        MessageBox.Show("Lỗi thời gian");
                        return;
                    }

                }
                 if (dtpNgayDen.Value.Month > dtpNgayDi.Value.Month || dtpNgayDen.Value.Year > dtpNgayDi.Value.Year)
                {
                    MessageBox.Show("Lỗi thời gian");
                    return;
                }

               else {
                    if (dgvDSHD.Rows.Count > 0)
                    {
                        for (int i = 0; i < dgvDSHD.Rows.Count - 1; i++)
                        {
                            if (cboMaPhong.Text == dgvDSHD.Rows[i].Cells[4].Value.ToString())
                            {

                                string ngden = dgvDSHD.Rows[i].Cells[6].Value.ToString();
                                int ngayden = Int32.Parse(string.Format("{0:dd}", Convert.ToDateTime(ngden)));
                                int thangden = Int32.Parse(string.Format("{0:MM}", Convert.ToDateTime(ngden)));
                                int namden = Int32.Parse(string.Format("{0:yyyy}", Convert.ToDateTime(ngden)));

                                string ngdi = dgvDSHD.Rows[i].Cells[7].Value.ToString();
                                int ngaydi = Int32.Parse(string.Format("{0:dd}", Convert.ToDateTime(ngdi)));
                                int thangdi = Int32.Parse(string.Format("{0:MM}", Convert.ToDateTime(ngdi)));
                                int namdi = Int32.Parse(string.Format("{0:yyyy}", Convert.ToDateTime(ngdi)));

                                if (KTNgayDen(ngayden, thangden, namden, dtpNgayDen.Value.Day, dtpNgayDen.Value.Month, dtpNgayDen.Value.Year) == true)
                                {

                                    if (KTNgayDen(ngayden, thangden, namden, dtpNgayDi.Value.Day, dtpNgayDi.Value.Month, dtpNgayDi.Value.Year) == false)
                                    {
                                        MessageBox.Show("Phòng này đã đặt rồi ");
                                        return;
                                    }

                                }
                                else if (KTNgayDi(ngaydi, thangdi, namdi, dtpNgayDen.Value.Day, dtpNgayDen.Value.Month, dtpNgayDen.Value.Year) == true)
                                {

                                    if (KTNgayDi(ngaydi, thangdi, namdi, dtpNgayDi.Value.Day, dtpNgayDi.Value.Month, dtpNgayDi.Value.Year) == false)
                                    {
                                        MessageBox.Show("Phòng này đã đặt rồi ");
                                        return;
                                    }
                                }
                                else if (KTNgayDen(ngayden, thangden, namden, dtpNgayDen.Value.Day, dtpNgayDen.Value.Month, dtpNgayDen.Value.Year) == false)
                                {
                                    if (KTNgayDen(ngayden, thangden, namden, dtpNgayDi.Value.Day, dtpNgayDi.Value.Month, dtpNgayDi.Value.Year) == false)
                                    {
                                        MessageBox.Show("Phòng này đã đặt rồi ");
                                        return;
                                    }

                                }


                            }
                        }
                    }    


                        bool HieuLuc, ThanhToan,HTT;
                    if (chkHL.Checked == true)
                    {
                        HieuLuc = true;
                    }
                    else
                    {
                        HieuLuc = false;
                    }

                    if (chkThanhToan.Checked == true)
                    {
                        ThanhToan = true;
                    }
                    else
                    {
                        ThanhToan = false;
                    }

                    
                    int ID = bHD.HoaDon_Select().Rows.Count + 1;


                    if (chkThueTheoNgay.Checked ==true)
                    {

                        TienPhong = Int32.Parse(bHD.TienPhong(Int32.Parse(cboMaPhong.Text)).Rows[0][0].ToString());
                        TongTienPhong = TienPhong * (ThoiGianThue(GioThue) / 24);
                    }
                    //else
                    //{
                    //    TienPhong = Int32.Parse(bHD.TienPhong(Int32.Parse(cboMaPhong.Text)).Rows[0][1].ToString());
                    //    TongTienPhong = TienPhong * (ThoiGianThue(GioThue));
                    //}
                    
                    bPhong.phong_CNConTrong(Int32.Parse(cboMaPhong.SelectedValue.ToString()), 1);
                    bHD.HoaDon_Them(ID, txtMaHD.Text, IDNV.ToString(), cboTenKH.SelectedValue.ToString(), cboMaPhong.SelectedValue.ToString(), Convert.ToDateTime(DateTime.Now).ToString("yyyy/MM/dd hh:mm"), Convert.ToDateTime(dtpNgayDen.Text).ToString("yyyy/MM/dd hh:mm"), Convert.ToDateTime(dtpNgayDi.Text).ToString("yyyy/MM/dd hh:mm"), true, TongTienPhong, lblTongTienDV.Text, TongTienPhong, rtxtGhiChu.Text, ThanhToan, HieuLuc);

                    MessageBox.Show("Thêm thành công ");
                    txtSDT.ReadOnly = true;
                    flag = false;
                    dgvDSHD.DataSource = bHD.HoaDon_Select();


                }


            }

        }
        int GioThue,TongTienPhong,TienPhong;
        public bool KTNgayDen(int ngay, int thang, int nam, int ngay1, int thang1, int nam1)
        {
            if (thang1 == thang && nam1 == nam && ngay > ngay1)
            {
                //MessageBox.Show("KT Đúng Ngay đi  vs ngay đến trong data");
                return true;
            }
            //else if (dtpNgayDi.Value.Month < thang && dtpNgayDi.Value.Year == nam)
            //{
            //    return true;
            //}
            else
            {
                //MessageBox.Show("KT Sai Ngay đi  vs ngay đến trong data");
                return false;
            }

        }

        public bool KTNgayDi(int ngay, int thang, int nam, int ngay1, int thang1, int nam1)
        {
            if (thang1 == thang && nam1 == nam && ngay < ngay1)
            {
                //MessageBox.Show("KT Đúng Ngay đến  vs ngay đi trong data");
                return true;
            }
            //else if (dtpNgayDen.Value.Month > thang && dtpNgayDen.Value.Year == nam)
            //{
            //    return true;
            //}
            else
            {
                //MessageBox.Show("KT Sai Ngay đến  vs ngay đi trong data");
                return false;
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            
            if(flag==false)
            {
                xulytextbox(false);
                flag = true;
                panel1.Enabled = false;
                panel2.Enabled = false;
                panel3.Enabled = false;
                panel4.Enabled = false;
            }    
            else if (flag == true)
            {

                bool HieuLuc, ThanhToan,HTT;
                if (chkHL.Checked == true)
                {
                    HieuLuc = true;
                }
                else
                {
                    HieuLuc = false;
                }

                if (chkThanhToan.Checked == true)
                {
                    ThanhToan = true;
                }
                else
                {
                    ThanhToan = false;
                }
               

                if (chkThueTheoNgay.Checked==true)
                {
                    TienPhong = Int32.Parse(bHD.TienPhong(Int32.Parse(cboMaPhong.Text)).Rows[0][0].ToString());
                    TongTienPhong = TienPhong * (ThoiGianThue(GioThue) / 24) ;
                }
                //else
                //{
                //    TienPhong = Int32.Parse(bHD.TienPhong(Int32.Parse(cboMaPhong.Text)).Rows[0][1].ToString());
                //    TongTienPhong = TienPhong * (ThoiGianThue(GioThue));
                //}
                lblTongTienPhong.Text = TongTienPhong.ToString();
                lblTongTien.Text = (TongTienPhong + Int32.Parse(lblTongTienDV.Text)).ToString();


                bHD.HoaDon_CapNhat(ID_HD, txtMaHD.Text, ID_NV.ToString(), ID_KH.ToString(), cboMaPhong.SelectedValue.ToString(), Convert.ToDateTime(ngaylap).ToString("yyyy/MM/dd hh:mm"), Convert.ToDateTime(dtpNgayDen.Text).ToString("yyyy/MM/dd hh:mm"), Convert.ToDateTime(dtpNgayDi.Text).ToString("yyyy/MM/dd hh:mm"), true, lblTongTienPhong.Text, lblTongTienDV.Text, lblTongTien.Text, rtxtGhiChu.Text, ThanhToan, HieuLuc);
                MessageBox.Show("Sữa thành công ");
                panel1.Enabled = true;
                panel2.Enabled = true;
                panel3.Enabled = true;
                panel4.Enabled = true;
                flag = false;
                dgvDSHD.DataSource = bHD.HoaDon_Select();
            }
        }

        

        int coCTHD, TongID;
        string gangID;
        private void btnThemCTHD_Click(object sender, EventArgs e)
        {
            
            //bCTHD.TongID(txtID_CTHD);
            
            TongID = bCTHD.CTHD_Select().Rows.Count + 1;
            //txtID_CTHD.Text = TongID.ToString();
            txtSoLuong.Text = "";
            cboTenDV.Text = "";
            coCTHD = 1;
        }

        
        private void btnLuuCTHD_Click(object sender, EventArgs e)
        {
            int flagg = 0, vitri = 0;
            int TienDV = 0;
            for (int i = 0; i < dgvDSCTHD.Rows.Count - 1; i++)
            {
                //Kiểm tra xem trong datagridview có tên dịch vụ nào đã nhập vào chưa.
                if (cboTenDV.Text == dgvDSCTHD.Rows[i].Cells["TenDV"].Value.ToString())
                {
                    flagg = 1;    // nếu có tên dv nào thì gán flag =1
                    vitri = i;
                    gangID = dgvDSCTHD.Rows[i].Cells[0].Value.ToString();
                    break;
                }
            }

            if (coCTHD == 1)
            {
                bool HieuLuc, ThanhToan;
                if (chkHL.Checked == true)
                {
                    HieuLuc = true;
                }
                else
                {
                    HieuLuc = false;
                }

                if (chkThanhToan.Checked == true)
                {
                    ThanhToan = true;
                }
                else
                {
                    ThanhToan = false;
                }
                if (flagg == 1)
                {

                    int SLT = (Int32.Parse(bDV.DV_Select(Int32.Parse(cboTenDV.SelectedValue.ToString())).Rows[0][1].ToString()) - int.Parse(txtSoLuong.Text));
                    bDV.dichvu_capnhatSLTon(cboTenDV.SelectedValue.ToString(), SLT);
                    //Tăng số lượng dịch vụ cùng tên lên
                    int soluong = int.Parse(txtSoLuong.Text) + int.Parse(dgvDSCTHD.Rows[vitri].Cells[3].Value.ToString());
                    bCTHD.CTHD_CongDonSL(gangID, soluong.ToString());
                    MessageBox.Show("Cập nhật số lượng dịch vụ thành công ");
                    bCTHD.HienThiDSCTHD(dgvDSCTHD, ID_HD);
                    for (int i = 0; i < dgvDSCTHD.Rows.Count - 1; i++)
                    {
                        int SL = Int32.Parse(dgvDSCTHD.Rows[i].Cells[3].Value.ToString());
                        int DG = Int32.Parse(dgvDSCTHD.Rows[i].Cells[4].Value.ToString());
                        TienDV = TienDV + (SL * DG);
                    }
                    lblTongTienDV.Text = TienDV.ToString();
                    bHD.HoaDon_CapNhat(ID_HD, txtMaHD.Text, ID_NV.ToString(), ID_KH.ToString(), cboMaPhong.SelectedValue.ToString(), Convert.ToDateTime(ngaylap).ToString("yyyy-MM-dd"), Convert.ToDateTime(dtpNgayDen.Text).ToString("yyyy-MM-dd"), Convert.ToDateTime(dtpNgayDi.Text).ToString("yyyy-MM-dd"), true, lblTongTienPhong.Text, lblTongTienDV.Text, lblTongTien.Text, rtxtGhiChu.Text, ThanhToan, HieuLuc); lblTongTien.Text = (Int32.Parse(lblTongTienPhong.Text) + Int32.Parse(lblTongTienDV.Text)).ToString();
                    
                    dgvDSHD.DataSource = bHD.HoaDon_Select();
                }    
                else
                {
                    int SLT = (Int32.Parse(bDV.DV_Select(Int32.Parse(cboTenDV.SelectedValue.ToString())).Rows[0][1].ToString()) - int.Parse(txtSoLuong.Text));
                    bDV.dichvu_capnhatSLTon(cboTenDV.SelectedValue.ToString(), SLT);
                    bCTHD.CTHD_Them(TongID, ID_HD, cboTenDV.SelectedValue.ToString(), txtSoLuong.Text, lblDonGia.Text, Convert.ToDateTime(DateTime.Now).ToString("yyyy/MM/dd hh:mm"));
                    MessageBox.Show("Thêm dịch vụ thành công ");
                    bCTHD.HienThiDSCTHD(dgvDSCTHD, ID_HD);
                    for (int i = 0; i < dgvDSCTHD.Rows.Count - 1; i++)
                    {
                        int SL = Int32.Parse(dgvDSCTHD.Rows[i].Cells[3].Value.ToString());
                        int DG = Int32.Parse(dgvDSCTHD.Rows[i].Cells[4].Value.ToString());
                        TienDV = TienDV + (SL * DG);
                    }
                    lblTongTienDV.Text = TienDV.ToString();
                    lblTongTien.Text = (Int32.Parse(lblTongTienPhong.Text) + Int32.Parse(lblTongTienDV.Text)).ToString();
                    bHD.HoaDon_CapNhat(ID_HD, txtMaHD.Text, ID_NV.ToString(), ID_KH.ToString(), cboMaPhong.SelectedValue.ToString(), Convert.ToDateTime(ngaylap).ToString("yyyy-MM-dd"), Convert.ToDateTime(dtpNgayDen.Text).ToString("yyyy-MM-dd"), Convert.ToDateTime(dtpNgayDi.Text).ToString("yyyy-MM-dd"), true, lblTongTienPhong.Text, lblTongTienDV.Text, lblTongTien.Text, rtxtGhiChu.Text, ThanhToan, HieuLuc);
                    
                    dgvDSHD.DataSource = bHD.HoaDon_Select();
                }

            }
           
            if(coCTHD == 2)
            {
                bool HieuLuc, ThanhToan;
                if (chkHL.Checked == true)
                {
                    HieuLuc = true;
                }
                else
                {
                    HieuLuc = false;
                }

                if (chkThanhToan.Checked == true)
                {
                    ThanhToan = true;
                }
                else
                {
                    ThanhToan = false;
                }
                bCTHD.CTHD_CapNhat(ID_CTHD_CellClick,ID_HD, cboTenDV.SelectedValue.ToString(), txtSoLuong.Text, lblDonGia.Text, Convert.ToDateTime(ThoiGian).ToString("yyyy-MM-dd"));
                MessageBox.Show("Sữa dịch vụ thành công ");
                bCTHD.HienThiDSCTHD(dgvDSCTHD, ID_HD);
                for (int i = 0; i < dgvDSCTHD.Rows.Count - 1; i++)
                {
                    int SL = Int32.Parse(dgvDSCTHD.Rows[i].Cells[3].Value.ToString());
                    int DG = Int32.Parse(dgvDSCTHD.Rows[i].Cells[4].Value.ToString());
                    TienDV = TienDV + (SL * DG);
                }
                lblTongTienDV.Text = TienDV.ToString();
                lblTongTien.Text = (Int32.Parse(lblTongTienPhong.Text) + Int32.Parse(lblTongTienDV.Text)).ToString();
                bHD.HoaDon_CapNhat(ID_HD, txtMaHD.Text, ID_NV.ToString(), ID_KH.ToString(), cboMaPhong.SelectedValue.ToString(), Convert.ToDateTime(ngaylap).ToString("yyyy-MM-dd"), Convert.ToDateTime(dtpNgayDen.Text).ToString("yyyy-MM-dd"), Convert.ToDateTime(dtpNgayDi.Text).ToString("yyyy-MM-dd"), true, lblTongTienPhong.Text, lblTongTienDV.Text, lblTongTien.Text, rtxtGhiChu.Text, ThanhToan, HieuLuc);
                dgvDSHD.DataSource = bHD.HoaDon_Select();
            }    
        }

        public void reload()
        {
            dgvDSHD.DataSource = bHD.HoaDon_Select();
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {

            chkThueTheoNgay.Enabled = false;
            txtTenNV.Text = this.HoTen;
            txtTenNV.ReadOnly = true;
            txtMaHD.ReadOnly = true;
            txtSDT.ReadOnly = true;
            btnChuyenPhong.Enabled = false;
            xulychucnang(true);
            xulytextbox(true);
            bHD.HienThiTenKH(cboTenKH);
            //bHD.HienThiTenKH(cboTenKH, txtSDT);
            bCTHD.HienThiTenDV(cboTenDV, lblDonGia);
            bHD.HienThiMaPhong(cboMaPhong);
            dgvDSHD.DataSource = bHD.HoaDon_Select();
        }

        int ID_HD,ID_NV,ID_KH,ID_Phong;
        string ngaylap,MaHD,NgayDi,NgayDen,nNgayDi,nNgayDen;
        private void dgvDSHD_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btnChuyenPhong.Enabled = true;
            try
            {
                int vt = dgvDSHD.CurrentCell.RowIndex;
                hienthi_textbox(vt);
                ID_HD = Int32.Parse(dgvDSHD.Rows[vt].Cells[0].Value.ToString());
                bCTHD.HienThiDSCTHD(dgvDSCTHD, ID_HD);
                
                ngaylap =  dgvDSHD.Rows[vt].Cells[5].Value.ToString();
                InMaHD= dgvDSHD.Rows[vt].Cells[1].Value.ToString();
                MaHD = dgvDSHD.Rows[vt].Cells[1].Value.ToString();
                NgayDen = dgvDSHD.Rows[vt].Cells[6].Value.ToString();
                NgayDi = dgvDSHD.Rows[vt].Cells[7].Value.ToString();
                nNgayDen = dgvDSHD.Rows[vt].Cells[6].Value.ToString();
                nNgayDi = dgvDSHD.Rows[vt].Cells[7].Value.ToString();
                ID_NV = Int32.Parse(dgvDSHD.Rows[vt].Cells[15].Value.ToString());
                ID_KH=Int32.Parse(dgvDSHD.Rows[vt].Cells[16].Value.ToString());
                ID_Phong= Int32.Parse(dgvDSHD.Rows[vt].Cells[18].Value.ToString());
                TienDV= Int32.Parse(dgvDSHD.Rows[vt].Cells[10].Value.ToString());
            }
            catch(Exception ex)
            {
               
            }
           
           
        }

        private void btnSuaCTHD_Click(object sender, EventArgs e)
        {
            coCTHD = 2;
        }

        public void hienthitextbox(int numrow)
        {
            
            //txtID_HD.Text = dgvDSCTHD.Rows[numrow].Cells[1].Value.ToString();
            cboTenDV.Text = dgvDSCTHD.Rows[numrow].Cells[2].Value.ToString();
            txtSoLuong.Text = dgvDSCTHD.Rows[numrow].Cells[3].Value.ToString();
            lblDonGia.Text = dgvDSCTHD.Rows[numrow].Cells[4].Value.ToString();
        }

        int ID_CTHD_CellClick,SoLuongTon,ID_DichVu,DonGia;
        string ThoiGian;
        private void dgvDSCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int vt = dgvDSCTHD.CurrentCell.RowIndex;
                ID_CTHD_CellClick =Int32.Parse(dgvDSCTHD.Rows[vt].Cells[0].Value.ToString());
                SoLuongTon= Int32.Parse(dgvDSCTHD.Rows[vt].Cells[3].Value.ToString());
                DonGia = Int32.Parse(dgvDSCTHD.Rows[vt].Cells[4].Value.ToString());
                ID_DichVu = Int32.Parse(dgvDSCTHD.Rows[vt].Cells[5].Value.ToString());
                ThoiGian = dgvDSCTHD.Rows[vt].Cells[6].Value.ToString();
                hienthitextbox(vt);
            }
            catch (Exception ex)
            {
               
            }
           
        }

     

        private void btnInHD_Click(object sender, EventArgs e)
        {
            //ReportHD rHD = new ReportHD(iIdInHD);
            frmReport rHD = new frmReport(this.IDNV,  ID_HD);
            rHD.Show();         
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hóa đơn này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool HL = false;
                bHD.HoaDon_Xoa(ID_HD, HL);
                bPhong.phong_CNConTrong(ID_Phong, 0);
                MessageBox.Show("Xóa thành công ");
                dgvDSHD.DataSource = bHD.HoaDon_Select();
            }
        }


        int TienDVSauXoa;
        private void btnXoaCTHD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa dịch vụ này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                int SLT = (Int32.Parse(bDV.DV_Select(ID_DichVu).Rows[0][1].ToString()) + SoLuongTon);
                bDV.dichvu_capnhatSLTon(ID_DichVu.ToString(), SLT);
                bCTHD.CTHD_Xoa(ID_CTHD_CellClick.ToString());
                bCTHD.HienThiDSCTHD(dgvDSCTHD, ID_HD);
                bool HieuLuc, ThanhToan;
                if (chkHL.Checked == true)
                {
                    HieuLuc = true;
                }
                else
                {
                    HieuLuc = false;
                }

                if (chkThanhToan.Checked == true)
                {
                    ThanhToan = true;
                }
                else
                {
                    ThanhToan = false;
                }
                for (int i = 0; i < dgvDSCTHD.Rows.Count - 1; i++)
                {
                    int SL = Int32.Parse(dgvDSCTHD.Rows[i].Cells[3].Value.ToString());
                    int DG = Int32.Parse(dgvDSCTHD.Rows[i].Cells[4].Value.ToString());
                    TienDVSauXoa = TienDVSauXoa + (SL * DG);
                }
                lblTongTienDV.Text = TienDVSauXoa.ToString();
                lblTongTien.Text = (Int32.Parse(lblTongTienPhong.Text) + Int32.Parse(lblTongTienDV.Text)).ToString();
                bHD.HoaDon_CapNhat(ID_HD, txtMaHD.Text, ID_NV.ToString(), ID_KH.ToString(), cboMaPhong.SelectedValue.ToString(), Convert.ToDateTime(ngaylap).ToString("yyyy-MM-dd"), Convert.ToDateTime(dtpNgayDen.Text).ToString("yyyy-MM-dd"), Convert.ToDateTime(dtpNgayDi.Text).ToString("yyyy-MM-dd"), true, lblTongTienPhong.Text, lblTongTienDV.Text, lblTongTien.Text, rtxtGhiChu.Text, ThanhToan, HieuLuc);
                
            }
                
        }

        private void txtSDT_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if(bHD.HoaDon_HTTenKH(txtSDT.Text).Rows.Count==0)
                {
                    MessageBox.Show("Thông tin khách hàng chưa có");
                }    
                else
                {
                    cboTenKH.Text = bHD.HoaDon_HTTenKH(txtSDT.Text).Rows[0][0].ToString();
                }    
              
            }    
        }

        private void LoadData(string data)
        {
            cboMaPhong.Text = "";
            cboMaPhong.Text = data;
        }    

        private void btnTimPhong_Click(object sender, EventArgs e)
        {
            frmTimPhong tim = new frmTimPhong();
            tim.truyenchoHD = new frmTimPhong.TruyenChoHD(LoadData);
            tim.Show();
        }

        private void txtTim_TextChangeEvent(object sender, EventArgs e)
        {
            bHD.HienThiDanhSach(txtTim.TextValue, dgvDSHD);
        }

        private void btnDatThemPhong_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;

            if (flag == false)
            {
                clear_textboxThemPhong();
                xulytextbox(false);
                chkHL.Checked = true;
                chkThueTheoNgay.Checked = true;
                chkThanhToan.Checked = false;
                flag = true;

            }
            else if (flag == true)
            {

                if (dtpNgayDen.Value.Day < DateTime.Now.Day || dtpNgayDen.Value.Month < DateTime.Now.Month || dtpNgayDen.Value.Year < DateTime.Now.Year || dtpNgayDi.Value.Day < DateTime.Now.Day || dtpNgayDi.Value.Month < DateTime.Now.Month || dtpNgayDi.Value.Year < DateTime.Now.Year)
                {
                    MessageBox.Show("Thời gian đến không được nhỏ hơn ngày hiện tại");
                    return;
                }

                if (dtpNgayDen.Value.Month == dtpNgayDi.Value.Month && dtpNgayDen.Value.Year == dtpNgayDi.Value.Year)
                {
                    if (dtpNgayDen.Value.Day > dtpNgayDi.Value.Day)
                    {
                        MessageBox.Show("Lỗi thời gian");
                        return;
                    }

                }
                if (dtpNgayDen.Value.Month > dtpNgayDi.Value.Month || dtpNgayDen.Value.Year > dtpNgayDi.Value.Year)
                {
                    MessageBox.Show("Lỗi thời gian");
                    return;
                }
                else
                {


                    bool HieuLuc, ThanhToan;
                    if (chkHL.Checked == true)
                    {
                        HieuLuc = true;
                    }
                    else
                    {
                        HieuLuc = false;
                    }

                    if (chkThanhToan.Checked == true)
                    {
                        ThanhToan = true;
                    }
                    else
                    {
                        ThanhToan = false;
                    }
                    int ID = bHD.HoaDon_Select().Rows.Count+1;


                    if (chkThueTheoNgay.Checked==true)
                    {
                        TienPhong = Int32.Parse(bHD.TienPhong(Int32.Parse(cboMaPhong.Text)).Rows[0][0].ToString());
                        TongTienPhong = TienPhong * (ThoiGianThue(GioThue) / 24);
                    }
                    //else
                    //{
                    //    TienPhong = Int32.Parse(bHD.TienPhong(Int32.Parse(cboMaPhong.Text)).Rows[0][1].ToString());
                    //    TongTienPhong = TienPhong * (ThoiGianThue(GioThue));
                    //}
                    

                    //bPhong.phong_CNConTrong(Int32.Parse(cboMaPhong.SelectedValue.ToString()), 1);
                    bHD.HoaDon_Them(ID, txtMaHD.Text, IDNV.ToString(), ID_KH.ToString(), cboMaPhong.SelectedValue.ToString(), Convert.ToDateTime(DateTime.Now).ToString("yyyy/MM/dd hh:mm"), Convert.ToDateTime(dtpNgayDen.Text).ToString("yyyy/MM/dd hh:mm"), Convert.ToDateTime(dtpNgayDi.Text).ToString("yyyy/MM/dd hh:mm"), true, TongTienPhong, lblTongTienDV.Text, TongTienPhong, rtxtGhiChu.Text, ThanhToan, HieuLuc);
                    bPhong.phong_CNConTrong(Int32.Parse(cboMaPhong.SelectedValue.ToString()), 1);
                    MessageBox.Show("Thêm thành công ");
                    panel1.Enabled = true;
                    flag = false;
                    dgvDSHD.DataSource = bHD.HoaDon_Select();




                }


            }

        }

        int Gio;
        int HTT;
        int TienDV;
        private void btnChuyenPhong_Click(object sender, EventArgs e)
        {
            if(chkThueTheoNgay.Checked==true)
            {
                HTT = 1;
            }    
             
            frmChuyenPhong CP = new frmChuyenPhong(ID_HD,MaHD,this.IDNV,ID_KH,ID_Phong,NgayDen,NgayDi,HTT,TienDV);
            CP.chuyenphong = new frmChuyenPhong.ChuyenPhong(reload);
            CP.Show();
        }

       

        private int KTThang(int iThang,int iNam)
        {
            int Ngay=0;
            if(iThang==1|| iThang == 3 || iThang == 5 || iThang == 7 || iThang == 8 || iThang == 10 || iThang == 12)
            {
                Ngay = 31; ;
            }
            else if(iThang == 4 || iThang == 6 || iThang == 9 || iThang == 11 )
            {
               Ngay=30;
            }
            else if(iThang==2&&iNam%4==0)
            {
                Ngay = 29;
            }
            else
            {
                Ngay = 28;
            }
            return Ngay;
            
        }

        int TienPhongTT, TongTienPhongTT,GioThueTT;
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thanh toán hóa đơn này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TongTienPhongTT = 0;
                TienPhongTT = 0;

                //for (int i = 0; i < dgvDSHD.Rows.Count - 1; i++)
                //{
                //if(MaHD== dgvDSHD.Rows[i].Cells[1].Value.ToString())
                //{
                //int ID_HD_TT = ID_HD;

                string NgDi = nNgayDi;

                string NgDen = nNgayDen;

                 int NgayDi = Int32.Parse(string.Format("{0:dd}", Convert.ToDateTime(NgDi)));
                 int ThangDi = Int32.Parse(string.Format("{0:MM}", Convert.ToDateTime(NgDi)));
                 int NamDi = Int32.Parse(string.Format("{0:yyyy}", Convert.ToDateTime(NgDi)));

                 int NgayDen = Int32.Parse(string.Format("{0:dd}", Convert.ToDateTime(NgDen)));
                 int ThangDen = Int32.Parse(string.Format("{0:MM}", Convert.ToDateTime(NgDen)));
                 int NamDen = Int32.Parse(string.Format("{0:yyyy}", Convert.ToDateTime(NgDen)));
                        if (ThangDi==DateTime.Now.Month&&NamDi==DateTime.Now.Year)
                        {
                            if(NgayDi>DateTime.Now.Day)
                            {

                                
                                bool HieuLuc, ThanhToan;
                                if (chkHL.Checked == true)
                                {
                                    HieuLuc = true;
                                }
                                else
                                {
                                    HieuLuc = false;
                                }

                                if (chkThanhToan.Checked == true)
                                {
                                    ThanhToan = true;
                                }
                                else
                                {
                                    ThanhToan = false;
                                }

                                if (chkThueTheoNgay.Checked==true)
                                {
                                    TienPhongTT = Int32.Parse(bHD.TienPhong(Int32.Parse(cboMaPhong.Text)).Rows[0][0].ToString());
                                    TongTienPhongTT = TienPhongTT * (ThoiGianThueThanhToan(GioThueTT, NgayDen, ThangDen, NamDen) / 24) ;
                                }
                                //else
                                //{
                                //    TienPhongTT = Int32.Parse(bHD.TienPhong(Int32.Parse(cboMaPhong.Text)).Rows[0][1].ToString());
                                //    TongTienPhongTT = TienPhongTT * (ThoiGianThueThanhToan(GioThueTT, NgayDen, ThangDen, NamDen)) ;
                                //}
                                lblTongTienPhong.Text = TongTienPhongTT.ToString();
                                lblTongTien.Text = (TongTienPhongTT + Int32.Parse(lblTongTienDV.Text)).ToString();

                                bHD.HoaDon_CapNhat(ID_HD, txtMaHD.Text, ID_NV.ToString(), ID_KH.ToString(), cboMaPhong.SelectedValue.ToString(), Convert.ToDateTime(ngaylap).ToString("yyyy/MM/dd hh:mm"), Convert.ToDateTime(dtpNgayDen.Text).ToString("yyyy/MM/dd hh:mm"), Convert.ToDateTime(DateTime.Now).ToString("yyyy/MM/dd hh:mm"), true, lblTongTienPhong.Text, lblTongTienDV.Text, lblTongTien.Text, rtxtGhiChu.Text, ThanhToan, HieuLuc);
                            }    
                        }
                        else if(ThangDi > DateTime.Now.Month && NamDi == DateTime.Now.Year)
                        {

                            
                            bool HieuLuc, ThanhToan;
                            if (chkHL.Checked == true)
                            {
                                HieuLuc = true;
                            }
                            else
                            {
                                HieuLuc = false;
                            }

                            if (chkThanhToan.Checked == true)
                            {
                                ThanhToan = true;
                            }
                            else
                            {
                                ThanhToan = false;
                            }

                            if (chkThueTheoNgay.Checked==true)
                            {
                                TienPhongTT = Int32.Parse(bHD.TienPhong(Int32.Parse(cboMaPhong.Text)).Rows[0][0].ToString());
                                TongTienPhongTT = TienPhongTT * (ThoiGianThueThanhToan(GioThueTT, NgayDen, ThangDen, NamDen) / 24) ;
                            }
                            else
                            //{
                            //    TienPhongTT = Int32.Parse(bHD.TienPhong(Int32.Parse(cboMaPhong.Text)).Rows[0][1].ToString());
                            //    TongTienPhongTT = TienPhongTT * (ThoiGianThueThanhToan(GioThueTT, NgayDen, ThangDen, NamDen)) ;
                            //}
                            lblTongTienPhong.Text = TongTienPhong.ToString();
                            lblTongTien.Text = (TongTienPhong + Int32.Parse(lblTongTienDV.Text)).ToString();

                            bHD.HoaDon_CapNhat(ID_HD, txtMaHD.Text, ID_NV.ToString(), ID_KH.ToString(), cboMaPhong.SelectedValue.ToString(), Convert.ToDateTime(ngaylap).ToString("yyyy/MM/dd hh:mm"), Convert.ToDateTime(dtpNgayDen.Text).ToString("yyyy/MM/dd hh:mm"), Convert.ToDateTime(DateTime.Now).ToString("yyyy/MM/dd hh:mm"), true, lblTongTienPhong.Text, lblTongTienDV.Text, lblTongTien.Text, rtxtGhiChu.Text, ThanhToan, HieuLuc);
                        }
                        bHD.HoaDon_ThanhToan(ID_HD, true);
                bPhong.phong_CNConTrong(ID_HD, Int32.Parse(cboMaPhong.SelectedValue.ToString()));
                       
                    //}    
                //}

                dgvDSHD.DataSource = bHD.HoaDon_Select();
                frmReport rHD = new frmReport(this.IDNV, ID_HD);
                rHD.Show();
            }
        }

        private int ThoiGianThue(int iGio)
        {
            if(dtpNgayDen.Value.Month==dtpNgayDi.Value.Month&&dtpNgayDen.Value.Year==dtpNgayDi.Value.Year)
            {
                if((dtpNgayDi.Value.Day - dtpNgayDen.Value.Day)==0)
                {
                    iGio = 1 * 24;
                }  
                else
                {
                    iGio = (dtpNgayDi.Value.Day - dtpNgayDen.Value.Day) * 24;
                }    
               
            }
            else if(dtpNgayDi.Value.Month>dtpNgayDen.Value.Month && dtpNgayDen.Value.Year == dtpNgayDi.Value.Year)
            {
                iGio = ((KTThang(dtpNgayDen.Value.Month, dtpNgayDen.Value.Year) - dtpNgayDen.Value.Day) + dtpNgayDi.Value.Day) * 24;
            }

            return iGio;
        }


        private int ThoiGianThueThanhToan(int iGio,int Ngay,int Thang,int Nam)
        {
            if (Thang == DateTime.Now.Month && Nam == DateTime.Now.Year)
            {
                iGio = (DateTime.Now.Day - Ngay) * 24;
            }
            else if (DateTime.Now.Month > Thang && Nam == DateTime.Now.Year)
            {
                iGio = ((KTThang(Thang, Nam) - Ngay) + DateTime.Now.Day) * 24;
            }

            return iGio;
        }


        //if (cboHinhThucThue.SelectedIndex == 0)
        //{
        //    bHD.HienThiTienPhong(cboMaPhong, cboHinhThucThue, lblTongTienPhong, 0);
        //}
        //else
        //{
        //    bHD.HienThiTienPhong(cboMaPhong, cboHinhThucThue, lblTongTienPhong, 1);
        //}

    }
}
