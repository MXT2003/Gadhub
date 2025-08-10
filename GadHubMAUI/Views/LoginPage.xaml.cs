using GadHubMAUI.Models;
using System.Globalization;
using System.Text;

namespace GadHubMAUI.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            await AttemptLogin();
        }

        private async void txtPassword_Completed(object sender, EventArgs e)
        {
            await AttemptLogin();
        }

        private void txtUsername_Completed(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }

        private async Task AttemptLogin()
        {
            string tenDangNhap = txtUsername.Text?.Trim() ?? "";
            string matKhau = txtPassword.Text?.Trim() ?? "";

            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                await DisplayAlert("Lỗi", "Vui lòng nhập tên đăng nhập và mật khẩu", "OK");
                return;
            }

            // Kiểm tra đăng nhập với dữ liệu cứng
            if ((tenDangNhap == "truong" && matKhau == "1") ||
                (tenDangNhap == "huy" && matKhau == "1"))
            {
                // Thiết lập thông tin phiên đăng nhập
                if (tenDangNhap == "truong")
                {
                    Session.MaNhanVien = "NV001";
                    Session.VaiTro = "Admin";
                    Session.TenNhanVien = "Xuân Trường";
                    Session.HinhAnh = null;
                }
                else
                {
                    Session.MaNhanVien = "NV002";
                    Session.VaiTro = "NhanVien";
                    Session.TenNhanVien = "Đan Huy";
                    Session.HinhAnh = null;
                }

                // Chuyển đến trang chính sau khi đăng nhập thành công
                Application.Current.MainPage = new AppShell();
                await Shell.Current.GoToAsync("//DashboardPage");
            }
            else
            {
                await DisplayAlert("Lỗi", "Sai tên đăng nhập hoặc mật khẩu", "OK");
            }
        }

        private void txtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue))
                return;

            string input = e.NewTextValue;
            string noDiacritics = RemoveDiacritics(input);
            string clean = new string(noDiacritics.Where(c => char.IsLetterOrDigit(c)).ToArray());

            if (txtUsername.Text != clean)
            {
                txtUsername.Text = clean;
                txtUsername.CursorPosition = clean.Length;
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
    }
}