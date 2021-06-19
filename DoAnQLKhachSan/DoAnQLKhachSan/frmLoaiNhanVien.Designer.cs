namespace DoAnQLKhachSan
{
    partial class frmLoaiNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnXoaTatCa = new ePOSOne.btnProduct.Button_WOC();
            this.btnXoa = new ePOSOne.btnProduct.Button_WOC();
            this.btnSua = new ePOSOne.btnProduct.Button_WOC();
            this.btnLuu = new ePOSOne.btnProduct.Button_WOC();
            this.btnThem = new ePOSOne.btnProduct.Button_WOC();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSLoaiNV = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column3 = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTim = new JTextBox.JTextBox();
            this.cboHieuLuc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtTenLoaiNV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLoaiNV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoaTatCa
            // 
            this.btnXoaTatCa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoaTatCa.BorderColor = System.Drawing.Color.Black;
            this.btnXoaTatCa.ButtonColor = System.Drawing.Color.Blue;
            this.btnXoaTatCa.CausesValidation = false;
            this.btnXoaTatCa.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnXoaTatCa.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnXoaTatCa.FlatAppearance.BorderSize = 0;
            this.btnXoaTatCa.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnXoaTatCa.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnXoaTatCa.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnXoaTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTatCa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTatCa.ForeColor = System.Drawing.Color.White;
            this.btnXoaTatCa.Location = new System.Drawing.Point(1068, 255);
            this.btnXoaTatCa.Name = "btnXoaTatCa";
            this.btnXoaTatCa.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnXoaTatCa.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnXoaTatCa.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnXoaTatCa.Size = new System.Drawing.Size(136, 48);
            this.btnXoaTatCa.TabIndex = 192;
            this.btnXoaTatCa.Text = "XÓA TẤT CẢ";
            this.btnXoaTatCa.TextColor = System.Drawing.Color.White;
            this.btnXoaTatCa.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoa.BorderColor = System.Drawing.Color.Black;
            this.btnXoa.ButtonColor = System.Drawing.Color.Blue;
            this.btnXoa.CausesValidation = false;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(707, 255);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnXoa.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnXoa.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnXoa.Size = new System.Drawing.Size(105, 48);
            this.btnXoa.TabIndex = 193;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.TextColor = System.Drawing.Color.White;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSua.BorderColor = System.Drawing.Color.Black;
            this.btnSua.ButtonColor = System.Drawing.Color.Blue;
            this.btnSua.CausesValidation = false;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnSua.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnSua.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(818, 255);
            this.btnSua.Name = "btnSua";
            this.btnSua.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnSua.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnSua.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSua.Size = new System.Drawing.Size(120, 48);
            this.btnSua.TabIndex = 194;
            this.btnSua.Text = "SỮA";
            this.btnSua.TextColor = System.Drawing.Color.White;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.ttnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLuu.BorderColor = System.Drawing.Color.Black;
            this.btnLuu.ButtonColor = System.Drawing.Color.Blue;
            this.btnLuu.CausesValidation = false;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLuu.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnLuu.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnLuu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(944, 255);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnLuu.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnLuu.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnLuu.Size = new System.Drawing.Size(118, 48);
            this.btnLuu.TabIndex = 195;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.TextColor = System.Drawing.Color.White;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThem.BorderColor = System.Drawing.Color.Black;
            this.btnThem.ButtonColor = System.Drawing.Color.Blue;
            this.btnThem.CausesValidation = false;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(575, 255);
            this.btnThem.Name = "btnThem";
            this.btnThem.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnThem.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnThem.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnThem.Size = new System.Drawing.Size(125, 48);
            this.btnThem.TabIndex = 196;
            this.btnThem.Text = "THÊM";
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSLoaiNV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 394);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1488, 466);
            this.groupBox1.TabIndex = 153;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Loại Nhân Viên";
            // 
            // dgvDSLoaiNV
            // 
            this.dgvDSLoaiNV.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSLoaiNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLoaiNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSLoaiNV.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSLoaiNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSLoaiNV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDSLoaiNV.Location = new System.Drawing.Point(3, 24);
            this.dgvDSLoaiNV.Name = "dgvDSLoaiNV";
            this.dgvDSLoaiNV.RowHeadersWidth = 51;
            this.dgvDSLoaiNV.RowTemplate.Height = 24;
            this.dgvDSLoaiNV.Size = new System.Drawing.Size(1482, 439);
            this.dgvDSLoaiNV.TabIndex = 1;
            this.dgvDSLoaiNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSLoaiNV_CellClick);
            // 
            // Column3
            // 
            this.Column3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.Column3.BackgroundStyle.Class = "DataGridViewIpAddressBorder";
            this.Column3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Column3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Column3.HeaderText = "ID";
            this.Column3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.PasswordChar = '\0';
            this.Column3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Column3.Text = "";
            this.Column3.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "TÊN LOẠI NHÂN VIÊN";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 250;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "HIỆU LỰC";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoaTatCa);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.txtTim);
            this.groupBox2.Controls.Add(this.cboHieuLuc);
            this.groupBox2.Controls.Add(this.txtTenLoaiNV);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.labelX2);
            this.groupBox2.Controls.Add(this.labelX1);
            this.groupBox2.Controls.Add(this.labelX3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1488, 394);
            this.groupBox2.TabIndex = 154;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loại Nhân Viên";
            // 
            // txtTim
            // 
            this.txtTim.AutoSize = true;
            this.txtTim.BorderColor = System.Drawing.Color.Black;
            this.txtTim.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTim.Hint = "";
            this.txtTim.IsPassword = false;
            this.txtTim.Length = 0;
            this.txtTim.Location = new System.Drawing.Point(25, 255);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTim.Name = "txtTim";
            this.txtTim.OnFocus = System.Drawing.Color.DarkGray;
            this.txtTim.OnlyChar = false;
            this.txtTim.OnlyNumber = false;
            this.txtTim.Size = new System.Drawing.Size(449, 48);
            this.txtTim.TabIndex = 191;
            this.txtTim.TextValue = "";
            // 
            // cboHieuLuc
            // 
            this.cboHieuLuc.DisplayMember = "Text";
            this.cboHieuLuc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboHieuLuc.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHieuLuc.FormattingEnabled = true;
            this.cboHieuLuc.ItemHeight = 30;
            this.cboHieuLuc.Location = new System.Drawing.Point(1154, 62);
            this.cboHieuLuc.Name = "cboHieuLuc";
            this.cboHieuLuc.Size = new System.Drawing.Size(282, 36);
            this.cboHieuLuc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboHieuLuc.TabIndex = 163;
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.Border.Class = "TextBoxBorder";
            this.txtID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtID.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(192, 63);
            this.txtID.Name = "txtID";
            this.txtID.PreventEnterBeep = true;
            this.txtID.Size = new System.Drawing.Size(282, 35);
            this.txtID.TabIndex = 157;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelX2.Location = new System.Drawing.Point(25, 67);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(146, 24);
            this.labelX2.TabIndex = 154;
            this.labelX2.Text = "ID Nhân viên:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelX1.Location = new System.Drawing.Point(1030, 67);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(146, 24);
            this.labelX1.TabIndex = 155;
            this.labelX1.Text = "Hiệu lực:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelX3.Location = new System.Drawing.Point(536, 67);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(146, 24);
            this.labelX3.TabIndex = 153;
            this.labelX3.Text = "Tên Loại NV:";
            // 
            // txtTenLoaiNV
            // 
            // 
            // 
            // 
            this.txtTenLoaiNV.Border.Class = "TextBoxBorder";
            this.txtTenLoaiNV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenLoaiNV.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiNV.Location = new System.Drawing.Point(675, 63);
            this.txtTenLoaiNV.Name = "txtTenLoaiNV";
            this.txtTenLoaiNV.PreventEnterBeep = true;
            this.txtTenLoaiNV.Size = new System.Drawing.Size(282, 35);
            this.txtTenLoaiNV.TabIndex = 157;
            // 
            // frmLoaiNhanVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1488, 860);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoaiNhanVien";
            this.Text = "LOẠI NHÂN VIÊN";
            this.Load += new System.EventHandler(this.frmLoaiNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLoaiNV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDSLoaiNV;
        private DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboHieuLuc;
        private DevComponents.DotNetBar.Controls.TextBoxX txtID;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private JTextBox.JTextBox txtTim;
        private ePOSOne.btnProduct.Button_WOC btnXoaTatCa;
        private ePOSOne.btnProduct.Button_WOC btnXoa;
        private ePOSOne.btnProduct.Button_WOC btnSua;
        private ePOSOne.btnProduct.Button_WOC btnLuu;
        private ePOSOne.btnProduct.Button_WOC btnThem;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenLoaiNV;
    }
}