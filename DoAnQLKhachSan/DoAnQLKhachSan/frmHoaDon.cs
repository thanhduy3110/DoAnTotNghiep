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
        bool flag=false;

        void Tang_ID()
        {
            int count = 0;
            count = dgvDSHD.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count <= 1)
            {
                txtID.Text = "0";
            }
            else
            {
                chuoi = Convert.ToString(dgvDSHD.Rows[count - 2].Cells[0].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 0)));
                if (chuoi2 + 1 < 10)
                {
                    txtID.Text = "" + (chuoi2 + 1).ToString();
                }
                else if (chuoi2 + 1 < 100)
                {
                    txtID.Text = "" + (chuoi2 + 1).ToString();
                }

            }
        }

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
            Tang_ID();
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
            cboThanhToan.Text = "";
            cboHieuLuc.Text = "";
        }
        void xulychucnang(Boolean t)
        {
            btnThem.Enabled = t;
            //btnXoa.Enabled = t;
            btnSua.Enabled = t;
            btnLuu.Enabled = !t;
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
            txtID.Text = dgvDSHD.Rows[numrow].Cells[0].Value.ToString();
            txtID_HD.Text = dgvDSHD.Rows[numrow].Cells[0].Value.ToString();
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

            string HTT = dgvDSHD.Rows[numrow].Cells[8].Value.ToString();
            if (HTT == "False")
            {
                cboHinhThucThue.SelectedIndex = 0;
            }
            else
            {
                cboHinhThucThue.SelectedIndex = 1;
            }

            string TT = dgvDSHD.Rows[numrow].Cells[13].Value.ToString();
            if (TT == "False")
            {
                cboThanhToan.SelectedIndex = 0;
            }
            else
            {
                cboThanhToan.SelectedIndex = 1;
            }

            string HL = dgvDSHD.Rows[numrow].Cells[14].Value.ToString();
            if (HL == "False")
            {
                cboHieuLuc.SelectedIndex = 0;
            }
            else
            {
                cboHieuLuc.SelectedIndex = 1;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            if(flag==false)
            {
                clear_textbox();
                xulychucnang(false);
                xulytextbox(false);
                flag = true;
            }
            else if (flag == true)
            {

                if (cboTenNV.Text == "" || cboTenKH.Text == "" || cboMaPhong.Text == "" || cboHinhThucThue.Text == "" || dtpNgayLap.Text == "" || dtpNgayDen.Text == "" || dtpNgayDi.Text == "" || rtxtGhiChu.Text == "" || cboThanhToan.Text == "")
                {
                    MessageBox.Show("Lỗi");
                }
                else
                {
                    xulychucnang(true);
                    bHD.HoaDon_Them(txtID.Text, txtMaHD.Text, cboTenNV.SelectedValue.ToString(), cboTenKH.SelectedValue.ToString(), cboMaPhong.SelectedValue.ToString(), Convert.ToDateTime(dtpNgayLap.Text).ToString("yyyy/MM/dd hh:mm"), Convert.ToDateTime(dtpNgayDen.Text).ToString("yyyy/MM/dd hh:mm"), Convert.ToDateTime(dtpNgayDi.Text).ToString("yyyy/MM/dd hh:mm"), cboHinhThucThue.SelectedIndex, lblTongTienPhong.Text, lblTongTienDV.Text, lblTongTien.Text, rtxtGhiChu.Text, cboThanhToan.SelectedIndex, cboHieuLuc.SelectedIndex);
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
                xulychucnang(false);
                xulytextbox(false);
                flag = true;
            }    
            if (flag == true)
            {
                xulychucnang(true);
                bHD.HoaDon_CapNhat(txtID.Text, txtMaHD.Text, cboTenNV.SelectedValue.ToString(), cboTenKH.SelectedValue.ToString(), cboMaPhong.SelectedValue.ToString(), Convert.ToDateTime(dtpNgayLap.Text).ToString("yyyy/MM/dd hh:mm"), Convert.ToDateTime(dtpNgayDen.Text).ToString("yyyy/MM/dd hh:mm"), Convert.ToDateTime(dtpNgayDi.Text).ToString("yyyy/MM/dd hh:mm"), cboHinhThucThue.SelectedIndex, lblTongTienPhong.Text, lblTongTienDV.Text, lblTongTien.Text, rtxtGhiChu.Text, cboThanhToan.SelectedIndex, cboHieuLuc.SelectedIndex);
                MessageBox.Show("Thêm thành công ");
                flag = false;
                dgvDSHD.DataSource = bHD.HoaDon_Select();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
           
        }

        int coCTHD;
        private void btnThemCTHD_Click(object sender, EventArgs e)
        {
            bCTHD.TongID(txtID_CTHD);
            int TongID = Int32.Parse(txtID_CTHD.Text) + 1;
            txtID_CTHD.Text = TongID.ToString();
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
                if (flagg == 1)
                {
                    //Tăng số lượng dịch vụ cùng tên lên
                    int soluong = int.Parse(txtSoLuong.Text) + int.Parse(dgvDSCTHD.Rows[vitri].Cells[3].Value.ToString());
                    bCTHD.CTHD_CongDonSL(txtID_CTHD.Text, soluong.ToString());
                    MessageBox.Show("Cập nhật số lượng thành công ");
                    bCTHD.HienThiDSCTHD(dgvDSCTHD, Int32.Parse(txtID_HD.Text));
                    for (int i = 0; i < dgvDSCTHD.Rows.Count - 1; i++)
                    {
                        int SL = Int32.Parse(dgvDSCTHD.Rows[i].Cells[3].Value.ToString());
                        int DG = Int32.Parse(dgvDSCTHD.Rows[i].Cells[4].Value.ToString());
                        TienDV = TienDV + (SL * DG);
                    }
                    lblTongTienDV.Text = TienDV.ToString();
                    bHD.HoaDon_CapNhat(txtID.Text, txtMaHD.Text, cboTenNV.SelectedValue.ToString(), cboTenKH.SelectedValue.ToString(), cboMaPhong.SelectedValue.ToString(), Convert.ToDateTime(dtpNgayLap.Text).ToString("yyyy-MM-dd"), Convert.ToDateTime(dtpNgayDen.Text).ToString("yyyy-MM-dd"), Convert.ToDateTime(dtpNgayDi.Text).ToString("yyyy-MM-dd"), cboHinhThucThue.SelectedIndex, lblTongTienPhong.Text, lblTongTienDV.Text, lblTongTien.Text, rtxtGhiChu.Text, cboThanhToan.SelectedIndex, cboHieuLuc.SelectedIndex); lblTongTien.Text = (Int32.Parse(lblTongTienPhong.Text) + Int32.Parse(lblTongTienDV.Text)).ToString();
                    dgvDSHD.DataSource = bHD.HoaDon_Select();
                }    
                else
                {
                    bCTHD.CTHD_Them(txtID_CTHD.Text, txtID_HD.Text, cboTenDV.SelectedValue.ToString(), txtSoLuong.Text, lblDonGia.Text);
                    MessageBox.Show("Thêm thành công ");
                    bCTHD.HienThiDSCTHD(dgvDSCTHD, Int32.Parse(txtID_HD.Text));
                    for (int i = 0; i < dgvDSCTHD.Rows.Count - 1; i++)
                    {
                        int SL = Int32.Parse(dgvDSCTHD.Rows[i].Cells[3].Value.ToString());
                        int DG = Int32.Parse(dgvDSCTHD.Rows[i].Cells[4].Value.ToString());
                        TienDV = TienDV + (SL * DG);
                    }
                    lblTongTienDV.Text = TienDV.ToString();
                    lblTongTien.Text = (Int32.Parse(lblTongTienPhong.Text) + Int32.Parse(lblTongTienDV.Text)).ToString();
                    bHD.HoaDon_CapNhat(txtID.Text, txtMaHD.Text, cboTenNV.SelectedValue.ToString(), cboTenKH.SelectedValue.ToString(), cboMaPhong.SelectedValue.ToString(), Convert.ToDateTime(dtpNgayLap.Text).ToString("yyyy-MM-dd"), Convert.ToDateTime(dtpNgayDen.Text).ToString("yyyy-MM-dd"), Convert.ToDateTime(dtpNgayDi.Text).ToString("yyyy-MM-dd"), cboHinhThucThue.SelectedIndex, lblTongTienPhong.Text, lblTongTienDV.Text, lblTongTien.Text, rtxtGhiChu.Text, cboThanhToan.SelectedIndex, cboHieuLuc.SelectedIndex);
                    dgvDSHD.DataSource = bHD.HoaDon_Select();
                }

            }
           
            if(coCTHD == 2)
            {
                bCTHD.CTHD_CapNhat(txtID_CTHD.Text, txtID_HD.Text, cboTenDV.SelectedValue.ToString(), txtSoLuong.Text, lblDonGia.Text);
                MessageBox.Show("Sữa thành công ");
                bCTHD.HienThiDSCTHD(dgvDSCTHD, Int32.Parse(txtID_HD.Text));
                for (int i = 0; i < dgvDSCTHD.Rows.Count - 1; i++)
                {
                    int SL = Int32.Parse(dgvDSCTHD.Rows[i].Cells[3].Value.ToString());
                    int DG = Int32.Parse(dgvDSCTHD.Rows[i].Cells[4].Value.ToString());
                    TienDV = TienDV + (SL * DG);
                }
                lblTongTienDV.Text = TienDV.ToString();
                lblTongTien.Text = (Int32.Parse(lblTongTienPhong.Text) + Int32.Parse(lblTongTienDV.Text)).ToString();
                bHD.HoaDon_CapNhat(txtID.Text, txtMaHD.Text, cboTenNV.SelectedValue.ToString(), cboTenKH.SelectedValue.ToString(), cboMaPhong.SelectedValue.ToString(), Convert.ToDateTime(dtpNgayLap.Text).ToString("yyyy-MM-dd"), Convert.ToDateTime(dtpNgayDen.Text).ToString("yyyy-MM-dd"), Convert.ToDateTime(dtpNgayDi.Text).ToString("yyyy-MM-dd"), cboHinhThucThue.SelectedIndex, lblTongTienPhong.Text, lblTongTienDV.Text, lblTongTien.Text, rtxtGhiChu.Text, cboThanhToan.SelectedIndex, cboHieuLuc.SelectedIndex);
                dgvDSHD.DataSource = bHD.HoaDon_Select();
            }    
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            xulychucnang(true);
            xulytextbox(true);
            txtID.ReadOnly = true;
            bHD.HienThiTenNV(cboTenNV);
            bHD.HienThiTenKH(cboTenKH);
            bCTHD.HienThiTenDV(cboTenDV, lblDonGia);
            bHD.HienThiMaPhong(cboMaPhong);
            dgvDSHD.DataSource = bHD.HoaDon_Select();
        }


        private void dgvDSHD_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int vt = dgvDSHD.CurrentCell.RowIndex;
                hienthi_textbox(vt);
                int ID_HD = Int32.Parse(dgvDSHD.Rows[vt].Cells[0].Value.ToString());
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
            txtID_HD.Text = dgvDSCTHD.Rows[numrow].Cells[1].Value.ToString();
            cboTenDV.SelectedValue = dgvDSCTHD.Rows[numrow].Cells[2].Value.ToString();
            txtSoLuong.Text = dgvDSCTHD.Rows[numrow].Cells[3].Value.ToString();
            lblDonGia.Text = dgvDSCTHD.Rows[numrow].Cells[4].Value.ToString();
        }
        private void dgvDSCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int vt = dgvDSCTHD.CurrentCell.RowIndex;
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
