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
                
                chkHieuLuc.Checked = true;
                flag = true;
                xulytextbox(false);
                clear_textbox();
            }
            else if (flag == true)
            {
                string fname = DuoiAnh; // tên ảnh
                string floder = "D:\\DoAnTotNghiep\\DoAnTotNghiep\\DoAnQLKhachSan\\ImageDichVu\\";//đường dẫn lưu ảnh
                string path = System.IO.Path.Combine(floder, fname);
                Image a = pictureBox.Image;
                a.Save(path); //lưu ảnh vào đường dẫn   
                if (cboLoaiDV.Text == "" || txtTenDV.Text == "" || pictureBox.Image == null || txtGiaTien.Text == "" || txtSLTon.Text == "" || txtDVT.Text == ""  )
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

                    //string fname = txtID.Text + ".jpg"; // tên ảnh theo id
                    //string floder = "D:\\DoAnTotNghiep\\DoAnTotNghiep\\DoAnQLKhachSan\\DoAnQLKhachSan\\Images\\";//đường dẫn lưu ảnh
                    //string path = System.IO.Path.Combine(floder, fname);//lưu tên ảnh xuống csdl
                    //Image a = pictureBox.Image;
                    //a.Save(path);
                    int TangID = bdv.DV_Select().Rows.Count + 1;
                    bdv.DV_Them(TangID, cboLoaiDV.SelectedIndex+1, txtTenDV.Text, rtxtMoTa.Text, fname, txtGiaTien.Text, txtSLTon.Text, txtDVT.Text, rtxtGhiChu.Text, HieuLuc);
                    MessageBox.Show("thêm thành công");
                    flag = false;
                    xulytextbox(true);
                    dgvDichVu.DataSource = bdv.DV_Select();
                }
            }
          

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (flag == false)
            {
                flag = true;
                xulytextbox(false);
            }
            else if (flag == true)
            {
                string fname1 = DuoiAnh; // tên ảnh
                string floder1 = "D:\\DoAnTotNghiep\\DoAnTotNghiep\\DoAnQLKhachSan\\ImageDichVu\\";//đường dẫn lưu ảnh
                string path1 = System.IO.Path.Combine(floder1, fname1);

                {
                    if (cboLoaiDV.Text == "" || txtTenDV.Text == "" || pictureBox.Image == null || txtGiaTien.Text == "" || txtSLTon.Text == "" || txtDVT.Text == "")
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
                        int r = this.dgvDichVu.CurrentCell.RowIndex;
                        string address = "D:\\DoAnTotNghiep\\DoAnTotNghiep\\DoAnQLKhachSan\\ImageDichVu\\" + dgvDichVu.Rows[r].Cells[4].Value.ToString();
                        string result;
                        result = Path.GetFileName(address);
                        string b = dgvDichVu.Rows[r].Cells[4].Value.ToString();


                        FileInfo info = new FileInfo(@"D:\DoAnTotNghiep\DoAnTotNghiep\DoAnQLKhachSan\ImageDichVu\" + DuoiAnh);
                        //Get file infromation from info object


                        string FileNames = info.Name;
                        //{
                        //    MessageBox.Show("info " + FileNames);
                        //}

                        if (FileNames == "")  //picturebox bằng null là ảnh giống ảnh cũ
                        {
                            //MessageBox.Show("Có vô so sánh if 1");


                            bdv.DV_CapNhat(ID, cboLoaiDV.SelectedIndex + 1, txtTenDV.Text, rtxtMoTa.Text, result, txtGiaTien.Text, txtSLTon.Text, txtDVT.Text, rtxtGhiChu.Text, HieuLuc);

                            MessageBox.Show("Cập nhật thành công");
                            dgvDichVu.DataSource = bdv.DV_Select();
                            flag = false;
                            xulytextbox(true);
                            //MessageBox.Show("Có lưu if 1");


                        }

                        else //khác
                        {
                            {
                                //MessageBox.Show("có vô so sánh if 2 " + path1);
                            }

                            Image a1 = pictureBox.Image;
                            a1.Save(path1); //lưu ảnh mới vào đường dẫn 
                            bdv.DV_CapNhat(ID, cboLoaiDV.SelectedIndex + 1, txtTenDV.Text, rtxtMoTa.Text, DuoiAnh, txtGiaTien.Text, txtSLTon.Text, txtDVT.Text, rtxtGhiChu.Text, HieuLuc);
                            MessageBox.Show("Cập nhật thành công");
                            dgvDichVu.DataSource = bdv.DV_Select();
                            flag = false;
                            xulytextbox(true);
                            //MessageBox.Show("có lưu ảnh  if 2 ");


                        }

                    }
                }
            }
            //else if (flag == true)
            //{
            //    bool HieuLuc;
            //    if (chkHieuLuc.Checked == true)
            //    {
            //        HieuLuc = true;
            //    }
            //    else
            //    {
            //        HieuLuc = false;
            //    }
            //    string fname1 = DuoiAnh; // tên ảnh
            //    string floder1 = "D:\\DoAnTotNghiep\\DoAnTotNghiep\\DoAnQLKhachSan\\ImageDichVu\\";//đường dẫn lưu ảnh
            //    string path1 = System.IO.Path.Combine(floder1, fname1);

            //    int r = this.dgvDichVu.CurrentCell.RowIndex;
            //    string address = "D:\\DoAnTotNghiep\\DoAnTotNghiep\\DoAnQLKhachSan\\ImageDichVu\\" + dgvDichVu.Rows[r].Cells[4].Value.ToString();
            //    string result;
            //    result = Path.GetFileName(address);
            //    string b = dgvDichVu.Rows[r].Cells[4].Value.ToString();
            //    FileInfo info = new FileInfo(@"D:\DoAnTotNghiep\DoAnTotNghiep\DoAnQLKhachSan\ImageDichVu\" + DuoiAnh);
            //    string FileNames = info.Name;
            //    if (FileNames == "")  //picturebox bằng null là ảnh giống ảnh cũ
            //    {
            //        //MessageBox.Show("Có vô so sánh if 1");

            //        bdv.DV_CapNhat(ID.ToString(), cboLoaiDV.SelectedIndex+1, txtTenDV.Text, rtxtMoTa.Text, result, txtGiaTien.Text, txtSLTon.Text, txtDVT.Text, rtxtGhiChu.Text, HieuLuc);
            //        MessageBox.Show("Cập nhật thành công");
            //        flag = false;
            //        xulytextbox(true);
            //        dgvDichVu.DataSource = bdv.DV_Select();
            //        //MessageBox.Show("Có lưu if 1");


            //    }

            //    else //khác
            //    {
            //        {
            //            //MessageBox.Show("có vô so sánh if 2 " + path1);
            //        }

            //        Image a1 = pictureBox.Image;
            //        a1.Save(path1); //lưu ảnh mới vào đường dẫn 
            //        bdv.DV_CapNhat(ID.ToString(), cboLoaiDV.SelectedIndex+1, txtTenDV.Text, rtxtMoTa.Text, DuoiAnh, txtGiaTien.Text, txtSLTon.Text, txtDVT.Text, rtxtGhiChu.Text, HieuLuc);
            //        MessageBox.Show("Cập nhật thành công");
            //        flag = false;
            //        xulytextbox(true);
            //        dgvDichVu.DataSource = bdv.DV_Select();
            //        //MessageBox.Show("có lưu ảnh  if 2 ");


            //    }


            //}

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa dịch vụ này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bdv.DV_Xoa(ID.ToString());
                dgvDichVu.DataSource = bdv.DV_Select();
            }
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
            cboLoaiDV.Text = dgvDichVu.Rows[numrow].Cells[1].Value.ToString();
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
            string floder = "D:\\DoAnTotNghiep\\DoAnTotNghiep\\DoAnQLKhachSan\\ImageDichVu\\" + dgvDichVu.Rows[numrow].Cells[4].Value.ToString();
            Bitmap a = new Bitmap(floder);
            pictureBox.Image = a;
        }
        int ID;
        

        string DuoiAnh = "";
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
                    DuoiAnh = open.SafeFileName;// lấy tên ảnh
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

        private void txtTim_Load(object sender, EventArgs e)
        {

        }

        private void txtTim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int vt = dgvDichVu.CurrentCell.RowIndex;
                hienthi_textbox(vt);
                ID = Int32.Parse(dgvDichVu.Rows[vt].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {

            }
        }
    }
}
