using GadHubMAUI.Models;

namespace GadHubMAUI.Views
{
    public partial class DonHangPage : ContentPage
    {
        private List<HoaDonDTO> allDonHang = new List<HoaDonDTO>();

        public DonHangPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            LoadDanhSachDonHang();
        }

        private void LoadDanhSachDonHang()
        {
            // Dữ liệu tĩnh cho đơn hàng
            allDonHang = new List<HoaDonDTO>
            {
                new HoaDonDTO { MaHD = "HD001", MaKH = "KH001", MaNV = "NV001", NgayLap = DateTime.Now.AddDays(-1), GiaTien = 35000000, TenKH = "Nguyễn Văn An", TenNV = "Trương Văn Admin" },
                new HoaDonDTO { MaHD = "HD002", MaKH = "KH002", MaNV = "NV002", NgayLap = DateTime.Now.AddDays(-2), GiaTien = 28000000, TenKH = "Trần Thị Bình", TenNV = "Nguyễn Văn Huy" },
                new HoaDonDTO { MaHD = "HD003", MaKH = "KH003", MaNV = "NV001", NgayLap = DateTime.Now.AddDays(-3), GiaTien = 45000000, TenKH = "Lê Văn Cường", TenNV = "Trương Văn Admin" },
                new HoaDonDTO { MaHD = "HD004", MaKH = "KH004", MaNV = "NV002", NgayLap = DateTime.Now.AddDays(-4), GiaTien = 32000000, TenKH = "Phạm Thị Dung", TenNV = "Nguyễn Văn Huy" },
                new HoaDonDTO { MaHD = "HD005", MaKH = "KH005", MaNV = "NV001", NgayLap = DateTime.Now.AddDays(-5), GiaTien = 6500000, TenKH = "Hoàng Văn Em", TenNV = "Trương Văn Admin" }
            };

            cvDonHang.ItemsSource = allDonHang;
        }

        private void searchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            ThucHienTimKiem(searchBar.Text);
        }

        private void searchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                cvDonHang.ItemsSource = allDonHang;
            }
        }

        private void ThucHienTimKiem(string tuKhoa)
        {
            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                cvDonHang.ItemsSource = allDonHang;
                return;
            }

            var ketQua = allDonHang.Where(dh => 
                dh.MaHD.ToLower().Contains(tuKhoa.ToLower()) ||
                dh.TenKH.ToLower().Contains(tuKhoa.ToLower()) ||
                dh.TenNV.ToLower().Contains(tuKhoa.ToLower()))
                .ToList();

            cvDonHang.ItemsSource = ketQua;
        }

        private async void DonHang_Tapped(object sender, TappedEventArgs e)
        {
            string maHD = e.Parameter.ToString();
            await DisplayAlert("Thông báo", $"Đã chọn đơn hàng {maHD}", "OK");
            // Tại đây có thể mở trang chi tiết đơn hàng
            // await Shell.Current.GoToAsync($"ChiTietDonHangPage?MaHD={maHD}");
        }

        private async void btnThem_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Thông báo", "Chức năng tạo đơn hàng đang được phát triển", "OK");
            // Tại đây có thể mở trang tạo đơn hàng
            // await Shell.Current.GoToAsync("ThemDonHangPage");
        }
    }
}