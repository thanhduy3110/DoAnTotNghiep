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

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            this.panelMid.Visible = false;
            frmQLHoaDon frm = new frmQLHoaDon();
            frm.MdiParent = this;
            frm.Show();

        }

        public Panel panelMenu()
        {
            return panelMid;
        }

        private void frmMenu_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult request = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (request == DialogResult.Yes)
                e.Cancel = false;
        }
    }
}
