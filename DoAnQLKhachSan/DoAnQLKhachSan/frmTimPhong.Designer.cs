
namespace DoAnQLKhachSan
{
    partial class frmTimPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSPhong = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnXacNhan = new ePOSOne.btnProduct.Button_WOC();
            this.btnThoat = new ePOSOne.btnProduct.Button_WOC();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dtpNgayBD = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtpNgayKT = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cboGocNhin = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.chkBonTam = new System.Windows.Forms.CheckBox();
            this.btnChonPhong = new ePOSOne.btnProduct.Button_WOC();
            this.radioPhongCD = new System.Windows.Forms.RadioButton();
            this.radioPhongDD = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayKT)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSPhong);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(836, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phòng còn trống";
            // 
            // dgvDSPhong
            // 
            this.dgvDSPhong.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSPhong.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSPhong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDSPhong.HighlightSelectedColumnHeaders = false;
            this.dgvDSPhong.Location = new System.Drawing.Point(3, 28);
            this.dgvDSPhong.Name = "dgvDSPhong";
            this.dgvDSPhong.PaintEnhancedSelection = false;
            this.dgvDSPhong.RowHeadersVisible = false;
            this.dgvDSPhong.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvDSPhong.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDSPhong.RowTemplate.Height = 24;
            this.dgvDSPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSPhong.Size = new System.Drawing.Size(830, 222);
            this.dgvDSPhong.TabIndex = 20;
            this.dgvDSPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSPhong_CellClick);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXacNhan.BorderColor = System.Drawing.Color.Black;
            this.btnXacNhan.ButtonColor = System.Drawing.Color.Lime;
            this.btnXacNhan.CausesValidation = false;
            this.btnXacNhan.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnXacNhan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnXacNhan.FlatAppearance.BorderSize = 0;
            this.btnXacNhan.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnXacNhan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnXacNhan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(570, 276);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnXacNhan.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnXacNhan.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnXacNhan.Size = new System.Drawing.Size(173, 48);
            this.btnXacNhan.TabIndex = 169;
            this.btnXacNhan.Text = "Tìm phòng";
            this.btnXacNhan.TextColor = System.Drawing.Color.Black;
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThoat.BorderColor = System.Drawing.Color.Black;
            this.btnThoat.ButtonColor = System.Drawing.Color.Lime;
            this.btnThoat.CausesValidation = false;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(570, 426);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnThoat.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnThoat.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnThoat.Size = new System.Drawing.Size(173, 48);
            this.btnThoat.TabIndex = 169;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextColor = System.Drawing.Color.Black;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelX1.Location = new System.Drawing.Point(52, 276);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(144, 32);
            this.labelX1.TabIndex = 191;
            this.labelX1.Text = "Ngày bắt đầu:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelX2.Location = new System.Drawing.Point(52, 341);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(148, 32);
            this.labelX2.TabIndex = 192;
            this.labelX2.Text = "Ngày kết thúc:";
            // 
            // dtpNgayBD
            // 
            // 
            // 
            // 
            this.dtpNgayBD.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpNgayBD.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpNgayBD.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpNgayBD.ButtonDropDown.Visible = true;
            this.dtpNgayBD.IsPopupCalendarOpen = false;
            this.dtpNgayBD.Location = new System.Drawing.Point(226, 276);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtpNgayBD.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpNgayBD.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtpNgayBD.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpNgayBD.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpNgayBD.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpNgayBD.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpNgayBD.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpNgayBD.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpNgayBD.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpNgayBD.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpNgayBD.MonthCalendar.DisplayMonth = new System.DateTime(2021, 6, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dtpNgayBD.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpNgayBD.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpNgayBD.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpNgayBD.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpNgayBD.MonthCalendar.TodayButtonVisible = true;
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(233, 32);
            this.dtpNgayBD.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpNgayBD.TabIndex = 195;
            // 
            // dtpNgayKT
            // 
            // 
            // 
            // 
            this.dtpNgayKT.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpNgayKT.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpNgayKT.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpNgayKT.ButtonDropDown.Visible = true;
            this.dtpNgayKT.IsPopupCalendarOpen = false;
            this.dtpNgayKT.Location = new System.Drawing.Point(226, 341);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtpNgayKT.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpNgayKT.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtpNgayKT.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpNgayKT.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpNgayKT.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpNgayKT.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpNgayKT.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpNgayKT.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpNgayKT.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpNgayKT.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpNgayKT.MonthCalendar.DisplayMonth = new System.DateTime(2021, 6, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dtpNgayKT.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpNgayKT.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpNgayKT.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpNgayKT.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpNgayKT.MonthCalendar.TodayButtonVisible = true;
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(233, 32);
            this.dtpNgayKT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpNgayKT.TabIndex = 196;
            // 
            // cboGocNhin
            // 
            this.cboGocNhin.DisplayMember = "Text";
            this.cboGocNhin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGocNhin.FormattingEnabled = true;
            this.cboGocNhin.ItemHeight = 27;
            this.cboGocNhin.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3});
            this.cboGocNhin.Location = new System.Drawing.Point(226, 400);
            this.cboGocNhin.Name = "cboGocNhin";
            this.cboGocNhin.Size = new System.Drawing.Size(233, 33);
            this.cboGocNhin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboGocNhin.TabIndex = 194;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "View Hồ bơi";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "View Bãi biển";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "View Thành phố";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelX3.Location = new System.Drawing.Point(52, 400);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(104, 33);
            this.labelX3.TabIndex = 193;
            this.labelX3.Text = "Góc nhìn:";
            // 
            // chkBonTam
            // 
            this.chkBonTam.AutoSize = true;
            this.chkBonTam.ForeColor = System.Drawing.Color.Navy;
            this.chkBonTam.Location = new System.Drawing.Point(52, 457);
            this.chkBonTam.Name = "chkBonTam";
            this.chkBonTam.Size = new System.Drawing.Size(123, 28);
            this.chkBonTam.TabIndex = 197;
            this.chkBonTam.Text = "Bồn tắm:";
            this.chkBonTam.UseVisualStyleBackColor = true;
            // 
            // btnChonPhong
            // 
            this.btnChonPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChonPhong.BorderColor = System.Drawing.Color.Black;
            this.btnChonPhong.ButtonColor = System.Drawing.Color.Lime;
            this.btnChonPhong.CausesValidation = false;
            this.btnChonPhong.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnChonPhong.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnChonPhong.FlatAppearance.BorderSize = 0;
            this.btnChonPhong.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnChonPhong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnChonPhong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnChonPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonPhong.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonPhong.ForeColor = System.Drawing.Color.White;
            this.btnChonPhong.Location = new System.Drawing.Point(570, 351);
            this.btnChonPhong.Name = "btnChonPhong";
            this.btnChonPhong.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnChonPhong.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnChonPhong.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnChonPhong.Size = new System.Drawing.Size(173, 48);
            this.btnChonPhong.TabIndex = 169;
            this.btnChonPhong.Text = "Chọn phòng";
            this.btnChonPhong.TextColor = System.Drawing.Color.Black;
            this.btnChonPhong.UseVisualStyleBackColor = true;
            this.btnChonPhong.Click += new System.EventHandler(this.btnChonPhongf_Click);
            // 
            // radioPhongCD
            // 
            this.radioPhongCD.AutoSize = true;
            this.radioPhongCD.Location = new System.Drawing.Point(226, 463);
            this.radioPhongCD.Name = "radioPhongCD";
            this.radioPhongCD.Size = new System.Drawing.Size(190, 28);
            this.radioPhongCD.TabIndex = 198;
            this.radioPhongCD.TabStop = true;
            this.radioPhongCD.Text = "Phòng chưa đặt";
            this.radioPhongCD.UseVisualStyleBackColor = true;
            // 
            // radioPhongDD
            // 
            this.radioPhongDD.AutoSize = true;
            this.radioPhongDD.Location = new System.Drawing.Point(226, 508);
            this.radioPhongDD.Name = "radioPhongDD";
            this.radioPhongDD.Size = new System.Drawing.Size(165, 28);
            this.radioPhongDD.TabIndex = 198;
            this.radioPhongDD.TabStop = true;
            this.radioPhongDD.Text = "Phòng đã đặt";
            this.radioPhongDD.UseVisualStyleBackColor = true;
            // 
            // frmTimPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(836, 558);
            this.Controls.Add(this.radioPhongDD);
            this.Controls.Add(this.radioPhongCD);
            this.Controls.Add(this.chkBonTam);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.dtpNgayBD);
            this.Controls.Add(this.dtpNgayKT);
            this.Controls.Add(this.cboGocNhin);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.btnChonPhong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmTimPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTimPhong";
            this.Load += new System.EventHandler(this.frmTimPhong_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayKT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDSPhong;
        private ePOSOne.btnProduct.Button_WOC btnXacNhan;
        private ePOSOne.btnProduct.Button_WOC btnThoat;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpNgayBD;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpNgayKT;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboGocNhin;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.CheckBox chkBonTam;
        private ePOSOne.btnProduct.Button_WOC btnChonPhong;
        private System.Windows.Forms.RadioButton radioPhongCD;
        private System.Windows.Forms.RadioButton radioPhongDD;
    }
}