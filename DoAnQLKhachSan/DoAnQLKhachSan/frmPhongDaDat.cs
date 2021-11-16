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
    public partial class frmPhongDaDat : Form
    {
        private int IDNV;
        public frmPhongDaDat()
        {
            InitializeComponent();
        }
        public frmPhongDaDat(int IDNV)
        {
            this.IDNV = IDNV;
            InitializeComponent();
        }

        BUSPhongDaDat bPDD = new BUSPhongDaDat();
        BUSHoaDon bHD = new BUSHoaDon();
        BUSPhieuDatPhong bPhieuDP = new BUSPhieuDatPhong();
        BUSPhong bPhong = new BUSPhong();
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
            txtSDT.Text = "";
            
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

                txtSDT.Text = dgvPhongDaDat.Rows[numrow].Cells[3].Value.ToString();
                cboTenKH.Text = dgvPhongDaDat.Rows[numrow].Cells[2].Value.ToString();
                cboMaPhong.Text = dgvPhongDaDat.Rows[numrow].Cells[7].Value.ToString();
                dtpNgayDen.Text = dgvPhongDaDat.Rows[numrow].Cells[9].Value.ToString();
                dtpNgayDi.Text = dgvPhongDaDat.Rows[numrow].Cells[10].Value.ToString();
            }
            catch (Exception ex)
            {

            }

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (flag == false)
            {
                clear_textbox();
                txtSDT.ReadOnly = false;
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
                    //int numrow = dgvPhongDaDat.CurrentCell.RowIndex;

                    if(dgvPhongDaDat.Rows.Count ==1)
                    {
                        if(Int32.Parse(bPDD.Phong_HienTTPhong(cboMaPhong.Text).Rows[0][1].ToString()) == 2)
                        {
                            MessageBox.Show("Phòng này đã đặt rồi");
                            return;
                        }    
                    } 
                        
                       
                       
                   else if (dgvPhongDaDat.Rows.Count > 0)
                    {
                        //if (cboMaPhong.Text == MaPhong)
                        //{

                        //}
                        //else
                        {
                            for (int i = 0; i < dgvPhongDaDat.Rows.Count - 1; i++)
                            {
                                if (cboMaPhong.Text == dgvPhongDaDat.Rows[i].Cells[8].Value.ToString())
                                {

                                    string ngden = dgvPhongDaDat.Rows[i].Cells[10].Value.ToString();
                                    int ngayden = Int32.Parse(string.Format("{0:dd}", Convert.ToDateTime(ngden)));
                                    int thangden = Int32.Parse(string.Format("{0:MM}", Convert.ToDateTime(ngden)));
                                    int namden = Int32.Parse(string.Format("{0:yyyy}", Convert.ToDateTime(ngden)));

                                    string ngdi = dgvPhongDaDat.Rows[i].Cells[11].Value.ToString();
                                    int ngaydi = Int32.Parse(string.Format("{0:dd}", Convert.ToDateTime(ngdi)));
                                    int thangdi = Int32.Parse(string.Format("{0:MM}", Convert.ToDateTime(ngdi)));
                                    int namdi = Int32.Parse(string.Format("{0:yyyy}", Convert.ToDateTime(ngdi)));

                                    if (KTNgayDen(ngayden, thangden, namden, dtpNgayDen.Value.Day, dtpNgayDen.Value.Month, dtpNgayDen.Value.Year) == true)
                                    {
                                        
                                        if (KTNgayDen(ngayden, thangden, namden, dtpNgayDi.Value.Day, dtpNgayDi.Value.Month, dtpNgayDi.Value.Year) == false )
                                        {
                                            MessageBox.Show("Phòng này đã đặt rồi ");
                                            return;
                                        }    
                                        
                                    }
                                    else if (KTNgayDi(ngaydi, thangdi, namdi, dtpNgayDen.Value.Day, dtpNgayDen.Value.Month, dtpNgayDen.Value.Year) == true)
                                    {
                                        
                                        if (KTNgayDi(ngaydi, thangdi, namdi, dtpNgayDi.Value.Day, dtpNgayDi.Value.Month, dtpNgayDi.Value.Year) == false )
                                        {
                                            MessageBox.Show("Phòng này đã đặt rồi ");
                                            return;
                                        }
                                    }    
                                    else if(KTNgayDen(ngayden, thangden, namden, dtpNgayDen.Value.Day, dtpNgayDen.Value.Month, dtpNgayDen.Value.Year) == false)
                                    {
                                        if (KTNgayDen(ngayden, thangden, namden, dtpNgayDi.Value.Day, dtpNgayDi.Value.Month, dtpNgayDi.Value.Year) == false)
                                        {
                                            MessageBox.Show("Phòng này đã đặt rồi ");
                                            return;
                                        }

                                    }    
                                    

                                }
                            }
                        }
                    }
                    
                    string TangID = (bPDD.PhongDaDat_Select().Rows.Count + 1).ToString();
                    xulychucnang(true);
                    bPDD.PhongDaDat_Them( cboTenKH.SelectedValue.ToString(), cboMaPhong.SelectedValue.ToString(), Convert.ToDateTime(dtpNgayDen.Text).ToString("yyyy-MM-dd"), Convert.ToDateTime(dtpNgayDi.Text).ToString("yyyy-MM-dd"));
                    bPhong.phong_CNConTrong(Int32.Parse(cboMaPhong.SelectedValue.ToString()), 2);
                    MessageBox.Show("Thêm thành công ");
                    flag = false;
                    txtSDT.ReadOnly = true;
                    dgvPhongDaDat.DataSource = bPDD.PhongDaDat_Select();
                    dgvDSPhong.Columns.Clear();
                    
                }
            }


        }


        public bool KTNgayDen(int ngay, int thang, int nam, int ngay1, int thang1, int nam1)
        {
            if (thang1 == thang && nam1 == nam && ngay > ngay1)
            {
                //MessageBox.Show("KT Đúng Ngay đi  vs ngay đến trong data");
                return true;
            }
            //else if (dtpNgayDi.Value.Month < thang && dtpNgayDi.Value.Year == nam)
            //{
            //    return true;
            //}
            else
            {
                //MessageBox.Show("KT Sai Ngay đi  vs ngay đến trong data");
                return false;
            }    
               
        }

        public bool KTNgayDi(int ngay, int thang, int nam ,int ngay1,int thang1,int nam1)
        {
            if (thang1 == thang && nam1 == nam && ngay < ngay1)
            {
                //MessageBox.Show("KT Đúng Ngay đến  vs ngay đi trong data");
                return true;
            }
            //else if (dtpNgayDen.Value.Month > thang && dtpNgayDen.Value.Year == nam)
            //{
            //    return true;
            //}
            else
            {
                //MessageBox.Show("KT Sai Ngay đến  vs ngay đi trong data");
                return false;
            }    
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa phiếu đặt phòng này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool HL = false;
                int dem = 0;
                bPDD.PhongDaDat_Xoa(ID.ToString());
                for (int i = 0; i < dgvPhongDaDat.Rows.Count - 1; i++)
                {
                    if(cboMaPhong.Text== dgvPhongDaDat.Rows[i].Cells[8].Value.ToString())
                    {
                        dem++;
                    }    
                } 
                if(dem==1)
                {
                    bPhong.phong_CNConTrong(ID_Phong, 0);
                }    
                    
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
                    bPDD.PhongDaDat_CapNhat(ID.ToString(), cboTenKH.SelectedValue.ToString(), cboMaPhong.SelectedValue.ToString(), Convert.ToDateTime(dtpNgayDen.Text).ToString("yyyy-MM-dd"), Convert.ToDateTime(dtpNgayDi.Text).ToString("yyyy-MM-dd"));
                    bPhong.phong_CNConTrong(ID_Phong, 0);
                    bPhong.phong_CNConTrong(Int32.Parse(cboMaPhong.SelectedValue.ToString()), 2);
                    MessageBox.Show("Sữa thành công ");
                    flag = false;
                    dgvPhongDaDat.DataSource = bPDD.PhongDaDat_Select();
                }
            }
        }


        int ID,IDPHONG,ID_PhieuDat,ID_Phong;
        string TenKH, SDT, HTT, GTN, GTG, ID_KH, SoPhong, NgayDen, NgayDi,MaPhong;

        private void dgvDSPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vt = dgvDSPhong.CurrentCell.RowIndex;
            HienThiDS(vt);
        }

        //private void cboMaPhong_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if(e.KeyCode==Keys.Enter)
        //    {
        //       txtTenLP.Text= bPDD.Phong_HienTMaPhong(cboMaPhong.Text).Rows[0][1].ToString();
        //        txtSoKhach.Text= bPDD.Phong_HienTMaPhong(cboMaPhong.Text).Rows[0][3].ToString();
        //        txtTenLP.Text= bPDD.Phong_HienTMaPhong(cboMaPhong.Text).Rows[0][3].ToString();
        //    }    
        //}

        public void HienThiDS(int vt)
        {
            try
            {
                cboMaPhong.Text = dgvDSPhong.Rows[vt].Cells[0].Value.ToString();
            }
            catch(Exception ex)
            {

            }
        }

        private void txtSDT_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if(bPDD.PhongDaDat_HTTenKH(txtSDT.Text).Rows.Count==0)
                {
                    MessageBox.Show("Thông tin khách hàng chưa có");
                }    
                else
                {
                    cboTenKH.Text = bPDD.PhongDaDat_HTTenKH(txtSDT.Text).Rows[0][0].ToString();
                    dtpNgayDen.Text = bPDD.PhongDaDat_HTTenKH(txtSDT.Text).Rows[0][1].ToString();
                    dtpNgayDi.Text = bPDD.PhongDaDat_HTTenKH(txtSDT.Text).Rows[0][2].ToString();
                    rtxtGhiChu.Text = bPDD.PhongDaDat_HTTenKH(txtSDT.Text).Rows[0][3].ToString();
                }    
               
            }    
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if(radioPhongCD.Checked==true)
            {
                if (cboGocNhin.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
                }
                else
                {
                    bool BonTam1;
                    if (chkBonTam.Checked == true)
                    {
                        BonTam1 = true;
                    }
                    else
                    {
                        BonTam1 = false;
                    }
                    dgvDSPhong.Columns.Clear();
                    dgvDSPhong.DataSource = bPDD.PhongDaDat_TimDSPhongCD(cboGocNhin.SelectedIndex, BonTam1);
                }


            }
            else if(radioPhongDDT.Checked==true)
            {
                if (dtpNgayBD.Text == "" || dtpNgayKT.Text == "" || cboGocNhin.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
                }
                else
                {
                    bool BonTam;
                    if (chkBonTam.Checked == true)
                    {
                        BonTam = true;
                    }
                    else
                    {
                        BonTam = false;
                    }

                    dgvDSPhong.Columns.Clear();
                    dgvDSPhong.DataSource = bPDD.PhongDaDat_TimDSPhongDD(Convert.ToDateTime(dtpNgayBD.Text).ToString("yyyy-MM-dd"), Convert.ToDateTime(dtpNgayKT.Text).ToString("yyyy-MM-dd"), cboGocNhin.SelectedIndex, BonTam);
                }    
           
            }
        }

      

        private void dgvPhongDaDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int vt = dgvPhongDaDat.CurrentCell.RowIndex;
                hienthi_textbox(vt);
                ID = Int32.Parse(dgvPhongDaDat.Rows[vt].Cells[0].Value.ToString());
                ID_PhieuDat = Int32.Parse(dgvPhongDaDat.Rows[vt].Cells[1].Value.ToString());
                TenKH = dgvPhongDaDat.Rows[vt].Cells[2].Value.ToString();
                SDT = dgvPhongDaDat.Rows[vt].Cells[3].Value.ToString();
               
                GTN = dgvPhongDaDat.Rows[vt].Cells[5].Value.ToString();
                ID_KH = dgvPhongDaDat.Rows[vt].Cells[6].Value.ToString();
                ID_Phong= Int32.Parse(dgvPhongDaDat.Rows[vt].Cells[11].Value.ToString());
                MaPhong = dgvPhongDaDat.Rows[vt].Cells[7].Value.ToString();
                HTT = dgvPhongDaDat.Rows[vt].Cells[4].Value.ToString();
                SoPhong = dgvPhongDaDat.Rows[vt].Cells[7].Value.ToString();
                NgayDen = dgvPhongDaDat.Rows[vt].Cells[9].Value.ToString();
                NgayDi = dgvPhongDaDat.Rows[vt].Cells[10].Value.ToString();
            }
            catch (Exception ex)
            {
                
            }
        }

        private void frmPhongDaDat_Load(object sender, EventArgs e)
        {

            txtSDT.ReadOnly = true;
            txtSoKhach.ReadOnly = true;
            rtxtGhiChu.ReadOnly = true;
            xulychucnang(true);
            bPDD.HienThiSDT(cboTenKH);
            //bPDD.HienThiID_PDD(cboID_PDP, dtpNgayDen, dtpNgayDi);
            bPDD.HienThiMaPhong(cboMaPhong,txtSoKhach,txtTenLP);
            dgvPhongDaDat.DataSource = bPDD.PhongDaDat_Select();
            dgvPhongDaDat.ReadOnly = true;
            dgvDSPhong.ReadOnly = true;
            dtpNgayBD.Text = DateTime.Now.ToString();
            dtpNgayKT.Text = DateTime.Now.ToString();
        }

        private void txtTim_TextChangeEvent(object sender, EventArgs e)
        {
            bPDD.HienThiDanhSach(txtTim.TextValue, dgvPhongDaDat);
        }

        string PhatSinhMaTuDong()
        {
            string MaHD;
            int dem = bHD.HoaDon_PhatSinhMa().Rows.Count + 1;
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
        int TienPhong, TongTienPhong,GioThue,HinhTT;
        string TangMaHD;
      
       
        


        private void btnXacNhanDatPhong_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Đồng ý xác nhận đặt phòng?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                TangMaHD = PhatSinhMaTuDong();
                //for (int i = 0; i < dgvPhongDaDat.Rows.Count - 1; i++)
                //{

                    //if (ID_KH == dgvPhongDaDat.Rows[i].Cells[7].Value.ToString())
                    //{

                        //int IDD = Int32.Parse(dgvPhongDaDat.Rows[i].Cells[0].Value.ToString());
                        //HTT = dgvPhongDaDat.Rows[i].Cells[4].Value.ToString();
                        //SoPhong = dgvPhongDaDat.Rows[i].Cells[8].Value.ToString();
                        //NgayDen = dgvPhongDaDat.Rows[i].Cells[10].Value.ToString();
                        //NgayDi = dgvPhongDaDat.Rows[i].Cells[11].Value.ToString();
                        //IDPHONG = Int32.Parse(dgvPhongDaDat.Rows[i].Cells[12].Value.ToString());
                        if (HTT == "False")
                        {
                            HinhTT = 0;
                            TienPhong = Int32.Parse(bHD.TienPhong(Int32.Parse(SoPhong)).Rows[0][0].ToString());
                            TongTienPhong = TienPhong * ((ThoiGianThue(NgayDen,NgayDi,GioThue) / 24));
                        }
                       

                        int TangID = bHD.HoaDon_Select().Rows.Count + 1;
                        
                        bHD.HoaDon_Them(TangID, TangMaHD, IDNV.ToString(), ID_KH, ID_Phong.ToString(), Convert.ToDateTime(DateTime.Now).ToString("yyyy/MM/dd hh:mm"), Convert.ToDateTime(NgayDen).ToString("yyyy/MM/dd hh:mm"), Convert.ToDateTime(NgayDi).ToString("yyyy/MM/dd hh:mm"), true, TongTienPhong, "0", TongTienPhong, "Không", false, true);
                        bPhong.phong_CNConTrong(IDPHONG, 1);
                        bPDD.PhongDaDat_Xoa(ID.ToString());
                    //}

                //}

                MessageBox.Show("Xác nhận hoàn tất");
                bPhieuDP.phieudatphong_XuLy(ID_PhieuDat, true);
                dgvPhongDaDat.DataSource = bPDD.PhongDaDat_Select();

            }

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
        private int ThoiGianThue(string NgayDen,string NgayDi,int iGio)
        {
            
            if (Int32.Parse(string.Format("{0:MM}", Convert.ToDateTime(NgayDen))) == Int32.Parse(string.Format("{0:MM}", Convert.ToDateTime(NgayDi))) && Int32.Parse(string.Format("{0:yyyy}", Convert.ToDateTime(NgayDen))) == Int32.Parse(string.Format("{0:yyyy}", Convert.ToDateTime(NgayDi))))
            {
                iGio = (Int32.Parse(string.Format("{0:dd}", Convert.ToDateTime(NgayDi))) - Int32.Parse(string.Format("{0:dd}", Convert.ToDateTime(NgayDen)))) * 24;
            }
            else if (Int32.Parse(string.Format("{0:MM}", Convert.ToDateTime(NgayDi))) > Int32.Parse(string.Format("{0:MM}", Convert.ToDateTime(NgayDen))) && Int32.Parse(string.Format("{0:yyyy}", Convert.ToDateTime(NgayDen))) == Int32.Parse(string.Format("{0:yyyy}", Convert.ToDateTime(NgayDi))))
            {
                iGio = ((KTThang(Int32.Parse(string.Format("{0:MM}", Convert.ToDateTime(NgayDen))), Int32.Parse(string.Format("{0:yyyy}", Convert.ToDateTime(NgayDen)))) - Int32.Parse(string.Format("{0:dd}", Convert.ToDateTime(NgayDen)))) + Int32.Parse(string.Format("{0:dd}", Convert.ToDateTime(NgayDi)))) * 24;
            }

            return iGio;
        }

    }
}
