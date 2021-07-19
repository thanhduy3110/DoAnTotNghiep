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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }
        BUSThongKe bTK = new BUSThongKe();
        private void frmThongKe_Load(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (radioNgay.Checked == true)
            {
               
                try
                {
                    if (dtpNgayBatDau.Value.Month > dtpNgayKetThuc.Value.Month|| dtpNgayBatDau.Value.Year > dtpNgayKetThuc.Value.Year)
                    {
                        MessageBox.Show("Ngày không hợp lệ");
                    }

                    else
                    {
                        dgvThongKe.Columns.Clear();
                        DataSet d = new DataSet();
                        d = bTK.ThongKeTheoNgay(dtpNgayBatDau.Text, dtpNgayKetThuc.Text);
                        string tien = d.Tables[0].Rows[0][0].ToString();
                        dgvThongKe.Columns.Add("colum1", "Ngày bắt đầu");
                        dgvThongKe.Columns[0].Width = 200;
                        dgvThongKe.Columns.Add("colum2", "Ngày ngày kết thúc");
                        dgvThongKe.Columns[1].Width = 200;
                        dgvThongKe.Columns.Add("colum2", "Tổng tiền");
                        dgvThongKe.Columns[2].Width = 200;
                        object[] t = { dtpNgayBatDau.Value.Day, dtpNgayKetThuc.Value.Day, tien };
                        dgvThongKe.Rows.Add(t);

                    }


                }
                catch(Exception ex)
                {
                    
                }
                
            }
            else if (radioThang.Checked == true)
            {
                try
                {
                    if (dtpNgayBatDau.Value.Month > dtpNgayKetThuc.Value.Month || dtpNgayBatDau.Value.Year > dtpNgayKetThuc.Value.Year)
                    {
                        MessageBox.Show("Ngày không hợp lệ");
                    }

                    else
                    {
                        dgvThongKe.Columns.Clear();
                        DataSet d = new DataSet();
                        d = bTK.ThongKeTheoNgay(dtpNgayBatDau.Text, dtpNgayKetThuc.Text);
                        string tien = d.Tables[0].Rows[0][0].ToString();
                        dgvThongKe.Columns.Add("colum1", "Tháng bắt đầu");
                        dgvThongKe.Columns[0].Width = 200;
                        dgvThongKe.Columns.Add("colum2", "Tháng kết thúc");
                        dgvThongKe.Columns[1].Width = 200;
                        dgvThongKe.Columns.Add("colum2", "Tổng tiền");
                        dgvThongKe.Columns[2].Width = 200;
                        object[] t = { dtpNgayBatDau.Value.Month, dtpNgayKetThuc.Value.Month, tien };
                        dgvThongKe.Rows.Add(t);

                    }


                }
                catch (Exception ex)
                {
                    
                }
            }
            else
            {
                try
                {
                    if (dtpNgayBatDau.Value.Month > dtpNgayKetThuc.Value.Month || dtpNgayBatDau.Value.Year > dtpNgayKetThuc.Value.Year)
                    {
                        MessageBox.Show("Ngày không hợp lệ");
                    }

                    else
                    {
                        dgvThongKe.Columns.Clear();
                        DataSet d = new DataSet();
                        d = bTK.ThongKeTheoNgay(dtpNgayBatDau.Text, dtpNgayKetThuc.Text);
                        string tien = d.Tables[0].Rows[0][0].ToString();
                        dgvThongKe.Columns.Add("colum1", "Năm bắt đầu");
                        dgvThongKe.Columns[0].Width = 200;
                        dgvThongKe.Columns.Add("colum2", "Năm kết thúc");
                        dgvThongKe.Columns[1].Width = 200;
                        dgvThongKe.Columns.Add("colum2", "Tổng tiền");
                        dgvThongKe.Columns[2].Width = 200;
                        object[] t = { dtpNgayBatDau.Value.Day, dtpNgayKetThuc.Value.Day, tien };
                        dgvThongKe.Rows.Add(t);

                    }


                }
                catch (Exception ex)
                {
                    
                }
            }    
                
        }

        private void btnThongKeDV_Click(object sender, EventArgs e)
        {
            if(radioDVBanChay.Checked==true)
            {
                dgvThongKe.Columns.Clear();
                DataSet data = new DataSet();
                data = bTK.ThongKeDV(dtpDVNgayBD.Text, dtpDVNgayKT.Text);
                dgvThongKe.DataSource = data.Tables[0];
                dgvThongKe.Columns[0].Width = 200;
                dgvThongKe.Columns[1].Width = 200;
                dgvThongKe.Columns[2].Width = 200;
                dgvThongKe.Columns[3].Width = 200;
            } 
            else if(radioSLTonKho.Checked==true)
            {
                dgvThongKe.Columns.Clear();
                DataSet data = new DataSet();
                data = bTK.ThongKeSLT();
                dgvThongKe.DataSource = data.Tables[0];
                dgvThongKe.Columns[0].Width = 200;
                dgvThongKe.Columns[1].Width = 200;
                dgvThongKe.Columns[2].Width = 200;
                dgvThongKe.Columns[3].Width = 200;
            }    
        }
    }
}
