using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class frmMenu : DevExpress.XtraEditors.XtraForm
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        //public Panel panelMenu()
        //{
        //    return panelMid;
        //}
        public Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMid.Controls.Add(childForm);
            panelMid.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void frmMenu_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult request = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (request == DialogResult.Yes)
                e.Cancel = false;
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            //this.panelMid.Visible = false;
            //frmQLNhanVien frm = new frmQLNhanVien();
            //frm.MdiParent = this;
            //frm.Show();
            openChildForm(new frmQLNhanVien());
        }

        private void btnPhieuDatPhong_Click(object sender, EventArgs e)
        {
            //this.panelMid.Visible = false;
            //frmQLPhieuDatPhong frm = new frmQLPhieuDatPhong();
            //frm.MdiParent = this;
            //frm.Show();
            openChildForm(new frmQLPhieuDatPhong());
        }

        private void btnPhongDaDat_Click(object sender, EventArgs e)
        {
            //this.panelMid.Visible = false;
            //frmQLPhongDaDat frm = new frmQLPhongDaDat();
            //frm.MdiParent = this;
            //frm.Show();
            openChildForm(new frmQLPhongDaDat());
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            //this.panelMid.Visible = false;
            //frmQLPhong frm = new frmQLPhong();
            //frm.MdiParent = this;
            //frm.Show();
            openChildForm(new frmQLPhong());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            //this.panelMid.Visible = false;
            //frmQLKhachHang frm = new frmQLKhachHang();
            //frm.MdiParent = this;
            //frm.Show();
            openChildForm(new frmQLKhachHang());
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            //this.panelMid.Visible = false;
            //frmQLDichVu frm = new frmQLDichVu();
            //frm.MdiParent = this;
            //frm.Show();
            openChildForm(new frmQLDichVu());
        }

        private void btnLoaiDichVu_Click(object sender, EventArgs e)
        {
            //this.panelMid.Visible = false;
            //frmQLLoaiDV frm = new frmQLLoaiDV();
            //frm.MdiParent = this;
            //frm.Show();
            openChildForm(new frmQLLoaiDV());
        }

        private void btnLoaiPhong_Click(object sender, EventArgs e)
        {
            //this.panelMid.Visible = false;
            //frmQLLoaiPhong frm = new frmQLLoaiPhong();
            //frm.MdiParent = this;
            //frm.Show();
            openChildForm(new frmQLLoaiPhong());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            //this.panelMid.Visible = false;
            //frmQLHoaDon frm = new frmQLHoaDon();
            //frm.MdiParent = this;
            //frm.Show();
            openChildForm(new frmQLHoaDon());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLoaiNhanVien_Click(object sender, EventArgs e)
        {
            //this.panelMid.Visible = false;
            //frmQLLoaiNV frm = new frmQLLoaiNV();
            //frm.MdiParent = this;
            //frm.Show();
            openChildForm(new frmQLLoaiNV());
        }
    }
}
