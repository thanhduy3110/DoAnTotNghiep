
namespace QLKhachSan
{
    partial class frmQLTimKiemNguoi
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.checkEdit3 = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(0, 0);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(798, 66);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Tìm kiếm";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 66);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(798, 220);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông tin tìm kiếm";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.checkEdit3);
            this.layoutControl1.Controls.Add(this.checkEdit2);
            this.layoutControl1.Controls.Add(this.checkEdit1);
            this.layoutControl1.Controls.Add(this.textEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 28);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(794, 190);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 50, 10);
            this.Root.Size = new System.Drawing.Size(794, 190);
            this.Root.TextVisible = false;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(221, 52);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.AutoHeight = false;
            this.textEdit1.Size = new System.Drawing.Size(561, 43);
            this.textEdit1.StyleController = this.layoutControl1;
            this.textEdit1.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.textEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(774, 47);
            this.layoutControlItem1.Text = "Nhập thông tin cần tìm";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(197, 21);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 114);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(774, 16);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(12, 137);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.AutoHeight = false;
            this.checkEdit1.Properties.Caption = "Tìm theo mã";
            this.checkEdit1.Size = new System.Drawing.Size(253, 25);
            this.checkEdit1.StyleController = this.layoutControl1;
            this.checkEdit1.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.checkEdit1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 85);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(257, 29);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // checkEdit2
            // 
            this.checkEdit2.Location = new System.Drawing.Point(269, 137);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit2.Properties.Appearance.Options.UseFont = true;
            this.checkEdit2.Properties.Caption = "Tìm theo tên";
            this.checkEdit2.Size = new System.Drawing.Size(270, 25);
            this.checkEdit2.StyleController = this.layoutControl1;
            this.checkEdit2.TabIndex = 6;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.checkEdit2;
            this.layoutControlItem3.Location = new System.Drawing.Point(257, 85);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(274, 29);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // checkEdit3
            // 
            this.checkEdit3.Location = new System.Drawing.Point(543, 137);
            this.checkEdit3.Name = "checkEdit3";
            this.checkEdit3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit3.Properties.Appearance.Options.UseFont = true;
            this.checkEdit3.Properties.Caption = "Tìm theo số điện thoại";
            this.checkEdit3.Size = new System.Drawing.Size(239, 25);
            this.checkEdit3.StyleController = this.layoutControl1;
            this.checkEdit3.TabIndex = 7;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.checkEdit3;
            this.layoutControlItem4.Location = new System.Drawing.Point(531, 85);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(243, 29);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 47);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(774, 38);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmQLTimKiem
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 286);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelX1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmQLTimKiem";
            this.Text = "frmQLTimKiem";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.CheckEdit checkEdit3;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}