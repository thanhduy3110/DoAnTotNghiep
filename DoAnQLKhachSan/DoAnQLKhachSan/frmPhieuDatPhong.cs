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
    public partial class frmPhieuDatPhong : Form
    {
        public frmPhieuDatPhong()
        {
            InitializeComponent();
        }

        BUSPhieuDatPhong bpdp = new BUSPhieuDatPhong();
        bool flag=false;

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if(flag==false)
            {
                clear_textbox();
                txtID.Text = (bpdp.PDP_Select().Rows.Count + 1).ToString();
                flag = true;
            }    
      
            else if (flag == true)
            {
                if (cboTenKH.Text == "" || dtNgayDen.Text == "" || dtNgayDi.Text == "" || cboHinhThucThue.Text == "" || txtSoKH.Text == "" || rtxtGhiChu.Text == "" || cboDaXuLy.Text == "" || cboHieuLuc.Text == "")
                {
                    MessageBox.Show("Lỗi");
                }
                else
                {
                    bpdp.PDP_Them(txtID.Text, cboTenKH.SelectedValue.ToString(), dtNgayDen.Text, dtNgayDi.Text, cboHinhThucThue.Text, txtSoKH.Text, rtxtGhiChu.Text, cboDaXuLy.Text, cboHieuLuc.Text);
                    MessageBox.Show("thêm thành công rồi nè");
                    flag = false;
                    dgvPhieuDatPhong.DataSource = bpdp.PDP_Select();
                }
            }
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(flag == false)
            {
                flag = true;
            }    
            else if (flag == true)
            {
                bpdp.PDP_CapNhat(txtID.Text, cboTenKH.SelectedValue.ToString(), dtNgayDen.Text, dtNgayDi.Text, cboHinhThucThue.Text, txtSoKH.Text, rtxtGhiChu.Text, cboDaXuLy.Text, cboHieuLuc.Text);
                MessageBox.Show("thêm thành công rồi nè");
                flag = false;
                dgvPhieuDatPhong.DataSource = bpdp.PDP_Select();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

      

        private void frmPhieuDatPhong_Load(object sender, EventArgs e)
        {
            bpdp.HienThiID_KH(cboTenKH);
            dgvPhieuDatPhong.DataSource = bpdp.PDP_Select();
        }

        void hienthi_textbox(int numrow)
        {
            txtID.Text = dgvPhieuDatPhong.Rows[numrow].Cells[0].Value.ToString();
            cboTenKH.SelectedValue = dgvPhieuDatPhong.Rows[numrow].Cells[1].Value.ToString();
            dtNgayDen.Text = dgvPhieuDatPhong.Rows[numrow].Cells[2].Value.ToString();
            dtNgayDi.Text = dgvPhieuDatPhong.Rows[numrow].Cells[3].Value.ToString();
            cboHinhThucThue.Text = dgvPhieuDatPhong.Rows[numrow].Cells[4].Value.ToString();
            txtSoKH.Text = dgvPhieuDatPhong.Rows[numrow].Cells[5].Value.ToString();
            rtxtGhiChu.Text = dgvPhieuDatPhong.Rows[numrow].Cells[6].Value.ToString();
            cboDaXuLy.Text = dgvPhieuDatPhong.Rows[numrow].Cells[7].Value.ToString();
            cboHieuLuc.Text = dgvPhieuDatPhong.Rows[numrow].Cells[8].Value.ToString();

        }

        void Tang_ID()
        {
            int count = 0;
            count = dgvPhieuDatPhong.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count <= 1)
            {
                txtID.Text = "0";
            }
            else
            {
                chuoi = Convert.ToString(dgvPhieuDatPhong.Rows[count - 2].Cells[0].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 0)));
                if (chuoi2 + 1 < 10)
                    txtID.Text = "" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 < 100)
                    txtID.Text = "" + (chuoi2 + 1).ToString();
            }
        }
        void clear_textbox()
        {
            cboTenKH.Text = "";
            dtNgayDen.Text = "";
            dtNgayDi.Text = "";
            cboHinhThucThue.Text = "";
            txtSoKH.Text = "";
            rtxtGhiChu.Text = "";
            cboDaXuLy.Text = "";
            cboHieuLuc.Text = "";
        }

        private void dgvPhieuDatPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int vt = dgvPhieuDatPhong.CurrentCell.RowIndex;
                hienthi_textbox(vt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có dữ liệu");
            }
        }

        private void txtTim_TextChangeEvent(object sender, EventArgs e)
        {
            bpdp.HienThiDanhSach(txtTim.TextValue, dgvPhieuDatPhong);
        }
    }
}
