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

namespace QLKhachSan
{
    public partial class frmDatPhong : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmDatPhong()
        {
            InitializeComponent();
        }
        private void btnPhong_Click(object sender, EventArgs e)
        {

            this.Controls.Clear();
            frmQLPhieuThue frmPT = new frmQLPhieuThue();
            frmPT.TopLevel = false;
            this.Controls.Add(frmPT);
            frmPT.Dock = DockStyle.Fill;
            frmPT.Show();
        }

        private void btnDSPhong1_ItemClick(object sender, ItemClickEventArgs e)
        {
            groupControlDSPhong.Text = "Danh sách phòng thường lầu 1";
            groupControlPT.Controls.Clear();
            groupControlPV.Controls.Clear();
            //Tạo danh sách phòng thường đơn lầu 1
            for (int i = 0; i < 5; i++)
            {
                Button btnii = new Button();
                btnii.AutoSize = false;
                btnii.Size = new System.Drawing.Size(100, 50);
                groupControlPT.Controls.Add(btnii);
                btnii.Dock = DockStyle.Left;
                btnii.Text = "Phòng Thường Đơn T1." + (i + 1);
                btnii.Click += new System.EventHandler(this.btnPhong_Click);
                btnii.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                btnii.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnii.Show();

            }

            //Tạo danh sách phòng thường đôi lầu 1
            for (int i = 0; i < 5; i++)
            {
                Button btni = new Button();
                btni.AutoSize = false;
                btni.Size = new System.Drawing.Size(100, 50);
                groupControlPV.Controls.Add(btni);
                btni.Dock = DockStyle.Left;
                btni.Text = "Phòng Thường Đôi T1." + (i + 1);
                btni.Click += new System.EventHandler(this.btnPhong_Click);
                btni.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                btni.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btni.Show();

            }

        }

        private void btnDSPhong2_ItemClick(object sender, ItemClickEventArgs e)
        {
            groupControlDSPhong.Text = "Danh sách phòng thường lầu 2";
            groupControlPT.Controls.Clear();
            groupControlPV.Controls.Clear();
            //Tạo danh sách phòng thường đơn lầu 2
            for (int i = 0; i < 5; i++)
            {
                Button btni = new Button();
                btni.AutoSize = false;
                btni.Size = new System.Drawing.Size(100, 50);
                groupControlPT.Controls.Add(btni);
                btni.Dock = DockStyle.Left;
                btni.Text = "Phòng Thường Đơn T2." + (i + 1);
                btni.Click += new System.EventHandler(this.btnPhong_Click);
                btni.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                btni.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btni.Show();

            }
            //Tạo danh sách phòng thường đôi lầu 2
            for (int i = 0; i < 5; i++)
            {
                Button btni = new Button();
                btni.AutoSize = false;
                btni.Size = new System.Drawing.Size(100, 50);
                groupControlPV.Controls.Add(btni);
                btni.Dock = DockStyle.Left;
                btni.Text = "Phòng Thường Đôi T2." + (i + 1);
                btni.Click += new System.EventHandler(this.btnPhong_Click);
                btni.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                btni.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btni.Show();

            }
        }

        private void btnDSPhong3_ItemClick(object sender, ItemClickEventArgs e)
        {
            groupControlDSPhong.Text = "Danh sách phòng thường lầu 3";
            groupControlPT.Controls.Clear();
            groupControlPV.Controls.Clear();
            //Tạo danh sách phòng thường đơn lầu 3
            for (int i = 0; i < 5; i++)
            {
                Button btni = new Button();
                btni.AutoSize = false;
                btni.Size = new System.Drawing.Size(100, 50);
                groupControlPT.Controls.Add(btni);
                btni.Dock = DockStyle.Left;
                btni.Text = "Phòng Thường Đơn T3." + (i + 1);
                btni.Click += new System.EventHandler(this.btnPhong_Click);
                btni.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                btni.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btni.Show();

            }
            //Tạo danh sách phòng thường đôi lầu 3
            for (int i = 0; i < 5; i++)
            {
                Button btni = new Button();
                btni.AutoSize = false;
                btni.Size = new System.Drawing.Size(100, 50);
                groupControlPV.Controls.Add(btni);
                btni.Dock = DockStyle.Left;
                btni.Text = "Phòng Thường Đôi T3." + (i + 1);
                btni.Click += new System.EventHandler(this.btnPhong_Click);
                btni.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                btni.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btni.Show();

            }
        }

        private void btnDSPhongV1_ItemClick(object sender, ItemClickEventArgs e)
        {
            groupControlDSPhong.Text = "Danh sách phòng vip lầu 1";
            groupControlPT.Controls.Clear();
            groupControlPV.Controls.Clear();
            //Tạo danh sách phòng đơn VIP lầu 1
            for (int i = 0; i < 5; i++)
            {
                Button btni = new Button();
                btni.AutoSize = false;
                btni.Size = new System.Drawing.Size(100, 50);
                groupControlPT.Controls.Add(btni);
                btni.Dock = DockStyle.Left;
                btni.Text = "Phòng VIP Đơn V1." + (i + 1);
                btni.Click += new System.EventHandler(this.btnPhong_Click);
                btni.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                btni.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btni.Show();

            }
            //Tạo danh sách phòng đôi VIP lầu 1
            for (int i = 0; i < 5; i++)
            {
                Button btni = new Button();
                btni.AutoSize = false;
                btni.Size = new System.Drawing.Size(100, 50);
                groupControlPV.Controls.Add(btni);
                btni.Dock = DockStyle.Left;
                btni.Text = "Phòng VIP Đôi V1." + (i + 1);
                btni.Click += new System.EventHandler(this.btnPhong_Click);
                btni.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                btni.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btni.Show();

            }
        }

        private void btnDSPhongV2_ItemClick(object sender, ItemClickEventArgs e)
        {
            groupControlDSPhong.Text = "Danh sách phòng VIP lầu 2";
            groupControlPT.Controls.Clear();
            groupControlPV.Controls.Clear();
            //Tạo danh sách phòng VIP đơn lầu 2
            for (int i = 0; i < 5; i++)
            {
                Button btni = new Button();
                btni.AutoSize = false;
                btni.Size = new System.Drawing.Size(100, 50);
                groupControlPT.Controls.Add(btni);
                btni.Dock = DockStyle.Left;
                btni.Text = "Phòng VIP Đơn V2." + (i + 1);
                btni.Click += new System.EventHandler(this.btnPhong_Click);
                btni.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                btni.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btni.Show();

            }
            //Tạo danh sách phòng VIP đôi lầu 2
            for (int i = 0; i < 5; i++)
            {
                Button btni = new Button();
                btni.AutoSize = false;
                btni.Size = new System.Drawing.Size(100, 50);
                groupControlPV.Controls.Add(btni);
                btni.Dock = DockStyle.Left;
                btni.Text = "Phòng VIP ĐÔI V2." + (i + 1);
                btni.Click += new System.EventHandler(this.btnPhong_Click);
                btni.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                btni.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btni.Show();

            }
        }

        private void btnDSPhongV3_ItemClick(object sender, ItemClickEventArgs e)
        {
            groupControlDSPhong.Text = "Danh sách phòng VIP lầu 3";
            groupControlPT.Controls.Clear();
            groupControlPV.Controls.Clear();
            //Tạo danh sách phòng vip đơn lầu 3
            for (int i = 0; i < 5; i++)
            {
                Button btni = new Button();
                btni.AutoSize = false;
                btni.Size = new System.Drawing.Size(100, 50);
                groupControlPT.Controls.Add(btni);
                btni.Dock = DockStyle.Left;
                btni.Text = "Phòng VIP Đơn V3." + (i + 1);
                btni.Click += new System.EventHandler(this.btnPhong_Click);
                btni.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                btni.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btni.Show();

            }
            //Tạo danh sách phòng VIP đôi lầu 3
            for (int i = 0; i < 5; i++)
            {
                Button btni = new Button();
                btni.AutoSize = false;
                btni.Size = new System.Drawing.Size(100, 50);
                groupControlPV.Controls.Add(btni);
                btni.Dock = DockStyle.Left;
                btni.Text = "Phòng VIP Đôi V3." + (i + 1);
                btni.Click += new System.EventHandler(this.btnPhong_Click);
                btni.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                btni.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btni.Show();

            }
        }

        private void btnHome_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Controls.Clear();
            frmMainMenu frm = new frmMainMenu();
            frm.TopLevel = false;
            this.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}