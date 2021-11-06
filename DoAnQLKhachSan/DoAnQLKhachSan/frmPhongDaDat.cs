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
    public partial class frmPhongDaDat : Form
    {
        public frmPhongDaDat()
        {
            InitializeComponent();
        }

        BUSPhongDaDat bPDD = new BUSPhongDaDat();
        bool flag=false;
        //void Tang_ID()
        //{
        //    int count = 0;
        //    count = dgvPhongDaDat.Rows.Count;
        //    string chuoi = "";
        //    int chuoi2 = 0;
        //    if (count <= 1)
        //    {
        //        txtID.Text = "0";
        //    }
        //    else
        //    {
        //        chuoi = Convert.ToString(dgvPhongDaDat.Rows[count - 2].Cells[0].Value);
        //        chuoi2 = Convert.ToInt32((chuoi.Remove(0, 0)));
        //        if (chuoi2 + 1 < 10)
        //        {
        //            txtID.Text = "" + (chuoi2 + 1).ToString();
        //        }
        //        else if (chuoi2 + 1 < 100)
        //        {
        //            txtID.Text = "" + (chuoi2 + 1).ToString();
        //        }

        //    }
        //}

        void clear_textbox()
        {
            cboMaPhong.Text = "";
            dtpNgayDen.Text = "";
            dtpNgayDi.Text = "";
        }
        void xulychucnang(Boolean t)
        {
            btnThem.Enabled = t;
            btnXoa.Enabled = t;
            btnSua.Enabled = t;

        }

        void hienthi_textbox(int numrow)
        {
            try
            {

                txtTenKH.Text = dgvPhongDaDat.Rows[numrow].Cells[2].Value.ToString();
                cboSDTKH.Text = dgvPhongDaDat.Rows[numrow].Cells[3].Value.ToString();
                cboMaPhong.Text = dgvPhongDaDat.Rows[numrow].Cells[8].Value.ToString();
                dtpNgayDen.Text = dgvPhongDaDat.Rows[numrow].Cells[9].Value.ToString();
                dtpNgayDi.Text = dgvPhongDaDat.Rows[numrow].Cells[10].Value.ToString();
            }
            catch (Exception ex)
            {

            }

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if(flag==false)
            {
                clear_textbox();
                
                flag = true;
            }    
           
            else if (flag == true)
            {

                if ( cboMaPhong.Text == "")
                {
                    MessageBox.Show("Lỗi");
                }
                else
                {
                    string TangID = (bPDD.PhongDaDat_Select().Rows.Count + 1).ToString();
                    xulychucnang(true);
                    bPDD.PhongDaDat_Them(TangID, cboSDTKH.SelectedValue.ToString(), cboMaPhong.SelectedValue.ToString(), dtpNgayDen.Text, dtpNgayDi.Text);
                    MessageBox.Show("Thêm thành công ");
                    flag = false;
                    dgvPhongDaDat.DataSource = bPDD.PhongDaDat_Select();
                }
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa phiếu đặt phòng này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool HL = false;
                bPDD.PhongDaDat_Xoa(ID.ToString());
                dgvPhongDaDat.DataSource = bPDD.PhongDaDat_Select();
            }
            }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(flag==false)
            {
                flag = true;
            }    
            else if (flag == true)
            {
                if (cboMaPhong.Text == "")
                {
                    MessageBox.Show("Lỗi");
                }
                else
                {
                    xulychucnang(true);
                    bPDD.PhongDaDat_CapNhat(ID.ToString(), cboSDTKH.SelectedValue.ToString(), cboMaPhong.SelectedValue.ToString(), dtpNgayDen.Text, dtpNgayDi.Text);
                    MessageBox.Show("Sữa thành công ");
                    flag = false;
                    dgvPhongDaDat.DataSource = bPDD.PhongDaDat_Select();
                }
            }
        }


        int ID;
        private void dgvPhongDaDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int vt = dgvPhongDaDat.CurrentCell.RowIndex;
                hienthi_textbox(vt);
                ID = Int32.Parse(dgvPhongDaDat.Rows[vt].Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                
            }
        }

        private void frmPhongDaDat_Load(object sender, EventArgs e)
        {

            txtTenKH.ReadOnly = true;
            xulychucnang(true);
            //bPDD.HienThiID_PDD(cboID_PDP, dtpNgayDen, dtpNgayDi);
            bPDD.HienThiMaPhong(cboMaPhong);
            bPDD.HienThiSDT(cboSDTKH,dtpNgayDen,dtpNgayDi,txtTenKH);
            dgvPhongDaDat.DataSource = bPDD.PhongDaDat_Select();
        }

        private void txtTim_TextChangeEvent(object sender, EventArgs e)
        {
            bPDD.HienThiDanhSach(txtTim.TextValue, dgvPhongDaDat);
        }

        private void btnXacNhanDatPhong_Click(object sender, EventArgs e)
        {

        }
    }
}
