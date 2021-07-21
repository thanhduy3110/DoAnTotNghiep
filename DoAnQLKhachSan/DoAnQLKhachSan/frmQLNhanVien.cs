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
            //txtMatKhau.Text = dgvDSNhanVien.Rows[numrow].Cells[3].Value.ToString();
            txtHoTen.Text = dgvDSNhanVien.Rows[numrow].Cells[4].Value.ToString();
            dtpNgaySinh.Text = dgvDSNhanVien.Rows[numrow].Cells[5].Value.ToString();
            txtSDT.Text = dgvDSNhanVien.Rows[numrow].Cells[6].Value.ToString();
            rtxtDiaChi.Text = dgvDSNhanVien.Rows[numrow].Cells[7].Value.ToString();
            txtEmail.Text = dgvDSNhanVien.Rows[numrow].Cells[8].Value.ToString();
            txtCMND.Text = dgvDSNhanVien.Rows[numrow].Cells[9].Value.ToString();
            try
            {
                string duongdanhinh = "C:\\Users\\USER\\source\\repos\\DoAnTotNghiep\\DoAnQLKhachSan\\ImageNhanVien\\" + dgvDSNhanVien.Rows[numrow].Cells[11].Value.ToString();
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
            if (HL == "Còn Làm")
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
                radioNam.Checked = true;
                flag = true;
            }else if(flag==true)
            {
                string fname = DuoiAnh; // tên ảnh
                string floder = "C:\\Users\\USER\\source\\repos\\DoAnTotNghiep\\DoAnQLKhachSan\\ImageNhanVien";//đường dẫn lưu ảnh
                string path = System.IO.Path.Combine(floder, fname);
                Image a = pichHinh.Image;
                a.Save(path); //lưu ảnh vào đường dẫn   
                if (txtEmail.Text == "" || txtCMND.Text == "" || txtHoTen.Text == "" || txtMatKhau.Text == "" || txtSDT.Text == "" || cboLoaiNV.Text == "" || rtxtDiaChi.Text == "" || txtMaNV.Text == "" )
                {
                    MessageBox.Show("Lỗi");
                }
                else
                {

                    Boolean GT=false;
                    bool HieuLuc;
                    if (radioNam.Checked == true)
                    {
                        GT = true;

                    }
                    else if (radioNu.Checked == true)
                    {
                        GT = false;
                    }

                    if(chkHieuLuc.Checked==true)
                    {
                        HieuLuc = true;
                    }    
                    else
                    {
                        HieuLuc = false;
                    }
                    bNV.NhanVien_Them(Int32.Parse(txtID.Text), cboLoaiNV.SelectedIndex + 1, txtMaNV.Text, txtMatKhau.Text, txtHoTen.Text, Convert.ToDateTime(dtpNgaySinh.Text).ToString("yyyy-MM-dd"), txtSDT.Text, rtxtDiaChi.Text, txtEmail.Text, Int32.Parse(txtCMND.Text), GT, fname, HieuLuc);
                    MessageBox.Show("Thêm thành công ");
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
                string fname1 = DuoiAnh; // tên ảnh
                string floder1 = "C:\\Users\\USER\\source\\repos\\DoAnTotNghiep\\DoAnQLKhachSan\\ImageNhanVien";//đường dẫn lưu ảnh
                string path1 = System.IO.Path.Combine(floder1, fname1);

                {
                    if (txtEmail.Text == "" || txtCMND.Text == "" || txtHoTen.Text == "" || txtSDT.Text == "" || cboLoaiNV.Text == "" || rtxtDiaChi.Text == "" || txtMaNV.Text == "")
                    {
                        MessageBox.Show("Lỗi");
                    }
                    else
                    {

                        Boolean GT = false;
                        bool HieuLuc;
                        if (radioNam.Checked == true)
                        {
                            GT = true;

                        }
                        else if (radioNu.Checked == true)
                        {
                            GT = false;
                        }
                        if (chkHieuLuc.Checked == true)
                        {
                            HieuLuc = true;
                        }
                        else
                        {
                            HieuLuc = false;
                        }
                        int r = this.dgvDSNhanVien.CurrentCell.RowIndex;
                        string address = "C:\\Users\\USER\\source\\repos\\DoAnTotNghiep\\DoAnQLKhachSan\\ImageNhanVien\\" + dgvDSNhanVien.Rows[r].Cells[11].Value.ToString();
                        string result;
                        result = Path.GetFileName(address);
                        string b = dgvDSNhanVien.Rows[r].Cells[11].Value.ToString();
                       

                        FileInfo info = new FileInfo(@"C:\Users\USER\source\repos\DoAnTotNghiep\DoAnQLKhachSan\ImageNhanVien\" + DuoiAnh);
                        //Get file infromation from info object


                        string FileNames = info.Name;
                        //{
                        //    MessageBox.Show("info " + FileNames);
                        //}

                        if (FileNames == "")  //picturebox bằng null là ảnh giống ảnh cũ
                        {
                            MessageBox.Show("Có vô so sánh if 1");
                            if (txtMatKhau.Text == "")
                            {
                                txtMatKhau.Text = dgvDSNhanVien.Rows[r].Cells[3].Value.ToString();
                            }
                            bNV.NhanVien_CapNhat(Int32.Parse(txtID.Text), cboLoaiNV.SelectedIndex + 1, txtMaNV.Text, txtMatKhau.Text, txtHoTen.Text, Convert.ToDateTime(dtpNgaySinh.Text).ToString("yyyy-MM-dd"), txtSDT.Text, rtxtDiaChi.Text, txtEmail.Text, Int32.Parse(txtCMND.Text), GT, result, HieuLuc);
                            txtMatKhau.Text = "";
                            dgvDSNhanVien.DataSource = bNV.NhanVien_Select();

                            MessageBox.Show("Có lưu if 1");


                        }

                        else //khác
                        {
                            {
                                MessageBox.Show("có vô so sánh if 2 " + path1);
                            }
                            if (txtMatKhau.Text == "")
                            {
                                txtMatKhau.Text = dgvDSNhanVien.Rows[r].Cells[3].Value.ToString();
                            }
                            Image a1 = pichHinh.Image;
                            a1.Save(path1); //lưu ảnh mới vào đường dẫn 
                            bNV.NhanVien_CapNhat(Int32.Parse(txtID.Text), cboLoaiNV.SelectedIndex + 1, txtMaNV.Text, txtMatKhau.Text, txtHoTen.Text, Convert.ToDateTime(dtpNgaySinh.Text).ToString("yyyy-MM-dd"), txtSDT.Text, rtxtDiaChi.Text, txtEmail.Text, Int32.Parse(txtCMND.Text), GT, DuoiAnh, HieuLuc);
                            txtMatKhau.Text = "";
                            //MessageBox.Show("Sửa hình mới thành công");
                            dgvDSNhanVien.DataSource = bNV.NhanVien_Select();
                            MessageBox.Show("có lưu ảnh  if 2 ");


                        }

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
            try
            {
                vt = dgvDSNhanVien.CurrentCell.RowIndex;
                hienthi_textbox(vt);
                ID = Int32.Parse(dgvDSNhanVien.Rows[vt].Cells[0].Value.ToString());
            }catch(Exception ex)
            {

            }
               
        }
        string DuongDan = "";

       

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

        string DuoiAnh = "";
        private void pichHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            PictureBox p = sender as PictureBox;
            if (p != null)
            {
                open.Filter = "(*.jpg;)|*.jpg;";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(open.FileName);
                    DuoiAnh = open.SafeFileName;// lấy tên ảnh


                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
