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

      
        private void btnQLNhanVien_Click_1(object sender, EventArgs e)
        {
            frmQLNguoiDung frmNV = new frmQLNhanVien();
            anPanel();
            frmNV.TopLevel = false;
            panelMid.Controls.Add(frmNV);
            frmNV.Dock = DockStyle.Fill;
            frmNV.Show();
        }
    }
}
