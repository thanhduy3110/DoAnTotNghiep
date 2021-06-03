using DevExpress.XtraBars;
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
    public partial class frmQLLoaiNV : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmQLLoaiNV()
        {
            InitializeComponent();
        }

        private void btnHome_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
            frmMenu frm = new frmMenu();
            frm.panelMenu().Visible = true;
            frm.Show();
        }
    }
}