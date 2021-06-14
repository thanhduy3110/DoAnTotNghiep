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
    public partial class frmQLDichVu : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        BUSDichVu bdv = new BUSDichVu();
        public frmQLDichVu()
        {
            InitializeComponent();
        }

        private void btnHome_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
           
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmQLDichVu_Load(object sender, EventArgs e)
        {
            bdv.HienTHiLoaiDichVu(cboLoaiDV);
            dgvDichVu.DataSource = bdv.DV_Select();
        }
        int flag;
        void Tang_ID()
        {
            int count = 0;
            count = dgvDichVu.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count <= 1)
            {
                txtID.Text = "0";
            }
            else
            {
                chuoi = Convert.ToString(dgvDichVu.Rows[count - 2].Cells[0].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 0)));
                if (chuoi2 + 1 < 10)
                    txtID.Text = "" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 < 100)
                    txtID.Text = "" + (chuoi2 + 1).ToString();
            }
        }
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
            cboHieuLuc.Text = "";
        }
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
            string fname = txtID.Text + ".jpg"; // tên ảnh theo id
            string floder = "C:\\Users\\USER\\source\\repos\\DoAnTotNghiep\\QLKhachSan\\image";//đường dẫn lưu ảnh
            string path=System.IO.Path.Combine(floder,fname);//lưu tên ảnh xuống csdl
            Image a = pictureBox.Image;
            a.Save(path);
            if (flag == 1)
            {         
                if (cboLoaiDV.Text == "" || txtTenDV.Text == "" || rtxtMoTa.Text == "" || pictureBox.Image == null || txtGiaTien.Text == "" || txtSLTon.Text == "" || txtDVT.Text == "" || rtxtGhiChu.Text == "" || cboHieuLuc.Text == "")
                {
                    MessageBox.Show("Lỗi");
                }
                else
                {
                    bdv.DV_Them(txtID.Text, cboLoaiDV.SelectedValue.ToString(), txtTenDV.Text, rtxtMoTa.Text, fname, txtGiaTien.Text, txtSLTon.Text, txtDVT.Text, rtxtGhiChu.Text, cboHieuLuc.Text);
                    MessageBox.Show("thêm thành công rồi nè");
                    dgvDichVu.DataSource = bdv.DV_Select();
                }
            }
            if (flag == 2)
            {
                bdv.DV_CapNhat(txtID.Text, cboLoaiDV.SelectedValue.ToString(), txtTenDV.Text, rtxtMoTa.Text, fname, txtGiaTien.Text, txtSLTon.Text, txtDVT.Text, rtxtGhiChu.Text, cboHieuLuc.Text);
                MessageBox.Show("sửa thành công rồi nè");
                dgvDichVu.DataSource = bdv.DV_Select();
            }
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
              bdv.DV_Xoa(txtID.Text);
              MessageBox.Show("Xóa thành công rồi nè");
              dgvDichVu.DataSource = bdv.DV_Select();
        }
        void hienthi_textbox(int numrow)
        {
            


            txtHinhAnh.Text= dgvDichVu.Rows[numrow].Cells[4].Value.ToString();
            txtID.Text = dgvDichVu.Rows[numrow].Cells[0].Value.ToString();
            cboLoaiDV.SelectedValue = dgvDichVu.Rows[numrow].Cells[1].Value.ToString();
            txtTenDV.Text = dgvDichVu.Rows[numrow].Cells[2].Value.ToString();
            rtxtMoTa.Text = dgvDichVu.Rows[numrow].Cells[3].Value.ToString();
            txtGiaTien.Text = dgvDichVu.Rows[numrow].Cells[5].Value.ToString();
            txtSLTon.Text = dgvDichVu.Rows[numrow].Cells[6].Value.ToString();
            txtDVT.Text = dgvDichVu.Rows[numrow].Cells[7].Value.ToString();
            rtxtGhiChu.Text = dgvDichVu.Rows[numrow].Cells[8].Value.ToString();
            cboHieuLuc.Text = dgvDichVu.Rows[numrow].Cells[9].Value.ToString();
            string floder = "C:\\Users\\USER\\source\\repos\\DoAnTotNghiep\\QLKhachSan\\image\\" + txtHinhAnh.Text;
            Bitmap a = new Bitmap(floder);
            pictureBox.Image = a;
        }
        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = dgvDichVu.CurrentCell.RowIndex;
            hienthi_textbox(vt);
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox p = sender as PictureBox;
            if(p!=null)
            {
                open.Filter = "(*.jpg;)|*.jpg;";
                if(open.ShowDialog()==DialogResult.OK)
                {
                    p.Image = Image.FromFile(open.FileName);
                }
            }

        }
    }
}