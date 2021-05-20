using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class frmMainMenu : DevExpress.XtraEditors.XtraForm
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void anPanel()
        {
            labelX1.Hide();
            panelLeft.Hide();
            panelRight.Hide();
        }

      
       

        private void btnQLNguoiDung_Click(object sender, EventArgs e)
        {
            frmQLNgDung frmND = new frmQLNgDung();
            anPanel();
            frmND.TopLevel = false;
            panelMid.Controls.Add(frmND);
            frmND.Dock = DockStyle.Fill;
            frmND.Show();
        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            frmQLNhanVien frmNV = new frmQLNhanVien();
            anPanel();
            frmNV.TopLevel = false;
            panelMid.Controls.Add(frmNV);
            frmNV.Dock = DockStyle.Fill;
            frmNV.Show();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            frmDatPhong frmDP = new frmDatPhong();
            anPanel();
            frmDP.TopLevel = false;
            panelMid.Controls.Add(frmDP);
            frmDP.Dock = DockStyle.Fill;
            frmDP.Show();
        }
    }
}
