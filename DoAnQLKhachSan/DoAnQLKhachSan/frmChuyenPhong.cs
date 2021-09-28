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
        private int iID_HD, iHinhThucThue, iNamDen,iThangDen,iNgayDen,iGioDen,iNamDi,iThangDi,iNgayDi,iGioDi;

        private void frmChuyenPhong_Load(object sender, EventArgs e)
        {
            dgv_Phong.DataSource = Bphong.Phong_Select();
        }


        BUSPhong Bphong = new BUSPhong();
        BUSHoaDon bHD = new BUSHoaDon();
        string ID, ID_LoaiPhong;
        private void dgv_Phong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = dgv_Phong.CurrentCell.RowIndex;
            
            ID_LoaiPhong = dgv_Phong.Rows[vt].Cells[1].Value.ToString();
           
           
        }

        public frmChuyenPhong()
        {
            InitializeComponent();
        }

        public frmChuyenPhong(int ID_HD,int HTT,int NamDen,int NamDi,int ThangDen,int ThangDi,int NgayDen,int NgayDi,int GioDen,int GioDi)
        {
            iID_HD = ID_HD;
            iHinhThucThue = HTT;

            iNamDen = NamDen;
            iThangDen = ThangDen;
            iNgayDen = NgayDen;
            iGioDen = GioDen;

            iNamDi = NamDi;
            iThangDi = ThangDi;
            iNgayDi = NgayDi;
            iGioDi = GioDi;
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
            bHD.HoaDon_CapNhatChuyenPhong(iID_HD, ID_LoaiPhong);
           
        }
    }
}
