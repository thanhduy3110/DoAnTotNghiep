
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
            this.radioSLDVTonKho = new System.Windows.Forms.RadioButton();
            this.radioDVPThuongDat = new System.Windows.Forms.RadioButton();
            this.radioDoanhThuHD = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSThongKe = new System.Windows.Forms.DataGridView();
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
            this.groupBox4.Location = new System.Drawing.Point(768, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(702, 782);
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
            this.chart1.Size = new System.Drawing.Size(696, 751);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Biểu đồ thống kê";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(btnThongKe);
            this.groupBox1.Controls.Add(this.radioSLDVTonKho);
            this.groupBox1.Controls.Add(this.radioDVPThuongDat);
            this.groupBox1.Controls.Add(this.radioDoanhThuHD);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 438);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            // 
            // radioSLDVTonKho
            // 
            this.radioSLDVTonKho.AutoSize = true;
            this.radioSLDVTonKho.Location = new System.Drawing.Point(36, 200);
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
            this.radioDVPThuongDat.Location = new System.Drawing.Point(36, 133);
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
            this.radioDoanhThuHD.Location = new System.Drawing.Point(36, 73);
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
            this.groupBox2.Size = new System.Drawing.Size(768, 344);
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
            this.dgvDSThongKe.RowHeadersWidth = 51;
            this.dgvDSThongKe.RowTemplate.Height = 24;
            this.dgvDSThongKe.Size = new System.Drawing.Size(762, 313);
            this.dgvDSThongKe.TabIndex = 0;
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
    }
}