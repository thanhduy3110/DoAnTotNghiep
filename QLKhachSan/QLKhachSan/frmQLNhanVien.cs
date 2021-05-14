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
    public partial class frmQLNguoiDung : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmQLNguoiDung()
        {
            InitializeComponent();
        }

        private void btnHome_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMainMenu frm = new frmMainMenu();
            this.Close();
            frm.Show();
        }
    }
}