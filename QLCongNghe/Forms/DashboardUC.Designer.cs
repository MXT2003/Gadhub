using DevExpress.XtraEditors;
using System.Drawing;

namespace QLCongNghe.Forms
{
    partial class DashboardUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StackedBarSeriesView stackedBarSeriesView1 = new DevExpress.XtraCharts.StackedBarSeriesView();
            this.chartBanHang = new DevExpress.XtraCharts.ChartControl();
            this.panelDonHang = new DevExpress.XtraEditors.PanelControl();
            this.lblSoDon = new DevExpress.XtraEditors.LabelControl();
            this.panelSanPham = new DevExpress.XtraEditors.PanelControl();
            this.lblSoSanPham = new DevExpress.XtraEditors.LabelControl();
            this.panelDoanhThu = new DevExpress.XtraEditors.PanelControl();
            this.lblDoanhThu = new DevExpress.XtraEditors.LabelControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dateEditNgay = new DevExpress.XtraEditors.DateEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBanHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelDonHang)).BeginInit();
            this.panelDonHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelSanPham)).BeginInit();
            this.panelSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDoanhThu)).BeginInit();
            this.panelDoanhThu.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // chartBanHang
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartBanHang.Diagram = xyDiagram1;
            this.chartBanHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chartBanHang.Location = new System.Drawing.Point(0, 176);
            this.chartBanHang.LookAndFeel.SkinName = "Money Twins";
            this.chartBanHang.LookAndFeel.UseDefaultLookAndFeel = false;
            this.chartBanHang.Name = "chartBanHang";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            series1.Name = "Series 1";
            series1.SeriesID = 0;
            stackedBarSeriesView1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Hatch;
            series1.View = stackedBarSeriesView1;
            this.chartBanHang.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartBanHang.Size = new System.Drawing.Size(722, 305);
            this.chartBanHang.TabIndex = 4;
            // 
            // panelDonHang
            // 
            this.panelDonHang.Controls.Add(this.pictureEdit1);
            this.panelDonHang.Controls.Add(this.lblSoDon);
            this.panelDonHang.Location = new System.Drawing.Point(415, 3);
            this.panelDonHang.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            this.panelDonHang.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelDonHang.Name = "panelDonHang";
            this.panelDonHang.Size = new System.Drawing.Size(200, 138);
            this.panelDonHang.TabIndex = 2;
            // 
            // lblSoDon
            // 
            this.lblSoDon.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoDon.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.lblSoDon.Appearance.Options.UseFont = true;
            this.lblSoDon.Appearance.Options.UseForeColor = true;
            this.lblSoDon.Location = new System.Drawing.Point(5, 8);
            this.lblSoDon.Name = "lblSoDon";
            this.lblSoDon.Size = new System.Drawing.Size(11, 25);
            this.lblSoDon.TabIndex = 0;
            this.lblSoDon.Text = "0";
            // 
            // panelSanPham
            // 
            this.panelSanPham.Controls.Add(this.pictureEdit3);
            this.panelSanPham.Controls.Add(this.lblSoSanPham);
            this.panelSanPham.Location = new System.Drawing.Point(209, 3);
            this.panelSanPham.LookAndFeel.SkinName = "Office 2010 Silver";
            this.panelSanPham.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelSanPham.Name = "panelSanPham";
            this.panelSanPham.Size = new System.Drawing.Size(200, 138);
            this.panelSanPham.TabIndex = 4;
            // 
            // lblSoSanPham
            // 
            this.lblSoSanPham.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoSanPham.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.lblSoSanPham.Appearance.Options.UseFont = true;
            this.lblSoSanPham.Appearance.Options.UseForeColor = true;
            this.lblSoSanPham.Location = new System.Drawing.Point(5, 8);
            this.lblSoSanPham.Name = "lblSoSanPham";
            this.lblSoSanPham.Size = new System.Drawing.Size(11, 25);
            this.lblSoSanPham.TabIndex = 1;
            this.lblSoSanPham.Text = "0";
            // 
            // panelDoanhThu
            // 
            this.panelDoanhThu.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelDoanhThu.Appearance.Options.UseBackColor = true;
            this.panelDoanhThu.Controls.Add(this.pictureEdit2);
            this.panelDoanhThu.Controls.Add(this.lblDoanhThu);
            this.panelDoanhThu.Location = new System.Drawing.Point(3, 3);
            this.panelDoanhThu.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelDoanhThu.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelDoanhThu.LookAndFeel.SkinName = "Money Twins";
            this.panelDoanhThu.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.True;
            this.panelDoanhThu.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelDoanhThu.Name = "panelDoanhThu";
            this.panelDoanhThu.Size = new System.Drawing.Size(200, 138);
            this.panelDoanhThu.TabIndex = 3;
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDoanhThu.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.lblDoanhThu.Appearance.Options.UseFont = true;
            this.lblDoanhThu.Appearance.Options.UseForeColor = true;
            this.lblDoanhThu.Location = new System.Drawing.Point(5, 8);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(11, 25);
            this.lblDoanhThu.TabIndex = 1;
            this.lblDoanhThu.Text = "0";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panelDoanhThu);
            this.flowLayoutPanel1.Controls.Add(this.panelSanPham);
            this.flowLayoutPanel1.Controls.Add(this.panelDonHang);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(49, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(618, 141);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // dateEditNgay
            // 
            this.dateEditNgay.EditValue = new System.DateTime(2025, 8, 7, 16, 50, 34, 857);
            this.dateEditNgay.Location = new System.Drawing.Point(451, 150);
            this.dateEditNgay.Name = "dateEditNgay";
            this.dateEditNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateEditNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateEditNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditNgay.Properties.LookAndFeel.SkinName = "Money Twins";
            this.dateEditNgay.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dateEditNgay.Size = new System.Drawing.Size(100, 20);
            this.dateEditNgay.TabIndex = 5;
            this.dateEditNgay.EditValueChanged += new System.EventHandler(this.dateEditNgay_EditValueChanged);
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = global::QLCongNghe.Properties.Resources.money;
            this.pictureEdit2.Location = new System.Drawing.Point(128, 83);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureEdit2.Properties.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureEdit2.Properties.LookAndFeel.SkinName = "Money Twins";
            this.pictureEdit2.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit2.Size = new System.Drawing.Size(72, 50);
            this.pictureEdit2.TabIndex = 2;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = global::QLCongNghe.Properties.Resources.shopping_cart;
            this.pictureEdit3.Location = new System.Drawing.Point(130, 83);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit3.Size = new System.Drawing.Size(70, 50);
            this.pictureEdit3.TabIndex = 2;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::QLCongNghe.Properties.Resources.bill;
            this.pictureEdit1.Location = new System.Drawing.Point(130, 83);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Size = new System.Drawing.Size(70, 50);
            this.pictureEdit1.TabIndex = 1;
            // 
            // DashboardUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.Controls.Add(this.dateEditNgay);
            this.Controls.Add(this.chartBanHang);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "DashboardUC";
            this.Size = new System.Drawing.Size(722, 481);
            this.Load += new System.EventHandler(this.DashboardUC_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBanHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelDonHang)).EndInit();
            this.panelDonHang.ResumeLayout(false);
            this.panelDonHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelSanPham)).EndInit();
            this.panelSanPham.ResumeLayout(false);
            this.panelSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDoanhThu)).EndInit();
            this.panelDoanhThu.ResumeLayout(false);
            this.panelDoanhThu.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraCharts.ChartControl chartBanHang;
        private DateEdit dateEditNgay;
        private PanelControl panelDonHang;
        private PictureEdit pictureEdit1;
        private LabelControl lblSoDon;
        private PanelControl panelSanPham;
        private PictureEdit pictureEdit3;
        private LabelControl lblSoSanPham;
        private PanelControl panelDoanhThu;
        private PictureEdit pictureEdit2;
        private LabelControl lblDoanhThu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
