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
    public partial class frmPhong : Form
    {
        public frmPhong()
        {
            InitializeComponent();
        }

        BUSPhong Bphong = new BUSPhong();
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void frmPhong_Load(object sender, EventArgs e)
        {
            Bphong.HienThiLP(cboTenLP);
            dgvDSPhong.DataSource = Bphong.Phong_Select();

        }
        void hienthi_textbox(int numrow)
        {
            txtID.Text = dgvDSPhong.Rows[numrow].Cells[0].Value.ToString();
            cboTenLP.SelectedValue = dgvDSPhong.Rows[numrow].Cells[1].Value.ToString();
            txtTang.Text = dgvDSPhong.Rows[numrow].Cells[2].Value.ToString();
            txtSoPhong.Text = dgvDSPhong.Rows[numrow].Cells[3].Value.ToString();
            txtGiaThueTheoNgay.Text = dgvDSPhong.Rows[numrow].Cells[4].Value.ToString();
            txtGiaThueTheoGio.Text = dgvDSPhong.Rows[numrow].Cells[5].Value.ToString();
            rtxtGhiChu.Text = dgvDSPhong.Rows[numrow].Cells[6].Value.ToString();
            cboGocNhin.Text = dgvDSPhong.Rows[numrow].Cells[7].Value.ToString();
            cboBonTam.Text = dgvDSPhong.Rows[numrow].Cells[8].Value.ToString();
            cboConTrong.Text = dgvDSPhong.Rows[numrow].Cells[9].Value.ToString();
            cboHieuLuc.Text = dgvDSPhong.Rows[numrow].Cells[10].Value.ToString();
        }

       
        int flag;
        void Tang_ID()
        {
            int count = 0;
            count = dgvDSPhong.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count <= 1)
            {
                txtID.Text = "0";
            }
            else
            {
                chuoi = Convert.ToString(dgvDSPhong.Rows[count - 2].Cells[0].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 0)));
                if (chuoi2 + 1 < 10)
                    txtID.Text = "" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 < 100)
                    txtID.Text = "" + (chuoi2 + 1).ToString();
            }
        }
        void clear_textbox()
        {
            cboTenLP.Text = "";
            txtTang.Text = "";
            txtTang.Text = "";
            txtGiaThueTheoGio.Text = "";
            txtGiaThueTheoNgay.Text = "";
            rtxtGhiChu.Text = "";
            cboGocNhin.Text = "";
            cboGocNhin.Text = "";
            cboConTrong.Text = "";
            cboHieuLuc.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
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
                if (cboTenLP.Text == "" || txtTang.Text == "" || txtTang.Text == "" || txtGiaThueTheoNgay.Text == "" || txtGiaThueTheoGio.Text == "" || rtxtGhiChu.Text == "" || cboGocNhin.Text == "" || cboBonTam.Text == "" || cboConTrong.Text == "" || cboHieuLuc.Text == "")
                {
                    MessageBox.Show("Lỗi");
                }
                else
                {
                    Bphong.P_Them(txtID.Text, cboTenLP.SelectedValue.ToString(), txtTang.Text, txtTang.Text, txtGiaThueTheoNgay.Text, txtGiaThueTheoGio.Text, rtxtGhiChu.Text, cboGocNhin.Text, cboBonTam.Text, cboConTrong.Text, cboHieuLuc.Text);
                    MessageBox.Show("thêm thành công rồi nè");
                    dgvDSPhong.DataSource = Bphong.Phong_Select();
                }
            }
            if (flag == 2)
            {
                Bphong.P_CapNhat(txtID.Text, cboTenLP.SelectedValue.ToString(), txtTang.Text, txtTang.Text, txtGiaThueTheoNgay.Text, txtGiaThueTheoGio.Text, rtxtGhiChu.Text, cboGocNhin.Text, cboBonTam.Text, cboConTrong.Text, cboHieuLuc.Text);
                MessageBox.Show("sửa thành công rồi nè");
                dgvDSPhong.DataSource = Bphong.Phong_Select();
            }
        }

        private void dgvDSPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = dgvDSPhong.CurrentCell.RowIndex;
            hienthi_textbox(vt);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
