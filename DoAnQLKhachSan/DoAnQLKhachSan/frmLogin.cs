using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;

namespace DoAnQLKhachSan
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        BUSLogin bLG = new BUSLogin();
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //public string MaHoa(string key, string toEncrypt)//bỏ thằng mã hóa này vô để mã hóa mật khẩu
        //{
        //    byte[] keyArray;
        //    byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);
        //    MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
        //    keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
        //    TripleDESCryptoServiceProvider tdes =
        //    new TripleDESCryptoServiceProvider();
        //    tdes.Key = keyArray;
        //    tdes.Mode = CipherMode.ECB;
        //    tdes.Padding = PaddingMode.PKCS7;
        //    ICryptoTransform cTransform = tdes.CreateEncryptor();
        //    byte[] resultArray = cTransform.TransformFinalBlock(
        //        toEncryptArray, 0, toEncryptArray.Length);
        //    return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        //}

        //public string GiaiMa(string key, string toDecrypt)//có mã hóa thì phải có giải mã, chỉ cần ở chỗ phân quyền này thôi
        //                                                  //chỗ nhân viên ko cần
        //{
        //    byte[] keyArray;
        //    byte[] toEncryptArray = Convert.FromBase64String(toDecrypt);

        //    MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
        //    keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));

        //    TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
        //    tdes.Key = keyArray;
        //    tdes.Mode = CipherMode.ECB;
        //    tdes.Padding = PaddingMode.PKCS7;
        //    ICryptoTransform cTransform = tdes.CreateDecryptor();
        //    byte[] resultArray = cTransform.TransformFinalBlock(
        //    toEncryptArray, 0, toEncryptArray.Length);
        //    return UTF8Encoding.UTF8.GetString(resultArray);
        //}

    
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        //public string Encrypt(string toEncrypt, bool useHashing)
        //{
        //    byte[] keyArray;
        //    byte[] toEncryptArray = Encoding.UTF8.GetBytes(toEncrypt);
        //    if (useHashing)
        //    {
        //        var hashmd5 = new MD5CryptoServiceProvider();
        //        keyArray = hashmd5.ComputeHash(Encoding.UTF8.GetBytes("iloveit1208"));
        //    }
        //    else keyArray = Encoding.UTF8.GetBytes("iloveit1208");
        //    var tdes = new TripleDESCryptoServiceProvider
        //    {
        //        Key = keyArray,
        //        Mode = CipherMode.ECB,
        //        Padding = PaddingMode.PKCS7
        //    };
        //    ICryptoTransform cTransform = tdes.CreateEncryptor();
        //    byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
        //    return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        //}
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
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.TextName==""||txtMatKhau.TextName=="")//nếu trống thì cho lable hiển thị là chưa nhập
            {
                MessageBox.Show("Bạn chưa nhập tài khoản hoặc mật khẩu");
            }
            else
            {
                //string s = txtMatKhau.TextName;
                //string mahoa = Encrypt(s, true);
                //đếm số phần tử trùng mã và mật khẩu nhé, tất nhiên sẽ ko thể có 2 tài khoản cùng mã và mật khẩu đc
                int count = bLG.DangNhap_Select(txtTaiKhoan.TextName, GetMD5(txtMatKhau.TextName)).Rows.Count;
                //vì vậy nếu đếm là 0 thì ko có tài khoản nào phù hợp nhé
                //tại chưa xử lý nếu form đăng nhập close giữa chừng nên nó sẽ vô form main nếu close form dăng nhập
                //tuy nhiên vô thì nó sẽ ko có quyền gì hết trừ quyền đăng xuất và mua hàng :))))))))))))
                //sẽ xử lý chuyện đó sau :v
                if (count == 0)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công");
                    this.Hide();            
                    string LoaiNV = bLG.DangNhap_Select(txtTaiKhoan.TextName, GetMD5(txtMatKhau.TextName)).Rows[0][0].ToString();
                    string MaNV = bLG.DangNhap_Select(txtTaiKhoan.TextName, GetMD5(txtMatKhau.TextName)).Rows[0][1].ToString();
                    frmMenu Menu = new frmMenu(MaNV,LoaiNV);
                    Menu.Show();
                }
            }
        }
    }
}
