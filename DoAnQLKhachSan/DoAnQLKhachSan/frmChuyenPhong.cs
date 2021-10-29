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
        private int iID_HD, iHinhThucThue,iTGThue;

        private void frmChuyenPhong_Load(object sender, EventArgs e)
        {
            dgv_Phong.DataSource = Bphong.Phong_Select();
        }


        BUSPhong Bphong = new BUSPhong();
        BUSHoaDon bHD = new BUSHoaDon();
        string ID, ID_LoaiPhong;
        string TTN, TTG;
        private void dgv_Phong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = dgv_Phong.CurrentCell.RowIndex;
            
            ID_LoaiPhong = dgv_Phong.Rows[vt].Cells[1].Value.ToString();
            TTN = dgv_Phong.Rows[vt].Cells[5].Value.ToString();
            TTG = dgv_Phong.Rows[vt].Cells[6].Value.ToString();


        }

        public frmChuyenPhong()
        {
            InitializeComponent();
        }

        public frmChuyenPhong(int ID_HD,int TGThue,int HTT)
        {
            this.iID_HD = ID_HD;
            this.iTGThue = TGThue;
            this.iHinhThucThue = HTT;
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
            int TienPhong;
            if (ID_LoaiPhong != "")
            {
                if(iHinhThucThue==1)
                {
                    TienPhong =Int32.Parse(TTN) * (iTGThue / 24);
                }    
                else
                {
                    TienPhong = Int32.Parse(TTG) * iTGThue;
                }
                //MessageBox.Show("Tien " + TTN+" "+TTG);
                bHD.HoaDon_CapNhatChuyenPhong(iID_HD, ID_LoaiPhong, TienPhong);
                MessageBox.Show("Chuyển phòng thành công");
                this.Close();

            }

           

        }
    }
}
