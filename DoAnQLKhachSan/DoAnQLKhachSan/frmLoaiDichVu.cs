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
    public partial class frmLoaiDichVu : Form
    {
        public frmLoaiDichVu()
        {
            InitializeComponent();
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
        void clear_textbox()
        {
            txtTenLoaiDV.Text = "";
            cboHieuLuc.Text = "";
        }
        bool flag=false;

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if(flag==false)
            {
                clear_textbox();
                txtID.Text = (ldv.LDV_Select().Rows.Count+1).ToString();
                flag = true;
            }    
            
            else if (flag == true)
            {
                if (txtTenLoaiDV.Text == "" || cboHieuLuc.Text == "")
                {
                    MessageBox.Show("Lỗi");
                }
                else
                {
                    ldv.LDV_Them(txtID.Text, txtTenLoaiDV.Text, cboHieuLuc.Text);
                    MessageBox.Show("thêm thành công rồi nè");
                    flag = false;
                    dgvLoaiDV.DataSource = ldv.LDV_Select();
                }
            }
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(flag==false)
            {
                flag = true;
            }    
            if (flag == true)
            {
                ldv.LDV_CapNhat(txtID.Text, txtTenLoaiDV.Text, cboHieuLuc.Text);
                MessageBox.Show("sửa thành công rồi nè");
                flag = false;
                dgvLoaiDV.DataSource = ldv.LDV_Select();
            }
        }

     

        void hienthi_textbox(int numrow)
        {
            txtID.Text = dgvLoaiDV.Rows[numrow].Cells[0].Value.ToString();
            txtTenLoaiDV.Text = dgvLoaiDV.Rows[numrow].Cells[1].Value.ToString();
            cboHieuLuc.Text = dgvLoaiDV.Rows[numrow].Cells[2].Value.ToString();
        }

        private void dgvLoaiDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int vt = dgvLoaiDV.CurrentCell.RowIndex;
                hienthi_textbox(vt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có dữ liệu");
            }
        }

        private void frmLoaiDichVu_Load(object sender, EventArgs e)
        {
            dgvLoaiDV.DataSource = ldv.LDV_Select();
        }

        private void txtTim_TextChangeEvent(object sender, EventArgs e)
        {
            ldv.HienThiDanhSach(txtTim.TextValue, dgvLoaiDV);
        }
    }
}
