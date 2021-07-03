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
        public string MaNV="", LoaiNV="";
        public frmMenu()
        {
            InitializeComponent();
        }

        public frmMenu(string MaNV,string LoaiNV)
        {
            InitializeComponent();
            this.MaNV = MaNV;
            this.LoaiNV = LoaiNV;
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
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            closefrom(new frmMenu());
        }

        private void btnLoaiNV_Click(object sender, EventArgs e)
        {
            openChildForm(new frmLoaiNhanVien(MaNV,LoaiNV));
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQLNhanVien());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            openChildForm(new frmKhachHang());
        }

       

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            openChildForm(new frmHoaDon());
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPhong());
        }

        private void btnLoaiDV_Click(object sender, EventArgs e)
        {
            openChildForm(new frmLoaiDichVu());
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDichVu());
        }

        private void btnLoaiPhong_Click(object sender, EventArgs e)
        {
            openChildForm(new frmLoaiPhong());
        }

        private void btnPhieuDatPhong_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPhieuDatPhong());
        }

        private void btnPhongDaDat_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPhongDaDat());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau dmk = new frmDoiMatKhau();
            dmk.Show();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
