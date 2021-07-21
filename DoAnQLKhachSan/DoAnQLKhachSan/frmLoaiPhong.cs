﻿using System;
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
    public partial class frmLoaiPhong : Form
    {
        public frmLoaiPhong()
        {
            InitializeComponent();
        }
        BUSLoaiPhong blp = new BUSLoaiPhong();

        void Tang_ID()
        {
            int count = 0;
            count = dgvDSLoaiPhong.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count <= 1)
            {
                txtID.Text = "0";
            }
            else
            {
                chuoi = Convert.ToString(dgvDSLoaiPhong.Rows[count - 2].Cells[0].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 0)));
                if (chuoi2 + 1 < 10)
                    txtID.Text = "" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 < 100)
                    txtID.Text = "" + (chuoi2 + 1).ToString();
            }
        }
        void clear_textbox()
        {
            txtTenLoaiPhong.Text = "";
            txtSoGiuongDoi.Text = "";
            txtSoGiuongDon.Text = "";
            txtSoKhach.Text = "";
        }
        void hienthi_textbox(int numrow)
        {
            txtID.Text = dgvDSLoaiPhong.Rows[numrow].Cells[0].Value.ToString();
            txtTenLoaiPhong.Text = dgvDSLoaiPhong.Rows[numrow].Cells[1].Value.ToString();
            txtSoGiuongDoi.Text = dgvDSLoaiPhong.Rows[numrow].Cells[2].Value.ToString();
            txtSoGiuongDon.Text = dgvDSLoaiPhong.Rows[numrow].Cells[3].Value.ToString();
            txtSoKhach.Text = dgvDSLoaiPhong.Rows[numrow].Cells[4].Value.ToString();
            string HL = dgvDSLoaiPhong.Rows[numrow].Cells[5].Value.ToString();
            if(HL== "Còn trống")
            {
                chkHieuLuc.Checked = true;
            }    
            else
            {
                chkHieuLuc.Checked = false;
            }    
        }
        bool flag=false;
        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
            dgvDSLoaiPhong.DataSource = blp.LP_Select();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(flag==false)
            {
                clear_textbox();
                txtID.Text = (blp.LP_Select().Rows.Count+1).ToString();
                chkHieuLuc.Checked = false;
                flag = true;
            }    
            else if (flag == true)
            {
                if (txtTenLoaiPhong.Text == "" || txtSoGiuongDoi.Text == "" || txtSoGiuongDon.Text == "" || txtSoKhach.Text == "" )
                {
                    MessageBox.Show("Lỗi");
                }
                else
                {
                    bool HieuLuc;
                    if (chkHieuLuc.Checked == true)
                    {
                        HieuLuc = true;
                    }
                    else
                    {
                        HieuLuc = false;
                    }
                    blp.LP_Them(txtID.Text, txtTenLoaiPhong.Text, txtSoGiuongDoi.Text, txtSoGiuongDon.Text, txtSoKhach.Text, HieuLuc);
                    MessageBox.Show("Thêm thành công ");
                    flag = false;
                    dgvDSLoaiPhong.DataSource = blp.LP_Select();
                }
            }
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            blp.LP_Xoa(txtID.Text);
            MessageBox.Show("Xóa thành công ");
            dgvDSLoaiPhong.DataSource = blp.LP_Select();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(flag==false)
            {
                flag = true;
            }    
            else if (flag == true)
            {
                bool HieuLuc;
                if (chkHieuLuc.Checked == true)
                {
                    HieuLuc = true;
                }
                else
                {
                    HieuLuc = false;
                }
                blp.LP_CapNhat(txtID.Text, txtTenLoaiPhong.Text, txtSoGiuongDoi.Text, txtSoGiuongDon.Text, txtSoKhach.Text, HieuLuc);
                MessageBox.Show("Sữa thành công ");
                flag = false;
                dgvDSLoaiPhong.DataSource = blp.LP_Select();
            }
        }

       

        private void dgvDSLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int vt = dgvDSLoaiPhong.CurrentCell.RowIndex;
                hienthi_textbox(vt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có dữ liệu");
            }
        }

        private void txtTim_TextChangeEvent(object sender, EventArgs e)
        {
            blp.HienThiDanhSach(txtTim.TextValue, dgvDSLoaiPhong);
        }

       
    }
}
