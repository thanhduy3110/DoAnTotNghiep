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
    public partial class frmQLNhanVien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmQLNhanVien()
        {
            InitializeComponent();
        }

        private void btnHome_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Controls.Clear();
            frmMenu frm = new frmMenu();
            frm.TopLevel = false;
            this.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}