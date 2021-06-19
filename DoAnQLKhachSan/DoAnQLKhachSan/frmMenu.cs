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
        public frmMenu()
        {
            InitializeComponent();
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
            frmLoaiNhanVien lnv = new frmLoaiNhanVien();
            lnv.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQLNhanVien());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            openChildForm(new frmKhachHang());
        }

        private void btnCTHD_Click(object sender, EventArgs e)
        {
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
            frmLoaiDichVu ldv = new frmLoaiDichVu();
            ldv.Show();
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDichVu());
        }

        private void btnLoaiPhong_Click(object sender, EventArgs e)
        {
            frmLoaiPhong lp = new frmLoaiPhong();
            lp.Show();
        }

        private void btnPhieuDatPhong_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPhieuDatPhong());
        }

        private void btnPhongDaDat_Click(object sender, EventArgs e)
        {
            frmPhongDaDat pdd = new frmPhongDaDat();
            pdd.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau dmk = new frmDoiMatKhau();
            dmk.Show();
        }
      
    }
}
