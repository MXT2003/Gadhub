namespace QLCongNghe.Forms
{
    partial class SanPhamUC
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
            this.panelTop = new DevExpress.XtraEditors.PanelControl();
            this.cboLoaiSanPham = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.txtTimKiem = new DevExpress.XtraEditors.TextEdit();
            this.cboLoaiSP = new DevExpress.XtraEditors.ComboBoxEdit();
            this.flpDanhSach = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.panelTop)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiSP.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(300, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(145, 37);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "SẢN PHẨM";
            // 
            // panelTop
            // 
            this.panelTop.Appearance.BackColor = System.Drawing.Color.LightPink;
            this.panelTop.Appearance.Options.UseBackColor = true;
            this.panelTop.Controls.Add(this.cboLoaiSanPham);
            this.panelTop.Controls.Add(this.btnThem);
            this.panelTop.Controls.Add(this.txtTimKiem);
            this.panelTop.Controls.Add(this.labelControl1);
            this.panelTop.Controls.Add(this.cboLoaiSP);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.LookAndFeel.SkinName = "Money Twins";
            this.panelTop.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(723, 169);
            this.panelTop.TabIndex = 1;
            // 
            // cboLoaiSanPham
            // 
            this.cboLoaiSanPham.Location = new System.Drawing.Point(160, 60);
            this.cboLoaiSanPham.Name = "cboLoaiSanPham";
            this.cboLoaiSanPham.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboLoaiSanPham.Properties.Appearance.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.cboLoaiSanPham.Properties.Appearance.Options.UseFont = true;
            this.cboLoaiSanPham.Properties.Appearance.Options.UseForeColor = true;
            this.cboLoaiSanPham.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLoaiSanPham.Properties.Items.AddRange(new object[] {
            "Điện thoại",
            "Laptop",
            "Máy tính bảng",
            "Phụ kiện điện thoại",
            "Phụ kiện laptop",
            "Thiết bị mạng",
            "Thiết bị lưu trữ",
            "Màn hình – Monitor"});
            this.cboLoaiSanPham.Properties.NullText = "Loại Sản Phẩm";
            this.cboLoaiSanPham.Size = new System.Drawing.Size(100, 24);
            this.cboLoaiSanPham.TabIndex = 3;
            this.cboLoaiSanPham.SelectedIndexChanged += new System.EventHandler(this.cboLoaiSanPham_SelectedIndexChanged);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Appearance.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Appearance.Options.UseForeColor = true;
            this.btnThem.Location = new System.Drawing.Point(425, 58);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 26);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(266, 60);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Properties.Appearance.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTimKiem.Properties.Appearance.Options.UseFont = true;
            this.txtTimKiem.Properties.Appearance.Options.UseForeColor = true;
            this.txtTimKiem.Size = new System.Drawing.Size(153, 24);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.EditValueChanged += new System.EventHandler(this.txtTimKiem_EditValueChanged);
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            // 
            // cboLoaiSP
            // 
            this.cboLoaiSP.Location = new System.Drawing.Point(54, 60);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboLoaiSP.Properties.Appearance.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.cboLoaiSP.Properties.Appearance.Options.UseFont = true;
            this.cboLoaiSP.Properties.Appearance.Options.UseForeColor = true;
            this.cboLoaiSP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLoaiSP.Properties.NullText = "Danh Mục";
            this.cboLoaiSP.Size = new System.Drawing.Size(100, 24);
            this.cboLoaiSP.TabIndex = 0;
            this.cboLoaiSP.SelectedIndexChanged += new System.EventHandler(this.cboLoaiSP_SelectedIndexChanged);
            // 
            // flpDanhSach
            // 
            this.flpDanhSach.AutoScroll = true;
            this.flpDanhSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpDanhSach.Location = new System.Drawing.Point(0, 175);
            this.flpDanhSach.Name = "flpDanhSach";
            this.flpDanhSach.Size = new System.Drawing.Size(723, 357);
            this.flpDanhSach.TabIndex = 2;
            // 
            // SanPhamUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.Controls.Add(this.flpDanhSach);
            this.Controls.Add(this.panelTop);
            this.Name = "SanPhamUC";
            this.Size = new System.Drawing.Size(723, 532);
            this.Load += new System.EventHandler(this.SanPhamUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelTop)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiSP.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelTop;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.TextEdit txtTimKiem;
        private DevExpress.XtraEditors.ComboBoxEdit cboLoaiSP;
        private System.Windows.Forms.FlowLayoutPanel flpDanhSach;
        private DevExpress.XtraEditors.ComboBoxEdit cboLoaiSanPham;
    }
}
