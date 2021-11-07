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
    public partial class frmLoaiPhong : Form
    {
        public frmLoaiPhong()
        {
            InitializeComponent();
        }
        BUSLoaiPhong blp = new BUSLoaiPhong();

        
        void clear_textbox()
        {
            txtTenLoaiPhong.Text = "";
            txtSoGiuongDoi.Text = "";
            txtSoGiuongDon.Text = "";
            txtSoKhach.Text = "";
        }
        void xulytextbox(bool t)
        {
            txtTenLoaiPhong.ReadOnly = t;
            txtSoGiuongDoi.ReadOnly = t;
            txtSoGiuongDon.ReadOnly = t;
            txtSoKhach.ReadOnly = t;
            
        }
        void hienthi_textbox(int numrow)
        {
            
            txtTenLoaiPhong.Text = dgvDSLoaiPhong.Rows[numrow].Cells[1].Value.ToString();
            txtSoGiuongDoi.Text = dgvDSLoaiPhong.Rows[numrow].Cells[2].Value.ToString();
            txtSoGiuongDon.Text = dgvDSLoaiPhong.Rows[numrow].Cells[3].Value.ToString();
            txtSoKhach.Text = dgvDSLoaiPhong.Rows[numrow].Cells[4].Value.ToString();
            string HL = dgvDSLoaiPhong.Rows[numrow].Cells[5].Value.ToString();
            if(HL== "Còn trống")
            {
                chkHieuLuc.Checked = true;
            }    
            else
            {
                chkHieuLuc.Checked = false;
            }    
        }
        bool flag=false;
        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
            xulytextbox(true);
            dgvDSLoaiPhong.DataSource = blp.LP_Select();
        }

        private void btnThem_Click(object sender, EventArgs e)
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
                if (txtTenLoaiPhong.Text == "" || txtSoGiuongDoi.Text == "" || txtSoGiuongDon.Text == "" || txtSoKhach.Text == "" )
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
                   string TangID = (blp.LP_Select().Rows.Count + 1).ToString();
                    blp.LP_Them(TangID.ToString(), txtTenLoaiPhong.Text, txtSoGiuongDoi.Text, txtSoGiuongDon.Text, txtSoKhach.Text, HieuLuc);
                    MessageBox.Show("Thêm thành công ");
                    flag = false;
                    xulytextbox(true);
                    dgvDSLoaiPhong.DataSource = blp.LP_Select();
                }
            }
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa loại phòng này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool HL = false;
                blp.LP_Xoa(ID,HL);
                dgvDSLoaiPhong.DataSource = blp.LP_Select();
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
                blp.LP_CapNhat(ID.ToString(), txtTenLoaiPhong.Text, txtSoGiuongDoi.Text, txtSoGiuongDon.Text, txtSoKhach.Text, HieuLuc);
                MessageBox.Show("Sữa thành công ");
                flag = false;
                xulytextbox(true);
                dgvDSLoaiPhong.DataSource = blp.LP_Select();
            }
        }


        int ID;
        private void dgvDSLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int vt = dgvDSLoaiPhong.CurrentCell.RowIndex;
                hienthi_textbox(vt);
                ID = Int32.Parse(dgvDSLoaiPhong.Rows[vt].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                
            }
        }

        private void txtTim_TextChangeEvent(object sender, EventArgs e)
        {
            blp.HienThiDanhSach(txtTim.TextValue, dgvDSLoaiPhong);
        }

       
    }
}
