using DevExpress.XtraBars;
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

namespace QLKhachSan
{
    public partial class frmQLPhieuDatPhong : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BUSPhieuDatPhong bpdp = new BUSPhieuDatPhong();
        public frmQLPhieuDatPhong()
        {
            InitializeComponent();
        }
        

        private void btnHome_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
          
        }

        private void frmQLPhieuDatPhong_Load(object sender, EventArgs e)
        {
            bpdp.HienThiID_KH(cboID_KH);
            dgvPhieuDatPhong.DataSource = bpdp.PDP_Select();
        }
        void hienthi_textbox(int numrow)
        {
            txtID.Text = dgvPhieuDatPhong.Rows[numrow].Cells[0].Value.ToString();
            cboID_KH.SelectedValue = dgvPhieuDatPhong.Rows[numrow].Cells[1].Value.ToString();
            dtNgayDen.Text = dgvPhieuDatPhong.Rows[numrow].Cells[2].Value.ToString();
            dtNgayDi.Text = dgvPhieuDatPhong.Rows[numrow].Cells[3].Value.ToString();
            cboHinhThucThue.Text = dgvPhieuDatPhong.Rows[numrow].Cells[4].Value.ToString();
            txtSoKhach.Text = dgvPhieuDatPhong.Rows[numrow].Cells[5].Value.ToString();
            rtxtGhiChu.Text = dgvPhieuDatPhong.Rows[numrow].Cells[6].Value.ToString();
            cboDaXuLy.Text = dgvPhieuDatPhong.Rows[numrow].Cells[7].Value.ToString();
            cboHieuLuc.Text = dgvPhieuDatPhong.Rows[numrow].Cells[8].Value.ToString();

        }
        int flag;
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
            cboID_KH.Text = "";
            dtNgayDen.Text = "";
            dtNgayDi.Text = "";
            cboHinhThucThue.Text = "";
            txtSoKhach.Text = "";
            rtxtGhiChu.Text = "";
            cboDaXuLy.Text = "";
            cboHieuLuc.Text = "";
        }
        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Tang_ID();
            clear_textbox();
            flag = 1;
        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            flag = 2;
        }

        private void btnLuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (flag == 1)
            {
                if (cboID_KH.Text == "" || dtNgayDen.Text == "" || dtNgayDi.Text == "" || cboHinhThucThue.Text == "" || txtSoKhach.Text == "" || rtxtGhiChu.Text == "" || cboDaXuLy.Text == "" || cboHieuLuc.Text == "")
                {
                    MessageBox.Show("Lỗi");
                }
                else
                {
                    bpdp.PDP_Them(txtID.Text, cboID_KH.SelectedValue.ToString(), dtNgayDen.Text, dtNgayDi.Text, cboHinhThucThue.Text, txtSoKhach.Text, rtxtGhiChu.Text, cboDaXuLy.Text,cboHieuLuc.Text);
                    MessageBox.Show("thêm thành công rồi nè");
                    dgvPhieuDatPhong.DataSource = bpdp.PDP_Select();
                }
            }
            if (flag == 2)
            {
                bpdp.PDP_CapNhat(txtID.Text, cboID_KH.SelectedValue.ToString(), dtNgayDen.Text, dtNgayDi.Text, cboHinhThucThue.Text, txtSoKhach.Text, rtxtGhiChu.Text, cboDaXuLy.Text, cboHieuLuc.Text);
                MessageBox.Show("thêm thành công rồi nè");
                dgvPhieuDatPhong.DataSource = bpdp.PDP_Select();
            }
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void dgvPhieuDatPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                int vt = dgvPhieuDatPhong.CurrentCell.RowIndex;
                hienthi_textbox(vt);
            }
        }
    }
}