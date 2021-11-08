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
    public partial class frmLoaiNhanVien : Form
    {
        public string MaNV = "", LoaiNV = "";
        public frmLoaiNhanVien()
        {
            InitializeComponent();
        }

        public frmLoaiNhanVien(string MaNV, string LoaiNV)
        {
            InitializeComponent();
            this.MaNV = MaNV;
            this.LoaiNV = LoaiNV;
        }
        BUSLoaiNV bLNV = new BUSLoaiNV();
        bool flag = false;

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        void clear_textbox()
        {
            txtTenLoaiNV.Text = "";
        }
        void xulychucnang(Boolean t)
        {
            btnThem.Enabled = t;
            btnXoa.Enabled = t;
            btnSua.Enabled = t;
        }
        void xulychucnangThem(Boolean t)
        {
            btnThem.Enabled = t;
            btnXoa.Enabled = !t;
            btnSua.Enabled = !t;
        }

        void xulychucnangSua(Boolean t)
        {
            btnThem.Enabled = !t;
            btnXoa.Enabled = !t;
            btnSua.Enabled = t;
        }

        void xulytextbox(Boolean t)
        {
            txtTenLoaiNV.ReadOnly = t;
        }

        void hienthi_textbox(int numrow)
        {

           
            txtTenLoaiNV.Text = dgvDSLoaiNV.Rows[numrow].Cells[1].Value.ToString();
            string t = dgvDSLoaiNV.Rows[numrow].Cells[2].Value.ToString();
            if (t == "Còn trống")
            {
                chkHieuLuc.Checked = true;
            }
            else
            {
                chkHieuLuc.Checked = false;
            }
        }


        private void btnThem_Click_1(object sender, EventArgs e)
        {

            if (flag == false)
            {
                clear_textbox();
                xulychucnangThem(true);
                chkHieuLuc.Checked = true;
                flag = true;
            }
            else if (flag == true)
            {
                if (txtTenLoaiNV.Text == "")
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
                    int TangID = bLNV.LoaiNV_selecl().Rows.Count + 1;
                    bLNV.LoaiNV_Them(TangID, txtTenLoaiNV.Text, HieuLuc);
                    MessageBox.Show("Thêm thành công ");
                    flag = false;
                    xulytextbox(true);
                    xulychucnang(true);
                    dgvDSLoaiNV.DataSource = bLNV.LoaiNV_selecl();
                    
                }
            }

        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa loại nhân viên này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bLNV.LoaiNV_Xoa(ID, 0);
                MessageBox.Show("Xóa thành công ");
                dgvDSLoaiNV.DataSource = bLNV.LoaiNV_selecl();
            } 

               
        }

        private void ttnSua_Click(object sender, EventArgs e)
        {
            //xulychucnang(false);
            //xulytextbox(false);
            if (flag==false)
            {
                xulychucnangSua(true);
                xulytextbox(false);
                flag = true;
            }
            else if(flag==true)
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
                xulychucnang(true);
                bLNV.LoaiNV_CapNhat(ID, txtTenLoaiNV.Text, HieuLuc);
                MessageBox.Show("Sữa thành công ");
                flag = false;
                xulytextbox(true);
                xulychucnang(true);
                dgvDSLoaiNV.DataSource = bLNV.LoaiNV_selecl();
            }
        }

      

        private void frmLoaiNhanVien_Load(object sender, EventArgs e)
        {
            dgvDSLoaiNV.DataSource = bLNV.LoaiNV_selecl();
            xulychucnang(true);
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtTim_TextChangeEvent(object sender, EventArgs e)
        {
            bLNV.HienThiDanhSach(txtTim.TextValue, dgvDSLoaiNV);
        }
        int ID;
        private void dgvDSLoaiNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int vt = dgvDSLoaiNV.CurrentCell.RowIndex;
                hienthi_textbox(vt);
                ID= Int32.Parse(dgvDSLoaiNV.Rows[vt].Cells[0].Value.ToString());
            }
            catch(Exception ex)
            {
                
            }
           
        }
    }
}
