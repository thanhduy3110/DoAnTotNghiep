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
using BUS;

namespace QLKhachSan
{
    public partial class frmQLPhong : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmQLPhong()
        {
            InitializeComponent();
        }
        BUSPhong Bphong = new BUSPhong();

        private void btnHome_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
          
        }

        private void frmQLPhong_Load(object sender, EventArgs e)
        {
            Bphong.HienThiLP(cboTenLP);
            dgvDSPhong.DataSource = Bphong.Phong_Select();
        }

        void hienthi_textbox(int numrow)
        {
            txtID.Text = dgvDSPhong.Rows[numrow].Cells[0].Value.ToString();
            txtSoPhong.Text = dgvDSPhong.Rows[numrow].Cells[2].Value.ToString();
            txtTang.Text = dgvDSPhong.Rows[numrow].Cells[3].Value.ToString();
            txtGiaThueNgay.Text = dgvDSPhong.Rows[numrow].Cells[4].Value.ToString();
            txtGiaThueGio.Text = dgvDSPhong.Rows[numrow].Cells[5].Value.ToString();
            rtxtGhiChu.Text= dgvDSPhong.Rows[numrow].Cells[6].Value.ToString();
            cboGocNhin.Text = dgvDSPhong.Rows[numrow].Cells[7].Value.ToString();
            cboBonTam.Text = dgvDSPhong.Rows[numrow].Cells[8].Value.ToString();
            cboConTrong.Text = dgvDSPhong.Rows[numrow].Cells[9].Value.ToString();
            cboHieuLuc.Text = dgvDSPhong.Rows[numrow].Cells[10].Value.ToString();

            int t = Int32.Parse(dgvDSPhong.Rows[numrow].Cells[1].Value.ToString());
            int tong = dgvDSPhong.Rows.Count;
            for (int i= 0;i<tong;i++)
            {
                if(i==t)
                {
                    cboTenLP.SelectedIndex = i-1;
                }    
            }    
        }

        private void dgvDSPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = dgvDSPhong.CurrentCell.RowIndex;
            hienthi_textbox(vt);
        }
    }
}