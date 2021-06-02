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
        int n = 0;
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
           
                this.Close();
              
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            //this.panelMid.Controls.Clear();
            //frmQLHoaDon frHD = new frmQLHoaDon();
            //frHD.TopLevel = false;
            //this.panelMid.Controls.Add(frHD);
            //frHD.Dock = DockStyle.Fill;
            //frHD.Show();
            n++;
            this.panelMid.Visible = false;
            frmQLHoaDon frm = new frmQLHoaDon();
            frm.MdiParent = this;
            frm.Show();

        }

        public Panel panelMenu()
        {
            return panelMid;
        }
    }
}
