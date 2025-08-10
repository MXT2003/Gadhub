using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLCongNghe.DataAccess;

namespace QLCongNghe.Forms
{
    public partial class SanPhamUC : UserControl
    {
        public SanPhamUC()
        {
            InitializeComponent();
            LoadDanhMuc();
            LoadDanhSachSanPham();
            cboLoaiSanPham.Enabled = false;
        }

        private void SanPhamUC_Load(object sender, EventArgs e)
        {
            
        }
        private void Pic_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            string maSP = pic.Tag.ToString();

            FormChiTietSanPham frm = new FormChiTietSanPham(maSP);
            frm.FormClosed += (s, args) => LoadDanhSachSanPham(); // reload khi có sửa đổi
            frm.ShowDialog();
        }
        private void LoadDanhMuc()
        {
            cboLoaiSP.Properties.Items.Clear();
            cboLoaiSP.Properties.Items.Add("Tất cả"); // ✅ Thêm tùy chọn "Tất cả"
            cboLoaiSP.SelectedIndex = 0;

            string sql = "SELECT DISTINCT TenDanhMuc FROM LoaiSP";
            DataTable dt = DatabaseHelper.GetData(sql);

            foreach (DataRow row in dt.Rows)
            {
                cboLoaiSP.Properties.Items.Add(row["TenDanhMuc"].ToString());
            }

            // Load lại sản phẩm mặc định là tất cả
            LoadDanhSachSanPham();
        }

        private void cboLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string danhMuc = cboLoaiSP.Text;

            cboLoaiSanPham.Properties.Items.Clear();
            cboLoaiSanPham.Text = "";
            cboLoaiSanPham.Enabled = false;

            if (danhMuc == "Tất cả")
            {
                LoadDanhSachSanPham();  // ✅ Hiển thị toàn bộ
                return;
            }

            string sql = $"SELECT TenLoai FROM LoaiSP WHERE TenDanhMuc = N'{danhMuc}'";
            DataTable dt = DatabaseHelper.GetData(sql);

            foreach (DataRow row in dt.Rows)
            {
                cboLoaiSanPham.Properties.Items.Add(row["TenLoai"].ToString());
            }

            if (cboLoaiSanPham.Properties.Items.Count > 0)
            {
                cboLoaiSanPham.Enabled = true;
                cboLoaiSanPham.SelectedIndex = 0;
            }
        }
        private void cboLoaiSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            string loai = cboLoaiSanPham.Text;
            if (!string.IsNullOrWhiteSpace(loai))
            {
                LoadDanhSachSanPham(loai);
            }
        }

        private void LoadDanhSachSanPham(string tenLoai = "")
        {
            flpDanhSach.Controls.Clear();
            string sql = "SELECT * FROM SanPham";
            if (!string.IsNullOrWhiteSpace(tenLoai))
            {
                sql = @"
                    SELECT sp.* 
                    FROM SanPham sp
                    JOIN LoaiSP loai ON sp.MaLoai = loai.MaLoai
                    WHERE loai.TenLoai = N'" + tenLoai + "'"; //  Cột "Loai" trong bảng SanPham
            }
            DataTable dt = DatabaseHelper.GetData(sql);

            foreach (DataRow row in dt.Rows)
            {
                Panel panel = new Panel
                {
                    Width = 160,
                    Height = 240,
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10)
                };
                string imagePath = Path.Combine("Images", row["HinhAnh"].ToString());
                if (!File.Exists(imagePath))
                {
                    imagePath = Path.Combine("Images", "default.png");
                }
                PictureBox pic = new PictureBox
                {   
                    Width = 140,
                    Height = 140,
                    Top = 5,
                    Left = 10,
                    Image = Image.FromFile(@"Images\" + row["HinhAnh"]),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Cursor = Cursors.Hand,
                    Tag = row["MaSP"].ToString()
                };
                pic.Click += Pic_Click;

                LabelControl lblTen = new LabelControl
                {
                    Text = row["TenSP"].ToString(),
                    Appearance = { Font = new Font("Segoe UI", 10, FontStyle.Bold) },
                    AutoSizeMode = LabelAutoSizeMode.Vertical,
                    Dock = DockStyle.Bottom,
                    Padding = new Padding(3)
                };

                LabelControl lblGia = new LabelControl
                {
                    Text = string.Format("{0:N0} VNĐ", row["DonGia"]),
                    Appearance = { Font = new Font("Segoe UI", 9), ForeColor = Color.DarkOrange },
                    Dock = DockStyle.Bottom,
                    Padding = new Padding(3)
                };

                panel.Controls.Add(pic);
                panel.Controls.Add(lblTen);
                panel.Controls.Add(lblGia);
                flpDanhSach.Controls.Add(panel);

                // Dock các controls xuống dưới
                lblTen.Dock = DockStyle.Bottom;
                lblGia.Dock = DockStyle.Bottom;

                flpDanhSach.Controls.Add(panel);
            }
            if (dt.Rows.Count == 0)
            {
                Label lbl = new Label
                {
                    Text = "Hiện chưa có sản phẩm nào.",
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    Dock = DockStyle.Top
                };
                flpDanhSach.Controls.Add(lbl);
                return;
            }
            // Cấu hình flpDanhSach để scroll và wrap đẹp hơn
            flpDanhSach.AutoScroll = true;
            flpDanhSach.WrapContents = true;
            flpDanhSach.FlowDirection = FlowDirection.LeftToRight;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemSanPham form = new FormThemSanPham();
            form.FormClosed += (s, args) => LoadDanhSachSanPham();  // Reload sau khi thêm
            form.ShowDialog();
        }
        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Ngăn tiếng beep
                ThucHienTimKiem(txtTimKiem.Text.Trim());
            }
        }
        private void ThucHienTimKiem(string tuKhoa)
        {
            flpDanhSach.Controls.Clear();

            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                LoadDanhSachSanPham(); // Nếu không nhập gì, load lại toàn bộ
                return;
            }

            string sql = @"
        SELECT * FROM SanPham
        WHERE TenSP LIKE N'%" + tuKhoa + @"%'";

            DataTable dt = DatabaseHelper.GetData(sql);

            if (dt.Rows.Count == 0)
            {
                Label lbl = new Label
                {
                    Text = $"Không tìm thấy sản phẩm nào với từ khóa \"{tuKhoa}\".",
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    Dock = DockStyle.Top
                };
                flpDanhSach.Controls.Add(lbl);
                return;
            }

            // Nếu có kết quả, hiển thị sản phẩm giống như LoadDanhSachSanPham
            foreach (DataRow row in dt.Rows)
            {
                Panel panel = new Panel
                {
                    Width = 160,
                    Height = 240,
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10)
                };

                string imagePath = Path.Combine("Images", row["HinhAnh"].ToString());
                if (!File.Exists(imagePath))
                {
                    imagePath = Path.Combine("Images", "default.png");
                }

                PictureBox pic = new PictureBox
                {
                    Width = 140,
                    Height = 140,
                    Top = 5,
                    Left = 10,
                    Image = Image.FromFile(imagePath),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Cursor = Cursors.Hand,
                    Tag = row["MaSP"].ToString()
                };
                pic.Click += Pic_Click;

                LabelControl lblTen = new LabelControl
                {
                    Text = row["TenSP"].ToString(),
                    Appearance = { Font = new Font("Segoe UI", 10, FontStyle.Bold) },
                    AutoSizeMode = LabelAutoSizeMode.Vertical,
                    Dock = DockStyle.Bottom,
                    Padding = new Padding(3)
                };

                LabelControl lblGia = new LabelControl
                {
                    Text = string.Format("{0:N0} VNĐ", row["DonGia"]),
                    Appearance = { Font = new Font("Segoe UI", 9), ForeColor = Color.DarkOrange },
                    Dock = DockStyle.Bottom,
                    Padding = new Padding(3)
                };

                panel.Controls.Add(pic);
                panel.Controls.Add(lblTen);
                panel.Controls.Add(lblGia);
                flpDanhSach.Controls.Add(panel);
            }
        }
        private void txtTimKiem_EditValueChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(tuKhoa))
            {
                LoadDanhSachSanPham(); // Trở về danh sách ban đầu
            }
        }

    }
}
