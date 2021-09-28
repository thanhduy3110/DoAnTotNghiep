namespace DoAnQLKhachSan
{
    partial class frmChuyenPhong
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
            ePOSOne.btnProduct.Button_WOC btnHuy;
            ePOSOne.btnProduct.Button_WOC btnChuyenPhong;
            this.dgv_Phong = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnHuy = new ePOSOne.btnProduct.Button_WOC();
            btnChuyenPhong = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Phong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Phong
            // 
            this.dgv_Phong.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Phong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Phong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.ghichu,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Phong.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Phong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv_Phong.HighlightSelectedColumnHeaders = false;
            this.dgv_Phong.Location = new System.Drawing.Point(12, 12);
            this.dgv_Phong.Name = "dgv_Phong";
            this.dgv_Phong.PaintEnhancedSelection = false;
            this.dgv_Phong.RowHeadersVisible = false;
            this.dgv_Phong.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgv_Phong.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Phong.RowTemplate.Height = 24;
            this.dgv_Phong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Phong.Size = new System.Drawing.Size(1433, 675);
            this.dgv_Phong.TabIndex = 68;
            this.dgv_Phong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Phong_CellClick);
            // 
            // btnHuy
            // 
            btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnHuy.BorderColor = System.Drawing.Color.Black;
            btnHuy.ButtonColor = System.Drawing.Color.Lime;
            btnHuy.CausesValidation = false;
            btnHuy.Cursor = System.Windows.Forms.Cursors.Default;
            btnHuy.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            btnHuy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            btnHuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHuy.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnHuy.ForeColor = System.Drawing.Color.White;
            btnHuy.Location = new System.Drawing.Point(812, 703);
            btnHuy.Name = "btnHuy";
            btnHuy.OnHoverBorderColor = System.Drawing.Color.Red;
            btnHuy.OnHoverButtonColor = System.Drawing.Color.Yellow;
            btnHuy.OnHoverTextColor = System.Drawing.Color.Black;
            btnHuy.Size = new System.Drawing.Size(164, 48);
            btnHuy.TabIndex = 133;
            btnHuy.Text = "HỦY";
            btnHuy.TextColor = System.Drawing.Color.Black;
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnChuyenPhong
            // 
            btnChuyenPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btnChuyenPhong.BorderColor = System.Drawing.Color.Black;
            btnChuyenPhong.ButtonColor = System.Drawing.Color.Lime;
            btnChuyenPhong.CausesValidation = false;
            btnChuyenPhong.Cursor = System.Windows.Forms.Cursors.Default;
            btnChuyenPhong.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btnChuyenPhong.FlatAppearance.BorderSize = 0;
            btnChuyenPhong.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            btnChuyenPhong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            btnChuyenPhong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            btnChuyenPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnChuyenPhong.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnChuyenPhong.ForeColor = System.Drawing.Color.White;
            btnChuyenPhong.Location = new System.Drawing.Point(982, 703);
            btnChuyenPhong.Name = "btnChuyenPhong";
            btnChuyenPhong.OnHoverBorderColor = System.Drawing.Color.Red;
            btnChuyenPhong.OnHoverButtonColor = System.Drawing.Color.Yellow;
            btnChuyenPhong.OnHoverTextColor = System.Drawing.Color.Black;
            btnChuyenPhong.Size = new System.Drawing.Size(288, 48);
            btnChuyenPhong.TabIndex = 133;
            btnChuyenPhong.Text = "THỰC HIỆN CHUYỂN PHÒNG";
            btnChuyenPhong.TextColor = System.Drawing.Color.Black;
            btnChuyenPhong.UseVisualStyleBackColor = true;
            btnChuyenPhong.Click += new System.EventHandler(this.btnChuyenPhong_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenloaiphong";
            this.Column2.HeaderText = "Tên loại phòng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 170;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "sophong";
            this.Column3.HeaderText = "Số Phòng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "tang";
            this.Column4.HeaderText = "Tầng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "giathuengay";
            this.Column5.HeaderText = "Giá thuê theo ngày";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "giathuegio";
            this.Column6.HeaderText = "Giá thuê theo giờ";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 190;
            // 
            // ghichu
            // 
            this.ghichu.HeaderText = "Ghi chú";
            this.ghichu.MinimumWidth = 6;
            this.ghichu.Name = "ghichu";
            this.ghichu.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "gocnhin";
            this.Column7.HeaderText = "Góc nhìn";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "bontam";
            this.Column8.HeaderText = "Bồn tắm";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 150;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "controng";
            this.Column9.HeaderText = "Còn trống";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "hieuluc";
            this.Column10.HeaderText = "Hiệu lực";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // frmChuyenPhong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1448, 763);
            this.Controls.Add(btnHuy);
            this.Controls.Add(btnChuyenPhong);
            this.Controls.Add(this.dgv_Phong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChuyenPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHUYỂN PHÒNG";
            this.Load += new System.EventHandler(this.frmChuyenPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Phong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.DataGridViewX dgv_Phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}