using GadHubMAUI.Models;
using GadHubMAUI.Views;
using System.Windows.Input;

namespace GadHubMAUI
{
    public partial class AppShell : Shell
    {
        public ICommand LogoutCommand { get; private set; }

        public AppShell()
        {
            InitializeComponent();

            // Hiển thị thông tin người dùng
            UpdateUserInfo();

            // Đăng ký các route cho điều hướng
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(DashboardPage), typeof(DashboardPage));
            Routing.RegisterRoute(nameof(SanPhamPage), typeof(SanPhamPage));
            Routing.RegisterRoute(nameof(KhachHangPage), typeof(KhachHangPage));
            Routing.RegisterRoute(nameof(DonHangPage), typeof(DonHangPage));
            Routing.RegisterRoute(nameof(NhanVienPage), typeof(NhanVienPage));
            Routing.RegisterRoute(nameof(ChiTietSanPhamPage), typeof(ChiTietSanPhamPage));
            Routing.RegisterRoute(nameof(ChiTietKhachHangPage), typeof(ChiTietKhachHangPage));
            Routing.RegisterRoute(nameof(ChiTietDonHangPage), typeof(ChiTietDonHangPage));
            Routing.RegisterRoute(nameof(ThemSanPhamPage), typeof(ThemSanPhamPage));

            // Xử lý đăng xuất
            LogoutCommand = new Command(async () => {
                bool answer = await DisplayAlert("Xác nhận", "Bạn có chắc chắn muốn đăng xuất?", "Đăng xuất", "Hủy");
                if (answer)
                {
                    // Xóa thông tin phiên đăng nhập
                    Session.MaNhanVien = null;
                    Session.TenNhanVien = null;
                    Session.VaiTro = null;
                    Session.HinhAnh = null;

                    // Chuyển về trang đăng nhập
                    await Shell.Current.GoToAsync("//LoginPage");
                }
            });

            BindingContext = this;
        }

        private void UpdateUserInfo()
        {
            if (!string.IsNullOrEmpty(Session.TenNhanVien))
            {
                lblUserInfo.Text = $"{Session.TenNhanVien} ({Session.VaiTro})";
            }
        }
    }
}
