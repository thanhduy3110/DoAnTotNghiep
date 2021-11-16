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

namespace DoAnQLKhachSan
{
    public partial class frmTimPhong : Form
    {
        //private string ngayden, ngaydi;
        //private int gocnhin;
        //private bool bontam;
        public delegate void TruyenChoHD(string MaPhong);
        public TruyenChoHD truyenchoHD;
        BUSPhongDaDat bPDD = new BUSPhongDaDat();
        public frmTimPhong()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(radioPhongCD.Checked==true)
            {
                if(cboGocNhin.Text=="")
                {
                    MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
                }    
                else
                {
                    bool BonTam1;
                    if (chkBonTam.Checked == true)
                    {
                        BonTam1 = true;
                    }
                    else
                    {
                        BonTam1 = false;
                    }
                    dgvDSPhong.Columns.Clear();
                    dgvDSPhong.DataSource = bPDD.PhongDaDat_TimDSPhongCD(cboGocNhin.SelectedIndex, BonTam1);
                }    
               
            }  
            else if(radioPhongDD.Checked==true)
            {
                if (dtpNgayBD.Text == "" || dtpNgayKT.Text == "" || cboGocNhin.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
                }
                else
                {
                    bool BonTam;
                    if (chkBonTam.Checked == true)
                    {
                        BonTam = true;
                    }
                    else
                    {
                        BonTam = false;
                    }
                    dgvDSPhong.Columns.Clear();
                    dgvDSPhong.DataSource = bPDD.PhongDaDat_TimDSPhongDD(Convert.ToDateTime(dtpNgayBD.Text).ToString("yyyy-MM-dd"), Convert.ToDateTime(dtpNgayKT.Text).ToString("yyyy-MM-dd"), cboGocNhin.SelectedIndex, BonTam);
                }
            }    
          
         }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void frmTimPhong_Load(object sender, EventArgs e)
        {
            
            dgvDSPhong.Columns.Clear();
            
            //dgvDSPhong.DataSource = bPDD.PhongDaDat_TimDSPhong(Convert.ToDateTime(dtpNgayBD.Text).ToString("yyyy-MM-dd"), Convert.ToDateTime(dtpNgayKT.Text).ToString("yyyy-MM-dd"), cboGocNhin.SelectedIndex, BonTam);
        }

        private void btnChonPhongf_Click(object sender, EventArgs e)
        {

            truyenchoHD(MaPhong);
            this.Close();
            
        }

        string MaPhong;
        private void dgvDSPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = dgvDSPhong.CurrentCell.RowIndex;
            MaPhong = dgvDSPhong.Rows[vt].Cells[0].Value.ToString();
        }
    }
}
