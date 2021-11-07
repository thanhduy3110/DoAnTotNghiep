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
            int dem = dgvDSHD.Rows.Count;
            if (dem < 10)
            {
                MaHD = "HD00" + dem.ToString();
            }
            else
            {
                MaHD = "HD" + dem.ToString();
            }

            return MaHD;
        }

        void clear_textbox()
        {

            txtMaHD.Text = PhatSinhMaTuDong();
            txtTenKH.Text = "";
            cboMaPhong.Text = "";
            cboHinhThucThue.Text = "";
            dtpNgayDen.Text = "";
            dtpNgayDi.Text = "";
          
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
            txtMaHD.ReadOnly = t;
            rtxtGhiChu.ReadOnly = t;
        }
        int iIdInHD;
        public void hienthi_textbox(int numrow)
        {
            iIdInHD = int.Parse(dgvDSHD.Rows[numrow].Cells[0].Value.ToString());
            //txtID.Text = dgvDSHD.Rows[numrow].Cells[0].Value.ToString();
            //txtID_HD.Text = dgvDSHD.Rows[numrow].Cells[0].Value.ToString();
            txtMaHD.Text = dgvDSHD.Rows[numrow].Cells[1].Value.ToString();
            txtTenNV.Text = dgvDSHD.Rows[numrow].Cells[2].Value.ToString();
            txtTenKH.Text = dgvDSHD.Rows[numrow].Cells[3].Value.ToString();
            cboMaPhong.Text = dgvDSHD.Rows[numrow].Cells[4].Value.ToString();
            
            dtpNgayDen.Text = dgvDSHD.Rows[numrow].Cells[6].Value.ToString();
            dtpNgayDi.Text = dgvDSHD.Rows[numrow].Cells[7].Value.ToString();
            lblTongTienPhong.Text = dgvDSHD.Rows[numrow].Cells[9].Value.ToString();
            lblTongTienDV.Text = dgvDSHD.Rows[numrow].Cells[10].Value.ToString();
            lblTongTien.Text = dgvDSHD.Rows[numrow].Cells[11].Value.ToString();
            rtxtGhiChu.Text = dgvDSHD.Rows[numrow].Cells[12].Value.ToString();

            cboHinhThucThue.Text = dgvDSHD.Rows[numrow].Cells[8].Value.ToString();
           

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
        }


       
            
  

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (flag == false)
            {
                clear_textbox();
                xulytextbox(false);
                chkHL.Checked = true;
                flag = true;
            }
            else if (flag == true)
            {

                if ( cboMaPhong.Text == "" || cboHinhThucThue.Text == "")
                {
                    MessageBox.Show("Lỗi");
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
                        int ID = dgvDSHD.Rows.Count + 1;

                     
                    if(cboHinhThucThue.Text=="Thuê theo ngày")
                    {
                        TienPhong = Int32.Parse(bHD.TienPhong(Int32.Parse(cboMaPhong.Text)).Rows[0][0].ToString());
                        TongTienPhong = TienPhong * (ThoiGianThue(GioThue) / 24);
                    }    
                    else
                    {
                        TienPhong = Int32.Parse(bHD.TienPhong(Int32.Parse(cboMaPhong.Text)).Rows[0][1].ToString());
                        TongTienPhong = TienPhong * (ThoiGianThue(GioThue));
                    }    
                        bHD.HoaDon_Them(ID, txtMaHD.Text, IDNV.ToString(),cboSDT.SelectedValue.ToString(), cboMaPhong.SelectedValue.ToString(), Convert.ToDateTime(DateTime.Now).ToString("yyyy/MM/dd hh:mm"), Convert.ToDateTime(dtpNgayDen.Text).ToString("yyyy/MM/dd hh:mm"), Convert.ToDateTime(dtpNgayDi.Text).ToString("yyyy/MM/dd hh:mm"), cboHinhThucThue.SelectedIndex, TongTienPhong, lblTongTienDV.Text, TongTienPhong, rtxtGhiChu.Text, ThanhToan, HieuLuc);
                        MessageBox.Show("Thêm thành công ");
                        flag = false;
                        dgvDSHD.DataSource = bHD.HoaDon_Select();
                       
                   
                    
                        
                    }    
                    
                    
            }
           
        }
        int GioThue,TongTienPhong,TienPhong;

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            if(flag==false)
            {
                xulytextbox(false);
                flag = true;
            }    
            else if (flag == true)
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

                if (cboHinhThucThue.Text == "Thuê theo ngày")
                {
                    TienPhong = Int32.Parse(bHD.TienPhong(Int32.Parse(cboMaPhong.Text)).Rows[0][0].ToString());
                    TongTienPhong = TienPhong * (ThoiGianThue(GioThue) / 24)+Int32.Parse(lblTongTienDV.Text);
                }
                else
                {
                    TienPhong = Int32.Parse(bHD.TienPhong(Int32.Parse(cboMaPhong.Text)).Rows[0][1].ToString());
                    TongTienPhong = TienPhong * (ThoiGianThue(GioThue))+ Int32.Parse(lblTongTienDV.Text);
                }
                lblTongTienPhong.Text = TongTienPhong.ToString();
                lblTongTien.Text = (TongTienPhong + Int32.Parse(lblTongTienDV.Text)).ToString();
                   
                bHD.HoaDon_CapNhat(ID_HD, txtMaHD.Text, ID_NV.ToString(), ID_KH.ToString(), cboMaPhong.SelectedValue.ToString(),ngaylap , Convert.ToDateTime(dtpNgayDen.Text).ToString("yyyy/MM/dd hh:mm"), Convert.ToDateTime(dtpNgayDi.Text).ToString("yyyy/MM/dd hh:mm"), cboHinhThucThue.SelectedIndex, lblTongTienPhong.Text, lblTongTienDV.Text,lblTongTien.Text , rtxtGhiChu.Text, ThanhToan, HieuLuc);
                MessageBox.Show("Sữa thành công ");
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
                    bHD.HoaDon_CapNhat(ID_HD, txtMaHD.Text, ID_NV.ToString(), ID_KH.ToString(), cboMaPhong.SelectedValue.ToString(), Convert.ToDateTime(ngaylap).ToString("yyyy-MM-dd"), Convert.ToDateTime(dtpNgayDen.Text).ToString("yyyy-MM-dd"), Convert.ToDateTime(dtpNgayDi.Text).ToString("yyyy-MM-dd"), cboHinhThucThue.SelectedIndex, lblTongTienPhong.Text, lblTongTienDV.Text, lblTongTien.Text, rtxtGhiChu.Text, ThanhToan, HieuLuc); lblTongTien.Text = (Int32.Parse(lblTongTienPhong.Text) + Int32.Parse(lblTongTienDV.Text)).ToString();
                    
                    dgvDSHD.DataSource = bHD.HoaDon_Select();
                }    
                else
                {
                    bCTHD.CTHD_Them(TongID, ID_HD, cboTenDV.SelectedValue.ToString(), txtSoLuong.Text, lblDonGia.Text);
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
                    bHD.HoaDon_CapNhat(ID_HD, txtMaHD.Text, ID_NV.ToString(), ID_KH.ToString(), cboMaPhong.SelectedValue.ToString(), Convert.ToDateTime(ngaylap).ToString("yyyy-MM-dd"), Convert.ToDateTime(dtpNgayDen.Text).ToString("yyyy-MM-dd"), Convert.ToDateTime(dtpNgayDi.Text).ToString("yyyy-MM-dd"), cboHinhThucThue.SelectedIndex, lblTongTienPhong.Text, lblTongTienDV.Text, lblTongTien.Text, rtxtGhiChu.Text, ThanhToan, HieuLuc);
                    
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
                bCTHD.CTHD_CapNhat(ID_CTHD_CellClick,ID_HD, cboTenDV.SelectedValue.ToString(), txtSoLuong.Text, lblDonGia.Text);
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
                bHD.HoaDon_CapNhat(ID_HD, txtMaHD.Text, ID_NV.ToString(), ID_KH.ToString(), cboMaPhong.SelectedValue.ToString(), Convert.ToDateTime(ngaylap).ToString("yyyy-MM-dd"), Convert.ToDateTime(dtpNgayDen.Text).ToString("yyyy-MM-dd"), Convert.ToDateTime(dtpNgayDi.Text).ToString("yyyy-MM-dd"), cboHinhThucThue.SelectedIndex, lblTongTienPhong.Text, lblTongTienDV.Text, lblTongTien.Text, rtxtGhiChu.Text, ThanhToan, HieuLuc);
                dgvDSHD.DataSource = bHD.HoaDon_Select();
            }    
        }

        public void reload()
        {
            dgvDSHD.DataSource = bHD.HoaDon_Select();
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            txtTenNV.Text = this.HoTen;
            txtTenNV.ReadOnly = true;
            btnChuyenPhong.Enabled = false;
            xulychucnang(true);
            xulytextbox(true);
            bHD.HienThiSDT(cboSDT);
            bHD.HienThiTenKH(cboSDT, txtTenKH);
            bCTHD.HienThiTenDV(cboTenDV, lblDonGia);
            bHD.HienThiMaPhong(cboMaPhong);
            dgvDSHD.DataSource = bHD.HoaDon_Select();
        }

        int ID_HD,ID_NV,ID_KH,ID_Phong;
        string ngaylap;
        private void dgvDSHD_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btnChuyenPhong.Enabled = true;
            try
            {
                int vt = dgvDSHD.CurrentCell.RowIndex;
                hienthi_textbox(vt);
                ID_HD = Int32.Parse(dgvDSHD.Rows[vt].Cells[0].Value.ToString());
                bCTHD.HienThiDSCTHD(dgvDSCTHD, ID_HD);
                ngaylap=  dgvDSHD.Rows[vt].Cells[5].Value.ToString();
                ID_NV= Int32.Parse(dgvDSHD.Rows[vt].Cells[15].Value.ToString());
                ID_KH=Int32.Parse(dgvDSHD.Rows[vt].Cells[16].Value.ToString());
                ID_Phong= Int32.Parse(dgvDSHD.Rows[vt].Cells[16].Value.ToString());
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

        int ID_CTHD_CellClick;
        private void dgvDSCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int vt = dgvDSCTHD.CurrentCell.RowIndex;
                ID_CTHD_CellClick =Int32.Parse(dgvDSCTHD.Rows[vt].Cells[0].Value.ToString());
                hienthitextbox(vt);
            }
            catch (Exception ex)
            {
               
            }
           
        }

     

        private void btnInHD_Click(object sender, EventArgs e)
        {
            //ReportHD rHD = new ReportHD(iIdInHD);
            frmReport rHD = new frmReport(iIdInHD);
            rHD.Show();         
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hóa đươn này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool HL = false;
                bHD.HoaDon_Xoa(ID_HD, HL);
                MessageBox.Show("Xóa thành công ");
                dgvDSHD.DataSource = bHD.HoaDon_Select();
            }
        }

      

        private void btnXoaCTHD_Click(object sender, EventArgs e)
        {
            bCTHD.CTHD_Xoa(ID_CTHD_CellClick.ToString());
            MessageBox.Show("Xóa thành công ");
            bCTHD.HienThiDSCTHD(dgvDSCTHD, ID_HD);
        }

        int Gio;
        int HTT;
        int TienDV;
        private void btnChuyenPhong_Click(object sender, EventArgs e)
        {
            if(cboHinhThucThue.Text=="Thuê theo ngày")
            {
                HTT = 1;
            }    
            else
            {
                HTT = 2;
            }    
            frmChuyenPhong CP = new frmChuyenPhong(ID_HD, ThoiGianThue(Gio),HTT,TienDV);
            CP.Show();
        }

        private void btnLoadDS_Click(object sender, EventArgs e)
        {
            reload();
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

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

        }

        private int ThoiGianThue(int iGio)
        {
            if(dtpNgayDen.Value.Month==dtpNgayDi.Value.Month&&dtpNgayDen.Value.Year==dtpNgayDi.Value.Year)
            {
                iGio = (dtpNgayDi.Value.Day - dtpNgayDen.Value.Day) * 24;
            }
            else if(dtpNgayDi.Value.Month>dtpNgayDen.Value.Month && dtpNgayDen.Value.Year == dtpNgayDi.Value.Year)
            {
                iGio = ((KTThang(dtpNgayDen.Value.Month, dtpNgayDen.Value.Year) - dtpNgayDen.Value.Day) + dtpNgayDi.Value.Day) * 24;
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
