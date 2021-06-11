
namespace QLKhachSan
{
    partial class frmQLNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLNhanVien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnHome = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.Xoa = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDSLoaiNV = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cboTenLoaiNV = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.checkBoxX3 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.textBoxX5 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.checkBoxX2 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.textBoxX4 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.checkBoxX1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX3 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTimKiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLoaiNV)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnHome,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.Xoa});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4);
            this.ribbon.MaxItemId = 8;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1462, 213);
            // 
            // btnHome
            // 
            this.btnHome.Caption = "Trở về Menu";
            this.btnHome.Id = 1;
            this.btnHome.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHome.ImageOptions.SvgImage")));
            this.btnHome.Name = "btnHome";
            this.btnHome.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHome_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Tìm kiếm";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Thêm Mới";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Sữa Chữa";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem5.ImageOptions.SvgImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Lưu Trữ";
            this.barButtonItem6.Id = 6;
            this.barButtonItem6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem6.ImageOptions.SvgImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // Xoa
            // 
            this.Xoa.Caption = "Xóa";
            this.Xoa.Id = 7;
            this.Xoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Xoa.ImageOptions.SvgImage")));
            this.Xoa.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa.ItemAppearance.Disabled.Options.UseFont = true;
            this.Xoa.Name = "Xoa";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.ribbonPage1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonPage1.ImageOptions.SvgImage")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản Lý";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnHome);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup3.ItemLinks.Add(this.Xoa);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Chức Năng";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1462, 681);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDSLoaiNV);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 442);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1456, 236);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Nhân Viên";
            // 
            // dgvDSLoaiNV
            // 
            this.dgvDSLoaiNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLoaiNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSLoaiNV.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSLoaiNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSLoaiNV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDSLoaiNV.Location = new System.Drawing.Point(3, 22);
            this.dgvDSLoaiNV.Name = "dgvDSLoaiNV";
            this.dgvDSLoaiNV.RowHeadersWidth = 51;
            this.dgvDSLoaiNV.RowTemplate.Height = 24;
            this.dgvDSLoaiNV.Size = new System.Drawing.Size(1450, 211);
            this.dgvDSLoaiNV.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID Loại Nhân Viên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenLoaiNV";
            this.Column2.HeaderText = "Tên Loại Nhân Viên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "HieuLuc";
            this.Column3.HeaderText = "Hiệu Lực";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.labelX12);
            this.groupBox2.Controls.Add(this.labelX10);
            this.groupBox2.Controls.Add(this.labelX9);
            this.groupBox2.Controls.Add(this.labelX6);
            this.groupBox2.Controls.Add(this.labelX8);
            this.groupBox2.Controls.Add(this.labelX11);
            this.groupBox2.Controls.Add(this.labelX5);
            this.groupBox2.Controls.Add(this.labelX3);
            this.groupBox2.Controls.Add(this.labelX4);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.cboTenLoaiNV);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.labelX2);
            this.groupBox2.Controls.Add(this.labelX7);
            this.groupBox2.Controls.Add(this.labelX1);
            this.groupBox2.Controls.Add(this.checkBoxX3);
            this.groupBox2.Controls.Add(this.textBoxX5);
            this.groupBox2.Controls.Add(this.checkBoxX2);
            this.groupBox2.Controls.Add(this.textBoxX4);
            this.groupBox2.Controls.Add(this.checkBoxX1);
            this.groupBox2.Controls.Add(this.textBoxX1);
            this.groupBox2.Controls.Add(this.textBoxX2);
            this.groupBox2.Controls.Add(this.textBoxX3);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1456, 418);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhân viên";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(244, 249);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(239, 139);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(732, 249);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 147);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(1168, 193);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(249, 26);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // labelX12
            // 
            this.labelX12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.ForeColor = System.Drawing.Color.Black;
            this.labelX12.Location = new System.Drawing.Point(586, 296);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(95, 23);
            this.labelX12.TabIndex = 12;
            this.labelX12.Text = "Hình ảnh";
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.ForeColor = System.Drawing.Color.Black;
            this.labelX10.Location = new System.Drawing.Point(75, 131);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(121, 23);
            this.labelX10.TabIndex = 12;
            this.labelX10.Text = "Mật khẩu";
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.ForeColor = System.Drawing.Color.Black;
            this.labelX9.Location = new System.Drawing.Point(1015, 75);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(121, 23);
            this.labelX9.TabIndex = 12;
            this.labelX9.Text = "Mã nhân viên";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.ForeColor = System.Drawing.Color.Black;
            this.labelX6.Location = new System.Drawing.Point(586, 131);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(121, 23);
            this.labelX6.TabIndex = 12;
            this.labelX6.Text = "Số điện thoại";
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.ForeColor = System.Drawing.Color.Black;
            this.labelX8.Location = new System.Drawing.Point(1018, 296);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(88, 23);
            this.labelX8.TabIndex = 13;
            this.labelX8.Text = "Hiệu lực";
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.ForeColor = System.Drawing.Color.Black;
            this.labelX11.Location = new System.Drawing.Point(75, 296);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(118, 23);
            this.labelX11.TabIndex = 13;
            this.labelX11.Text = "Đia chỉ";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(75, 196);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(84, 23);
            this.labelX5.TabIndex = 13;
            this.labelX5.Text = "CMND";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(586, 75);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(125, 23);
            this.labelX3.TabIndex = 12;
            this.labelX3.Text = "Loại nhân viên";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(1015, 131);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(89, 23);
            this.labelX4.TabIndex = 14;
            this.labelX4.Text = "Email";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(1167, 293);
            this.comboBox2.MaximumSize = new System.Drawing.Size(250, 0);
            this.comboBox2.MinimumSize = new System.Drawing.Size(250, 0);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(250, 26);
            this.comboBox2.TabIndex = 11;
            // 
            // cboTenLoaiNV
            // 
            this.cboTenLoaiNV.FormattingEnabled = true;
            this.cboTenLoaiNV.Location = new System.Drawing.Point(731, 71);
            this.cboTenLoaiNV.MaximumSize = new System.Drawing.Size(250, 0);
            this.cboTenLoaiNV.MinimumSize = new System.Drawing.Size(250, 0);
            this.cboTenLoaiNV.Name = "cboTenLoaiNV";
            this.cboTenLoaiNV.Size = new System.Drawing.Size(250, 26);
            this.cboTenLoaiNV.TabIndex = 11;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(732, 193);
            this.comboBox3.MaximumSize = new System.Drawing.Size(250, 0);
            this.comboBox3.MinimumSize = new System.Drawing.Size(250, 0);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(250, 26);
            this.comboBox3.TabIndex = 11;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(1018, 196);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(144, 23);
            this.labelX2.TabIndex = 13;
            this.labelX2.Text = "Ngày sinh";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.ForeColor = System.Drawing.Color.Black;
            this.labelX7.Location = new System.Drawing.Point(586, 196);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(89, 23);
            this.labelX7.TabIndex = 14;
            this.labelX7.Text = "Giới tính";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(75, 75);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(144, 23);
            this.labelX1.TabIndex = 14;
            this.labelX1.Text = "ID Nhân viên";
            // 
            // checkBoxX3
            // 
            this.checkBoxX3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.checkBoxX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX3.Location = new System.Drawing.Point(1002, 13);
            this.checkBoxX3.Name = "checkBoxX3";
            this.checkBoxX3.Size = new System.Drawing.Size(181, 30);
            this.checkBoxX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX3.TabIndex = 10;
            this.checkBoxX3.Text = "Tìm theo CMND";
            this.checkBoxX3.TextColor = System.Drawing.Color.Black;
            // 
            // textBoxX5
            // 
            // 
            // 
            // 
            this.textBoxX5.Border.Class = "TextBoxBorder";
            this.textBoxX5.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX5.Location = new System.Drawing.Point(244, 133);
            this.textBoxX5.MaximumSize = new System.Drawing.Size(100, 26);
            this.textBoxX5.MinimumSize = new System.Drawing.Size(250, 26);
            this.textBoxX5.Name = "textBoxX5";
            this.textBoxX5.PreventEnterBeep = true;
            this.textBoxX5.Size = new System.Drawing.Size(250, 26);
            this.textBoxX5.TabIndex = 7;
            // 
            // checkBoxX2
            // 
            this.checkBoxX2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.checkBoxX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX2.Location = new System.Drawing.Point(848, 13);
            this.checkBoxX2.Name = "checkBoxX2";
            this.checkBoxX2.Size = new System.Drawing.Size(148, 30);
            this.checkBoxX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX2.TabIndex = 10;
            this.checkBoxX2.Text = "Tìm theo SĐT";
            this.checkBoxX2.TextColor = System.Drawing.Color.Black;
            // 
            // textBoxX4
            // 
            // 
            // 
            // 
            this.textBoxX4.Border.Class = "TextBoxBorder";
            this.textBoxX4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX4.Location = new System.Drawing.Point(1168, 72);
            this.textBoxX4.MaximumSize = new System.Drawing.Size(100, 26);
            this.textBoxX4.MinimumSize = new System.Drawing.Size(250, 26);
            this.textBoxX4.Name = "textBoxX4";
            this.textBoxX4.PreventEnterBeep = true;
            this.textBoxX4.Size = new System.Drawing.Size(250, 26);
            this.textBoxX4.TabIndex = 7;
            // 
            // checkBoxX1
            // 
            this.checkBoxX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.checkBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX1.Location = new System.Drawing.Point(663, 13);
            this.checkBoxX1.Name = "checkBoxX1";
            this.checkBoxX1.Size = new System.Drawing.Size(179, 30);
            this.checkBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX1.TabIndex = 10;
            this.checkBoxX1.Text = "Tìm theo họ và tên";
            this.checkBoxX1.TextColor = System.Drawing.Color.Black;
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.Location = new System.Drawing.Point(732, 133);
            this.textBoxX1.MaximumSize = new System.Drawing.Size(100, 26);
            this.textBoxX1.MinimumSize = new System.Drawing.Size(250, 26);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.Size = new System.Drawing.Size(250, 26);
            this.textBoxX1.TabIndex = 7;
            // 
            // textBoxX2
            // 
            // 
            // 
            // 
            this.textBoxX2.Border.Class = "TextBoxBorder";
            this.textBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX2.Location = new System.Drawing.Point(244, 193);
            this.textBoxX2.MaximumSize = new System.Drawing.Size(100, 26);
            this.textBoxX2.MinimumSize = new System.Drawing.Size(250, 26);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.PreventEnterBeep = true;
            this.textBoxX2.Size = new System.Drawing.Size(250, 26);
            this.textBoxX2.TabIndex = 7;
            // 
            // textBoxX3
            // 
            // 
            // 
            // 
            this.textBoxX3.Border.Class = "TextBoxBorder";
            this.textBoxX3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX3.Location = new System.Drawing.Point(1167, 131);
            this.textBoxX3.MaximumSize = new System.Drawing.Size(100, 26);
            this.textBoxX3.MinimumSize = new System.Drawing.Size(250, 26);
            this.textBoxX3.Name = "textBoxX3";
            this.textBoxX3.PreventEnterBeep = true;
            this.textBoxX3.Size = new System.Drawing.Size(250, 26);
            this.textBoxX3.TabIndex = 7;
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.Border.Class = "TextBoxBorder";
            this.txtID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtID.Location = new System.Drawing.Point(244, 72);
            this.txtID.MaximumSize = new System.Drawing.Size(100, 26);
            this.txtID.MinimumSize = new System.Drawing.Size(250, 26);
            this.txtID.Name = "txtID";
            this.txtID.PreventEnterBeep = true;
            this.txtID.Size = new System.Drawing.Size(250, 26);
            this.txtID.TabIndex = 8;
            // 
            // txtTimKiem
            // 
            // 
            // 
            // 
            this.txtTimKiem.Border.Class = "TextBoxBorder";
            this.txtTimKiem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTimKiem.Location = new System.Drawing.Point(247, 13);
            this.txtTimKiem.MaximumSize = new System.Drawing.Size(100, 30);
            this.txtTimKiem.MinimumSize = new System.Drawing.Size(400, 30);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PreventEnterBeep = true;
            this.txtTimKiem.Size = new System.Drawing.Size(400, 30);
            this.txtTimKiem.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(50, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tìm kiếm nhân viên";
            // 
            // frmQLNhanVien
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 894);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQLNhanVien";
            this.Ribbon = this.ribbon;
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.frmQLNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLoaiNV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnHome;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem Xoa;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDSLoaiNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX3;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX2;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtID;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX5;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX4;
        private System.Windows.Forms.ComboBox cboTenLoaiNV;
    }
}