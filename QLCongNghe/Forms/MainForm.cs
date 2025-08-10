using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using QLCongNghe.DataAccess;
using QLCongNghe.DTO;
using QLCongNghe.Reports;

namespace QLCongNghe.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string role = Session.VaiTro?.Trim().ToLower(); // trim + lowercase cho chắc

            var args = new XtraMessageBoxArgs()
            {
                Caption = "Thông báo hệ thống",
                Text = "Vai trò hiện tại: " + role,
                Buttons = new DialogResult[] { DialogResult.OK },
                Icon = SystemIcons.Information,
                DefaultButtonIndex = 0
            };

         
            XtraMessageBox.Show(args);
            if (role == "admin")
            {
                navBarMenu.Visible = true;
                navBarAdmin.Visible = true;
                navBarCaiDat.Visible = true;
            }
            else if (role == "nhanvien")
            {
                navBarMenu.Visible = true;
                navBarAdmin.Visible = false;
                navBarCaiDat.Visible = true;
            }
            CapNhatThongTinNguoiDung();
            // Load mặc định: Dashboard
            LoadForm(new DashboardUC());
            btnBackup.Visible = Session.VaiTro == "admin";
            btnBaoCao.Visible = Session.VaiTro?.Trim().ToLower() == "admin";

        }
        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            new FormBaoCaoDoanhThuThang().ShowDialog();
        }

        public void CapNhatAvatar()
        {
            if (Session.HinhAnh != null)
            {
                using (var ms = new MemoryStream(Session.HinhAnh))
                {
                    Image img = Image.FromStream(ms);
                    pictureAvatar.Image = ResizeImage(img, 64, 64); // Kích thước avatar
                }
            }
        }
        public void CapNhatThongTinNguoiDung()
        {
            // Cập nhật tên và vai trò
            lblTenNguoiDung.Text = Session.TenNhanVien;
            lblVaiTro.Text = Session.VaiTro;

            // Cập nhật ảnh
            CapNhatAvatar();
        }


        Image ResizeImage(Image image, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawImage(image, 0, 0, width, height);
            }
            return bmp;
        }
        private void LoadForm(UserControl uc)
        {
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }
        private void navBarItemTrangChu_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            LoadForm(new DashboardUC());
        }

        private void navBarItemSanPham_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            LoadForm(new SanPhamUC());
        }
        private void navBarItemDonHang_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            LoadForm(new DonHangUC());
        }
        private void navBarItemKhachHang_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            LoadForm(new KhachHangUC());
        }
        private void navBarItemThongKe_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            LoadForm(new ThongKeUC());
        }
        private void navBarItemQLNV_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            LoadForm(new QLNhanVienUC());
        }
        private void navBarItemCaiDat_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            LoadForm(new CaiDatUC());
        }
        private void navBarMenu_Click(object sender, EventArgs e)
        {
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DangXuat();
        }
        private void DangXuat()
        {
            // Hiển thị xác nhận trước khi đăng xuất
            var result = XtraMessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();  // Ẩn MainForm
                Session.TenNhanVien = null;
                Session.VaiTro = null;
                Session.MaNhanVien = null;

                LoginForm login = new LoginForm();
                login.ShowDialog();
                this.Close(); // Đóng MainForm sau khi LoginForm được đóng
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Chọn nơi lưu file backup";
            
            saveFileDialog.Filter = "Backup Files (*.bak)|*.bak";
            saveFileDialog.FileName = "Backup_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".bak";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string backupPath = saveFileDialog.FileName;
                string databaseName = "QLCH";

                string sql = $@"BACKUP DATABASE [{databaseName}] TO DISK = N'{backupPath}' WITH INIT";

                try
                {
                    using (SqlConnection conn = new SqlConnection(DatabaseHelper.connectionString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }

                    XtraMessageBox.Show("Sao lưu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi sao lưu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // ✅ Thoát toàn bộ ứng dụng
        }

    }
}
