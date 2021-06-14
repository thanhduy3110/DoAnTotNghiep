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
    public partial class frmQLLoaiDV : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmQLLoaiDV()
        {
            InitializeComponent();
        }
        BUSLoaiDV ldv = new BUSLoaiDV();
        void Tang_ID()
        {
            int count = 0;
            count = dgvLoaiDV.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count <= 1)
            {
                txtID.Text = "0";
            }
            else
            {
                chuoi = Convert.ToString(dgvLoaiDV.Rows[count - 2].Cells[0].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 0)));
                if (chuoi2 + 1 < 10)
                    txtID.Text = "" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 < 100)
                    txtID.Text = "" + (chuoi2 + 1).ToString();
            }
        }

        private void btnHome_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
          
        }
        void clear_textbox()
        {
            txtTenLoaiDV.Text = "";
            cboHieuLuc.Text = "";         
        }
        int flag;
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
                if (txtTenLoaiDV.Text == "" || cboHieuLuc.Text == "")
                {
                    MessageBox.Show("Lỗi");
                }
                else
                {
                    ldv.LDV_Them(txtID.Text,txtTenLoaiDV.Text,cboHieuLuc.Text);
                    MessageBox.Show("thêm thành công rồi nè");
                    dgvLoaiDV.DataSource = ldv.LDV_Select();
                }
            }
            if (flag == 2)
            {
                ldv.LDV_CapNhat(txtID.Text, txtTenLoaiDV.Text, cboHieuLuc.Text);
                MessageBox.Show("sửa thành công rồi nè");
                dgvLoaiDV.DataSource = ldv.LDV_Select();
            }
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void frmQLLoaiDV_Load(object sender, EventArgs e)
        {
            dgvLoaiDV.DataSource = ldv.LDV_Select();
        }
        void hienthi_textbox(int numrow)
        {
            txtID.Text = dgvLoaiDV.Rows[numrow].Cells[0].Value.ToString();
            txtTenLoaiDV.Text = dgvLoaiDV.Rows[numrow].Cells[1].Value.ToString();
            cboHieuLuc.Text = dgvLoaiDV.Rows[numrow].Cells[2].Value.ToString();
        }
        private void dgvLoaiDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = dgvLoaiDV.CurrentCell.RowIndex;
            hienthi_textbox(vt);
        }
    }
}