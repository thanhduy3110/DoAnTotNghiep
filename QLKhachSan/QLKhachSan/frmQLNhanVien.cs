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
using System.IO;

namespace QLKhachSan
{
    public partial class frmQLNhanVien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmQLNhanVien()
        {
            InitializeComponent();
        }

        BUSNhanVien bNV = new BUSNhanVien();
        int flag;

        private void btnHome_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
            
        }

        void Tang_ID()
        {
            int count = 0;
            count = dgvDSNhanVien.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count <= 1)
            {
                txtID.Text = "0";
            }
            else
            {
                chuoi = Convert.ToString(dgvDSNhanVien.Rows[count - 2].Cells[0].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 0)));
                if (chuoi2 + 1 < 10)
                {
                    txtID.Text = "" + (chuoi2 + 1).ToString();
                }    
                else if (chuoi2 + 1 < 100)
                {
                    txtID.Text = "" + (chuoi2 + 1).ToString();
                }    
                    
            }
        }

        string PhatSinhMaTuDong()
        {
            string MaNV = "";
            int dem = dgvDSNhanVien.Rows.Count;
            if(dem<10)
            {
                MaNV = "NV00" + dem.ToString();
            }
            else
            {
                MaNV = "NV0" + dem.ToString();
            }

            return MaNV;
        }    

        void clear_textbox()
        {
            Tang_ID();
            txtMaNV.Text = PhatSinhMaTuDong();
            cboTenLoaiNV.Text = "";
            txtHoTen.Text = "";
            txtMatKhau.Text = "";
            txtSDT.Text = "";
            txtNgaySinh.Text = "";
            rtxtDiaChi.Text = "";
            txtEmail.Text = "";
            txtCMND.Text = "";
            cboGioiTinh.Text = "";
            txtHinh.Text = "";
            cboHieuLuc.Text = "";
        }
        void xulychucnang(Boolean t)
        {
            btnThem.Enabled = t;
            btnXoa.Enabled = t;
            btnSua.Enabled = t;
            btnLuu.Enabled = !t;
            btnHinh.Enabled = !t;
        }

        void xulytextbox(Boolean t)
        {
            txtMaNV.ReadOnly = t;
            txtHoTen.ReadOnly = t;
            txtMatKhau.ReadOnly = t;
            txtNgaySinh.ReadOnly = t;
            txtSDT.ReadOnly = t;
            rtxtDiaChi.ReadOnly = t;
            txtEmail.ReadOnly = t;
            txtCMND.ReadOnly = t;
            txtHinh.ReadOnly = t;

        }
        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            xulychucnang(true);
            xulytextbox(true);
            txtID.ReadOnly = true;
            bNV.HienThiTenLoaiNV(cboTenLoaiNV);
            dgvDSNhanVien.DataSource = bNV.NhanVien_Select();
        }

        void hienthi_textbox(int numrow)
        {
            txtID.Text = dgvDSNhanVien.Rows[numrow].Cells[0].Value.ToString();
            cboTenLoaiNV.SelectedValue = dgvDSNhanVien.Rows[numrow].Cells[1].Value.ToString();
            txtMaNV.Text = dgvDSNhanVien.Rows[numrow].Cells[2].Value.ToString();
            txtMatKhau.Text = dgvDSNhanVien.Rows[numrow].Cells[3].Value.ToString();
            txtHoTen.Text = dgvDSNhanVien.Rows[numrow].Cells[4].Value.ToString();
            txtNgaySinh.Text = dgvDSNhanVien.Rows[numrow].Cells[5].Value.ToString();
            txtSDT.Text = dgvDSNhanVien.Rows[numrow].Cells[6].Value.ToString();
            rtxtDiaChi.Text = dgvDSNhanVien.Rows[numrow].Cells[7].Value.ToString();
            txtEmail.Text = dgvDSNhanVien.Rows[numrow].Cells[8].Value.ToString();
            txtCMND.Text = dgvDSNhanVien.Rows[numrow].Cells[9].Value.ToString();
            txtHinh.Text = dgvDSNhanVien.Rows[numrow].Cells[11].Value.ToString();
            try
            {
                string duongdanhinh = "D:\\DoAnTotNghiep\\DoAnTotNghiep\\QLKhachSan\\QLKhachSan\\Images\\" + txtHinh.Text;
                Bitmap a = new Bitmap(duongdanhinh);
                picHinhAnh.Image = a;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Không có hình");
            }
           

            string GT = dgvDSNhanVien.Rows[numrow].Cells[10].Value.ToString();
            if (GT == "False")
            {
                cboGioiTinh.SelectedIndex = 0;
            }
            else
            {
                cboGioiTinh.SelectedIndex = 1;
            }

            string HL = dgvDSNhanVien.Rows[numrow].Cells[12].Value.ToString();
            if (HL == "False")
            {
                cboHieuLuc.SelectedIndex = 0;
            }
            else
            {
                cboHieuLuc.SelectedIndex = 1;
            }
        }

        private void dgvDSNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = dgvDSNhanVien.CurrentCell.RowIndex;
            hienthi_textbox(vt);
        }

        string DuongDan = "";
        private void btnHinh_Click(object sender, EventArgs e)
        {
            //OpenFileDialog open = new OpenFileDialog();
            //open.Filter = "Image Files(*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.png)|*.png|ALL Files (*.*)|*.*";
            //if(open.ShowDialog()==DialogResult.OK)
            //{
            //    txtHinh.Text = open.FileName;
            //    picHinhAnh.Image = new Bitmap(open.FileName);
            //}  

            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "bitmap (*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.png)|*.png|ALL Files (*.*)|*.*";
            if (o.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("bạn phải chọn ảnh");
                o.ShowDialog();
            }
            else
            {
                Bitmap a = new Bitmap(o.FileName);
                txtHinh.Text = txtID.Text+".jpg";
                DuongDan = o.FileName;
                picHinhAnh.Image = a;
            }
        }

    
        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            clear_textbox();
            xulychucnang(false);
            xulytextbox(false);
            flag = 1;

        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            xulychucnang(false);
            xulytextbox(false);
            flag = 2;
        }

        private void btnLuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (flag == 1)
            {
                
                if (txtEmail.Text == "" || txtCMND.Text==""|| txtHinh.Text==""||txtHoTen.Text==""|| txtMatKhau.Text == "" || txtSDT.Text == "" || cboGioiTinh.Text == "" || cboTenLoaiNV.Text==""|| rtxtDiaChi.Text==""||txtMaNV.Text==""|| cboHieuLuc.Text == "")
                {
                    MessageBox.Show("Lỗi");
                }
                else
                {
                    xulychucnang(true);
                    bNV.NhanVien_Them(Int32.Parse(txtID.Text), cboTenLoaiNV.SelectedIndex+1, txtMaNV.Text,txtMatKhau.Text,txtHoTen.Text,Convert.ToDateTime(txtNgaySinh.Text).ToString("yyyy-MM-dd"),txtSDT.Text,rtxtDiaChi.Text,txtEmail.Text,Int32.Parse(txtCMND.Text),cboGioiTinh.SelectedIndex,txtHinh.Text, cboHieuLuc.SelectedIndex);
                    File.Copy(DuongDan, Path.Combine(@"D:\DoAnTotNghiep\DoAnTotNghiep\QLKhachSan\QLKhachSan\Images\", Path.GetFileName(txtHinh.Text)), true);
                    MessageBox.Show("Thêm thành công ");
                    dgvDSNhanVien.DataSource = bNV.NhanVien_Select();
                }
            }
            if (flag == 2)
            {
                if (txtEmail.Text == "" || txtCMND.Text == "" || txtHinh.Text == "" || txtHoTen.Text == "" || txtMatKhau.Text == "" || txtSDT.Text == "" || cboGioiTinh.Text == "" || cboTenLoaiNV.Text == "" || rtxtDiaChi.Text == "" || txtMaNV.Text == "" || cboHieuLuc.Text == "")
                {
                    MessageBox.Show("Lỗi");
                }
                else
                {
                    xulychucnang(true);
                    bNV.NhanVien_CapNhat(Int32.Parse(txtID.Text), cboTenLoaiNV.SelectedIndex + 1, txtMaNV.Text, txtMatKhau.Text, txtHoTen.Text, Convert.ToDateTime(txtNgaySinh.Text).ToString("yyyy-MM-dd"), txtSDT.Text, rtxtDiaChi.Text, txtEmail.Text, Int32.Parse(txtCMND.Text), cboGioiTinh.SelectedIndex, txtHinh.Text, cboHieuLuc.SelectedIndex);
                    File.Copy(DuongDan, Path.Combine(@"D:\DoAnTotNghiep\DoAnTotNghiep\QLKhachSan\QLKhachSan\Images\", Path.GetFileName(txtHinh.Text)), true);
                    MessageBox.Show("Sữa thành công ");
                    dgvDSNhanVien.DataSource = bNV.NhanVien_Select();
                }
            }
           // File.Copy(txtHinh.Text, Path.Combine(@"D:\DoAnTotNghiep\DoAnTotNghiep\QLKhachSan\QLKhachSan\Images\", Path.GetFileName(txtHinh.Text)), true);
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            bNV.NhanVien_Xoa(Int32.Parse(txtID.Text),0);
            MessageBox.Show("Xóa thành công ");
            dgvDSNhanVien.DataSource = bNV.NhanVien_Select();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }
    }
}