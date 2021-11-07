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
       
        void clear_textbox()
        {
            txtTenLoaiDV.Text = "";
        }
        void xulytextbox(bool t)
        {
            txtTenLoaiDV.ReadOnly = t;
        }
        bool flag=false;

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if(flag==false)
            {
                clear_textbox();
                xulytextbox(false);
                chkHieuLuc.Checked = true;
                flag = true;
            }    
            
            else if (flag == true)
            {
                if (txtTenLoaiDV.Text == "" )
                {
                    MessageBox.Show("Lỗi");
                }
                else
                {
                    bool HieuLuc;
                    if (chkHieuLuc.Checked == true)
                    {
                        HieuLuc = true;
                    }
                    else
                    {
                        HieuLuc = false;
                    }
                    string TangID= (ldv.LDV_Select().Rows.Count + 1).ToString();
                    ldv.LDV_Them(TangID, txtTenLoaiDV.Text, HieuLuc);
                    MessageBox.Show("Thêm thành công");
                    flag = false;
                    xulytextbox(true);
                    dgvLoaiDV.DataSource = ldv.LDV_Select();
                }
            }
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa loại dịch vụ này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool HL = false;
                ldv.loaidv_xoa(ID, HL);
                dgvLoaiDV.DataSource =ldv.LDV_Select();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(flag==false)
            {
                xulytextbox(false);
                flag = true;
            }    
            else if (flag == true)
            {
                bool HieuLuc;
                if (chkHieuLuc.Checked == true)
                {
                    HieuLuc = true;
                }
                else
                {
                    HieuLuc = false;
                }
                ldv.LDV_CapNhat(ID.ToString(), txtTenLoaiDV.Text, HieuLuc);
                MessageBox.Show("sửa thành công");
                flag = false;
                xulytextbox(true);
                dgvLoaiDV.DataSource = ldv.LDV_Select();
            }
        }

     

        void hienthi_textbox(int numrow)
        {
           
            txtTenLoaiDV.Text = dgvLoaiDV.Rows[numrow].Cells[1].Value.ToString();
           string HL = dgvLoaiDV.Rows[numrow].Cells[2].Value.ToString();
            if(HL=="Còn")
            {
                chkHieuLuc.Checked = true;
            }    
            else
            {
                chkHieuLuc.Checked = false;
            }    
        }
        int ID;
        private void dgvLoaiDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int vt = dgvLoaiDV.CurrentCell.RowIndex;
                hienthi_textbox(vt);
                ID = Int32.Parse(dgvLoaiDV.Rows[vt].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                
            }
        }

        private void frmLoaiDichVu_Load(object sender, EventArgs e)
        {
            xulytextbox(true);
            dgvLoaiDV.DataSource = ldv.LDV_Select();
        }

        private void txtTim_TextChangeEvent(object sender, EventArgs e)
        {
            ldv.HienThiDanhSach(txtTim.TextValue, dgvLoaiDV);
        }

       
    }
}
