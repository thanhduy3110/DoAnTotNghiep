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
    public partial class frmPhong : Form
    {
        public frmPhong()
        {
            InitializeComponent();
        }

        BUSPhong Bphong = new BUSPhong();
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void frmPhong_Load(object sender, EventArgs e)
        {
            Bphong.HienThiLP(cboTenLP);
            dgvDSPhong.DataSource = Bphong.Phong_Select();

        }
       
       
        bool flag=false;
        void Tang_ID()
        {
            int count = 0;
            count = dgvDSPhong.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count <= 1)
            {
                txtID.Text = "0";
            }
            else
            {
                chuoi = Convert.ToString(dgvDSPhong.Rows[count - 2].Cells[0].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 0)));
                if (chuoi2 + 1 < 10)
                    txtID.Text = "" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 < 100)
                    txtID.Text = "" + (chuoi2 + 1).ToString();
            }
        }
        void clear_textbox()
        {
            cboTenLP.Text = "";
            txtTang.Text = "";
            txtTang.Text = "";
            txtGiaThueTheoGio.Text = "";
            txtGiaThueTheoNgay.Text = "";
            rtxtGhiChu.Text = "";
           
        }

      
 

        private void txtTim_TextChangeEvent(object sender, EventArgs e)
        {
            Bphong.HienThiDanhSach(txtTim.TextValue, dgvDSPhong);
        }

       
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (flag == false)
            {
                clear_textbox();
                txtID.Text = (Bphong.Phong_Select().Rows.Count + 1).ToString();
                chkBonTam.Checked = false;
                chkGocNhin.Checked = false;
                chkHieuLuc.Checked = false;
                flag = true;
            }

            else if (flag == true)
            {
                if (cboTenLP.Text == "" || txtTang.Text == "" || txtTang.Text == "" || txtGiaThueTheoNgay.Text == "" || txtGiaThueTheoGio.Text == "" || rtxtGhiChu.Text == "")
                {
                    MessageBox.Show("Lỗi");
                }
                else
                {
                    bool hieuluc, bontam, gocnhin;

                    if (chkBonTam.Checked == true)
                    {
                        bontam = true;
                    }
                    else
                    {
                        bontam = false;
                    }
                    if (chkHieuLuc.Checked == true)
                    {
                        hieuluc = true;
                    }
                    else
                    {
                        hieuluc = false;
                    }
                    if (chkGocNhin.Checked == true)
                    {
                        gocnhin = true;
                    }
                    else
                    {
                        gocnhin = false;
                    }
                    Bphong.P_Them(txtID.Text, cboTenLP.SelectedValue.ToString(), txtTang.Text, txtTang.Text, txtGiaThueTheoNgay.Text, txtGiaThueTheoGio.Text, rtxtGhiChu.Text, gocnhin, bontam, cboConTrong.SelectedIndex, hieuluc);
                    MessageBox.Show("thêm thành công rồi nè");
                    flag = false;
                    dgvDSPhong.DataSource = Bphong.Phong_Select();
                }
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (flag == false)
            {
                flag = true;
            }
            else if (flag == true)
            {
                bool hieuluc, bontam, gocnhin;

                if (chkBonTam.Checked == true)
                {
                    bontam = true;
                }
                else
                {
                    bontam = false;
                }
                if (chkHieuLuc.Checked == true)
                {
                    hieuluc = true;
                }
                else
                {
                    hieuluc = false;
                }
                if (chkGocNhin.Checked == true)
                {
                    gocnhin = true;
                }
                else
                {
                    gocnhin = false;
                }
                Bphong.P_CapNhat(txtID.Text, cboTenLP.SelectedValue.ToString(), txtTang.Text, txtTang.Text, txtGiaThueTheoNgay.Text, txtGiaThueTheoGio.Text, rtxtGhiChu.Text, gocnhin, bontam, cboConTrong.SelectedIndex, hieuluc);
                MessageBox.Show("sửa thành công rồi nè");
                flag = false;
                dgvDSPhong.DataSource = Bphong.Phong_Select();
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {

        }

        void hienthi_textbox(int numrow)
        {
            txtID.Text = dgvDSPhong.Rows[numrow].Cells[0].Value.ToString();
            cboTenLP.Text= dgvDSPhong.Rows[numrow].Cells[1].Value.ToString();
            txtSoPhong.Text= dgvDSPhong.Rows[numrow].Cells[2].Value.ToString();
            txtTang.Text= dgvDSPhong.Rows[numrow].Cells[3].Value.ToString();
            txtGiaThueTheoNgay.Text= dgvDSPhong.Rows[numrow].Cells[4].Value.ToString();
            txtGiaThueTheoGio.Text= dgvDSPhong.Rows[numrow].Cells[5].Value.ToString();
            rtxtGhiChu.Text= dgvDSPhong.Rows[numrow].Cells[6].Value.ToString();
            cboConTrong.Text= dgvDSPhong.Rows[numrow].Cells[9].Value.ToString();

            string GocNhin= dgvDSPhong.Rows[numrow].Cells[7].Value.ToString();
            string BonTam= dgvDSPhong.Rows[numrow].Cells[8].Value.ToString();
            string HieuLuc= dgvDSPhong.Rows[numrow].Cells[10].Value.ToString();
            if (GocNhin== "Có ban công")
            {
                chkGocNhin.Checked = true;
            }    
            else
            {
                chkGocNhin.Checked = false;
            }

            if (BonTam == "Có bồn tắm")
            {
                chkBonTam.Checked = true;
            }
            else
            {
                chkBonTam.Checked = false;
            }

            if (HieuLuc == "Còn sử dụng")
            {
                chkHieuLuc.Checked = true;
            }
            else
            {
                chkHieuLuc.Checked = false;
            }

        }

        private void dgvDSPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int vt = dgvDSPhong.CurrentCell.RowIndex;
                hienthi_textbox(vt);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
