using GadHubMAUI.Models;

namespace GadHubMAUI.Views
{
    public partial class KhachHangPage : ContentPage
    {
        private List<KhachHangDTO> allKhachHang = new List<KhachHangDTO>();

        public KhachHangPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            LoadDanhSachKhachHang();
        }

        private void LoadDanhSachKhachHang()
        {
            // Dữ liệu tĩnh cho khách hàng
            allKhachHang = new List<KhachHangDTO>
            {
                new KhachHangDTO { MaKH = "KH001", TenKH = "Nguyễn Văn An", SDT = "0901234567", DiaChi = "123 Đường ABC, Quận 1, TP.HCM" },
                new KhachHangDTO { MaKH = "KH002", TenKH = "Trần Thị Bình", SDT = "0912345678", DiaChi = "456 Đường XYZ, Quận 2, TP.HCM" },
                new KhachHangDTO { MaKH = "KH003", TenKH = "Lê Văn Cường", SDT = "0923456789", DiaChi = "789 Đường DEF, Quận 3, TP.HCM" },
                new KhachHangDTO { MaKH = "KH004", TenKH = "Phạm Thị Dung", SDT = "0934567890", DiaChi = "321 Đường GHI, Quận 4, TP.HCM" },
                new KhachHangDTO { MaKH = "KH005", TenKH = "Hoàng Văn Em", SDT = "0945678901", DiaChi = "654 Đường JKL, Quận 5, TP.HCM" }
            };

            cvKhachHang.ItemsSource = allKhachHang;
        }

        private void searchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            ThucHienTimKiem(searchBar.Text);
        }

        private void searchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                cvKhachHang.ItemsSource = allKhachHang;
            }
        }

        private void ThucHienTimKiem(string tuKhoa)
        {
            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                cvKhachHang.ItemsSource = allKhachHang;
                return;
            }

            var ketQua = allKhachHang.Where(kh => 
                kh.TenKH.ToLower().Contains(tuKhoa.ToLower()) ||
                kh.SDT.Contains(tuKhoa) ||
                kh.DiaChi.ToLower().Contains(tuKhoa.ToLower()))
                .ToList();

            cvKhachHang.ItemsSource = ketQua;
        }

        private async void KhachHang_Tapped(object sender, TappedEventArgs e)
        {
            string maKH = e.Parameter.ToString();
            var khachHang = allKhachHang.FirstOrDefault(kh => kh.MaKH == maKH);
            
            if (khachHang != null)
            {
                await DisplayAlert("Thông tin khách hàng", 
                    $"Mã KH: {khachHang.MaKH}\n" +
                    $"Tên: {khachHang.TenKH}\n" +
                    $"SĐT: {khachHang.SDT}\n" +
                    $"Địa chỉ: {khachHang.DiaChi}", 
                    "Đóng");
            }
        }

        private async void btnSua_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            string maKH = button.CommandParameter.ToString();
            await DisplayAlert("Thông báo", $"Chức năng sửa khách hàng {maKH} đang được phát triển", "OK");
        }

        private async void btnXoa_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            string maKH = button.CommandParameter.ToString();
            await DisplayAlert("Thông báo", $"Chức năng xóa khách hàng {maKH} đang được phát triển", "OK");
        }

        private async void btnThem_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Thông báo", "Chức năng thêm khách hàng đang được phát triển", "OK");
        }
    }
}