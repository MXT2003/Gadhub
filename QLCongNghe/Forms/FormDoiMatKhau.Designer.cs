namespace QLCongNghe.Forms
{
    partial class FormDoiMatKhau
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblMatKhauCu = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnDoiMatKhau = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.txtNhapLai = new DevExpress.XtraEditors.TextEdit();
            this.txtMatKhauMoi = new DevExpress.XtraEditors.TextEdit();
            this.txtMatKhauCu = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhapLai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauMoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauCu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(112, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(215, 40);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ĐỔI MẬT KHẨU";
            // 
            // lblMatKhauCu
            // 
            this.lblMatKhauCu.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMatKhauCu.Appearance.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblMatKhauCu.Appearance.Options.UseFont = true;
            this.lblMatKhauCu.Appearance.Options.UseForeColor = true;
            this.lblMatKhauCu.Location = new System.Drawing.Point(12, 74);
            this.lblMatKhauCu.Name = "lblMatKhauCu";
            this.lblMatKhauCu.Size = new System.Drawing.Size(134, 21);
            this.lblMatKhauCu.TabIndex = 1;
            this.lblMatKhauCu.Text = "Mật khẩu hiện tại";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 122);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(106, 21);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Mật khẩu mới";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 176);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(175, 21);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Nhập lại mật khẩu mới";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDoiMatKhau.Appearance.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDoiMatKhau.Appearance.Options.UseFont = true;
            this.btnDoiMatKhau.Appearance.Options.UseForeColor = true;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(91, 218);
            this.btnDoiMatKhau.LookAndFeel.SkinName = "Money Twins";
            this.btnDoiMatKhau.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(128, 37);
            this.btnDoiMatKhau.TabIndex = 7;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Appearance.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Appearance.Options.UseForeColor = true;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(257, 218);
            this.btnThoat.LookAndFeel.SkinName = "Money Twins";
            this.btnThoat.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 37);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtNhapLai
            // 
            this.txtNhapLai.Location = new System.Drawing.Point(193, 169);
            this.txtNhapLai.Name = "txtNhapLai";
            this.txtNhapLai.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapLai.Properties.Appearance.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNhapLai.Properties.Appearance.Options.UseFont = true;
            this.txtNhapLai.Properties.Appearance.Options.UseForeColor = true;
            this.txtNhapLai.Properties.PasswordChar = '*';
            this.txtNhapLai.Properties.UseSystemPasswordChar = true;
            this.txtNhapLai.Size = new System.Drawing.Size(193, 28);
            this.txtNhapLai.TabIndex = 6;
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(193, 119);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauMoi.Properties.Appearance.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMatKhauMoi.Properties.Appearance.Options.UseFont = true;
            this.txtMatKhauMoi.Properties.Appearance.Options.UseForeColor = true;
            this.txtMatKhauMoi.Properties.PasswordChar = '*';
            this.txtMatKhauMoi.Properties.UseSystemPasswordChar = true;
            this.txtMatKhauMoi.Size = new System.Drawing.Size(193, 28);
            this.txtMatKhauMoi.TabIndex = 5;
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Location = new System.Drawing.Point(193, 71);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauCu.Properties.Appearance.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMatKhauCu.Properties.Appearance.Options.UseFont = true;
            this.txtMatKhauCu.Properties.Appearance.Options.UseForeColor = true;
            this.txtMatKhauCu.Properties.PasswordChar = '*';
            this.txtMatKhauCu.Properties.UseSystemPasswordChar = true;
            this.txtMatKhauCu.Size = new System.Drawing.Size(193, 28);
            this.txtMatKhauCu.TabIndex = 4;
            // 
            // FormDoiMatKhau
            // 
            this.AcceptButton = this.btnDoiMatKhau;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(434, 262);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.txtNhapLai);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.txtMatKhauCu);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lblMatKhauCu);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDoiMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.txtNhapLai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauMoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauCu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblMatKhauCu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtMatKhauCu;
        private DevExpress.XtraEditors.TextEdit txtMatKhauMoi;
        private DevExpress.XtraEditors.TextEdit txtNhapLai;
        private DevExpress.XtraEditors.SimpleButton btnDoiMatKhau;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
    }
}