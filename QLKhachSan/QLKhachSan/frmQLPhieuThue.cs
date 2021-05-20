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
    public partial class frmQLPhieuThue : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmQLPhieuThue()
        {
            InitializeComponent();
        }

        private void btnHome_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Controls.Clear();
            frmDatPhong frmDP = new frmDatPhong();
            frmDP.TopLevel = false;
            this.Controls.Add(frmDP);
            frmDP.Dock = DockStyle.Fill;
            frmDP.Show();
        }
    }
}