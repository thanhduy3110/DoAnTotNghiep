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
        public frmHoaDon()
        {
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
            cboTenNV.Text = "";
            cboTenKH.Text = "";
            cboMaPhong.Text = "";
            cboHinhThucThue.Text = "";
            dtpNgayDen.Text = "";
            dtpNgayDi.Text = "";
            dtpNgayLap.Text = "";
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
            cboTenNV.Text = dgvDSHD.Rows[numrow].Cells[2].Value.ToString();
            cboTenKH.Text = dgvDSHD.Rows[numrow].Cells[3].Value.ToString();
            cboMaPhong.Text = dgvDSHD.Rows[numrow].Cells[4].Value.ToString();
            dtpNgayLap.Text = dgvDSHD.Rows[numrow].Cells[5].Value.ToString();
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
                flag = true;
            }
            else if (flag == true)
            {

                if (cboTenNV.Text == "" || cboTenKH.Text == "" || cboMaPhong.Text == "" || cboHinhThucThue.Text == "")
                {
                    MessageBox.Show("Lỗi");
                }
                //if (dtpNgayLap.Value.Year > dtpNgayDen.Value.Year || dtpNgayLap.Value.Year > dtpNgayDi.Value.Year || dtpNgayDen.Value.Year > dtpNgayDi.Value.Year|| dtpNgayLap.Value.Month > dtpNgayDen.Value.Month || dtpNgayLap.Value.Month > dtpNgayDi.Value.Month || dtpNgayDen.Value.Month > dtpNgayDi.Value.Month)
                //    {
                //        MessageBox.Show("Lỗi thời gian");
                //    }
                //else if (dtpNgayLap.Value.Year == dtpNgayDen.Value.Year|| dtpNgayDen.Value.Year == dtpNgayDi.Value.Year)
                //    {
                //        if (dtpNgayLap.Value.Month == dtpNgayDen.Value.Month)
                //        {
                //            if (dtpNgayLap.Value.Day > dtpNgayDen.Value.Day)
                //            {
                //                MessageBox.Show("Ngày lập không được lớn hơn ngày đến");
                //            }
                //        }

                //    if (dtpNgayDen.Value.Month == dtpNgayDi.Value.Month)
                //    {
                //        if (dtpNgayDen.Value.Day > dtpNgayDi.Value.Day)

                //        {
                //            MessageBox.Show("Ngày đến không được lớn hơn ngày đi");
                //        }
                //    }
                //     } 
               else
                {
                    bool HieuLuc,ThanhToan;
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
                        bHD.HoaDon_Them(ID, txtMaHD.Text, cboTenNV.SelectedValue.ToString(), cboTenKH.SelectedValue.ToString(), cboMaPhong.SelectedValue.ToString(), Convert.ToDateTime(dtpNgayLap.Text).ToString("yyyy/MM/dd hh:mm"), Convert.ToDateTime(dtpNgayDen.Text).ToString("yyyy/MM/dd hh:mm"), Convert.ToDateTime(dtpNgayDi.Text).ToString("yyyy/MM/dd hh:mm"), cboHinhThucThue.SelectedIndex, lblTongTienPhong.Text, lblTongTienDV.Text, lblTongTien.Text, rtxtGhiChu.Text, ThanhToan, HieuLuc);
                        MessageBox.Show("Thêm thành công ");
                        flag = false;
                        dgvDSHD.DataSource = bHD.HoaDon_Select();
                }    
            }
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            if(flag==false)
            {
                xulytextbox(false);
                flag = true;
            }    
            if (flag == true)
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
                bHD.HoaDon_CapNhat(ID_HD, txtMaHD.Text, cboTenNV.SelectedValue.ToString(), cboTenKH.SelectedValue.ToString(), cboMaPhong.SelectedValue.ToString(), Convert.ToDateTime(dtpNgayLap.Text).ToString("yyyy/MM/dd hh:mm"), Convert.ToDateTime(dtpNgayDen.Text).ToString("yyyy/MM/dd hh:mm"), Convert.ToDateTime(dtpNgayDi.Text).ToString("yyyy/MM/dd hh:mm"), cboHinhThucThue.SelectedIndex, lblTongTienPhong.Text, lblTongTienDV.Text, lblTongTien.Text, rtxtGhiChu.Text, ThanhToan, HieuLuc);
                MessageBox.Show("Sữa thành công ");
                flag = false;
                dgvDSHD.DataSource = bHD.HoaDon_Select();
            }
        }

        

        int coCTHD;
        private void btnThemCTHD_Click(object sender, EventArgs e)
        {
            
            bCTHD.TongID(txtID_CTHD);
            int TongID = Int32.Parse(txtID_CTHD.Text) + 1;
            txtID_CTHD.Text = TongID.ToString();
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
                if (cboTenDV.SelectedValue.ToString() == dgvDSCTHD.Rows[i].Cells["ID_DV"].Value.ToString())
                {
                    flagg = 1;    // nếu có tên dv nào thì gán flag =1
                    vitri = i;
                    txtID_CTHD.Text = dgvDSCTHD.Rows[i].Cells[0].Value.ToString();
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
                    bCTHD.CTHD_CongDonSL(txtID_CTHD.Text, soluong.ToString());
                    MessageBox.Show("Cập nhật số lượng thành công ");
                    bCTHD.HienThiDSCTHD(dgvDSCTHD, ID_HD);
                    for (int i = 0; i < dgvDSCTHD.Rows.Count - 1; i++)
                    {
                        int SL = Int32.Parse(dgvDSCTHD.Rows[i].Cells[3].Value.ToString());
                        int DG = Int32.Parse(dgvDSCTHD.Rows[i].Cells[4].Value.ToString());
                        TienDV = TienDV + (SL * DG);
                    }
                    lblTongTienDV.Text = TienDV.ToString();
                    bHD.HoaDon_CapNhat(ID_HD, txtMaHD.Text, cboTenNV.SelectedValue.ToString(), cboTenKH.SelectedValue.ToString(), cboMaPhong.SelectedValue.ToString(), Convert.ToDateTime(dtpNgayLap.Text).ToString("yyyy-MM-dd"), Convert.ToDateTime(dtpNgayDen.Text).ToString("yyyy-MM-dd"), Convert.ToDateTime(dtpNgayDi.Text).ToString("yyyy-MM-dd"), cboHinhThucThue.SelectedIndex, lblTongTienPhong.Text, lblTongTienDV.Text, lblTongTien.Text, rtxtGhiChu.Text, ThanhToan, HieuLuc); lblTongTien.Text = (Int32.Parse(lblTongTienPhong.Text) + Int32.Parse(lblTongTienDV.Text)).ToString();
                    dgvDSHD.DataSource = bHD.HoaDon_Select();
                }    
                else
                {
                    bCTHD.CTHD_Them(Int32.Parse(txtID_CTHD.Text), ID_HD, cboTenDV.SelectedValue.ToString(), txtSoLuong.Text, lblDonGia.Text);
                    MessageBox.Show("Thêm thành công ");
                    bCTHD.HienThiDSCTHD(dgvDSCTHD, ID_HD);
                    for (int i = 0; i < dgvDSCTHD.Rows.Count - 1; i++)
                    {
                        int SL = Int32.Parse(dgvDSCTHD.Rows[i].Cells[3].Value.ToString());
                        int DG = Int32.Parse(dgvDSCTHD.Rows[i].Cells[4].Value.ToString());
                        TienDV = TienDV + (SL * DG);
                    }
                    lblTongTienDV.Text = TienDV.ToString();
                    lblTongTien.Text = (Int32.Parse(lblTongTienPhong.Text) + Int32.Parse(lblTongTienDV.Text)).ToString();
                    bHD.HoaDon_CapNhat(ID_HD, txtMaHD.Text, cboTenNV.SelectedValue.ToString(), cboTenKH.SelectedValue.ToString(), cboMaPhong.SelectedValue.ToString(), Convert.ToDateTime(dtpNgayLap.Text).ToString("yyyy-MM-dd"), Convert.ToDateTime(dtpNgayDen.Text).ToString("yyyy-MM-dd"), Convert.ToDateTime(dtpNgayDi.Text).ToString("yyyy-MM-dd"), cboHinhThucThue.SelectedIndex, lblTongTienPhong.Text, lblTongTienDV.Text, lblTongTien.Text, rtxtGhiChu.Text, ThanhToan, HieuLuc);
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
                MessageBox.Show("Sữa thành công ");
                bCTHD.HienThiDSCTHD(dgvDSCTHD, ID_HD);
                for (int i = 0; i < dgvDSCTHD.Rows.Count - 1; i++)
                {
                    int SL = Int32.Parse(dgvDSCTHD.Rows[i].Cells[3].Value.ToString());
                    int DG = Int32.Parse(dgvDSCTHD.Rows[i].Cells[4].Value.ToString());
                    TienDV = TienDV + (SL * DG);
                }
                lblTongTienDV.Text = TienDV.ToString();
                lblTongTien.Text = (Int32.Parse(lblTongTienPhong.Text) + Int32.Parse(lblTongTienDV.Text)).ToString();
                bHD.HoaDon_CapNhat(ID_HD, txtMaHD.Text, cboTenNV.SelectedValue.ToString(), cboTenKH.SelectedValue.ToString(), cboMaPhong.SelectedValue.ToString(), Convert.ToDateTime(dtpNgayLap.Text).ToString("yyyy-MM-dd"), Convert.ToDateTime(dtpNgayDen.Text).ToString("yyyy-MM-dd"), Convert.ToDateTime(dtpNgayDi.Text).ToString("yyyy-MM-dd"), cboHinhThucThue.SelectedIndex, lblTongTienPhong.Text, lblTongTienDV.Text, lblTongTien.Text, rtxtGhiChu.Text, ThanhToan, HieuLuc);
                dgvDSHD.DataSource = bHD.HoaDon_Select();
            }    
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            xulychucnang(true);
            xulytextbox(true);
            bHD.HienThiTenNV(cboTenNV);
            bHD.HienThiTenKH(cboTenKH);
            bCTHD.HienThiTenDV(cboTenDV, lblDonGia);
            bHD.HienThiMaPhong(cboMaPhong);
            dgvDSHD.DataSource = bHD.HoaDon_Select();
        }

        int ID_HD;
        private void dgvDSHD_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int vt = dgvDSHD.CurrentCell.RowIndex;
                hienthi_textbox(vt);
                ID_HD = Int32.Parse(dgvDSHD.Rows[vt].Cells[0].Value.ToString());
                bCTHD.HienThiDSCTHD(dgvDSCTHD, ID_HD);
                
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
            txtID_CTHD.Text = dgvDSCTHD.Rows[numrow].Cells[0].Value.ToString();
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

        private void cboHinhThucThue_TextChanged(object sender, EventArgs e)
        {
            if (cboHinhThucThue.SelectedIndex == 0)
            {
                bHD.HienThiTienPhong(cboMaPhong, cboHinhThucThue, lblTongTienPhong, 0);
            }
            else
            {
                bHD.HienThiTienPhong(cboMaPhong, cboHinhThucThue, lblTongTienPhong, 1);
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
            bool HL = false;
            bHD.HoaDon_Xoa(ID_HD, HL);
            MessageBox.Show("Xóa thành công ");
            dgvDSHD.DataSource = bHD.HoaDon_Select();
        }

        private void btnChuyenPhong_Click(object sender, EventArgs e)
        {
            int HTT;
            if (cboHinhThucThue.Text == "Thuê theo ngày")
            {
                HTT = 0;
            }
            else
                HTT = 1;

            int NamDen = dtpNgayDen.Value.Year;
            int ThangDen = dtpNgayDen.Value.Month;
            int NgayDen = dtpNgayDen.Value.Day;
            int GioDen = dtpNgayDen.Value.Hour;

            int NamDi = dtpNgayDi.Value.Year;
            int ThangDi = dtpNgayDi.Value.Month;
            int NgayDi = dtpNgayDi.Value.Day;
            int GioDi = dtpNgayDi.Value.Hour;

            frmChuyenPhong CP = new frmChuyenPhong(ID_HD, HTT, NamDen, NamDi, ThangDen, ThangDi, NgayDen, NgayDi, GioDen, GioDi);
            CP.Show();
        }

        private void btnXoaCTHD_Click(object sender, EventArgs e)
        {
            bCTHD.CTHD_Xoa(txtID_CTHD.Text);
            MessageBox.Show("Xóa thành công ");
            bCTHD.HienThiDSCTHD(dgvDSCTHD, ID_HD);
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
