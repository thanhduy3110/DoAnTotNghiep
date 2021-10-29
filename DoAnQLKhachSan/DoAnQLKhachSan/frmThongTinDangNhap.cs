using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace DoAnQLKhachSan
{
    public partial class frmThongTinDangNhap : Form
    {
        private string MaNV = "",LoaiNV="";
        private int ID;
        string DuoiAnh = "";
        bool flag = false;

        BUSLogin bLG = new BUSLogin();
        BUSNhanVien bNV = new BUSNhanVien();
        public frmThongTinDangNhap()
        {
            InitializeComponent();
        }

        public frmThongTinDangNhap(string MaNV,int ID,string LoaiNV)
        {
            this.MaNV = MaNV;
            this.ID = ID;
            this.LoaiNV = LoaiNV;
            InitializeComponent();
        }


        void xulytextbox(Boolean t)
        {
            txtHoTen.ReadOnly = t;
            txtEmail.ReadOnly = t;
            txtCMND.ReadOnly = t;
            txtMatKhau.ReadOnly = t;
            txtSDT.ReadOnly = t;
            rtxtDiaChi.ReadOnly = t;
            
        }




        private void frmThongTinDangNhap_Load(object sender, EventArgs e)
        {
            txtMaNV.ReadOnly = true;
            txtLoaiNV.ReadOnly = true;
            xulytextbox(true);
            dgvThongTinNhanVien.DataSource = bLG.ThongTinDangNhap(this.MaNV);
            hienthi_textbox(0);
        }

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

        private void btnCN_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {

                xulytextbox(false);
                flag = true;
            }
            else if (flag == true)
            {
                string fname1 = DuoiAnh; // tên ảnh
                string floder1 = "D:\\DoAnTotNghiep\\DoAnTotNghiep\\DoAnQLKhachSan\\ImageNhanVien";//đường dẫn lưu ảnh
                string path1 = System.IO.Path.Combine(floder1, fname1);

                {
                    if (txtEmail.Text == "" || txtCMND.Text == "" || txtHoTen.Text == "" || txtSDT.Text == "" || txtLoaiNV.Text == "" || rtxtDiaChi.Text == "" || txtMaNV.Text == "")
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

                        int r = this.dgvThongTinNhanVien.CurrentCell.RowIndex;
                        string address = "D:\\DoAnTotNghiep\\DoAnTotNghiep\\DoAnQLKhachSan\\ImageNhanVien\\" + dgvThongTinNhanVien.Rows[r].Cells[10].Value.ToString();
                        string result;
                        result = Path.GetFileName(address);
                        string b = dgvThongTinNhanVien.Rows[r].Cells[10].Value.ToString();


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
                                txtMatKhau.Text = dgvThongTinNhanVien.Rows[r].Cells[9].Value.ToString();
                            }
                            bNV.NhanVien_CapNhat(this.ID, Int32.Parse(this.LoaiNV), txtMaNV.Text, txtMatKhau.Text, txtHoTen.Text, Convert.ToDateTime(dtpNgaySinh.Text).ToString("yyyy-MM-dd"), txtSDT.Text, rtxtDiaChi.Text, txtEmail.Text, Int32.Parse(txtCMND.Text), GT, result, true);
                            txtMatKhau.Text = "";
                            MessageBox.Show("Cập nhật thành công");
                            dgvThongTinNhanVien.DataSource = bLG.ThongTinDangNhap(this.MaNV);
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
                                txtMatKhau.Text = dgvThongTinNhanVien.Rows[r].Cells[3].Value.ToString();
                            }
                            Image a1 = pichHinh.Image;
                            a1.Save(path1); //lưu ảnh mới vào đường dẫn 
                            bNV.NhanVien_CapNhat(this.ID, Int32.Parse(this.LoaiNV), txtMaNV.Text, txtMatKhau.Text, txtHoTen.Text, Convert.ToDateTime(dtpNgaySinh.Text).ToString("yyyy-MM-dd"), txtSDT.Text, rtxtDiaChi.Text, txtEmail.Text, Int32.Parse(txtCMND.Text), GT, DuoiAnh, true);
                            txtMatKhau.Text = "";
                            MessageBox.Show("Cập nhật thành công");
                            dgvThongTinNhanVien.DataSource = bLG.ThongTinDangNhap(this.MaNV);
                            flag = false;
                            xulytextbox(true);
                            //MessageBox.Show("có lưu ảnh  if 2 ");


                        }

                    }
                }
            }
        }


        void hienthi_textbox(int numrow)
        {

            txtMaNV.Text = dgvThongTinNhanVien.Rows[numrow].Cells[0].Value.ToString();
            txtHoTen.Text = dgvThongTinNhanVien.Rows[numrow].Cells[1].Value.ToString();
            dtpNgaySinh.Text = dgvThongTinNhanVien.Rows[numrow].Cells[2].Value.ToString();
            rtxtDiaChi.Text = dgvThongTinNhanVien.Rows[numrow].Cells[3].Value.ToString();
            txtLoaiNV.Text = dgvThongTinNhanVien.Rows[numrow].Cells[5].Value.ToString();
            txtCMND.Text = dgvThongTinNhanVien.Rows[numrow].Cells[6].Value.ToString();
            txtSDT.Text = dgvThongTinNhanVien.Rows[numrow].Cells[7].Value.ToString();
            txtEmail.Text = dgvThongTinNhanVien.Rows[numrow].Cells[8].Value.ToString();
            //txtMatKhau.Text = dgvDSNhanVien.Rows[numrow].Cells[3].Value.ToString();

            try
            {
                string duongdanhinh = "D:\\DoAnTotNghiep\\DoAnTotNghiep\\DoAnQLKhachSan\\ImageNhanVien\\" + dgvThongTinNhanVien.Rows[numrow].Cells[10].Value.ToString();
                Bitmap a = new Bitmap(duongdanhinh);
                pichHinh.Image = a;
            }
            catch (Exception ex)
            {

            }
            string GT = dgvThongTinNhanVien.Rows[numrow].Cells[4].Value.ToString();
            if (GT == "Nữ")
            {
                radioNu.Checked = true;
            }
            else
            {
                radioNam.Checked = true;
            }

           
        }


    }
}
