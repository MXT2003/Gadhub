using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLCongNghe.DataAccess;

namespace QLCongNghe.Forms
{
    public partial class FormThemSanPham : Form
    {
        private bool isEditMode = false;
        private string maSP = "";
        private string tenFileAnh = "default.png";

        // ==========================
        // 1. FORM THÊM SẢN PHẨM
        // ==========================
        public FormThemSanPham()
        {
            InitializeComponent();
            this.isEditMode = false;
            this.Text = "Thêm sản phẩm";
            txtMaSP.Text = GenerateMaSP();
            btnThem.Visible = true;
            btnCapNhat.Visible = false;

            LoadDanhMuc();
        }

        // ==========================
        // 2. FORM CẬP NHẬT SẢN PHẨM
        // ==========================
        public FormThemSanPham(string maSP)
        {
            InitializeComponent();
            this.maSP = maSP;
            this.isEditMode = true;
            this.Text = "Cập nhật sản phẩm";
            btnThem.Visible = false;
            btnCapNhat.Visible = true;

            LoadDanhMuc();
            LoadDuLieuSanPham();
        }

        // ==========================
        // TẠO MÃ SP
        // ==========================
        private string GenerateMaSP()
        {
            string rand = Path.GetRandomFileName().Replace(".", "").Substring(0, 3).ToUpper();
            return $"SP{DateTime.Now:ddMyy}{rand}";
        }

        // ==========================
        // LOAD DANH MỤC
        // ==========================
        private void LoadDanhMuc()
        {
            string sql = "SELECT DISTINCT TenDanhMuc FROM LoaiSP";
            DataTable dt = DatabaseHelper.GetData(sql);
            cboLoaiSP.Properties.Items.Clear();
            foreach (DataRow row in dt.Rows)
                cboLoaiSP.Properties.Items.Add(row["TenDanhMuc"].ToString());
        }

        // ==========================
        // LOAD LOẠI SP THEO DANH MỤC
        // ==========================
        private void LoadLoaiSanPhamTheoDanhMuc(string danhMuc)
        {
            string sql = $"SELECT TenLoai FROM LoaiSP WHERE TenDanhMuc = N'{danhMuc}'";
            DataTable dt = DatabaseHelper.GetData(sql);

            cboLoaiSanPham.Properties.Items.Clear();
            cboLoaiSanPham.Text = "";
            cboLoaiSanPham.Enabled = false;

            foreach (DataRow row in dt.Rows)
                cboLoaiSanPham.Properties.Items.Add(row["TenLoai"].ToString());

            if (cboLoaiSanPham.Properties.Items.Count > 0)
                cboLoaiSanPham.Enabled = true;
        }

        private void cboLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLoaiSanPhamTheoDanhMuc(cboLoaiSP.Text);
        }

        // ==========================
        // LOAD DỮ LIỆU CẬP NHẬT
        // ==========================
        private void LoadDuLieuSanPham()
        {
            string sql = $"SELECT * FROM SanPham WHERE MaSP = '{maSP}'";
            var dt = DatabaseHelper.GetData(sql);
            if (dt.Rows.Count > 0)
            {
                var row = dt.Rows[0];
                txtMaSP.Text = row["MaSP"].ToString();
                txtTenSP.Text = row["TenSP"].ToString();
                spinGia.Value = Convert.ToDecimal(row["DonGia"]);
                spinSoLuong.Value = Convert.ToDecimal(row["SoLuongTon"]);
                txtMoTa.Text = row["MoTa"].ToString();
                tenFileAnh = row["HinhAnh"].ToString();

                // 👉 Load danh mục & loại sản phẩm từ MaLoai
                string maLoai = row["MaLoai"].ToString();
                string sqlLoai = $"SELECT TenDanhMuc, TenLoai FROM LoaiSP WHERE MaLoai = '{maLoai}'";
                var dtLoai = DatabaseHelper.GetData(sqlLoai);
                if (dtLoai.Rows.Count > 0)
                {
                    string tenDanhMuc = dtLoai.Rows[0]["TenDanhMuc"].ToString();
                    string tenLoai = dtLoai.Rows[0]["TenLoai"].ToString();

                    cboLoaiSP.Text = tenDanhMuc;
                    LoadLoaiSanPhamTheoDanhMuc(tenDanhMuc);
                    cboLoaiSanPham.Text = tenLoai;
                }

                // Ảnh
                string path = Path.Combine(Application.StartupPath, "Images", tenFileAnh);
                if (File.Exists(path))
                    picSanPham.Image = Image.FromFile(path);

                picSanPham.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            }

            txtMaSP.ReadOnly = true;
        }

        // ==========================
        // CHỌN ẢNH
        // ==========================
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpg; *.png; *.jpeg)|*.jpg;*.png;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                tenFileAnh = Path.GetFileName(filePath);
                string destPath = Path.Combine(Application.StartupPath, "Images", tenFileAnh);

                try
                {
                    if (!File.Exists(destPath))
                        File.Copy(filePath, destPath);

                    picSanPham.Image = Image.FromFile(destPath);
                    picSanPham.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi khi xử lý ảnh: " + ex.Message);
                }
            }
        }

        // ==========================
        // THÊM SẢN PHẨM
        // ==========================
        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenLoai = cboLoaiSanPham.Text;
            string sqlLoai = $"SELECT MaLoai FROM LoaiSP WHERE TenLoai = N'{tenLoai}'";
            DataTable dtLoai = DatabaseHelper.GetData(sqlLoai);

            if (dtLoai.Rows.Count == 0)
            {
                XtraMessageBox.Show("Không tìm thấy mã loại!");
                return;
            }

            string maLoai = dtLoai.Rows[0]["MaLoai"].ToString();

            string sqlInsert = $@"
                INSERT INTO SanPham(MaSP, TenSP, MaLoai, DonGia, SoLuongTon, MoTa, HinhAnh)
                VALUES ('{txtMaSP.Text}', N'{txtTenSP.Text}', '{maLoai}', {spinGia.Value}, {spinSoLuong.Value},
                        N'{txtMoTa.Text}', '{tenFileAnh}')";

            DatabaseHelper.Execute(sqlInsert);
            XtraMessageBox.Show("Thêm sản phẩm thành công!");
            this.Close();
        }

        // ==========================
        // CẬP NHẬT SẢN PHẨM
        // ==========================
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenSP.Text) || cboLoaiSP.Text == "" || cboLoaiSanPham.Text == "")
            {
                XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm.");
                return;
            }

            try
            {
                string tenLoai = cboLoaiSanPham.Text;
                string sqlLoai = $"SELECT MaLoai FROM LoaiSP WHERE TenLoai = N'{tenLoai}'";
                var dtLoai = DatabaseHelper.GetData(sqlLoai);
                if (dtLoai.Rows.Count == 0)
                {
                    XtraMessageBox.Show("Không tìm thấy mã loại!");
                    return;
                }
                string maLoai = dtLoai.Rows[0]["MaLoai"].ToString();

                string sql = $@"
                    UPDATE SanPham SET 
                        TenSP = N'{txtTenSP.Text}', 
                        MaLoai = '{maLoai}', 
                        DonGia = {spinGia.Value}, 
                        SoLuongTon = {spinSoLuong.Value}, 
                        MoTa = N'{txtMoTa.Text}', 
                        HinhAnh = '{tenFileAnh}' 
                    WHERE MaSP = '{maSP}'";

                int rows = DatabaseHelper.Execute(sql);
                if (rows > 0)
                {
                    XtraMessageBox.Show("Cập nhật sản phẩm thành công!");
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("Cập nhật thất bại!");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi cập nhật sản phẩm: " + ex.Message);
            }
        }
    }
}
