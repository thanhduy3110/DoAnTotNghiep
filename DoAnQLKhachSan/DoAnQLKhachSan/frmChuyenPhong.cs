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
        private int iID_HD, iHinhThucThue,iTGThue,iTienDV,ID_NV,ID_KH,ID_Phong;
        private string MaHD, NgayDi,NgayDen;

        public delegate void ChuyenPhong();
        public ChuyenPhong chuyenphong;

        private void frmChuyenPhong_Load(object sender, EventArgs e)
        {
            dgv_Phong.DataSource = Bphong.phong_ChuyenPhong();
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
            TTN = Int32.Parse(dgv_Phong.Rows[vt].Cells[5].Value.ToString());
           
            ConTrong = dgv_Phong.Rows[vt].Cells[9].Value.ToString();

        }

        public frmChuyenPhong()
        {
            InitializeComponent();
        }

        public frmChuyenPhong(int ID_HD,string MaHD,int ID_NV,int ID_KH,int ID_Phong,string NgayDen, string NgayDi,int HTT,int TienDV)
        {
            this.iID_HD = ID_HD;
            this.MaHD = MaHD;
            this.ID_NV = ID_NV;
            this.ID_KH = ID_KH;
            this.ID_Phong = ID_Phong;
            this.NgayDen = NgayDen;
            this.NgayDi = NgayDi;
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

        int GioThue,GioThueCu;
        int TienPhong , TongTien, TienPhongCu, TongTienCu;
        private void btnChuyenPhong_Click(object sender, EventArgs e)
        {

        

            if (ConTrong == "Không còn trống" || ConTrong == "Đã đặt trước")
            {
                MessageBox.Show("Phòng này đã có người dử dụng");
            }
            else
            {
                if (iHinhThucThue == 1)
                {
                    TienPhong = TTN * (ThoiGianThue(GioThue) / 24);
                    
                    TienPhongCu = Int32.Parse(bHD.HoaDon_TimPhongCu(this.ID_Phong).Rows[0][1].ToString()) * (ThoiGianThueCu(GioThueCu) / 24);
                   
                }

                //else
                //{
                //    TienPhong = TTG * (ThoiGianThue(GioThue));
                //    TienPhongCu = Int32.Parse(bHD.HoaDon_TimPhongCu(this.ID_Phong).Rows[0][2].ToString()) * ThoiGianThueCu(GioThueCu);
                //}

                TongTienCu = TienPhongCu + this.iTienDV;
                //MessageBox.Show("Tien " + TTN+" "+TTG);
                //Bphong.phong_CNConTrong(ID, 1);
                bHD.HoaDon_CapNhatChuyenPhong(iID_HD, this.ID_Phong, Convert.ToDateTime(DateTime.Now).ToString("yyyy/MM/dd hh:mm"), TienPhongCu, TongTienCu);
                Bphong.phong_CNConTrong(this.ID_Phong, 0);
                int TangID = bHD.HoaDon_Select().Rows.Count + 1;
                bHD.HoaDon_Them(TangID, PhatSinhMaTuDong(), this.ID_NV.ToString(), this.ID_KH.ToString(), ID.ToString(), Convert.ToDateTime(DateTime.Now).ToString("yyyy/MM/dd hh:mm"), Convert.ToDateTime(DateTime.Now).ToString("yyyy/MM/dd hh:mm"), Convert.ToDateTime(this.NgayDi).ToString("yyyy/MM/dd hh:mm"), true, TienPhong, "0", TienPhong, "Không", false, true);
                Bphong.phong_CNConTrong(this.ID, 1);
                MessageBox.Show("Chuyển phòng thành công");
                chuyenphong();
                this.Close();
            }



        }

        string PhatSinhMaTuDong()
        {
            string MaHD = "";
            int dem = bHD.HoaDon_Select().Rows.Count + 1;
            if (dem < 10)
            {
                MaHD = "HD00" + dem.ToString();
            }
            else
            {
                MaHD = "HD0" + dem.ToString();
            }

            return MaHD;
        }

        private int ThoiGianThueCu(int iGio)
        {
            if (DateTime.Now.Month == Int32.Parse(string.Format("{0:MM}", Convert.ToDateTime(NgayDen))) && DateTime.Now.Year == Int32.Parse(string.Format("{0:yyyy}", Convert.ToDateTime(NgayDen))))
            {
                if((DateTime.Now.Day - Int32.Parse(string.Format("{0:dd}", Convert.ToDateTime(NgayDen))))==0)
                {
                    iGio = 1 * 24;
                }    
                else
                {
                    iGio = (DateTime.Now.Day - Int32.Parse(string.Format("{0:dd}", Convert.ToDateTime(NgayDen))))*24;
                }

               
               
            }
            else if (DateTime.Now.Month > Int32.Parse(string.Format("{0:MM}", Convert.ToDateTime(NgayDen)))  && DateTime.Now.Year == Int32.Parse(string.Format("{0:yyyy}", Convert.ToDateTime(NgayDen))))
            {
                iGio = ((KTThang(Int32.Parse(string.Format("{0:MM}", Convert.ToDateTime(NgayDen))), Int32.Parse(string.Format("{0:yyyy}", Convert.ToDateTime(NgayDen)))) - Int32.Parse(string.Format("{0:dd}", Convert.ToDateTime(NgayDen)))) + DateTime.Now.Day) * 24;
            }

            return iGio;
        }

        private int ThoiGianThue(int iGio)
        {
            if (DateTime.Now.Month == Int32.Parse(string.Format("{0:MM}", Convert.ToDateTime(NgayDi))) && DateTime.Now.Year == Int32.Parse(string.Format("{0:yyyy}", Convert.ToDateTime(NgayDi))))
            {
                if((Int32.Parse(string.Format("{0:dd}", Convert.ToDateTime(NgayDi))) - DateTime.Now.Day)==0)
                {
                    iGio = 1 * 24;
                }
                else
                {
                    iGio = (Int32.Parse(string.Format("{0:dd}", Convert.ToDateTime(NgayDi))) - DateTime.Now.Day) * 24;
                }    
           
                
            }
            else if (Int32.Parse(string.Format("{0:MM}", Convert.ToDateTime(NgayDi))) > DateTime.Now.Month && DateTime.Now.Year == Int32.Parse(string.Format("{0:yyyy}", Convert.ToDateTime(NgayDi))))
            {
                iGio = ((KTThang(DateTime.Now.Month, DateTime.Now.Year) - DateTime.Now.Day) + Int32.Parse(string.Format("{0:dd}", Convert.ToDateTime(NgayDi)))) * 24;
            }

            return iGio;
        }

        private int KTThang(int iThang, int iNam)
        {
            int Ngay = 0;
            if (iThang == 1 || iThang == 3 || iThang == 5 || iThang == 7 || iThang == 8 || iThang == 10 || iThang == 12)
            {
                Ngay = 31; ;
            }
            else if (iThang == 4 || iThang == 6 || iThang == 9 || iThang == 11)
            {
                Ngay = 30;
            }
            else if (iThang == 2 && iNam % 4 == 0)
            {
                Ngay = 29;
            }
            else
            {
                Ngay = 28;
            }
            return Ngay;

        }
    }
}
