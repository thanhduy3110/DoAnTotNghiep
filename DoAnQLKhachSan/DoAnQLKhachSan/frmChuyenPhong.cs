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
    public partial class frmChuyenPhong : Form
    {
        private int iID_HD, iHinhThucThue,iTGThue,iTienDV;

        private void frmChuyenPhong_Load(object sender, EventArgs e)
        {
            dgv_Phong.DataSource = Bphong.Phong_Select();
        }


        BUSPhong Bphong = new BUSPhong();
        BUSHoaDon bHD = new BUSHoaDon();
        
        string ConTrong;
        int TTN, TTG, ID,ID_LoaiPhong;
        private void dgv_Phong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = dgv_Phong.CurrentCell.RowIndex;
            ID = Int32.Parse(dgv_Phong.Rows[vt].Cells[0].Value.ToString());
            //ID_LoaiPhong = Int32.Parse(dgv_Phong.Rows[vt].Cells[2].Value.ToString());
            TTN = Int32.Parse(dgv_Phong.Rows[vt].Cells[4].Value.ToString());
            TTG = Int32.Parse(dgv_Phong.Rows[vt].Cells[5].Value.ToString());
            ConTrong = dgv_Phong.Rows[vt].Cells[9].Value.ToString();

        }

        public frmChuyenPhong()
        {
            InitializeComponent();
        }

        public frmChuyenPhong(int ID_HD,int TGThue,int HTT,int TienDV)
        {
            this.iID_HD = ID_HD;
            this.iTGThue = TGThue;
            this.iHinhThucThue = HTT;
            this.iTienDV = TienDV;
            InitializeComponent();
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btnChuyenPhong_Click(object sender, EventArgs e)
        {



            int TienPhong, TongTien;
            if (ConTrong == "Không còn trống")
            {
                MessageBox.Show("Phòng này đã có người dử dụng");
            }
            else 
            {
                if (iHinhThucThue == 1)
                {
                    TienPhong = TTN * (iTGThue / 24);
                }
                else
                {
                    TienPhong = TTG * iTGThue;
                }
                TongTien = this.iTienDV + TienPhong;
                //MessageBox.Show("Tien " + TTN+" "+TTG);
                //Bphong.phong_CNConTrong(ID, 1);
                bHD.HoaDon_CapNhatChuyenPhong(iID_HD, ID, TienPhong, TongTien);
                MessageBox.Show("Chuyển phòng thành công");
                this.Close();

            }



        }
    }
}
