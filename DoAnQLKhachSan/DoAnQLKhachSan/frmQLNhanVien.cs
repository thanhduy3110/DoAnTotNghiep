using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace DoAnQLKhachSan
{
    public partial class frmQLNhanVien : Form
    {
        public frmQLNhanVien()
        {
            InitializeComponent();
        }

        BUSNhanVien bNV = new BUSNhanVien();
        int flag;

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
            if (dem < 10)
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
            cboLoaiNV.Text = "";
            txtHoTen.Text = "";
            txtMatKhau.Text = "";
            txtSDT.Text = "";
            dtpNgaySinh.Text = "";
            rtxtDiaChi.Text = "";
            txtEmail.Text = "";
            txtCMND.Text = "";
            cboGioiTinh.Text = "";
            txtHinhAnh.Text = "";
            cboHieuLuc.Text = "";
        }
        void xulychucnang(Boolean t)
        {
            btnThem.Enabled = t;
            btnXoa.Enabled = t;
            btnSua.Enabled = t;
            btnLuu.Enabled = !t;
            btnChonHinh.Enabled = !t;
        }

        void xulytextbox(Boolean t)
        {
            txtMaNV.ReadOnly = t;
            txtHoTen.ReadOnly = t;
            txtMatKhau.ReadOnly = t;
            txtSDT.ReadOnly = t;
            rtxtDiaChi.ReadOnly = t;
            txtEmail.ReadOnly = t;
            txtCMND.ReadOnly = t;
            txtHinhAnh.ReadOnly = t;

        }


        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            xulychucnang(true);
            xulytextbox(true);
            txtID.ReadOnly = true;
            bNV.HienThiTenLoaiNV(cboLoaiNV);
            dgvDSNhanVien.DataSource = bNV.NhanVien_Select();


        }

        void hienthi_textbox(int numrow)
        {

            txtID.Text = dgvDSNhanVien.Rows[numrow].Cells[0].Value.ToString();
            cboLoaiNV.SelectedValue = dgvDSNhanVien.Rows[numrow].Cells[1].Value.ToString();
            txtMaNV.Text = dgvDSNhanVien.Rows[numrow].Cells[2].Value.ToString();
            txtMatKhau.Text = dgvDSNhanVien.Rows[numrow].Cells[3].Value.ToString();
            txtHoTen.Text = dgvDSNhanVien.Rows[numrow].Cells[4].Value.ToString();
            dtpNgaySinh.Text = dgvDSNhanVien.Rows[numrow].Cells[5].Value.ToString();
            txtSDT.Text = dgvDSNhanVien.Rows[numrow].Cells[6].Value.ToString();
            rtxtDiaChi.Text = dgvDSNhanVien.Rows[numrow].Cells[7].Value.ToString();
            txtEmail.Text = dgvDSNhanVien.Rows[numrow].Cells[8].Value.ToString();
            txtCMND.Text = dgvDSNhanVien.Rows[numrow].Cells[9].Value.ToString();
            txtHinhAnh.Text = dgvDSNhanVien.Rows[numrow].Cells[11].Value.ToString();
            try
            {
                string duongdanhinh = "D:\\DoAnTotNghiep\\DoAnTotNghiep\\QLKhachSan\\QLKhachSan\\Images\\" + txtHinhAnh.Text;
                Bitmap a = new Bitmap(duongdanhinh);
                pichHinh.Image = a;
            }
            catch (Exception ex)
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

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            clear_textbox();
            xulychucnang(false);
            xulytextbox(false);
            flag = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulychucnang(false);
            xulytextbox(false);
            flag = 2;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        public string Encrypt(string toEncrypt, bool useHashing)
        {
            byte[] keyArray;
            byte[] toEncryptArray = Encoding.UTF8.GetBytes(toEncrypt);
            if (useHashing)
            {
                var hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(Encoding.UTF8.GetBytes("iloveit1208"));
            }
            else keyArray = Encoding.UTF8.GetBytes("iloveit1208");
            var tdes = new TripleDESCryptoServiceProvider
            {
                Key = keyArray,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };
            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
        private String GetMD5(string txt)
        {
            String str = "";
            Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(txt);
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            foreach (Byte b in buffer)
            {
                str += b.ToString("X2");
            }
            return str;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {           
            if (flag == 1)
            {

                if (txtEmail.Text == "" || txtCMND.Text == "" || txtHinhAnh.Text == "" || txtHoTen.Text == "" || txtMatKhau.Text == "" || txtSDT.Text == "" || cboGioiTinh.Text == "" || cboLoaiNV.Text == "" || rtxtDiaChi.Text == "" || txtMaNV.Text == "" || cboHieuLuc.Text == "")
                {
                    MessageBox.Show("Lỗi");
                }
                else
                {
                    xulychucnang(true);
                    bNV.NhanVien_Them(Int32.Parse(txtID.Text), cboLoaiNV.SelectedIndex + 1, txtMaNV.Text, GetMD5(txtMatKhau.Text), txtHoTen.Text, Convert.ToDateTime(dtpNgaySinh.Text).ToString("yyyy-MM-dd"), txtSDT.Text, rtxtDiaChi.Text, txtEmail.Text, Int32.Parse(txtCMND.Text), cboGioiTinh.SelectedIndex, txtHinhAnh.Text, cboHieuLuc.SelectedIndex);
                    File.Copy(DuongDan, Path.Combine(@"D:\DoAnTotNghiep\DoAnTotNghiep\QLKhachSan\QLKhachSan\Images\", Path.GetFileName(txtHinhAnh.Text)), true);
                    MessageBox.Show("Thêm thành công ");
                    dgvDSNhanVien.DataSource = bNV.NhanVien_Select();
                }
            }
            if (flag == 2)
            {
                if (txtEmail.Text == "" || txtCMND.Text == "" || txtHinhAnh.Text == "" || txtHoTen.Text == "" || txtMatKhau.Text == "" || txtSDT.Text == "" || cboGioiTinh.Text == "" || cboLoaiNV.Text == "" || rtxtDiaChi.Text == "" || txtMaNV.Text == "" || cboHieuLuc.Text == "")
                {
                    MessageBox.Show("Lỗi");
                }
                else
                {
                    xulychucnang(true);
                    bNV.NhanVien_CapNhat(Int32.Parse(txtID.Text), cboLoaiNV.SelectedIndex + 1, txtMaNV.Text, txtMatKhau.Text, txtHoTen.Text, Convert.ToDateTime(dtpNgaySinh.Text).ToString("yyyy-MM-dd"), txtSDT.Text, rtxtDiaChi.Text, txtEmail.Text, Int32.Parse(txtCMND.Text), cboGioiTinh.SelectedIndex, txtHinhAnh.Text, cboHieuLuc.SelectedIndex);
                    File.Copy(DuongDan, Path.Combine(@"D:\DoAnTotNghiep\DoAnTotNghiep\QLKhachSan\QLKhachSan\Images\", Path.GetFileName(txtHinhAnh.Text)), true);
                    MessageBox.Show("Sữa thành công ");
                    dgvDSNhanVien.DataSource = bNV.NhanVien_Select();
                }
            }
        }

        private void dgvDSNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int vt = dgvDSNhanVien.CurrentCell.RowIndex;
                hienthi_textbox(vt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có dữ liệu");
            }
           
        }
        string DuongDan = "";

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
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
                txtHinhAnh.Text = txtID.Text + ".jpg";
                DuongDan = o.FileName;
                pichHinh.Image = a;
            }
        }

        private void txtTim_TextChangeEvent(object sender, EventArgs e)
        {
            bNV.HienThiDanhSach(txtTim.TextValue, dgvDSNhanVien);
        }

       
    }
}
