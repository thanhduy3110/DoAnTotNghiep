using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQLKhachSan
{
    public partial class frmMenu : Form
    {
        private string MaNV="", LoaiNV="",TenNV="";
        private int ID;
        public frmMenu()
        {
            InitializeComponent();
        }

        public frmMenu(string MaNV,string LoaiNV,int ID, string TenNV)
        {
            InitializeComponent();
            this.MaNV = MaNV;
            this.LoaiNV = LoaiNV;
            this.ID = ID;
            this.TenNV = TenNV;
        }

        public Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelMenu.Controls.Add(childForm);
            panelMenu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }      
        public void closefrom(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMenu.Controls.Add(childForm);
            panelMenu.Tag = childForm;
            childForm.BringToFront();
            childForm.Close();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                frmLogin fLG = new frmLogin();
                fLG.Show();
            }
                
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn trở về menu chính không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                closefrom(new frmMenu());
            }
            
        }

        private void btnLoaiNV_Click(object sender, EventArgs e)
        {
            //if (this.LoaiNV == "4")
            //{
                openChildForm(new frmLoaiNhanVien());
            //}
            //else
            //{
            //    MessageBox.Show("Bạn không có quyền vào chức năng này");
            //}

        }

       
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
        //    if(this.LoaiNV == "4")
        //    {
               openChildForm(new frmQLNhanVien());
            //}
            //else
            //{
            //    MessageBox.Show("Bạn không có quyền vào chức năng này");
            //}
        }    
          

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            openChildForm(new frmKhachHang());
        }

       

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            openChildForm(new frmHoaDon(ID,TenNV));
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            
            //if (this.LoaiNV == "4")
            //{
                openChildForm(new frmPhong());
            //}
            //else
            //{
            //    MessageBox.Show("Bạn không có quyền vào chức năng này");
            //}
        }

        private void btnLoaiDV_Click(object sender, EventArgs e)
        {
            
            //if (this.LoaiNV == "4")
            //{
                openChildForm(new frmLoaiDichVu());
            //}
            //else
            //{
            //    MessageBox.Show("Bạn không có quyền vào chức năng này");
            //}
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDichVu());
        }

        private void btnLoaiPhong_Click(object sender, EventArgs e)
        {
            
            //if (this.LoaiNV == "4")
            //{
                openChildForm(new frmLoaiPhong());
             //}
        //    else
        //    {
        //        MessageBox.Show("Bạn không có quyền vào chức năng này");
        //    }
}

        private void btnPhieuDatPhong_Click(object sender, EventArgs e)
        {

            openChildForm(new frmPhieuDatPhong());
        }

        private void btnPhongDaDat_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPhongDaDat(ID));
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThongKe());
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            if(Int32.Parse(this.LoaiNV)==1)
            {
                btnNhanVien.Enabled = false;
                btnLoaiNV.Enabled = false;
                btnDichVu.Enabled = false;
                btnLoaiDV.Enabled = false;
                btnLoaiPhong.Enabled = false;
                btnThongKe.Enabled = false;
            }else if(Int32.Parse(this.LoaiNV) == 2)
            {
                btnNhanVien.Enabled = false;
                btnDichVu.Enabled = false;
                btnLoaiDV.Enabled = false;
                btnLoaiPhong.Enabled = false;
                btnThongKe.Enabled = false;
                btnPhong.Enabled = false;
                btnPhieuDatPhong.Enabled = false;
                btnPhongDaDat.Enabled = false;
                btnLoaiNV.Enabled = false;
                btnKhachHang.Enabled = false;

            }else if(Int32.Parse(this.LoaiNV)==4)
            {
                btnNhanVien.Enabled = true;
                btnDichVu.Enabled = true;
                btnLoaiDV.Enabled = true;
                btnLoaiPhong.Enabled = true;
                btnThongKe.Enabled = true;
                btnPhong.Enabled = true;
                btnPhieuDatPhong.Enabled = true;
                btnPhongDaDat.Enabled = true;
                btnLoaiNV.Enabled = true;
                btnKhachHang.Enabled = true;
                btnHoaDon.Enabled = true;
            }    
            else if(Int32.Parse(this.LoaiNV) != 1|| Int32.Parse(this.LoaiNV) != 2|| Int32.Parse(this.LoaiNV) != 4)
            {
                btnNhanVien.Enabled = false;
                btnDichVu.Enabled = false;
                btnLoaiDV.Enabled = false;
                btnLoaiPhong.Enabled = false;
                btnThongKe.Enabled = false;
                btnPhong.Enabled = false;
                btnPhieuDatPhong.Enabled = false;
                btnPhongDaDat.Enabled = false;
                btnLoaiNV.Enabled = false;
                btnKhachHang.Enabled = false;
                btnHoaDon.Enabled = false;
            }    
           
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThongTinDangNhap(MaNV,ID,LoaiNV));
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
