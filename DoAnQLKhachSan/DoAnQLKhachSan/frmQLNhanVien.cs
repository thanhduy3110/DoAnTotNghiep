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
        bool flag=false;

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
            txtHinhAnh.Text = "";
            cboHieuLuc.Text = "";
        }
        void xulychucnang(Boolean t)
        {
            btnThem.Enabled = t;
            btnXoa.Enabled = t;
            btnSua.Enabled = t;
            btnClear.Enabled = !t;
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
            dgvDSNhanVien.ReadOnly = true;
            txtMaNV.ReadOnly = true;
            bNV.HienThiTenLoaiNV(cboLoaiNV);
            dgvDSNhanVien.DataSource = bNV.NhanVien_Select();
           
        }

        void hienthi_textbox(int numrow)
        {

            txtID.Text = dgvDSNhanVien.Rows[numrow].Cells[0].Value.ToString();
            cboLoaiNV.Text = dgvDSNhanVien.Rows[numrow].Cells[1].Value.ToString();
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
                string duongdanhinh = "D:\\DoAnTotNghiep\\DoAnTotNghiep\\DoAnQLKhachSan\\DoAnQLKhachSan\\Images\\" + txtHinhAnh.Text;
                Bitmap a = new Bitmap(duongdanhinh);
                pichHinh.Image = a;
            }
            catch (Exception ex)
            {
               
            }
            string GT = dgvDSNhanVien.Rows[numrow].Cells[10].Value.ToString();
            if (GT == "Nữ")
            {
                radioNu.Checked=true;
            }
            else
            {
                radioNam.Checked = true;
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

            if (flag == false)
            {
                clear_textbox();
                xulytextbox(false);
                radioNam.Checked = true;
                flag = true;
            }else if(flag==true)
            {
               
                if (txtEmail.Text == "" || txtCMND.Text == "" || txtHinhAnh.Text == "" || txtHoTen.Text == "" || txtMatKhau.Text == "" || txtSDT.Text == "" || cboLoaiNV.Text == "" || rtxtDiaChi.Text == "" || txtMaNV.Text == "" || cboHieuLuc.Text == "")
                {
                    MessageBox.Show("Lỗi");
                }
                else
                {

                    Boolean GT=false;
                    if (radioNam.Checked == true)
                    {
                        GT = true;

                    }
                    else if (radioNu.Checked == true)
                    {
                        GT = false;
                    }
                    bNV.NhanVien_Them(Int32.Parse(txtID.Text), cboLoaiNV.SelectedIndex + 1, txtMaNV.Text, MaHoa("123", txtMatKhau.Text), txtHoTen.Text, Convert.ToDateTime(dtpNgaySinh.Text).ToString("yyyy-MM-dd"), txtSDT.Text, rtxtDiaChi.Text, txtEmail.Text, Int32.Parse(txtCMND.Text), GT, txtHinhAnh.Text, cboHieuLuc.SelectedIndex);
                    File.Copy(DuongDan, Path.Combine(@"D:\DoAnTotNghiep\DoAnTotNghiep\DoAnQLKhachSan\DoAnQLKhachSan\Images", Path.GetFileName(txtHinhAnh.Text)), true);
                    MessageBox.Show("Thêm thành công ");
                    flag = false;
                    dgvDSNhanVien.DataSource = bNV.NhanVien_Select();
                    
                }
            }    

               
         }
          


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                
                xulytextbox(false);
                flag = true;
            }else if(flag==true)
            {
                
                {
                    if (txtEmail.Text == "" || txtCMND.Text == "" || txtHinhAnh.Text == "" || txtHoTen.Text == "" || txtMatKhau.Text == "" || txtSDT.Text == "" || cboLoaiNV.Text == "" || rtxtDiaChi.Text == "" || txtMaNV.Text == "" || cboHieuLuc.Text == "")
                    {
                        MessageBox.Show("Lỗi");
                    }
                    else
                    {

                        Boolean GT = false;
                        if (radioNam.Checked == true)
                        {
                            GT = true;

                        }
                        else if (radioNu.Checked == true)
                        {
                            GT = false;
                        }
                        txtHinhAnh.Text = txtID.Text + "Sua" + (Int32.Parse(txtID.Text) + 1).ToString() + ".jpg";
                        bNV.NhanVien_CapNhat(ID, cboLoaiNV.SelectedIndex + 1, txtMaNV.Text, txtMatKhau.Text, txtHoTen.Text, Convert.ToDateTime(dtpNgaySinh.Text).ToString("yyyy-MM-dd"), txtSDT.Text, rtxtDiaChi.Text, txtEmail.Text, int.Parse(txtCMND.Text), GT, txtHinhAnh.Text, cboHieuLuc.SelectedIndex);
                        File.Copy(DuongDan, Path.Combine(@"D:\DoAnTotNghiep\DoAnTotNghiep\DoAnQLKhachSan\DoAnQLKhachSan\Images", Path.GetFileName(txtHinhAnh.Text)), true);
                        MessageBox.Show("Sữa thành công ");
                        flag = false;
                        dgvDSNhanVien.DataSource = bNV.NhanVien_Select();
                        
                    }
                }
            }    

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

        public string GiaiMa(string key, string toDecrypt)//có mã hóa thì phải có giải mã, chỉ cần ở chỗ phân quyền này thôi
                                                          //chỗ nhân viên ko cần
        {
            byte[] keyArray;
            byte[] toEncryptArray = Convert.FromBase64String(toDecrypt);

            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(
            toEncryptArray, 0, toEncryptArray.Length);
            return UTF8Encoding.UTF8.GetString(resultArray);
        }

        int ID,vt;
        private void dgvDSNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                vt = dgvDSNhanVien.CurrentCell.RowIndex;
                
                hienthi_textbox(vt);
                ID = Int32.Parse(dgvDSNhanVien.Rows[vt].Cells[0].Value.ToString());
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

        public string MaHoa(string key, string toEncrypt)//bỏ thằng mã hóa này vô để mã hóa mật khẩu
        {
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            TripleDESCryptoServiceProvider tdes =
            new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(
                toEncryptArray, 0, toEncryptArray.Length);
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
