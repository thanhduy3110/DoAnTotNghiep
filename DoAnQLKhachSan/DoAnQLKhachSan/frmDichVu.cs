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
    public partial class frmDichVu : Form
    {
        public frmDichVu()
        {
            InitializeComponent();
        }
        BUSDichVu bdv = new BUSDichVu();
        bool flag=false;
        //void Tang_ID()
        //{
        //    int count = 0;
        //    count = dgvDichVu.Rows.Count;
        //    string chuoi = "";
        //    int chuoi2 = 0;
        //    if (count <= 1)
        //    {
        //        txtID.Text = "0";
        //    }
        //    else
        //    {
        //        chuoi = Convert.ToString(dgvDichVu.Rows[count - 2].Cells[0].Value);
        //        chuoi2 = Convert.ToInt32((chuoi.Remove(0, 0)));
        //        if (chuoi2 + 1 < 10)
        //            txtID.Text = "" + (chuoi2 + 1).ToString();
        //        else if (chuoi2 + 1 < 100)
        //            txtID.Text = "" + (chuoi2 + 1).ToString();
        //    }
        //}
        
        void clear_textbox()
        {
            txtTenDV.Text = "";
            cboLoaiDV.Text = "";
            rtxtMoTa.Text = "";
            pictureBox.Text = null;
            txtGiaTien.Text = "";
            rtxtGhiChu.Text = "";
            txtSLTon.Text = "";
            txtDVT.Text = "";
        }

        void xulytextbox(Boolean t)
        {
            txtTenDV.ReadOnly = t;
            txtGiaTien.ReadOnly = t;
            txtDVT.ReadOnly = t;
            txtSLTon.ReadOnly = t;
            rtxtGhiChu.ReadOnly = t;
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
           
            if(flag==false)
            {
                txtID.Text = (bdv.DV_Select().Rows.Count+1).ToString();
                chkHieuLuc.Checked = false;
                flag = true;
                xulytextbox(false);
            }
            else if (flag == true)
            {
                if (cboLoaiDV.Text == "" || txtTenDV.Text == "" || pictureBox.Image == null || txtGiaTien.Text == "" || txtSLTon.Text == "" || txtDVT.Text == ""  )
                {
                    MessageBox.Show("Lỗi");
                }
                else
                {
                    
                    clear_textbox();
                    bool HieuLuc;
                    if (chkHieuLuc.Checked == true)
                    {
                        HieuLuc = true;
                    }
                    else
                    {
                        HieuLuc = false;
                    }
                    string fname = txtID.Text + ".jpg"; // tên ảnh theo id
                    string floder = "D:\\DoAnTotNghiep\\DoAnTotNghiep\\DoAnQLKhachSan\\DoAnQLKhachSan\\Images\\";//đường dẫn lưu ảnh
                    string path = System.IO.Path.Combine(floder, fname);//lưu tên ảnh xuống csdl
                    Image a = pictureBox.Image;
                    a.Save(path);
                    bdv.DV_Them(txtID.Text, cboLoaiDV.SelectedValue.ToString(), txtTenDV.Text, rtxtMoTa.Text, fname, txtGiaTien.Text, txtSLTon.Text, txtDVT.Text, rtxtGhiChu.Text, HieuLuc);
                    MessageBox.Show("thêm thành công");
                    flag = false;
                    dgvDichVu.DataSource = bdv.DV_Select();
                }
            }
          

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(flag==false)
            {
                flag = true;
                xulytextbox(false);
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
                string fname = txtID.Text + ".jpg"; // tên ảnh theo id
                bdv.DV_CapNhat(txtID.Text, cboLoaiDV.SelectedValue.ToString(), txtTenDV.Text, rtxtMoTa.Text, fname, txtGiaTien.Text, txtSLTon.Text, txtDVT.Text, rtxtGhiChu.Text,HieuLuc);
                MessageBox.Show("sửa thành công");
                flag = false;
                xulytextbox(true);
                dgvDichVu.DataSource = bdv.DV_Select();
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bdv.DV_Xoa(txtID.Text);
            MessageBox.Show("Xóa thành");
            dgvDichVu.DataSource = bdv.DV_Select();
        }

       

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            bdv.HienTHiLoaiDichVu(cboLoaiDV);
            dgvDichVu.DataSource = bdv.DV_Select();
            xulytextbox(true);
        }
        void hienthi_textbox(int numrow)
        {

            //txtHinhAnh.Text = dgvDichVu.Rows[numrow].Cells[4].Value.ToString();
            txtID.Text = dgvDichVu.Rows[numrow].Cells[0].Value.ToString();
            cboLoaiDV.SelectedValue = dgvDichVu.Rows[numrow].Cells[1].Value.ToString();
            txtTenDV.Text = dgvDichVu.Rows[numrow].Cells[2].Value.ToString();
            rtxtMoTa.Text = dgvDichVu.Rows[numrow].Cells[3].Value.ToString();
            txtGiaTien.Text = dgvDichVu.Rows[numrow].Cells[5].Value.ToString();
            txtSLTon.Text = dgvDichVu.Rows[numrow].Cells[6].Value.ToString();
            txtDVT.Text = dgvDichVu.Rows[numrow].Cells[7].Value.ToString();
            rtxtGhiChu.Text = dgvDichVu.Rows[numrow].Cells[8].Value.ToString();
           string HL = dgvDichVu.Rows[numrow].Cells[9].Value.ToString();
            if(HL=="Còn")
            {
                chkHieuLuc.Checked = true;
            }    
            else
            {
                chkHieuLuc.Checked = false;
            }    
            string floder = "D:\\DoAnTotNghiep\\DoAnTotNghiep\\DoAnQLKhachSan\\DoAnQLKhachSan\\Images\\" + dgvDichVu.Rows[numrow].Cells[4].Value.ToString();
            Bitmap a = new Bitmap(floder);
            pictureBox.Image = a;
        }
        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int vt = dgvDichVu.CurrentCell.RowIndex;
                hienthi_textbox(vt);
            }
            catch (Exception ex)
            {
               
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox p = sender as PictureBox;
            if (p != null)
            {
                open.Filter = "(*.jpg;)|*.jpg;";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(open.FileName);
                }
            }
        }

        private void txtTim_TextChangeEvent(object sender, EventArgs e)
        {
            bdv.HienThiDanhSach(txtTim.TextValue, dgvDichVu);
        }

        private void txtGiaTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }
    }
}
