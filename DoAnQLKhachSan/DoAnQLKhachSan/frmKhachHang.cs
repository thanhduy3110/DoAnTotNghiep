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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        BUSKhachHang bkh = new BUSKhachHang();
        void hienthi_textbox(int numrow)
        {
            txtHoTen.Text = dgvKhachHang.Rows[numrow].Cells[1].Value.ToString();
            dtNgaySinh.Text = dgvKhachHang.Rows[numrow].Cells[2].Value.ToString();
            txtSDT.Text = dgvKhachHang.Rows[numrow].Cells[3].Value.ToString();
            txtEmail.Text = dgvKhachHang.Rows[numrow].Cells[4].Value.ToString();
            txtCMND.Text = dgvKhachHang.Rows[numrow].Cells[5].Value.ToString();
            string GT = dgvKhachHang.Rows[numrow].Cells[6].Value.ToString();
            txtQT.Text = dgvKhachHang.Rows[numrow].Cells[7].Value.ToString();
            string HL = dgvKhachHang.Rows[numrow].Cells[8].Value.ToString();

            if (GT == "Nữ")
            {
                radioNu.Checked = true;
            }
            else
            {
                radioNam.Checked = true;
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
        bool flag = false;
        //void Tang_ID()
        //{
        //    int count = 0;
        //    count = dgvKhachHang.Rows.Count;
        //    string chuoi = "";
        //    int chuoi2 = 0;
        //    if (count <= 1)
        //    {
        //        txtID.Text = "0";
        //    }
        //    else
        //    {
        //        chuoi = Convert.ToString(dgvKhachHang.Rows[count - 2].Cells[0].Value);
        //        chuoi2 = Convert.ToInt32((chuoi.Remove(0, 0)));
        //        if (chuoi2 + 1 < 10)
        //            txtID.Text = "" + (chuoi2 + 1).ToString();
        //        else if (chuoi2 + 1 < 100)
        //            txtID.Text = "" + (chuoi2 + 1).ToString();
        //    }
        //}
        void clear_textbox()
        {
            txtHoTen.Text = "";
            dtNgaySinh.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtCMND.Text = "";
            txtQT.Text = "";
        }

        void xulytextbox(Boolean t)
        {
            txtHoTen.ReadOnly = t;
            txtCMND.ReadOnly = t;
            txtSDT.ReadOnly = t;
            txtEmail.ReadOnly = t;
            txtQT.ReadOnly = t;
            
        }

      
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if(flag==false)
            {
                clear_textbox();
                xulytextbox(false);
                radioNam.Checked = false;
                radioNu.Checked = false;
                chkHieuLuc.Checked = false;
                flag = true;
            }    
            else if (flag == true)
            {
                if (txtHoTen.Text == "" || dtNgaySinh.Text == "" || txtSDT.Text == "" || txtCMND.Text == "" ||  txtQT.Text == "" )
                {
                    MessageBox.Show("Lỗi");
                }
                else
                {
                    Boolean GT = false;
                    bool HieuLuc;
                    if (radioNam.Checked == true)
                    {
                        GT = true;

                    }
                    else if (radioNu.Checked == true)
                    {
                        GT = false;
                    }

                    if (chkHieuLuc.Checked == true)
                    {
                        HieuLuc = true;
                    }
                    else
                    {
                        HieuLuc = false;
                    }

                    //lọc trùng dữ liệu
                    int numrow = dgvKhachHang.CurrentCell.RowIndex;
                    if (dgvKhachHang.Rows.Count > 0)
                    {
                        if (txtSDT.Text == dgvKhachHang.Rows[numrow].Cells[3].Value.ToString())
                        {

                        }
                        else
                        {
                            for (int i = 0; i < dgvKhachHang.Rows.Count - 1; i++)
                            {
                                if (txtSDT.Text == dgvKhachHang.Rows[i].Cells[3].Value.ToString())
                                {
                                    MessageBox.Show("Số điện thoại đã tồn tại trong hệ thống");
                                    return;
                                }
                            }
                        }
                        if (txtCMND.Text == dgvKhachHang.Rows[numrow].Cells[5].Value.ToString())
                        {

                        }
                        else for (int i = 0; i < dgvKhachHang.Rows.Count - 1; i++)
                            {
                                if (txtCMND.Text == dgvKhachHang.Rows[i].Cells[5].Value.ToString())
                                {
                                    MessageBox.Show("Số chứng minh nhân dân đã tồn tại trong hệ thống");
                                    return;
                                }

                            }
                    }
                    string TangID = (bkh.KH_Select().Rows.Count + 1).ToString();
                    bkh.KH_Them(TangID, txtHoTen.Text, Convert.ToDateTime(dtNgaySinh.Text).ToString("yyyy-MM-dd"), txtSDT.Text, txtEmail.Text, txtCMND.Text, GT, txtQT.Text, HieuLuc);
                    MessageBox.Show("thêm thành công");
                    flag = false;
                    xulytextbox(true);
                    dgvKhachHang.DataSource = bkh.KH_Select();
                }
            }
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                flag = true;
                xulytextbox(false);
            }
            else if (flag == true)
            {
                Boolean GT = false;
                bool HieuLuc;
                if (radioNam.Checked == true)
                {
                    GT = true;

                }
                else if (radioNu.Checked == true)
                {
                    GT = false;
                }

                if (chkHieuLuc.Checked == true)
                {
                    HieuLuc = true;
                }
                else
                {
                    HieuLuc = false;
                }

                //lọc trùng dữ liệu
                int numrow = dgvKhachHang.CurrentCell.RowIndex;//lấy dữ liệu dòng hiện tại
                if (dgvKhachHang.Rows.Count > 0)
                {
                    if (txtSDT.Text == dgvKhachHang.Rows[numrow].Cells[3].Value.ToString())//so sánh txtSDT với SDT dòng numrow ở dgv
                    {
                        //nêu bằng thì bỏ qua bước này
                        //nêu không bằng nhau thì xuống else
                    }
                    else
                    {
                        for (int i = 0; i < dgvKhachHang.Rows.Count - 1; i++)//vòng lặp
                        {
                            if (txtSDT.Text == dgvKhachHang.Rows[i].Cells[3].Value.ToString())//so sánh txtSDT với từng dòng trong dgv
                            {
                                //nêu txtSDT bằng với một hàng thì đã tồn tại
                                MessageBox.Show("Số điện thoại đã tồn tại trong hệ thống");
                                return;
                            }
                        }
                    }
                    if (txtCMND.Text == dgvKhachHang.Rows[numrow].Cells[5].Value.ToString())//so sánh txtCMND với số CMND dòng numrow ở dgv
                    {
                        //nêu bằng nhau thì bỏ qua bước này
                        //nêu không bằng nhau thì xuống else
                    }
                    else
                        for (int i = 0; i < dgvKhachHang.Rows.Count - 1; i++)
                        {
                            if (txtCMND.Text == dgvKhachHang.Rows[i].Cells[5].Value.ToString())
                            {
                                //nếu txtCMND bằng với một hàng thì đã tồn tại
                                MessageBox.Show("Số chứng minh nhân dân đã tồn tại trong hệ thống");
                                return;
                            }
                        }
                }

                bkh.KH_CapNhat(ID, txtHoTen.Text, Convert.ToDateTime(dtNgaySinh.Text).ToString("yyyy-MM-dd"), txtSDT.Text, txtEmail.Text, txtCMND.Text, GT, txtQT.Text, HieuLuc);
                MessageBox.Show("Sữa thành công");
                flag = false;
                xulytextbox(true);
                dgvKhachHang.DataSource = bkh.KH_Select();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa khách hàng này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool HL = false;
                bkh.khachang_Xoa(ID, HL);
                dgvKhachHang.DataSource = bkh.KH_Select();
            }    
           
        }

      

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = bkh.KH_Select();
            xulytextbox(true);
            
        }

        int ID;
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int vt = dgvKhachHang.CurrentCell.RowIndex;
                hienthi_textbox(vt);
                ID = Int32.Parse(dgvKhachHang.Rows[vt].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                
            }
        }

        private void txtTim_TextChangeEvent(object sender, EventArgs e)
        {
            bkh.HienThiDanhSach(txtTim.TextValue, dgvKhachHang);
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }

        private void txtQT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true && char.IsControl(e.KeyChar) == false)
                e.Handled = true;
        }
    }
}
