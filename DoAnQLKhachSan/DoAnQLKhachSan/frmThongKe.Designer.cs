﻿
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioSLTonKho = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDVNgayKT = new System.Windows.Forms.DateTimePicker();
            this.radioDVBanChay = new System.Windows.Forms.RadioButton();
            this.dtpDVNgayBD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.radioNam = new System.Windows.Forms.RadioButton();
            this.radioThang = new System.Windows.Forms.RadioButton();
            this.radioNgay = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvThongKe = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnThongKeDV = new ePOSOne.btnProduct.Button_WOC();
            this.btnThongKe = new ePOSOne.btnProduct.Button_WOC();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1470, 596);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống Kê";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chart1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(613, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(854, 565);
            this.groupBox4.TabIndex = 4;
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
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "ThongKe";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(848, 534);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Biểu đồ thống kê";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThongKeDV);
            this.groupBox3.Controls.Add(this.radioSLTonKho);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dtpDVNgayKT);
            this.groupBox3.Controls.Add(this.radioDVBanChay);
            this.groupBox3.Controls.Add(this.dtpDVNgayBD);
            this.groupBox3.Controls.Add(this.btnThongKe);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dtpNgayKetThuc);
            this.groupBox3.Controls.Add(this.dtpNgayBatDau);
            this.groupBox3.Controls.Add(this.radioNam);
            this.groupBox3.Controls.Add(this.radioThang);
            this.groupBox3.Controls.Add(this.radioNgay);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(3, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(610, 565);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tổng Thu Nhập";
            // 
            // radioSLTonKho
            // 
            this.radioSLTonKho.AutoSize = true;
            this.radioSLTonKho.Location = new System.Drawing.Point(34, 425);
            this.radioSLTonKho.Name = "radioSLTonKho";
            this.radioSLTonKho.Size = new System.Drawing.Size(202, 28);
            this.radioSLTonKho.TabIndex = 6;
            this.radioSLTonKho.TabStop = true;
            this.radioSLTonKho.Text = "Số lượng tồn kho";
            this.radioSLTonKho.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Đến";
            // 
            // dtpDVNgayKT
            // 
            this.dtpDVNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDVNgayKT.Location = new System.Drawing.Point(378, 342);
            this.dtpDVNgayKT.Name = "dtpDVNgayKT";
            this.dtpDVNgayKT.Size = new System.Drawing.Size(216, 32);
            this.dtpDVNgayKT.TabIndex = 8;
            // 
            // radioDVBanChay
            // 
            this.radioDVBanChay.AutoSize = true;
            this.radioDVBanChay.Location = new System.Drawing.Point(34, 273);
            this.radioDVBanChay.Name = "radioDVBanChay";
            this.radioDVBanChay.Size = new System.Drawing.Size(205, 28);
            this.radioDVBanChay.TabIndex = 7;
            this.radioDVBanChay.TabStop = true;
            this.radioDVBanChay.Text = "Dịch vụ bán chạy";
            this.radioDVBanChay.UseVisualStyleBackColor = true;
            // 
            // dtpDVNgayBD
            // 
            this.dtpDVNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDVNgayBD.Location = new System.Drawing.Point(69, 344);
            this.dtpDVNgayBD.Name = "dtpDVNgayBD";
            this.dtpDVNgayBD.Size = new System.Drawing.Size(216, 32);
            this.dtpDVNgayBD.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Đến";
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(343, 125);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(216, 32);
            this.dtpNgayKetThuc.TabIndex = 3;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(34, 127);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(216, 32);
            this.dtpNgayBatDau.TabIndex = 3;
            // 
            // radioNam
            // 
            this.radioNam.AutoSize = true;
            this.radioNam.Location = new System.Drawing.Point(429, 54);
            this.radioNam.Name = "radioNam";
            this.radioNam.Size = new System.Drawing.Size(130, 28);
            this.radioNam.TabIndex = 2;
            this.radioNam.TabStop = true;
            this.radioNam.Text = "Theo năm";
            this.radioNam.UseVisualStyleBackColor = true;
            // 
            // radioThang
            // 
            this.radioThang.AutoSize = true;
            this.radioThang.Location = new System.Drawing.Point(220, 54);
            this.radioThang.Name = "radioThang";
            this.radioThang.Size = new System.Drawing.Size(145, 28);
            this.radioThang.TabIndex = 1;
            this.radioThang.TabStop = true;
            this.radioThang.Text = "Theo tháng";
            this.radioThang.UseVisualStyleBackColor = true;
            // 
            // radioNgay
            // 
            this.radioNgay.AutoSize = true;
            this.radioNgay.Location = new System.Drawing.Point(34, 54);
            this.radioNgay.Name = "radioNgay";
            this.radioNgay.Size = new System.Drawing.Size(136, 28);
            this.radioNgay.TabIndex = 0;
            this.radioNgay.TabStop = true;
            this.radioNgay.Text = "Theo ngày";
            this.radioNgay.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvThongKe);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 596);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(613, 186);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Thống Kê";
            // 
            // dgvThongKe
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongKe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongKe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThongKe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvThongKe.Location = new System.Drawing.Point(3, 43);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowHeadersVisible = false;
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.Size = new System.Drawing.Size(1464, 217);
            this.dgvThongKe.TabIndex = 0;
            // 
            // btnThongKeDV
            // 
            this.btnThongKeDV.BorderColor = System.Drawing.Color.Black;
            this.btnThongKeDV.ButtonColor = System.Drawing.Color.Lime;
            this.btnThongKeDV.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThongKeDV.FlatAppearance.BorderSize = 0;
            this.btnThongKeDV.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnThongKeDV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnThongKeDV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnThongKeDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKeDV.ForeColor = System.Drawing.Color.White;
            this.btnThongKeDV.Location = new System.Drawing.Point(160, 479);
            this.btnThongKeDV.Name = "btnThongKeDV";
            this.btnThongKeDV.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnThongKeDV.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnThongKeDV.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnThongKeDV.Size = new System.Drawing.Size(236, 54);
            this.btnThongKeDV.TabIndex = 5;
            this.btnThongKeDV.Text = "Thống kê dịch vụ";
            this.btnThongKeDV.TextColor = System.Drawing.Color.Black;
            this.btnThongKeDV.UseVisualStyleBackColor = true;
            this.btnThongKeDV.Click += new System.EventHandler(this.btnThongKeDV_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BorderColor = System.Drawing.Color.Black;
            this.btnThongKe.ButtonColor = System.Drawing.Color.Lime;
            this.btnThongKe.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnThongKe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnThongKe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(171, 200);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnThongKe.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnThongKe.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnThongKe.Size = new System.Drawing.Size(225, 54);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextColor = System.Drawing.Color.Black;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
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
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmThongKe";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.RadioButton radioNam;
        private System.Windows.Forms.RadioButton radioThang;
        private System.Windows.Forms.RadioButton radioNgay;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvThongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private ePOSOne.btnProduct.Button_WOC btnThongKe;
        private ePOSOne.btnProduct.Button_WOC btnThongKeDV;
        private System.Windows.Forms.RadioButton radioSLTonKho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDVNgayKT;
        private System.Windows.Forms.RadioButton radioDVBanChay;
        private System.Windows.Forms.DateTimePicker dtpDVNgayBD;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}