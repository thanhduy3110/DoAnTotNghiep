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
    public partial class frmPhongDaDat : Form
    {
        private int IDNV;
        public frmPhongDaDat()
        {
            InitializeComponent();
        }
        public frmPhongDaDat(int IDNV)
        {
            this.IDNV = IDNV;
            InitializeComponent();
        }

        BUSPhongDaDat bPDD = new BUSPhongDaDat();
        BUSHoaDon bHD = new BUSHoaDon();
        BUSPhieuDatPhong bPhieuDP = new BUSPhieuDatPhong();
        bool flag=false;
        //void Tang_ID()
        //{
        //    int count = 0;
        //    count = dgvPhongDaDat.Rows.Count;
        //    string chuoi = "";
        //    int chuoi2 = 0;
        //    if (count <= 1)
        //    {
        //        txtID.Text = "0";
        //    }
        //    else
        //    {
        //        chuoi = Convert.ToString(dgvPhongDaDat.Rows[count - 2].Cells[0].Value);
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

        void clear_textbox()
        {
            cboMaPhong.Text = "";
            dtpNgayDen.Text = "";
            dtpNgayDi.Text = "";
        }
        void xulychucnang(Boolean t)
        {
            btnThem.Enabled = t;
            btnXoa.Enabled = t;
            btnSua.Enabled = t;

        }

        void hienthi_textbox(int numrow)
        {
            try
            {

                txtTenKH.Text = dgvPhongDaDat.Rows[numrow].Cells[2].Value.ToString();
                cboSDTKH.Text = dgvPhongDaDat.Rows[numrow].Cells[3].Value.ToString();
                cboMaPhong.Text = dgvPhongDaDat.Rows[numrow].Cells[8].Value.ToString();
                dtpNgayDen.Text = dgvPhongDaDat.Rows[numrow].Cells[9].Value.ToString();
                dtpNgayDi.Text = dgvPhongDaDat.Rows[numrow].Cells[10].Value.ToString();
            }
            catch (Exception ex)
            {

            }

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (flag == false)
            {
                clear_textbox();

                flag = true;
            }

            else if (flag == true)
            {

                if (cboMaPhong.Text == "")
                {
                    MessageBox.Show("Lỗi");
                }
                else
                {
                    string TangID = (bPDD.PhongDaDat_Select().Rows.Count + 1).ToString();
                    xulychucnang(true);
                    bPDD.PhongDaDat_Them( cboSDTKH.SelectedValue.ToString(), cboMaPhong.SelectedValue.ToString(), dtpNgayDen.Text, dtpNgayDi.Text);
                    MessageBox.Show("Thêm thành công ");
                    flag = false;
                    dgvPhongDaDat.DataSource = bPDD.PhongDaDat_Select();
                }
            }


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa phiếu đặt phòng này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool HL = false;
                bPDD.PhongDaDat_Xoa(ID.ToString());
                dgvPhongDaDat.DataSource = bPDD.PhongDaDat_Select();
            }
            }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(flag==false)
            {
                flag = true;
            }    
            else if (flag == true)
            {
                if (cboMaPhong.Text == "")
                {
                    MessageBox.Show("Lỗi");
                }
                else
                {
                    xulychucnang(true);
                    bPDD.PhongDaDat_CapNhat(ID.ToString(), cboSDTKH.SelectedValue.ToString(), cboMaPhong.SelectedValue.ToString(), dtpNgayDen.Text, dtpNgayDi.Text);
                    MessageBox.Show("Sữa thành công ");
                    flag = false;
                    dgvPhongDaDat.DataSource = bPDD.PhongDaDat_Select();
                }
            }
        }


        int ID,IDPHONG,ID_PhieuDat;
        string TenKH, SDT, HTT, GTN, GTG, ID_KH, SoPhong, NgayDen, NgayDi;
        private void dgvPhongDaDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int vt = dgvPhongDaDat.CurrentCell.RowIndex;
                hienthi_textbox(vt);
                ID = Int32.Parse(dgvPhongDaDat.Rows[vt].Cells[0].Value.ToString());
                ID_PhieuDat = Int32.Parse(dgvPhongDaDat.Rows[vt].Cells[1].Value.ToString());
                TenKH = dgvPhongDaDat.Rows[vt].Cells[2].Value.ToString();
                SDT = dgvPhongDaDat.Rows[vt].Cells[3].Value.ToString();
               
                GTN = dgvPhongDaDat.Rows[vt].Cells[5].Value.ToString();
                GTG = dgvPhongDaDat.Rows[vt].Cells[6].Value.ToString();
                ID_KH = dgvPhongDaDat.Rows[vt].Cells[7].Value.ToString();


            }
            catch (Exception ex)
            {
                
            }
        }

        private void frmPhongDaDat_Load(object sender, EventArgs e)
        {

            txtTenKH.ReadOnly = true;
            txtSoKhach.ReadOnly = true;
            xulychucnang(true);
            //bPDD.HienThiID_PDD(cboID_PDP, dtpNgayDen, dtpNgayDi);
            bPDD.HienThiMaPhong(cboMaPhong,txtSoKhach);
            bPDD.HienThiSDT(cboSDTKH,dtpNgayDen,dtpNgayDi,txtTenKH);
            dgvPhongDaDat.DataSource = bPDD.PhongDaDat_Select();
        }

        private void txtTim_TextChangeEvent(object sender, EventArgs e)
        {
            bPDD.HienThiDanhSach(txtTim.TextValue, dgvPhongDaDat);
        }

        string PhatSinhMaTuDong()
        {
            string MaHD;
            int dem = bHD.HoaDon_PhatSinhMa().Rows.Count + 1;
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
        int TienPhong, TongTienPhong,GioThue,HinhTT;
        string TangMaHD;
      
       
        


        private void btnXacNhanDatPhong_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Đồng ý xác nhận đặt phòng?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

               
                TangMaHD = PhatSinhMaTuDong();
                for (int i = 0; i < dgvPhongDaDat.Rows.Count - 1; i++)
                {

                    if (ID_KH == dgvPhongDaDat.Rows[i].Cells[7].Value.ToString())
                    {
                        int IDD = Int32.Parse(dgvPhongDaDat.Rows[i].Cells[0].Value.ToString());
                        HTT = dgvPhongDaDat.Rows[i].Cells[4].Value.ToString();
                        SoPhong = dgvPhongDaDat.Rows[i].Cells[8].Value.ToString();
                        NgayDen = dgvPhongDaDat.Rows[i].Cells[9].Value.ToString();
                        NgayDi = dgvPhongDaDat.Rows[i].Cells[10].Value.ToString();
                        IDPHONG = Int32.Parse(dgvPhongDaDat.Rows[i].Cells[11].Value.ToString());
                        if (HTT == "Thuê theo ngày")
                        {
                            HinhTT = 0;
                            TienPhong = Int32.Parse(bHD.TienPhong(Int32.Parse(SoPhong)).Rows[0][0].ToString());
                            TongTienPhong = TienPhong * ((ThoiGianThue(GioThue) / 24));
                        }
                        else
                        {
                            HinhTT = 1;
                            TienPhong = Int32.Parse(bHD.TienPhong(Int32.Parse(SoPhong)).Rows[0][1].ToString());
                            TongTienPhong = TienPhong * (ThoiGianThue(GioThue));
                        }

                        int TangID = bHD.HoaDon_Select().Rows.Count + 1;
                        bHD.HoaDon_Them(TangID, TangMaHD, IDNV.ToString(), ID_KH, IDPHONG.ToString(), Convert.ToDateTime(DateTime.Now).ToString("yyyy/MM/dd hh:mm"), Convert.ToDateTime(NgayDen).ToString("yyyy/MM/dd hh:mm"), Convert.ToDateTime(NgayDi).ToString("yyyy/MM/dd hh:mm"), HinhTT, TongTienPhong, "0", TongTienPhong, "Không", false, true);
                        bPDD.PhongDaDat_Xoa(IDD.ToString());
                    }

                }

                MessageBox.Show("Xác nhận hoàn tất");
                bPhieuDP.phieudatphong_XuLy(ID_PhieuDat, true);
                dgvPhongDaDat.DataSource = bPDD.PhongDaDat_Select();

            }

        }
        private int KTThang(int iThang, int iNam)
        {
            int Ngay = 0;
            if (iThang == 1 || iThang == 3 || iThang == 5 || iThang == 7 || iThang == 8 || iThang == 10 || iThang == 12)
            {
                Ngay = 31; ;
            }
            else if (iThang == 4 || iThang == 6 || iThang == 9 || iThang == 11)
            {
                Ngay = 30;
            }
            else if (iThang == 2 && iNam % 4 == 0)
            {
                Ngay = 29;
            }
            else
            {
                Ngay = 28;
            }
            return Ngay;

        }
        private int ThoiGianThue(int iGio)
        {
            if (dtpNgayDen.Value.Month == dtpNgayDi.Value.Month && dtpNgayDen.Value.Year == dtpNgayDi.Value.Year)
            {
                iGio = (dtpNgayDi.Value.Day - dtpNgayDen.Value.Day) * 24;
            }
            else if (dtpNgayDi.Value.Month > dtpNgayDen.Value.Month && dtpNgayDen.Value.Year == dtpNgayDi.Value.Year)
            {
                iGio = ((KTThang(dtpNgayDen.Value.Month, dtpNgayDen.Value.Year) - dtpNgayDen.Value.Day) + dtpNgayDi.Value.Day) * 24;
            }

            return iGio;
        }

    }
}
