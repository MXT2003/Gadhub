using GadHubMAUI.Models;

namespace GadHubMAUI.Views
{
    public partial class ChiTietDonHangPage : ContentPage
    {
        private string maHD;
        private HoaDonDTO hoaDon;
        private List<ChiTietHoaDonDTO> chiTietList = new List<ChiTietHoaDonDTO>();

        public ChiTietDonHangPage(string maHD)
        {
            InitializeComponent();
            this.maHD = maHD;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await LoadThongTinDonHang();
            await LoadChiTietDonHang();
        }

        private async Task LoadThongTinDonHang()
        {
            try
            {
                // Mock data cho hóa đơn
                hoaDon = new HoaDonDTO
                {
                    MaHD = maHD,
                    MaKH = "KH001",
                    MaNV = "NV001",
                    NgayLap = DateTime.Now.AddDays(-1),
                    GiaTien = 35000000,
                    TenKH = "Nguyễn Văn An",
                    TenNV = "Trương Văn Admin"
                };

                // Hiển thị thông tin đơn hàng
                lblMaHD.Text = hoaDon.MaHD;
                lblNgayLap.Text = hoaDon.NgayLap.ToString("dd/MM/yyyy HH:mm");
                lblKhachHang.Text = hoaDon.TenKH;
                lblNhanVien.Text = hoaDon.TenNV;
                lblTongTien.Text = $"{hoaDon.GiaTien:#,##0} VNĐ";
            }
            catch (Exception ex)
            {
                await DisplayAlert("Lỗi", $"Không thể tải thông tin đơn hàng: {ex.Message}", "OK");
            }
        }

        private async Task LoadChiTietDonHang()
        {
            try
            {
                // Mock data cho chi tiết hóa đơn
                chiTietList = new List<ChiTietHoaDonDTO>
                {
                    new ChiTietHoaDonDTO
                    {
                        MaHD = maHD,
                        MaSP = "SP001",
                        SoLuong = 1,
                        DonGia = 35000000,
                        TenSP = "iPhone 15 Pro Max"
                    }
                };

                cvChiTietDonHang.ItemsSource = chiTietList;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Lỗi", $"Không thể tải chi tiết đơn hàng: {ex.Message}", "OK");
            }
        }

        private async void btnInHoaDon_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Thông báo", "Chức năng in hóa đơn đang được phát triển", "OK");
        }
    }
}