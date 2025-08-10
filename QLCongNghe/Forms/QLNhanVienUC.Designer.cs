namespace QLCongNghe.Forms
{
    partial class QLNhanVienUC
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.flowLayoutPanelNhanVien = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTimKiem = new DevExpress.XtraEditors.TextEdit();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(171, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(274, 37);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // flowLayoutPanelNhanVien
            // 
            this.flowLayoutPanelNhanVien.AutoScroll = true;
            this.flowLayoutPanelNhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanelNhanVien.Location = new System.Drawing.Point(0, 105);
            this.flowLayoutPanelNhanVien.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelNhanVien.Name = "flowLayoutPanelNhanVien";
            this.flowLayoutPanelNhanVien.Size = new System.Drawing.Size(592, 336);
            this.flowLayoutPanelNhanVien.TabIndex = 1;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(107, 60);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Properties.Appearance.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTimKiem.Properties.Appearance.Options.UseFont = true;
            this.txtTimKiem.Properties.Appearance.Options.UseForeColor = true;
            this.txtTimKiem.Size = new System.Drawing.Size(155, 24);
            this.txtTimKiem.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.Appearance.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTimKiem.Appearance.Options.UseFont = true;
            this.btnTimKiem.Appearance.Options.UseForeColor = true;
            this.btnTimKiem.Location = new System.Drawing.Point(268, 58);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(96, 26);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Appearance.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Appearance.Options.UseForeColor = true;
            this.btnThem.Location = new System.Drawing.Point(370, 58);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 26);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnThem);
            this.panelControl1.Controls.Add(this.txtTimKiem);
            this.panelControl1.Controls.Add(this.btnTimKiem);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.LookAndFeel.SkinName = "Money Twins";
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(592, 99);
            this.panelControl1.TabIndex = 5;
            // 
            // QLNhanVienUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.flowLayoutPanelNhanVien);
            this.Name = "QLNhanVienUC";
            this.Size = new System.Drawing.Size(592, 441);
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNhanVien;
        private DevExpress.XtraEditors.TextEdit txtTimKiem;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}
