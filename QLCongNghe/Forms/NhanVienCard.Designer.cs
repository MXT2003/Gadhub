namespace QLCongNghe.Forms
{
    partial class Card
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
            this.lblTen = new DevExpress.XtraEditors.LabelControl();
            this.lblSDT = new DevExpress.XtraEditors.LabelControl();
            this.lblDiaChi = new DevExpress.XtraEditors.LabelControl();
            this.picAnh = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTen
            // 
            this.lblTen.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTen.Appearance.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblTen.Appearance.Options.UseFont = true;
            this.lblTen.Appearance.Options.UseForeColor = true;
            this.lblTen.Location = new System.Drawing.Point(130, 22);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(83, 17);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "labelControl1";
            // 
            // lblSDT
            // 
            this.lblSDT.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSDT.Appearance.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblSDT.Appearance.Options.UseFont = true;
            this.lblSDT.Appearance.Options.UseForeColor = true;
            this.lblSDT.Location = new System.Drawing.Point(130, 57);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(83, 17);
            this.lblSDT.TabIndex = 2;
            this.lblSDT.Text = "labelControl1";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiaChi.Appearance.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblDiaChi.Appearance.Options.UseFont = true;
            this.lblDiaChi.Appearance.Options.UseForeColor = true;
            this.lblDiaChi.Location = new System.Drawing.Point(130, 91);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(83, 17);
            this.lblDiaChi.TabIndex = 3;
            this.lblDiaChi.Text = "labelControl1";
            // 
            // picAnh
            // 
            this.picAnh.Location = new System.Drawing.Point(13, 16);
            this.picAnh.Name = "picAnh";
            this.picAnh.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.picAnh.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.picAnh.Properties.Appearance.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.picAnh.Properties.Appearance.Options.UseBackColor = true;
            this.picAnh.Properties.Appearance.Options.UseFont = true;
            this.picAnh.Properties.Appearance.Options.UseForeColor = true;
            this.picAnh.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picAnh.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picAnh.Size = new System.Drawing.Size(106, 111);
            this.picAnh.TabIndex = 4;
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblTen);
            this.Name = "Card";
            this.Size = new System.Drawing.Size(320, 144);
            this.Click += new System.EventHandler(this.Card_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picAnh.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTen;
        private DevExpress.XtraEditors.LabelControl lblSDT;
        private DevExpress.XtraEditors.LabelControl lblDiaChi;
        private DevExpress.XtraEditors.PictureEdit picAnh;
    }
}
