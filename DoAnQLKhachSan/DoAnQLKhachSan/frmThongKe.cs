using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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
        BUSKhachHang bKH = new BUSKhachHang();
        BUSNhanVien bNV = new BUSNhanVien();
        private void frmThongKe_Load(object sender, EventArgs e)
        {
            LoadBieuDo();
            
            
        }

       

       

        public void LoadBieuDo()
        {
            var chart = chart1.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;

            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "{#,###}Đ";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            chart.AxisX.Minimum = 1;
            chart.AxisX.Maximum = 12;
            chart.AxisY.Minimum = 0;

            chart1.DataSource = bTK.bieudo_select();
            chart1.Series["ThongKe"].XValueMember = "Thang";
            chart1.Series["ThongKe"].YValueMembers = "TongTien";
            
            
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {



            if (radioDoanhThuHD.Checked == true)
            {
                
                dgvDSThongKe.Columns.Clear();
                bTK.ThongKeHD(dgvDSThongKe, Convert.ToDateTime(dtpNgayBD.Text).ToString("yyyy-MM-dd"), Convert.ToDateTime(dtpNgayKT.Text).ToString("yyyy-MM-dd"));
            }
            else if (radioSLDVTonKho.Checked == true)
            {
              
                dgvDSThongKe.Columns.Clear();
                dgvDSThongKe.DataSource = bTK.ThongKeSLT();
            }else if(radioDVPThuongDat.Checked==true)
            {
                dgvDSThongKe.Columns.Clear();
                bTK.ThongKeDV(dgvDSThongKe, Convert.ToDateTime(dtpNgayBD.Text).ToString("yyyy-MM-dd"), Convert.ToDateTime(dtpNgayKT.Text).ToString("yyyy-MM-dd"));
            }else if(radioPhongSuaChua.Checked==true)
            {
                dgvDSThongKe.Columns.Clear();
                dgvDSThongKe.DataSource = bTK.ThongKePhongSuaChua();
            }
            else if (radioPhongChoKhach.Checked == true)
            {
                dgvDSThongKe.Columns.Clear();
                dgvDSThongKe.DataSource = bTK.THongKePhongChoKhach();
            }
        }
    }
}
