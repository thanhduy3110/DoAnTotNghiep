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

        void Tang_ID()
        {
            int count = 0;
            count = dgvDSLoaiNV.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count <= 1)
            {
                txtID.Text = "0";
            }
            else
            {
                chuoi = Convert.ToString(dgvDSLoaiNV.Rows[count - 2].Cells[0].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 0)));
                if (chuoi2 + 1 < 10)
                    txtID.Text = "" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 < 100)
                    txtID.Text = "" + (chuoi2 + 1).ToString();
            }
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

        void xulytextbox(Boolean t)
        {
            txtTenLoaiNV.ReadOnly = t;
        }

        void hienthi_textbox(int numrow)
        {

            txtID.Text = dgvDSLoaiNV.Rows[numrow].Cells[0].Value.ToString();
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
                xulytextbox(false);
                txtID.Text = (bLNV.LoaiNV_selecl().Rows.Count + 1).ToString();
                chkHieuLuc.Checked = false;
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
                        
                    bLNV.LoaiNV_Them(Int32.Parse(txtID.Text), txtTenLoaiNV.Text, HieuLuc);
                    MessageBox.Show("Thêm thành công ");
                    flag = false;
                    dgvDSLoaiNV.DataSource = bLNV.LoaiNV_selecl();
                    
                }
            }

        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            bLNV.LoaiNV_Xoa(Int32.Parse(txtID.Text), 0);
            MessageBox.Show("Xóa thành công ");
            dgvDSLoaiNV.DataSource = bLNV.LoaiNV_selecl();
        }

        private void ttnSua_Click(object sender, EventArgs e)
        {
            //xulychucnang(false);
            //xulytextbox(false);
            if (flag==false)
            {
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
                bLNV.LoaiNV_CapNhat(Int32.Parse(txtID.Text), txtTenLoaiNV.Text, HieuLuc);
                MessageBox.Show("Sữa thành công ");
                flag = false;
                dgvDSLoaiNV.DataSource = bLNV.LoaiNV_selecl();
            }
        }

      

        private void frmLoaiNhanVien_Load(object sender, EventArgs e)
        {
            dgvDSLoaiNV.DataSource = bLNV.LoaiNV_selecl();
            xulychucnang(true);
            xulytextbox(true);
            txtID.ReadOnly = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtTim_TextChangeEvent(object sender, EventArgs e)
        {
            bLNV.HienThiDanhSach(txtTim.TextValue, dgvDSLoaiNV);
        }

        private void dgvDSLoaiNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int vt = dgvDSLoaiNV.CurrentCell.RowIndex;
                hienthi_textbox(vt);
            }
            catch(Exception ex)
            {
                
            }
           
        }
    }
}
