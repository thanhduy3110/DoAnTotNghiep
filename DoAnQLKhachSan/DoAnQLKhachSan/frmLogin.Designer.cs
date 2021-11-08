namespace DoAnQLKhachSan
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtMatKhau = new JMaterialTextbox.JMaterialTextbox();
            this.cboSDT = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtMaNV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnThoat = new ePOSOne.btnProduct.Button_WOC();
            this.btnDangNhap = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 164);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 279);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 370);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(518, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.txtMatKhau.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Font_Size = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColors = System.Drawing.Color.White;
            this.txtMatKhau.HintText = "Mật khẩu";
            this.txtMatKhau.IsPassword = true;
            this.txtMatKhau.LineBackColor = System.Drawing.Color.White;
            this.txtMatKhau.LineThickness = 3;
            this.txtMatKhau.Location = new System.Drawing.Point(121, 393);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMatKhau.MaxLength = 32767;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.OnFocusedColor = System.Drawing.Color.Black;
            this.txtMatKhau.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtMatKhau.ReadOnly = false;
            this.txtMatKhau.Size = new System.Drawing.Size(409, 36);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMatKhau.TextName = "Mật khẩu";
            // 
            // cboSDT
            // 
            this.cboSDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cboSDT.DisplayMember = "MaNV";
            this.cboSDT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSDT.ForeColor = System.Drawing.Color.White;
            this.cboSDT.FormattingEnabled = true;
            this.cboSDT.Location = new System.Drawing.Point(121, 209);
            this.cboSDT.Name = "cboSDT";
            this.cboSDT.Size = new System.Drawing.Size(409, 39);
            this.cboSDT.TabIndex = 6;
            this.cboSDT.ValueMember = "MaNV";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(16, 180);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 68);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // txtMaNV
            // 
            // 
            // 
            // 
            this.txtMaNV.Border.Class = "TextBoxBorder";
            this.txtMaNV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaNV.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(122, 303);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.PreventEnterBeep = true;
            this.txtMaNV.Size = new System.Drawing.Size(409, 35);
            this.txtMaNV.TabIndex = 158;
            // 
            // btnThoat
            // 
            this.btnThoat.BorderColor = System.Drawing.Color.Silver;
            this.btnThoat.ButtonColor = System.Drawing.Color.Red;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(329, 457);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnThoat.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnThoat.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnThoat.Size = new System.Drawing.Size(182, 49);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BorderColor = System.Drawing.Color.Silver;
            this.btnDangNhap.ButtonColor = System.Drawing.Color.Red;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(121, 457);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnDangNhap.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnDangNhap.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnDangNhap.Size = new System.Drawing.Size(182, 49);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.TextColor = System.Drawing.Color.White;
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(560, 622);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.cboSDT);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMatKhau);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ePOSOne.btnProduct.Button_WOC btnDangNhap;
        private ePOSOne.btnProduct.Button_WOC btnThoat;
        private System.Windows.Forms.PictureBox pictureBox3;
        private JMaterialTextbox.JMaterialTextbox txtMatKhau;
        private System.Windows.Forms.ComboBox cboSDT;
        private System.Windows.Forms.PictureBox pictureBox4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaNV;
    }
}