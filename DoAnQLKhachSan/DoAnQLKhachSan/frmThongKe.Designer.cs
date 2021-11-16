
namespace DoAnQLKhachSan
{
    partial class frmThongKe
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
            ePOSOne.btnProduct.Button_WOC btnThongKe;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioPhongSuaChua = new System.Windows.Forms.RadioButton();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioSLDVTonKho = new System.Windows.Forms.RadioButton();
            this.radioDVPThuongDat = new System.Windows.Forms.RadioButton();
            this.radioDoanhThuHD = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSThongKe = new System.Windows.Forms.DataGridView();
            this.radioPhongChoKhach = new System.Windows.Forms.RadioButton();
            btnThongKe = new ePOSOne.btnProduct.Button_WOC();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThongKe
            // 
            btnThongKe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnThongKe.BorderColor = System.Drawing.Color.Black;
            btnThongKe.ButtonColor = System.Drawing.Color.Lime;
            btnThongKe.CausesValidation = false;
            btnThongKe.Cursor = System.Windows.Forms.Cursors.Default;
            btnThongKe.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            btnThongKe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            btnThongKe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnThongKe.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnThongKe.ForeColor = System.Drawing.Color.White;
            btnThongKe.Location = new System.Drawing.Point(36, 368);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.OnHoverBorderColor = System.Drawing.Color.Red;
            btnThongKe.OnHoverButtonColor = System.Drawing.Color.Yellow;
            btnThongKe.OnHoverTextColor = System.Drawing.Color.Black;
            btnThongKe.Size = new System.Drawing.Size(194, 48);
            btnThongKe.TabIndex = 176;
            btnThongKe.Text = "Xác nhận thống kê";
            btnThongKe.TextColor = System.Drawing.Color.Black;
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chart1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox4.Location = new System.Drawing.Point(946, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(524, 782);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Biểu Đồ";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 28);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "ThongKe";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(518, 751);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Biểu đồ thống kê";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioPhongChoKhach);
            this.groupBox1.Controls.Add(this.radioPhongSuaChua);
            this.groupBox1.Controls.Add(this.dtpNgayKT);
            this.groupBox1.Controls.Add(this.dtpNgayBD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(btnThongKe);
            this.groupBox1.Controls.Add(this.radioSLDVTonKho);
            this.groupBox1.Controls.Add(this.radioDVPThuongDat);
            this.groupBox1.Controls.Add(this.radioDoanhThuHD);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(946, 438);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            // 
            // radioPhongSuaChua
            // 
            this.radioPhongSuaChua.AutoSize = true;
            this.radioPhongSuaChua.Location = new System.Drawing.Point(509, 128);
            this.radioPhongSuaChua.Name = "radioPhongSuaChua";
            this.radioPhongSuaChua.Size = new System.Drawing.Size(194, 28);
            this.radioPhongSuaChua.TabIndex = 181;
            this.radioPhongSuaChua.TabStop = true;
            this.radioPhongSuaChua.Text = "Phòng đang sửa";
            this.radioPhongSuaChua.UseVisualStyleBackColor = true;
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKT.Location = new System.Drawing.Point(690, 51);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(200, 32);
            this.dtpNgayKT.TabIndex = 180;
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBD.Location = new System.Drawing.Point(223, 51);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(200, 32);
            this.dtpNgayBD.TabIndex = 179;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 24);
            this.label2.TabIndex = 178;
            this.label2.Text = "Ngày kết thúc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 178;
            this.label1.Text = "Ngày bắt đầu";
            // 
            // radioSLDVTonKho
            // 
            this.radioSLDVTonKho.AutoSize = true;
            this.radioSLDVTonKho.Location = new System.Drawing.Point(45, 255);
            this.radioSLDVTonKho.Name = "radioSLDVTonKho";
            this.radioSLDVTonKho.Size = new System.Drawing.Size(282, 28);
            this.radioSLDVTonKho.TabIndex = 0;
            this.radioSLDVTonKho.TabStop = true;
            this.radioSLDVTonKho.Text = "Số lượng dịch vụ tồn kho";
            this.radioSLDVTonKho.UseVisualStyleBackColor = true;
            // 
            // radioDVPThuongDat
            // 
            this.radioDVPThuongDat.AutoSize = true;
            this.radioDVPThuongDat.Location = new System.Drawing.Point(45, 188);
            this.radioDVPThuongDat.Name = "radioDVPThuongDat";
            this.radioDVPThuongDat.Size = new System.Drawing.Size(295, 28);
            this.radioDVPThuongDat.TabIndex = 0;
            this.radioDVPThuongDat.TabStop = true;
            this.radioDVPThuongDat.Text = "Dịch vụ phòng thường đặt";
            this.radioDVPThuongDat.UseVisualStyleBackColor = true;
            // 
            // radioDoanhThuHD
            // 
            this.radioDoanhThuHD.AutoSize = true;
            this.radioDoanhThuHD.Location = new System.Drawing.Point(45, 128);
            this.radioDoanhThuHD.Name = "radioDoanhThuHD";
            this.radioDoanhThuHD.Size = new System.Drawing.Size(223, 28);
            this.radioDoanhThuHD.TabIndex = 0;
            this.radioDoanhThuHD.TabStop = true;
            this.radioDoanhThuHD.Text = "Doanh thu hóa đơn";
            this.radioDoanhThuHD.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDSThongKe);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 438);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(946, 344);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách thống kê";
            // 
            // dgvDSThongKe
            // 
            this.dgvDSThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSThongKe.Location = new System.Drawing.Point(3, 28);
            this.dgvDSThongKe.Name = "dgvDSThongKe";
            this.dgvDSThongKe.RowHeadersVisible = false;
            this.dgvDSThongKe.RowHeadersWidth = 51;
            this.dgvDSThongKe.RowTemplate.Height = 24;
            this.dgvDSThongKe.Size = new System.Drawing.Size(940, 313);
            this.dgvDSThongKe.TabIndex = 0;
            // 
            // radioPhongChoKhach
            // 
            this.radioPhongChoKhach.AutoSize = true;
            this.radioPhongChoKhach.Location = new System.Drawing.Point(509, 188);
            this.radioPhongChoKhach.Name = "radioPhongChoKhach";
            this.radioPhongChoKhach.Size = new System.Drawing.Size(318, 28);
            this.radioPhongChoKhach.TabIndex = 182;
            this.radioPhongChoKhach.TabStop = true;
            this.radioPhongChoKhach.Text = "Phòng đang chờ khách nhận";
            this.radioPhongChoKhach.UseVisualStyleBackColor = true;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1470, 782);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmThongKe";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioSLDVTonKho;
        private System.Windows.Forms.RadioButton radioDVPThuongDat;
        private System.Windows.Forms.RadioButton radioDoanhThuHD;
        private System.Windows.Forms.DataGridView dgvDSThongKe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.RadioButton radioPhongSuaChua;
        private System.Windows.Forms.RadioButton radioPhongChoKhach;
    }
}