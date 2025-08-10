using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization; 
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLCongNghe.DataAccess;
using QLCongNghe.DTO;

namespace QLCongNghe.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
            this.CancelButton = btnClose;

            // ✅ Tắt bộ gõ tiếng Việt
            txtUsername.ImeMode = ImeMode.Disable;
            this.Load += new System.EventHandler(this.LoginForm_Load);

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
            // Có thể đặt con trỏ vào ô username ngay khi form hiển thị
            txtUsername.Focus();
        }

        // ✅ Chặn ký tự có dấu hoặc đặc biệt
        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn nhập
            }
        }
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            var edit = sender as DevExpress.XtraEditors.TextEdit;
            string input = edit.Text;
            string noDiacritics = RemoveDiacritics(input);
            string clean = new string(noDiacritics.Where(c => char.IsLetterOrDigit(c)).ToArray());

            if (edit.Text != clean)
            {
                int caret = edit.SelectionStart;
                edit.Text = clean;
                edit.SelectionStart = Math.Min(caret, clean.Length);
            }
        }

        private string RemoveDiacritics(string text)
        {
            string normalized = text.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();

            foreach (char c in normalized)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(c);
                }
            }

            return sb.ToString().Normalize(NormalizationForm.FormC);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtUsername.Text.Trim();
            string matKhau = txtPassword.Text.Trim();
            string hashMatKhau = HashHelper.ComputeSha256Hash(matKhau);

            string sql = $@"
                SELECT TK.MaNV, TK.VaiTro, NV.TenNV, NV.HinhAnh
                FROM TaiKhoan TK
                JOIN NhanVien NV ON TK.MaNV = NV.MaNV
                WHERE TK.TenDangNhap COLLATE Latin1_General_CS_AS = '{tenDangNhap}'
                AND TK.MatKhau = '{hashMatKhau}'";

            DataTable dt = DatabaseHelper.GetData(sql);

            if (dt.Rows.Count > 0)
            {
                var row = dt.Rows[0];
                Session.MaNhanVien = row["MaNV"].ToString();
                Session.VaiTro = row["VaiTro"].ToString();
                Session.TenNhanVien = row["TenNV"].ToString();

                Session.HinhAnh = row["HinhAnh"] != DBNull.Value ? row["HinhAnh"] as byte[] : null;

                this.Hide();
                MainForm main = new MainForm();
                main.ShowDialog();
                this.Show();
            }
            else
            {
                XtraMessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
