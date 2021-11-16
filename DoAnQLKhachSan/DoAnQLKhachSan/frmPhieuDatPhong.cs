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
    public partial class frmPhieuDatPhong : Form
    {
        public frmPhieuDatPhong()
        {
            InitializeComponent();
        }

        BUSPhieuDatPhong bpdp = new BUSPhieuDatPhong();
        bool flag=false;

        public void XulyTextBox(bool t)
        {
            txtSDT.ReadOnly = !t;
            txtSoKH.ReadOnly = !t;
            rtxtGhiChu.ReadOnly = !t;
            dtNgayDen.Enabled = t;
            dtNgayDi.Enabled = t;
            radioNgay.Enabled = t;
            
            

        }

        public void ClearTextBox()
        {
            txtSDT.Text = "";
            cboTenKH.Text = "";
            rtxtGhiChu.Text = "";
            
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if(flag==false)
            {
                clear_textbox();
                XulyTextBox(true);
                chkHieuLuc.Checked = true;
                chkDaXuLy.Checked = false;
                radioNgay.Checked = false;
                flag = true;
            }    
      
            else if (flag == true)
            {
                if ( dtNgayDen.Text == "" || dtNgayDi.Text == ""  || txtSoKH.Text == ""  )
                {
                    MessageBox.Show("Lỗi");
                }
                else
                {

                    bool  DaXuLy, HieuLuc;
                    bool HinhThucThue=false;
                    if(chkDaXuLy.Checked==true)
                    {
                        DaXuLy = true;
                    }    
                    else
                    {
                        DaXuLy = false;
                    }    

                    if(chkHieuLuc.Checked==true)
                    {
                        HieuLuc = true;
                    }    
                    else
                    {
                        HieuLuc = false;
                    }   
                    if(radioNgay.Checked==true)
                    {
                        HinhThucThue = false;
                    }
                    string TangID = (bpdp.PDP_Select().Rows.Count + 1).ToString();
                    bpdp.PDP_Them(TangID, cboTenKH.SelectedValue.ToString(), Convert.ToDateTime(dtNgayDen.Text).ToString("yyyy-MM-dd") , Convert.ToDateTime(dtNgayDi.Text).ToString("yyyy-MM-dd"), HinhThucThue, txtSoKH.Text, rtxtGhiChu.Text, DaXuLy, HieuLuc);
                    MessageBox.Show("thêm thành công");
                    flag = false;
                    XulyTextBox(false);
                    dgvPhieuDatPhong.DataSource = bpdp.PDP_Select();
                }
            }
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(flag == false)
            {
                XulyTextBox(true);
                flag = true;
            }    
            else if (flag == true)
            {
                bool HinhThucThue = false, DaXuLy, HieuLuc;
                if (chkDaXuLy.Checked == true)
                {
                    DaXuLy = true;
                }
                else
                {
                    DaXuLy = false;
                }

                if (chkHieuLuc.Checked == true)
                {
                    HieuLuc = true;
                }
                else
                {
                    HieuLuc = false;
                }
                if (radioNgay.Checked == true)
                {
                    HinhThucThue = false;
                }
               
                bpdp.PDP_CapNhat(ID.ToString(), cboTenKH.SelectedValue.ToString(), Convert.ToDateTime(dtNgayDen.Text).ToString("yyyy-MM-dd"), Convert.ToDateTime(dtNgayDi.Text).ToString("yyyy-MM-dd"), HinhThucThue, txtSoKH.Text, rtxtGhiChu.Text, DaXuLy, HieuLuc);
                MessageBox.Show("Sửa thành công");
                flag = false;
                XulyTextBox(false);
                dgvPhieuDatPhong.DataSource = bpdp.PDP_Select();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa phiếu đặt phòng này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool HL = false;
                bpdp.phieudatphong_xoa(ID, HL);
                dgvPhieuDatPhong.DataSource = bpdp.PDP_Select();
            }
        }

      

        private void frmPhieuDatPhong_Load(object sender, EventArgs e)
        {
            //bpdp.HienThiID_KH(cboTenKH);
            XulyTextBox(false);
            bpdp.HienThiID_KH(cboTenKH);
            dgvPhieuDatPhong.DataSource = bpdp.PDP_Select();
        }

        void hienthi_textbox(int numrow)
        {

            cboTenKH.Text = dgvPhieuDatPhong.Rows[numrow].Cells[1].Value.ToString();
            dtNgayDen.Text = dgvPhieuDatPhong.Rows[numrow].Cells[2].Value.ToString();
            dtNgayDi.Text = dgvPhieuDatPhong.Rows[numrow].Cells[3].Value.ToString();
            string HTT = dgvPhieuDatPhong.Rows[numrow].Cells[4].Value.ToString();
            txtSoKH.Text = dgvPhieuDatPhong.Rows[numrow].Cells[5].Value.ToString();
            rtxtGhiChu.Text = dgvPhieuDatPhong.Rows[numrow].Cells[6].Value.ToString();
            string DXL = dgvPhieuDatPhong.Rows[numrow].Cells[7].Value.ToString();
            string HL = dgvPhieuDatPhong.Rows[numrow].Cells[8].Value.ToString();
            txtSDT.Text= dgvPhieuDatPhong.Rows[numrow].Cells[9].Value.ToString();
            if (HTT== "Thuê theo ngày")
            {
                radioNgay.Checked = true;
            }    
         
            
            if(DXL== "Xử lý rồi")
            {
                chkDaXuLy.Checked = true;
            }    
            else
            {
                chkDaXuLy.Checked = false;
            }
            if (HL == "Còn")
            {
                chkHieuLuc.Checked = true;
            }
            else
            {
                chkHieuLuc.Checked = false;
            }

        }

        //void Tang_ID()
        //{
        //    int count = 0;
        //    count = dgvPhieuDatPhong.Rows.Count;
        //    string chuoi = "";
        //    int chuoi2 = 0;
        //    if (count <= 1)
        //    {
        //        txtID.Text = "0";
        //    }
        //    else
        //    {
        //        chuoi = Convert.ToString(dgvPhieuDatPhong.Rows[count - 2].Cells[0].Value);
        //        chuoi2 = Convert.ToInt32((chuoi.Remove(0, 0)));
        //        if (chuoi2 + 1 < 10)
        //            txtID.Text = "" + (chuoi2 + 1).ToString();
        //        else if (chuoi2 + 1 < 100)
        //            txtID.Text = "" + (chuoi2 + 1).ToString();
        //    }
        //}
        void clear_textbox()
        {
            
            dtNgayDen.Text = "";
            dtNgayDi.Text = "";            
            txtSoKH.Text = "";
            rtxtGhiChu.Text = "";
        }

        int ID;
        private void dgvPhieuDatPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int vt = dgvPhieuDatPhong.CurrentCell.RowIndex;
                hienthi_textbox(vt);
                ID=Int32.Parse(dgvPhieuDatPhong.Rows[vt].Cells[0].Value.ToString());

            }
            catch (Exception ex)
            {
                
            }
        }

        private void txtTim_TextChangeEvent(object sender, EventArgs e)
        {
            bpdp.HienThiDanhSach(txtTim.TextValue, dgvPhieuDatPhong);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtSDT_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if (bpdp.phieudatphong_HienThiTenKH(txtSDT.Text).Rows.Count == 0)
                    MessageBox.Show("Tên khách hàng chưa có trong danh sách");
                else
                {
                    cboTenKH.Text = bpdp.phieudatphong_HienThiTenKH(txtSDT.Text).Rows[0][0].ToString();
                }    
            }    
        }
    }
}
