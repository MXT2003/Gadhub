// ------------------- FormDoiMatKhau.cs -------------------
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLCongNghe.DataAccess;
using QLCongNghe.DTO;

namespace QLCongNghe.Forms
{
    public partial class FormDoiMatKhau : Form
    {
        private string maNV;
        private bool isAdminMode;

        public FormDoiMatKhau(string maNV, bool isAdminMode = false)
        {
            InitializeComponent();
            this.maNV = maNV;
            this.isAdminMode = isAdminMode;
        }

        private void FormDoiMatKhau_Load(object sender, EventArgs e)
        {
            lblMatKhauCu.Visible = txtMatKhauCu.Visible = !isAdminMode;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string matKhauCu = txtMatKhauCu.Text.Trim();
            string matKhauMoi = txtMatKhauMoi.Text.Trim();
            string nhapLai = txtNhapLai.Text.Trim();

            if (string.IsNullOrWhiteSpace(matKhauMoi) || string.IsNullOrWhiteSpace(nhapLai))
            {
                XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (matKhauMoi != nhapLai)
            {
                XtraMessageBox.Show("Mật khẩu mới và nhập lại không khớp.");
                return;
            }

            if (!isAdminMode)
            {
                string hashCu = HashHelper.ComputeSha256Hash(matKhauCu);
                string sqlCheck = "SELECT COUNT(*) FROM TaiKhoan WHERE MaNV = @MaNV AND MatKhau = @MatKhau";
                var paramCheck = new Dictionary<string, object>
                {
                    {"@MaNV", maNV},
                    {"@MatKhau", hashCu}
                };
                int count = Convert.ToInt32(DatabaseHelper.ExecuteScalar(sqlCheck, paramCheck));

                if (count == 0)
                {
                    XtraMessageBox.Show("Mật khẩu hiện tại không đúng.");
                    return;
                }
            }

            string hashMoi = HashHelper.ComputeSha256Hash(matKhauMoi);
            string sqlUpdate = "UPDATE TaiKhoan SET MatKhau = @MatKhau WHERE MaNV = @MaNV";
            var param = new Dictionary<string, object>
            {
                {"@MaNV", maNV},
                {"@MatKhau", hashMoi}
            };

            DatabaseHelper.Execute(sqlUpdate, param);
            XtraMessageBox.Show("Đổi mật khẩu thành công!");
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
