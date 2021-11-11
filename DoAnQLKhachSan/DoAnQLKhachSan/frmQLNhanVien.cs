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

        //void Tang_ID()
        //{
        //    int count = 0;
        //    count = dgvDSNhanVien.Rows.Count;
        //    string chuoi = "";
        //    int chuoi2 = 0;
        //    if (count <= 1)
        //    {
        //        txtID.Text = "0";
        //    }
        //    else
        //    {
        //        chuoi = Convert.ToString(dgvDSNhanVien.Rows[count - 2].Cells[0].Value);
        //        chuoi2 = Convert.ToInt32((chuoi.Remove(0, 0)));
        //        if (chuoi2 + 1 < 10)
        //        {
        //            txtID.Text = "" + (chuoi2 + 1).ToString();
        //        }
        //        else if (chuoi2 + 1 < 100)
        //        {
        //            txtID.Text = "" + (chuoi2 + 1).ToString();
        //        }

        //    }
        //}

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

        }

        void xulytextbox(Boolean t)
        {
            txtHoTen.ReadOnly = t;
            txtMatKhau.ReadOnly = t;
            txtSDT.ReadOnly = t;
            rtxtDiaChi.ReadOnly = t;
            txtEmail.ReadOnly = t;
            txtCMND.ReadOnly = t;
            rtxtDiaChi.ReadOnly = t;

        }

        
        private void frmQLNhanVien_Load(object sender, EventArgs e)
        {
            
            xulychucnang(true);
            xulytextbox(true);
            dgvDSNhanVien.ReadOnly = true;
            txtMaNV.ReadOnly = true;
            bNV.HienThiTenLoaiNV(cboLoaiNV);
            dgvDSNhanVien.DataSource = bNV.NhanVien_Select();
           
        }

        void hienthi_textbox(int numrow)
        {

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
                string duongdanhinh = "D:\\DoAnTotNghiep\\DoAnTotNghiep\\DoAnQLKhachSan\\ImageNhanVien\\" + dgvDSNhanVien.Rows[numrow].Cells[11].Value.ToString();
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
                chkHieuLuc.Checked=true;
                flag = true;
            }else if(flag==true)
            {
                string fname = DuoiAnh; // tên ảnh
                string floder = "D:\\DoAnTotNghiep\\DoAnTotNghiep\\DoAnQLKhachSan\\ImageNhanVien\\";//đường dẫn lưu ảnh
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

                    int r = dgvDSNhanVien.CurrentCell.RowIndex;//lấy dữ liệu dòng hiện tại
                    if (dgvDSNhanVien.Rows.Count > 0)
                    {
                        if (txtSDT.Text == dgvDSNhanVien.Rows[r].Cells[6].Value.ToString())//so sánh txtSDT với SDT dòng numrow ở dgv
                        {
                            //nêu bằng thì bỏ qua bước này
                            //nêu không bằng nhau thì xuống else
                        }
                        else
                        {
                            for (int i = 0; i < dgvDSNhanVien.Rows.Count - 1; i++)//vòng lặp
                            {
                                if (txtSDT.Text == dgvDSNhanVien.Rows[i].Cells[6].Value.ToString())//so sánh txtSDT với từng dòng trong dgv
                                {
                                    //nêu txtSDT bằng với một hàng thì đã tồn tại
                                    MessageBox.Show("Số điện thoại đã tồn tại trong hệ thống");
                                    return;
                                }
                            }
                        }
                        if (txtCMND.Text == dgvDSNhanVien.Rows[r].Cells[9].Value.ToString())//so sánh txtCMND với số CMND dòng numrow ở dgv
                        {
                            //nêu bằng nhau thì bỏ qua bước này
                            //nêu không bằng nhau thì xuống else
                        }
                        else
                            for (int i = 0; i < dgvDSNhanVien.Rows.Count - 1; i++)
                            {
                                if (txtCMND.Text == dgvDSNhanVien.Rows[i].Cells[9].Value.ToString())
                                {
                                    //nếu txtCMND bằng với một hàng thì đã tồn tại
                                    MessageBox.Show("Số chứng minh nhân dân đã tồn tại trong hệ thống");
                                    return;
                                }
                            }

                        if (txtEmail.Text == dgvDSNhanVien.Rows[r].Cells[8].Value.ToString())
                        {

                        }
                        else
                            for (int i = 0; i < dgvDSNhanVien.Rows.Count - 1; i++)
                            {
                                if (txtCMND.Text == dgvDSNhanVien.Rows[i].Cells[8].Value.ToString())
                                {
                                    //nếu txtCMND bằng với một hàng thì đã tồn tại
                                    MessageBox.Show("Số chứng minh nhân dân đã tồn tại trong hệ thống");
                                    return;
                                }
                            }
                    }
                    int TangID  = bNV.NhanVien_Select().Rows.Count + 1;
                    bNV.NhanVien_Them(TangID, cboLoaiNV.SelectedIndex + 1, txtMaNV.Text,GetMD5(txtMatKhau.Text), txtHoTen.Text, Convert.ToDateTime(dtpNgaySinh.Text).ToString("yyyy-MM-dd"), txtSDT.Text, rtxtDiaChi.Text, txtEmail.Text, Int32.Parse(txtCMND.Text), GT, fname, HieuLuc);
                    MessageBox.Show("Thêm thành công ");
                    xulytextbox(true);
                    flag = false;
                    dgvDSNhanVien.DataSource = bNV.NhanVien_Select();
                }
                }
                

               
         }
          


        private void btnSua_Click(object sender, EventArgs e)
        {

            if (flag == false)
            {
                txtMatKhau.Text = "";
                xulytextbox(false);
                flag = true;
            }
            else if (flag == true)
            {
                string fname1 = DuoiAnh; // tên ảnh
                string floder1 = "D:\\DoAnTotNghiep\\DoAnTotNghiep\\DoAnQLKhachSan\\ImageNhanVien\\";//đường dẫn lưu ảnh
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
                        string address = "D:\\DoAnTotNghiep\\DoAnTotNghiep\\DoAnQLKhachSan\\ImageNhanVien\\" + dgvDSNhanVien.Rows[r].Cells[11].Value.ToString();
                        string result;
                        result = Path.GetFileName(address);
                        string b = dgvDSNhanVien.Rows[r].Cells[11].Value.ToString();


                        FileInfo info = new FileInfo(@"D:\DoAnTotNghiep\DoAnTotNghiep\DoAnQLKhachSan\ImageNhanVien\" + DuoiAnh);
                        //Get file infromation from info object


                        string FileNames = info.Name;
                        //{
                        //    MessageBox.Show("info " + FileNames);
                        //}

                        if (FileNames == "")  //picturebox bằng null là ảnh giống ảnh cũ
                        {
                            //MessageBox.Show("Có vô so sánh if 1");
                            if (txtMatKhau.Text == "")
                            {
                                txtMatKhau.Text = dgvDSNhanVien.Rows[r].Cells[3].Value.ToString();
                            }

                            if (dgvDSNhanVien.Rows.Count > 0)
                            {
                                if (txtSDT.Text == dgvDSNhanVien.Rows[r].Cells[6].Value.ToString())//so sánh txtSDT với SDT dòng numrow ở dgv
                                {
                                    //nêu bằng thì bỏ qua bước này
                                    //nêu không bằng nhau thì xuống else
                                }
                                else
                                {
                                    for (int i = 0; i < dgvDSNhanVien.Rows.Count - 1; i++)//vòng lặp
                                    {
                                        if (txtSDT.Text == dgvDSNhanVien.Rows[i].Cells[6].Value.ToString())//so sánh txtSDT với từng dòng trong dgv
                                        {
                                            //nêu txtSDT bằng với một hàng thì đã tồn tại
                                            MessageBox.Show("Số điện thoại đã tồn tại trong hệ thống");
                                            return;
                                        }
                                    }
                                }
                                if (txtCMND.Text == dgvDSNhanVien.Rows[r].Cells[9].Value.ToString())//so sánh txtCMND với số CMND dòng numrow ở dgv
                                {
                                    //nêu bằng nhau thì bỏ qua bước này
                                    //nêu không bằng nhau thì xuống else
                                }
                                else
                                    for (int i = 0; i < dgvDSNhanVien.Rows.Count - 1; i++)
                                    {
                                        if (txtCMND.Text == dgvDSNhanVien.Rows[i].Cells[9].Value.ToString())
                                        {
                                            //nếu txtCMND bằng với một hàng thì đã tồn tại
                                            MessageBox.Show("Số chứng minh nhân dân đã tồn tại trong hệ thống");
                                            return;
                                        }
                                    }

                                if (txtEmail.Text == dgvDSNhanVien.Rows[r].Cells[8].Value.ToString())
                                {

                                }
                                else
                                    for (int i = 0; i < dgvDSNhanVien.Rows.Count - 1; i++)
                                    {
                                        if (txtCMND.Text == dgvDSNhanVien.Rows[i].Cells[8].Value.ToString())
                                        {
                                            //nếu txtCMND bằng với một hàng thì đã tồn tại
                                            MessageBox.Show("Số chứng minh nhân dân đã tồn tại trong hệ thống");
                                            return;
                                        }
                                    }
                            }
                            bNV.NhanVien_CapNhat(ID, cboLoaiNV.SelectedIndex + 1, txtMaNV.Text, txtMatKhau.Text, txtHoTen.Text, Convert.ToDateTime(dtpNgaySinh.Text).ToString("yyyy-MM-dd"), txtSDT.Text, rtxtDiaChi.Text, txtEmail.Text, Int32.Parse(txtCMND.Text), GT, result, HieuLuc);
                            txtMatKhau.Text = "";
                            MessageBox.Show("Cập nhật thành công");
                            dgvDSNhanVien.DataSource = bNV.NhanVien_Select();
                            flag = false;
                            xulytextbox(true);
                            //MessageBox.Show("Có lưu if 1");


                        }

                        else //khác
                        {
                            {
                                //MessageBox.Show("có vô so sánh if 2 " + path1);
                            }
                            if (txtMatKhau.Text == "")
                            {
                                txtMatKhau.Text = dgvDSNhanVien.Rows[r].Cells[3].Value.ToString();
                            }
                            if (dgvDSNhanVien.Rows.Count > 0)
                            {
                                if (txtSDT.Text == dgvDSNhanVien.Rows[r].Cells[6].Value.ToString())//so sánh txtSDT với SDT dòng numrow ở dgv
                                {
                                    //nêu bằng thì bỏ qua bước này
                                    //nêu không bằng nhau thì xuống else
                                }
                                else
                                {
                                    for (int i = 0; i < dgvDSNhanVien.Rows.Count - 1; i++)//vòng lặp
                                    {
                                        if (txtSDT.Text == dgvDSNhanVien.Rows[i].Cells[6].Value.ToString())//so sánh txtSDT với từng dòng trong dgv
                                        {
                                            //nêu txtSDT bằng với một hàng thì đã tồn tại
                                            MessageBox.Show("Số điện thoại đã tồn tại trong hệ thống");
                                            return;
                                        }
                                    }
                                }
                                if (txtCMND.Text == dgvDSNhanVien.Rows[r].Cells[9].Value.ToString())//so sánh txtCMND với số CMND dòng numrow ở dgv
                                {
                                    //nêu bằng nhau thì bỏ qua bước này
                                    //nêu không bằng nhau thì xuống else
                                }
                                else
                                    for (int i = 0; i < dgvDSNhanVien.Rows.Count - 1; i++)
                                    {
                                        if (txtCMND.Text == dgvDSNhanVien.Rows[i].Cells[9].Value.ToString())
                                        {
                                            //nếu txtCMND bằng với một hàng thì đã tồn tại
                                            MessageBox.Show("Số chứng minh nhân dân đã tồn tại trong hệ thống");
                                            return;
                                        }
                                    }

                                if (txtEmail.Text == dgvDSNhanVien.Rows[r].Cells[8].Value.ToString())
                                {

                                }
                                else
                                    for (int i = 0; i < dgvDSNhanVien.Rows.Count - 1; i++)
                                    {
                                        if (txtCMND.Text == dgvDSNhanVien.Rows[i].Cells[8].Value.ToString())
                                        {
                                            //nếu txtCMND bằng với một hàng thì đã tồn tại
                                            MessageBox.Show("Số chứng minh nhân dân đã tồn tại trong hệ thống");
                                            return;
                                        }
                                    }
                            }
                            Image a1 = pichHinh.Image;
                            a1.Save(path1); //lưu ảnh mới vào đường dẫn 
                            bNV.NhanVien_CapNhat(ID, cboLoaiNV.SelectedIndex + 1, txtMaNV.Text, txtMatKhau.Text, txtHoTen.Text, Convert.ToDateTime(dtpNgaySinh.Text).ToString("yyyy-MM-dd"), txtSDT.Text, rtxtDiaChi.Text, txtEmail.Text, Int32.Parse(txtCMND.Text), GT, DuoiAnh, HieuLuc);
                            txtMatKhau.Text = "";
                            MessageBox.Show("Cập nhật thành công");
                            dgvDSNhanVien.DataSource = bNV.NhanVien_Select();
                            flag = false;
                            xulytextbox(true);
                            //MessageBox.Show("có lưu ảnh  if 2 ");


                        }

                    }
                }
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool HL = false;
            bNV.NhanVien_Xoa(ID, HL);
            MessageBox.Show("Xóa thành công");
            dgvDSNhanVien.DataSource = bNV.NhanVien_Select();
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

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

       
    }
}
