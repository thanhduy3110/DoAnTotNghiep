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
    public partial class frmQLLoaiPhong : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int id;
        BUSLoaiPhong blp = new BUSLoaiPhong();
        public frmQLLoaiPhong()
        {
            InitializeComponent();
        }

        private void btnHome_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
           
        }
        void Tang_ID()
        {
            int count = 0;
            count = dgvLoaiPhong.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count <= 1)
            {
                txtID.Text = "0";
            }
            else
            {
                chuoi = Convert.ToString(dgvLoaiPhong.Rows[count - 2].Cells[0].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 0)));
                if (chuoi2 + 1 < 10)
                    txtID.Text = "" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 < 100)
                    txtID.Text = "" + (chuoi2 + 1).ToString();
            }
        }
        void clear_textbox()
        {
            Tang_ID();
            txtTenLoaiPhong.Text = "";
            txtSoGiuongDoi.Text = "";
            txtSoGiuongDon.Text = "";
            txtSoKhach.Text = "";
            cbHieuLuc.Text = "";
        }
        void hienthi_textbox(int numrow)
        {
            txtID.Text = dgvLoaiPhong.Rows[numrow].Cells[0].Value.ToString();
            txtTenLoaiPhong.Text = dgvLoaiPhong.Rows[numrow].Cells[1].Value.ToString();
            txtSoGiuongDoi.Text = dgvLoaiPhong.Rows[numrow].Cells[2].Value.ToString();
            txtSoGiuongDon.Text = dgvLoaiPhong.Rows[numrow].Cells[3].Value.ToString();
            txtSoKhach.Text = dgvLoaiPhong.Rows[numrow].Cells[4].Value.ToString();
            cbHieuLuc.Text = dgvLoaiPhong.Rows[numrow].Cells[5].Value.ToString();
        }
        int flag;
        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            clear_textbox();
            flag = 1;
        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            flag = 2;
        }

        private void btnLuu_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (flag == 1)
            {
                if (txtTenLoaiPhong.Text == "" || txtSoGiuongDoi.Text == "" || txtSoGiuongDon.Text == "" || txtSoKhach.Text == "" || cbHieuLuc.Text == "")
                {
                    MessageBox.Show("Lỗi");
                }
                else
                {
                    blp.LP_Them(txtID.Text, txtTenLoaiPhong.Text, txtSoGiuongDoi.Text, txtSoGiuongDon.Text, txtSoKhach.Text, cbHieuLuc.Text);
                    MessageBox.Show("thêm thành công rồi nè");
                    dgvLoaiPhong.DataSource = blp.LP_Select();
                }
            }
            if (flag == 2)
            {
                blp.LP_CapNhat(txtID.Text, txtTenLoaiPhong.Text, txtSoGiuongDoi.Text, txtSoGiuongDon.Text, txtSoKhach.Text, cbHieuLuc.Text);
                MessageBox.Show("sửa thành công rồi nè");
                dgvLoaiPhong.DataSource = blp.LP_Select();
            }
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            blp.LP_Xoa(txtID.Text);
            MessageBox.Show("Xóa thành công rồi nè");
            dgvLoaiPhong.DataSource = blp.LP_Select();
        }

        private void dgvLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = dgvLoaiPhong.CurrentCell.RowIndex;
            hienthi_textbox(vt);
        }

        private void frmQLLoaiPhong_Load(object sender, EventArgs e)
        {
            dgvLoaiPhong.DataSource = blp.LP_Select();
        }
    }
}