namespace QLCongNghe.Forms
{
    partial class FormChiTietSanPham
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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.picSanPham = new System.Windows.Forms.PictureBox();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.lblMoTa = new DevExpress.XtraEditors.LabelControl();
            this.lblGia = new DevExpress.XtraEditors.LabelControl();
            this.lblSoLuong = new DevExpress.XtraEditors.LabelControl();
            this.lblLoai = new DevExpress.XtraEditors.LabelControl();
            this.lblTenSP = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.Fuchsia;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.Controls.Add(this.picSanPham);
            this.panelControl2.Controls.Add(this.btnXoa);
            this.panelControl2.Controls.Add(this.btnCapNhat);
            this.panelControl2.Controls.Add(this.lblMoTa);
            this.panelControl2.Controls.Add(this.lblGia);
            this.panelControl2.Controls.Add(this.lblSoLuong);
            this.panelControl2.Controls.Add(this.lblLoai);
            this.panelControl2.Controls.Add(this.lblTenSP);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.LookAndFeel.SkinName = "Money Twins";
            this.panelControl2.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.True;
            this.panelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(712, 369);
            this.panelControl2.TabIndex = 1;
            // 
            // picSanPham
            // 
            this.picSanPham.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.picSanPham.Location = new System.Drawing.Point(415, 83);
            this.picSanPham.Name = "picSanPham";
            this.picSanPham.Size = new System.Drawing.Size(238, 259);
            this.picSanPham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSanPham.TabIndex = 8;
            this.picSanPham.TabStop = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Appearance.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Appearance.Options.UseForeColor = true;
            this.btnXoa.Location = new System.Drawing.Point(114, 314);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(232, 43);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "XÓA";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCapNhat.Appearance.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCapNhat.Appearance.Options.UseFont = true;
            this.btnCapNhat.Appearance.Options.UseForeColor = true;
            this.btnCapNhat.Location = new System.Drawing.Point(114, 249);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(232, 47);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "CẬP NHẬT";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // lblMoTa
            // 
            this.lblMoTa.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMoTa.Appearance.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblMoTa.Appearance.Options.UseFont = true;
            this.lblMoTa.Appearance.Options.UseForeColor = true;
            this.lblMoTa.Location = new System.Drawing.Point(48, 197);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(104, 21);
            this.lblMoTa.TabIndex = 5;
            this.lblMoTa.Text = "labelControl1";
            // 
            // lblGia
            // 
            this.lblGia.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGia.Appearance.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblGia.Appearance.Options.UseFont = true;
            this.lblGia.Appearance.Options.UseForeColor = true;
            this.lblGia.Location = new System.Drawing.Point(170, 72);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(104, 21);
            this.lblGia.TabIndex = 3;
            this.lblGia.Text = "labelControl1";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoLuong.Appearance.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblSoLuong.Appearance.Options.UseFont = true;
            this.lblSoLuong.Appearance.Options.UseForeColor = true;
            this.lblSoLuong.Location = new System.Drawing.Point(48, 155);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(104, 21);
            this.lblSoLuong.TabIndex = 2;
            this.lblSoLuong.Text = "labelControl1";
            // 
            // lblLoai
            // 
            this.lblLoai.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLoai.Appearance.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblLoai.Appearance.Options.UseFont = true;
            this.lblLoai.Appearance.Options.UseForeColor = true;
            this.lblLoai.Location = new System.Drawing.Point(48, 120);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(104, 21);
            this.lblLoai.TabIndex = 1;
            this.lblLoai.Text = "labelControl1";
            // 
            // lblTenSP
            // 
            this.lblTenSP.Appearance.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenSP.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.lblTenSP.Appearance.Options.UseFont = true;
            this.lblTenSP.Appearance.Options.UseForeColor = true;
            this.lblTenSP.Location = new System.Drawing.Point(170, 24);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(176, 37);
            this.lblTenSP.TabIndex = 0;
            this.lblTenSP.Text = "labelControl1";
            // 
            // FormChiTietSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(712, 369);
            this.Controls.Add(this.panelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormChiTietSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChiTietSanPham";
            this.Load += new System.EventHandler(this.FormChiTietSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl lblMoTa;
        private DevExpress.XtraEditors.LabelControl lblGia;
        private DevExpress.XtraEditors.LabelControl lblSoLuong;
        private DevExpress.XtraEditors.LabelControl lblLoai;
        private DevExpress.XtraEditors.LabelControl lblTenSP;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private System.Windows.Forms.PictureBox picSanPham;
    }
}