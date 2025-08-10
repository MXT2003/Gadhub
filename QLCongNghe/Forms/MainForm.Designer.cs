namespace QLCongNghe.Forms
{
    partial class MainForm
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
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnBaoCao = new DevExpress.XtraEditors.SimpleButton();
            this.lblTenNguoiDung = new DevExpress.XtraEditors.LabelControl();
            this.lblVaiTro = new DevExpress.XtraEditors.LabelControl();
            this.pictureAvatar = new DevExpress.XtraEditors.PictureEdit();
            this.calendarControl1 = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnBackup = new DevExpress.XtraEditors.SimpleButton();
            this.btnDangXuat = new DevExpress.XtraEditors.SimpleButton();
            this.panelMenu = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarMenu = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemTrangChu = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemDonHang = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemSanPham = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemKhachHang = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarAdmin = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemThongKe = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemQLNV = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarCaiDat = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemCaiDat = new DevExpress.XtraNavBar.NavBarItem();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelRight.Controls.Add(this.btnBaoCao);
            this.panelRight.Controls.Add(this.lblTenNguoiDung);
            this.panelRight.Controls.Add(this.lblVaiTro);
            this.panelRight.Controls.Add(this.pictureAvatar);
            this.panelRight.Controls.Add(this.calendarControl1);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.panelRight.Location = new System.Drawing.Point(876, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(200, 450);
            this.panelRight.TabIndex = 1;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBaoCao.Appearance.Options.UseFont = true;
            this.btnBaoCao.Location = new System.Drawing.Point(40, 173);
            this.btnBaoCao.LookAndFeel.SkinName = "Money Twins";
            this.btnBaoCao.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(103, 36);
            this.btnBaoCao.TabIndex = 5;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // lblTenNguoiDung
            // 
            this.lblTenNguoiDung.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenNguoiDung.Appearance.ForeColor = System.Drawing.Color.LightPink;
            this.lblTenNguoiDung.Appearance.Options.UseFont = true;
            this.lblTenNguoiDung.Appearance.Options.UseForeColor = true;
            this.lblTenNguoiDung.Location = new System.Drawing.Point(40, 114);
            this.lblTenNguoiDung.Name = "lblTenNguoiDung";
            this.lblTenNguoiDung.Size = new System.Drawing.Size(104, 21);
            this.lblTenNguoiDung.TabIndex = 3;
            this.lblTenNguoiDung.Text = "labelControl1";
            // 
            // lblVaiTro
            // 
            this.lblVaiTro.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblVaiTro.Appearance.ForeColor = System.Drawing.Color.LightPink;
            this.lblVaiTro.Appearance.Options.UseFont = true;
            this.lblVaiTro.Appearance.Options.UseForeColor = true;
            this.lblVaiTro.Location = new System.Drawing.Point(49, 141);
            this.lblVaiTro.Name = "lblVaiTro";
            this.lblVaiTro.Size = new System.Drawing.Size(83, 17);
            this.lblVaiTro.TabIndex = 4;
            this.lblVaiTro.Text = "labelControl1";
            // 
            // pictureAvatar
            // 
            this.pictureAvatar.Location = new System.Drawing.Point(40, 12);
            this.pictureAvatar.Name = "pictureAvatar";
            this.pictureAvatar.Properties.AllowFocused = false;
            this.pictureAvatar.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureAvatar.Properties.Appearance.Options.UseBackColor = true;
            this.pictureAvatar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureAvatar.Properties.OptionsMask.MaskType = DevExpress.XtraEditors.Controls.PictureEditMaskType.Circle;
            this.pictureAvatar.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureAvatar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureAvatar.Size = new System.Drawing.Size(103, 96);
            this.pictureAvatar.TabIndex = 2;
            // 
            // calendarControl1
            // 
            this.calendarControl1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calendarControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.calendarControl1.Location = new System.Drawing.Point(0, 215);
            this.calendarControl1.Name = "calendarControl1";
            this.calendarControl1.Size = new System.Drawing.Size(200, 235);
            this.calendarControl1.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Pink;
            this.panelMain.Location = new System.Drawing.Point(153, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(721, 450);
            this.panelMain.TabIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnBackup);
            this.panelControl1.Controls.Add(this.btnDangXuat);
            this.panelControl1.Controls.Add(this.panelMenu);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(147, 450);
            this.panelControl1.TabIndex = 3;
            // 
            // btnBackup
            // 
            this.btnBackup.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btnBackup.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBackup.Appearance.ForeColor = System.Drawing.Color.LightPink;
            this.btnBackup.Appearance.Options.UseBackColor = true;
            this.btnBackup.Appearance.Options.UseFont = true;
            this.btnBackup.Appearance.Options.UseForeColor = true;
            this.btnBackup.Location = new System.Drawing.Point(2, 354);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(145, 35);
            this.btnBackup.TabIndex = 6;
            this.btnBackup.Text = "SAO LƯU DỮ LIỆU";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangXuat.Appearance.ForeColor = System.Drawing.Color.LightPink;
            this.btnDangXuat.Appearance.Options.UseFont = true;
            this.btnDangXuat.Appearance.Options.UseForeColor = true;
            this.btnDangXuat.ImageOptions.Image = global::QLCongNghe.Properties.Resources.exit;
            this.btnDangXuat.Location = new System.Drawing.Point(12, 393);
            this.btnDangXuat.LookAndFeel.SkinName = "Office 2016 Black";
            this.btnDangXuat.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(130, 32);
            this.btnDangXuat.TabIndex = 5;
            this.btnDangXuat.Text = "ĐĂNG XUẤT";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.ActiveGroup = this.navBarMenu;
            this.panelMenu.Appearance.Background.BackColor = System.Drawing.Color.Black;
            this.panelMenu.Appearance.Background.Options.UseBackColor = true;
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarMenu,
            this.navBarAdmin,
            this.navBarCaiDat});
            this.panelMenu.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItemTrangChu,
            this.navBarItemDonHang,
            this.navBarItemSanPham,
            this.navBarItemKhachHang,
            this.navBarItemThongKe,
            this.navBarItemQLNV,
            this.navBarItemCaiDat});
            this.panelMenu.Location = new System.Drawing.Point(2, 2);
            this.panelMenu.LookAndFeel.SkinMaskColor = System.Drawing.Color.Transparent;
            this.panelMenu.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Black;
            this.panelMenu.LookAndFeel.SkinName = "Office 2016 Black";
            this.panelMenu.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.OptionsNavPane.ExpandedWidth = 145;
            this.panelMenu.Size = new System.Drawing.Size(145, 446);
            this.panelMenu.TabIndex = 4;
            this.panelMenu.Text = "navBarControl1";
            // 
            // navBarMenu
            // 
            this.navBarMenu.Appearance.BackColor = System.Drawing.Color.Black;
            this.navBarMenu.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.navBarMenu.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.navBarMenu.Appearance.Options.UseBackColor = true;
            this.navBarMenu.Appearance.Options.UseFont = true;
            this.navBarMenu.AppearanceBackground.BackColor = System.Drawing.Color.Black;
            this.navBarMenu.AppearanceBackground.Options.UseBackColor = true;
            this.navBarMenu.Caption = "CHỨC NĂNG";
            this.navBarMenu.Expanded = true;
            this.navBarMenu.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemTrangChu),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemDonHang),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemSanPham),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemKhachHang)});
            this.navBarMenu.Name = "navBarMenu";
            // 
            // navBarItemTrangChu
            // 
            this.navBarItemTrangChu.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.navBarItemTrangChu.Appearance.ForeColor = System.Drawing.Color.LightPink;
            this.navBarItemTrangChu.Appearance.Options.UseFont = true;
            this.navBarItemTrangChu.Appearance.Options.UseForeColor = true;
            this.navBarItemTrangChu.Caption = "TRANG CHỦ";
            this.navBarItemTrangChu.Name = "navBarItemTrangChu";
            this.navBarItemTrangChu.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemTrangChu_LinkClicked);
            // 
            // navBarItemDonHang
            // 
            this.navBarItemDonHang.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.navBarItemDonHang.Appearance.ForeColor = System.Drawing.Color.LightPink;
            this.navBarItemDonHang.Appearance.Options.UseFont = true;
            this.navBarItemDonHang.Appearance.Options.UseForeColor = true;
            this.navBarItemDonHang.Caption = "ĐƠN HÀNG";
            this.navBarItemDonHang.Name = "navBarItemDonHang";
            this.navBarItemDonHang.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemDonHang_LinkClicked);
            // 
            // navBarItemSanPham
            // 
            this.navBarItemSanPham.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.navBarItemSanPham.Appearance.ForeColor = System.Drawing.Color.LightPink;
            this.navBarItemSanPham.Appearance.Options.UseFont = true;
            this.navBarItemSanPham.Appearance.Options.UseForeColor = true;
            this.navBarItemSanPham.Caption = "SẢN PHẨM";
            this.navBarItemSanPham.Name = "navBarItemSanPham";
            this.navBarItemSanPham.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemSanPham_LinkClicked);
            // 
            // navBarItemKhachHang
            // 
            this.navBarItemKhachHang.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.navBarItemKhachHang.Appearance.ForeColor = System.Drawing.Color.LightPink;
            this.navBarItemKhachHang.Appearance.Options.UseFont = true;
            this.navBarItemKhachHang.Appearance.Options.UseForeColor = true;
            this.navBarItemKhachHang.Caption = "KHÁCH HÀNG";
            this.navBarItemKhachHang.Name = "navBarItemKhachHang";
            this.navBarItemKhachHang.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemKhachHang_LinkClicked);
            // 
            // navBarAdmin
            // 
            this.navBarAdmin.Appearance.BackColor = System.Drawing.Color.Black;
            this.navBarAdmin.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.navBarAdmin.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.navBarAdmin.Appearance.Options.UseBackColor = true;
            this.navBarAdmin.Appearance.Options.UseFont = true;
            this.navBarAdmin.Caption = "QUẢN LÝ";
            this.navBarAdmin.Expanded = true;
            this.navBarAdmin.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemThongKe),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemQLNV)});
            this.navBarAdmin.Name = "navBarAdmin";
            // 
            // navBarItemThongKe
            // 
            this.navBarItemThongKe.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.navBarItemThongKe.Appearance.ForeColor = System.Drawing.Color.LightPink;
            this.navBarItemThongKe.Appearance.Options.UseFont = true;
            this.navBarItemThongKe.Appearance.Options.UseForeColor = true;
            this.navBarItemThongKe.Caption = "THỐNG KÊ";
            this.navBarItemThongKe.Name = "navBarItemThongKe";
            this.navBarItemThongKe.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemThongKe_LinkClicked);
            // 
            // navBarItemQLNV
            // 
            this.navBarItemQLNV.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.navBarItemQLNV.Appearance.ForeColor = System.Drawing.Color.LightPink;
            this.navBarItemQLNV.Appearance.Options.UseFont = true;
            this.navBarItemQLNV.Appearance.Options.UseForeColor = true;
            this.navBarItemQLNV.Caption = "QUẢN LÝ NHÂN VIÊN";
            this.navBarItemQLNV.Name = "navBarItemQLNV";
            this.navBarItemQLNV.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemQLNV_LinkClicked);
            // 
            // navBarCaiDat
            // 
            this.navBarCaiDat.Caption = "";
            this.navBarCaiDat.Expanded = true;
            this.navBarCaiDat.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemCaiDat)});
            this.navBarCaiDat.Name = "navBarCaiDat";
            // 
            // navBarItemCaiDat
            // 
            this.navBarItemCaiDat.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.navBarItemCaiDat.Appearance.ForeColor = System.Drawing.Color.LightPink;
            this.navBarItemCaiDat.Appearance.Options.UseFont = true;
            this.navBarItemCaiDat.Appearance.Options.UseForeColor = true;
            this.navBarItemCaiDat.Caption = "CÀI ĐẶT";
            this.navBarItemCaiDat.Name = "navBarItemCaiDat";
            this.navBarItemCaiDat.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemCaiDat_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 450);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelMain;
        private DevExpress.XtraEditors.Controls.CalendarControl calendarControl1;
        private DevExpress.XtraEditors.PictureEdit pictureAvatar;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraNavBar.NavBarControl panelMenu;
        private DevExpress.XtraNavBar.NavBarGroup navBarMenu;
        private DevExpress.XtraNavBar.NavBarItem navBarItemTrangChu;
        private DevExpress.XtraNavBar.NavBarItem navBarItemDonHang;
        private DevExpress.XtraNavBar.NavBarItem navBarItemSanPham;
        private DevExpress.XtraNavBar.NavBarItem navBarItemKhachHang;
        private DevExpress.XtraNavBar.NavBarGroup navBarAdmin;
        private DevExpress.XtraNavBar.NavBarItem navBarItemThongKe;
        private DevExpress.XtraNavBar.NavBarItem navBarItemQLNV;
        private DevExpress.XtraNavBar.NavBarGroup navBarCaiDat;
        private DevExpress.XtraNavBar.NavBarItem navBarItemCaiDat;
        private DevExpress.XtraEditors.SimpleButton btnDangXuat;
        private DevExpress.XtraEditors.LabelControl lblVaiTro;
        private DevExpress.XtraEditors.LabelControl lblTenNguoiDung;
        private DevExpress.XtraEditors.SimpleButton btnBackup;
        private DevExpress.XtraEditors.SimpleButton btnBaoCao;
    }
}