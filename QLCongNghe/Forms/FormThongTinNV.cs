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
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLCongNghe.DataAccess;

namespace QLCongNghe.Forms
{
    public partial class FormThongTinNV : Form
    {
        private string maNV;
        private bool isEditing = true;
        public FormThongTinNV(string maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
            isEditing = true;

            LoadThongTinNhanVien(maNV);// Hàm để hiển thị dữ liệu lên giao diện
        }
        public FormThongTinNV()
        {
            InitializeComponent();
            // Đây là chế độ thêm mới
            isEditing = false;
        }
        private void LoadThongTinNhanVien(string maNV)
        {
            string sql = @"
        SELECT nv.*, tk.TenDangNhap, tk.VaiTro
        FROM NhanVien nv 
        LEFT JOIN TaiKhoan tk ON nv.MaNV = tk.MaNV 
        WHERE nv.MaNV = '" + maNV + "'";

            DataTable dt = DatabaseHelper.GetData(sql);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtMaNV.Text = row["MaNV"].ToString();
                txtTenNV.Text = row["TenNV"].ToString();
                txtSDT.Text = row["SDT"].ToString();
                txtDiaChi.Text = row["DiaChi"].ToString();
                txtEmail.Text = row["Email"].ToString();
                cboChucVu.Text = row["VaiTro"].ToString();

                // ✅ Load ảnh
                if (row.Table.Columns.Contains("HinhAnh") && row["HinhAnh"] != DBNull.Value)
                {
                    byte[] imageData = row["HinhAnh"] as byte[];
                    using (var ms = new MemoryStream(imageData))
                    {
                        picAnh.Image = Image.FromStream(ms); // ⚠️ picAnh là PictureBox bạn cần đặt đúng tên
                    }
                }
                else
                {
                    picAnh.Image = null;
                }
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string tenNV = txtTenNV.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string email = txtEmail.Text.Trim();
            string chucVu = cboChucVu.Text.Trim();

            // Xử lý ảnh
            byte[] imageData = null;
            if (picAnh.Image != null)
            {
                using (var ms = new MemoryStream())
                {
                    picAnh.Image.Save(ms, picAnh.Image.RawFormat);
                    imageData = ms.ToArray();
                }
            }

            if (isEditing)
            {
                // Cập nhật
                string sql = @"
                            UPDATE NhanVien 
                            SET TenNV = @TenNV, SDT = @SDT, DiaChi = @DiaChi, Email = @Email, HinhAnh = @HinhAnh
                            WHERE MaNV = @MaNV;

                            UPDATE TaiKhoan 
                            SET VaiTro = @VaiTro 
                            WHERE MaNV = @MaNV";

                SqlParameter[] parameters = {
                    new SqlParameter("@TenNV", tenNV),
                    new SqlParameter("@SDT", sdt),
                    new SqlParameter("@DiaChi", diaChi),
                    new SqlParameter("@Email", email),
                    new SqlParameter("@HinhAnh", (object)imageData ?? DBNull.Value),
                    new SqlParameter("@VaiTro", chucVu),
                    new SqlParameter("@MaNV", maNV)
                };

                DatabaseHelper.Execute(sql, parameters);
                XtraMessageBox.Show("Cập nhật thành công!");
            }
            
        }
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            // lấy mã nhân viên từ textbox
            string maNV = txtMaNV.Text.Trim();

            if (!string.IsNullOrEmpty(maNV))
            {
                FormDoiMatKhau doiMK = new FormDoiMatKhau(maNV);
                doiMK.ShowDialog(); // hiện form đổi mật khẩu
            }
            else
            {
                XtraMessageBox.Show("Không có mã nhân viên để đổi mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string sql1 = "DELETE FROM TaiKhoan WHERE MaNV = @MaNV";
                string sql2 = "DELETE FROM NhanVien WHERE MaNV = @MaNV";

                // ⚠️ Tạo parameter riêng biệt cho từng câu lệnh
                SqlParameter[] parameters1 = { new SqlParameter("@MaNV", maNV) };
                SqlParameter[] parameters2 = { new SqlParameter("@MaNV", maNV) };
                DatabaseHelper.Execute(sql1, parameters1);
                DatabaseHelper.Execute(sql2, parameters2);


                XtraMessageBox.Show("Xóa thành công!");
                LoadThongTinNhanVien(maNV);
                this.Close(); // Đóng form sau khi xóa
            }
        }



    }
}
