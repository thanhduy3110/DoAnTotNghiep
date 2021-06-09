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
using DTO;

namespace QLKhachSan
{
    public partial class frmQLLoaiNV : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmQLLoaiNV()
        {
            InitializeComponent();
        }

        private void btnHome_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
          
        }

        int iTong = 0;

        private void frmQLLoaiNV_Load(object sender, EventArgs e)
        {
            dgvDSLoaiNV.DataSource = BUSLoaiNV.GetAllLoaiNV();
            
        }

       


        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                int ID = iTong;
                //ID = Int32.Parse(txtID.Text);
                string TenLoaiNV = txtTenLoaiNV.Text;
                bool HieuLuc;
                if (cboHieuLuc.Text == "Còn Vị Trí")
                {
                    HieuLuc = true;
                }
                else
                {
                    HieuLuc = false;
                }

                DTOLoaiNV LoaiNV = new DTOLoaiNV(ID, TenLoaiNV, HieuLuc);
                BUSLoaiNV.InsertLoaiNV(LoaiNV);
                MessageBox.Show("Bạn đã thêm thành công");
                dgvDSLoaiNV.DataSource = BUSLoaiNV.GetAllLoaiNV();
            }catch(Exception ex)
            {
                MessageBox.Show("Thêm thất bại");
            }
            

        }
     
        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                int ID = Int32.Parse(txtID.Text);
                string TenLoaiNV = txtTenLoaiNV.Text;
                bool HieuLuc;
                if (cboHieuLuc.Text == "Còn Vị Trí")
                {
                    HieuLuc = true;
                }
                else
                {
                    HieuLuc = false;
                }

                DTOLoaiNV LoaiNV = new DTOLoaiNV(ID, TenLoaiNV, HieuLuc);
                BUSLoaiNV.UpdateLoaiNV(LoaiNV);
                MessageBox.Show("Bạn đã sữa thành công");
                dgvDSLoaiNV.DataSource = BUSLoaiNV.GetAllLoaiNV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sữa thất bại");
            }
        }

        private void dgvDSLoaiNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvDSLoaiNV.Rows[e.RowIndex];
                iTong = dgvDSLoaiNV.Rows.Count;
                txtID.Text = row.Cells[0].Value.ToString();
                txtTenLoaiNV.Text = row.Cells[1].Value.ToString();
                string t = row.Cells[2].Value.ToString();
                if (t == "False")
                {
                    cboHieuLuc.SelectedIndex = 1;
                }
                else
                {
                    cboHieuLuc.SelectedIndex = 0;
                }
            }
            catch
            {

            }
        }
    }
}