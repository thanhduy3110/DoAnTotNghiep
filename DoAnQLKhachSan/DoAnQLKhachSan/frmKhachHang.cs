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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        BUSKhachHang bkh = new BUSKhachHang();
        void hienthi_textbox(int numrow)
        {
            txtID.Text = dgvKhachHang.Rows[numrow].Cells[0].Value.ToString();
            txtHoTen.Text = dgvKhachHang.Rows[numrow].Cells[1].Value.ToString();
            dtNgaySinh.Text = dgvKhachHang.Rows[numrow].Cells[2].Value.ToString();
            txtSDT.Text = dgvKhachHang.Rows[numrow].Cells[3].Value.ToString();
            txtEmail.Text = dgvKhachHang.Rows[numrow].Cells[4].Value.ToString();
            txtCMND.Text = dgvKhachHang.Rows[numrow].Cells[5].Value.ToString();
            cboGioiTinh.Text = dgvKhachHang.Rows[numrow].Cells[6].Value.ToString();
            cboQuocTich.Text = dgvKhachHang.Rows[numrow].Cells[7].Value.ToString();
            cboHieuLuc.Text = dgvKhachHang.Rows[numrow].Cells[8].Value.ToString();

        }
        int flag;
        void Tang_ID()
        {
            int count = 0;
            count = dgvKhachHang.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count <= 1)
            {
                txtID.Text = "0";
            }
            else
            {
                chuoi = Convert.ToString(dgvKhachHang.Rows[count - 2].Cells[0].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 0)));
                if (chuoi2 + 1 < 10)
                    txtID.Text = "" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 < 100)
                    txtID.Text = "" + (chuoi2 + 1).ToString();
            }
        }
        void clear_textbox()
        {
            txtHoTen.Text = "";
            dtNgaySinh.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtCMND.Text = "";
            cboGioiTinh.Text = "";
            cboQuocTich.Text = "";
            cboHieuLuc.Text = "";
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            Tang_ID();
            clear_textbox();
            flag = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 2;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                if (txtHoTen.Text == "" || dtNgaySinh.Text == "" || txtSDT.Text == "" || txtCMND.Text == "" || cboGioiTinh.Text == "" || cboQuocTich.Text == "" || cboHieuLuc.Text == "")
                {
                    MessageBox.Show("Lỗi");
                }
                else
                {
                    bkh.KH_Them(txtID.Text, txtHoTen.Text, dtNgaySinh.Text, txtSDT.Text, txtEmail.Text, txtCMND.Text, cboGioiTinh.Text, cboQuocTich.Text, cboHieuLuc.Text);
                    MessageBox.Show("thêm thành công rồi nè");
                    dgvKhachHang.DataSource = bkh.KH_Select();
                }
            }
            if (flag == 2)
            {
                bkh.KH_CapNhat(txtID.Text, txtHoTen.Text, dtNgaySinh.Text, txtSDT.Text, txtEmail.Text, txtCMND.Text, cboGioiTinh.Text, cboQuocTich.Text, cboHieuLuc.Text);
                MessageBox.Show("thêm thành công rồi nè");
                dgvKhachHang.DataSource = bkh.KH_Select();
            }
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = bkh.KH_Select();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = dgvKhachHang.CurrentCell.RowIndex;
            hienthi_textbox(vt);
        }
    }
}
