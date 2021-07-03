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
        public frmPhongDaDat()
        {
            InitializeComponent();
        }

        BUSPhongDaDat bPDD = new BUSPhongDaDat();
        int flag;
        void Tang_ID()
        {
            int count = 0;
            count = dgvPhongDaDat.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count <= 1)
            {
                txtID.Text = "0";
            }
            else
            {
                chuoi = Convert.ToString(dgvPhongDaDat.Rows[count - 2].Cells[0].Value);
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

        void clear_textbox()
        {
            Tang_ID();
            cboID_PDP.Text = "";
            cboMaPhong.Text = "";
            dtpNgayDen.Text = "";
            dtpNgayDi.Text = "";
        }
        void xulychucnang(Boolean t)
        {
            btnThem.Enabled = t;
            btnXoa.Enabled = t;
            btnSua.Enabled = t;
            btnLuu.Enabled = !t;

        }

        void hienthi_textbox(int numrow)
        {
            try
            {
                txtID.Text = dgvPhongDaDat.Rows[numrow].Cells[0].Value.ToString();
                cboID_PDP.SelectedValue = dgvPhongDaDat.Rows[numrow].Cells[1].Value.ToString();
                cboMaPhong.SelectedValue = dgvPhongDaDat.Rows[numrow].Cells[2].Value.ToString();
                dtpNgayDen.Text = dgvPhongDaDat.Rows[numrow].Cells[3].Value.ToString();
                dtpNgayDi.Text = dgvPhongDaDat.Rows[numrow].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {

            }

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            xulychucnang(false);
            clear_textbox();
            flag = 1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulychucnang(false);
            flag = 2;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {

                if (cboID_PDP.Text == "" || cboMaPhong.Text == "")
                {
                    MessageBox.Show("Lỗi");
                }
                else
                {
                    xulychucnang(true);
                    bPDD.PhongDaDat_Them(txtID.Text, cboID_PDP.SelectedValue.ToString(), cboMaPhong.SelectedValue.ToString(), dtpNgayDen.Text, dtpNgayDi.Text);
                    MessageBox.Show("Thêm thành công ");
                    dgvPhongDaDat.DataSource = bPDD.PhongDaDat_Select();
                }
            }
            if (flag == 2)
            {
                if (cboID_PDP.Text == "" || cboMaPhong.Text == "")
                {
                    MessageBox.Show("Lỗi");
                }
                else
                {
                    xulychucnang(true);
                    bPDD.PhongDaDat_CapNhat(txtID.Text, cboID_PDP.SelectedValue.ToString(), cboMaPhong.SelectedValue.ToString(), dtpNgayDen.Text, dtpNgayDi.Text);
                    MessageBox.Show("Sữa thành công ");
                    dgvPhongDaDat.DataSource = bPDD.PhongDaDat_Select();
                }
            }
        }

        private void dgvPhongDaDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int vt = dgvPhongDaDat.CurrentCell.RowIndex;
                hienthi_textbox(vt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có dữ liệu");
            }
        }

        private void frmPhongDaDat_Load(object sender, EventArgs e)
        {
            txtID.ReadOnly = true;
            xulychucnang(true);
            bPDD.HienThiID_PDD(cboID_PDP, dtpNgayDen, dtpNgayDi);
            bPDD.HienThiMaPhong(cboMaPhong);
            dgvPhongDaDat.DataSource = bPDD.PhongDaDat_Select();
        }

        private void txtTim_TextChangeEvent(object sender, EventArgs e)
        {
            bPDD.HienThiDanhSach(txtTim.TextValue, dgvPhongDaDat);
        }
    }
}
